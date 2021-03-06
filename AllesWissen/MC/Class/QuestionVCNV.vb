Imports System.Collections.Generic

Public Enum VCNVState
    ChuaLat = 1
    DangLat = 2
    BoQua = 3
    DaLat = 4
    DaLatSang = 5
End Enum

Public Class QuestionVCNV
    Public Question As String = ""
    Public Answer As String = ""
    Public Type As String = ""
    Public FilePath As String = ""
    Public Length As Integer = 0
    Public Begin As Integer = 1 'Vị trí bắt đầu ô chữ
    Public Sang1 As Integer = -1 'Vị trí đỏ của ô chữ
    Public Sang2 As Integer = -1
    Public lstWord As List(Of Label) = New List(Of Label)
    Public State As VCNVState = VCNVState.ChuaLat
    Public SleepTime As Integer = 100

    Public Sub ChangeState(ByVal newState As VCNVState)
        State = newState
        Dim i As Integer
        Select Case newState
            Case VCNVState.ChuaLat
                For i = 0 To lstWord.Count - 1
                    'Blue:
                    lstWord(i).BackColor = Color.CornflowerBlue
                Next
            Case VCNVState.DangLat
                For i = 0 To lstWord.Count - 1
                    lstWord(i).BackColor = Color.Khaki
                    If (SleepTime > 0) Then
                        Application.DoEvents()
                        Threading.Thread.Sleep(SleepTime)
                    End If
                Next
            Case VCNVState.BoQua
                For i = 0 To lstWord.Count - 1
                    lstWord(i).BackColor = Color.Crimson
                Next
            Case VCNVState.DaLat
                'Đã lật, hiện chữ:
                For i = 0 To lstWord.Count - 1
                    lstWord(i).BackColor = Color.AntiqueWhite
                    lstWord(i).Text = Answer(i)
                    If (SleepTime > 0) Then
                        Application.DoEvents()
                        Threading.Thread.Sleep(SleepTime)
                    End If
                Next
                'Hiện ô đỏ:
                If (Sang1 <> -1) Then
                    lstWord(Sang1 - 1).BackColor = Color.Red
                    lstWord(Sang1 - 1).ForeColor = Color.White
                End If
                If (Sang2 <> -1) Then
                    lstWord(Sang2 - 1).BackColor = Color.Red
                    lstWord(Sang2 - 1).ForeColor = Color.White
                End If
            Case VCNVState.DaLatSang
                'Đã lật, hiện chữ:
                For i = 0 To lstWord.Count - 1
                    lstWord(i).BackColor = Color.AntiqueWhite
                    lstWord(i).Text = Answer(i)
                    If (SleepTime > 0) Then
                        Application.DoEvents()
                        Threading.Thread.Sleep(SleepTime)
                    End If
                Next
                'Hiện ô đỏ:
                If (Sang1 <> -1) Then
                    lstWord(Sang1 - 1).BackColor = Color.Red
                    lstWord(Sang1 - 1).ForeColor = Color.White
                End If
                If (Sang2 <> -1) Then
                    lstWord(Sang2 - 1).BackColor = Color.Red
                    lstWord(Sang2 - 1).ForeColor = Color.White
                End If
        End Select
    End Sub
End Class
