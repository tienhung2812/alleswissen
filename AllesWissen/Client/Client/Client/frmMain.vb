Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports System.Collections.Generic
Imports System.Threading

Public Class frmMain
    Public Client As New TcpClient
    Dim ip As String = "127.0.0.1"
    Dim port As Integer = 8000
    Dim isDisconnected As Boolean = False
    Dim isConnected As Boolean = False
    'Dim logWriter As IO.StreamWriter

    Public answer As String
    Public question As String
    Public TeamName As String = "Team1"
    Public isSending As Boolean = False
    Public isSendName As Boolean = False
    Private Stream As NetworkStream

    Dim clientRead As System.Threading.Thread 'New System.Threading.Thread(AddressOf ClientThreadRead)
    Dim clientWrite As System.Threading.Thread 'New Threading.Thread(AddressOf ClientThreadWrite)

    Dim answerTime As Integer = 0 'Number of answer allowed
    Dim TimeCountConst As Integer = 15
    Dim TimeCount As Integer = 15
    Dim idThiSinh As Integer = 0 'Get ID of Contestant
    Dim Command As Integer = 0
    Public Const MaxThiSinh As Integer = 3 'Khai báo số thí sinh
    Public ArrThiSinh(MaxThiSinh) As Contestant 'chuỗi thông tin thí sinh
    Private lstNames As List(Of Label)
    Private lstScores As List(Of Label)

    '____________ Software Initialize:

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        readTeamName()
        Me.Text = Me.TeamName & " - AllesWissen" 'title cho phần mềm
        lbAnswer.Text = "" 'reset khung câu trả lời
        lbQuestion.Text = "" 'reset khung câu hỏi
        InitArrays() 'khai báo chuỗi thông tin tên và điểm thí sinh
        'btnAnswerCNV.Enabled = False
        'btnAnswerVeDich.Enabled = False
        tbAnswer.Enabled = False
        tbAnswer.Focus()

        Try
            connecttoserver() 'tự động connect ----> check cẩn thận
        Catch ex As Exception
            'xuất hiện nút connect
            mnConnect.Enabled = True
        End Try
    End Sub

    Private Sub frmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Dim dr As DialogResult = MessageBox.Show("Exit the program may reset your score, Continue?", "AllesWissen !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dr = DialogResult.No Then
            e.Cancel = True
        ElseIf dr = DialogResult.Yes Then
            isConnected = True
            isDisconnected = True
        End If

        isConnected = True
        isDisconnected = True
    End Sub

    Private Sub readTeamName()
        Dim oRead As System.IO.StreamReader
        oRead = File.OpenText("Config.ini")
        Dim teamName As String = oRead.ReadLine() 'đọc tên thí sinh
        ip = oRead.ReadLine() 'đọc ip
        lbTeamName.Text = teamName 'gán tên
        Me.TeamName = teamName
        idThiSinh = Convert.ToInt32(oRead.ReadLine()) 'đọc và chuyển ID char -> num
        oRead.Close()
    End Sub

    Private Sub InitArrays()
        Dim i As Integer
        For i = 0 To MaxThiSinh - 1
            ArrThiSinh(i) = New Contestant
        Next
        lstNames = New List(Of Label)
        lstNames.Add(lbName01)
        lstNames.Add(lbName02)
        lstNames.Add(lbName03)
        lstNames.Add(lbName04)
        lstScores = New List(Of Label)
        lstScores.Add(lbScore01)
        lstScores.Add(lbScore02)
        lstScores.Add(lbScore03)
        lstScores.Add(lbScore04)
    End Sub

    Private Sub mnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnConnect.Click
        connecttoserver()
    End Sub

    Private Sub mnIPAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnIPAddress.Click
        ip = InputBox("Type the server's IP : ", "AllesWissen", ip)
    End Sub

    Private Sub mnTeamName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnTeamName.Click
        Dim s As String = InputBox("Type your name: ", "AllesWissen", lbTeamName.Text)
        If (s <> "") Then
            TeamName = s
            lbTeamName.Text = TeamName
            Me.Text = Me.TeamName & " - AllesWissen"
            'isSendName = True
        End If
    End Sub

    Private Sub connecttoserver() 'Kết nối đến SERVER
        Try 'Thử ngắt kết nối nhận/gởi với server
            clientRead.Abort()
            clientWrite.Abort()
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try
        clientRead = New System.Threading.Thread(AddressOf ClientThreadRead) 'tạo luồng nhận tín hiệu từ server
        clientWrite = New Threading.Thread(AddressOf ClientThreadWrite) 'tạo luồng gởi tín hiệu đến server
        clientRead.IsBackground = True
        clientWrite.IsBackground = True
        clientRead.Start() 'bắt đầu nhận tín hiệu
        clientWrite.Start() 'bắt đầu gởi tín hiệu
    End Sub

    Private Sub tbAnswer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbAnswer.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbAnswer.Text = tbAnswer.Text.Trim()
            If (tbAnswer.Text = "") Then 'chưa có câu trả lời mà ấn gởi
                MsgBox("Nhập câu trả lời rồi nhấn Enter")
                tbAnswer.Focus() 'Đặt con trỏ chuột vào textbox để trả lời
                Exit Sub
            End If
            answer = tbAnswer.Text
            lbAnswer.Text = answer 'xác nhận câu trả lời
            answerTime -= 1 'giảm số lần được trả lời
            tbAnswer.Text = ""
            Command = MyCommands.SendAnswer ' Ra lệnh gửi trả lời về server
            If (answerTime = 0) Then
                tbAnswer.Enabled = False
            End If
        End If
    End Sub

    Private Sub reset_client()
        isDisconnected = True
        'Client.Close()
        'Client.Connect(IPAddress.Parse(ip), port)
        'Restart("client")
        Application.Restart()

    End Sub

    Private Sub tmTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmTime.Tick
        TimeCount -= 1
        lbTime.Text = TimeCount
        If (TimeCount = 0) Then
            tmTime.Enabled = False
            'tbAnswer.Enabled = False
        End If
    End Sub

    Private Sub StartAnswering()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf StartAnswering))
        Else
            lbAnswer.Text = ""
            tbAnswer.Enabled = True
            TimeCount = TimeCountConst
            tmTime.Enabled = True
            'Đặt con trỏ chuột vào textbox để trả lời
            tbAnswer.Focus()
        End If

        'lbTime.Visible = True
    End Sub

    Private Sub StopAnswering()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf StopAnswering))
        Else
            tbAnswer.Enabled = False
            'lbQuestion.Text = ""
        End If
    End Sub

    Private Sub ShowQuestion()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ShowQuestion))
        Else
            'lbAnswer.Text = ""
            lbQuestion.Text = question
        End If
    End Sub

    Private Sub UpdateScores()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf UpdateScores))
        Else
            Dim i As Integer
            For i = 0 To MaxThiSinh - 1
                lstNames(i).Text = ArrThiSinh(i).name
                lstScores(i).Text = ArrThiSinh(i).score
            Next
        End If
    End Sub

    Private Sub btnSteal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSteal.Click
        Command = MyCommands.AnswerVeDich
        btnSteal.Enabled = False
    End Sub

    Private Sub ShowStealButton()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ShowStealButton))
        Else
            btnSteal.Show()
            btnSteal.Enabled = True
        End If
    End Sub

    Private Sub HideStealButton()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf HideStealButton))
        Else
            btnSteal.Hide()
        End If
    End Sub

    Private Sub DisableStealButton()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf DisableStealButton))
        Else
            btnSteal.Enabled = False
        End If
    End Sub

    Public Sub ClientThreadRead() '===============NHẬN TÍN HIỆU TỪ SERVER===============================================
        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1))

        Dim temp As String 'dữ liệu đệm
        Dim i As Integer

        Try
            Debug.WriteLine("Attempting to connect to the server on port 8000.")
            'logWriter.WriteLine("Attempting to connect to the server on port 8000.")
            Client.Connect(IPAddress.Parse(ip), port) 'Kết nối TCP thông qua IP và port -<<<<<<<<<<<<<<<<<<<
            Debug.WriteLine("Connection established.")

            Stream = Client.GetStream() 'Get Stream for writing and reading
            Dim r As New BinaryReader(Stream)
            isConnected = True
            If r.ReadString() = MyMessages.AcknowledgeOK Then
                MsgBox("Kết nối Server thành công")
                mnConnect.Enabled = False
                Do
                    temp = r.ReadString() 'lưu tín hiệu nhận qua temp
                    If (temp = MyMessages.RestartRequest) Then 'reset client
                        reset_client()
                    End If
                    If (temp = MyMessages.StartNormal) Then 'Bắt đầu được phép trả lời nhiều lần
                        StartAnswering()
                        answerTime = 10000 'được trả lời 10000 lần
                    End If

                    If (temp = MyMessages.StartAnswerOnce) Then
                        'Bắt đầu được phép trả lời (chỉ trả lời 1 lần)
                        'question = r.ReadString()
                        StartAnswering()
                        answerTime = 1
                    End If

                    If (temp = MyMessages.SendQuestion) Then
                        'Nhận được nội dung câu hỏi từ Server -> Hiển thị:
                        question = r.ReadString()
                        'Debug.Print(question)
                        ShowQuestion()
                    End If

                    If (temp = MyMessages.StopAnswer) Then
                        'Server báo hết thời gian trả lời
                        StopAnswering()
                    End If
                    'Server gửi thời gian trả lời 1 câu hỏi (15s, 30s...)
                    If (temp = MyMessages.ClientTime) Then
                        TimeCountConst = r.ReadInt32()
                    End If
                    'Cho phép trả lời Chướng ngại vật:
                    'If (temp = MyMessages.AllowCNV) Then
                    'ShowCNVButton()
                    'End If
                    'ẩn nút trả lời CNV:
                    'If (temp = MyMessages.HideCNV) Then
                    'HideCNVButton()
                    'End If
                    'Cho phép trả lời Về đích:
                    If (temp = MyMessages.AllowVeDich) Then
                        ShowStealButton()
                    End If
                    'If (temp = MyMessages.StartGianh) Then
                    'ShowGianhButton()
                    'End If
                    'If (temp = MyMessages.DisGianh) Then
                    'DisableGianhButton()
                    'End If
                    'Ẩn nút trả lời Về đích:
                    If (temp = MyMessages.HideVeDich) Then
                        HideStealButton()
                    End If
                    'Disable nút về đích:
                    If (temp = MyMessages.DisGianh) Then
                        DisableStealButton()
                    End If
                    'Server gửi bảng điểm
                    If (temp = MyMessages.SendScores) Then
                        For i = 0 To MaxThiSinh - 1
                            'Nhận lần lượt tên, điểm
                            ArrThiSinh(i).name = r.ReadString()
                            ArrThiSinh(i).score = r.ReadInt32()
                        Next
                        UpdateScores()
                    End If
                    'Sleep -<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<======= xem lại
                    Threading.Thread.Sleep(20)
                Loop Until isDisconnected = True

            Else
                Debug.WriteLine("Connection not completed.")
            End If

            Client.Close()

        Catch Err As Exception
            'do nothing
        End Try
    End Sub

    Public Sub ClientThreadWrite() '===================GỞI TÍN HIỆU ĐẾN SERVER=======================================
        Try
            Do
                'nothing
            Loop Until isConnected

            Dim w As New BinaryWriter(Stream)
            w.Write(MyMessages.RequestConnect)
            Do
                Threading.Thread.Sleep(20)
                If (Command <> MyCommands.Normal) Then
                    Select Case Command
                        Case MyCommands.SendAnswer
                            w.Write(MyMessages.SendAnswer)
                            w.Write(idThiSinh)
                            w.Write(answer)
                        Case MyCommands.AnswerCNV
                            w.Write(MyMessages.AnswerCNV)
                            w.Write(idThiSinh)
                        Case MyCommands.AnswerVeDich
                            w.Write(MyMessages.IDGianh)
                            w.Write(idThiSinh)

                    End Select
                    Command = MyCommands.Normal
                End If
            Loop Until isDisconnected
            If (isDisconnected) Then
                w.Write(MyMessages.Disconnect)
            End If

        Catch ex As Exception

        End Try
    End Sub

End Class
