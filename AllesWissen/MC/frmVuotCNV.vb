Imports System.Data.OleDb
Imports System.Collections.Generic

Public Class frmVuotCNV

    Const MaxQuestion As Integer = 7

    Public frm1 As frmMain
    Private arrQuestions(MaxQuestion) As QuestionVCNV
    Private lstHeaders As List(Of Label)
    Private lstCNVNames As List(Of Label)
    Public idThiSinhCNV As Integer = -1 'id của thí sinh vừa bấm trả lời CNV
    Public idCNV As Integer = 0 'Số thí sinh đã trả lời CNV
    Private idQuest As Integer = 0
    Private idCurQuest As Integer = 0 'Id câu hỏi đang chọn
    Private timeConst As Integer = 15
    Private timeCount As Integer = 15

    Private Sub frmVuotCNV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.P
                Application.Exit()
            Case Keys.T
                'Bắt đầu tính giờ:
                frm1.Command = MyCommands.StartAnswerVCNV
                timeCount = timeConst
                lbTime.Text = timeCount
                frm1.fSound.PlaySound(SoundPaths.VCNV15s)
                tmTime.Enabled = True
            Case Keys.Z
                Undo()
            Case Keys.L
                'Lật hết:
                OpenAllWords()
            Case Keys.Space
                frm1.fSound2.PlaySound(SoundPaths.ChoTrong)
            Case Keys.N
                If arrQuestions(idCurQuest).Type = "Music" Then
                    frm1.fSound2.PlaySound(arrQuestions(idCurQuest).FilePath)
                End If
            Case Keys.Z
                'Nhạc trả lời sai:
                frm1.fSound2.PlaySound(SoundPaths.TraLoiSai)
            Case Keys.X
                'Nhạc trả lời đúng:
                frm1.fSound2.PlaySound(SoundPaths.TraLoiDung)
        End Select
    End Sub
    Private Sub loadQuestions(ByVal filename As String)
        Dim connstring As String
        Dim i As Integer
        Dim dtQuest As DataTable
        connstring = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
       "Data Source=" & filename & ";Extended Properties=""Excel 8.0;HDR=YES;"""

        Dim query As String = "SELECT Question, Answer, Begin, Length, Sang1, Sang2,Type,FilePath FROM [Sheet1$]"
        'Try
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(query, connstring)
        dtQuest = New DataTable()
        da.Fill(dtQuest)

        For i = 0 To MaxQuestion - 1
            arrQuestions(i) = New QuestionVCNV()
            If dtQuest.Rows(i).IsNull("Answer") = False Then
                arrQuestions(i).Answer = dtQuest.Rows(i).Item("Answer")
            End If
            If (dtQuest.Rows(i).IsNull("Question") = False) Then
                arrQuestions(i).Question = dtQuest.Rows(i).Item("Question")
            End If

        Next i
        'Catch ex As Exception
        'Debug.Print(ex.Message)
        'End Try
    End Sub
    Private Sub ShowQuestions(ByVal i As Integer)

        If (i < 0 Or i >= MaxQuestion) Then Exit Sub
        Dim Quest As QuestionVCNV = arrQuestions(i)
        'lbNum.Text = Quest.ID

        lbQuestion.Text = ""
        lbQuestion.Text = Quest.Question
        lbCategory.Text = Quest.Answer
        frm1.SendQuestion(arrQuestions(i).Question)
        
    End Sub
    Public Sub ShowNextQuest()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ShowNextQuest))
        Else

            ShowQuestions(idQuest)
            idQuest = idQuest + 1
        End If
    End Sub

    ''' <summary>
    ''' Lật hết 8 hàng ngang
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub OpenAllWords()
        Dim i As Integer
        frm1.fSound.PlaySound(SoundPaths.VCNV_Hien8HangNgang)
        For i = 0 To MaxQuestion - 1
            If (arrQuestions(i).State <> VCNVState.DaLat) Then
                arrQuestions(i).ChangeState(VCNVState.DaLat)
            End If
        Next
    End Sub

    Private Sub Undo()
        'Sửa đang lật thành chưa lật
        Dim i As Integer
        For i = 0 To MaxQuestion - 1
            If (arrQuestions(i).State = VCNVState.DangLat) Then
                arrQuestions(i).ChangeState(VCNVState.ChuaLat)
            End If
        Next
    End Sub

    Private Sub frmVuotCNV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbDaLat01.Text = ""
        lbDaLat02.Text = ""
        lbQuestion.Text = ""
        loadQuestions(".\Data\Round2\Round2.xls")
        frm1.MakeLabelTranparent(Me)
        InitArrays()
        InitWords()
        'Ẩn label tên thí sinh trả lời CNV
        Dim i As Integer
        For i = 0 To frmMain.MaxThiSinh - 1
            lstCNVNames(i).BackColor = Color.Red
            lstCNVNames(i).Visible = False
        Next
    End Sub

    Private Sub InitWords()
        Dim i As Integer
        Dim j As Integer
        Dim X As Integer 'Location X
        Dim lb As Label
        For i = 0 To MaxQuestion - 1
            For j = 0 To arrQuestions(i).Length - 1
                arrQuestions(i).Answer = UCase(arrQuestions(i).Answer)
                lb = New Label()
                lb.Font = Me.lbDaLat01.Font
                lb.TextAlign = Me.lbDaLat01.TextAlign
                lb.BackColor = Color.CornflowerBlue
                lb.Size = Me.lbChuaLat.Size
                X = lstHeaders(i).Location.X + 20 + (arrQuestions(i).Begin + j) * (lbChuaLat.Size.Width + 6)
                lb.Location = New Point(X, lstHeaders(i).Location.Y - 5)
                arrQuestions(i).lstWord.Add(lb)
                Me.Controls.Add(lb)
            Next
        Next
    End Sub

    Private Sub InitArrays()
        lstHeaders = New List(Of Label)
        lstHeaders.Add(lbHeader01)
        lstHeaders.Add(lbHeader02)
        lstHeaders.Add(lbHeader03)
        lstHeaders.Add(lbHeader04)
        lstHeaders.Add(lbHeader05)
        lstHeaders.Add(lbHeader06)
        lstHeaders.Add(lbHeader07)
        lstHeaders.Add(lbHeader08)
        'Tên thí sinh trả lời CNV:
        lstCNVNames = New List(Of Label)
        lstCNVNames.Add(lbCNVName01)
        lstCNVNames.Add(lbCNVName02)
        lstCNVNames.Add(lbCNVName03)
        lstCNVNames.Add(lbCNVName04)
    End Sub

    Private Sub lbHeader01_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbHeader01.MouseClick, lbHeader02.MouseClick, lbHeader03.MouseClick, lbHeader04.MouseClick, lbHeader05.MouseClick, lbHeader06.MouseClick, lbHeader07.MouseClick, lbHeader08.MouseClick
        Dim lb As Label
        Dim id As Integer
        lb = CType(sender, Label)
        id = lstHeaders.IndexOf(lb)
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Select Case arrQuestions(id).State
                Case VCNVState.ChuaLat
                    frm1.fSound.PlaySound(SoundPaths.VCNV_ChonHangNgang)
                    idCurQuest = id
                    arrQuestions(id).ChangeState(VCNVState.DangLat)
                    ShowQuestions(id)
                Case VCNVState.DangLat
                    'Đang lật thì lật
                    lbQuestion.Text = ""
                    frm1.SendQuestion("")
                    frm1.fSound.PlaySound(SoundPaths.VCNV_HienSangChu)
                    arrQuestions(id).ChangeState(VCNVState.DaLat)
                Case VCNVState.BoQua
                    'Đang bỏ qua thì lật lại
                    arrQuestions(id).ChangeState(VCNVState.DaLat)
            End Select
        End If
        If (e.Button = Windows.Forms.MouseButtons.Right) Then
            Select Case arrQuestions(id).State
                Case VCNVState.DangLat
                    'Đang lật thì bỏ qua ko lật
                    lbQuestion.Text = ""
                    frm1.SendQuestion("")
                    arrQuestions(id).ChangeState(VCNVState.BoQua)
            End Select
        End If
    End Sub

    Private Sub tmTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmTime.Tick
        timeCount -= 1
        lbTime.Text = timeCount
        If (timeCount = 0) Then
            tmTime.Enabled = False
        End If
    End Sub

    Public Sub ShowThiSinhCNV()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ShowThiSinhCNV))
        Else
            lstCNVNames(idCNV).Text = frm1.ArrThiSinh(idThiSinhCNV).name
            lstCNVNames(idCNV).Visible = True
            idCNV += 1
            frm1.fSound2.PlaySound(SoundPaths.GianhQuyen)
        End If
    End Sub

    Private Sub lbCNVName01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbCNVName01.Click, lbCNVName02.Click, lbCNVName03.Click, lbCNVName04.Click
        Dim lb As Label
        lb = CType(sender, Label)
        lb.Hide()
    End Sub
End Class