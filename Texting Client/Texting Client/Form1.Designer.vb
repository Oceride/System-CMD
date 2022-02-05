<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cmdConnect = New System.Windows.Forms.Button()
        Me.cmdSend = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.tbIP = New System.Windows.Forms.TextBox()
        Me.SetIP = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdConnect
        '
        Me.cmdConnect.Location = New System.Drawing.Point(18, 18)
        Me.cmdConnect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(256, 60)
        Me.cmdConnect.TabIndex = 0
        Me.cmdConnect.Text = "Connect"
        Me.cmdConnect.UseVisualStyleBackColor = True
        '
        'cmdSend
        '
        Me.cmdSend.Location = New System.Drawing.Point(284, 18)
        Me.cmdSend.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdSend.Name = "cmdSend"
        Me.cmdSend.Size = New System.Drawing.Size(256, 60)
        Me.cmdSend.TabIndex = 1
        Me.cmdSend.Text = "Send"
        Me.cmdSend.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(18, 88)
        Me.txtMessage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(520, 26)
        Me.txtMessage.TabIndex = 2
        '
        'tbIP
        '
        Me.tbIP.Location = New System.Drawing.Point(584, 31)
        Me.tbIP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbIP.Name = "tbIP"
        Me.tbIP.Size = New System.Drawing.Size(164, 26)
        Me.tbIP.TabIndex = 3
        Me.tbIP.Text = "IP"
        '
        'SetIP
        '
        Me.SetIP.Location = New System.Drawing.Point(584, 71)
        Me.SetIP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SetIP.Name = "SetIP"
        Me.SetIP.Size = New System.Drawing.Size(166, 46)
        Me.SetIP.TabIndex = 4
        Me.SetIP.Text = "Set IP Connection"
        Me.SetIP.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 138)
        Me.Controls.Add(Me.SetIP)
        Me.Controls.Add(Me.tbIP)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.cmdSend)
        Me.Controls.Add(Me.cmdConnect)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdConnect As Button
    Friend WithEvents cmdSend As Button
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents tbIP As TextBox
    Friend WithEvents SetIP As Button
End Class
