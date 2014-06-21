<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.imgExit = New System.Windows.Forms.PictureBox()
        Me.imgStats = New System.Windows.Forms.PictureBox()
        Me.imgHelp = New System.Windows.Forms.PictureBox()
        Me.imgPlay = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgStats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Pexeso.My.Resources.Resources.pexeso
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(760, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'imgExit
        '
        Me.imgExit.Image = CType(resources.GetObject("imgExit.Image"), System.Drawing.Image)
        Me.imgExit.Location = New System.Drawing.Point(570, 124)
        Me.imgExit.Name = "imgExit"
        Me.imgExit.Size = New System.Drawing.Size(180, 251)
        Me.imgExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgExit.TabIndex = 9
        Me.imgExit.TabStop = False
        '
        'imgStats
        '
        Me.imgStats.Image = CType(resources.GetObject("imgStats.Image"), System.Drawing.Image)
        Me.imgStats.Location = New System.Drawing.Point(384, 124)
        Me.imgStats.Name = "imgStats"
        Me.imgStats.Size = New System.Drawing.Size(180, 251)
        Me.imgStats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgStats.TabIndex = 8
        Me.imgStats.TabStop = False
        '
        'imgHelp
        '
        Me.imgHelp.Image = CType(resources.GetObject("imgHelp.Image"), System.Drawing.Image)
        Me.imgHelp.Location = New System.Drawing.Point(198, 124)
        Me.imgHelp.Name = "imgHelp"
        Me.imgHelp.Size = New System.Drawing.Size(180, 251)
        Me.imgHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHelp.TabIndex = 7
        Me.imgHelp.TabStop = False
        '
        'imgPlay
        '
        Me.imgPlay.Image = Global.Pexeso.My.Resources.Resources.back
        Me.imgPlay.Location = New System.Drawing.Point(12, 124)
        Me.imgPlay.Name = "imgPlay"
        Me.imgPlay.Size = New System.Drawing.Size(180, 251)
        Me.imgPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPlay.TabIndex = 6
        Me.imgPlay.TabStop = False
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(760, 384)
        Me.Controls.Add(Me.imgExit)
        Me.Controls.Add(Me.imgStats)
        Me.Controls.Add(Me.imgHelp)
        Me.Controls.Add(Me.imgPlay)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pexeso"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgStats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPlay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgPlay As System.Windows.Forms.PictureBox
    Friend WithEvents imgHelp As System.Windows.Forms.PictureBox
    Friend WithEvents imgStats As System.Windows.Forms.PictureBox
    Friend WithEvents imgExit As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
