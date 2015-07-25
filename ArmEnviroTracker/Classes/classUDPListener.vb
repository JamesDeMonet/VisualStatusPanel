Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Text

''' <summary>
''' Class to listen for UDP packets on a given port
''' </summary>
''' <remarks></remarks>
Public Class classUDPListener
    Private Const listenPort As Integer = 11000

    Private listener As New UdpClient(listenPort)
    Public Shared Event DataReceived(ByVal strData As String)
    Private Shared doneListening As Boolean = False
    Private Shared receiverReentrancyOkay As Boolean = True

    Public ReadOnly Property StartListener() As Boolean
        Get
            doneListening = False
            BeginListening()
            Return True
        End Get
    End Property

    Public ReadOnly Property StopListener() As Boolean
        Get
            doneListening = True
            Return True
        End Get
    End Property

    ' Asynchronus Version
    Private Sub BeginListening()
        Try
            Console.WriteLine("Waiting for broadcast")
            listener.BeginReceive(New AsyncCallback(AddressOf Receiver), vbNull)
        Catch e As Exception
            Console.WriteLine(e.ToString())
        End Try
    End Sub 'StartListener

    Private Sub Receiver(ByVal res As IAsyncResult)
        'If receiverReentrancyOkay = True Then
        '    receiverReentrancyOkay = False
        Try
            Dim groupEP As New IPEndPoint(IPAddress.Any, 0)

            Dim bytes As Byte() = listener.EndReceive(res, groupEP)
            If Not doneListening Then
                listener.BeginReceive(New AsyncCallback(AddressOf Receiver), vbNull)
            Else
                listener.Close()
            End If
            Dim strData As String = Encoding.ASCII.GetString(bytes, 0, bytes.Length)
            Console.WriteLine("Received broadcast from {0} :", groupEP.ToString())
            Console.WriteLine(strData)
            Console.WriteLine()
            RaiseEvent DataReceived(strData)
        Catch ex As Exception
            doneListening = doneListening
        End Try
        receiverReentrancyOkay = True
        'Else
        '' This line is only here as an error check, to see if we are getting stuck in a non-reentrancy loop where the variable never resets for some reason.
        'receiverReentrancyOkay = receiverReentrancyOkay
        'End If
    End Sub

    ' Synchronous Version
    'Private Shared Sub BeginListening()
    '    Dim listener As New UdpClient(listenPort)
    '    Dim groupEP As New IPEndPoint(IPAddress.Any, 0)
    '    Try
    '        While Not doneListening
    '            Try
    '                Console.WriteLine("Waiting for broadcast")
    '                Dim bytes As Byte() = listener.Receive(groupEP)
    '                Dim strData As String = Encoding.ASCII.GetString(bytes, 0, bytes.Length)
    '                Console.WriteLine("Received broadcast from {0} :", groupEP.ToString())
    '                Console.WriteLine(strData)
    '                Console.WriteLine()
    '                RaiseEvent DataReceived(strData)
    '            Catch ex As Exception
    '                ' Ignore Exceptions
    '            End Try
    '        End While
    '    Catch e As Exception
    '        Console.WriteLine(e.ToString())
    '    Finally
    '        listener.Close()
    '    End Try
    'End Sub 'StartListener

    Public Function Main() As Integer
        BeginListening()
        Return 0
    End Function 'Main
End Class 'UDPListener

''' <summary>
''' Class to send UDP packets back to the host, if desired
''' </summary>
''' <remarks></remarks>
Public Class classUDPSender
    Public Const broadcastAddress As String = "127.0.0.1"
    Private Const broadcastPort As Integer = 5000

    Public Overloads Shared Function Main(args() As [String]) As Integer
        Dim s As New Socket(AddressFamily.InterNetwork, SocketType.Dgram,
            ProtocolType.Udp)
        Dim broadcast As IPAddress = IPAddress.Parse(broadcastAddress)
        Dim sendbuf As Byte() = Encoding.ASCII.GetBytes(args(0))
        Dim ep As New IPEndPoint(broadcast, broadcastPort)
        s.SendTo(sendbuf, ep)
        Console.WriteLine("Message sent to the broadcast address")
    End Function 'Main
End Class