Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports System.Data.OleDb
Imports System.Data

Public Class frmMain
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnIPAddress As System.Windows.Forms.MenuItem
    Friend WithEvents mnTeamName As System.Windows.Forms.MenuItem
    Friend WithEvents mnConnect As System.Windows.Forms.MenuItem
    Friend WithEvents lbTeamName As System.Windows.Forms.Label
    Friend WithEvents btnKhoiDong As System.Windows.Forms.Button
    Friend WithEvents btnTangToc As System.Windows.Forms.Button
    Friend WithEvents btnVeDich As System.Windows.Forms.Button
    Friend WithEvents btnShowWait As System.Windows.Forms.Button
    Friend WithEvents btnShowIntroKD As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnVCNVPic As System.Windows.Forms.Button
    Friend WithEvents btnShowVCNV As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.mnIPAddress = New System.Windows.Forms.MenuItem()
        Me.mnTeamName = New System.Windows.Forms.MenuItem()
        Me.mnConnect = New System.Windows.Forms.MenuItem()
        Me.lbTeamName = New System.Windows.Forms.Label()
        Me.btnKhoiDong = New System.Windows.Forms.Button()
        Me.btnTangToc = New System.Windows.Forms.Button()
        Me.btnShowVCNV = New System.Windows.Forms.Button()
        Me.btnVeDich = New System.Windows.Forms.Button()
        Me.btnShowWait = New System.Windows.Forms.Button()
        Me.btnShowIntroKD = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnVCNVPic = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnIPAddress, Me.mnTeamName, Me.mnConnect})
        Me.MenuItem1.Text = "Setting"
        '
        'mnIPAddress
        '
        Me.mnIPAddress.Index = 0
        Me.mnIPAddress.Text = "IP Address"
        '
        'mnTeamName
        '
        Me.mnTeamName.Index = 1
        Me.mnTeamName.Text = "Team Name"
        Me.mnTeamName.Visible = False
        '
        'mnConnect
        '
        Me.mnConnect.Index = 2
        Me.mnConnect.Text = "Connect"
        '
        'lbTeamName
        '
        Me.lbTeamName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbTeamName.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTeamName.Location = New System.Drawing.Point(165, 16)
        Me.lbTeamName.Name = "lbTeamName"
        Me.lbTeamName.Size = New System.Drawing.Size(240, 24)
        Me.lbTeamName.TabIndex = 4
        Me.lbTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbTeamName.Visible = False
        '
        'btnKhoiDong
        '
        Me.btnKhoiDong.Location = New System.Drawing.Point(17, 13)
        Me.btnKhoiDong.Name = "btnKhoiDong"
        Me.btnKhoiDong.Size = New System.Drawing.Size(75, 23)
        Me.btnKhoiDong.TabIndex = 8
        Me.btnKhoiDong.Text = "Khoi Dong"
        Me.btnKhoiDong.UseVisualStyleBackColor = True
        '
        'btnTangToc
        '
        Me.btnTangToc.Location = New System.Drawing.Point(240, 13)
        Me.btnTangToc.Name = "btnTangToc"
        Me.btnTangToc.Size = New System.Drawing.Size(75, 23)
        Me.btnTangToc.TabIndex = 9
        Me.btnTangToc.Text = "Tang toc"
        Me.btnTangToc.UseVisualStyleBackColor = True
        '
        'btnShowVCNV
        '
        Me.btnShowVCNV.Location = New System.Drawing.Point(125, 13)
        Me.btnShowVCNV.Name = "btnShowVCNV"
        Me.btnShowVCNV.Size = New System.Drawing.Size(75, 23)
        Me.btnShowVCNV.TabIndex = 10
        Me.btnShowVCNV.Text = "VCNV"
        Me.btnShowVCNV.UseVisualStyleBackColor = True
        '
        'btnVeDich
        '
        Me.btnVeDich.Location = New System.Drawing.Point(340, 13)
        Me.btnVeDich.Name = "btnVeDich"
        Me.btnVeDich.Size = New System.Drawing.Size(75, 23)
        Me.btnVeDich.TabIndex = 11
        Me.btnVeDich.Text = "Về đích"
        Me.btnVeDich.UseVisualStyleBackColor = True
        '
        'btnShowWait
        '
        Me.btnShowWait.Location = New System.Drawing.Point(17, 94)
        Me.btnShowWait.Name = "btnShowWait"
        Me.btnShowWait.Size = New System.Drawing.Size(93, 23)
        Me.btnShowWait.TabIndex = 12
        Me.btnShowWait.Text = "Màn hình chờ"
        Me.btnShowWait.UseVisualStyleBackColor = True
        '
        'btnShowIntroKD
        '
        Me.btnShowIntroKD.Location = New System.Drawing.Point(125, 94)
        Me.btnShowIntroKD.Name = "btnShowIntroKD"
        Me.btnShowIntroKD.Size = New System.Drawing.Size(103, 23)
        Me.btnShowIntroKD.TabIndex = 13
        Me.btnShowIntroKD.Text = "Intro Khoi dong"
        Me.btnShowIntroKD.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnVCNVPic)
        Me.Panel1.Controls.Add(Me.btnShowIntroKD)
        Me.Panel1.Controls.Add(Me.btnShowWait)
        Me.Panel1.Controls.Add(Me.btnVeDich)
        Me.Panel1.Controls.Add(Me.btnShowVCNV)
        Me.Panel1.Controls.Add(Me.btnTangToc)
        Me.Panel1.Controls.Add(Me.btnKhoiDong)
        Me.Panel1.Location = New System.Drawing.Point(87, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(433, 129)
        Me.Panel1.TabIndex = 14
        Me.Panel1.Visible = False
        '
        'btnVCNVPic
        '
        Me.btnVCNVPic.Location = New System.Drawing.Point(125, 42)
        Me.btnVCNVPic.Name = "btnVCNVPic"
        Me.btnVCNVPic.Size = New System.Drawing.Size(75, 23)
        Me.btnVCNVPic.TabIndex = 14
        Me.btnVCNVPic.Text = "Hình VCNV"
        Me.btnVCNVPic.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(611, 338)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbTeamName)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MC - AllesWissen (Demo)"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Const MaxThiSinh As Integer = 3 'Có 3 team
    Public Client As New TcpClient
    Dim ip As String = "127.0.0.1"
    Dim port As Integer = 8000
    Dim isDisconnected As Boolean = False
    Dim isConnected As Boolean = False
    'Dim logWriter As IO.StreamWriter

    Public answer As String
    Public Question As String = ""
    Public TeamName As String = "Team1"
    Public isSending As Boolean = False
    Public isSendName As Boolean = False
    Private Stream As NetworkStream

    Dim clientRead As System.Threading.Thread 'New System.Threading.Thread(AddressOf ClientThreadRead)
    Dim clientWrite As System.Threading.Thread 'New Threading.Thread(AddressOf ClientThreadWrite)

    Dim answerTime As Integer = 0 'Number of answer allowed
    'New:
    Public ArrThiSinh(MaxThiSinh) As Contestant
    Public idThiSinh As Integer 'id của thí sinh sắp thi Khởi động hay Về đích
    Public FilePath As String ' FilePath received from server
    Dim frmKD As frmKhoiDong
    Dim frmVCNV As frmVuotCNV = Nothing
    Dim frmVCNVAnswer As frmAnswerVCNV = Nothing
    Dim frmTT As frmTangToc = Nothing
    Dim frmTTAnswer As frmAnswerTangToc = Nothing
    Dim frmWeit As frmWait = New frmWait()
    Dim frmScore As frmDisplayScore
    Dim frmVD As frmVeDich
    'Intro form
    Dim frmIntro As frmIntroKD
    Dim introFilePath As String = "\Clips\khoi dong.swf"

    Public fSound As frmSound
    Public fSound2 As frmSound2
    Public Command As Integer 'Mã lệnh de truyen ve Server
    Dim frmVCNV_Pic As frmVCNVPic = New frmVCNVPic()

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.S) Then
            'Panel1.Visible = True
        End If
    End Sub

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim logPath As String
        logPath = Application.StartupPath
        If (logPath.Length > 3) Then logPath += "\"
        'logPath += "ClientLog.txt"
        'logWriter = New IO.StreamWriter(logPath)
        readTeamName()
        'New:
        loadContestants(".\Data\Contestant.xls")
        fSound = New frmSound()
        fSound2 = New frmSound2()
        fSound.Show()
        fSound.Hide()
        fSound2.Show()
        fSound2.Hide()
        Me.Show()
        frmWeit.frm1 = Me
    End Sub

    Private Sub readTeamName()
        Dim oRead As System.IO.StreamReader
        oRead = File.OpenText("name.txt")
        Dim teamName As String = oRead.ReadLine()
        ip = oRead.ReadLine()
        lbTeamName.Text = teamName
        Me.TeamName = teamName
        oRead.Close()
    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        isConnected = True
        isDisconnected = True
        'logWriter.Flush()
        'logWriter.Close()
    End Sub

    Private Sub mnIPAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnIPAddress.Click
        ip = InputBox("Type Server's IP: ", "IP input", ip)
    End Sub

    Public Sub ClientThreadWrite()
        Try
            Do
                'nothing
            Loop Until isConnected
            Dim w As New BinaryWriter(Stream)
            w.Write(MyMessages.RequestConnect)
            Do
                If (Command <> MyCommands.Normal) Then
                    Select Case Command
                        Case MyCommands.StartAnswerTT
                            'Cho phép trả lời phần tăng tốc
                            w.Write(MsgTangToc.StartAnswer)
                        Case MyCommands.StartAnswerVCNV
                            'Cho phép trả lời 1 ô chữ trong VCNV
                            w.Write(MsgVCNV.StartAnswer)
                        Case MyCommands.AllowVeDich
                            'Cho phép giành quyền VD:
                            w.Write(MyMessages.AllowVeDich)
                        Case MyCommands.SendQuestion
                            w.Write(MyMessages.SendQuestion)
                            w.Write(Me.Question)
                    End Select
                    Command = MyCommands.Normal
                End If
                'Sleep
                Threading.Thread.Sleep(20)
            Loop Until isDisconnected
            If (isDisconnected) Then
                w.Write(MyMessages.Disconnect)
            End If

        Catch ex As Exception
            Try
                'logWriter.WriteLine(ex.ToString())
            Catch exc As Exception
                'nothing
            End Try
        End Try
    End Sub

    Private Sub CloseOtherForms()
        On Error Resume Next
        Me.Hide()
        frmWeit.Hide()

        frmIntro.Close()
        frmIntro.Dispose()
        
        'Score form
        frmScore.Hide()
        frmScore = Nothing

        'Khoi dong
        frmKD.Hide()
        frmKD = Nothing

        'Tang toc:
        frmTT.Hide()
        frmTT = Nothing
        frmTTAnswer.Hide()
        frmTTAnswer = Nothing

        'VCNV:
        frmVCNV.Hide()
        frmVCNV = Nothing
        frmVCNVAnswer.Hide()
        frmVCNVAnswer = Nothing
        frmVCNV_Pic.Hide()
        frmVCNV_Pic = Nothing
        'VeDIch:
        frmVD.Hide()
        frmVD = Nothing
    End Sub

    Private Sub ShowKhoiDong()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ShowKhoiDong))
        Else
            CloseOtherForms()
            frmKD = New frmKhoiDong()
            frmKD.frm1 = Me
            frmKD.Show()
        End If
    End Sub

    Private Sub ShowScoreForm()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ShowScoreForm))
        Else
            CloseOtherForms()
            frmScore = New frmDisplayScore()
            frmScore.frm1 = Me
            frmScore.Show()
            frmScore.ShowScores()
        End If
    End Sub

    Private Sub ShowWaitForm()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ShowWaitForm))
        Else
            CloseOtherForms()
            frmWeit.Show()
        End If
    End Sub

    Private Sub ShowIntroForm()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ShowIntroForm))
        Else
            CloseOtherForms()            
            frmIntro = New frmIntroKD()
            frmIntro.setFilePath(introFilePath)
            frmIntro.Show()
        End If
    End Sub


    Public Sub ShowTangToc()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ShowTangToc))
        Else
            Me.Hide()
            frmWeit.Hide()

            Try
                frmIntro.Close()
                frmIntro.Dispose()
            Catch
            End Try
            If (IsNothing(frmTTAnswer) = False) Then
                frmTTAnswer.Hide()
            End If
            If (IsNothing(frmTT)) Then
                frmTT = New frmTangToc()
                frmTT.frm1 = Me
            End If
            frmTT.Show()
        End If
    End Sub

    Public Sub ShowVCNV()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ShowVCNV))
        Else
            Me.Hide()
            frmWeit.Hide()
            Try
                frmIntro.Close()
                frmIntro.Dispose()
            Catch
            End Try
            If (IsNothing(frmVCNVAnswer) = False) Then
                frmVCNVAnswer.Hide()
            End If
            If (IsNothing(frmVCNV_Pic) = False) Then
                frmVCNV_Pic.Hide()
            End If
            If (IsNothing(frmVCNV)) Then
                frmVCNV = New frmVuotCNV()
                frmVCNV.frm1 = Me
            End If
            frmVCNV.Show()
        End If
    End Sub

    Public Sub ShowAnswerVCNV()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ShowAnswerVCNV))
        Else
            Me.Hide()
            frmWeit.Hide()
            Try
                frmIntro.Close()
                frmIntro.Dispose()
            Catch
            End Try
            If (IsNothing(frmVCNV) = False) Then
                frmVCNV.Hide()
            End If
            If (IsNothing(frmVCNV_Pic) = False) Then
                frmVCNV_Pic.Hide()
            End If
            If (IsNothing(frmVCNVAnswer)) Then
                frmVCNVAnswer = New frmAnswerVCNV()
                frmVCNVAnswer.frm1 = Me
            End If
            frmVCNVAnswer.Show()
            frmVCNVAnswer.FillArrays()
        End If
    End Sub

    Public Sub ShowVCNVPic()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ShowVCNVPic))
        Else
            Me.Hide()
            frmWeit.Hide()
            Try
                frmIntro.Close()
                frmIntro.Dispose()
            Catch
            End Try
            If (IsNothing(frmVCNV) = False) Then
                frmVCNV.Hide()
            End If
            If (IsNothing(frmVCNVAnswer) = False) Then
                frmVCNVAnswer.Hide()
            End If
            If (IsNothing(frmVCNV_Pic)) Then
                frmVCNV_Pic = New frmVCNVPic()
                frmVCNV_Pic.frm1 = Me
            End If
            frmVCNV_Pic.Show()
        End If
    End Sub

    Public Sub ShowAnswerTangToc()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ShowAnswerTangToc))
        Else
            Me.Hide()
            frmWeit.Hide()
            Try
                frmIntro.Close()
                frmIntro.Dispose()
            Catch
            End Try
            If (IsNothing(frmTT) = False) Then
                frmTT.Hide()
            End If
            If (IsNothing(frmTTAnswer)) Then
                frmTTAnswer = New frmAnswerTangToc()
                frmTTAnswer.frm1 = Me
            End If
            frmTTAnswer.Show()
            frmTTAnswer.FillArrays()
        End If
    End Sub

    ''' <summary>
    ''' Hiện tên thí sinh trả lời CNV
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ShowCNVName()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ShowCNVName))
        Else
            Me.Hide()
            frmWeit.Hide()
            Try
                frmIntro.Close()
                frmIntro.Dispose()
            Catch
            End Try
            If (IsNothing(frmVCNV) = False) Then
                frmVCNV.ShowThiSinhCNV()
            End If
        End If
    End Sub

    Private Sub ShowVeDich()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ShowVeDich))
        Else
            CloseOtherForms()
            frmVD = New frmVeDich()
            frmVD.frm1 = Me
            frmVD.Show()
        End If
    End Sub

    Public Sub ClientThreadRead()
        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1))

        Dim temp As String
        Dim i As Integer

        Try
            Debug.WriteLine("Attempting to connect to the server on port 8000.")
            'logWriter.WriteLine("Attempting to connect to the server on port 8000.")
            Client.Connect(IPAddress.Parse(ip), port)
            Debug.WriteLine("Connection established.")

            Stream = Client.GetStream() 'Get Stream for writing and reading
            Dim r As New BinaryReader(Stream)
            isConnected = True
            If r.ReadString() = MyMessages.AcknowledgeOK Then
                MsgBox("Successfully Connected")
                mnConnect.Enabled = False
                Do
                    temp = r.ReadString()
                    'New: ----------------
                    If (temp = MyMessages.SendThiSinh) Then
                        idThiSinh = Convert.ToInt32(r.ReadString())
                        FilePath = r.ReadString()
                    End If

                    'Khởi động _________________________________________
                    If (temp = MsgKhoiDong.ShowKhoiDong) Then
                        idThiSinh = Convert.ToInt32(r.ReadString())
                        ShowKhoiDong()
                    End If

                    If (temp = MsgKhoiDong.SendEasy) Then
                        frmKD.LoadQuestEasy()
                    End If
                    If (temp = MsgKhoiDong.SendMedium) Then
                        frmKD.LoadQuestMedium()
                    End If
                    If (temp = MsgKhoiDong.SendHard) Then
                        frmKD.LoadQuestHard()
                    End If
                    If (temp = MsgKhoiDong.BackQuestKD) Then
                        frmKD.BackQuestionShow()
                    End If

                    If (temp = MsgKhoiDong.NextQuestKD) Then
                        frmKD.NextQuestionShow()
                    End If

                    If (temp = MsgKhoiDong.StartQuestKD) Then
                        frmKD.StartQuestion()
                    End If

                    If (temp = MsgKhoiDong.StopQuestKD) Then
                        frmKD.StopQuestion()
                    End If
                    'Show Điểm
                    If (temp = MyMessages.ShowScore) Then
                        For i = 0 To MaxThiSinh - 1
                            ArrThiSinh(i).score = r.ReadInt32()
                        Next
                        ShowScoreForm()
                    End If

                    'Send điểm
                    If (temp = MyMessages.SendScores) Then
                        For i = 0 To MaxThiSinh - 1
                            ArrThiSinh(i).score = r.ReadInt32()
                        Next
                    End If

                    'Show wait
                    If (temp = MyMessages.ShowWait) Then
                        ShowWaitForm()
                    End If

                    'Show Tăng tốc:
                    If (temp = MsgTangToc.ShowTangToc) Then
                        ShowTangToc()
                    End If
                    'Show trả lời tăng tốc

                    If (temp = MsgTangToc.ShowTTAnswer) Then
                        'Lần lượt đọc Answer và time của thí sinh
                        For i = 0 To MaxThiSinh - 1
                            ArrThiSinh(i).Answer = r.ReadString()
                            ArrThiSinh(i).TimeCount = r.ReadString()
                        Next
                        ShowAnswerTangToc()
                    End If

                    If (temp = MsgTangToc.BackQuest3) Then
                        frmTT.BackQuestionShow()
                    End If

                    If (temp = MsgTangToc.NextQuest3) Then
                        frmTT.NextQuestionShow()
                    End If

                    If (temp = MsgTangToc.StartQuest3) Then
                        frmTT.StartQuestion()
                    End If

                    If (temp = MsgTangToc.StopQuest3) Then
                        frmTT.StopQuestion()
                    End If

                    'Show Vượt chướng ngại vật:
                    If (temp = MsgVCNV.ShowVCNV) Then
                        ShowVCNV()
                    End If
                    If (temp = MsgVCNV.NextR2) Then
                        frmVCNV.ShowNextQuest()
                    End If


                    'Show Trả lời Vượt chướng ngại vật:
                    If (temp = MsgVCNV.ShowVCNVAnswer) Then
                        'Lần lượt đọc Answer của thí sinh:
                        For i = 0 To MaxThiSinh - 1
                            ArrThiSinh(i).Answer = r.ReadString()
                        Next
                        ShowAnswerVCNV()
                    End If

                    'Nhận ID thí sinh bấm trả lời CNV:
                    If (temp = MsgVCNV.IDAnswerCNV) Then
                        Try
                            frmVCNV.idThiSinhCNV = Convert.ToInt32(r.ReadString())
                            ShowCNVName()
                        Catch ex As Exception

                        End Try
                    End If

                    'Show form Về đích:
                    If (temp = MsgVeDich.ShowVeDich) Then
                        idThiSinh = Convert.ToInt32(r.ReadString())
                        ShowVeDich()
                    End If

                    'Nhận ID thí sinh giành quyền về đích:
                    If (temp = MsgVeDich.IDAnswerVeDich) Then
                        Try
                            i = Convert.ToInt32(r.ReadString())
                            frmVD.ShowThiSinhVeDich(ArrThiSinh(i).name)
                        Catch ex As Exception

                        End Try
                    End If
                    If (temp = MsgVeDich.ClearVeDich) Then
                        frmVD.TransparentAllLabels()
                    End If


                    If (temp = MsgVeDich.Sport1) Then
                        frmVD.LoadSport1()
                    End If
                    If (temp = MsgVeDich.Sport2) Then
                        frmVD.LoadSport2()
                    End If
                    If (temp = MsgVeDich.Sport3) Then
                        frmVD.LoadSport3()
                    End If
                    If (temp = MsgVeDich.SportE) Then
                        frmVD.LoadSportE()
                    End If
                    If (temp = MsgVeDich.Music1) Then
                        frmVD.LoadMusic1()
                    End If
                    If (temp = MsgVeDich.Music2) Then
                        frmVD.LoadMusic2()
                    End If
                    If (temp = MsgVeDich.Music3) Then
                        frmVD.LoadMusic3()
                    End If
                    If (temp = MsgVeDich.MusicE) Then
                        frmVD.LoadMusicE()
                    End If
                    If (temp = MsgVeDich.HisGeo1) Then
                        frmVD.LoadHisGeo1()
                    End If
                    If (temp = MsgVeDich.HisGeo2) Then
                        frmVD.LoadHisGeo2()
                    End If
                    If (temp = MsgVeDich.HisGeo3) Then
                        frmVD.LoadHisGeo3()
                    End If
                    If (temp = MsgVeDich.HisGeoE) Then
                        frmVD.LoadHisGeoE()
                    End If
                    If (temp = MsgVeDich.Science1) Then
                        frmVD.LoadScience1()
                    End If
                    If (temp = MsgVeDich.Science2) Then
                        frmVD.LoadScience2()
                    End If
                    If (temp = MsgVeDich.Science3) Then
                        frmVD.LoadScience3()
                    End If
                    If (temp = MsgVeDich.ScienceE) Then
                        frmVD.LoadScienceE()
                    End If
                    If (temp = MsgVeDich.FA1) Then
                        frmVD.LoadFA1()
                    End If
                    If (temp = MsgVeDich.FA2) Then
                        frmVD.LoadFA2()
                    End If
                    If (temp = MsgVeDich.FA3) Then
                        frmVD.LoadFA3()
                    End If
                    If (temp = MsgVeDich.FAE) Then
                        frmVD.LoadFAE()
                    End If
                    If (temp = MsgVeDich.EEIT1) Then
                        frmVD.LoadEEIT1()
                    End If
                    If (temp = MsgVeDich.EEIT2) Then
                        frmVD.LoadEEIT2()
                    End If
                    If (temp = MsgVeDich.EEIT3) Then
                        frmVD.LoadEEIT3()
                    End If
                    If (temp = MsgVeDich.EEITE) Then
                        frmVD.LoadEEITE()
                    End If
                    If (temp = MsgVeDich.CS1) Then
                        frmVD.LoadCS1()
                    End If
                    If (temp = MsgVeDich.CS2) Then
                        frmVD.LoadCS2()
                    End If
                    If (temp = MsgVeDich.CS3) Then
                        frmVD.LoadCS3()
                    End If
                    If (temp = MsgVeDich.CSE) Then
                        frmVD.LoadCSE()
                    End If


                    'Intro:
                    If (temp = MyMessages.ShowIntroKD) Then
                        introFilePath = SoundPaths.IntroKD
                        ShowIntroForm()
                    End If
                    If (temp = MyMessages.ShowIntroVCNV) Then
                        introFilePath = SoundPaths.IntroVCNV
                        ShowIntroForm()
                    End If
                    If (temp = MyMessages.ShowIntroTT) Then
                        introFilePath = SoundPaths.IntroTT
                        ShowIntroForm()
                    End If
                    If (temp = MyMessages.ShowIntroVD) Then
                        introFilePath = SoundPaths.IntroVD
                        ShowIntroForm()
                    End If
                    'Hình gợi ý CNV
                    If (temp = MsgVCNV.ShowVCNVPic) Then
                        ShowVCNVPic()
                    End If
                    'Sleep:
                    Threading.Thread.Sleep(20)
                Loop Until isDisconnected = True

            Else
                Debug.WriteLine("Connection not completed.")
            End If

            Client.Close()

        Catch Err As Exception
            Console.WriteLine(Err.ToString())
            'logWriter.WriteLine(Err.ToString())
        End Try

    End Sub

    Private Sub mnTeamName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnTeamName.Click
        Dim s As String = InputBox("Nhập tên đội: ", "Team Name", lbTeamName.Text)
        If (s <> "") Then
            TeamName = s
            lbTeamName.Text = TeamName
            isSendName = True
        End If
    End Sub

    Private Sub mnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnConnect.Click
        Try
            clientRead.Abort()
            clientWrite.Abort()
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try

        clientRead = New System.Threading.Thread(AddressOf ClientThreadRead)
        clientWrite = New Threading.Thread(AddressOf ClientThreadWrite)

        clientRead.IsBackground = True
        clientWrite.IsBackground = True

        clientRead.Start()
        clientWrite.Start()
    End Sub

    Private Sub loadContestants(ByVal filename As String)
        Dim connstring As String
        Dim i As Integer
        Dim dtThiSinh As DataTable
        connstring = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
        "Data Source=" & filename & ";Extended Properties=""Excel 8.0;HDR=YES;"""
        Debug.Print(connstring)
        Dim query As String = "SELECT No, FilePath, Name, Class FROM [Sheet1$]"
        Try
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(query, connstring)
            dtThiSinh = New DataTable()
            da.Fill(dtThiSinh)
            For i = 0 To MaxThiSinh - 1
                ArrThiSinh(i) = New Contestant
                If (dtThiSinh.Rows(i).IsNull(0) = False) Then
                    ArrThiSinh(i).id = dtThiSinh.Rows(i).Item(0)
                End If
                If (dtThiSinh.Rows(i).IsNull(1) = False) Then
                    ArrThiSinh(i).imagePath = dtThiSinh.Rows(i).Item(1)
                End If
                ArrThiSinh(i).name = dtThiSinh.Rows(i).Item(2)
                If (dtThiSinh.Rows(i).IsNull(3) = False) Then
                    ArrThiSinh(i).stdClass = dtThiSinh.Rows(i).Item(3)
                End If
            Next i
            Debug.Print("test thisinh: " & ArrThiSinh(0).imagePath)
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub btnKhoiDong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKhoiDong.Click
        ShowKhoiDong()
    End Sub

    Public Sub MakeLabelTranparent(ByVal frm As Form)
        Dim obj As Object
        Dim lb As Label
        Dim pb As PictureBox
        For Each obj In frm.Controls
            If (TypeOf obj Is Label) Then
                lb = CType(obj, Label)
                lb.BackColor = Color.Transparent
            End If
            If (TypeOf obj Is PictureBox) Then
                pb = CType(obj, PictureBox)
                pb.BackColor = Color.Transparent
            End If
        Next
    End Sub

    Private Sub btnTangToc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTangToc.Click
        ShowTangToc()
    End Sub

    Private Sub btnShowVCNV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowVCNV.Click
        ShowVCNV()
    End Sub

    Private Sub btnVeDich_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVeDich.Click
        ShowVeDich()
    End Sub

    Public Sub SendQuestion(ByVal sQuestion As String)
        Me.Question = sQuestion
        Command = MyCommands.SendQuestion
    End Sub

    Private Sub btnShowWait_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowWait.Click
        ShowWaitForm()
    End Sub

    Private Sub btnShowIntroKD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowIntroKD.Click
        ShowIntroForm()

    End Sub

    Private Sub btnVCNVPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVCNVPic.Click
        ShowVCNVPic()
    End Sub
End Class
