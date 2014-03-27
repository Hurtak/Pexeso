<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameSelect
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
        Me.lstDifficulty = New System.Windows.Forms.ListBox()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.NumericUpDownX = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDownY = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotalNumberOfCards = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstDifficulty
        '
        Me.lstDifficulty.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lstDifficulty.FormattingEnabled = True
        Me.lstDifficulty.ItemHeight = 25
        Me.lstDifficulty.Items.AddRange(New Object() {"Easy", "Normal", "Hard", "User defined"})
        Me.lstDifficulty.Location = New System.Drawing.Point(12, 44)
        Me.lstDifficulty.Name = "lstDifficulty"
        Me.lstDifficulty.Size = New System.Drawing.Size(225, 104)
        Me.lstDifficulty.TabIndex = 1
        '
        'cmdStart
        '
        Me.cmdStart.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cmdStart.Location = New System.Drawing.Point(40, 266)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(160, 40)
        Me.cmdStart.TabIndex = 5
        Me.cmdStart.Text = "Start the game"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdBack.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cmdBack.Location = New System.Drawing.Point(40, 198)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(160, 40)
        Me.cmdBack.TabIndex = 4
        Me.cmdBack.Text = "Back to menu"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'NumericUpDownX
        '
        Me.NumericUpDownX.BackColor = System.Drawing.Color.White
        Me.NumericUpDownX.Enabled = False
        Me.NumericUpDownX.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.NumericUpDownX.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.NumericUpDownX.Location = New System.Drawing.Point(283, 83)
        Me.NumericUpDownX.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.NumericUpDownX.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NumericUpDownX.Name = "NumericUpDownX"
        Me.NumericUpDownX.ReadOnly = True
        Me.NumericUpDownX.Size = New System.Drawing.Size(59, 32)
        Me.NumericUpDownX.TabIndex = 2
        Me.NumericUpDownX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDownX.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(345, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "x"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUpDownY
        '
        Me.NumericUpDownY.BackColor = System.Drawing.Color.White
        Me.NumericUpDownY.Enabled = False
        Me.NumericUpDownY.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.NumericUpDownY.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.NumericUpDownY.Location = New System.Drawing.Point(381, 83)
        Me.NumericUpDownY.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.NumericUpDownY.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownY.Name = "NumericUpDownY"
        Me.NumericUpDownY.ReadOnly = True
        Me.NumericUpDownY.Size = New System.Drawing.Size(59, 32)
        Me.NumericUpDownY.TabIndex = 3
        Me.NumericUpDownY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDownY.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 32)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Difficulty selection"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(277, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 32)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Number of cards"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(278, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "X asix"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(376, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Y axis"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(446, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 32)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "="
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalNumberOfCards
        '
        Me.lblTotalNumberOfCards.BackColor = System.Drawing.Color.White
        Me.lblTotalNumberOfCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalNumberOfCards.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTotalNumberOfCards.Location = New System.Drawing.Point(489, 83)
        Me.lblTotalNumberOfCards.Name = "lblTotalNumberOfCards"
        Me.lblTotalNumberOfCards.Size = New System.Drawing.Size(55, 32)
        Me.lblTotalNumberOfCards.TabIndex = 12
        Me.lblTotalNumberOfCards.Text = "16"
        Me.lblTotalNumberOfCards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(277, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 32)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Time to beat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(297, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 25)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "1st place"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.Location = New System.Drawing.Point(297, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 25)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "10th place"
        '
        'lblFirst
        '
        Me.lblFirst.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFirst.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblFirst.Location = New System.Drawing.Point(432, 222)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(84, 34)
        Me.lblFirst.TabIndex = 16
        Me.lblFirst.Text = "00:00"
        Me.lblFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLast
        '
        Me.lblLast.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLast.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblLast.Location = New System.Drawing.Point(432, 275)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(84, 34)
        Me.lblLast.TabIndex = 17
        Me.lblLast.Text = "00:00"
        Me.lblLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmGameSelect
        '
        Me.AcceptButton = Me.cmdStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.cmdBack
        Me.ClientSize = New System.Drawing.Size(560, 334)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTotalNumberOfCards)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDownY)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDownX)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.lstDifficulty)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmGameSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGameSelect"
        CType(Me.NumericUpDownX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstDifficulty As System.Windows.Forms.ListBox
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents NumericUpDownX As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownY As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTotalNumberOfCards As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblLast As System.Windows.Forms.Label
End Class
