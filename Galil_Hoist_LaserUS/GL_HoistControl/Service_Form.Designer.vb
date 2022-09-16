<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Service_Form
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Service_Form))
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtHomeoffset = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHome = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtScale = New System.Windows.Forms.TextBox()
        Me.txtDecel = New System.Windows.Forms.TextBox()
        Me.txtAccel = New System.Windows.Forms.TextBox()
        Me.txtMovespeed = New System.Windows.Forms.TextBox()
        Me.txtJogSpeed = New System.Windows.Forms.TextBox()
        Me.CmdSave2 = New System.Windows.Forms.Button()
        Me.txtKd = New System.Windows.Forms.TextBox()
        Me.txtKp = New System.Windows.Forms.TextBox()
        Me.txtKi = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmdSave3 = New System.Windows.Forms.Button()
        Me.txtHighLimit = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLowLimit = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtRingDist = New System.Windows.Forms.TextBox()
        Me.txtLastRing = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBarLevel = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtShadeSlack = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDropToTable = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FabTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RollUpDistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RollUpDistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GalilHoistDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GalilHoistDataSet = New GL_HoistControl.GalilHoistDataSet()
        Me.RollUpDistTableAdapter = New GL_HoistControl.GalilHoistDataSetTableAdapters.RollUpDistTableAdapter()
        Me.Exit_Btn = New System.Windows.Forms.Button()
        Me.SystemTST_btn = New System.Windows.Forms.Button()
        Me.Exit_Service_btn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RollUpDistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GalilHoistDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GalilHoistDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(77, 221)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(112, 52)
        Me.cmdSave.TabIndex = 14
        Me.cmdSave.Text = "Save Speed Data"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'txtHomeoffset
        '
        Me.txtHomeoffset.Location = New System.Drawing.Point(77, 189)
        Me.txtHomeoffset.Name = "txtHomeoffset"
        Me.txtHomeoffset.Size = New System.Drawing.Size(100, 20)
        Me.txtHomeoffset.TabIndex = 13
        Me.txtHomeoffset.Text = "1000"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Home Offset"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHome
        '
        Me.txtHome.Location = New System.Drawing.Point(77, 162)
        Me.txtHome.Name = "txtHome"
        Me.txtHome.Size = New System.Drawing.Size(100, 20)
        Me.txtHome.TabIndex = 11
        Me.txtHome.Text = "1000"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.txtHomeoffset)
        Me.GroupBox1.Controls.Add(Me.txtHome)
        Me.GroupBox1.Controls.Add(Me.txtScale)
        Me.GroupBox1.Controls.Add(Me.txtDecel)
        Me.GroupBox1.Controls.Add(Me.txtAccel)
        Me.GroupBox1.Controls.Add(Me.txtMovespeed)
        Me.GroupBox1.Controls.Add(Me.txtJogSpeed)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 286)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Speed Settings"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(182, 89)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(73, 13)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "Inches/sec^2"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(182, 113)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(73, 13)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "Inches/sec^2"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(182, 37)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 13)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Pulses/Inch"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(182, 63)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 13)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Pulses/Inch"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(182, 139)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 13)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Pulses/Inch"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(182, 166)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 13)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Inches"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(182, 192)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 13)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Inches"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Home Point"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Scale"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Decel"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Accel"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Move Speed"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jog Speed"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtScale
        '
        Me.txtScale.Location = New System.Drawing.Point(77, 136)
        Me.txtScale.Name = "txtScale"
        Me.txtScale.Size = New System.Drawing.Size(100, 20)
        Me.txtScale.TabIndex = 9
        Me.txtScale.Text = "1000"
        '
        'txtDecel
        '
        Me.txtDecel.Location = New System.Drawing.Point(77, 110)
        Me.txtDecel.Name = "txtDecel"
        Me.txtDecel.Size = New System.Drawing.Size(100, 20)
        Me.txtDecel.TabIndex = 7
        Me.txtDecel.Text = "1000"
        '
        'txtAccel
        '
        Me.txtAccel.Location = New System.Drawing.Point(77, 86)
        Me.txtAccel.Name = "txtAccel"
        Me.txtAccel.Size = New System.Drawing.Size(100, 20)
        Me.txtAccel.TabIndex = 5
        Me.txtAccel.Text = "1000"
        '
        'txtMovespeed
        '
        Me.txtMovespeed.Location = New System.Drawing.Point(77, 60)
        Me.txtMovespeed.Name = "txtMovespeed"
        Me.txtMovespeed.Size = New System.Drawing.Size(100, 20)
        Me.txtMovespeed.TabIndex = 3
        Me.txtMovespeed.Text = "1000"
        '
        'txtJogSpeed
        '
        Me.txtJogSpeed.Location = New System.Drawing.Point(77, 34)
        Me.txtJogSpeed.Name = "txtJogSpeed"
        Me.txtJogSpeed.Size = New System.Drawing.Size(100, 20)
        Me.txtJogSpeed.TabIndex = 1
        Me.txtJogSpeed.Text = "1000"
        '
        'CmdSave2
        '
        Me.CmdSave2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSave2.Location = New System.Drawing.Point(38, 221)
        Me.CmdSave2.Name = "CmdSave2"
        Me.CmdSave2.Size = New System.Drawing.Size(75, 52)
        Me.CmdSave2.TabIndex = 12
        Me.CmdSave2.Text = "Save Gain Data"
        Me.CmdSave2.UseVisualStyleBackColor = True
        '
        'txtKd
        '
        Me.txtKd.Location = New System.Drawing.Point(38, 89)
        Me.txtKd.Name = "txtKd"
        Me.txtKd.Size = New System.Drawing.Size(91, 20)
        Me.txtKd.TabIndex = 11
        Me.txtKd.Text = "1"
        '
        'txtKp
        '
        Me.txtKp.Location = New System.Drawing.Point(38, 37)
        Me.txtKp.Name = "txtKp"
        Me.txtKp.Size = New System.Drawing.Size(91, 20)
        Me.txtKp.TabIndex = 7
        Me.txtKp.Text = "1"
        '
        'txtKi
        '
        Me.txtKi.Location = New System.Drawing.Point(38, 63)
        Me.txtKi.Name = "txtKi"
        Me.txtKi.Size = New System.Drawing.Size(91, 20)
        Me.txtKi.TabIndex = 9
        Me.txtKi.Text = "1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmdSave2)
        Me.GroupBox2.Controls.Add(Me.txtKd)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtKi)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtKp)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(273, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(131, 286)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gain Settings"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "KD"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "KI"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "KP"
        '
        'CmdSave3
        '
        Me.CmdSave3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSave3.Location = New System.Drawing.Point(68, 221)
        Me.CmdSave3.Name = "CmdSave3"
        Me.CmdSave3.Size = New System.Drawing.Size(95, 52)
        Me.CmdSave3.TabIndex = 20
        Me.CmdSave3.Text = "Save Hoist Dimensions"
        Me.CmdSave3.UseVisualStyleBackColor = True
        '
        'txtHighLimit
        '
        Me.txtHighLimit.Location = New System.Drawing.Point(127, 191)
        Me.txtHighLimit.Name = "txtHighLimit"
        Me.txtHighLimit.Size = New System.Drawing.Size(66, 20)
        Me.txtHighLimit.TabIndex = 19
        Me.txtHighLimit.Text = "200"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(42, 191)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Upper Soft Limit"
        '
        'txtLowLimit
        '
        Me.txtLowLimit.Location = New System.Drawing.Point(127, 165)
        Me.txtLowLimit.Name = "txtLowLimit"
        Me.txtLowLimit.Size = New System.Drawing.Size(66, 20)
        Me.txtLowLimit.TabIndex = 17
        Me.txtLowLimit.Text = "10"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.txtRingDist)
        Me.GroupBox3.Controls.Add(Me.txtLastRing)
        Me.GroupBox3.Controls.Add(Me.CmdSave3)
        Me.GroupBox3.Controls.Add(Me.txtHighLimit)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtLowLimit)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtBarLevel)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtShadeSlack)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtDropToTable)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(414, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(203, 286)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hoist Dimensions"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(46, 35)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(74, 13)
        Me.Label24.TabIndex = 24
        Me.Label24.Text = "Ring Distance"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(20, 63)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(100, 13)
        Me.Label23.TabIndex = 23
        Me.Label23.Text = "Last Ring to Bottom"
        '
        'txtRingDist
        '
        Me.txtRingDist.Location = New System.Drawing.Point(126, 33)
        Me.txtRingDist.Name = "txtRingDist"
        Me.txtRingDist.Size = New System.Drawing.Size(66, 20)
        Me.txtRingDist.TabIndex = 22
        '
        'txtLastRing
        '
        Me.txtLastRing.Location = New System.Drawing.Point(126, 61)
        Me.txtLastRing.Name = "txtLastRing"
        Me.txtLastRing.Size = New System.Drawing.Size(66, 20)
        Me.txtLastRing.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(42, 168)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Lower Soft Limit"
        '
        'txtBarLevel
        '
        Me.txtBarLevel.Location = New System.Drawing.Point(126, 140)
        Me.txtBarLevel.Name = "txtBarLevel"
        Me.txtBarLevel.Size = New System.Drawing.Size(66, 20)
        Me.txtBarLevel.TabIndex = 15
        Me.txtBarLevel.Text = "30"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(70, 143)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Eye Level"
        '
        'txtShadeSlack
        '
        Me.txtShadeSlack.Location = New System.Drawing.Point(126, 114)
        Me.txtShadeSlack.Name = "txtShadeSlack"
        Me.txtShadeSlack.Size = New System.Drawing.Size(66, 20)
        Me.txtShadeSlack.TabIndex = 13
        Me.txtShadeSlack.Text = "16"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(56, 117)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Shade Slack"
        '
        'txtDropToTable
        '
        Me.txtDropToTable.Location = New System.Drawing.Point(126, 88)
        Me.txtDropToTable.Name = "txtDropToTable"
        Me.txtDropToTable.Size = New System.Drawing.Size(66, 20)
        Me.txtDropToTable.TabIndex = 11
        Me.txtDropToTable.Text = "24"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 90)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 13)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Dist Drop Cord to Table"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FabTypeDataGridViewTextBoxColumn, Me.RollUpDistDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RollUpDistBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(148, 316)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Size = New System.Drawing.Size(294, 173)
        Me.DataGridView1.TabIndex = 16
        '
        'FabTypeDataGridViewTextBoxColumn
        '
        Me.FabTypeDataGridViewTextBoxColumn.DataPropertyName = "FabType"
        Me.FabTypeDataGridViewTextBoxColumn.HeaderText = "FabType"
        Me.FabTypeDataGridViewTextBoxColumn.Name = "FabTypeDataGridViewTextBoxColumn"
        Me.FabTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.FabTypeDataGridViewTextBoxColumn.Width = 116
        '
        'RollUpDistDataGridViewTextBoxColumn
        '
        Me.RollUpDistDataGridViewTextBoxColumn.DataPropertyName = "RollUpDist"
        Me.RollUpDistDataGridViewTextBoxColumn.HeaderText = "RollUpDist"
        Me.RollUpDistDataGridViewTextBoxColumn.Name = "RollUpDistDataGridViewTextBoxColumn"
        Me.RollUpDistDataGridViewTextBoxColumn.ReadOnly = True
        Me.RollUpDistDataGridViewTextBoxColumn.Width = 132
        '
        'RollUpDistBindingSource
        '
        Me.RollUpDistBindingSource.DataMember = "RollUpDist"
        Me.RollUpDistBindingSource.DataSource = Me.GalilHoistDataSetBindingSource
        '
        'GalilHoistDataSetBindingSource
        '
        Me.GalilHoistDataSetBindingSource.DataSource = Me.GalilHoistDataSet
        Me.GalilHoistDataSetBindingSource.Position = 0
        '
        'GalilHoistDataSet
        '
        Me.GalilHoistDataSet.DataSetName = "GalilHoistDataSet"
        Me.GalilHoistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RollUpDistTableAdapter
        '
        Me.RollUpDistTableAdapter.ClearBeforeFill = True
        '
        'Exit_Btn
        '
        Me.Exit_Btn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Btn.Location = New System.Drawing.Point(511, 437)
        Me.Exit_Btn.Name = "Exit_Btn"
        Me.Exit_Btn.Size = New System.Drawing.Size(95, 52)
        Me.Exit_Btn.TabIndex = 25
        Me.Exit_Btn.Text = "Main screen"
        Me.Exit_Btn.UseVisualStyleBackColor = True
        '
        'SystemTST_btn
        '
        Me.SystemTST_btn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemTST_btn.Location = New System.Drawing.Point(15, 437)
        Me.SystemTST_btn.Name = "SystemTST_btn"
        Me.SystemTST_btn.Size = New System.Drawing.Size(95, 52)
        Me.SystemTST_btn.TabIndex = 26
        Me.SystemTST_btn.Text = "System test"
        Me.SystemTST_btn.UseVisualStyleBackColor = True
        '
        'Exit_Service_btn
        '
        Me.Exit_Service_btn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Service_btn.Location = New System.Drawing.Point(511, 500)
        Me.Exit_Service_btn.Name = "Exit_Service_btn"
        Me.Exit_Service_btn.Size = New System.Drawing.Size(95, 52)
        Me.Exit_Service_btn.TabIndex = 27
        Me.Exit_Service_btn.Text = "Exit"
        Me.Exit_Service_btn.UseVisualStyleBackColor = True
        '
        'Service_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 564)
        Me.Controls.Add(Me.Exit_Service_btn)
        Me.Controls.Add(Me.SystemTST_btn)
        Me.Controls.Add(Me.Exit_Btn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Service_Form"
        Me.Text = "Service_Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RollUpDistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GalilHoistDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GalilHoistDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtHomeoffset As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtHome As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtScale As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDecel As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAccel As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMovespeed As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtJogSpeed As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmdSave2 As System.Windows.Forms.Button
    Friend WithEvents txtKd As System.Windows.Forms.TextBox
    Friend WithEvents txtKp As System.Windows.Forms.TextBox
    Friend WithEvents txtKi As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CmdSave3 As System.Windows.Forms.Button
    Friend WithEvents txtHighLimit As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtLowLimit As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBarLevel As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtShadeSlack As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtDropToTable As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtRingDist As System.Windows.Forms.TextBox
    Friend WithEvents txtLastRing As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GalilHoistDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GalilHoistDataSet As GL_HoistControl.GalilHoistDataSet
    Friend WithEvents RollUpDistBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RollUpDistTableAdapter As GL_HoistControl.GalilHoistDataSetTableAdapters.RollUpDistTableAdapter
    Friend WithEvents FabTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RollUpDistDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Exit_Btn As System.Windows.Forms.Button
    Friend WithEvents SystemTST_btn As System.Windows.Forms.Button
    Friend WithEvents Exit_Service_btn As System.Windows.Forms.Button
End Class
