<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SerialComExampleForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.DiscoLightsButton = New System.Windows.Forms.Button()
        Me.GetSettingsButton = New System.Windows.Forms.Button()
        Me.ReadA1Button = New System.Windows.Forms.Button()
        Me.A1InputLabel = New System.Windows.Forms.Label()
        Me.A2InputLabel = New System.Windows.Forms.Label()
        Me.ReadA2Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DiscoLightsButton
        '
        Me.DiscoLightsButton.Location = New System.Drawing.Point(23, 108)
        Me.DiscoLightsButton.Name = "DiscoLightsButton"
        Me.DiscoLightsButton.Size = New System.Drawing.Size(160, 76)
        Me.DiscoLightsButton.TabIndex = 0
        Me.DiscoLightsButton.Text = "Start A " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DISCO!!"
        Me.DiscoLightsButton.UseVisualStyleBackColor = True
        '
        'GetSettingsButton
        '
        Me.GetSettingsButton.Location = New System.Drawing.Point(204, 108)
        Me.GetSettingsButton.Name = "GetSettingsButton"
        Me.GetSettingsButton.Size = New System.Drawing.Size(160, 76)
        Me.GetSettingsButton.TabIndex = 1
        Me.GetSettingsButton.Text = "Receive Settings"
        Me.GetSettingsButton.UseVisualStyleBackColor = True
        '
        'ReadA1Button
        '
        Me.ReadA1Button.Location = New System.Drawing.Point(391, 108)
        Me.ReadA1Button.Name = "ReadA1Button"
        Me.ReadA1Button.Size = New System.Drawing.Size(160, 76)
        Me.ReadA1Button.TabIndex = 2
        Me.ReadA1Button.Text = "Read Analog Input 1"
        Me.ReadA1Button.UseVisualStyleBackColor = True
        '
        'A1InputLabel
        '
        Me.A1InputLabel.AutoSize = True
        Me.A1InputLabel.Location = New System.Drawing.Point(441, 66)
        Me.A1InputLabel.Name = "A1InputLabel"
        Me.A1InputLabel.Size = New System.Drawing.Size(51, 17)
        Me.A1InputLabel.TabIndex = 3
        Me.A1InputLabel.Text = "Label1"
        '
        'A2InputLabel
        '
        Me.A2InputLabel.AutoSize = True
        Me.A2InputLabel.Location = New System.Drawing.Point(626, 66)
        Me.A2InputLabel.Name = "A2InputLabel"
        Me.A2InputLabel.Size = New System.Drawing.Size(51, 17)
        Me.A2InputLabel.TabIndex = 5
        Me.A2InputLabel.Text = "Label1"
        '
        'ReadA2Button
        '
        Me.ReadA2Button.Location = New System.Drawing.Point(576, 108)
        Me.ReadA2Button.Name = "ReadA2Button"
        Me.ReadA2Button.Size = New System.Drawing.Size(160, 76)
        Me.ReadA2Button.TabIndex = 4
        Me.ReadA2Button.Text = "Read Analog Input 2"
        Me.ReadA2Button.UseVisualStyleBackColor = True
        '
        'SerialComExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 568)
        Me.Controls.Add(Me.A2InputLabel)
        Me.Controls.Add(Me.ReadA2Button)
        Me.Controls.Add(Me.A1InputLabel)
        Me.Controls.Add(Me.ReadA1Button)
        Me.Controls.Add(Me.GetSettingsButton)
        Me.Controls.Add(Me.DiscoLightsButton)
        Me.Name = "SerialComExampleForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents DiscoLightsButton As Button
    Friend WithEvents GetSettingsButton As Button
    Friend WithEvents ReadA1Button As Button
    Friend WithEvents A1InputLabel As Label
    Friend WithEvents A2InputLabel As Label
    Friend WithEvents ReadA2Button As Button
End Class
