Imports System.Net
Imports System.Net.Sockets
Imports System.IO

Public Class ClientHandlerWrite

    Private Client As TcpClient
    Public ID As String
    Public Command As Integer = 0
    Public path As String = ""
    Public Question As String = ""
    Public ClientTime As Integer = 15 'Thời gian trả lời 1 câu hỏi (tính theo giây)
    Public frm1 As frmServer

    Public Sub New(ByVal client As TcpClient, ByVal ID As String)
        Me.Client = client
        Me.ID = ID
    End Sub

    Public Sub Start() 'Start thread write
        Dim Stream As NetworkStream = Client.GetStream()
        Dim isDis As Boolean = False
        Dim w As New BinaryWriter(Stream)
        Dim i As Integer
        Try
            Do
                If (Command <> MyCommands.Normal) Then
                    Select Case Command
                        Case MyCommands.SendQuestion
                            w.Write(MyMessages.SendQuestion)
                            w.Write(Me.Question)
                        Case MyCommands.StopAnswer
                            w.Write(MyMessages.StopAnswer)
                        Case MyCommands.StartAnswerOnce
                            w.Write(MyMessages.StartAnswerOnce)
                        Case MyCommands.SendClientTime
                            w.Write(MyMessages.ClientTime)
                            w.Write(Me.ClientTime)
                        Case MyCommands.StartNormal
                            'Start normally
                            w.Write(MyMessages.StartNormal)
                        Case MyCommands.AllowCNV
                            w.Write(MyMessages.AllowCNV)
                        Case MyCommands.HideCNV
                            w.Write(MyMessages.HideCNV)
                        Case MyCommands.AllowVeDich
                            w.Write(MyMessages.AllowVeDich)
                            Debug.Print("Cho phép giành quyền về đích")
                            frm1.appendLog("Cho phép giành quyền về đích")
                        Case MyCommands.HideVeDich
                            w.Write(MyMessages.HideVeDich)
                        Case MyCommands.DisableVeDich
                            w.Write(MyMessages.DisableVeDich)
                        Case MyCommands.SendScore
                            'Gửi bảng điểm tới thí sinh
                            w.Write(MyMessages.SendScores)
                            For i = 0 To frmServer.MaxThiSinh - 1
                                'Lần lượt gửi tên, điểm
                                w.Write(frm1.ArrThiSinh(i).name)
                                w.Write(frm1.ArrThiSinh(i).score)
                            Next
                    End Select
                    Command = MyCommands.Normal
                End If
                Threading.Thread.Sleep(20)
            Loop
            'Loop Until r.ReadString() = MyMessages.Disconnect
            Debug.WriteLine(ID & ": Disconnected.")
            Client.Close()
            Debug.WriteLine(ID & ": Client connection closed.")
        Catch Err As Exception
            Debug.WriteLine(Err.ToString)
        End Try
    End Sub

End Class