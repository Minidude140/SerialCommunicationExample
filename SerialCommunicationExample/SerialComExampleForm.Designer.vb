﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SerialComExampleForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.DiscoLightsButton = New System.Windows.Forms.Button()
        Me.CatGifWebBrowser = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'DiscoLightsButton
        '
        Me.DiscoLightsButton.Location = New System.Drawing.Point(269, 480)
        Me.DiscoLightsButton.Name = "DiscoLightsButton"
        Me.DiscoLightsButton.Size = New System.Drawing.Size(160, 76)
        Me.DiscoLightsButton.TabIndex = 0
        Me.DiscoLightsButton.Text = "Start A " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DISCO!!"
        Me.DiscoLightsButton.UseVisualStyleBackColor = True
        '
        'CatGifWebBrowser
        '
        Me.CatGifWebBrowser.Location = New System.Drawing.Point(44, 27)
        Me.CatGifWebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.CatGifWebBrowser.Name = "CatGifWebBrowser"
        Me.CatGifWebBrowser.Size = New System.Drawing.Size(691, 407)
        Me.CatGifWebBrowser.TabIndex = 2
        Me.CatGifWebBrowser.Url = New System.Uri("https://i.pinimg.com/originals/23/51/bc/2351bc65b2b5d75cef146b7edddf805b.gif", System.UriKind.Absolute)
        '
        'SerialComExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 568)
        Me.Controls.Add(Me.CatGifWebBrowser)
        Me.Controls.Add(Me.DiscoLightsButton)
        Me.Name = "SerialComExampleForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents DiscoLightsButton As Button
    Friend WithEvents CatGifWebBrowser As WebBrowser
End Class
