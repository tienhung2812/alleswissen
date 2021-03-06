Imports System.Data.OleDb

Public Class frmTangToc

    Public frm1 As frmMain
    Const MaxQuestion As Integer = 6
    Dim ArrQuestions(MaxQuestion) As QuestionTT
    Dim idQuest As Integer = -1 'ID of current question
    Dim topClock As Integer = 223
    Dim bottomClock As Integer = 575
    Dim vantoc As Integer = 0

    Private Sub frmTangToc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'If (e.Control = True) Then
        Select Case e.KeyCode
            Case Keys.P
                Application.Exit()
            Case Keys.B 'Bắt đầu hiện câu hỏi
                pbImage.Visible = False
                WMP1.Visible = False
                pbClock.Location = New Point(pbClock.Location.X, topClock)
                idQuest += 1
                DisplayQuestion()
            Case Keys.T 'Bắt đầu tính giờ

                If (ArrQuestions(idQuest).Type = "Image") Then
                    frm1.fSound.PlaySound(SoundPaths.TT30s)
                End If
                tmClock.Enabled = True
                frm1.Command = MyCommands.StartAnswerTT
            Case Keys.Space
                frm1.fSound2.PlaySound(SoundPaths.ChoTrong)
            Case Keys.Z
                'Nhạc trả lời sai:
                frm1.fSound2.PlaySound(SoundPaths.TraLoiSai)
            Case Keys.X
                'Nhạc trả lời đúng:
                frm1.fSound2.PlaySound(SoundPaths.TraLoiDung)
        End Select
        'End If
    End Sub

    Private Sub PlayMoCauHoi()
        Dim i As Integer
        frm1.fSound.PlaySound(SoundPaths.TTMoCauHoi)
        For i = 0 To 35
            Application.DoEvents()
            Threading.Thread.Sleep(100)
        Next
    End Sub

    Private Sub frmTangToc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WMP1.uiMode = "none"
        frm1.MakeLabelTranparent(Me)
        lbNum.Text = ""
        lbQuestion.Text = ""
        pbClock.BackColor = Color.Transparent
        loadQuestions(".\Data\Round3\Tangtoc.xls")
        vantoc = Convert.ToInt32((bottomClock - topClock - pbClock.Height) / 150)
        Debug.Print("Vantoc: " & vantoc)
    End Sub

    Private Sub DisplayQuestion()
        If (idQuest < 0 Or idQuest >= MaxQuestion) Then Exit Sub
        Dim Quest As QuestionTT = ArrQuestions(idQuest)
        'lbNum.Text = Quest.ID
        lbNum.Text = (idQuest + 1)
        lbQuestion.Text = ""
        PlayMoCauHoi()
        lbQuestion.Text = Quest.Question
        frm1.SendQuestion(ArrQuestions(idQuest).Question)
        Debug.Print("Diplay: " + Quest.Type)
        If (Quest.Type = "Image") Then
            'Câu hỏi hình
            pbImage.Image = Image.FromFile(Quest.FilePath)
            WMP1.Visible = False
            pbImage.Visible = True
        Else
            'Câu hỏi đoạn phim
            pbImage.Visible = False
            WMP1.URL = Quest.FilePath
            WMP1.Ctlcontrols.play()
            Do
                Application.DoEvents()
                System.Threading.Thread.Sleep(20)
            Loop Until WMP1.playState = WMPLib.WMPPlayState.wmppsReady Or WMP1.playState = WMPLib.WMPPlayState.wmppsPlaying
            WMP1.Visible = True
        End If
       
    End Sub

    Private Sub loadQuestions(ByVal filename As String)
        Dim connstring As String
        Dim i As Integer
        Dim dtQuest As DataTable
        connstring = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
       "Data Source=" & filename & ";Extended Properties=""Excel 8.0;HDR=YES;"""
        Debug.Print(connstring)
        Dim query As String = "SELECT No, Type, FilePath, Question, Answer FROM [Sheet1$]"
        Try
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(query, connstring)
            dtQuest = New DataTable()
            da.Fill(dtQuest)
            For i = 0 To MaxQuestion - 1
                ArrQuestions(i) = New QuestionTT()
                'ArrQuestions(i).ID = dtQuest.Rows(i).Item("No")
                ArrQuestions(i).Type = dtQuest.Rows(i).Item("Type")
                If dtQuest.Rows(i).IsNull("Answer") = False Then
                    ArrQuestions(i).Answer = dtQuest.Rows(i).Item("Answer")
                End If
                If (dtQuest.Rows(i).IsNull("FilePath") = False) Then
                    ArrQuestions(i).FilePath = dtQuest.Rows(i).Item("FilePath")
                End If
                If (dtQuest.Rows(i).IsNull("Question") = False) Then
                    ArrQuestions(i).Question = dtQuest.Rows(i).Item("Question")
                End If
            Next i
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub
    Public Sub StartQuestion()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf StartQuestion))
        Else
            If (ArrQuestions(idQuest).Type = "Image") Then
                frm1.fSound.PlaySound(SoundPaths.TT30s)
            End If
            tmClock.Enabled = True
            frm1.Command = MyCommands.StartAnswerTT
        End If

    End Sub
    Public Sub StopQuestion()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf StopQuestion))
        Else
            Try
                WMP1.Ctlcontrols.stop()
                tmClock.Enabled = False
                frm1.fSound.StopSound()
            Catch ex As Exception
                '
            End Try
            
        End If

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
            pbImage.Visible = False
            WMP1.Visible = False
            pbClock.Location = New Point(pbClock.Location.X, topClock)
            idQuest += 1
            DisplayQuestion()
        End If
    End Sub

    Private Sub tmClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmClock.Tick
        pbClock.Location = New Point(pbClock.Location.X, pbClock.Location.Y + vantoc)
        If (pbClock.Location.Y >= bottomClock) Then
            tmClock.Enabled = False
        End If
    End Sub

    Private Sub WMP1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WMP1.Enter

    End Sub

    Private Sub WMP1_KeyDownEvent(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_KeyDownEvent) Handles WMP1.KeyDownEvent
        If (e.nKeyCode = Keys.F) Then
            If (WMP1.playState = WMPLib.WMPPlayState.wmppsPlaying) Then
                If (WMP1.fullScreen = False) Then
                    WMP1.fullScreen = True
                Else
                    WMP1.fullScreen = False
                End If
            End If
        End If
    End Sub


End Class