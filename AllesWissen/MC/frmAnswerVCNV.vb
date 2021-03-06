Imports System.Collections.Generic

Public Class frmAnswerVCNV

    Public frm1 As frmMain

    Private lstNames As List(Of Label)
    Private lstAnswers As List(Of Label)

    Public arrThiSinh(frmMain.MaxThiSinh) As Contestant

    Private Sub frmAnswerTangToc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (IsNothing(lstNames)) Then
            InitArrays()
            frm1.MakeLabelTranparent(Me)
        End If
    End Sub


    ''' <summary>
    ''' Điền thông tin vào các control
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub FillArrays()
        Dim i As Integer
        If (IsNothing(lstNames)) Then
            InitArrays()
            frm1.MakeLabelTranparent(Me)
        End If
        ClearLabels()
        frm1.fSound.PlaySound(SoundPaths.VCNV_HienTraLoi)
        For i = 0 To 20
            Application.DoEvents()
            Threading.Thread.Sleep(100)
        Next

        Me.arrThiSinh = frm1.ArrThiSinh.Clone()
        For i = 0 To frmMain.MaxThiSinh - 1
            lstNames(i).Text = arrThiSinh(i).name
            lstAnswers(i).Text = UCase(arrThiSinh(i).Answer)
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
    End Sub

    Private Sub ClearLabels()
        Dim i As Integer
        For i = 0 To frmMain.MaxThiSinh - 1
            lstAnswers(i).Text = ""
            lstNames(i).Text = ""            
        Next
    End Sub

End Class