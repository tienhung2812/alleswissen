<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhoiDong
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKhoiDong))
        Me.pbThiSinh = New System.Windows.Forms.PictureBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbQuestion = New System.Windows.Forms.Label()
        Me.lbCategory = New System.Windows.Forms.Label()
        Me.lbScore = New System.Windows.Forms.Label()
        Me.lbTime = New System.Windows.Forms.Label()
        Me.tmTimeCount = New System.Windows.Forms.Timer(Me.components)
        Me.lbEasy = New System.Windows.Forms.Label()
        Me.lbNormal = New System.Windows.Forms.Label()
        Me.lbHard = New System.Windows.Forms.Label()
        CType(Me.pbThiSinh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbThiSinh
        '
        Me.pbThiSinh.BackColor = System.Drawing.Color.Black
        Me.pbThiSinh.ImageLocation = ""
        Me.pbThiSinh.Location = New System.Drawing.Point(155, 53)
        Me.pbThiSinh.Name = "pbThiSinh"
        Me.pbThiSinh.Size = New System.Drawing.Size(467, 319)
        Me.pbThiSinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbThiSinh.TabIndex = 0
        Me.pbThiSinh.TabStop = False
        '
        'lbName
        '
        Me.lbName.BackColor = System.Drawing.Color.Transparent
        Me.lbName.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.ForeColor = System.Drawing.Color.Black
        Me.lbName.Location = New System.Drawing.Point(358, 408)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(339, 40)
        Me.lbName.TabIndex = 1
        Me.lbName.Text = "CONTESTANT"
        Me.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbQuestion
        '
        Me.lbQuestion.BackColor = System.Drawing.Color.Transparent
        Me.lbQuestion.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQuestion.ForeColor = System.Drawing.Color.Black
        Me.lbQuestion.Location = New System.Drawing.Point(67, 523)
        Me.lbQuestion.Name = "lbQuestion"
        Me.lbQuestion.Size = New System.Drawing.Size(698, 201)
        Me.lbQuestion.TabIndex = 2
        Me.lbQuestion.Text = "Question here"
        '
        'lbCategory
        '
        Me.lbCategory.BackColor = System.Drawing.Color.Transparent
        Me.lbCategory.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCategory.ForeColor = System.Drawing.Color.Black
        Me.lbCategory.Location = New System.Drawing.Point(70, 457)
        Me.lbCategory.Name = "lbCategory"
        Me.lbCategory.Size = New System.Drawing.Size(259, 40)
        Me.lbCategory.TabIndex = 3
        Me.lbCategory.Text = "Strategy"
        Me.lbCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbScore
        '
        Me.lbScore.BackColor = System.Drawing.Color.Transparent
        Me.lbScore.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbScore.ForeColor = System.Drawing.Color.Red
        Me.lbScore.Location = New System.Drawing.Point(809, 117)
        Me.lbScore.Name = "lbScore"
        Me.lbScore.Size = New System.Drawing.Size(148, 99)
        Me.lbScore.TabIndex = 4
        Me.lbScore.Text = "0"
        Me.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbScore.Visible = False
        '
        'lbTime
        '
        Me.lbTime.BackColor = System.Drawing.Color.Transparent
        Me.lbTime.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTime.ForeColor = System.Drawing.Color.Red
        Me.lbTime.Location = New System.Drawing.Point(807, 641)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(135, 68)
        Me.lbTime.TabIndex = 5
        Me.lbTime.Text = "10"
        Me.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmTimeCount
        '
        Me.tmTimeCount.Interval = 1000
        '
        'lbEasy
        '
        Me.lbEasy.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbEasy.BackColor = System.Drawing.Color.Transparent
        Me.lbEasy.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEasy.Location = New System.Drawing.Point(824, 221)
        Me.lbEasy.Name = "lbEasy"
        Me.lbEasy.Size = New System.Drawing.Size(115, 60)
        Me.lbEasy.TabIndex = 6
        Me.lbEasy.Text = "Easy"
        Me.lbEasy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbNormal
        '
        Me.lbNormal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbNormal.BackColor = System.Drawing.Color.Transparent
        Me.lbNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNormal.Location = New System.Drawing.Point(824, 344)
        Me.lbNormal.Name = "lbNormal"
        Me.lbNormal.Size = New System.Drawing.Size(115, 60)
        Me.lbNormal.TabIndex = 7
        Me.lbNormal.Text = "Normal"
        Me.lbNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbHard
        '
        Me.lbHard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbHard.BackColor = System.Drawing.Color.Transparent
        Me.lbHard.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHard.Location = New System.Drawing.Point(824, 473)
        Me.lbHard.Name = "lbHard"
        Me.lbHard.Size = New System.Drawing.Size(115, 60)
        Me.lbHard.TabIndex = 8
        Me.lbHard.Text = "Hard"
        Me.lbHard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmKhoiDong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.lbHard)
        Me.Controls.Add(Me.lbNormal)
        Me.Controls.Add(Me.lbEasy)
        Me.Controls.Add(Me.lbTime)
        Me.Controls.Add(Me.lbScore)
        Me.Controls.Add(Me.lbCategory)
        Me.Controls.Add(Me.lbQuestion)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.pbThiSinh)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmKhoiDong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Khoi Dong"
        CType(Me.pbThiSinh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbThiSinh As System.Windows.Forms.PictureBox
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents lbQuestion As System.Windows.Forms.Label
    Friend WithEvents lbCategory As System.Windows.Forms.Label
    Friend WithEvents lbScore As System.Windows.Forms.Label
    Friend WithEvents lbTime As System.Windows.Forms.Label
    Friend WithEvents tmTimeCount As System.Windows.Forms.Timer
    Friend WithEvents lbEasy As System.Windows.Forms.Label
    Friend WithEvents lbNormal As System.Windows.Forms.Label
    Friend WithEvents lbHard As System.Windows.Forms.Label
End Class
