Imports System.Data.OleDb
Imports System.Data
Imports System.Collections.Generic

Public Class frmVeDich

    Const MaxQuestion As Integer = 28
    Public frm1 As frmMain
    Public KDFileName As String
    Public ArrQuestions(MaxQuestion) As QuestionVD
    Private lstVDNames As List(Of Label) 'Chứa label tên các thí sinh khác
    Private idThiSinhGianhQuyen As Integer = -1
    Private isGianhQuyen As Boolean = False 'Xác định xem có ai giành quyền chưa

    Private Sub frmVeDich_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'frm1.MakeLabelTranparent(Me)
        InitArrays()
        'Me.BackgroundImage = Image.FromFile(".\Images\VD\VD1.jpg")
        loadQuestions(".\Data\Round4\Round4.xls")
        'Ẩn các control:
        lbQuestionScore.Text = ""
        lbQuestion.Text = ""
        lbNum.Text = ""
    End Sub
    Private Sub InitArrays()
        lstVDNames = New List(Of Label)
        lstVDNames.Add(lbVDName01)
        lstVDNames.Add(lbVDName02)
        lstVDNames.Add(lbVDName03)
        lstVDNames.Add(lbVDName04)
        Dim i As Integer
        For i = 0 To frmMain.MaxThiSinh - 1
            lstVDNames(i).Text = frm1.ArrThiSinh(i).name
        Next
    End Sub
    Private Sub frmVeDich_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.D0
                DisplayQuestion(9)
            Case Keys.P 'Thoát
                Application.Exit()
            Case Keys.Q
                'Cho phép thí sinh khác giành quyền:
                Me.isGianhQuyen = False
                frm1.Command = MyCommands.AllowVeDich
                frm1.fSound2.PlaySound(SoundPaths.VD5sGianhQuyenh)
            Case Keys.Space
                frm1.fSound2.PlaySound(SoundPaths.ChoTrong)
        End Select
    End Sub

    Public Sub LoadSport1()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadSport1))
        Else
            lbSport1.BackColor = Color.Gray
            DisplayQuestion(0)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadSport2()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadSport2))
        Else
            lbSport2.BackColor = Color.Gray
            DisplayQuestion(1)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadSport3()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadSport3))
        Else
            lbSport3.BackColor = Color.Gray
            DisplayQuestion(2)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadSportE()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadSportE))
        Else
            DisplayQuestion(3)
            TransparentAllLabels()
        End If
    End Sub

    Public Sub LoadMusic1()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadMusic1))
        Else
            lbMusic1.BackColor = Color.Gray
            DisplayQuestion(4)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadMusic2()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadMusic2))
        Else
            lbMusic2.BackColor = Color.Gray
            DisplayQuestion(5)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadMusic3()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadMusic3))
        Else
            lbMusic3.BackColor = Color.Gray
            DisplayQuestion(6)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadMusicE()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadMusicE))
        Else
            DisplayQuestion(7)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadHisGeo1()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadHisGeo1))
        Else
            lbHisGeo1.BackColor = Color.Gray
            DisplayQuestion(8)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadHisGeo2()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadHisGeo2))
        Else
            lbHisGeo2.BackColor = Color.Gray
            DisplayQuestion(9)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadHisGeo3()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadHisGeo3))
        Else
            lbHisGeo3.BackColor = Color.Gray
            DisplayQuestion(10)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadHisGeoE()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadHisGeoE))
        Else
            DisplayQuestion(11)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadScience1()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadScience1))
        Else
            lbScience1.BackColor = Color.Gray
            DisplayQuestion(12)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadScience2()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadScience2))
        Else
            lbScience2.BackColor = Color.Gray
            DisplayQuestion(13)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadScience3()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadScience3))
        Else
            lbScience3.BackColor = Color.Gray
            DisplayQuestion(14)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadScienceE()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadScienceE))
        Else
            DisplayQuestion(15)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadFA1()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadFA1))
        Else
            lbFA1.BackColor = Color.Gray
            DisplayQuestion(16)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadFA2()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadFA2))
        Else
            lbFA2.BackColor = Color.Gray
            DisplayQuestion(17)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadFA3()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadFA3))
        Else
            lbFA3.BackColor = Color.Gray
            DisplayQuestion(18)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadFAE()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadFAE))
        Else
            DisplayQuestion(19)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadEEIT1()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadEEIT1))
        Else
            lbEEIT1.BackColor = Color.Gray
            DisplayQuestion(20)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadEEIT2()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadEEIT2))
        Else
            lbEEIT2.BackColor = Color.Gray
            DisplayQuestion(21)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadEEIT3()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadEEIT3))
        Else
            lbEEIT3.BackColor = Color.Gray
            DisplayQuestion(22)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadEEITE()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadEEITE))
        Else
            DisplayQuestion(23)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadCS1()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadCS1))
        Else
            lbCS1.BackColor = Color.Gray
            DisplayQuestion(24)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadCS2()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadCS2))
        Else
            lbCS2.BackColor = Color.Gray
            DisplayQuestion(25)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadCS3()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadCS3))
        Else
            lbCS3.BackColor = Color.Gray
            DisplayQuestion(26)
            TransparentAllLabels()
        End If
    End Sub
    Public Sub LoadCSE()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadCSE))
        Else
            DisplayQuestion(27)
            TransparentAllLabels()
        End If
    End Sub

    Private Sub DisplayQuestion(ByVal idQuest As Integer)
        If (idQuest < 0 Or idQuest > 27) Then Exit Sub
        'TurnOffAllLights()
        TransparentAllLabels()
        lbQuestionScore.Text = ArrQuestions(idQuest).Score
        lbQuestion.Text = ArrQuestions(idQuest).Question
        frm1.SendQuestion(ArrQuestions(idQuest).Question)

    End Sub

    Private Sub Sleep(ByVal milSec As Integer)
        Application.DoEvents()
        System.Threading.Thread.Sleep(milSec)
    End Sub
    Private Sub loadQuestions(ByVal filename As String)
        Dim connstring As String
        Dim i As Integer
        Dim dtQuest As DataTable
        connstring = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
       "Data Source=" & filename & ";Extended Properties=""Excel 8.0;HDR=YES;"""
        Debug.Print(connstring)
        Dim query As String = "SELECT Type, FilePath, Question, Score FROM [Sheet1$]"
        Try
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(query, connstring)
            dtQuest = New DataTable()
            da.Fill(dtQuest)
            For i = 0 To MaxQuestion - 1
                ArrQuestions(i) = New QuestionVD()
                ArrQuestions(i).Question = dtQuest.Rows(i).Item("Question")
                If (dtQuest.Rows(i).IsNull("Type") = False) Then
                    ArrQuestions(i).Type = dtQuest.Rows(i).Item("Type")
                End If
                If (dtQuest.Rows(i).IsNull("FilePath") = False) Then
                    ArrQuestions(i).FilePath = dtQuest.Rows(i).Item("FilePath")
                End If
                If (dtQuest.Rows(i).IsNull("Score") = False) Then
                    ArrQuestions(i).Score = dtQuest.Rows(i).Item("Score")
                End If
            Next i
            Debug.Print("Test Quest Vedich: " + ArrQuestions(MaxQuestion - 1).Question)
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Public Sub ShowThiSinhVeDich(ByVal tsName As String)

        Dim i As Integer
        For i = 0 To lstVDNames.Count - 1
            If (lstVDNames(i).Text = tsName) Then
                lstVDNames(i).BackColor = Color.Red
                'idThiSinhGianhQuyen = i
                Me.isGianhQuyen = True

                frm1.fSound2.PlaySound(SoundPaths.GianhQuyen)
                'Debug.Print("Showed Picture" & i)
            End If
        Next
    End Sub

    Public Sub TransparentAllLabels()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf TransparentAllLabels))
        Else
            Try
                Dim i As Integer
                For i = 0 To lstVDNames.Count - 1
                    lstVDNames(i).BackColor = Color.Transparent
                    lstVDNames(i).ForeColor = Color.Black
                Next
            Catch ex As Exception
                '
            End Try
        End If
    End Sub

End Class