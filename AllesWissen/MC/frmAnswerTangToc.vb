Imports System.Collections.Generic

Public Class frmAnswerTangToc

    Public frm1 As frmMain

    Private lstNames As List(Of Label)
    Private lstAnswers As List(Of Label)
    Private lstTimes As List(Of Label)
    Private lstImages As List(Of PictureBox)

    Public arrThiSinh(frmMain.MaxThiSinh) As Contestant

    Private Sub frmAnswerTangToc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (IsNothing(lstNames)) Then
            InitArrays()
            frm1.MakeLabelTranparent(Me)
        End If
    End Sub

    Public Sub SortContestants()
        Dim i As Integer
        Dim j As Integer
        Dim time1 As Integer
        Dim time2 As Integer
        For i = 0 To frmMain.MaxThiSinh - 1
            If (arrThiSinh(i).Answer = "") Then
                arrThiSinh(i).TimeCount = 40000
            End If
        Next
        'Bắt đầu sort theo timeCount
        Dim temp As Contestant
        For i = 0 To frmMain.MaxThiSinh - 2
            For j = i + 1 To frmMain.MaxThiSinh - 1
                time1 = Convert.ToInt32(arrThiSinh(i).TimeCount)
                time2 = Convert.ToInt32(arrThiSinh(j).TimeCount)
                If (time1 > time2) Then
                    temp = arrThiSinh(i)
                    arrThiSinh(i) = arrThiSinh(j)
                    arrThiSinh(j) = temp
                End If
            Next
        Next
    End Sub

    ''' <summary>
    ''' Điền thông tin vào các control
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub FillArrays()
        Dim i As Integer
        Dim time1 As Integer
        If (IsNothing(lstNames)) Then
            InitArrays()
            frm1.MakeLabelTranparent(Me)
        End If
        Me.arrThiSinh = frm1.ArrThiSinh.Clone()
        ClearLabels()
        'Âm thanh:
        Application.DoEvents()
        frm1.fSound.PlaySound(SoundPaths.TTShowAnswers)
        For i = 0 To 30
            Application.DoEvents()
            Threading.Thread.Sleep(100)
        Next

        'Sắp xếp:
        SortContestants()
        For i = 0 To frmMain.MaxThiSinh - 1
            time1 = Convert.ToInt32(arrThiSinh(i).TimeCount)
            lstNames(i).Text = arrThiSinh(i).name
            If (time1 > 3000 And time1 < 40000) Then
                'Nếu chậm hơn 30s thì tính thành 29.99 giây
                lstTimes(i).Text = "29.99"
                lstAnswers(i).Text = UCase(arrThiSinh(i).Answer)
            ElseIf (time1 = 40000) Then
                lstTimes(i).Text = "_"
                lstAnswers(i).Text = ""
            Else
                lstTimes(i).Text = (time1 / 100).ToString("0.00")
                lstAnswers(i).Text = UCase(arrThiSinh(i).Answer)
            End If
            lstImages(i).Image = Image.FromFile(arrThiSinh(i).imagePath)
            lstImages(i).Visible = True
        Next
    End Sub

    Private Sub ClearLabels()
        Dim i As Integer
        For i = 0 To frmMain.MaxThiSinh - 1
            lstAnswers(i).Text = ""
            lstNames(i).Text = ""
            lstTimes(i).Text = ""
            lstImages(i).Visible = False
        Next
    End Sub

    Private Sub InitArrays()
        'Name:
        lstNames = New List(Of Label)()
        lstNames.Add(lbName01)
        lstNames.Add(lbName02)
        lstNames.Add(lbName03)
        lstNames.Add(lbName04)
        'Answer:
        lstAnswers = New List(Of Label)()
        lstAnswers.Add(lbAnswer01)
        lstAnswers.Add(lbAnswer02)
        lstAnswers.Add(lbAnswer03)
        lstAnswers.Add(lbAnswer04)
        'Time:
        lstTimes = New List(Of Label)()
        lstTimes.Add(lbTime01)
        lstTimes.Add(lbTime02)
        lstTimes.Add(lbTime03)
        lstTimes.Add(lbTime04)
        'Pictures:
        lstImages = New List(Of PictureBox)()
        lstImages.Add(pbImage01)
        lstImages.Add(pbImage02)
        lstImages.Add(pbImage03)
        lstImages.Add(pbImage04)
    End Sub

End Class