Imports System.Data.OleDb
Imports System.Data

Public Class frmKhoiDong

    Const MaxQuestion As Integer = 10
    Public frm1 As frmMain
    Public KDFileName As String
    Public ArrQuestions(MaxQuestion) As QuestionKD
    Public idQuest As Integer = -1 'Current question
    Public timeCount As Integer = 10 'TimeCount in second
    Public Score As Integer = 0
    Private rightAns As Integer = 0 'Số câu đúng
    Private imgThiSinh As Image


    Private Sub frmKhoiDong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frm1.MakeLabelTranparent(Me)
        loadThiSinh()
        'frm1.fSound.PlaySound(SoundPaths.Theme)
        'loadQuestions(".\Data\Round1\" & (frm1.idThiSinh + 1) & ".xls")
        lbCategory.Text = ""
        lbQuestion.Text = ""

    End Sub

    Public Sub loadThiSinh()
        Dim ThiSinh As Contestant = frm1.ArrThiSinh(frm1.idThiSinh)
        imgThiSinh = Image.FromFile(ThiSinh.imagePath)
        pbThiSinh.Image = imgThiSinh
        lbName.Text = ThiSinh.name
    End Sub

    Public Sub LoadQuestEasy()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadQuestEasy))
        Else
            loadQuestions(".\Data\Round1\" & (frm1.idThiSinh + 1) & "E.xls")
            lbEasy.ForeColor = Color.Red
            lbNormal.Font = New Font(lbNormal.Font, FontStyle.Regular)
            lbHard.Font = New Font(lbHard.Font, FontStyle.Regular)
            PlayStartSound()
        End If

    End Sub
    Public Sub LoadQuestMedium()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadQuestMedium))
        Else
            loadQuestions(".\Data\Round1\" & (frm1.idThiSinh + 1) & "M.xls")
            lbNormal.ForeColor = Color.Red
            lbEasy.Font = New Font(lbEasy.Font, FontStyle.Regular)
            lbHard.Font = New Font(lbHard.Font, FontStyle.Regular)
            PlayStartSound()
        End If

    End Sub
    Public Sub LoadQuestHard()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadQuestHard))
        Else
            loadQuestions(".\Data\Round1\" & (frm1.idThiSinh + 1) & "H.xls")
            lbHard.ForeColor = Color.Red
            lbEasy.Font = New Font(lbEasy.Font, FontStyle.Regular)
            lbNormal.Font = New Font(lbNormal.Font, FontStyle.Regular)
            PlayStartSound()
        End If

    End Sub

    Private Sub frmKhoiDong_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.P 'Thoát
                Application.Exit()
            Case Keys.B, Keys.T 'Bat dau
                PlayStartSound() 'Nhạc bắt đầu
                frm1.fSound.PlaySound(SoundPaths.VD10s)
                StartTime()
                idQuest = 0
                rightAns = 0
                DisplayQuestion()
            Case Keys.D 'Tra loi Đúng

                If (idQuest < MaxQuestion) Then
                    Score += 10
                    lbScore.Text = Score
                    rightAns += 1
                    idQuest += 1
                    StartTime()
                    DisplayQuestion()
                    frm1.fSound.PlaySound(SoundPaths.VD10s)
                End If
            Case Keys.O
                NextQuestionShow()
            Case Keys.S 'Tra loi Sai                    
                idQuest += 1
                DisplayQuestion()
            Case Keys.Space
                frm1.fSound2.PlaySound(SoundPaths.ChoTrong)
            Case Keys.N
                'Choi nhac:
                If (ArrQuestions(idQuest).Type = "Music") Then
                    frm1.fSound2.PlaySound(ArrQuestions(idQuest).FilePath)
                End If
            Case Keys.Z
                'Nhạc trả lời sai:
                frm1.fSound2.PlaySound(SoundPaths.TraLoiSai)
            Case Keys.X
                'Nhạc trả lời đúng:
                frm1.fSound2.PlaySound(SoundPaths.TraLoiDung)
        End Select
    End Sub

    Public Sub BackQuestionShow()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf BackQuestionShow))
        Else
            idQuest -= 1
            DisplayQuestion()
        End If
    End Sub

    Public Sub NextQuestionShow()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf NextQuestionShow))
        Else
            If (idQuest < MaxQuestion) Then
                idQuest += 1
                lbTime.Text = "10"
                DisplayQuestion()
            End If
        End If
    End Sub

    Private Sub PlayStartSound()
        Dim i As Integer
        frm1.fSound.PlaySound(SoundPaths.KDPhanThiBatDau)
        For i = 0 To 75
            Application.DoEvents()
            Threading.Thread.Sleep(100)
        Next
    End Sub

    Private Sub StartTime() 'Bat dau tinh gio
        timeCount = 10
        tmTimeCount.Enabled = True
        frm1.fSound.PlaySound(SoundPaths.VD10s)
    End Sub

    Private Sub DisplayQuestion()
        If (idQuest < 0 Or idQuest > 9) Then Exit Sub
        lbCategory.Text = ArrQuestions(idQuest).Category
        lbQuestion.Text = ArrQuestions(idQuest).Question
        frm1.SendQuestion(ArrQuestions(idQuest).Question)
        If (ArrQuestions(idQuest).Type = "Image") Then
            pbThiSinh.Image = Image.FromFile(ArrQuestions(idQuest).FilePath)
        Else
            pbThiSinh.Image = imgThiSinh
        End If
    End Sub

   
    Public Sub StartQuestion()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf StartQuestion))
        Else
            StartTime()
        End If

    End Sub
    Public Sub StopQuestion()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf StopQuestion))
        Else
            timeCount = 10
            tmTimeCount.Enabled = False
            frm1.fSound.StopSound()
        End If

    End Sub

    Private Sub loadQuestions(ByVal filename As String)
        Dim connstring As String
        Dim i As Integer
        Dim dtQuest As DataTable
        connstring = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
       "Data Source=" & filename & ";Extended Properties=""Excel 8.0;HDR=YES;"""
        Debug.Print(connstring)
        Dim query As String = "SELECT No, Category, Question, Answer, FilePath, Type FROM [Sheet1$]"
        Try
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(query, connstring)
            dtQuest = New DataTable()
            da.Fill(dtQuest)
            For i = 0 To MaxQuestion - 1
                ArrQuestions(i) = New QuestionKD()
                If (dtQuest.Rows(i).IsNull(0) = False) Then
                    ArrQuestions(i).ID = dtQuest.Rows(i).Item(0)
                End If
                If (dtQuest.Rows(i).IsNull(1) = False) Then
                    ArrQuestions(i).Category = dtQuest.Rows(i).Item(1)
                End If
                ArrQuestions(i).Question = dtQuest.Rows(i).Item(2)
                If dtQuest.Rows(i).IsNull("Answer") = False Then
                    ArrQuestions(i).Answer = dtQuest.Rows(i).Item(3)
                End If
                If (dtQuest.Rows(i).IsNull("FilePath") = False) Then
                    ArrQuestions(i).FilePath = dtQuest.Rows(i).Item("FilePath")
                End If
                If (dtQuest.Rows(i).IsNull("Type") = False) Then
                    ArrQuestions(i).Type = dtQuest.Rows(i).Item("Type")
                End If
            Next i
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub tmTimeCount_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmTimeCount.Tick
        timeCount -= 1
        If (timeCount >= 0) Then
            lbTime.Text = timeCount
        Else
            'Hết giờ:
            tmTimeCount.Enabled = False
        End If
    End Sub


End Class