Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Public Class TCPControl
    Public Event MessageReceived(sender As TCPControl, Data As String)

    'Server config
    Dim strHostName As String = System.Net.Dns.GetHostName()
    Dim strIPAddress As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
    Public ServerIP As IPAddress = IPAddress.Parse(strIPAddress)
    Public ServerPort As Integer = 64555
    Public Server As TcpListener

    Private CommThread As Thread
    Public IsListening As Boolean = True

    'CLIENT
    Private Client As TcpClient
    Private ClientData As StreamReader

    Public Sub New()
        Server = New TcpListener(ServerIP, ServerPort)
        Server.Start()

        CommThread = New Thread(New ThreadStart(AddressOf Listening))
        CommThread.Start()
    End Sub
    Private Sub Listening()
        'Create listing loop
        Do Until IsListening = False
            'Accept Connections
            If Server.Pending = True Then
                Client = Server.AcceptTcpClient
                ClientData = New StreamReader(Client.GetStream)
            End If

            'Incomming Messages Event
            Try
                RaiseEvent MessageReceived(Me, ClientData.ReadLine)
            Catch ex As Exception

            End Try


            'Sleeping CPU overuse
            Thread.Sleep(500)
        Loop
    End Sub
End Class
