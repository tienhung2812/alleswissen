<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSound2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSound2))
        Me.WMP1 = New AxWMPLib.AxWindowsMediaPlayer
        CType(Me.WMP1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WMP1
        '
        Me.WMP1.Enabled = True
        Me.WMP1.Location = New System.Drawing.Point(19, 55)
        Me.WMP1.Name = "WMP1"
        Me.WMP1.OcxState = CType(resources.GetObject("WMP1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WMP1.Size = New System.Drawing.Size(247, 155)
        Me.WMP1.TabIndex = 3
        '
        'frmSound2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.WMP1)
        Me.Name = "frmSound2"
        Me.Text = "frmSound2"
        CType(Me.WMP1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WMP1 As AxWMPLib.AxWindowsMediaPlayer
End Class
