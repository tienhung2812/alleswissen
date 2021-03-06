Imports System.Net
Imports System.Net.Sockets
Imports System.IO


Public Class ClientHandlerReadSpec

    Private Client As TcpClient
    Public ID As String
    Public isStarted As Boolean = False
    Public isPathSent As Boolean = False
    Public path As String = ""

    Public Time As Integer = 0
    Public TimeCount As Integer = 0
    Public Answer As String = ""
    Public TeamName As String = ""

    Public frm1 As frmServer

    Public Sub New(ByVal client As TcpClient, ByVal ID As String)
        Me.Client = client
        Me.ID = ID
    End Sub

    Public Sub Start() 'Start thread read
        Dim Stream As NetworkStream = Client.GetStream()
        Dim isDis As Boolean = False
        'Dim w As New BinaryWriter(Stream)
        Dim temp As String
        Dim r As New BinaryReader(Stream)
        Dim w As New BinaryWriter(Stream)
        Try
            If r.ReadString() = MyMessages.RequestConnect Then
                w.Write(MyMessages.AcknowledgeOK)
                Debug.WriteLine(ID + " connected")
                frm1.appendLog(ID + " connected")
                Do
                    temp = r.ReadString()
                    If (temp = MyMessages.Disconnect) Then
                        Debug.WriteLine(ID + " disconnected")
                        frm1.appendLog(ID + " disconnected")
                    End If
                    'Bắt đầu trả lời tăng tốc
                    If (temp = MsgTangToc.StartAnswer) Then
                        frm1.StartAllClient()
                    End If
                    'Bắt đầu trả lời VCNV:
                    If (temp = MsgVCNV.StartAnswer) Then
                        frm1.StartAllClient()
                    End If
                    'Cho phép trả lời về đích:
                    If (temp = MyMessages.AllowVeDich) Then
                        frm1.isGianhQuyenVD = False
                        frm1.SendCommand(MyCommands.AllowVeDich)
                    End If
                    'Nhận nội dung câu hỏi
                    If (temp = MyMessages.SendQuestion) Then
                        frm1.Question4Send = r.ReadString()
                        frm1.DisplayQuestionOnServer()
                        frm1.SendQuestion()
                    End If
                    Threading.Thread.Sleep(50)
                Loop Until temp = MyMessages.Disconnect

                '  Loop Until r.ReadString() = MyMessages.Disconnect
                Debug.WriteLine(ID & ": Disconnected.")
                frm1.appendLog(ID & ": Disconnected.")
                'w.Write(ServerMessages.Disconnect)                


            Else
                Debug.WriteLine(ID & ": Could not complete connection.")
                frm1.appendLog(ID & ": Could not complete connection.")
            End If

            Client.Close()
            Debug.WriteLine(ID & ": Client connection closed.")
        Catch Err As Exception
            Debug.WriteLine(Err.ToString)
        End Try
    End Sub

End Class