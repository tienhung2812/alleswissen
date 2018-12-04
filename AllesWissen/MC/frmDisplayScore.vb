Public Class frmDisplayScore

    Public frm1 As frmMain
    Const MaxThiSinh As Integer = 3
    Dim ArrNames As ArrayList
    Dim ArrScores As ArrayList

    Private Sub frmDisplayScore_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.P
                Application.Exit()
        End Select
    End Sub

    Private Sub frmDisplayScore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddArray()
        frm1.MakeLabelTranparent(Me)       
    End Sub

    Public Sub ShowScores()
        Dim i As Integer
        PlayShowingSound()
        For i = 0 To MaxThiSinh - 1
            SetScore(i)
            Application.DoEvents()
            Threading.Thread.Sleep(20)
        Next
    End Sub

    Private Sub PlayShowingSound()
        Dim i As Integer
        frm1.fSound.PlaySound(SoundPaths.HienForm)
        For i = 1 To 30
            Application.DoEvents()
            Threading.Thread.Sleep(20)
        Next
    End Sub

    Private Sub SetScore(ByVal id As Integer)        
        Dim lbName As Label = CType(ArrNames(id), Label)
        Dim lbScore As Label = CType(ArrScores(id), Label)
        lbName.Text = frm1.ArrThiSinh(id).name
        lbScore.Text = frm1.ArrThiSinh(id).score
    End Sub

    Private Sub AddArray()
        ArrNames = New ArrayList()
        ArrScores = New ArrayList()
        ArrNames.Add(lbName01)
        ArrNames.Add(lbName02)
        ArrNames.Add(lbName03)
        'ArrNames.Add(lbName04)
        ArrScores.Add(lbScore01)
        ArrScores.Add(lbScore02)
        ArrScores.Add(lbScore03)
        'ArrScores.Add(lbScore04)
        Dim i As Integer
        Dim lb As Label
        For i = 0 To frmMain.MaxThiSinh - 1
            lb = CType(ArrNames(i), Label)
            lb.Text = ""
            lb = CType(ArrScores(i), Label)
            lb.Text = ""
        Next
    End Sub
End Class