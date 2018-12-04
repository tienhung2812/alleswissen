Public Class frmWait

    Private vX As Integer = 3
    Private vY As Integer = 3
    Public frm1 As frmMain

    Private Sub frmWait_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.P) Then
            Application.Exit()
        End If
        Select Case e.KeyCode
            Case Keys.B
                frm1.fSound2.PlaySound(SoundPaths.BatDauPhanThi)
        End Select
    End Sub

    Private Sub frmWait_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WMP1.Visible = False
        Label1.Visible = False
        ''Label1.Text = ""
        ''WMP1.uiMode = "none"
        ''WMP1.Location = New Point(0, 0)
        ''WMP1.Size = New Size(1024, 768)
        ''WMP1.settings.setMode("loop", True)
        ''WMP1.settings.volume = 0
        ''Try
        ''    WMP1.URL = SoundPaths.ClipWait
        ''    WMP1.Ctlcontrols.play()
        ''    WMP1.fullScreen = True
        ''Catch
        ''    Debug.Print("error form wait")
        ''End Try
    End Sub

    Private Sub tmAnimate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmAnimate.Tick        
    End Sub

    Private Sub frmWait_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        'If (Me.Visible = False) Then
        '    WMP1.fullScreen = False
        '    WMP1.Ctlcontrols.stop()
        'Else
        '    WMP1.Ctlcontrols.play()
        '    WMP1.fullScreen = True
        'End If
    End Sub
End Class