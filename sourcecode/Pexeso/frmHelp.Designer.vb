<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.panEasyTitle = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panBottom = New System.Windows.Forms.Panel()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.panEasyTitle.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.panBottom.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label7.Size = New System.Drawing.Size(192, 138)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Pexeso or Memory game in English is game where player have to guess pictures and " & _
    "remember their position in order to guess same picture next time "
        '
        'panEasyTitle
        '
        Me.panEasyTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.panEasyTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panEasyTitle.Controls.Add(Me.Label7)
        Me.panEasyTitle.Location = New System.Drawing.Point(7, 62)
        Me.panEasyTitle.Name = "panEasyTitle"
        Me.panEasyTitle.Size = New System.Drawing.Size(194, 140)
        Me.panEasyTitle.TabIndex = 15
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.panEasyTitle)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 60)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(208, 261)
        Me.Panel5.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 67)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "About game"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panBottom
        '
        Me.panBottom.BackColor = System.Drawing.SystemColors.Control
        Me.panBottom.Controls.Add(Me.cmdBack)
        Me.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panBottom.Location = New System.Drawing.Point(0, 321)
        Me.panBottom.Name = "panBottom"
        Me.panBottom.Size = New System.Drawing.Size(694, 100)
        Me.panBottom.TabIndex = 20
        '
        'cmdBack
        '
        Me.cmdBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdBack.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cmdBack.Location = New System.Drawing.Point(275, 30)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(160, 40)
        Me.cmdBack.TabIndex = 4
        Me.cmdBack.Text = "Back to menu"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label14.Location = New System.Drawing.Point(0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label14.Size = New System.Drawing.Size(192, 138)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "The faster you are, better position in Stats! Each difficulty level is evaluated " & _
    "separately so don't have to worry about being beaten by 10yrs old kid!"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Location = New System.Drawing.Point(7, 62)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(194, 140)
        Me.Panel6.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(694, 60)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Help"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 67)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Stats"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(208, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(278, 261)
        Me.Panel1.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(0, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(278, 198)
        Me.Panel2.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label5.Size = New System.Drawing.Size(276, 196)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = resources.GetString("Label5.Text")
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 67)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "How to play"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(486, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(208, 261)
        Me.Panel3.TabIndex = 19
        '
        'frmHelp
        '
        Me.AcceptButton = Me.cmdBack
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdBack
        Me.ClientSize = New System.Drawing.Size(694, 421)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.panBottom)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmHelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHelp"
        Me.panEasyTitle.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.panBottom.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents panEasyTitle As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents panBottom As System.Windows.Forms.Panel
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
