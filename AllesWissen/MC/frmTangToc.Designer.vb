<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTangToc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTangToc))
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.WMP1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.lbNum = New System.Windows.Forms.Label()
        Me.lbQuestion = New System.Windows.Forms.Label()
        Me.pbClock = New System.Windows.Forms.PictureBox()
        Me.tmClock = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WMP1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbClock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbImage
        '
        Me.pbImage.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pbImage.Location = New System.Drawing.Point(164, 145)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(792, 554)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImage.TabIndex = 0
        Me.pbImage.TabStop = False
        Me.pbImage.Visible = False
        '
        'WMP1
        '
        Me.WMP1.Enabled = True
        Me.WMP1.Location = New System.Drawing.Point(164, 145)
        Me.WMP1.Name = "WMP1"
        Me.WMP1.OcxState = CType(resources.GetObject("WMP1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WMP1.Size = New System.Drawing.Size(792, 554)
        Me.WMP1.TabIndex = 1
        '
        'lbNum
        '
        Me.lbNum.Font = New System.Drawing.Font("Arial", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbNum.Location = New System.Drawing.Point(17, 9)
        Me.lbNum.Name = "lbNum"
        Me.lbNum.Size = New System.Drawing.Size(89, 95)
        Me.lbNum.TabIndex = 2
        Me.lbNum.Text = "4"
        '
        'lbQuestion
        '
        Me.lbQuestion.BackColor = System.Drawing.Color.Transparent
        Me.lbQuestion.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQuestion.ForeColor = System.Drawing.Color.Red
        Me.lbQuestion.Location = New System.Drawing.Point(209, 64)
        Me.lbQuestion.Name = "lbQuestion"
        Me.lbQuestion.Size = New System.Drawing.Size(570, 49)
        Me.lbQuestion.TabIndex = 3
        Me.lbQuestion.Text = "Hình nào khác với các hình còn lại"
        Me.lbQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbClock
        '
        Me.pbClock.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pbClock.Image = CType(resources.GetObject("pbClock.Image"), System.Drawing.Image)
        Me.pbClock.Location = New System.Drawing.Point(50, 223)
        Me.pbClock.Name = "pbClock"
        Me.pbClock.Size = New System.Drawing.Size(55, 72)
        Me.pbClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbClock.TabIndex = 4
        Me.pbClock.TabStop = False
        '
        'tmClock
        '
        Me.tmClock.Interval = 210
        '
        'frmTangToc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.pbClock)
        Me.Controls.Add(Me.lbQuestion)
        Me.Controls.Add(Me.lbNum)
        Me.Controls.Add(Me.WMP1)
        Me.Controls.Add(Me.pbImage)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "frmTangToc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tang toc"
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WMP1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbClock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbImage As System.Windows.Forms.PictureBox
    Friend WithEvents WMP1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents lbNum As System.Windows.Forms.Label
    Friend WithEvents lbQuestion As System.Windows.Forms.Label
    Friend WithEvents pbClock As System.Windows.Forms.PictureBox
    Friend WithEvents tmClock As System.Windows.Forms.Timer
End Class
