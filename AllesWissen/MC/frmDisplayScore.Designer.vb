<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayScore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDisplayScore))
        Me.lbScore01 = New System.Windows.Forms.Label()
        Me.lbScore02 = New System.Windows.Forms.Label()
        Me.lbScore04 = New System.Windows.Forms.Label()
        Me.lbScore03 = New System.Windows.Forms.Label()
        Me.lbName01 = New System.Windows.Forms.Label()
        Me.lbName02 = New System.Windows.Forms.Label()
        Me.lbName03 = New System.Windows.Forms.Label()
        Me.lbName04 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbScore01
        '
        Me.lbScore01.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbScore01.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbScore01.Location = New System.Drawing.Point(127, 191)
        Me.lbScore01.Name = "lbScore01"
        Me.lbScore01.Size = New System.Drawing.Size(157, 84)
        Me.lbScore01.TabIndex = 0
        Me.lbScore01.Text = "000"
        Me.lbScore01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbScore02
        '
        Me.lbScore02.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbScore02.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbScore02.Location = New System.Drawing.Point(149, 383)
        Me.lbScore02.Name = "lbScore02"
        Me.lbScore02.Size = New System.Drawing.Size(157, 84)
        Me.lbScore02.TabIndex = 1
        Me.lbScore02.Text = "000"
        Me.lbScore02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbScore04
        '
        Me.lbScore04.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbScore04.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbScore04.Location = New System.Drawing.Point(364, 658)
        Me.lbScore04.Name = "lbScore04"
        Me.lbScore04.Size = New System.Drawing.Size(157, 84)
        Me.lbScore04.TabIndex = 2
        Me.lbScore04.Text = "000"
        Me.lbScore04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbScore04.Visible = False
        '
        'lbScore03
        '
        Me.lbScore03.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbScore03.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbScore03.Location = New System.Drawing.Point(129, 580)
        Me.lbScore03.Name = "lbScore03"
        Me.lbScore03.Size = New System.Drawing.Size(157, 84)
        Me.lbScore03.TabIndex = 3
        Me.lbScore03.Text = "000"
        Me.lbScore03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbName01
        '
        Me.lbName01.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbName01.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName01.ForeColor = System.Drawing.Color.Black
        Me.lbName01.Location = New System.Drawing.Point(333, 195)
        Me.lbName01.Name = "lbName01"
        Me.lbName01.Size = New System.Drawing.Size(531, 84)
        Me.lbName01.TabIndex = 4
        Me.lbName01.Text = "TÊN THÍ SINH"
        Me.lbName01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbName02
        '
        Me.lbName02.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbName02.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName02.ForeColor = System.Drawing.Color.Black
        Me.lbName02.Location = New System.Drawing.Point(357, 384)
        Me.lbName02.Name = "lbName02"
        Me.lbName02.Size = New System.Drawing.Size(513, 84)
        Me.lbName02.TabIndex = 5
        Me.lbName02.Text = "TÊN THÍ SINH"
        Me.lbName02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbName03
        '
        Me.lbName03.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbName03.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName03.ForeColor = System.Drawing.Color.Black
        Me.lbName03.Location = New System.Drawing.Point(347, 581)
        Me.lbName03.Name = "lbName03"
        Me.lbName03.Size = New System.Drawing.Size(534, 84)
        Me.lbName03.TabIndex = 6
        Me.lbName03.Text = "TÊN THÍ SINH"
        Me.lbName03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbName04
        '
        Me.lbName04.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbName04.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName04.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbName04.Location = New System.Drawing.Point(527, 677)
        Me.lbName04.Name = "lbName04"
        Me.lbName04.Size = New System.Drawing.Size(243, 37)
        Me.lbName04.TabIndex = 7
        Me.lbName04.Text = "TÊN THÍ SINH"
        Me.lbName04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbName04.Visible = False
        '
        'frmDisplayScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.lbName04)
        Me.Controls.Add(Me.lbName03)
        Me.Controls.Add(Me.lbName02)
        Me.Controls.Add(Me.lbName01)
        Me.Controls.Add(Me.lbScore03)
        Me.Controls.Add(Me.lbScore04)
        Me.Controls.Add(Me.lbScore02)
        Me.Controls.Add(Me.lbScore01)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "frmDisplayScore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bang diem"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbScore01 As System.Windows.Forms.Label
    Friend WithEvents lbScore02 As System.Windows.Forms.Label
    Friend WithEvents lbScore04 As System.Windows.Forms.Label
    Friend WithEvents lbScore03 As System.Windows.Forms.Label
    Friend WithEvents lbName01 As System.Windows.Forms.Label
    Friend WithEvents lbName02 As System.Windows.Forms.Label
    Friend WithEvents lbName03 As System.Windows.Forms.Label
    Friend WithEvents lbName04 As System.Windows.Forms.Label
End Class
