<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbScore04 = New System.Windows.Forms.Label()
        Me.lbName03 = New System.Windows.Forms.Label()
        Me.lbName04 = New System.Windows.Forms.Label()
        Me.lbScore03 = New System.Windows.Forms.Label()
        Me.lbScore02 = New System.Windows.Forms.Label()
        Me.lbName01 = New System.Windows.Forms.Label()
        Me.lbName02 = New System.Windows.Forms.Label()
        Me.lbScore01 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbTime = New System.Windows.Forms.Label()
        Me.lbDaNhan = New System.Windows.Forms.Label()
        Me.lbAnswer = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbAnswer = New System.Windows.Forms.TextBox()
        Me.lbQuestion = New System.Windows.Forms.Label()
        Me.lbTeamName = New System.Windows.Forms.Label()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.mnIPAddress = New System.Windows.Forms.MenuItem()
        Me.mnTeamName = New System.Windows.Forms.MenuItem()
        Me.mnConnect = New System.Windows.Forms.MenuItem()
        Me.tmTime = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSteal = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GroupBox1.Controls.Add(Me.lbScore04)
        Me.GroupBox1.Controls.Add(Me.lbName03)
        Me.GroupBox1.Controls.Add(Me.lbName04)
        Me.GroupBox1.Controls.Add(Me.lbScore03)
        Me.GroupBox1.Controls.Add(Me.lbScore02)
        Me.GroupBox1.Controls.Add(Me.lbName01)
        Me.GroupBox1.Controls.Add(Me.lbName02)
        Me.GroupBox1.Controls.Add(Me.lbScore01)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(176, 129)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Score"
        '
        'lbScore04
        '
        Me.lbScore04.Enabled = False
        Me.lbScore04.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbScore04.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbScore04.Location = New System.Drawing.Point(136, 101)
        Me.lbScore04.Name = "lbScore04"
        Me.lbScore04.Size = New System.Drawing.Size(37, 25)
        Me.lbScore04.TabIndex = 17
        Me.lbScore04.Text = "000"
        Me.lbScore04.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbScore04.Visible = False
        '
        'lbName03
        '
        Me.lbName03.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName03.Location = New System.Drawing.Point(6, 75)
        Me.lbName03.Name = "lbName03"
        Me.lbName03.Size = New System.Drawing.Size(127, 25)
        Me.lbName03.TabIndex = 14
        Me.lbName03.Text = "Contestant 3"
        Me.lbName03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbName04
        '
        Me.lbName04.Enabled = False
        Me.lbName04.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName04.Location = New System.Drawing.Point(6, 101)
        Me.lbName04.Name = "lbName04"
        Me.lbName04.Size = New System.Drawing.Size(127, 25)
        Me.lbName04.TabIndex = 16
        Me.lbName04.Text = "Contestant 4"
        Me.lbName04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbName04.Visible = False
        '
        'lbScore03
        '
        Me.lbScore03.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbScore03.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbScore03.Location = New System.Drawing.Point(136, 75)
        Me.lbScore03.Name = "lbScore03"
        Me.lbScore03.Size = New System.Drawing.Size(37, 25)
        Me.lbScore03.TabIndex = 15
        Me.lbScore03.Text = "000"
        Me.lbScore03.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbScore02
        '
        Me.lbScore02.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbScore02.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbScore02.Location = New System.Drawing.Point(136, 49)
        Me.lbScore02.Name = "lbScore02"
        Me.lbScore02.Size = New System.Drawing.Size(37, 25)
        Me.lbScore02.TabIndex = 13
        Me.lbScore02.Text = "000"
        Me.lbScore02.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbName01
        '
        Me.lbName01.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName01.Location = New System.Drawing.Point(6, 23)
        Me.lbName01.Name = "lbName01"
        Me.lbName01.Size = New System.Drawing.Size(127, 25)
        Me.lbName01.TabIndex = 10
        Me.lbName01.Text = "Contestant 1"
        Me.lbName01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbName02
        '
        Me.lbName02.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName02.Location = New System.Drawing.Point(6, 49)
        Me.lbName02.Name = "lbName02"
        Me.lbName02.Size = New System.Drawing.Size(127, 25)
        Me.lbName02.TabIndex = 12
        Me.lbName02.Text = "Contestant 2"
        Me.lbName02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbScore01
        '
        Me.lbScore01.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbScore01.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbScore01.Location = New System.Drawing.Point(136, 23)
        Me.lbScore01.Name = "lbScore01"
        Me.lbScore01.Size = New System.Drawing.Size(37, 25)
        Me.lbScore01.TabIndex = 11
        Me.lbScore01.Text = "000"
        Me.lbScore01.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(104, 310)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Time left"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbTime
        '
        Me.lbTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbTime.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTime.ForeColor = System.Drawing.Color.Red
        Me.lbTime.Location = New System.Drawing.Point(91, 313)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(88, 60)
        Me.lbTime.TabIndex = 20
        Me.lbTime.Text = "00"
        Me.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbDaNhan
        '
        Me.lbDaNhan.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbDaNhan.AutoSize = True
        Me.lbDaNhan.Location = New System.Drawing.Point(304, 312)
        Me.lbDaNhan.Name = "lbDaNhan"
        Me.lbDaNhan.Size = New System.Drawing.Size(69, 13)
        Me.lbDaNhan.TabIndex = 25
        Me.lbDaNhan.Text = "Solution got :"
        '
        'lbAnswer
        '
        Me.lbAnswer.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbAnswer.AutoSize = True
        Me.lbAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAnswer.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lbAnswer.Location = New System.Drawing.Point(379, 310)
        Me.lbAnswer.Name = "lbAnswer"
        Me.lbAnswer.Size = New System.Drawing.Size(105, 15)
        Me.lbAnswer.TabIndex = 24
        Me.lbAnswer.Text = "Answer goes here"
        Me.lbAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(214, 339)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 23)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Answer:"
        '
        'tbAnswer
        '
        Me.tbAnswer.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.tbAnswer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAnswer.Location = New System.Drawing.Point(287, 337)
        Me.tbAnswer.Name = "tbAnswer"
        Me.tbAnswer.Size = New System.Drawing.Size(422, 26)
        Me.tbAnswer.TabIndex = 22
        '
        'lbQuestion
        '
        Me.lbQuestion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lbQuestion.BackColor = System.Drawing.SystemColors.Control
        Me.lbQuestion.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQuestion.Location = New System.Drawing.Point(187, 39)
        Me.lbQuestion.Name = "lbQuestion"
        Me.lbQuestion.Size = New System.Drawing.Size(556, 258)
        Me.lbQuestion.TabIndex = 26
        Me.lbQuestion.Text = "Question goes here"
        '
        'lbTeamName
        '
        Me.lbTeamName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbTeamName.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTeamName.Location = New System.Drawing.Point(258, 3)
        Me.lbTeamName.Name = "lbTeamName"
        Me.lbTeamName.Size = New System.Drawing.Size(393, 34)
        Me.lbTeamName.TabIndex = 27
        Me.lbTeamName.Text = "Contestant's Name"
        Me.lbTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.mnIPAddress.Text = "IP Config"
        '
        'mnTeamName
        '
        Me.mnTeamName.Index = 1
        Me.mnTeamName.Text = "Name..."
        '
        'mnConnect
        '
        Me.mnConnect.Index = 2
        Me.mnConnect.Text = "Connect"
        '
        'tmTime
        '
        Me.tmTime.Interval = 1000
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GroupBox3.Controls.Add(Me.btnSteal)
        Me.GroupBox3.Location = New System.Drawing.Point(752, 103)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(128, 82)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Get chance to answer"
        '
        'btnSteal
        '
        Me.btnSteal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSteal.Enabled = False
        Me.btnSteal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSteal.ForeColor = System.Drawing.Color.Red
        Me.btnSteal.Location = New System.Drawing.Point(6, 18)
        Me.btnSteal.Name = "btnSteal"
        Me.btnSteal.Size = New System.Drawing.Size(116, 55)
        Me.btnSteal.TabIndex = 9
        Me.btnSteal.Text = "Get Chance"
        Me.btnSteal.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 384)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lbTeamName)
        Me.Controls.Add(Me.lbDaNhan)
        Me.Controls.Add(Me.lbAnswer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbAnswer)
        Me.Controls.Add(Me.lbQuestion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbTime)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client - AllesWissen (Demo)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbScore04 As System.Windows.Forms.Label
    Friend WithEvents lbName03 As System.Windows.Forms.Label
    Friend WithEvents lbName04 As System.Windows.Forms.Label
    Friend WithEvents lbScore03 As System.Windows.Forms.Label
    Friend WithEvents lbScore02 As System.Windows.Forms.Label
    Friend WithEvents lbName01 As System.Windows.Forms.Label
    Friend WithEvents lbName02 As System.Windows.Forms.Label
    Friend WithEvents lbScore01 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbTime As System.Windows.Forms.Label
    Friend WithEvents lbDaNhan As System.Windows.Forms.Label
    Friend WithEvents lbAnswer As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents tbAnswer As System.Windows.Forms.TextBox
    Friend WithEvents lbQuestion As System.Windows.Forms.Label
    Friend WithEvents lbTeamName As System.Windows.Forms.Label
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnIPAddress As System.Windows.Forms.MenuItem
    Friend WithEvents mnTeamName As System.Windows.Forms.MenuItem
    Friend WithEvents mnConnect As System.Windows.Forms.MenuItem
    Friend WithEvents tmTime As System.Windows.Forms.Timer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSteal As System.Windows.Forms.Button

End Class
