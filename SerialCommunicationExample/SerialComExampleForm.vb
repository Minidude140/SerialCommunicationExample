Imports System.IO.Ports
Imports System.Threading
Public Class SerialComExampleForm
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

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        'Read from serial port (event triggers after so many bytes have been received)
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
    Sub WriteDigitalOut(output As Byte)
        'create a byte array
        Dim data(1) As Byte
        'populate the byte array
        data(0) = &H20
        data(1) = output
        'write the data byte array starting at bit 0 and sending two bytes
        SerialPort1.Write(data, 0, 2)
    End Sub

    Sub StartDiscoLights()
        For i = 0 To 10
            WriteDigitalOut(&HAA)
            Thread.Sleep(500)
            WriteDigitalOut(&H55)
            Thread.Sleep(500)
        Next
        WriteDigitalOut(&H0)
    End Sub
End Class
