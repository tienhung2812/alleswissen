Imports System.Net
Imports System.Net.Sockets
Imports System.IO

Public Class ClientHandlerWriteSpec

    Const MaxThiSinh As Integer = 4
    Private Client As TcpClient
    Public ID As String
    Public Command As Integer = 0
    Public FileName As String = "" 'FileName to be sent
    Public Question As String = ""
    Public Message As String = "" 'Message ready to be sent
    Public IDSend As String = " 'ID to be sent"
    Public arrThiSinh(MaxThiSinh) As Contestant

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
                        Case MyCommands.SendSpecial
                            w.Write(Me.Message)
                            w.Write(Me.IDSend)
                            w.Write(FileName)
                        Case MyCommands.SendThiSinhID 'Bat dau khoi dong hoac ve dich
                            w.Write(Me.Message) 'Message báo khởi động hoặc về đích
                            w.Write(IDSend) 'ID của thí sinh chuẩn bị thi
                        Case MyCommands.ShowScore 'Send and show score
                            w.Write(Me.Message)
                            'Lan lượt send  score của 4 thí sinh theo thứ tự ID trong file
                            For i = 0 To MaxThiSinh - 1
                                w.Write(arrThiSinh(i).score)
                            Next
                        Case MyCommands.SendScore
                            w.Write(MyMessages.SendScores)
                            'Lần lượt send score:
                            For i = 0 To MaxThiSinh - 1
                                w.Write(arrThiSinh(i).score)
                            Next
                        Case MyCommands.ShowWait 'Hiện màn hình chờ
                            w.Write(MyMessages.ShowWait)
                        Case MyCommands.ShowTangToc 'Hiện form tăng tốc
                            w.Write(MsgTangToc.ShowTangToc)
                        Case MyCommands.ShowAnswerTangToc
                            'Hiện câu trả lời tăng tốc của thí sinh
                            w.Write(MsgTangToc.ShowTTAnswer)
                            'Lần lượt send câu trả lời, thời gian trả lời theo thứ tự ID trong file:
                            For i = 0 To MaxThiSinh - 1
                                w.Write(arrThiSinh(i).Answer)
                                w.Write(arrThiSinh(i).TimeCount)
                            Next
                        Case MyCommands.ShowAnswerVCNV
                            'Hiện trả lời VCNV
                            w.Write(MsgVCNV.ShowVCNVAnswer)
                            'Lần lượt send answer:
                            For i = 0 To MaxThiSinh - 1
                                w.Write(arrThiSinh(i).Answer)
                            Next
                        Case MyCommands.ShowVCNV
                            w.Write(MsgVCNV.ShowVCNV)
                        Case MyCommands.SendIDAnswerCNV
                            w.Write(MsgVCNV.IDAnswerCNV)
                            'Gửi ID của thí sinh vừa bấm trả lời CNV:
                            w.Write(Me.IDSend)
                        Case MyCommands.ShowVeDich
                            'Hiện form về đích:
                            w.Write(MsgVeDich.ShowVeDich)
                        Case MyCommands.SendIDAnswerVeDich
                            w.Write(MsgVeDich.IDAnswerVeDich)
                            'Gửi ID thí sinh vừa bấm giành quyền về đích:
                            w.Write(Me.IDSend)
                            '
                        Case MyCommands.ShowIntroKD
                            w.Write(MyMessages.ShowIntroKD)
                        Case MyCommands.ShowIntroVD
                            w.Write(MyMessages.ShowIntroVD)
                        Case MyCommands.ShowIntroVCNV
                            w.Write(MyMessages.ShowIntroVCNV)
                        Case MyCommands.ShowIntroTT
                            w.Write(MyMessages.ShowIntroTT)
                        Case MyCommands.ShowVCNVPic
                            'Hiện form gợi ý CNV
                            w.Write(MsgVCNV.ShowVCNVPic)
                    End Select
                    Command = MyCommands.Normal
                End If
                Threading.Thread.Sleep(50)
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