Imports System.IO.Ports
Imports System.Threading
Public Class SerialComExampleForm
    '*****************Custom Methods*******************************

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

    ''' <summary>
    ''' Gets a Series of data from the Quiet Board and writes to the output console
    ''' </summary>
    Sub GetQySettings()
        'command QY Board to output settings data
        Dim command(0) As Byte
        command(0) = &B11110000
        SerialPort1.Write(command, 0, 1)
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
    ''' Read Analog Input 1 and Output Result (High Byte) to A1 Label
    ''' </summary>
    Sub Qy_AnalogReadA1()
        ReadA1Button.Enabled = False
        'command to QY board to read analog data
        Dim command(0) As Byte
        command(0) = &B1010001
        SerialPort1.Write(command, 0, 1)
        'create an array of bytes with the length of given bytes
        Thread.Sleep(5)

        Dim data(SerialPort1.BytesToRead) As Byte
        SerialPort1.Read(data, 0, SerialPort1.BytesToRead)

        A1InputLabel.Text = CStr(data(0))

        ReadA1Button.Enabled = True
    End Sub

    ''' <summary>
    ''' Read Analog Input 2 and Output Result (High Byte) to A2 Label
    ''' </summary>
    Sub Qy_AnalogReadA2()
        ReadA2Button.Enabled = False
        'command to QY board to read analog data
        Dim command(0) As Byte
        command(0) = &B1010010
        SerialPort1.Write(command, 0, 1)
        'create an array of bytes with the length of given bytes
        Thread.Sleep(5)

        Dim data(SerialPort1.BytesToRead) As Byte
        SerialPort1.Read(data, 0, SerialPort1.BytesToRead)

        A2InputLabel.Text = CStr(data(0))

        ReadA2Button.Enabled = True
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

    Private Sub GetSettingsButton_Click(sender As Object, e As EventArgs) Handles GetSettingsButton.Click
        GetQySettings()
    End Sub

    Private Sub ReadA1Button_Click(sender As Object, e As EventArgs) Handles ReadA1Button.Click
        Qy_AnalogReadA1()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ReadA2Button.Click
        Qy_AnalogReadA2()
    End Sub
End Class
