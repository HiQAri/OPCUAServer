<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Tmr_reset_Servo = New System.Windows.Forms.Timer(Me.components)
        Me.RollUpDistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GalilHoistDataSet1 = New GL_HoistControl.GalilHoistDataSet()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HoistOrders1DataSet = New GL_HoistControl.HoistOrders1DataSet()
        Me.TimerCyclicWork = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCheckPopup = New System.Windows.Forms.Timer(Me.components)
        Me.RollUpDistTableAdapter = New GL_HoistControl.GalilHoistDataSetTableAdapters.RollUpDistTableAdapter()
        Me.instructionLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DMCPoll1 = New System.Windows.Forms.TextBox()
        Me.frmAttributes = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxOrderNr = New System.Windows.Forms.TextBox()
        Me.LinerCombo = New System.Windows.Forms.ComboBox()
        Me.cmbHem = New System.Windows.Forms.ComboBox()
        Me.ComboBoxModel = New System.Windows.Forms.ComboBox()
        Me.txtRollup = New System.Windows.Forms.TextBox()
        Me.txtCLO = New System.Windows.Forms.TextBox()
        Me.txtDrop = New System.Windows.Forms.TextBox()
        Me.dcFabType = New System.Windows.Forms.ComboBox()
        Me.LabelCordLength = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtWidth = New System.Windows.Forms.TextBox()
        Me.LabelModel = New System.Windows.Forms.Label()
        Me.LabelFabtype = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelLiner = New System.Windows.Forms.Label()
        Me.LabelBottom = New System.Windows.Forms.Label()
        Me.LabelWidth = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.EstopLabel = New System.Windows.Forms.Label()
        Me.CmdResetServo = New System.Windows.Forms.Button()
        Me.cmdServo_on = New System.Windows.Forms.Button()
        Me.cmdQuit = New System.Windows.Forms.Button()
        Me.cmdServo_off = New System.Windows.Forms.Button()
        Me.homeind = New System.Windows.Forms.Label()
        Me.btnHomeServo = New System.Windows.Forms.Button()
        Me.service_btn = New System.Windows.Forms.Button()
        Me.lblEstcomm = New System.Windows.Forms.Label()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.cmdGoBack = New System.Windows.Forms.Button()
        Me.cmdResetSeq = New System.Windows.Forms.Button()
        Me.initializeCommand = New System.Windows.Forms.Button()
        Me.switch_StatusX = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdYMinus = New System.Windows.Forms.Button()
        Me.cmdYPlus = New System.Windows.Forms.Button()
        Me.btnCLMPoff = New System.Windows.Forms.Button()
        Me.ButtonInspection = New System.Windows.Forms.Button()
        Me.btnCLMPon = New System.Windows.Forms.Button()
        Me.cmdGo = New System.Windows.Forms.Button()
        Me.eighthUp = New System.Windows.Forms.Button()
        Me.eighthDn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.System_Label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.DataGridViewOrders = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderNrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DropDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WidthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonUseDatSelected = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.DataGridViewRollUpDist = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OrdersTableAdapter1 = New GL_HoistControl.HoistOrders1DataSetTableAdapters.OrdersTableAdapter()
        Me.NextButton = New GL_HoistControl.NextButtonColor()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OrdersResultTableAdapter1 = New GL_HoistControl.HoistOrdersResultDataSetTableAdapters.OrdersResultTableAdapter()
        Me.HoistOrdersResultDataSet1 = New GL_HoistControl.HoistOrdersResultDataSet()
        CType(Me.RollUpDistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GalilHoistDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoistOrders1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.frmAttributes.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DataGridViewRollUpDist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoistOrdersResultDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tmr_reset_Servo
        '
        Me.Tmr_reset_Servo.Interval = 1000
        Me.Tmr_reset_Servo.Tag = "ResetServoTimer"
        '
        'RollUpDistBindingSource
        '
        Me.RollUpDistBindingSource.DataMember = "RollUpDist"
        Me.RollUpDistBindingSource.DataSource = Me.GalilHoistDataSet1
        '
        'GalilHoistDataSet1
        '
        Me.GalilHoistDataSet1.DataSetName = "GalilHoistDataSet"
        Me.GalilHoistDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.HoistOrders1DataSet
        '
        'HoistOrders1DataSet
        '
        Me.HoistOrders1DataSet.DataSetName = "HoistOrders1DataSet"
        Me.HoistOrders1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TimerCyclicWork
        '
        '
        'TimerCheckPopup
        '
        Me.TimerCheckPopup.Enabled = True
        '
        'RollUpDistTableAdapter
        '
        Me.RollUpDistTableAdapter.ClearBeforeFill = True
        '
        'instructionLabel
        '
        Me.instructionLabel.BackColor = System.Drawing.SystemColors.Window
        Me.instructionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.instructionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.instructionLabel.Font = New System.Drawing.Font("Arial Narrow", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.instructionLabel.ForeColor = System.Drawing.Color.DarkRed
        Me.instructionLabel.Location = New System.Drawing.Point(618, 633)
        Me.instructionLabel.Name = "instructionLabel"
        Me.instructionLabel.Size = New System.Drawing.Size(646, 137)
        Me.instructionLabel.TabIndex = 18
        Me.instructionLabel.Text = "ENTER SHADE INFO, THEN HIT START"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DMCPoll1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(14, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 68)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Current Position"
        '
        'DMCPoll1
        '
        Me.DMCPoll1.BackColor = System.Drawing.SystemColors.Window
        Me.DMCPoll1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DMCPoll1.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DMCPoll1.Location = New System.Drawing.Point(5, 16)
        Me.DMCPoll1.Name = "DMCPoll1"
        Me.DMCPoll1.ReadOnly = True
        Me.DMCPoll1.Size = New System.Drawing.Size(301, 44)
        Me.DMCPoll1.TabIndex = 0
        '
        'frmAttributes
        '
        Me.frmAttributes.Controls.Add(Me.Label3)
        Me.frmAttributes.Controls.Add(Me.TextBoxOrderNr)
        Me.frmAttributes.Controls.Add(Me.LinerCombo)
        Me.frmAttributes.Controls.Add(Me.cmbHem)
        Me.frmAttributes.Controls.Add(Me.ComboBoxModel)
        Me.frmAttributes.Controls.Add(Me.txtRollup)
        Me.frmAttributes.Controls.Add(Me.txtCLO)
        Me.frmAttributes.Controls.Add(Me.txtDrop)
        Me.frmAttributes.Controls.Add(Me.dcFabType)
        Me.frmAttributes.Controls.Add(Me.LabelCordLength)
        Me.frmAttributes.Controls.Add(Me.Label4)
        Me.frmAttributes.Controls.Add(Me.Label8)
        Me.frmAttributes.Controls.Add(Me.Label7)
        Me.frmAttributes.Controls.Add(Me.TxtWidth)
        Me.frmAttributes.Controls.Add(Me.LabelModel)
        Me.frmAttributes.Controls.Add(Me.LabelFabtype)
        Me.frmAttributes.Controls.Add(Me.Label6)
        Me.frmAttributes.Controls.Add(Me.LabelLiner)
        Me.frmAttributes.Controls.Add(Me.LabelBottom)
        Me.frmAttributes.Controls.Add(Me.LabelWidth)
        Me.frmAttributes.Location = New System.Drawing.Point(618, 353)
        Me.frmAttributes.Name = "frmAttributes"
        Me.frmAttributes.Size = New System.Drawing.Size(646, 270)
        Me.frmAttributes.TabIndex = 14
        Me.frmAttributes.TabStop = False
        Me.frmAttributes.Text = "Attributes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(313, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 31)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "OrderNr"
        '
        'TextBoxOrderNr
        '
        Me.TextBoxOrderNr.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxOrderNr.Location = New System.Drawing.Point(440, 16)
        Me.TextBoxOrderNr.Name = "TextBoxOrderNr"
        Me.TextBoxOrderNr.Size = New System.Drawing.Size(177, 44)
        Me.TextBoxOrderNr.TabIndex = 32
        '
        'LinerCombo
        '
        Me.LinerCombo.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinerCombo.FormattingEnabled = True
        Me.LinerCombo.Items.AddRange(New Object() {"Liner", "No Liner"})
        Me.LinerCombo.Location = New System.Drawing.Point(185, 184)
        Me.LinerCombo.Name = "LinerCombo"
        Me.LinerCombo.Size = New System.Drawing.Size(177, 31)
        Me.LinerCombo.TabIndex = 28
        '
        'cmbHem
        '
        Me.cmbHem.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHem.FormattingEnabled = True
        Me.cmbHem.Items.AddRange(New Object() {"Hemmed", "Bottom Rail"})
        Me.cmbHem.Location = New System.Drawing.Point(185, 227)
        Me.cmbHem.Name = "cmbHem"
        Me.cmbHem.Size = New System.Drawing.Size(177, 31)
        Me.cmbHem.TabIndex = 29
        '
        'ComboBoxModel
        '
        Me.ComboBoxModel.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxModel.FormattingEnabled = True
        Me.ComboBoxModel.Items.AddRange(New Object() {""})
        Me.ComboBoxModel.Location = New System.Drawing.Point(185, 224)
        Me.ComboBoxModel.Name = "ComboBoxModel"
        Me.ComboBoxModel.Size = New System.Drawing.Size(455, 39)
        Me.ComboBoxModel.TabIndex = 23
        Me.ComboBoxModel.Visible = False
        '
        'txtRollup
        '
        Me.txtRollup.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRollup.Location = New System.Drawing.Point(380, 147)
        Me.txtRollup.Name = "txtRollup"
        Me.txtRollup.Size = New System.Drawing.Size(64, 29)
        Me.txtRollup.TabIndex = 27
        '
        'txtCLO
        '
        Me.txtCLO.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCLO.Location = New System.Drawing.Point(185, 78)
        Me.txtCLO.Name = "txtCLO"
        Me.txtCLO.Size = New System.Drawing.Size(177, 44)
        Me.txtCLO.TabIndex = 2
        '
        'txtDrop
        '
        Me.txtDrop.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrop.Location = New System.Drawing.Point(97, 16)
        Me.txtDrop.Name = "txtDrop"
        Me.txtDrop.Size = New System.Drawing.Size(177, 44)
        Me.txtDrop.TabIndex = 0
        '
        'dcFabType
        '
        Me.dcFabType.DataSource = Me.RollUpDistBindingSource
        Me.dcFabType.DisplayMember = "FabType"
        Me.dcFabType.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dcFabType.FormattingEnabled = True
        Me.dcFabType.Location = New System.Drawing.Point(185, 147)
        Me.dcFabType.Name = "dcFabType"
        Me.dcFabType.Size = New System.Drawing.Size(177, 31)
        Me.dcFabType.TabIndex = 25
        '
        'LabelCordLength
        '
        Me.LabelCordLength.AutoSize = True
        Me.LabelCordLength.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCordLength.Location = New System.Drawing.Point(6, 91)
        Me.LabelCordLength.Name = "LabelCordLength"
        Me.LabelCordLength.Size = New System.Drawing.Size(148, 31)
        Me.LabelCordLength.TabIndex = 3
        Me.LabelCordLength.Text = "Cord Length"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 31)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Drop"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(66, 470)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 23)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Bottom"
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(84, 425)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 23)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Liner"
        Me.Label7.Visible = False
        '
        'TxtWidth
        '
        Me.TxtWidth.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWidth.Location = New System.Drawing.Point(185, 140)
        Me.TxtWidth.Name = "TxtWidth"
        Me.TxtWidth.Size = New System.Drawing.Size(177, 44)
        Me.TxtWidth.TabIndex = 21
        '
        'LabelModel
        '
        Me.LabelModel.AutoSize = True
        Me.LabelModel.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelModel.Location = New System.Drawing.Point(8, 227)
        Me.LabelModel.Name = "LabelModel"
        Me.LabelModel.Size = New System.Drawing.Size(78, 31)
        Me.LabelModel.TabIndex = 24
        Me.LabelModel.Text = "Model"
        '
        'LabelFabtype
        '
        Me.LabelFabtype.AutoSize = True
        Me.LabelFabtype.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFabtype.Location = New System.Drawing.Point(10, 153)
        Me.LabelFabtype.Name = "LabelFabtype"
        Me.LabelFabtype.Size = New System.Drawing.Size(81, 23)
        Me.LabelFabtype.TabIndex = 26
        Me.LabelFabtype.Text = "Fab Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fab Type"
        Me.Label6.Visible = False
        '
        'LabelLiner
        '
        Me.LabelLiner.AutoSize = True
        Me.LabelLiner.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLiner.Location = New System.Drawing.Point(12, 187)
        Me.LabelLiner.Name = "LabelLiner"
        Me.LabelLiner.Size = New System.Drawing.Size(49, 23)
        Me.LabelLiner.TabIndex = 30
        Me.LabelLiner.Text = "Liner"
        '
        'LabelBottom
        '
        Me.LabelBottom.AutoSize = True
        Me.LabelBottom.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBottom.Location = New System.Drawing.Point(10, 230)
        Me.LabelBottom.Name = "LabelBottom"
        Me.LabelBottom.Size = New System.Drawing.Size(65, 23)
        Me.LabelBottom.TabIndex = 31
        Me.LabelBottom.Text = "Bottom"
        '
        'LabelWidth
        '
        Me.LabelWidth.AutoSize = True
        Me.LabelWidth.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWidth.Location = New System.Drawing.Point(8, 149)
        Me.LabelWidth.Name = "LabelWidth"
        Me.LabelWidth.Size = New System.Drawing.Size(76, 31)
        Me.LabelWidth.TabIndex = 22
        Me.LabelWidth.Text = "Width"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.EstopLabel)
        Me.GroupBox4.Controls.Add(Me.CmdResetServo)
        Me.GroupBox4.Controls.Add(Me.cmdServo_on)
        Me.GroupBox4.Controls.Add(Me.cmdQuit)
        Me.GroupBox4.Controls.Add(Me.cmdServo_off)
        Me.GroupBox4.Controls.Add(Me.homeind)
        Me.GroupBox4.Controls.Add(Me.btnHomeServo)
        Me.GroupBox4.Controls.Add(Me.service_btn)
        Me.GroupBox4.Controls.Add(Me.lblEstcomm)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(5, 203)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(600, 309)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Motor Control"
        '
        'EstopLabel
        '
        Me.EstopLabel.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.EstopLabel.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstopLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EstopLabel.Location = New System.Drawing.Point(7, 150)
        Me.EstopLabel.Name = "EstopLabel"
        Me.EstopLabel.Size = New System.Drawing.Size(221, 25)
        Me.EstopLabel.TabIndex = 17
        Me.EstopLabel.Text = "E-Stop Reset Status"
        Me.EstopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmdResetServo
        '
        Me.CmdResetServo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CmdResetServo.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdResetServo.Location = New System.Drawing.Point(8, 234)
        Me.CmdResetServo.Name = "CmdResetServo"
        Me.CmdResetServo.Size = New System.Drawing.Size(220, 54)
        Me.CmdResetServo.TabIndex = 13
        Me.CmdResetServo.Text = "RESET SERVO DRIVE"
        Me.CmdResetServo.UseVisualStyleBackColor = False
        Me.CmdResetServo.Visible = False
        '
        'cmdServo_on
        '
        Me.cmdServo_on.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdServo_on.Location = New System.Drawing.Point(3, 23)
        Me.cmdServo_on.Name = "cmdServo_on"
        Me.cmdServo_on.Size = New System.Drawing.Size(94, 54)
        Me.cmdServo_on.TabIndex = 1
        Me.cmdServo_on.Text = "SERVO ON"
        Me.cmdServo_on.UseVisualStyleBackColor = True
        '
        'cmdQuit
        '
        Me.cmdQuit.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuit.Location = New System.Drawing.Point(369, 234)
        Me.cmdQuit.Name = "cmdQuit"
        Me.cmdQuit.Size = New System.Drawing.Size(225, 54)
        Me.cmdQuit.TabIndex = 16
        Me.cmdQuit.Text = "Quit and turn off"
        Me.cmdQuit.UseVisualStyleBackColor = True
        '
        'cmdServo_off
        '
        Me.cmdServo_off.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdServo_off.Location = New System.Drawing.Point(119, 23)
        Me.cmdServo_off.Name = "cmdServo_off"
        Me.cmdServo_off.Size = New System.Drawing.Size(102, 54)
        Me.cmdServo_off.TabIndex = 2
        Me.cmdServo_off.Text = "SERVO OFF"
        Me.cmdServo_off.UseVisualStyleBackColor = True
        '
        'homeind
        '
        Me.homeind.BackColor = System.Drawing.Color.Red
        Me.homeind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.homeind.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeind.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.homeind.Location = New System.Drawing.Point(8, 104)
        Me.homeind.Name = "homeind"
        Me.homeind.Size = New System.Drawing.Size(220, 25)
        Me.homeind.TabIndex = 12
        Me.homeind.Text = "HOME STATUS"
        Me.homeind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHomeServo
        '
        Me.btnHomeServo.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomeServo.Location = New System.Drawing.Point(369, 23)
        Me.btnHomeServo.Name = "btnHomeServo"
        Me.btnHomeServo.Size = New System.Drawing.Size(225, 54)
        Me.btnHomeServo.TabIndex = 8
        Me.btnHomeServo.Text = "Home Servo"
        Me.btnHomeServo.UseVisualStyleBackColor = True
        '
        'service_btn
        '
        Me.service_btn.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.service_btn.Location = New System.Drawing.Point(369, 121)
        Me.service_btn.Name = "service_btn"
        Me.service_btn.Size = New System.Drawing.Size(225, 54)
        Me.service_btn.TabIndex = 11
        Me.service_btn.Text = "Service"
        Me.service_btn.UseVisualStyleBackColor = True
        '
        'lblEstcomm
        '
        Me.lblEstcomm.BackColor = System.Drawing.Color.Yellow
        Me.lblEstcomm.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstcomm.ForeColor = System.Drawing.Color.Blue
        Me.lblEstcomm.Location = New System.Drawing.Point(8, 192)
        Me.lblEstcomm.Name = "lblEstcomm"
        Me.lblEstcomm.Size = New System.Drawing.Size(220, 25)
        Me.lblEstcomm.TabIndex = 18
        Me.lblEstcomm.Text = "CONNECTING TO SERVO"
        Me.lblEstcomm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdStop
        '
        Me.cmdStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdStop.BackColor = System.Drawing.Color.DarkRed
        Me.cmdStop.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStop.ForeColor = System.Drawing.Color.White
        Me.cmdStop.Location = New System.Drawing.Point(345, 83)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(260, 55)
        Me.cmdStop.TabIndex = 9
        Me.cmdStop.Text = "STOP MOTION"
        Me.cmdStop.UseVisualStyleBackColor = False
        '
        'cmdGoBack
        '
        Me.cmdGoBack.BackColor = System.Drawing.Color.Gold
        Me.cmdGoBack.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGoBack.Location = New System.Drawing.Point(618, 780)
        Me.cmdGoBack.Name = "cmdGoBack"
        Me.cmdGoBack.Size = New System.Drawing.Size(140, 83)
        Me.cmdGoBack.TabIndex = 21
        Me.cmdGoBack.Text = "< Go Back"
        Me.cmdGoBack.UseVisualStyleBackColor = False
        '
        'cmdResetSeq
        '
        Me.cmdResetSeq.BackColor = System.Drawing.Color.Gold
        Me.cmdResetSeq.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResetSeq.Location = New System.Drawing.Point(618, 876)
        Me.cmdResetSeq.Name = "cmdResetSeq"
        Me.cmdResetSeq.Size = New System.Drawing.Size(140, 83)
        Me.cmdResetSeq.TabIndex = 22
        Me.cmdResetSeq.Text = "Reset Sequence"
        Me.cmdResetSeq.UseVisualStyleBackColor = False
        '
        'initializeCommand
        '
        Me.initializeCommand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.initializeCommand.BackColor = System.Drawing.Color.DarkRed
        Me.initializeCommand.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.initializeCommand.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.initializeCommand.ForeColor = System.Drawing.Color.White
        Me.initializeCommand.Location = New System.Drawing.Point(6, 707)
        Me.initializeCommand.Name = "initializeCommand"
        Me.initializeCommand.Size = New System.Drawing.Size(220, 35)
        Me.initializeCommand.TabIndex = 23
        Me.initializeCommand.Text = "Initialize"
        Me.initializeCommand.UseVisualStyleBackColor = False
        '
        'switch_StatusX
        '
        Me.switch_StatusX.AutoSize = True
        Me.switch_StatusX.BackColor = System.Drawing.SystemColors.ControlDark
        Me.switch_StatusX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.switch_StatusX.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.switch_StatusX.Location = New System.Drawing.Point(1243, 959)
        Me.switch_StatusX.Name = "switch_StatusX"
        Me.switch_StatusX.Size = New System.Drawing.Size(21, 15)
        Me.switch_StatusX.TabIndex = 10
        Me.switch_StatusX.Text = "00"
        Me.switch_StatusX.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(14, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(86, 53)
        Me.TextBox1.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 969)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdYMinus)
        Me.GroupBox1.Controls.Add(Me.cmdYPlus)
        Me.GroupBox1.Controls.Add(Me.btnCLMPoff)
        Me.GroupBox1.Controls.Add(Me.ButtonInspection)
        Me.GroupBox1.Controls.Add(Me.btnCLMPon)
        Me.GroupBox1.Controls.Add(Me.cmdGo)
        Me.GroupBox1.Controls.Add(Me.eighthUp)
        Me.GroupBox1.Controls.Add(Me.eighthDn)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 763)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 204)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'cmdYMinus
        '
        Me.cmdYMinus.BackColor = System.Drawing.Color.DarkKhaki
        Me.cmdYMinus.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdYMinus.Location = New System.Drawing.Point(4, 117)
        Me.cmdYMinus.Name = "cmdYMinus"
        Me.cmdYMinus.Size = New System.Drawing.Size(110, 83)
        Me.cmdYMinus.TabIndex = 1
        Me.cmdYMinus.Text = "Y-"
        Me.cmdYMinus.UseVisualStyleBackColor = False
        '
        'cmdYPlus
        '
        Me.cmdYPlus.BackColor = System.Drawing.Color.DarkKhaki
        Me.cmdYPlus.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdYPlus.Location = New System.Drawing.Point(5, 17)
        Me.cmdYPlus.Name = "cmdYPlus"
        Me.cmdYPlus.Size = New System.Drawing.Size(109, 83)
        Me.cmdYPlus.TabIndex = 0
        Me.cmdYPlus.Text = "Y+"
        Me.cmdYPlus.UseVisualStyleBackColor = False
        '
        'btnCLMPoff
        '
        Me.btnCLMPoff.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCLMPoff.Location = New System.Drawing.Point(270, 117)
        Me.btnCLMPoff.Name = "btnCLMPoff"
        Me.btnCLMPoff.Size = New System.Drawing.Size(140, 83)
        Me.btnCLMPoff.TabIndex = 22
        Me.btnCLMPoff.Text = "Clamp OFF"
        Me.btnCLMPoff.UseVisualStyleBackColor = True
        '
        'ButtonInspection
        '
        Me.ButtonInspection.AutoSize = True
        Me.ButtonInspection.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInspection.Location = New System.Drawing.Point(457, 114)
        Me.ButtonInspection.Name = "ButtonInspection"
        Me.ButtonInspection.Size = New System.Drawing.Size(114, 83)
        Me.ButtonInspection.TabIndex = 34
        Me.ButtonInspection.Text = "Inspection"
        Me.ButtonInspection.UseVisualStyleBackColor = True
        '
        'btnCLMPon
        '
        Me.btnCLMPon.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCLMPon.Location = New System.Drawing.Point(125, 117)
        Me.btnCLMPon.Name = "btnCLMPon"
        Me.btnCLMPon.Size = New System.Drawing.Size(140, 83)
        Me.btnCLMPon.TabIndex = 21
        Me.btnCLMPon.Text = "Clamp ON"
        Me.btnCLMPon.UseVisualStyleBackColor = True
        '
        'cmdGo
        '
        Me.cmdGo.BackColor = System.Drawing.Color.DarkKhaki
        Me.cmdGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGo.Location = New System.Drawing.Point(457, 19)
        Me.cmdGo.Name = "cmdGo"
        Me.cmdGo.Size = New System.Drawing.Size(115, 83)
        Me.cmdGo.TabIndex = 2
        Me.cmdGo.Text = "Go!"
        Me.cmdGo.UseVisualStyleBackColor = False
        Me.cmdGo.Visible = False
        '
        'eighthUp
        '
        Me.eighthUp.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eighthUp.Location = New System.Drawing.Point(270, 17)
        Me.eighthUp.Name = "eighthUp"
        Me.eighthUp.Size = New System.Drawing.Size(140, 83)
        Me.eighthUp.TabIndex = 2
        Me.eighthUp.Text = "1/8"" UP"
        Me.eighthUp.UseVisualStyleBackColor = True
        Me.eighthUp.Visible = False
        '
        'eighthDn
        '
        Me.eighthDn.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eighthDn.Location = New System.Drawing.Point(125, 17)
        Me.eighthDn.Name = "eighthDn"
        Me.eighthDn.Size = New System.Drawing.Size(140, 83)
        Me.eighthDn.TabIndex = 1
        Me.eighthDn.Text = "1/8"" DWN"
        Me.eighthDn.UseVisualStyleBackColor = True
        Me.eighthDn.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.GL_HoistControl.My.Resources.Resources.HDNEW
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(162, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(443, 50)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'System_Label
        '
        Me.System_Label.AutoSize = True
        Me.System_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.System_Label.Location = New System.Drawing.Point(6, 577)
        Me.System_Label.Name = "System_Label"
        Me.System_Label.Size = New System.Drawing.Size(475, 55)
        Me.System_Label.TabIndex = 26
        Me.System_Label.Text = "System going down!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(213, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 32)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "HunterDouglas"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(618, 296)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 36
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'DataGridViewOrders
        '
        Me.DataGridViewOrders.AutoGenerateColumns = False
        Me.DataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.OrderNrDataGridViewTextBoxColumn, Me.DropDataGridViewTextBoxColumn, Me.WidthDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridViewOrders.DataSource = Me.OrdersBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewOrders.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewOrders.Location = New System.Drawing.Point(618, 14)
        Me.DataGridViewOrders.MultiSelect = False
        Me.DataGridViewOrders.Name = "DataGridViewOrders"
        Me.DataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewOrders.Size = New System.Drawing.Size(646, 266)
        Me.DataGridViewOrders.TabIndex = 37
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'OrderNrDataGridViewTextBoxColumn
        '
        Me.OrderNrDataGridViewTextBoxColumn.DataPropertyName = "OrderNr"
        Me.OrderNrDataGridViewTextBoxColumn.HeaderText = "OrderNr"
        Me.OrderNrDataGridViewTextBoxColumn.Name = "OrderNrDataGridViewTextBoxColumn"
        '
        'DropDataGridViewTextBoxColumn
        '
        Me.DropDataGridViewTextBoxColumn.DataPropertyName = "Drop"
        Me.DropDataGridViewTextBoxColumn.HeaderText = "Drop"
        Me.DropDataGridViewTextBoxColumn.Name = "DropDataGridViewTextBoxColumn"
        '
        'WidthDataGridViewTextBoxColumn
        '
        Me.WidthDataGridViewTextBoxColumn.DataPropertyName = "Width"
        Me.WidthDataGridViewTextBoxColumn.HeaderText = "Width"
        Me.WidthDataGridViewTextBoxColumn.Name = "WidthDataGridViewTextBoxColumn"
        '
        'ModelDataGridViewTextBoxColumn
        '
        Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "Model"
        Me.ModelDataGridViewTextBoxColumn.HeaderText = "Model"
        Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'ButtonUseDatSelected
        '
        Me.ButtonUseDatSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUseDatSelected.Location = New System.Drawing.Point(760, 296)
        Me.ButtonUseDatSelected.Name = "ButtonUseDatSelected"
        Me.ButtonUseDatSelected.Size = New System.Drawing.Size(385, 52)
        Me.ButtonUseDatSelected.TabIndex = 38
        Me.ButtonUseDatSelected.Text = "Use Data from selected Row"
        Me.ButtonUseDatSelected.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1158, 814)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 40
        Me.TextBox2.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtPosition)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox6.Location = New System.Drawing.Point(14, 137)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(316, 68)
        Me.GroupBox6.TabIndex = 41
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Target Position"
        '
        'txtPosition
        '
        Me.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPosition.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold)
        Me.txtPosition.Location = New System.Drawing.Point(6, 17)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(301, 44)
        Me.txtPosition.TabIndex = 1
        '
        'DataGridViewRollUpDist
        '
        Me.DataGridViewRollUpDist.AutoGenerateColumns = False
        Me.DataGridViewRollUpDist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRollUpDist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DataGridViewRollUpDist.DataSource = Me.RollUpDistBindingSource
        Me.DataGridViewRollUpDist.Location = New System.Drawing.Point(345, 145)
        Me.DataGridViewRollUpDist.Name = "DataGridViewRollUpDist"
        Me.DataGridViewRollUpDist.Size = New System.Drawing.Size(254, 58)
        Me.DataGridViewRollUpDist.TabIndex = 42
        Me.DataGridViewRollUpDist.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FabType"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FabType"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "RollUpDist"
        Me.DataGridViewTextBoxColumn4.HeaderText = "RollUpDist"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1076, 814)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 23)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Step"
        Me.Label9.Visible = False
        '
        'OrdersTableAdapter1
        '
        Me.OrdersTableAdapter1.ClearBeforeFill = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(764, 873)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(484, 94)
        Me.NextButton.TabIndex = 39
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(679, 325)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "test"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OrdersResultTableAdapter1
        '
        Me.OrdersResultTableAdapter1.ClearBeforeFill = True
        '
        'HoistOrdersResultDataSet1
        '
        Me.HoistOrdersResultDataSet1.DataSetName = "HoistOrdersResultDataSet"
        Me.HoistOrdersResultDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1270, 991)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridViewRollUpDist)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.ButtonUseDatSelected)
        Me.Controls.Add(Me.DataGridViewOrders)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.System_Label)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.switch_StatusX)
        Me.Controls.Add(Me.initializeCommand)
        Me.Controls.Add(Me.cmdResetSeq)
        Me.Controls.Add(Me.cmdGoBack)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.instructionLabel)
        Me.Controls.Add(Me.frmAttributes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(-1, 12)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GL Hoist Control"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RollUpDistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GalilHoistDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoistOrders1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.frmAttributes.ResumeLayout(False)
        Me.frmAttributes.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DataGridViewRollUpDist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoistOrdersResultDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tmr_reset_Servo As System.Windows.Forms.Timer
    Friend WithEvents GalilHoistDataSetBindingSource As System.Windows.Forms.BindingSource


    Friend WithEvents FabTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RollUpDistDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimerCyclicWork As System.Windows.Forms.Timer
    Friend WithEvents TimerCheckPopup As System.Windows.Forms.Timer

    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoistOrders1DataSet As GL_HoistControl.HoistOrders1DataSet
    Friend WithEvents OrdersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RollUpDistBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GalilHoistDataSet1 As GL_HoistControl.GalilHoistDataSet
    Friend WithEvents RollUpDistTableAdapter As GL_HoistControl.GalilHoistDataSetTableAdapters.RollUpDistTableAdapter
    Friend WithEvents instructionLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DMCPoll1 As System.Windows.Forms.TextBox
    Friend WithEvents frmAttributes As System.Windows.Forms.GroupBox
    Friend WithEvents LinerCombo As System.Windows.Forms.ComboBox
    Friend WithEvents LabelModel As System.Windows.Forms.Label
    Friend WithEvents cmbHem As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxModel As System.Windows.Forms.ComboBox
    Friend WithEvents LabelLiner As System.Windows.Forms.Label
    Friend WithEvents LabelWidth As System.Windows.Forms.Label
    Friend WithEvents LabelBottom As System.Windows.Forms.Label
    Friend WithEvents txtRollup As System.Windows.Forms.TextBox
    Friend WithEvents txtCLO As System.Windows.Forms.TextBox
    Friend WithEvents LabelFabtype As System.Windows.Forms.Label
    Friend WithEvents txtDrop As System.Windows.Forms.TextBox
    Friend WithEvents dcFabType As System.Windows.Forms.ComboBox
    Friend WithEvents LabelCordLength As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtWidth As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents EstopLabel As System.Windows.Forms.Label
    Friend WithEvents CmdResetServo As System.Windows.Forms.Button
    Friend WithEvents cmdServo_on As System.Windows.Forms.Button
    Friend WithEvents cmdQuit As System.Windows.Forms.Button
    Friend WithEvents cmdServo_off As System.Windows.Forms.Button
    Friend WithEvents homeind As System.Windows.Forms.Label
    Friend WithEvents btnHomeServo As System.Windows.Forms.Button
    Friend WithEvents service_btn As System.Windows.Forms.Button
    Friend WithEvents lblEstcomm As System.Windows.Forms.Label
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents cmdGoBack As System.Windows.Forms.Button
    Friend WithEvents cmdResetSeq As System.Windows.Forms.Button
    Friend WithEvents initializeCommand As System.Windows.Forms.Button
    Friend WithEvents switch_StatusX As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCLMPoff As System.Windows.Forms.Button
    Friend WithEvents ButtonInspection As System.Windows.Forms.Button
    Friend WithEvents btnCLMPon As System.Windows.Forms.Button
    Friend WithEvents cmdGo As System.Windows.Forms.Button
    Friend WithEvents eighthUp As System.Windows.Forms.Button
    Friend WithEvents eighthDn As System.Windows.Forms.Button
    Friend WithEvents cmdYMinus As System.Windows.Forms.Button
    Friend WithEvents cmdYPlus As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents System_Label As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents DataGridViewOrders As System.Windows.Forms.DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderNrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DropDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WidthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonUseDatSelected As System.Windows.Forms.Button
    Friend WithEvents NextButton As GL_HoistControl.NextButtonColor
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewRollUpDist As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxAll As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxOrderNr As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OrdersTableAdapter1 As GL_HoistControl.HoistOrders1DataSetTableAdapters.OrdersTableAdapter
   
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OrdersResultTableAdapter1 As GL_HoistControl.HoistOrdersResultDataSetTableAdapters.OrdersResultTableAdapter
    Friend WithEvents HoistOrdersResultDataSet1 As GL_HoistControl.HoistOrdersResultDataSet
   
   



End Class
