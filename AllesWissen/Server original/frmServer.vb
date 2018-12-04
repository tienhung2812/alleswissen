Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports System.Data.OleDb
Imports System.Data
Imports System.Collections.Generic

Public Class frmServer
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
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btStart As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnIPAddress As System.Windows.Forms.MenuItem
    Friend WithEvents mnStartServer As System.Windows.Forms.MenuItem
    Friend WithEvents cboAnswerOnce As System.Windows.Forms.CheckBox
    Friend WithEvents cboTimeTik As System.Windows.Forms.CheckBox
    Friend WithEvents btStop As System.Windows.Forms.Button
    Friend WithEvents txtSecond As System.Windows.Forms.TextBox
    Friend WithEvents lbSecond As System.Windows.Forms.Label
    Friend WithEvents btShowAnswer As System.Windows.Forms.Button
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnRound1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnRound2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnRound3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnRound4 As System.Windows.Forms.MenuItem
    Friend WithEvents cboContestant As System.Windows.Forms.ComboBox
    Friend WithEvents gbKhoiDong As System.Windows.Forms.GroupBox
    Friend WithEvents btnShowKD As System.Windows.Forms.Button
    Friend WithEvents gbScore As System.Windows.Forms.GroupBox
    Friend WithEvents lbName01 As System.Windows.Forms.Label
    Friend WithEvents txtScore01 As System.Windows.Forms.TextBox
    Friend WithEvents txtScore04 As System.Windows.Forms.TextBox
    Friend WithEvents lbName04 As System.Windows.Forms.Label
    Friend WithEvents txtScore03 As System.Windows.Forms.TextBox
    Friend WithEvents lbName03 As System.Windows.Forms.Label
    Friend WithEvents txtScore02 As System.Windows.Forms.TextBox
    Friend WithEvents lbName02 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuScore As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnPlus10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrưĐiêmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnShowWait As System.Windows.Forms.Button
    Friend WithEvents btnShowScore As System.Windows.Forms.Button
    Friend WithEvents btnInputTime As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnShowAnswerTangToc As System.Windows.Forms.Button
    Friend WithEvents btnShowTangToc As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnShowAnswerVCNV As System.Windows.Forms.Button
    Friend WithEvents btnShowVCNV As System.Windows.Forms.Button
    Friend WithEvents btnAllowCNV As System.Windows.Forms.Button
    Friend WithEvents btnHideCNV As System.Windows.Forms.Button
    Friend WithEvents lbCNVName04 As System.Windows.Forms.Label
    Friend WithEvents lbCNVName03 As System.Windows.Forms.Label
    Friend WithEvents lbCNVName02 As System.Windows.Forms.Label
    Friend WithEvents lbCNVName01 As System.Windows.Forms.Label
    Friend WithEvents btnSendScore As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbVDName As System.Windows.Forms.Label
    Friend WithEvents btnHideVD As System.Windows.Forms.Button
    Friend WithEvents btnAllowVD As System.Windows.Forms.Button
    Friend WithEvents btnShowVeDich As System.Windows.Forms.Button
    Friend WithEvents btnDisableVeDich As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnIntroKD As System.Windows.Forms.Button
    Friend WithEvents btnIntroTT As System.Windows.Forms.Button
    Friend WithEvents btnIntroVCNV As System.Windows.Forms.Button
    Friend WithEvents btnIntroVD As System.Windows.Forms.Button
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents tmCounter As System.Windows.Forms.Timer
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents btnVCNVPic As System.Windows.Forms.Button
    Friend WithEvents tm01 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServer))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btStart = New System.Windows.Forms.Button()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.mnIPAddress = New System.Windows.Forms.MenuItem()
        Me.mnStartServer = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.mnRound1 = New System.Windows.Forms.MenuItem()
        Me.mnRound2 = New System.Windows.Forms.MenuItem()
        Me.mnRound3 = New System.Windows.Forms.MenuItem()
        Me.mnRound4 = New System.Windows.Forms.MenuItem()
        Me.cboAnswerOnce = New System.Windows.Forms.CheckBox()
        Me.cboTimeTik = New System.Windows.Forms.CheckBox()
        Me.btStop = New System.Windows.Forms.Button()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.lbSecond = New System.Windows.Forms.Label()
        Me.tm01 = New System.Windows.Forms.Timer(Me.components)
        Me.btShowAnswer = New System.Windows.Forms.Button()
        Me.cboContestant = New System.Windows.Forms.ComboBox()
        Me.gbKhoiDong = New System.Windows.Forms.GroupBox()
        Me.btnIntroKD = New System.Windows.Forms.Button()
        Me.btnShowKD = New System.Windows.Forms.Button()
        Me.gbScore = New System.Windows.Forms.GroupBox()
        Me.btnSendScore = New System.Windows.Forms.Button()
        Me.txtScore04 = New System.Windows.Forms.TextBox()
        Me.lbName04 = New System.Windows.Forms.Label()
        Me.txtScore03 = New System.Windows.Forms.TextBox()
        Me.lbName03 = New System.Windows.Forms.Label()
        Me.txtScore02 = New System.Windows.Forms.TextBox()
        Me.lbName02 = New System.Windows.Forms.Label()
        Me.txtScore01 = New System.Windows.Forms.TextBox()
        Me.lbName01 = New System.Windows.Forms.Label()
        Me.ContextMenuScore = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnPlus10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrưĐiêmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnShowWait = New System.Windows.Forms.Button()
        Me.btnShowScore = New System.Windows.Forms.Button()
        Me.btnInputTime = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnIntroTT = New System.Windows.Forms.Button()
        Me.btnShowAnswerTangToc = New System.Windows.Forms.Button()
        Me.btnShowTangToc = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnVCNVPic = New System.Windows.Forms.Button()
        Me.btnIntroVCNV = New System.Windows.Forms.Button()
        Me.lbCNVName04 = New System.Windows.Forms.Label()
        Me.lbCNVName03 = New System.Windows.Forms.Label()
        Me.lbCNVName02 = New System.Windows.Forms.Label()
        Me.lbCNVName01 = New System.Windows.Forms.Label()
        Me.btnHideCNV = New System.Windows.Forms.Button()
        Me.btnAllowCNV = New System.Windows.Forms.Button()
        Me.btnShowAnswerVCNV = New System.Windows.Forms.Button()
        Me.btnShowVCNV = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnIntroVD = New System.Windows.Forms.Button()
        Me.btnDisableVeDich = New System.Windows.Forms.Button()
        Me.lbVDName = New System.Windows.Forms.Label()
        Me.btnHideVD = New System.Windows.Forms.Button()
        Me.btnAllowVD = New System.Windows.Forms.Button()
        Me.btnShowVeDich = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.tmCounter = New System.Windows.Forms.Timer(Me.components)
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.gbKhoiDong.SuspendLayout()
        Me.gbScore.SuspendLayout()
        Me.ContextMenuScore.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btStart
        '
        Me.btStart.Enabled = False
        Me.btStart.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btStart.Location = New System.Drawing.Point(123, 17)
        Me.btStart.Name = "btStart"
        Me.btStart.Size = New System.Drawing.Size(75, 23)
        Me.btStart.TabIndex = 3
        Me.btStart.Text = "Bắt đầu"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnIPAddress, Me.mnStartServer})
        Me.MenuItem1.Text = "Config"
        '
        'mnIPAddress
        '
        Me.mnIPAddress.Index = 0
        Me.mnIPAddress.Text = "IP Address"
        '
        'mnStartServer
        '
        Me.mnStartServer.Index = 1
        Me.mnStartServer.Text = "Start Server"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.mnRound1, Me.mnRound2, Me.mnRound3, Me.mnRound4})
        Me.MenuItem2.Text = "Play"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "Thời gian"
        '
        'mnRound1
        '
        Me.mnRound1.Index = 1
        Me.mnRound1.Text = "Khởi động"
        '
        'mnRound2
        '
        Me.mnRound2.Index = 2
        Me.mnRound2.Text = "Vượt chướng ngại vật"
        '
        'mnRound3
        '
        Me.mnRound3.Index = 3
        Me.mnRound3.Text = "Tăng tốc"
        '
        'mnRound4
        '
        Me.mnRound4.Index = 4
        Me.mnRound4.Text = "Về đích"
        '
        'cboAnswerOnce
        '
        Me.cboAnswerOnce.AutoSize = True
        Me.cboAnswerOnce.Location = New System.Drawing.Point(22, 23)
        Me.cboAnswerOnce.Name = "cboAnswerOnce"
        Me.cboAnswerOnce.Size = New System.Drawing.Size(92, 17)
        Me.cboAnswerOnce.TabIndex = 9
        Me.cboAnswerOnce.Text = "Trả lời một lần"
        Me.cboAnswerOnce.UseVisualStyleBackColor = True
        '
        'cboTimeTik
        '
        Me.cboTimeTik.AutoSize = True
        Me.cboTimeTik.Location = New System.Drawing.Point(22, 46)
        Me.cboTimeTik.Name = "cboTimeTik"
        Me.cboTimeTik.Size = New System.Drawing.Size(92, 17)
        Me.cboTimeTik.TabIndex = 10
        Me.cboTimeTik.Text = "Tính thời gian"
        Me.cboTimeTik.UseVisualStyleBackColor = True
        '
        'btStop
        '
        Me.btStop.Enabled = False
        Me.btStop.Location = New System.Drawing.Point(123, 46)
        Me.btStop.Name = "btStop"
        Me.btStop.Size = New System.Drawing.Size(75, 23)
        Me.btStop.TabIndex = 11
        Me.btStop.Text = "Hết giờ"
        Me.btStop.UseVisualStyleBackColor = True
        '
        'txtSecond
        '
        Me.txtSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecond.Location = New System.Drawing.Point(22, 69)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(45, 31)
        Me.txtSecond.TabIndex = 12
        Me.txtSecond.Text = "15"
        Me.txtSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbSecond
        '
        Me.lbSecond.AutoSize = True
        Me.lbSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSecond.Location = New System.Drawing.Point(73, 73)
        Me.lbSecond.Name = "lbSecond"
        Me.lbSecond.Size = New System.Drawing.Size(51, 24)
        Me.lbSecond.TabIndex = 13
        Me.lbSecond.Text = "Giây"
        '
        'tm01
        '
        Me.tm01.Interval = 1000
        '
        'btShowAnswer
        '
        Me.btShowAnswer.Location = New System.Drawing.Point(204, 46)
        Me.btShowAnswer.Name = "btShowAnswer"
        Me.btShowAnswer.Size = New System.Drawing.Size(75, 23)
        Me.btShowAnswer.TabIndex = 14
        Me.btShowAnswer.Text = "Xem trả lời"
        Me.btShowAnswer.UseVisualStyleBackColor = True
        '
        'cboContestant
        '
        Me.cboContestant.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboContestant.FormattingEnabled = True
        Me.cboContestant.Location = New System.Drawing.Point(49, 113)
        Me.cboContestant.Name = "cboContestant"
        Me.cboContestant.Size = New System.Drawing.Size(206, 26)
        Me.cboContestant.TabIndex = 18
        '
        'gbKhoiDong
        '
        Me.gbKhoiDong.BackColor = System.Drawing.SystemColors.Control
        Me.gbKhoiDong.Controls.Add(Me.btnIntroKD)
        Me.gbKhoiDong.Controls.Add(Me.btnShowKD)
        Me.gbKhoiDong.Location = New System.Drawing.Point(7, 208)
        Me.gbKhoiDong.Name = "gbKhoiDong"
        Me.gbKhoiDong.Size = New System.Drawing.Size(90, 198)
        Me.gbKhoiDong.TabIndex = 19
        Me.gbKhoiDong.TabStop = False
        Me.gbKhoiDong.Text = "Bệ phóng"
        '
        'btnIntroKD
        '
        Me.btnIntroKD.Location = New System.Drawing.Point(9, 15)
        Me.btnIntroKD.Name = "btnIntroKD"
        Me.btnIntroKD.Size = New System.Drawing.Size(62, 26)
        Me.btnIntroKD.TabIndex = 0
        Me.btnIntroKD.Text = "Giới thiệu"
        Me.btnIntroKD.UseVisualStyleBackColor = True
        '
        'btnShowKD
        '
        Me.btnShowKD.Location = New System.Drawing.Point(9, 60)
        Me.btnShowKD.Name = "btnShowKD"
        Me.btnShowKD.Size = New System.Drawing.Size(62, 34)
        Me.btnShowKD.TabIndex = 0
        Me.btnShowKD.Text = "Hiện"
        Me.btnShowKD.UseVisualStyleBackColor = True
        '
        'gbScore
        '
        Me.gbScore.Controls.Add(Me.btnSendScore)
        Me.gbScore.Controls.Add(Me.txtScore04)
        Me.gbScore.Controls.Add(Me.lbName04)
        Me.gbScore.Controls.Add(Me.txtScore03)
        Me.gbScore.Controls.Add(Me.lbName03)
        Me.gbScore.Controls.Add(Me.txtScore02)
        Me.gbScore.Controls.Add(Me.lbName02)
        Me.gbScore.Controls.Add(Me.txtScore01)
        Me.gbScore.Controls.Add(Me.lbName01)
        Me.gbScore.Location = New System.Drawing.Point(285, 12)
        Me.gbScore.Name = "gbScore"
        Me.gbScore.Size = New System.Drawing.Size(242, 190)
        Me.gbScore.TabIndex = 20
        Me.gbScore.TabStop = False
        Me.gbScore.Text = "Điểm"
        '
        'btnSendScore
        '
        Me.btnSendScore.Location = New System.Drawing.Point(29, 160)
        Me.btnSendScore.Name = "btnSendScore"
        Me.btnSendScore.Size = New System.Drawing.Size(75, 23)
        Me.btnSendScore.TabIndex = 23
        Me.btnSendScore.Text = "Gửi điểm"
        Me.btnSendScore.UseVisualStyleBackColor = True
        '
        'txtScore04
        '
        Me.txtScore04.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore04.Location = New System.Drawing.Point(185, 128)
        Me.txtScore04.Name = "txtScore04"
        Me.txtScore04.Size = New System.Drawing.Size(50, 32)
        Me.txtScore04.TabIndex = 7
        Me.txtScore04.Text = "000"
        Me.txtScore04.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbName04
        '
        Me.lbName04.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName04.Location = New System.Drawing.Point(7, 134)
        Me.lbName04.Name = "lbName04"
        Me.lbName04.Size = New System.Drawing.Size(161, 23)
        Me.lbName04.TabIndex = 6
        Me.lbName04.Text = "TÊN THÍ SINH"
        '
        'txtScore03
        '
        Me.txtScore03.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore03.Location = New System.Drawing.Point(185, 90)
        Me.txtScore03.Name = "txtScore03"
        Me.txtScore03.Size = New System.Drawing.Size(50, 32)
        Me.txtScore03.TabIndex = 5
        Me.txtScore03.Text = "000"
        Me.txtScore03.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbName03
        '
        Me.lbName03.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName03.Location = New System.Drawing.Point(7, 96)
        Me.lbName03.Name = "lbName03"
        Me.lbName03.Size = New System.Drawing.Size(161, 23)
        Me.lbName03.TabIndex = 4
        Me.lbName03.Text = "TÊN THÍ SINH"
        '
        'txtScore02
        '
        Me.txtScore02.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore02.Location = New System.Drawing.Point(185, 52)
        Me.txtScore02.Name = "txtScore02"
        Me.txtScore02.Size = New System.Drawing.Size(50, 32)
        Me.txtScore02.TabIndex = 3
        Me.txtScore02.Text = "000"
        Me.txtScore02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbName02
        '
        Me.lbName02.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName02.Location = New System.Drawing.Point(7, 58)
        Me.lbName02.Name = "lbName02"
        Me.lbName02.Size = New System.Drawing.Size(161, 23)
        Me.lbName02.TabIndex = 2
        Me.lbName02.Text = "TÊN THÍ SINH"
        '
        'txtScore01
        '
        Me.txtScore01.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore01.Location = New System.Drawing.Point(186, 11)
        Me.txtScore01.Name = "txtScore01"
        Me.txtScore01.Size = New System.Drawing.Size(50, 32)
        Me.txtScore01.TabIndex = 1
        Me.txtScore01.Text = "000"
        Me.txtScore01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbName01
        '
        Me.lbName01.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName01.Location = New System.Drawing.Point(7, 20)
        Me.lbName01.Name = "lbName01"
        Me.lbName01.Size = New System.Drawing.Size(161, 23)
        Me.lbName01.TabIndex = 0
        Me.lbName01.Text = "TÊN THÍ SINH"
        '
        'ContextMenuScore
        '
        Me.ContextMenuScore.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnPlus10, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.TrưĐiêmToolStripMenuItem})
        Me.ContextMenuScore.Name = "ContextMenuScore"
        Me.ContextMenuScore.Size = New System.Drawing.Size(123, 114)
        '
        'mnPlus10
        '
        Me.mnPlus10.Name = "mnPlus10"
        Me.mnPlus10.Size = New System.Drawing.Size(122, 22)
        Me.mnPlus10.Text = "+10"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(122, 22)
        Me.ToolStripMenuItem3.Text = "+15"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(122, 22)
        Me.ToolStripMenuItem4.Text = "+20"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(122, 22)
        Me.ToolStripMenuItem5.Text = "+30"
        '
        'TrưĐiêmToolStripMenuItem
        '
        Me.TrưĐiêmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9})
        Me.TrưĐiêmToolStripMenuItem.Name = "TrưĐiêmToolStripMenuItem"
        Me.TrưĐiêmToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.TrưĐiêmToolStripMenuItem.Text = "Trừ điểm"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(91, 22)
        Me.ToolStripMenuItem6.Text = "-5"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(91, 22)
        Me.ToolStripMenuItem7.Text = "-10"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(91, 22)
        Me.ToolStripMenuItem8.Text = "-15"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(91, 22)
        Me.ToolStripMenuItem9.Text = "-20"
        '
        'btnShowWait
        '
        Me.btnShowWait.Location = New System.Drawing.Point(147, 75)
        Me.btnShowWait.Name = "btnShowWait"
        Me.btnShowWait.Size = New System.Drawing.Size(132, 23)
        Me.btnShowWait.TabIndex = 21
        Me.btnShowWait.Text = "Hiện màn hình chờ"
        Me.ToolTip1.SetToolTip(Me.btnShowWait, "Hiện màn hình chờ")
        Me.btnShowWait.UseVisualStyleBackColor = True
        '
        'btnShowScore
        '
        Me.btnShowScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowScore.ForeColor = System.Drawing.Color.Red
        Me.btnShowScore.Location = New System.Drawing.Point(66, 162)
        Me.btnShowScore.Name = "btnShowScore"
        Me.btnShowScore.Size = New System.Drawing.Size(179, 33)
        Me.btnShowScore.TabIndex = 22
        Me.btnShowScore.Text = "HIỆN ĐIỂM THÍ SINH"
        Me.ToolTip1.SetToolTip(Me.btnShowScore, "Hiện bảng điểm thí sinh trên máy MC")
        Me.btnShowScore.UseVisualStyleBackColor = True
        '
        'btnInputTime
        '
        Me.btnInputTime.Location = New System.Drawing.Point(204, 17)
        Me.btnInputTime.Name = "btnInputTime"
        Me.btnInputTime.Size = New System.Drawing.Size(75, 23)
        Me.btnInputTime.TabIndex = 24
        Me.btnInputTime.Text = "Input Time"
        Me.btnInputTime.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.btnIntroTT)
        Me.GroupBox1.Controls.Add(Me.btnShowAnswerTangToc)
        Me.GroupBox1.Controls.Add(Me.btnShowTangToc)
        Me.GroupBox1.Location = New System.Drawing.Point(287, 208)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(93, 198)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Đếm ngược"
        '
        'btnIntroTT
        '
        Me.btnIntroTT.Location = New System.Drawing.Point(6, 20)
        Me.btnIntroTT.Name = "btnIntroTT"
        Me.btnIntroTT.Size = New System.Drawing.Size(75, 34)
        Me.btnIntroTT.TabIndex = 0
        Me.btnIntroTT.Text = "Giới thiệu"
        Me.btnIntroTT.UseVisualStyleBackColor = True
        '
        'btnShowAnswerTangToc
        '
        Me.btnShowAnswerTangToc.Location = New System.Drawing.Point(6, 103)
        Me.btnShowAnswerTangToc.Name = "btnShowAnswerTangToc"
        Me.btnShowAnswerTangToc.Size = New System.Drawing.Size(75, 42)
        Me.btnShowAnswerTangToc.TabIndex = 1
        Me.btnShowAnswerTangToc.Text = "Hiện trả lời"
        Me.ToolTip1.SetToolTip(Me.btnShowAnswerTangToc, "Hiện câu trả lời và thời gian của thí sinh trên máy MC")
        Me.btnShowAnswerTangToc.UseVisualStyleBackColor = True
        '
        'btnShowTangToc
        '
        Me.btnShowTangToc.Location = New System.Drawing.Point(6, 60)
        Me.btnShowTangToc.Name = "btnShowTangToc"
        Me.btnShowTangToc.Size = New System.Drawing.Size(75, 35)
        Me.btnShowTangToc.TabIndex = 0
        Me.btnShowTangToc.Text = "Hiện"
        Me.btnShowTangToc.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox2.Controls.Add(Me.btnVCNVPic)
        Me.GroupBox2.Controls.Add(Me.btnIntroVCNV)
        Me.GroupBox2.Controls.Add(Me.lbCNVName04)
        Me.GroupBox2.Controls.Add(Me.lbCNVName03)
        Me.GroupBox2.Controls.Add(Me.lbCNVName02)
        Me.GroupBox2.Controls.Add(Me.lbCNVName01)
        Me.GroupBox2.Controls.Add(Me.btnHideCNV)
        Me.GroupBox2.Controls.Add(Me.btnAllowCNV)
        Me.GroupBox2.Controls.Add(Me.btnShowAnswerVCNV)
        Me.GroupBox2.Controls.Add(Me.btnShowVCNV)
        Me.GroupBox2.Location = New System.Drawing.Point(103, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(177, 198)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Định vị"
        '
        'btnVCNVPic
        '
        Me.btnVCNVPic.Location = New System.Drawing.Point(87, 14)
        Me.btnVCNVPic.Name = "btnVCNVPic"
        Me.btnVCNVPic.Size = New System.Drawing.Size(75, 23)
        Me.btnVCNVPic.TabIndex = 7
        Me.btnVCNVPic.Text = "Hình gợi ý"
        Me.btnVCNVPic.UseVisualStyleBackColor = True
        Me.btnVCNVPic.Visible = False
        '
        'btnIntroVCNV
        '
        Me.btnIntroVCNV.Location = New System.Drawing.Point(6, 15)
        Me.btnIntroVCNV.Name = "btnIntroVCNV"
        Me.btnIntroVCNV.Size = New System.Drawing.Size(75, 22)
        Me.btnIntroVCNV.TabIndex = 0
        Me.btnIntroVCNV.Text = "Giới thiệu"
        Me.btnIntroVCNV.UseVisualStyleBackColor = True
        '
        'lbCNVName04
        '
        Me.lbCNVName04.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbCNVName04.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCNVName04.Location = New System.Drawing.Point(7, 172)
        Me.lbCNVName04.Name = "lbCNVName04"
        Me.lbCNVName04.Size = New System.Drawing.Size(136, 19)
        Me.lbCNVName04.TabIndex = 6
        Me.lbCNVName04.Text = "TÊN THÍ SINH"
        '
        'lbCNVName03
        '
        Me.lbCNVName03.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbCNVName03.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCNVName03.Location = New System.Drawing.Point(6, 149)
        Me.lbCNVName03.Name = "lbCNVName03"
        Me.lbCNVName03.Size = New System.Drawing.Size(136, 19)
        Me.lbCNVName03.TabIndex = 5
        Me.lbCNVName03.Text = "TÊN THÍ SINH"
        '
        'lbCNVName02
        '
        Me.lbCNVName02.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbCNVName02.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCNVName02.Location = New System.Drawing.Point(6, 126)
        Me.lbCNVName02.Name = "lbCNVName02"
        Me.lbCNVName02.Size = New System.Drawing.Size(136, 19)
        Me.lbCNVName02.TabIndex = 4
        Me.lbCNVName02.Text = "TÊN THÍ SINH"
        '
        'lbCNVName01
        '
        Me.lbCNVName01.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbCNVName01.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCNVName01.Location = New System.Drawing.Point(6, 103)
        Me.lbCNVName01.Name = "lbCNVName01"
        Me.lbCNVName01.Size = New System.Drawing.Size(136, 19)
        Me.lbCNVName01.TabIndex = 3
        Me.lbCNVName01.Text = "TÊN THÍ SINH"
        '
        'btnHideCNV
        '
        Me.btnHideCNV.Location = New System.Drawing.Point(87, 72)
        Me.btnHideCNV.Name = "btnHideCNV"
        Me.btnHideCNV.Size = New System.Drawing.Size(75, 23)
        Me.btnHideCNV.TabIndex = 2
        Me.btnHideCNV.Text = "Hide CNV"
        Me.ToolTip1.SetToolTip(Me.btnHideCNV, "Ẩn nút trả lời CNV trên máy thí sinh")
        Me.btnHideCNV.UseVisualStyleBackColor = True
        '
        'btnAllowCNV
        '
        Me.btnAllowCNV.Location = New System.Drawing.Point(87, 43)
        Me.btnAllowCNV.Name = "btnAllowCNV"
        Me.btnAllowCNV.Size = New System.Drawing.Size(75, 23)
        Me.btnAllowCNV.TabIndex = 2
        Me.btnAllowCNV.Text = "Allow CNV"
        Me.ToolTip1.SetToolTip(Me.btnAllowCNV, "Cho phép máy thí sinh trả lời CNV")
        Me.btnAllowCNV.UseVisualStyleBackColor = True
        '
        'btnShowAnswerVCNV
        '
        Me.btnShowAnswerVCNV.Location = New System.Drawing.Point(6, 72)
        Me.btnShowAnswerVCNV.Name = "btnShowAnswerVCNV"
        Me.btnShowAnswerVCNV.Size = New System.Drawing.Size(75, 23)
        Me.btnShowAnswerVCNV.TabIndex = 1
        Me.btnShowAnswerVCNV.Text = "Hiện trả lời"
        Me.btnShowAnswerVCNV.UseVisualStyleBackColor = True
        '
        'btnShowVCNV
        '
        Me.btnShowVCNV.Location = New System.Drawing.Point(6, 43)
        Me.btnShowVCNV.Name = "btnShowVCNV"
        Me.btnShowVCNV.Size = New System.Drawing.Size(75, 23)
        Me.btnShowVCNV.TabIndex = 0
        Me.btnShowVCNV.Text = "Hiện"
        Me.btnShowVCNV.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Gray
        Me.GroupBox3.Controls.Add(Me.btnIntroVD)
        Me.GroupBox3.Controls.Add(Me.btnDisableVeDich)
        Me.GroupBox3.Controls.Add(Me.lbVDName)
        Me.GroupBox3.Controls.Add(Me.btnHideVD)
        Me.GroupBox3.Controls.Add(Me.btnAllowVD)
        Me.GroupBox3.Controls.Add(Me.btnShowVeDich)
        Me.GroupBox3.Location = New System.Drawing.Point(386, 208)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(179, 198)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chinh phục"
        '
        'btnIntroVD
        '
        Me.btnIntroVD.Location = New System.Drawing.Point(10, 19)
        Me.btnIntroVD.Name = "btnIntroVD"
        Me.btnIntroVD.Size = New System.Drawing.Size(75, 22)
        Me.btnIntroVD.TabIndex = 0
        Me.btnIntroVD.Text = "Giới thiệu"
        Me.btnIntroVD.UseVisualStyleBackColor = True
        '
        'btnDisableVeDich
        '
        Me.btnDisableVeDich.Location = New System.Drawing.Point(10, 103)
        Me.btnDisableVeDich.Name = "btnDisableVeDich"
        Me.btnDisableVeDich.Size = New System.Drawing.Size(75, 23)
        Me.btnDisableVeDich.TabIndex = 4
        Me.btnDisableVeDich.Text = "Disable VĐ"
        Me.ToolTip1.SetToolTip(Me.btnDisableVeDich, "Không cho phép giành quyền về đích")
        Me.btnDisableVeDich.UseVisualStyleBackColor = True
        '
        'lbVDName
        '
        Me.lbVDName.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbVDName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVDName.Location = New System.Drawing.Point(11, 172)
        Me.lbVDName.Name = "lbVDName"
        Me.lbVDName.Size = New System.Drawing.Size(130, 19)
        Me.lbVDName.TabIndex = 3
        Me.lbVDName.Text = "TÊN THÍ SINH"
        '
        'btnHideVD
        '
        Me.btnHideVD.Location = New System.Drawing.Point(91, 76)
        Me.btnHideVD.Name = "btnHideVD"
        Me.btnHideVD.Size = New System.Drawing.Size(75, 23)
        Me.btnHideVD.TabIndex = 2
        Me.btnHideVD.Text = "Hide VĐ"
        Me.ToolTip1.SetToolTip(Me.btnHideVD, "Ẩn nút giành quyền trả lời Về đích")
        Me.btnHideVD.UseVisualStyleBackColor = True
        '
        'btnAllowVD
        '
        Me.btnAllowVD.Location = New System.Drawing.Point(10, 76)
        Me.btnAllowVD.Name = "btnAllowVD"
        Me.btnAllowVD.Size = New System.Drawing.Size(75, 23)
        Me.btnAllowVD.TabIndex = 2
        Me.btnAllowVD.Text = "Allow VĐ"
        Me.ToolTip1.SetToolTip(Me.btnAllowVD, "Cho phép thí sinh giành quyền về đích")
        Me.btnAllowVD.UseVisualStyleBackColor = True
        '
        'btnShowVeDich
        '
        Me.btnShowVeDich.Location = New System.Drawing.Point(10, 47)
        Me.btnShowVeDich.Name = "btnShowVeDich"
        Me.btnShowVeDich.Size = New System.Drawing.Size(75, 23)
        Me.btnShowVeDich.TabIndex = 0
        Me.btnShowVeDich.Text = "Hiện"
        Me.btnShowVeDich.UseVisualStyleBackColor = True
        '
        'lblQuestion
        '
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(571, 215)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(282, 191)
        Me.lblQuestion.TabIndex = 28
        Me.lblQuestion.Text = "Nội dung câu hỏi"
        '
        'tmCounter
        '
        Me.tmCounter.Enabled = True
        Me.tmCounter.Interval = 20
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(533, 17)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLog.Size = New System.Drawing.Size(320, 185)
        Me.txtLog.TabIndex = 29
        '
        'frmServer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(862, 412)
        Me.Controls.Add(Me.cboAnswerOnce)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.btnInputTime)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.gbScore)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnShowWait)
        Me.Controls.Add(Me.gbKhoiDong)
        Me.Controls.Add(Me.txtSecond)
        Me.Controls.Add(Me.cboTimeTik)
        Me.Controls.Add(Me.btStop)
        Me.Controls.Add(Me.cboContestant)
        Me.Controls.Add(Me.btnShowScore)
        Me.Controls.Add(Me.btShowAnswer)
        Me.Controls.Add(Me.btStart)
        Me.Controls.Add(Me.lbSecond)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmServer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entropy Server"
        Me.gbKhoiDong.ResumeLayout(False)
        Me.gbScore.ResumeLayout(False)
        Me.gbScore.PerformLayout()
        Me.ContextMenuScore.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Const MaxThiSinh As Integer = 4 'Số lượng thí sinh tối đa

    Public ip As String = "127.0.0.1" 'IP của Server (các máy khác phải kết nối tới IP này)
    Public port As Integer = 8000 'Các máy khác phải kết nối đúng port này
    'Declare Clients
    Public ClientManager As ArrayList = New ArrayList 'Mảng các handler để gửi câu hỏi tới thí sinh
    Public ClientReadMn As ArrayList = New ArrayList 'Mảng các handler để nhận câu trả lời từ thí sinh
    Public SpecialRead As ClientHandlerReadSpec 'Handler nhận data từ máy MC (máy hiển thị câu hỏi và kết quả cho khán giả)
    Public SpecialWrite As ClientHandlerWriteSpec 'Handler chuyển data đến máy MC

    Public Listener As TcpListener
    Dim server As New System.Threading.Thread(AddressOf StartServer)
    Public exited As Boolean = False 'Xác định xem đã tắt server chưa
    Public cnt As Long = 0 'Biến counter để tính thời gian trả lời
    'cnt = 100 --> 1 second
    Public sec As Long = 0
    'Dim counter As New Threading.Thread(AddressOf DoCounter)
    Dim secDefault As Integer = 15 'Mặc định thời gian 15 giây

    Dim connstring As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
       "Data Source=Vong1.xls;Extended Properties=""Excel 8.0;HDR=YES;"""

    'New:
    Dim dtable As DataTable
    Dim dtThiSinh As DataTable 'Bảng chứa tên và thông tin thí sinh từ file Excel
    Dim ArrNames As ArrayList
    Dim ArrScores As ArrayList
    Dim curLbName As Label ' Label being right click
    Public ArrThiSinh(MaxThiSinh) As Contestant 'Mảng chứa thông tin thí sinh

    Public lstCNVNames As List(Of Label) = New List(Of Label) 'Mảng Label chứa tên các thí sinh trả lời CNV
    Public idCNV As Integer = 0 'Số thí sinh đã bấm trả lời CNV
    Public idThiSinhCNV As Integer = -1 'Id thí sinh vừa bấm CNV (ID đếm từ 0 đến 3)
    Public idThiSinhVD As Integer = -1 'ID thi sinh vừa bấm giành quyền trả lời Về đích
    Public Question4Send As String = ""
    Public isGianhQuyenVD As Boolean = False 'Xác định xem đã có thí sinh nào giành quyền Về đích chưa
    'Chức năng hiện log:
    Public logToWrite As String = ""

    Private Sub btOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenFileDialog1.ShowDialog()
        If (OpenFileDialog1.FileName <> "") Then
            'tbPath.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStart.Click
        StartAllClient()
    End Sub

    Private Sub SendPaths()
        Dim handler As ClientHandlerWrite
        Dim i As Integer
        For i = 0 To ClientManager.Count - 1
            handler = CType(ClientManager.Item(i), ClientHandlerWrite)
            'handler.path = tbPath.Text
            'handler.isPathSent = True
        Next
    End Sub

    Public Sub SendClientTime(ByVal time As Integer)
        Dim handler As ClientHandlerWrite
        Dim i As Integer
        For i = 0 To ClientManager.Count - 1
            handler = CType(ClientManager.Item(i), ClientHandlerWrite)
            handler.ClientTime = time
            handler.Command = MyCommands.SendClientTime
        Next
    End Sub


    ''' <summary>
    ''' Gởi nội dung câu hỏi tới tất cả thí sinh
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SendQuestion()

        Dim ques As String = ""
        Try
            ques = Me.Question4Send
        Catch
        End Try
        Dim handler As ClientHandlerWrite
        Dim i As Integer
        For i = 0 To ClientManager.Count - 1
            handler = CType(ClientManager.Item(i), ClientHandlerWrite)
            handler.Command = MyCommands.SendQuestion
            handler.Question = ques
        Next
    End Sub

    Public Sub DisplayQuestionOnServer() 'Bắt đầu cho phép client trả lời
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf DisplayQuestionOnServer))
        Else
            lblQuestion.Text = Question4Send
        End If
    End Sub

    Public Sub StartAllClient() 'Bắt đầu cho phép client trả lời
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf StartAllClient))
        Else
            Dim handler As ClientHandlerWrite
            Dim hdlRead As ClientHandlerRead
            Dim i As Integer
            Dim cmd As Integer
            If (cboAnswerOnce.Checked = True AndAlso cboTimeTik.Checked = True) Then
                cmd = MyCommands.StartAnswerOnce
            ElseIf (cboAnswerOnce.Checked = True) Then
                cmd = MyCommands.StartAnswerOnce
            Else
                cmd = MyCommands.StartNormal
            End If
            For i = 0 To MaxThiSinh - 1
                ArrThiSinh(i).Answer = ""
                ArrThiSinh(i).TimeCount = 40000
            Next
            For i = 0 To ClientManager.Count - 1
                hdlRead = CType(ClientReadMn.Item(i), ClientHandlerRead)
                hdlRead.Time = -1
                hdlRead.Answer = ""
                handler = CType(ClientManager.Item(i), ClientHandlerWrite)
                handler.Command = cmd
            Next
            'new
            cnt = 0
            sec = secDefault
            tm01.Enabled = True
            btStart.Enabled = False
            btStop.Enabled = True
            Debug.Print("Bắt đầu tính giờ: ")
            appendLog("Bắt đầu tính giờ:")
        End If

    End Sub

    Public Sub StopAllClient()
        Dim handler As ClientHandlerWrite
        Dim i As Integer
        Dim cmd As Integer
        cmd = MyCommands.StopAnswer
        For i = 0 To ClientManager.Count - 1
            handler = CType(ClientManager.Item(i), ClientHandlerWrite)
            handler.Command = cmd
        Next
    End Sub

    Public Sub appendLog(ByVal message As String)
        logToWrite = message
        appendTextbox()
    End Sub

    Public Sub appendTextbox()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf appendTextbox))
        Else
            txtLog.Text += Environment.NewLine & logToWrite
        End If
    End Sub

    Private Sub frmServer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'counter.Start()
        InitArrays()
        'Lấy thông tin thí sinh trong file Excel:
        loadContestants(".\Vong\ThiSinh.xls")
        readIP()
        'Automatically start server with default IP
        mnStartServer_Click(sender, e)
    End Sub

    Public Sub StartServer()
        Listener = New TcpListener(IPAddress.Parse(ip), port)
        Listener.Start()

        Debug.WriteLine("Server: Đang chờ kết nối...")
        appendLog("Server: Đang chờ kết nối...")

        Dim ClientNum As Integer
        ClientNum = -1
        Do
            Try
                Threading.Thread.Sleep(100) 'interval signal
                Dim Client As TcpClient = Listener.AcceptTcpClient()
                Application.DoEvents()
                Debug.WriteLine("Server: Đã nhận kết nối.")
                appendLog("Server: Đã nhận kết nối.")
                ClientNum += 1
                If ClientNum = 0 Then
                    'Add thread for special client
                    SpecialRead = New ClientHandlerReadSpec(Client, "ClientSpecialRead")
                    SpecialRead.frm1 = Me
                    SpecialWrite = New ClientHandlerWriteSpec(Client, "ClientSpecialWrite")
                    Dim SpecialWriteThread As New System.Threading.Thread(AddressOf SpecialWrite.Start)
                    SpecialWriteThread.IsBackground = True
                    SpecialWriteThread.Start()
                    Dim SpecialReadThread As New System.Threading.Thread(AddressOf SpecialRead.Start)
                    SpecialReadThread.IsBackground = True
                    SpecialReadThread.Start()
                Else
                    'Add thread to ClientManagers
                    Dim Handler As New ClientHandlerWrite(Client, "Client " & ClientNum.ToString())
                    Handler.frm1 = Me
                    ClientManager.Add(Handler)
                    Dim HandlerWriteThread As New System.Threading.Thread(AddressOf Handler.Start)
                    HandlerWriteThread.IsBackground = True
                    HandlerWriteThread.Start()
                    'Add hander for reading
                    Dim HandlerRead As New ClientHandlerRead(Client, "Client " & ClientNum.ToString())
                    Dim HandlerReadThread As New System.Threading.Thread(AddressOf HandlerRead.Start)
                    HandlerRead.frm1 = Me
                    ClientReadMn.Add(HandlerRead)
                    HandlerReadThread.IsBackground = True
                    HandlerReadThread.Start()
                End If
            Catch Err As Exception
                Debug.WriteLine(Err.ToString())
            End Try
        Loop Until exited = True


    End Sub


    Private Sub frmServer_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        server.Interrupt()
        server.Abort()
        Debug.WriteLine("abort")
        appendLog("Abort")
        exited = True
        Try
            Listener.Stop()
        Catch ex As Exception
            'nothing
        End Try
    End Sub


    Private Sub mnIPAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnIPAddress.Click
        ip = InputBox("Nhập IP server: ", "Server IP", ip)
    End Sub

    Private Sub mnStartServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnStartServer.Click
        server.Start()
        server.Priority = Threading.ThreadPriority.Lowest
        btStart.Enabled = True
    End Sub



    Private Sub tm01_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm01.Tick
        If (sec > 0) Then
            sec -= 1
            txtSecond.Text = sec
        Else
            btStop.Enabled = False
            btStart.Enabled = True
            StopAllClient()
            txtSecond.Text = secDefault
            tm01.Enabled = False
            'Out of time
        End If
    End Sub

    Private Sub btStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStop.Click
        StopAllClient()
        tm01.Enabled = False
        txtSecond.Text = secDefault
        btStop.Enabled = False
        btStart.Enabled = True
        'WMP1.URL = tbPath.Text
        'WMP1.Ctlcontrols.play()
        'Do
        '    Application.DoEvents()
        'Loop Until WMP1.playState = WMPLib.WMPPlayState.wmppsPlaying
        cnt = 0
    End Sub

    Private Sub readIP()
        Try
            Dim oRead As System.IO.StreamReader
            oRead = File.OpenText("ip.txt")
            ip = oRead.ReadLine()
            oRead.Close()
        Catch ex As Exception
            'Nothing
        End Try
    End Sub

    Private Sub mnRound1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnRound1.Click, mnRound2.Click, mnRound3.Click, mnRound4.Click
        mnRound1.Checked = False
        mnRound2.Checked = False
        mnRound3.Checked = False
        mnRound4.Checked = False
        Dim mn As MenuItem
        mn = CType(sender, MenuItem)
        mn.Checked = True
        Dim round As Integer = 0
        Dim filePath As String
        Dim idThiSinh As Integer
        'round = Convert.ToInt32(mn.Text.Substring(mn.Name.Length - 2))
        Debug.Print(mn.Text)
        appendLog(mn.Text)
        idThiSinh = cboContestant.SelectedIndex + 1
        Select Case mn.Text
            Case "Khởi động"
                filePath = ".\Vong\Khoidong" & idThiSinh & ".xls"
                'Send filePath to Special Client
                SpecialWrite.Message = MsgKhoiDong.SendFileName
                SpecialWrite.IDSend = 0
                SpecialWrite.Command = MyCommands.SendSpecial
            Case "Vượt chướng ngại vật"
            Case "Tăng tốc"
            Case "Về đích"
        End Select
        'loadQuestions(".\Vong\Vong" & round & ".xls")
    End Sub


    Private Sub btnShowKD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowKD.Click
        SpecialWrite.Message = MsgKhoiDong.ShowKhoiDong
        SpecialWrite.IDSend = cboContestant.SelectedIndex.ToString()
        SpecialWrite.Command = MyCommands.SendThiSinhID
    End Sub


    Private Sub mnPlus10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnPlus10.Click, ToolStripMenuItem3.Click, ToolStripMenuItem4.Click, ToolStripMenuItem5.Click, ToolStripMenuItem6.Click, ToolStripMenuItem7.Click, ToolStripMenuItem8.Click, ToolStripMenuItem9.Click
        Dim mn As ToolStripMenuItem
        mn = CType(sender, ToolStripMenuItem)
        Dim score As Integer
        Dim id As Integer
        Dim txtScore As TextBox
        id = ArrNames.IndexOf(curLbName)
        txtScore = CType(ArrScores(id), TextBox)
        score = Convert.ToInt32(txtScore.Text)
        score += Convert.ToInt32(mn.Text)
        txtScore.Text = score
    End Sub

    Private Sub InitArrays()
        ArrNames = New ArrayList()
        ArrScores = New ArrayList()
        ArrNames.Add(lbName01)
        ArrNames.Add(lbName02)
        ArrNames.Add(lbName03)
        ArrNames.Add(lbName04)
        ArrScores.Add(txtScore01)
        ArrScores.Add(txtScore02)
        ArrScores.Add(txtScore03)
        ArrScores.Add(txtScore04)
        'Tên các thí sinh trả lời CNV
        lstCNVNames.Add(lbCNVName01)
        lstCNVNames.Add(lbCNVName02)
        lstCNVNames.Add(lbCNVName03)
        lstCNVNames.Add(lbCNVName04)
    End Sub


    Private Sub lbName01_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbName01.MouseClick, lbName02.MouseClick, lbName03.MouseClick, lbName04.MouseClick
        If (e.Button = Windows.Forms.MouseButtons.Right) Then
            curLbName = CType(sender, Label)
            ContextMenuScore.Show(curLbName, e.X, e.Y)
        End If
    End Sub

    Private Sub loadContestants(ByVal filename As String)
        Dim connstring As String
        Dim i As Integer
        Dim dtThiSinh As DataTable
        connstring = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
        "Data Source=" & filename & ";Extended Properties=""Excel 8.0;HDR=YES;"""
        Debug.Print(connstring)
        Dim query As String = "SELECT FilePath, Name FROM [Sheet1$]"
        Try
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(query, connstring)
            dtThiSinh = New DataTable()
            da.Fill(dtThiSinh)
            Dim lb As Label
            For i = 0 To 3
                ArrThiSinh(i) = New Contestant
                If (IsNothing(dtThiSinh.Rows(i).Item("FilePath")) = False) Then
                    ArrThiSinh(i).imagePath = dtThiSinh.Rows(i).Item("FilePath")
                End If
                ArrThiSinh(i).name = dtThiSinh.Rows(i).Item("Name")
                'ArrThiSinh(i).stdClass = dtThiSinh.Rows(i).Item(3)
                'Set name to display
                lb = CType(ArrNames(i), Label)
                lb.Text = ArrThiSinh(i).name
            Next i
            cboContestant.DataSource = dtThiSinh
            cboContestant.DisplayMember = "Name"
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub UpdateArrScore()
        Dim i As Integer
        Dim txt As TextBox
        Dim thiSinh As Contestant
        For i = 0 To MaxThiSinh - 1
            txt = CType(ArrScores(i), TextBox)
            thiSinh = ArrThiSinh(i)
            thiSinh.score = Convert.ToInt32(txt.Text)
        Next
    End Sub

    Private Sub btnShowScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowScore.Click
        UpdateArrScore()
        SpecialWrite.arrThiSinh = Me.ArrThiSinh
        SpecialWrite.Message = MyMessages.ShowScore
        SpecialWrite.Command = MyCommands.ShowScore
    End Sub

    Private Sub btnShowWait_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowWait.Click
        SpecialWrite.Command = MyCommands.ShowWait
    End Sub


    Private Sub btnInputTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInputTime.Click
        Dim s As String = InputBox("Nhập thời gian (giây): ", "Thách Thức Entropy", secDefault)
        If (s <> "") Then
            secDefault = Convert.ToInt32(s)
            txtSecond.Text = secDefault.ToString()
        End If
        SendClientTime(Convert.ToInt32(txtSecond.Text))
    End Sub

    Private Sub btnShowTangToc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowTangToc.Click
        secDefault = 30
        txtSecond.Text = 30
        SendClientTime(secDefault)
        SpecialWrite.Command = MyCommands.ShowTangToc
        SendCommand(MyCommands.HideCNV)
        SetClientTime(30)
    End Sub

    Private Sub btnShowAnswerTangToc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAnswerTangToc.Click
        SpecialWrite.arrThiSinh = Me.ArrThiSinh
        SpecialWrite.Command = MyCommands.ShowAnswerTangToc
    End Sub

    Private Sub btnShowVCNV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowVCNV.Click
        secDefault = 20
        txtSecond.Text = 20
        SendClientTime(secDefault)
        SpecialWrite.Command = MyCommands.ShowVCNV
        SendCommand(MyCommands.AllowCNV)
    End Sub

    Private Sub btnShowAnswerVCNV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAnswerVCNV.Click
        SpecialWrite.arrThiSinh = Me.ArrThiSinh
        SpecialWrite.Command = MyCommands.ShowAnswerVCNV
    End Sub

    ''' <summary>
    ''' Show tên thí sinh trả lời CNV
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ShowThiSinhCNV()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ShowThiSinhCNV))
        Else
            lstCNVNames(idCNV).Text = ArrThiSinh(idThiSinhCNV).name
            idCNV += 1
        End If
    End Sub

    Public Sub ShowThiSinhVeDich()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ShowThiSinhVeDich))
        Else
            lbVDName.Text = ArrThiSinh(idThiSinhVD).name
        End If
    End Sub

    Public Sub SendThiSinhVeDich()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf SendThiSinhVeDich))
        Else
            SpecialWrite.IDSend = idThiSinhVD.ToString()
            SpecialWrite.Command = MyCommands.SendIDAnswerVeDich
        End If
    End Sub

    Public Sub SendThiSinhCNV()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf SendThiSinhCNV))
        Else
            SpecialWrite.IDSend = idThiSinhCNV.ToString()
            SpecialWrite.Command = MyCommands.SendIDAnswerCNV
        End If
    End Sub

    ''' <summary>
    ''' Send command-only to all ClientWrite
    ''' </summary>
    ''' <param name="cmd"></param>
    ''' <remarks></remarks>
    Public Sub SendCommand(ByVal cmd As Integer)
        Dim handler As ClientHandlerWrite
        Dim i As Integer
        For i = 0 To ClientManager.Count - 1
            handler = CType(ClientManager.Item(i), ClientHandlerWrite)
            handler.Command = cmd
        Next
    End Sub

    Public Sub SetClientTime(ByVal timeInSecond As Integer)
        Dim handler As ClientHandlerWrite
        Dim i As Integer
        For i = 0 To ClientManager.Count - 1
            handler = CType(ClientManager.Item(i), ClientHandlerWrite)
            handler.ClientTime = timeInSecond
            handler.Command = MyCommands.SendClientTime
        Next
    End Sub

    Private Sub btnAllowCNV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllowCNV.Click
        SendCommand(MyCommands.AllowCNV)
    End Sub

    Private Sub btnHideCNV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideCNV.Click
        SendCommand(MyCommands.HideCNV)
    End Sub

    Private Sub btnSendScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendScore.Click
        UpdateArrScore()
        SpecialWrite.arrThiSinh = Me.ArrThiSinh
        SpecialWrite.Command = MyCommands.SendScore
        Dim handler As ClientHandlerWrite
        Dim i As Integer
        For i = 0 To ClientManager.Count - 1
            handler = CType(ClientManager.Item(i), ClientHandlerWrite)
            handler.Command = MyCommands.SendScore
        Next
    End Sub

    Private Sub btnShowVeDich_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowVeDich.Click
        SpecialWrite.Message = MsgVeDich.ShowVeDich
        SpecialWrite.IDSend = cboContestant.SelectedIndex.ToString()
        SpecialWrite.Command = MyCommands.SendThiSinhID
    End Sub

    Private Sub btnAllowVD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllowVD.Click
        SendCommand(MyCommands.AllowVeDich)
    End Sub

    Private Sub btnHideVD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideVD.Click
        SendCommand(MyCommands.HideVeDich)
    End Sub

    Private Sub btnDisableVeDich_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisableVeDich.Click
        SendCommand(MyCommands.DisableVeDich)
    End Sub

    Private Sub btnIntroKD_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIntroKD.Click
        SpecialWrite.Command = MyCommands.ShowIntroKD
    End Sub

    Private Sub btnIntroTT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIntroTT.Click
        SendCommand(MyCommands.HideCNV)
        SpecialWrite.Command = MyCommands.ShowIntroTT
    End Sub

    Private Sub btnIntroVCNV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIntroVCNV.Click
        SpecialWrite.Command = MyCommands.ShowIntroVCNV
    End Sub

    Private Sub btnIntroVD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIntroVD.Click
        SpecialWrite.Command = MyCommands.ShowIntroVD
    End Sub

    Public Sub DoCounter()
        Debug.WriteLine("Counting")
        Dim rhandler As ClientHandlerRead
        Dim i As Integer
        Do
            Threading.Thread.Sleep(20)
            cnt += 2
            'If cnt Mod 100 = 0 Then Debug.WriteLine(cnt)
            For i = 0 To ClientReadMn.Count - 1
                rhandler = CType(ClientReadMn.Item(i), ClientHandlerRead)
                'Set time for counters in each clientRead
                rhandler.TimeCount = cnt
                'handler.path = tbPath.Text
                'handler.isPathSent = True
            Next
            If (cnt > 2000000000) Then cnt = 0
        Loop Until exited = True
    End Sub
    Private Sub tmCounter_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmCounter.Tick
        Dim rhandler As ClientHandlerRead
        Dim i As Integer
        cnt += 2
        'If cnt Mod 100 = 0 Then Debug.WriteLine(cnt)
        For i = 0 To ClientReadMn.Count - 1
            rhandler = CType(ClientReadMn.Item(i), ClientHandlerRead)
            'Set time for counters in each clientRead
            rhandler.TimeCount = cnt
            'handler.path = tbPath.Text
            'handler.isPathSent = True
        Next
        If (cnt > 2000000000) Then cnt = 0
    End Sub

    Private Sub btnVCNVPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVCNVPic.Click
        SpecialWrite.Command = MyCommands.ShowVCNVPic
    End Sub

    Private Sub txtLog_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLog.TextChanged

        txtLog.SelectionLength = 0

        txtLog.SelectionStart = txtLog.Text.Length

        txtLog.ScrollToCaret()
    End Sub


    Private Sub btShowAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btShowAnswer.Click
        SpecialWrite.arrThiSinh = Me.ArrThiSinh
        SpecialWrite.Command = MyCommands.ShowAnswerVCNV
    End Sub
End Class




Public Class ClientHandlerReadSpec
    'Handler nhận data từ máy MC (máy hiển thị câu hỏi và kết quả cho khán giả)
    Private Client As TcpClient
    Public ID As String
    Public isStarted As Boolean = False
    Public isPathSent As Boolean = False
    Public path As String = ""

    Public Time As Integer = 0
    Public TimeCount As Integer = 0
    Public Answer As String = ""
    Public TeamName As String = ""

    Public frm1 As frmServer

    Public Sub New(ByVal client As TcpClient, ByVal ID As String)
        Me.Client = client
        Me.ID = ID
    End Sub

    Public Sub Start() 'Start thread read
        Dim Stream As NetworkStream = Client.GetStream()
        Dim isDis As Boolean = False
        'Dim w As New BinaryWriter(Stream)
        Dim temp As String
        Dim r As New BinaryReader(Stream)
        Dim w As New BinaryWriter(Stream)
        Try
            If r.ReadString() = MyMessages.RequestConnect Then
                w.Write(MyMessages.AcknowledgeOK)
                Debug.WriteLine(ID + " đã kết nối")
                frm1.appendLog(ID + " đã kết nối")
                Do
                    temp = r.ReadString()
                    If (temp = MyMessages.Disconnect) Then
                        Debug.WriteLine(ID + " disconnected")
                        frm1.appendLog(ID + " disconnected")
                    End If
                    'Bắt đầu trả lời tăng tốc
                    If (temp = MsgTangToc.StartAnswer) Then
                        frm1.StartAllClient()
                    End If
                    'Bắt đầu trả lời VCNV:
                    If (temp = MsgVCNV.StartAnswer) Then
                        frm1.StartAllClient()
                    End If
                    'Cho phép trả lời về đích:
                    If (temp = MyMessages.AllowVeDich) Then
                        frm1.isGianhQuyenVD = False
                        frm1.SendCommand(MyCommands.AllowVeDich)
                    End If
                    'Nhận nội dung câu hỏi
                    If (temp = MyMessages.SendQuestion) Then
                        frm1.Question4Send = r.ReadString()
                        frm1.DisplayQuestionOnServer()
                        frm1.SendQuestion()
                    End If
                    Threading.Thread.Sleep(50)
                Loop Until temp = MyMessages.Disconnect

                '  Loop Until r.ReadString() = MyMessages.Disconnect
                Debug.WriteLine(ID & ": Disconnected.")
                frm1.appendLog(ID & ": Disconnected.")
                'w.Write(ServerMessages.Disconnect)                


            Else
                Debug.WriteLine(ID & ": Could not complete connection.")
                frm1.appendLog(ID & ": Could not complete connection.")
            End If

            Client.Close()
            Debug.WriteLine(ID & ": Client connection closed.")
        Catch Err As Exception
            Debug.WriteLine(Err.ToString)
        End Try
    End Sub

End Class



Public Class ClientHandlerRead

    Private Client As TcpClient
    Public ID As String
    Public isStarted As Boolean = False
    Public isPathSent As Boolean = False
    Public path As String = ""

    Public Time As Integer = 0
    Public TimeCount As Integer = 0
    Public Answer As String = ""
    Public TeamName As String = ""
    Public frm1 As frmServer
    Public idThiSinhCNV As Integer = -1

    Public Sub New(ByVal client As TcpClient, ByVal ID As String)
        Me.Client = client
        Me.ID = ID
    End Sub

    Public Sub Start() 'Start thread read
        Dim Stream As NetworkStream = Client.GetStream()
        Dim isDis As Boolean = False
        'Dim w As New BinaryWriter(Stream)
        Dim temp As String
        Dim r As New BinaryReader(Stream)
        Dim w As New BinaryWriter(Stream)
        Dim idThiSinh As Integer = 0
        Try
            If r.ReadString() = MyMessages.RequestConnect Then
                w.Write(MyMessages.AcknowledgeOK)
                Debug.WriteLine(ID + " đã kết nối")
                frm1.appendLog(ID + " đã kết nối")
                Do
                    temp = r.ReadString()
                    If (temp = MyMessages.Disconnect) Then
                        Debug.WriteLine(ID + " đã ngắt kết nối")
                        frm1.appendLog(ID + " đã ngắt kết nối")
                    End If
                    If (temp = MyMessages.SendAnswer) Then
                        'Nhận dc câu trả lời từ thí sinh
                        idThiSinh = r.ReadInt32() 'Nhận ID thí sinh
                        temp = r.ReadString() 'Nhận câu trả lời
                        frm1.ArrThiSinh(idThiSinh).Answer = temp
                        frm1.ArrThiSinh(idThiSinh).TimeCount = Me.TimeCount.ToString()
                        Me.Time = Me.TimeCount
                        Debug.WriteLine(frm1.ArrThiSinh(idThiSinh).name & "  gởi : " + temp + " lúc " + Me.Time.ToString())
                        frm1.appendLog(frm1.ArrThiSinh(idThiSinh).name & "   gởi : " + temp + " lúc " + Me.Time.ToString())
                    End If
                    If (temp = MyMessages.SendTeamName) Then
                        temp = r.ReadString()
                        Me.TeamName = temp
                    End If
                    'Nhận được tín hiệu trả lời CNV:
                    If (temp = MyMessages.AnswerCNV) Then
                        'Đọc id Thí sinh (integer)
                        idThiSinhCNV = r.ReadInt32()
                        frm1.idThiSinhCNV = idThiSinhCNV
                        frm1.ShowThiSinhCNV()
                        frm1.SendThiSinhCNV()
                    End If
                    'Nhận được tín hiệu giành quyền về đích:
                    If (temp = MsgVeDich.IDAnswerVeDich) Then
                        idThiSinh = r.ReadInt32()
                        frm1.idThiSinhVD = idThiSinh
                        Debug.Print("ID thí sinh giành quyền: " & idThiSinh)
                        frm1.appendLog("ID thí sinh giành quyền: " & idThiSinh)
                        If (frm1.isGianhQuyenVD = False) Then
                            'Nếu chưa có ai giành quyền về đích:
                            frm1.isGianhQuyenVD = True
                            frm1.ShowThiSinhVeDich()
                            frm1.SendThiSinhVeDich()
                            frm1.SendCommand(MyCommands.DisableVeDich)
                        End If
                    End If
                    'Sleep:
                    Threading.Thread.Sleep(50)
                Loop Until temp = MyMessages.Disconnect

                '  Loop Until r.ReadString() = MyMessages.Disconnect
                Debug.WriteLine(ID & ": Đã tắt.")
                frm1.appendLog(ID & ": Đã tắt.")
                'w.Write(ServerMessages.Disconnect)                


            Else
                Debug.WriteLine(ID & ": Không thể thực hiện kết nối.")
                frm1.appendLog(ID & ": Không thể thực hiện kết nối.")
            End If

            Client.Close()
            Debug.WriteLine(ID & ": Đóng kết nối Client.")
            frm1.appendLog(ID & ": Đóng kết nối Client")
        Catch Err As Exception
            Debug.WriteLine(Err.ToString)
        End Try
    End Sub

End Class

