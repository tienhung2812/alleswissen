Public Class frmIntroKD

    Dim appPath As String = Application.StartupPath
    Dim filePath As String = "\Clips\khoi dong.swf"

    Private Sub frmIntroKD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.P
                Application.ExitThread()
                Application.Exit()
        End Select
    End Sub

    Public Sub setFilePath(ByVal newPath As String)
        filePath = newPath
    End Sub


    Private Sub frmIntroKD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Debug.Print(appPath & filePath)
        'With (AxShockwaveFlash1)
        '.Movie = appPath & filePath
        '.Size = New Size(1024, 768)
        '.Loop = False
        '.Play()
        'End With
    End Sub

    Private Sub frmIntroKD_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        If (Me.Visible = False) Then
            ' AxShockwaveFlash1.Stop()
        Else
            '  AxShockwaveFlash1.Movie = appPath & filePath
            '  AxShockwaveFlash1.Loop = False
            '  AxShockwaveFlash1.Play()
        End If
    End Sub
End Class