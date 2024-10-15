Imports System.IO.Ports
Imports System.Threading
Public Class SerialComExampleForm
    '*****************Custom Methods*******************************
    ''' <summary>
    ''' Gets a Series of data from the Quiet Board and writes to the output console
    ''' </summary>
    Sub GetQySettings()
        'create an array of bytes with the length of given bytes
        Dim data(SerialPort1.BytesToRead) As Byte
        'populates data with incoming port data starting at 0 bit and reading the full bytes
        SerialPort1.Read(data, 0, SerialPort1.BytesToRead)
        'loops through the data array and writes each item to console (converts to hex)
        For i = 0 To UBound(data)
            Console.Write($"{Hex(data(i))}: ")
            Console.WriteLine(Chr(data(i)))
        Next
    End Sub

    ''' <summary>
    ''' Writes the Given Digital Byte to the Digital Output Pins on the Quiet Board
    ''' </summary>
    ''' <param name="output"></param>
    Sub WriteDigitalOut(output As Byte)
        'create a byte array
        Dim data(1) As Byte
        'populate the byte array
        data(0) = &H20
        data(1) = output
        'write the data byte array starting at bit 0 and sending two bytes
        SerialPort1.Write(data, 0, 2)
    End Sub

    ''' <summary>
    ''' Writes to the Quiet Board Digital Output.  Toggles every other Pin every 0.5S 10 times.
    ''' </summary>
    Sub StartDiscoLights()
        For i = 0 To 10
            WriteDigitalOut(&HAA)
            Thread.Sleep(500)
            WriteDigitalOut(&H55)
            Thread.Sleep(500)
        Next
        WriteDigitalOut(&H0)
    End Sub

    '****************Event Handlers**************************************************
    Private Sub SerialComExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Set up port name and baud rate
        SerialPort1.PortName = "COM5"
        SerialPort1.BaudRate = 9600
        'open serial port for data transfer
        SerialPort1.Open()
    End Sub

    Private Sub DiscoLightsButton_Click(sender As Object, e As EventArgs) Handles DiscoLightsButton.Click
        DiscoLightsButton.Enabled = False
        StartDiscoLights()
        DiscoLightsButton.Enabled = True
    End Sub
End Class
