Public Class frmSound

    Private FilePath As String

    Private Sub TurnSoundOn()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf TurnSoundOn))
        Else
            WMP1.URL = FilePath
            WMP1.Ctlcontrols.play()
        End If
    End Sub

    Public Sub PlaySound(ByVal path As String)
        FilePath = path
        TurnSoundOn()
    End Sub
    Private Sub TurnSoundOff()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf TurnSoundOff))
        Else
            'WMP1.URL = FilePath
            WMP1.Ctlcontrols.stop()
        End If
    End Sub

    Public Sub StopSound()
        TurnSoundOff()
    End Sub
    Private Sub frmSound_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WMP1.uiMode = "none"
        'WMP1.settings.volume = 100
        Me.Hide()
    End Sub
End Class