Imports System.Net
Imports System.Net.Sockets
Imports System.IO


Public Class ClientHandlerRead

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
    Public idThiSinhCNV As Integer = -1

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
        Dim idThiSinh As Integer = 0
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
                    If (temp = MyMessages.SendAnswer) Then
                        'Nhận dc câu trả lời từ thí sinh
                        idThiSinh = r.ReadInt32() 'Nhận ID thí sinh
                        temp = r.ReadString() 'Nhận câu trả lời
                        frm1.ArrThiSinh(idThiSinh).Answer = temp
                        frm1.ArrThiSinh(idThiSinh).TimeCount = Me.TimeCount.ToString()
                        Me.Time = Me.TimeCount
                        Debug.WriteLine(frm1.ArrThiSinh(idThiSinh).name & "  sent Answer: " + temp + " at " + Me.Time.ToString())
                        frm1.appendLog(frm1.ArrThiSinh(idThiSinh).name & "  sent Answer: " + temp + " at " + Me.Time.ToString())
                    End If
                    If (temp = MyMessages.SendTeamName) Then
                        temp = r.ReadString()
                        Me.TeamName = temp
                    End If
                    'Nhận được tín hiệu trả lời CNV:
                    If (temp = MyMessages.AnswerCNV) Then
                        'Đọc id Thí sinh (integer)
                        idThiSinhCNV = r.ReadInt32()
                        frm1.idThiSinhCNV = idThiSinhCNV
                        frm1.ShowThiSinhCNV()
                        frm1.SendThiSinhCNV()
                    End If
                    'Nhận được tín hiệu giành quyền về đích:
                    If (temp = MsgVeDich.IDAnswerVeDich) Then
                        idThiSinh = r.ReadInt32()
                        frm1.idThiSinhVD = idThiSinh
                        Debug.Print("ID thí sinh giành quyền: " & idThiSinh)
                        frm1.appendLog("ID thí sinh giành quyền: " & idThiSinh)
                        If (frm1.isGianhQuyenVD = False) Then
                            'Nếu chưa có ai giành quyền về đích:
                            frm1.isGianhQuyenVD = True
                            frm1.ShowThiSinhVeDich()
                            frm1.SendThiSinhVeDich()
                            frm1.SendCommand(MyCommands.DisableVeDich)
                        End If
                    End If
                    'Sleep:
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
            frm1.appendLog(ID & ": Client connection closed.")
        Catch Err As Exception
            Debug.WriteLine(Err.ToString)
        End Try
    End Sub

End Class