<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStats
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
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.panBottom = New System.Windows.Forms.Panel()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.panEasyTitle = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panEasy = New System.Windows.Forms.Panel()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lblEasyNumber = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.panBottom.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.panEasyTitle.SuspendLayout()
        Me.panEasy.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdBack
        '
        Me.cmdBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdBack.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cmdBack.Location = New System.Drawing.Point(38, 30)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(160, 40)
        Me.cmdBack.TabIndex = 4
        Me.cmdBack.Text = "Back to menu"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(694, 60)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Leaderboards"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(236, 67)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Easy"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 67)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Normal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 67)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Hard"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(236, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(222, 312)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(0, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(222, 41)
        Me.Panel2.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.Label5.Size = New System.Drawing.Size(130, 39)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label9.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.Location = New System.Drawing.Point(163, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Label9.Size = New System.Drawing.Size(57, 39)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Time"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label10.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 39)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Nr."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lbl3)
        Me.Panel4.Controls.Add(Me.lbl4)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Location = New System.Drawing.Point(0, 105)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(222, 201)
        Me.Panel4.TabIndex = 17
        '
        'lbl3
        '
        Me.lbl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl3.Location = New System.Drawing.Point(33, 0)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Padding = New System.Windows.Forms.Padding(9, 4, 0, 0)
        Me.lbl3.Size = New System.Drawing.Size(126, 199)
        Me.lbl3.TabIndex = 16
        Me.lbl3.Text = "user1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user6" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user7" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user8" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user9" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user10"
        '
        'lbl4
        '
        Me.lbl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl4.Location = New System.Drawing.Point(159, 0)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.lbl4.Size = New System.Drawing.Size(61, 199)
        Me.lbl4.TabIndex = 15
        Me.lbl4.Text = "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10"
        Me.lbl4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label13.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.Label13.Size = New System.Drawing.Size(33, 199)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "1." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "6." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "8." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "9." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "10."
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(458, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(236, 312)
        Me.Panel3.TabIndex = 14
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Controls.Add(Me.Label15)
        Me.Panel6.Controls.Add(Me.Label16)
        Me.Panel6.Location = New System.Drawing.Point(7, 62)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(222, 41)
        Me.Panel6.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label14.Location = New System.Drawing.Point(33, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.Label14.Size = New System.Drawing.Size(130, 39)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Name"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label15.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label15.Location = New System.Drawing.Point(163, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Label15.Size = New System.Drawing.Size(57, 39)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Time"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label16.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 39)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Nr."
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.lbl5)
        Me.Panel7.Controls.Add(Me.lbl6)
        Me.Panel7.Controls.Add(Me.Label19)
        Me.Panel7.Location = New System.Drawing.Point(7, 105)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(222, 201)
        Me.Panel7.TabIndex = 17
        '
        'lbl5
        '
        Me.lbl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl5.Location = New System.Drawing.Point(33, 0)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Padding = New System.Windows.Forms.Padding(9, 4, 0, 0)
        Me.lbl5.Size = New System.Drawing.Size(126, 199)
        Me.lbl5.TabIndex = 16
        Me.lbl5.Text = "user1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user6" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user7" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user8" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user9" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user10"
        '
        'lbl6
        '
        Me.lbl6.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl6.Location = New System.Drawing.Point(159, 0)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.lbl6.Size = New System.Drawing.Size(61, 199)
        Me.lbl6.TabIndex = 15
        Me.lbl6.Text = "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10"
        Me.lbl6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label19
        '
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label19.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label19.Location = New System.Drawing.Point(0, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.Label19.Size = New System.Drawing.Size(33, 199)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "1." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "6." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "8." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "9." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "10."
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'panBottom
        '
        Me.panBottom.BackColor = System.Drawing.SystemColors.Control
        Me.panBottom.Controls.Add(Me.cmdReset)
        Me.panBottom.Controls.Add(Me.cmdBack)
        Me.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panBottom.Location = New System.Drawing.Point(0, 372)
        Me.panBottom.Name = "panBottom"
        Me.panBottom.Size = New System.Drawing.Size(694, 100)
        Me.panBottom.TabIndex = 15
        '
        'cmdReset
        '
        Me.cmdReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdReset.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cmdReset.Location = New System.Drawing.Point(480, 30)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(193, 40)
        Me.cmdReset.TabIndex = 5
        Me.cmdReset.Text = "Reset leaderboard"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.panEasyTitle)
        Me.Panel5.Controls.Add(Me.panEasy)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 60)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(236, 312)
        Me.Panel5.TabIndex = 16
        '
        'panEasyTitle
        '
        Me.panEasyTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.panEasyTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panEasyTitle.Controls.Add(Me.Label7)
        Me.panEasyTitle.Controls.Add(Me.Label8)
        Me.panEasyTitle.Controls.Add(Me.Label6)
        Me.panEasyTitle.Location = New System.Drawing.Point(7, 62)
        Me.panEasyTitle.Name = "panEasyTitle"
        Me.panEasyTitle.Size = New System.Drawing.Size(222, 41)
        Me.panEasyTitle.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.Label7.Size = New System.Drawing.Size(130, 39)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Name"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label8.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(163, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Label8.Size = New System.Drawing.Size(57, 39)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Time"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 39)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Nr."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'panEasy
        '
        Me.panEasy.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.panEasy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panEasy.Controls.Add(Me.lbl1)
        Me.panEasy.Controls.Add(Me.lbl2)
        Me.panEasy.Controls.Add(Me.lblEasyNumber)
        Me.panEasy.Location = New System.Drawing.Point(7, 105)
        Me.panEasy.Name = "panEasy"
        Me.panEasy.Size = New System.Drawing.Size(222, 201)
        Me.panEasy.TabIndex = 11
        '
        'lbl1
        '
        Me.lbl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl1.Location = New System.Drawing.Point(33, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Padding = New System.Windows.Forms.Padding(9, 4, 0, 0)
        Me.lbl1.Size = New System.Drawing.Size(126, 199)
        Me.lbl1.TabIndex = 16
        Me.lbl1.Text = "user1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user6" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user7" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "123456789012" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WWWWWWWWWWWW" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user" & _
    "10"
        '
        'lbl2
        '
        Me.lbl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl2.Location = New System.Drawing.Point(159, 0)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.lbl2.Size = New System.Drawing.Size(61, 199)
        Me.lbl2.TabIndex = 15
        Me.lbl2.Text = "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:10"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblEasyNumber
        '
        Me.lblEasyNumber.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblEasyNumber.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblEasyNumber.Location = New System.Drawing.Point(0, 0)
        Me.lblEasyNumber.Name = "lblEasyNumber"
        Me.lblEasyNumber.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.lblEasyNumber.Size = New System.Drawing.Size(33, 199)
        Me.lblEasyNumber.TabIndex = 14
        Me.lblEasyNumber.Text = "1." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "6." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "8." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "9." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "10."
        Me.lblEasyNumber.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmStats
        '
        Me.AcceptButton = Me.cmdBack
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.cmdBack
        Me.ClientSize = New System.Drawing.Size(694, 472)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.panBottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmStats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stats"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.panBottom.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.panEasyTitle.ResumeLayout(False)
        Me.panEasy.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents panBottom As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents panEasy As System.Windows.Forms.Panel
    Friend WithEvents lblEasyNumber As System.Windows.Forms.Label
    Friend WithEvents panEasyTitle As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmdReset As System.Windows.Forms.Button
End Class
