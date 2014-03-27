<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameplay
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
        Me.lblSelectedCardBorder1 = New System.Windows.Forms.Label()
        Me.lblSelectedCardBorder2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.panBottom = New System.Windows.Forms.Panel()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectedCardBorder1
        '
        Me.lblSelectedCardBorder1.BackColor = System.Drawing.Color.Black
        Me.lblSelectedCardBorder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSelectedCardBorder1.ForeColor = System.Drawing.Color.Transparent
        Me.lblSelectedCardBorder1.Location = New System.Drawing.Point(38, 72)
        Me.lblSelectedCardBorder1.Name = "lblSelectedCardBorder1"
        Me.lblSelectedCardBorder1.Size = New System.Drawing.Size(30, 31)
        Me.lblSelectedCardBorder1.TabIndex = 1
        '
        'lblSelectedCardBorder2
        '
        Me.lblSelectedCardBorder2.BackColor = System.Drawing.Color.Black
        Me.lblSelectedCardBorder2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSelectedCardBorder2.ForeColor = System.Drawing.Color.Transparent
        Me.lblSelectedCardBorder2.Location = New System.Drawing.Point(74, 72)
        Me.lblSelectedCardBorder2.Name = "lblSelectedCardBorder2"
        Me.lblSelectedCardBorder2.Size = New System.Drawing.Size(30, 31)
        Me.lblSelectedCardBorder2.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(-1, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "cheats"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'cmdBack
        '
        Me.cmdBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdBack.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cmdBack.Location = New System.Drawing.Point(12, 12)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(160, 40)
        Me.cmdBack.TabIndex = 5
        Me.cmdBack.Text = "Back to menu"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'panBottom
        '
        Me.panBottom.BackColor = System.Drawing.Color.LightBlue
        Me.panBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.panBottom.Controls.Add(Me.lblTimer)
        Me.panBottom.Controls.Add(Me.lblTime)
        Me.panBottom.Controls.Add(Me.cmdBack)
        Me.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panBottom.Location = New System.Drawing.Point(0, 215)
        Me.panBottom.Name = "panBottom"
        Me.panBottom.Size = New System.Drawing.Size(377, 65)
        Me.panBottom.TabIndex = 6
        '
        'lblTimer
        '
        Me.lblTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTimer.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(283, 14)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(84, 34)
        Me.lblTimer.TabIndex = 9
        Me.lblTimer.Text = "00:00"
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTime.Location = New System.Drawing.Point(203, 14)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(74, 32)
        Me.lblTime.TabIndex = 8
        Me.lblTime.Text = "Time"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmGameplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.cmdBack
        Me.ClientSize = New System.Drawing.Size(377, 280)
        Me.Controls.Add(Me.panBottom)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblSelectedCardBorder2)
        Me.Controls.Add(Me.lblSelectedCardBorder1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmGameplay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGame"
        Me.panBottom.ResumeLayout(False)
        Me.panBottom.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSelectedCardBorder1 As System.Windows.Forms.Label
    Friend WithEvents lblSelectedCardBorder2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents panBottom As System.Windows.Forms.Panel
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
