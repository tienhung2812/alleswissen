<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVuotCNV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVuotCNV))
        Me.lbHeader01 = New System.Windows.Forms.Label()
        Me.lbHeader02 = New System.Windows.Forms.Label()
        Me.lbHeader03 = New System.Windows.Forms.Label()
        Me.lbHeader06 = New System.Windows.Forms.Label()
        Me.lbHeader05 = New System.Windows.Forms.Label()
        Me.lbHeader04 = New System.Windows.Forms.Label()
        Me.lbHeader08 = New System.Windows.Forms.Label()
        Me.lbHeader07 = New System.Windows.Forms.Label()
        Me.lbChuaLat = New System.Windows.Forms.Label()
        Me.lbDangLat = New System.Windows.Forms.Label()
        Me.lbBoQua = New System.Windows.Forms.Label()
        Me.lbDaLat01 = New System.Windows.Forms.Label()
        Me.lbDaLat02 = New System.Windows.Forms.Label()
        Me.lbTime = New System.Windows.Forms.Label()
        Me.lbQuestion = New System.Windows.Forms.Label()
        Me.tmTime = New System.Windows.Forms.Timer(Me.components)
        Me.lbCNVName02 = New System.Windows.Forms.Label()
        Me.lbCNVName03 = New System.Windows.Forms.Label()
        Me.lbCNVName04 = New System.Windows.Forms.Label()
        Me.lbCNVName01 = New System.Windows.Forms.Label()
        Me.lbCategory = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbHeader01
        '
        Me.lbHeader01.Location = New System.Drawing.Point(58, 39)
        Me.lbHeader01.Name = "lbHeader01"
        Me.lbHeader01.Size = New System.Drawing.Size(42, 41)
        Me.lbHeader01.TabIndex = 0
        Me.lbHeader01.Visible = False
        '
        'lbHeader02
        '
        Me.lbHeader02.Location = New System.Drawing.Point(58, 99)
        Me.lbHeader02.Name = "lbHeader02"
        Me.lbHeader02.Size = New System.Drawing.Size(42, 41)
        Me.lbHeader02.TabIndex = 1
        Me.lbHeader02.Visible = False
        '
        'lbHeader03
        '
        Me.lbHeader03.Location = New System.Drawing.Point(58, 161)
        Me.lbHeader03.Name = "lbHeader03"
        Me.lbHeader03.Size = New System.Drawing.Size(42, 41)
        Me.lbHeader03.TabIndex = 2
        Me.lbHeader03.Visible = False
        '
        'lbHeader06
        '
        Me.lbHeader06.Location = New System.Drawing.Point(58, 344)
        Me.lbHeader06.Name = "lbHeader06"
        Me.lbHeader06.Size = New System.Drawing.Size(42, 41)
        Me.lbHeader06.TabIndex = 5
        Me.lbHeader06.Visible = False
        '
        'lbHeader05
        '
        Me.lbHeader05.Location = New System.Drawing.Point(58, 282)
        Me.lbHeader05.Name = "lbHeader05"
        Me.lbHeader05.Size = New System.Drawing.Size(42, 41)
        Me.lbHeader05.TabIndex = 4
        Me.lbHeader05.Visible = False
        '
        'lbHeader04
        '
        Me.lbHeader04.Location = New System.Drawing.Point(58, 222)
        Me.lbHeader04.Name = "lbHeader04"
        Me.lbHeader04.Size = New System.Drawing.Size(42, 41)
        Me.lbHeader04.TabIndex = 3
        Me.lbHeader04.Visible = False
        '
        'lbHeader08
        '
        Me.lbHeader08.Location = New System.Drawing.Point(58, 465)
        Me.lbHeader08.Name = "lbHeader08"
        Me.lbHeader08.Size = New System.Drawing.Size(42, 41)
        Me.lbHeader08.TabIndex = 7
        Me.lbHeader08.Visible = False
        '
        'lbHeader07
        '
        Me.lbHeader07.Location = New System.Drawing.Point(58, 403)
        Me.lbHeader07.Name = "lbHeader07"
        Me.lbHeader07.Size = New System.Drawing.Size(42, 41)
        Me.lbHeader07.TabIndex = 6
        Me.lbHeader07.Visible = False
        '
        'lbChuaLat
        '
        Me.lbChuaLat.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lbChuaLat.Location = New System.Drawing.Point(-15, 394)
        Me.lbChuaLat.Name = "lbChuaLat"
        Me.lbChuaLat.Size = New System.Drawing.Size(54, 54)
        Me.lbChuaLat.TabIndex = 8
        Me.lbChuaLat.Visible = False
        '
        'lbDangLat
        '
        Me.lbDangLat.BackColor = System.Drawing.Color.Khaki
        Me.lbDangLat.Location = New System.Drawing.Point(-15, 256)
        Me.lbDangLat.Name = "lbDangLat"
        Me.lbDangLat.Size = New System.Drawing.Size(50, 50)
        Me.lbDangLat.TabIndex = 9
        Me.lbDangLat.Visible = False
        '
        'lbBoQua
        '
        Me.lbBoQua.BackColor = System.Drawing.Color.Crimson
        Me.lbBoQua.Location = New System.Drawing.Point(-15, 325)
        Me.lbBoQua.Name = "lbBoQua"
        Me.lbBoQua.Size = New System.Drawing.Size(50, 50)
        Me.lbBoQua.TabIndex = 10
        Me.lbBoQua.Visible = False
        '
        'lbDaLat01
        '
        Me.lbDaLat01.BackColor = System.Drawing.Color.AntiqueWhite
        Me.lbDaLat01.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDaLat01.Location = New System.Drawing.Point(-15, 197)
        Me.lbDaLat01.Name = "lbDaLat01"
        Me.lbDaLat01.Size = New System.Drawing.Size(50, 50)
        Me.lbDaLat01.TabIndex = 11
        Me.lbDaLat01.Text = "A"
        Me.lbDaLat01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbDaLat01.Visible = False
        '
        'lbDaLat02
        '
        Me.lbDaLat02.BackColor = System.Drawing.Color.Red
        Me.lbDaLat02.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDaLat02.ForeColor = System.Drawing.Color.White
        Me.lbDaLat02.Location = New System.Drawing.Point(-15, 465)
        Me.lbDaLat02.Name = "lbDaLat02"
        Me.lbDaLat02.Size = New System.Drawing.Size(50, 50)
        Me.lbDaLat02.TabIndex = 12
        Me.lbDaLat02.Text = "Ý"
        Me.lbDaLat02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbDaLat02.Visible = False
        '
        'lbTime
        '
        Me.lbTime.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbTime.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbTime.Location = New System.Drawing.Point(12, 587)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(105, 122)
        Me.lbTime.TabIndex = 13
        Me.lbTime.Text = "00"
        Me.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbTime.Visible = False
        '
        'lbQuestion
        '
        Me.lbQuestion.BackColor = System.Drawing.Color.Transparent
        Me.lbQuestion.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQuestion.ForeColor = System.Drawing.Color.Black
        Me.lbQuestion.Location = New System.Drawing.Point(144, 175)
        Me.lbQuestion.Name = "lbQuestion"
        Me.lbQuestion.Size = New System.Drawing.Size(764, 515)
        Me.lbQuestion.TabIndex = 14
        Me.lbQuestion.Text = "Câu hỏi"
        '
        'tmTime
        '
        Me.tmTime.Interval = 1000
        '
        'lbCNVName02
        '
        Me.lbCNVName02.BackColor = System.Drawing.Color.Red
        Me.lbCNVName02.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCNVName02.ForeColor = System.Drawing.Color.White
        Me.lbCNVName02.Location = New System.Drawing.Point(876, 426)
        Me.lbCNVName02.Name = "lbCNVName02"
        Me.lbCNVName02.Size = New System.Drawing.Size(150, 33)
        Me.lbCNVName02.TabIndex = 15
        Me.lbCNVName02.Text = "TÊN THÍ SINH"
        Me.lbCNVName02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbCNVName02.Visible = False
        '
        'lbCNVName03
        '
        Me.lbCNVName03.BackColor = System.Drawing.Color.Red
        Me.lbCNVName03.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCNVName03.ForeColor = System.Drawing.Color.White
        Me.lbCNVName03.Location = New System.Drawing.Point(876, 465)
        Me.lbCNVName03.Name = "lbCNVName03"
        Me.lbCNVName03.Size = New System.Drawing.Size(150, 33)
        Me.lbCNVName03.TabIndex = 16
        Me.lbCNVName03.Text = "TÊN THÍ SINH"
        Me.lbCNVName03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbCNVName03.Visible = False
        '
        'lbCNVName04
        '
        Me.lbCNVName04.BackColor = System.Drawing.Color.Red
        Me.lbCNVName04.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCNVName04.ForeColor = System.Drawing.Color.White
        Me.lbCNVName04.Location = New System.Drawing.Point(876, 505)
        Me.lbCNVName04.Name = "lbCNVName04"
        Me.lbCNVName04.Size = New System.Drawing.Size(150, 33)
        Me.lbCNVName04.TabIndex = 17
        Me.lbCNVName04.Text = "TÊN THÍ SINH"
        Me.lbCNVName04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbCNVName04.Visible = False
        '
        'lbCNVName01
        '
        Me.lbCNVName01.BackColor = System.Drawing.Color.Red
        Me.lbCNVName01.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCNVName01.ForeColor = System.Drawing.Color.White
        Me.lbCNVName01.Location = New System.Drawing.Point(876, 388)
        Me.lbCNVName01.Name = "lbCNVName01"
        Me.lbCNVName01.Size = New System.Drawing.Size(150, 33)
        Me.lbCNVName01.TabIndex = 18
        Me.lbCNVName01.Text = "TÊN THÍ SINH"
        Me.lbCNVName01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbCNVName01.Visible = False
        '
        'lbCategory
        '
        Me.lbCategory.BackColor = System.Drawing.Color.Transparent
        Me.lbCategory.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCategory.Location = New System.Drawing.Point(208, 67)
        Me.lbCategory.Name = "lbCategory"
        Me.lbCategory.Size = New System.Drawing.Size(470, 45)
        Me.lbCategory.TabIndex = 19
        Me.lbCategory.Text = "Câu 1"
        Me.lbCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmVuotCNV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.lbCategory)
        Me.Controls.Add(Me.lbCNVName01)
        Me.Controls.Add(Me.lbCNVName04)
        Me.Controls.Add(Me.lbCNVName03)
        Me.Controls.Add(Me.lbCNVName02)
        Me.Controls.Add(Me.lbQuestion)
        Me.Controls.Add(Me.lbTime)
        Me.Controls.Add(Me.lbDaLat02)
        Me.Controls.Add(Me.lbDaLat01)
        Me.Controls.Add(Me.lbBoQua)
        Me.Controls.Add(Me.lbDangLat)
        Me.Controls.Add(Me.lbChuaLat)
        Me.Controls.Add(Me.lbHeader08)
        Me.Controls.Add(Me.lbHeader07)
        Me.Controls.Add(Me.lbHeader06)
        Me.Controls.Add(Me.lbHeader05)
        Me.Controls.Add(Me.lbHeader04)
        Me.Controls.Add(Me.lbHeader03)
        Me.Controls.Add(Me.lbHeader02)
        Me.Controls.Add(Me.lbHeader01)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "frmVuotCNV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vuot chuong ngai vat"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbHeader01 As System.Windows.Forms.Label
    Friend WithEvents lbHeader02 As System.Windows.Forms.Label
    Friend WithEvents lbHeader03 As System.Windows.Forms.Label
    Friend WithEvents lbHeader06 As System.Windows.Forms.Label
    Friend WithEvents lbHeader05 As System.Windows.Forms.Label
    Friend WithEvents lbHeader04 As System.Windows.Forms.Label
    Friend WithEvents lbHeader08 As System.Windows.Forms.Label
    Friend WithEvents lbHeader07 As System.Windows.Forms.Label
    Friend WithEvents lbChuaLat As System.Windows.Forms.Label
    Friend WithEvents lbDangLat As System.Windows.Forms.Label
    Friend WithEvents lbBoQua As System.Windows.Forms.Label
    Friend WithEvents lbDaLat01 As System.Windows.Forms.Label
    Friend WithEvents lbDaLat02 As System.Windows.Forms.Label
    Friend WithEvents lbTime As System.Windows.Forms.Label
    Friend WithEvents lbQuestion As System.Windows.Forms.Label
    Friend WithEvents tmTime As System.Windows.Forms.Timer
    Friend WithEvents lbCNVName02 As System.Windows.Forms.Label
    Friend WithEvents lbCNVName03 As System.Windows.Forms.Label
    Friend WithEvents lbCNVName04 As System.Windows.Forms.Label
    Friend WithEvents lbCNVName01 As System.Windows.Forms.Label
    Friend WithEvents lbCategory As System.Windows.Forms.Label
End Class
