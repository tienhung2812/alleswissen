Imports System.Collections.Generic

Public Class frmVCNVPic
    Public frm1 As frmMain

    Private lstLabels As List(Of Label) 'Chứa các miếng ghép
    Private imagePath As String = ".\Images\VCNV.jpg"
    Private picWidth As Integer = 1024
    Private picHeight As Integer = 768

    Private Sub frmVCNVPic_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.P
                Application.Exit()
            Case Keys.L
                'Lật hết
                showAll()
        End Select
    End Sub


    Private Sub showAll()
        Dim i As Integer
        Dim lb As Label
        For i = 0 To 8 - 1
            lb = lstLabels.Item(i)
            lb.Visible = True
        Next
    End Sub

    Private Sub frmVCNVPic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Width = picWidth
        Panel1.Height = picHeight
        Panel1.BackgroundImage = Image.FromFile(imagePath)
        initLabels()
    End Sub

    Private Sub initLabels()
        Dim i As Integer
        Dim lb As Label
        lstLabels = New List(Of Label)
        For i = 0 To 8 - 1
            lb = New Label()
            lb.Font = lbSample.Font
            lb.ForeColor = lbSample.ForeColor
            lb.Size = New Size(picWidth / 4, picHeight / 2)
            lb.Location = New Point((i Mod 4) * lb.Width, (i \ 4) * lb.Height)
            lb.BackColor = lbSample.BackColor
            lb.BorderStyle = lbSample.BorderStyle
            lb.TextAlign = lbSample.TextAlign
            lb.Text = i + 1
            AddHandler lb.DoubleClick, AddressOf lbSample_DoubleClick
            lstLabels.Add(lb)
            lb.Visible = True
            Panel1.Controls.Add(lb)
        Next
    End Sub

    Private Sub Pb1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lbSample_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbSample.DoubleClick
        Dim lb As Label = CType(sender, Label)
        lb.Visible = False
    End Sub
End Class