<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Measurement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Measurement))
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.TextBox_OrderNr = New System.Windows.Forms.TextBox()
        Me.TextBox_InputA0 = New System.Windows.Forms.TextBox()
        Me.BtnStartUS = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.TextBoxWidthResult = New System.Windows.Forms.TextBox()
        Me.TextBoxCalcCalib = New System.Windows.Forms.TextBox()
        Me.ButtonStartCalibLaser = New System.Windows.Forms.Button()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.TextBoxResultCalibLaser = New System.Windows.Forms.TextBox()
        Me.textboxnrof = New System.Windows.Forms.TextBox()
        Me.TextBoxCycleLaser = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TextBoxCalcResultLaser = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TextBox_LaserControlPos = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBoxResultLaser = New System.Windows.Forms.TextBox()
        Me.GroupBoxSercom = New System.Windows.Forms.GroupBox()
        Me.GroupBoxDataReceived = New System.Windows.Forms.GroupBox()
        Me.TextBoxSend = New System.Windows.Forms.TextBox()
        Me.GroupBoxDatRec = New System.Windows.Forms.GroupBox()
        Me.TextBoxReceive = New System.Windows.Forms.TextBox()
        Me.ButtonSend = New System.Windows.Forms.Button()
        Me.GroupBoxComport = New System.Windows.Forms.GroupBox()
        Me.PortComboBox = New System.Windows.Forms.ComboBox()
        Me.ButtonSerialPortClose = New System.Windows.Forms.Button()
        Me.ButtonOpenComPort = New System.Windows.Forms.Button()
        Me.ButtonGoMeasureLaser = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonBotBarCalib = New System.Windows.Forms.Button()
        Me.ButtonStopContUS = New System.Windows.Forms.Button()
        Me.ButtonStartContUS = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBoxMeasurePositionUS = New System.Windows.Forms.TextBox()
        Me.GroupBoxSensorValue = New System.Windows.Forms.GroupBox()
        Me.GBResult = New System.Windows.Forms.GroupBox()
        Me.GroupBox26 = New System.Windows.Forms.GroupBox()
        Me.TextBoxPointsC = New System.Windows.Forms.TextBox()
        Me.GroupBox25 = New System.Windows.Forms.GroupBox()
        Me.TextBoxPointsB = New System.Windows.Forms.TextBox()
        Me.GroupBox24 = New System.Windows.Forms.GroupBox()
        Me.TextBoxPointsA = New System.Windows.Forms.TextBox()
        Me.GroupBox23 = New System.Windows.Forms.GroupBox()
        Me.TextBoxMeasuredDropC = New System.Windows.Forms.TextBox()
        Me.GroupBox22 = New System.Windows.Forms.GroupBox()
        Me.TextBoxMeasuredDropB = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.TextBoxResultUSCalcC = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TextBoxResultUSCalcB = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.TextBoxMeasuredDropA = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.TextBoxResultUSCalcA = New System.Windows.Forms.TextBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.TextBoxSSwUs = New System.Windows.Forms.TextBox()
        Me.ErrorUSVolts = New System.Windows.Forms.Label()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.TextBoxTheoDrop = New System.Windows.Forms.TextBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.TextBoxVertMountOffset = New System.Windows.Forms.TextBox()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.GroupBox21 = New System.Windows.Forms.GroupBox()
        Me.TextBoxProdbotbarrad = New System.Windows.Forms.TextBox()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.TextBoxVertLaserMeasureOffset = New System.Windows.Forms.TextBox()
        Me.ButtonCalibUS = New System.Windows.Forms.Button()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.DMCPoll1 = New System.Windows.Forms.TextBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerM = New System.Windows.Forms.Timer(Me.components)
        Me.TextBoxCB0_0 = New System.Windows.Forms.TextBox()
        Me.TextBoxCB1_0 = New System.Windows.Forms.TextBox()
        Me.TextBoxAlfa = New System.Windows.Forms.TextBox()
        Me.TextBoxSensposToRef1 = New System.Windows.Forms.TextBox()
        Me.TextBoxDistSensors = New System.Windows.Forms.TextBox()
        Me.calibmeasure1 = New System.Windows.Forms.Label()
        Me.TextBoxCB0_1 = New System.Windows.Forms.TextBox()
        Me.TextBoxCB1_1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxLog = New System.Windows.Forms.TextBox()
        Me.ButtonSaveLog = New System.Windows.Forms.Button()
        Me.TextBoxFname = New System.Windows.Forms.TextBox()
        Me.ButtonSkipCcalib = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.ButtonSaveCalib = New System.Windows.Forms.Button()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.TextBoxLaserErr = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBoxSercom.SuspendLayout()
        Me.GroupBoxDataReceived.SuspendLayout()
        Me.GroupBoxDatRec.SuspendLayout()
        Me.GroupBoxComport.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBoxSensorValue.SuspendLayout()
        Me.GBResult.SuspendLayout()
        Me.GroupBox26.SuspendLayout()
        Me.GroupBox25.SuspendLayout()
        Me.GroupBox24.SuspendLayout()
        Me.GroupBox23.SuspendLayout()
        Me.GroupBox22.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox21.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.AutoSize = True
        Me.ExitButton.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(1013, 891)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(258, 86)
        Me.ExitButton.TabIndex = 20
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'TextBox_OrderNr
        '
        Me.TextBox_OrderNr.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_OrderNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_OrderNr.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_OrderNr.Location = New System.Drawing.Point(248, 19)
        Me.TextBox_OrderNr.Name = "TextBox_OrderNr"
        Me.TextBox_OrderNr.ReadOnly = True
        Me.TextBox_OrderNr.Size = New System.Drawing.Size(192, 44)
        Me.TextBox_OrderNr.TabIndex = 32
        '
        'TextBox_InputA0
        '
        Me.TextBox_InputA0.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_InputA0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_InputA0.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_InputA0.Location = New System.Drawing.Point(6, 19)
        Me.TextBox_InputA0.Name = "TextBox_InputA0"
        Me.TextBox_InputA0.ReadOnly = True
        Me.TextBox_InputA0.Size = New System.Drawing.Size(199, 44)
        Me.TextBox_InputA0.TabIndex = 31
        '
        'BtnStartUS
        '
        Me.BtnStartUS.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStartUS.Location = New System.Drawing.Point(13, 105)
        Me.BtnStartUS.Name = "BtnStartUS"
        Me.BtnStartUS.Size = New System.Drawing.Size(92, 60)
        Me.BtnStartUS.TabIndex = 35
        Me.BtnStartUS.Text = "Start US"
        Me.BtnStartUS.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox19)
        Me.GroupBox1.Controls.Add(Me.TextBoxCalcCalib)
        Me.GroupBox1.Controls.Add(Me.ButtonStartCalibLaser)
        Me.GroupBox1.Controls.Add(Me.GroupBox18)
        Me.GroupBox1.Controls.Add(Me.textboxnrof)
        Me.GroupBox1.Controls.Add(Me.TextBoxCycleLaser)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBoxSercom)
        Me.GroupBox1.Controls.Add(Me.ButtonGoMeasureLaser)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(654, 481)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Laser unit"
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(Me.TextBoxWidthResult)
        Me.GroupBox19.Location = New System.Drawing.Point(410, 19)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(176, 77)
        Me.GroupBox19.TabIndex = 53
        Me.GroupBox19.TabStop = False
        Me.GroupBox19.Text = "Width Result"
        '
        'TextBoxWidthResult
        '
        Me.TextBoxWidthResult.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxWidthResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxWidthResult.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxWidthResult.Location = New System.Drawing.Point(6, 16)
        Me.TextBoxWidthResult.Name = "TextBoxWidthResult"
        Me.TextBoxWidthResult.ReadOnly = True
        Me.TextBoxWidthResult.Size = New System.Drawing.Size(162, 44)
        Me.TextBoxWidthResult.TabIndex = 45
        '
        'TextBoxCalcCalib
        '
        Me.TextBoxCalcCalib.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCalcCalib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxCalcCalib.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCalcCalib.Location = New System.Drawing.Point(509, 397)
        Me.TextBoxCalcCalib.Multiline = True
        Me.TextBoxCalcCalib.Name = "TextBoxCalcCalib"
        Me.TextBoxCalcCalib.ReadOnly = True
        Me.TextBoxCalcCalib.Size = New System.Drawing.Size(77, 69)
        Me.TextBoxCalcCalib.TabIndex = 62
        '
        'ButtonStartCalibLaser
        '
        Me.ButtonStartCalibLaser.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonStartCalibLaser.Location = New System.Drawing.Point(215, 177)
        Me.ButtonStartCalibLaser.Name = "ButtonStartCalibLaser"
        Me.ButtonStartCalibLaser.Size = New System.Drawing.Size(168, 57)
        Me.ButtonStartCalibLaser.TabIndex = 52
        Me.ButtonStartCalibLaser.Text = "Calib LASER"
        Me.ButtonStartCalibLaser.UseVisualStyleBackColor = True
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.TextBoxResultCalibLaser)
        Me.GroupBox18.Location = New System.Drawing.Point(15, 171)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(176, 66)
        Me.GroupBox18.TabIndex = 51
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "Calibration Result"
        '
        'TextBoxResultCalibLaser
        '
        Me.TextBoxResultCalibLaser.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxResultCalibLaser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxResultCalibLaser.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxResultCalibLaser.Location = New System.Drawing.Point(6, 16)
        Me.TextBoxResultCalibLaser.Name = "TextBoxResultCalibLaser"
        Me.TextBoxResultCalibLaser.ReadOnly = True
        Me.TextBoxResultCalibLaser.Size = New System.Drawing.Size(162, 44)
        Me.TextBoxResultCalibLaser.TabIndex = 45
        '
        'textboxnrof
        '
        Me.textboxnrof.Location = New System.Drawing.Point(608, 62)
        Me.textboxnrof.Name = "textboxnrof"
        Me.textboxnrof.Size = New System.Drawing.Size(40, 20)
        Me.textboxnrof.TabIndex = 50
        '
        'TextBoxCycleLaser
        '
        Me.TextBoxCycleLaser.Location = New System.Drawing.Point(608, 38)
        Me.TextBoxCycleLaser.Name = "TextBoxCycleLaser"
        Me.TextBoxCycleLaser.Size = New System.Drawing.Size(40, 20)
        Me.TextBoxCycleLaser.TabIndex = 48
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TextBoxCalcResultLaser)
        Me.GroupBox6.Location = New System.Drawing.Point(15, 99)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(176, 66)
        Me.GroupBox6.TabIndex = 47
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Calculation Result"
        '
        'TextBoxCalcResultLaser
        '
        Me.TextBoxCalcResultLaser.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCalcResultLaser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxCalcResultLaser.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCalcResultLaser.Location = New System.Drawing.Point(6, 16)
        Me.TextBoxCalcResultLaser.Name = "TextBoxCalcResultLaser"
        Me.TextBoxCalcResultLaser.ReadOnly = True
        Me.TextBoxCalcResultLaser.Size = New System.Drawing.Size(162, 44)
        Me.TextBoxCalcResultLaser.TabIndex = 45
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TextBox_LaserControlPos)
        Me.GroupBox5.Location = New System.Drawing.Point(215, 20)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(184, 76)
        Me.GroupBox5.TabIndex = 46
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "MeasurePositionSetValueLaser"
        '
        'TextBox_LaserControlPos
        '
        Me.TextBox_LaserControlPos.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_LaserControlPos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_LaserControlPos.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_LaserControlPos.Location = New System.Drawing.Point(6, 18)
        Me.TextBox_LaserControlPos.Name = "TextBox_LaserControlPos"
        Me.TextBox_LaserControlPos.Size = New System.Drawing.Size(162, 44)
        Me.TextBox_LaserControlPos.TabIndex = 35
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBoxResultLaser)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(176, 77)
        Me.GroupBox4.TabIndex = 45
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "LaserActValue"
        '
        'TextBoxResultLaser
        '
        Me.TextBoxResultLaser.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxResultLaser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxResultLaser.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxResultLaser.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxResultLaser.Name = "TextBoxResultLaser"
        Me.TextBoxResultLaser.ReadOnly = True
        Me.TextBoxResultLaser.Size = New System.Drawing.Size(162, 44)
        Me.TextBoxResultLaser.TabIndex = 44
        '
        'GroupBoxSercom
        '
        Me.GroupBoxSercom.Controls.Add(Me.GroupBoxDataReceived)
        Me.GroupBoxSercom.Controls.Add(Me.GroupBoxDatRec)
        Me.GroupBoxSercom.Controls.Add(Me.ButtonSend)
        Me.GroupBoxSercom.Controls.Add(Me.GroupBoxComport)
        Me.GroupBoxSercom.Controls.Add(Me.ButtonSerialPortClose)
        Me.GroupBoxSercom.Controls.Add(Me.ButtonOpenComPort)
        Me.GroupBoxSercom.Location = New System.Drawing.Point(8, 235)
        Me.GroupBoxSercom.Name = "GroupBoxSercom"
        Me.GroupBoxSercom.Size = New System.Drawing.Size(437, 240)
        Me.GroupBoxSercom.TabIndex = 42
        Me.GroupBoxSercom.TabStop = False
        Me.GroupBoxSercom.Text = "SerialComToLaser"
        '
        'GroupBoxDataReceived
        '
        Me.GroupBoxDataReceived.Controls.Add(Me.TextBoxSend)
        Me.GroupBoxDataReceived.Location = New System.Drawing.Point(6, 167)
        Me.GroupBoxDataReceived.Name = "GroupBoxDataReceived"
        Me.GroupBoxDataReceived.Size = New System.Drawing.Size(176, 64)
        Me.GroupBoxDataReceived.TabIndex = 47
        Me.GroupBoxDataReceived.TabStop = False
        Me.GroupBoxDataReceived.Text = "DataSend"
        '
        'TextBoxSend
        '
        Me.TextBoxSend.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxSend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxSend.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSend.Location = New System.Drawing.Point(6, 14)
        Me.TextBoxSend.Name = "TextBoxSend"
        Me.TextBoxSend.Size = New System.Drawing.Size(164, 44)
        Me.TextBoxSend.TabIndex = 40
        '
        'GroupBoxDatRec
        '
        Me.GroupBoxDatRec.Controls.Add(Me.TextBoxReceive)
        Me.GroupBoxDatRec.Location = New System.Drawing.Point(6, 92)
        Me.GroupBoxDatRec.Name = "GroupBoxDatRec"
        Me.GroupBoxDatRec.Size = New System.Drawing.Size(176, 69)
        Me.GroupBoxDatRec.TabIndex = 46
        Me.GroupBoxDatRec.TabStop = False
        Me.GroupBoxDatRec.Text = "DataReceived"
        '
        'TextBoxReceive
        '
        Me.TextBoxReceive.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxReceive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxReceive.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxReceive.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxReceive.Name = "TextBoxReceive"
        Me.TextBoxReceive.Size = New System.Drawing.Size(164, 44)
        Me.TextBoxReceive.TabIndex = 39
        '
        'ButtonSend
        '
        Me.ButtonSend.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonSend.Location = New System.Drawing.Point(207, 181)
        Me.ButtonSend.Name = "ButtonSend"
        Me.ButtonSend.Size = New System.Drawing.Size(162, 43)
        Me.ButtonSend.TabIndex = 41
        Me.ButtonSend.Text = "Send"
        Me.ButtonSend.UseVisualStyleBackColor = True
        '
        'GroupBoxComport
        '
        Me.GroupBoxComport.Controls.Add(Me.PortComboBox)
        Me.GroupBoxComport.Location = New System.Drawing.Point(6, 19)
        Me.GroupBoxComport.Name = "GroupBoxComport"
        Me.GroupBoxComport.Size = New System.Drawing.Size(176, 67)
        Me.GroupBoxComport.TabIndex = 45
        Me.GroupBoxComport.TabStop = False
        Me.GroupBoxComport.Text = "ComportNr"
        '
        'PortComboBox
        '
        Me.PortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PortComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PortComboBox.FormattingEnabled = True
        Me.PortComboBox.Location = New System.Drawing.Point(8, 19)
        Me.PortComboBox.Name = "PortComboBox"
        Me.PortComboBox.Size = New System.Drawing.Size(162, 28)
        Me.PortComboBox.TabIndex = 42
        '
        'ButtonSerialPortClose
        '
        Me.ButtonSerialPortClose.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonSerialPortClose.Location = New System.Drawing.Point(207, 100)
        Me.ButtonSerialPortClose.Name = "ButtonSerialPortClose"
        Me.ButtonSerialPortClose.Size = New System.Drawing.Size(162, 55)
        Me.ButtonSerialPortClose.TabIndex = 43
        Me.ButtonSerialPortClose.Text = "Close comport Laser"
        Me.ButtonSerialPortClose.UseVisualStyleBackColor = True
        '
        'ButtonOpenComPort
        '
        Me.ButtonOpenComPort.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonOpenComPort.Location = New System.Drawing.Point(207, 29)
        Me.ButtonOpenComPort.Name = "ButtonOpenComPort"
        Me.ButtonOpenComPort.Size = New System.Drawing.Size(162, 55)
        Me.ButtonOpenComPort.TabIndex = 38
        Me.ButtonOpenComPort.Text = "Open comport Laser"
        Me.ButtonOpenComPort.UseVisualStyleBackColor = True
        '
        'ButtonGoMeasureLaser
        '
        Me.ButtonGoMeasureLaser.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonGoMeasureLaser.Location = New System.Drawing.Point(215, 105)
        Me.ButtonGoMeasureLaser.Name = "ButtonGoMeasureLaser"
        Me.ButtonGoMeasureLaser.Size = New System.Drawing.Size(168, 57)
        Me.ButtonGoMeasureLaser.TabIndex = 37
        Me.ButtonGoMeasureLaser.Text = "Start LASER"
        Me.ButtonGoMeasureLaser.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonBotBarCalib)
        Me.GroupBox2.Controls.Add(Me.ButtonStopContUS)
        Me.GroupBox2.Controls.Add(Me.ButtonStartContUS)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBoxSensorValue)
        Me.GroupBox2.Controls.Add(Me.GBResult)
        Me.GroupBox2.Controls.Add(Me.BtnStartUS)
        Me.GroupBox2.Controls.Add(Me.GroupBox14)
        Me.GroupBox2.Location = New System.Drawing.Point(693, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(599, 567)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ultrasonic unit"
        '
        'ButtonBotBarCalib
        '
        Me.ButtonBotBarCalib.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBotBarCalib.Location = New System.Drawing.Point(461, 36)
        Me.ButtonBotBarCalib.Name = "ButtonBotBarCalib"
        Me.ButtonBotBarCalib.Size = New System.Drawing.Size(92, 60)
        Me.ButtonBotBarCalib.TabIndex = 73
        Me.ButtonBotBarCalib.Text = "BotBar calib"
        Me.ButtonBotBarCalib.UseVisualStyleBackColor = True
        '
        'ButtonStopContUS
        '
        Me.ButtonStopContUS.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStopContUS.Location = New System.Drawing.Point(363, 35)
        Me.ButtonStopContUS.Name = "ButtonStopContUS"
        Me.ButtonStopContUS.Size = New System.Drawing.Size(92, 60)
        Me.ButtonStopContUS.TabIndex = 71
        Me.ButtonStopContUS.Text = "Stop US cont"
        Me.ButtonStopContUS.UseVisualStyleBackColor = True
        '
        'ButtonStartContUS
        '
        Me.ButtonStartContUS.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStartContUS.Location = New System.Drawing.Point(265, 35)
        Me.ButtonStartContUS.Name = "ButtonStartContUS"
        Me.ButtonStartContUS.Size = New System.Drawing.Size(92, 60)
        Me.ButtonStartContUS.TabIndex = 70
        Me.ButtonStartContUS.Text = "Start US cont"
        Me.ButtonStartContUS.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBoxMeasurePositionUS)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(234, 74)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "MeasurePositionSetValueUS"
        '
        'TextBoxMeasurePositionUS
        '
        Me.TextBoxMeasurePositionUS.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxMeasurePositionUS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxMeasurePositionUS.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMeasurePositionUS.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxMeasurePositionUS.Name = "TextBoxMeasurePositionUS"
        Me.TextBoxMeasurePositionUS.Size = New System.Drawing.Size(220, 44)
        Me.TextBoxMeasurePositionUS.TabIndex = 42
        '
        'GroupBoxSensorValue
        '
        Me.GroupBoxSensorValue.Controls.Add(Me.TextBox_InputA0)
        Me.GroupBoxSensorValue.Controls.Add(Me.TextBox_OrderNr)
        Me.GroupBoxSensorValue.Location = New System.Drawing.Point(7, 171)
        Me.GroupBoxSensorValue.Name = "GroupBoxSensorValue"
        Me.GroupBoxSensorValue.Size = New System.Drawing.Size(484, 87)
        Me.GroupBoxSensorValue.TabIndex = 41
        Me.GroupBoxSensorValue.TabStop = False
        Me.GroupBoxSensorValue.Text = "SensorValue"
        '
        'GBResult
        '
        Me.GBResult.Controls.Add(Me.GroupBox26)
        Me.GBResult.Controls.Add(Me.GroupBox25)
        Me.GBResult.Controls.Add(Me.GroupBox24)
        Me.GBResult.Controls.Add(Me.GroupBox23)
        Me.GBResult.Controls.Add(Me.GroupBox22)
        Me.GBResult.Controls.Add(Me.GroupBox8)
        Me.GBResult.Controls.Add(Me.GroupBox7)
        Me.GBResult.Controls.Add(Me.GroupBox10)
        Me.GBResult.Controls.Add(Me.GroupBox9)
        Me.GBResult.Location = New System.Drawing.Point(7, 264)
        Me.GBResult.Name = "GBResult"
        Me.GBResult.Size = New System.Drawing.Size(586, 269)
        Me.GBResult.TabIndex = 40
        Me.GBResult.TabStop = False
        Me.GBResult.Text = "Calculation  Result"
        '
        'GroupBox26
        '
        Me.GroupBox26.Controls.Add(Me.TextBoxPointsC)
        Me.GroupBox26.Location = New System.Drawing.Point(454, 179)
        Me.GroupBox26.Name = "GroupBox26"
        Me.GroupBox26.Size = New System.Drawing.Size(97, 74)
        Me.GroupBox26.TabIndex = 52
        Me.GroupBox26.TabStop = False
        Me.GroupBox26.Text = "Points C"
        '
        'TextBoxPointsC
        '
        Me.TextBoxPointsC.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxPointsC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPointsC.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPointsC.Location = New System.Drawing.Point(6, 18)
        Me.TextBoxPointsC.Name = "TextBoxPointsC"
        Me.TextBoxPointsC.ReadOnly = True
        Me.TextBoxPointsC.Size = New System.Drawing.Size(78, 44)
        Me.TextBoxPointsC.TabIndex = 39
        '
        'GroupBox25
        '
        Me.GroupBox25.Controls.Add(Me.TextBoxPointsB)
        Me.GroupBox25.Location = New System.Drawing.Point(454, 99)
        Me.GroupBox25.Name = "GroupBox25"
        Me.GroupBox25.Size = New System.Drawing.Size(97, 74)
        Me.GroupBox25.TabIndex = 51
        Me.GroupBox25.TabStop = False
        Me.GroupBox25.Text = "Points B"
        '
        'TextBoxPointsB
        '
        Me.TextBoxPointsB.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxPointsB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPointsB.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPointsB.Location = New System.Drawing.Point(6, 18)
        Me.TextBoxPointsB.Name = "TextBoxPointsB"
        Me.TextBoxPointsB.ReadOnly = True
        Me.TextBoxPointsB.Size = New System.Drawing.Size(78, 44)
        Me.TextBoxPointsB.TabIndex = 39
        '
        'GroupBox24
        '
        Me.GroupBox24.Controls.Add(Me.TextBoxPointsA)
        Me.GroupBox24.Location = New System.Drawing.Point(454, 19)
        Me.GroupBox24.Name = "GroupBox24"
        Me.GroupBox24.Size = New System.Drawing.Size(97, 74)
        Me.GroupBox24.TabIndex = 50
        Me.GroupBox24.TabStop = False
        Me.GroupBox24.Text = "Points A"
        '
        'TextBoxPointsA
        '
        Me.TextBoxPointsA.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxPointsA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPointsA.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPointsA.Location = New System.Drawing.Point(6, 18)
        Me.TextBoxPointsA.Name = "TextBoxPointsA"
        Me.TextBoxPointsA.ReadOnly = True
        Me.TextBoxPointsA.Size = New System.Drawing.Size(78, 44)
        Me.TextBoxPointsA.TabIndex = 39
        '
        'GroupBox23
        '
        Me.GroupBox23.Controls.Add(Me.TextBoxMeasuredDropC)
        Me.GroupBox23.Location = New System.Drawing.Point(236, 179)
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Size = New System.Drawing.Size(210, 74)
        Me.GroupBox23.TabIndex = 49
        Me.GroupBox23.TabStop = False
        Me.GroupBox23.Text = "Measured Drop C"
        '
        'TextBoxMeasuredDropC
        '
        Me.TextBoxMeasuredDropC.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxMeasuredDropC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxMeasuredDropC.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMeasuredDropC.Location = New System.Drawing.Point(6, 18)
        Me.TextBoxMeasuredDropC.Name = "TextBoxMeasuredDropC"
        Me.TextBoxMeasuredDropC.ReadOnly = True
        Me.TextBoxMeasuredDropC.Size = New System.Drawing.Size(192, 44)
        Me.TextBoxMeasuredDropC.TabIndex = 39
        '
        'GroupBox22
        '
        Me.GroupBox22.Controls.Add(Me.TextBoxMeasuredDropB)
        Me.GroupBox22.Location = New System.Drawing.Point(236, 99)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Size = New System.Drawing.Size(210, 74)
        Me.GroupBox22.TabIndex = 48
        Me.GroupBox22.TabStop = False
        Me.GroupBox22.Text = "Measured DropB"
        '
        'TextBoxMeasuredDropB
        '
        Me.TextBoxMeasuredDropB.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxMeasuredDropB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxMeasuredDropB.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMeasuredDropB.Location = New System.Drawing.Point(6, 18)
        Me.TextBoxMeasuredDropB.Name = "TextBoxMeasuredDropB"
        Me.TextBoxMeasuredDropB.ReadOnly = True
        Me.TextBoxMeasuredDropB.Size = New System.Drawing.Size(192, 44)
        Me.TextBoxMeasuredDropB.TabIndex = 39
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TextBoxResultUSCalcC)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 179)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(220, 74)
        Me.GroupBox8.TabIndex = 47
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "UsCalculationResult C"
        '
        'TextBoxResultUSCalcC
        '
        Me.TextBoxResultUSCalcC.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxResultUSCalcC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxResultUSCalcC.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxResultUSCalcC.Location = New System.Drawing.Point(7, 18)
        Me.TextBoxResultUSCalcC.Name = "TextBoxResultUSCalcC"
        Me.TextBoxResultUSCalcC.ReadOnly = True
        Me.TextBoxResultUSCalcC.Size = New System.Drawing.Size(191, 44)
        Me.TextBoxResultUSCalcC.TabIndex = 39
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TextBoxResultUSCalcB)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 99)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(220, 74)
        Me.GroupBox7.TabIndex = 46
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "UsCalculationResult B"
        '
        'TextBoxResultUSCalcB
        '
        Me.TextBoxResultUSCalcB.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxResultUSCalcB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxResultUSCalcB.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxResultUSCalcB.Location = New System.Drawing.Point(7, 18)
        Me.TextBoxResultUSCalcB.Name = "TextBoxResultUSCalcB"
        Me.TextBoxResultUSCalcB.ReadOnly = True
        Me.TextBoxResultUSCalcB.Size = New System.Drawing.Size(191, 44)
        Me.TextBoxResultUSCalcB.TabIndex = 39
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.TextBoxMeasuredDropA)
        Me.GroupBox10.Location = New System.Drawing.Point(236, 19)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(210, 74)
        Me.GroupBox10.TabIndex = 45
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Measured DropA"
        '
        'TextBoxMeasuredDropA
        '
        Me.TextBoxMeasuredDropA.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxMeasuredDropA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxMeasuredDropA.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMeasuredDropA.Location = New System.Drawing.Point(6, 18)
        Me.TextBoxMeasuredDropA.Name = "TextBoxMeasuredDropA"
        Me.TextBoxMeasuredDropA.ReadOnly = True
        Me.TextBoxMeasuredDropA.Size = New System.Drawing.Size(192, 44)
        Me.TextBoxMeasuredDropA.TabIndex = 39
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.TextBoxResultUSCalcA)
        Me.GroupBox9.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(220, 74)
        Me.GroupBox9.TabIndex = 44
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "UsCalculationResult A"
        '
        'TextBoxResultUSCalcA
        '
        Me.TextBoxResultUSCalcA.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxResultUSCalcA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxResultUSCalcA.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxResultUSCalcA.Location = New System.Drawing.Point(7, 18)
        Me.TextBoxResultUSCalcA.Name = "TextBoxResultUSCalcA"
        Me.TextBoxResultUSCalcA.ReadOnly = True
        Me.TextBoxResultUSCalcA.Size = New System.Drawing.Size(191, 44)
        Me.TextBoxResultUSCalcA.TabIndex = 39
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.TextBoxSSwUs)
        Me.GroupBox14.Controls.Add(Me.ErrorUSVolts)
        Me.GroupBox14.Location = New System.Drawing.Point(111, 99)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(380, 72)
        Me.GroupBox14.TabIndex = 69
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Measurement stepper"
        '
        'TextBoxSSwUs
        '
        Me.TextBoxSSwUs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSSwUs.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxSSwUs.Name = "TextBoxSSwUs"
        Me.TextBoxSSwUs.Size = New System.Drawing.Size(122, 26)
        Me.TextBoxSSwUs.TabIndex = 49
        '
        'ErrorUSVolts
        '
        Me.ErrorUSVolts.BackColor = System.Drawing.Color.Red
        Me.ErrorUSVolts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ErrorUSVolts.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorUSVolts.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ErrorUSVolts.Location = New System.Drawing.Point(154, 16)
        Me.ErrorUSVolts.Name = "ErrorUSVolts"
        Me.ErrorUSVolts.Size = New System.Drawing.Size(220, 44)
        Me.ErrorUSVolts.TabIndex = 63
        Me.ErrorUSVolts.Text = "USMinMaxVoltError"
        Me.ErrorUSVolts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ErrorUSVolts.Visible = False
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.TextBoxTheoDrop)
        Me.GroupBox13.Location = New System.Drawing.Point(12, 152)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(234, 52)
        Me.GroupBox13.TabIndex = 68
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Theoretical product drop"
        '
        'TextBoxTheoDrop
        '
        Me.TextBoxTheoDrop.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxTheoDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxTheoDrop.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTheoDrop.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxTheoDrop.Name = "TextBoxTheoDrop"
        Me.TextBoxTheoDrop.Size = New System.Drawing.Size(220, 32)
        Me.TextBoxTheoDrop.TabIndex = 42
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.TextBoxVertMountOffset)
        Me.GroupBox12.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(234, 58)
        Me.GroupBox12.TabIndex = 67
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Vert mounting offset"
        '
        'TextBoxVertMountOffset
        '
        Me.TextBoxVertMountOffset.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxVertMountOffset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxVertMountOffset.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxVertMountOffset.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxVertMountOffset.Name = "TextBoxVertMountOffset"
        Me.TextBoxVertMountOffset.Size = New System.Drawing.Size(220, 32)
        Me.TextBoxVertMountOffset.TabIndex = 42
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.GroupBox21)
        Me.GroupBox17.Controls.Add(Me.GroupBox20)
        Me.GroupBox17.Controls.Add(Me.GroupBox13)
        Me.GroupBox17.Controls.Add(Me.GroupBox12)
        Me.GroupBox17.Location = New System.Drawing.Point(738, 606)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(258, 279)
        Me.GroupBox17.TabIndex = 72
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Model and Product data"
        '
        'GroupBox21
        '
        Me.GroupBox21.Controls.Add(Me.TextBoxProdbotbarrad)
        Me.GroupBox21.Location = New System.Drawing.Point(12, 210)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(234, 52)
        Me.GroupBox21.TabIndex = 70
        Me.GroupBox21.TabStop = False
        Me.GroupBox21.Text = "ProductBottomBarRadius"
        '
        'TextBoxProdbotbarrad
        '
        Me.TextBoxProdbotbarrad.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxProdbotbarrad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxProdbotbarrad.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxProdbotbarrad.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxProdbotbarrad.Name = "TextBoxProdbotbarrad"
        Me.TextBoxProdbotbarrad.Size = New System.Drawing.Size(220, 32)
        Me.TextBoxProdbotbarrad.TabIndex = 42
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Me.TextBoxVertLaserMeasureOffset)
        Me.GroupBox20.Location = New System.Drawing.Point(12, 88)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(234, 58)
        Me.GroupBox20.TabIndex = 69
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "Vert laser measure offset"
        '
        'TextBoxVertLaserMeasureOffset
        '
        Me.TextBoxVertLaserMeasureOffset.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxVertLaserMeasureOffset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxVertLaserMeasureOffset.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxVertLaserMeasureOffset.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxVertLaserMeasureOffset.Name = "TextBoxVertLaserMeasureOffset"
        Me.TextBoxVertLaserMeasureOffset.Size = New System.Drawing.Size(220, 32)
        Me.TextBoxVertLaserMeasureOffset.TabIndex = 42
        '
        'ButtonCalibUS
        '
        Me.ButtonCalibUS.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCalibUS.Location = New System.Drawing.Point(449, 185)
        Me.ButtonCalibUS.Name = "ButtonCalibUS"
        Me.ButtonCalibUS.Size = New System.Drawing.Size(137, 47)
        Me.ButtonCalibUS.TabIndex = 44
        Me.ButtonCalibUS.Text = "Calibration"
        Me.ButtonCalibUS.UseVisualStyleBackColor = True
        '
        'cmdStop
        '
        Me.cmdStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdStop.BackColor = System.Drawing.Color.DarkRed
        Me.cmdStop.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStop.ForeColor = System.Drawing.Color.White
        Me.cmdStop.Location = New System.Drawing.Point(284, 16)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(168, 55)
        Me.cmdStop.TabIndex = 41
        Me.cmdStop.Text = "STOP MOTION"
        Me.cmdStop.UseVisualStyleBackColor = False
        '
        'DMCPoll1
        '
        Me.DMCPoll1.BackColor = System.Drawing.SystemColors.Window
        Me.DMCPoll1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DMCPoll1.Font = New System.Drawing.Font("Arial Narrow", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DMCPoll1.Location = New System.Drawing.Point(6, 19)
        Me.DMCPoll1.Name = "DMCPoll1"
        Me.DMCPoll1.ReadOnly = True
        Me.DMCPoll1.Size = New System.Drawing.Size(272, 50)
        Me.DMCPoll1.TabIndex = 40
        '
        'SerialPort1
        '
        '
        'TimerM
        '
        '
        'TextBoxCB0_0
        '
        Me.TextBoxCB0_0.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCB0_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxCB0_0.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCB0_0.Location = New System.Drawing.Point(169, 38)
        Me.TextBoxCB0_0.Name = "TextBoxCB0_0"
        Me.TextBoxCB0_0.ReadOnly = True
        Me.TextBoxCB0_0.Size = New System.Drawing.Size(220, 44)
        Me.TextBoxCB0_0.TabIndex = 50
        '
        'TextBoxCB1_0
        '
        Me.TextBoxCB1_0.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCB1_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxCB1_0.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCB1_0.Location = New System.Drawing.Point(169, 102)
        Me.TextBoxCB1_0.Name = "TextBoxCB1_0"
        Me.TextBoxCB1_0.ReadOnly = True
        Me.TextBoxCB1_0.Size = New System.Drawing.Size(220, 44)
        Me.TextBoxCB1_0.TabIndex = 51
        '
        'TextBoxAlfa
        '
        Me.TextBoxAlfa.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxAlfa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxAlfa.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAlfa.Location = New System.Drawing.Point(169, 188)
        Me.TextBoxAlfa.Name = "TextBoxAlfa"
        Me.TextBoxAlfa.Size = New System.Drawing.Size(220, 44)
        Me.TextBoxAlfa.TabIndex = 52
        '
        'TextBoxSensposToRef1
        '
        Me.TextBoxSensposToRef1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxSensposToRef1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxSensposToRef1.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSensposToRef1.Location = New System.Drawing.Point(167, 257)
        Me.TextBoxSensposToRef1.Name = "TextBoxSensposToRef1"
        Me.TextBoxSensposToRef1.Size = New System.Drawing.Size(220, 44)
        Me.TextBoxSensposToRef1.TabIndex = 53
        '
        'TextBoxDistSensors
        '
        Me.TextBoxDistSensors.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxDistSensors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxDistSensors.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDistSensors.Location = New System.Drawing.Point(167, 321)
        Me.TextBoxDistSensors.Name = "TextBoxDistSensors"
        Me.TextBoxDistSensors.Size = New System.Drawing.Size(220, 44)
        Me.TextBoxDistSensors.TabIndex = 54
        '
        'calibmeasure1
        '
        Me.calibmeasure1.AutoSize = True
        Me.calibmeasure1.Location = New System.Drawing.Point(36, 50)
        Me.calibmeasure1.Name = "calibmeasure1"
        Me.calibmeasure1.Size = New System.Drawing.Size(75, 13)
        Me.calibmeasure1.TabIndex = 55
        Me.calibmeasure1.Text = "calibmeasure0"
        '
        'TextBoxCB0_1
        '
        Me.TextBoxCB0_1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCB0_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxCB0_1.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCB0_1.Location = New System.Drawing.Point(412, 38)
        Me.TextBoxCB0_1.Name = "TextBoxCB0_1"
        Me.TextBoxCB0_1.ReadOnly = True
        Me.TextBoxCB0_1.Size = New System.Drawing.Size(220, 44)
        Me.TextBoxCB0_1.TabIndex = 56
        '
        'TextBoxCB1_1
        '
        Me.TextBoxCB1_1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCB1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxCB1_1.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCB1_1.Location = New System.Drawing.Point(412, 102)
        Me.TextBoxCB1_1.Name = "TextBoxCB1_1"
        Me.TextBoxCB1_1.ReadOnly = True
        Me.TextBoxCB1_1.Size = New System.Drawing.Size(220, 44)
        Me.TextBoxCB1_1.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "alfa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "calibmeasure1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "UsSensorPosToRef1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "USDistSensors"
        '
        'TextBoxLog
        '
        Me.TextBoxLog.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxLog.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLog.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxLog.MaxLength = 100000
        Me.TextBoxLog.Multiline = True
        Me.TextBoxLog.Name = "TextBoxLog"
        Me.TextBoxLog.ReadOnly = True
        Me.TextBoxLog.Size = New System.Drawing.Size(51, 43)
        Me.TextBoxLog.TabIndex = 64
        '
        'ButtonSaveLog
        '
        Me.ButtonSaveLog.Location = New System.Drawing.Point(63, 39)
        Me.ButtonSaveLog.Name = "ButtonSaveLog"
        Me.ButtonSaveLog.Size = New System.Drawing.Size(123, 23)
        Me.ButtonSaveLog.TabIndex = 65
        Me.ButtonSaveLog.Text = "saveLog"
        Me.ButtonSaveLog.UseVisualStyleBackColor = True
        '
        'TextBoxFname
        '
        Me.TextBoxFname.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxFname.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFname.Location = New System.Drawing.Point(63, 19)
        Me.TextBoxFname.MaxLength = 100000
        Me.TextBoxFname.Name = "TextBoxFname"
        Me.TextBoxFname.Size = New System.Drawing.Size(123, 20)
        Me.TextBoxFname.TabIndex = 66
        Me.TextBoxFname.Text = "bbarcalibs\bbarcalibxx.txt"
        '
        'ButtonSkipCcalib
        '
        Me.ButtonSkipCcalib.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSkipCcalib.Location = New System.Drawing.Point(449, 254)
        Me.ButtonSkipCcalib.Name = "ButtonSkipCcalib"
        Me.ButtonSkipCcalib.Size = New System.Drawing.Size(137, 47)
        Me.ButtonSkipCcalib.TabIndex = 67
        Me.ButtonSkipCcalib.Text = "Skip Calibration"
        Me.ButtonSkipCcalib.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.TextBoxLog)
        Me.GroupBox11.Controls.Add(Me.ButtonSaveLog)
        Me.GroupBox11.Controls.Add(Me.TextBoxFname)
        Me.GroupBox11.Location = New System.Drawing.Point(492, 33)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(195, 78)
        Me.GroupBox11.TabIndex = 68
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "LogData"
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.ButtonSaveCalib)
        Me.GroupBox15.Controls.Add(Me.ButtonSkipCcalib)
        Me.GroupBox15.Controls.Add(Me.ButtonCalibUS)
        Me.GroupBox15.Controls.Add(Me.Label4)
        Me.GroupBox15.Controls.Add(Me.TextBoxDistSensors)
        Me.GroupBox15.Controls.Add(Me.TextBoxCB1_1)
        Me.GroupBox15.Controls.Add(Me.Label3)
        Me.GroupBox15.Controls.Add(Me.Label2)
        Me.GroupBox15.Controls.Add(Me.TextBoxCB0_1)
        Me.GroupBox15.Controls.Add(Me.Label1)
        Me.GroupBox15.Controls.Add(Me.TextBoxSensposToRef1)
        Me.GroupBox15.Controls.Add(Me.calibmeasure1)
        Me.GroupBox15.Controls.Add(Me.TextBoxAlfa)
        Me.GroupBox15.Controls.Add(Me.TextBoxCB1_0)
        Me.GroupBox15.Controls.Add(Me.TextBoxCB0_0)
        Me.GroupBox15.Location = New System.Drawing.Point(12, 606)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(720, 371)
        Me.GroupBox15.TabIndex = 70
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "US Calibration"
        '
        'ButtonSaveCalib
        '
        Me.ButtonSaveCalib.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveCalib.Location = New System.Drawing.Point(449, 318)
        Me.ButtonSaveCalib.Name = "ButtonSaveCalib"
        Me.ButtonSaveCalib.Size = New System.Drawing.Size(137, 47)
        Me.ButtonSaveCalib.TabIndex = 68
        Me.ButtonSaveCalib.Text = "Save Calib"
        Me.ButtonSaveCalib.UseVisualStyleBackColor = True
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.cmdStop)
        Me.GroupBox16.Controls.Add(Me.DMCPoll1)
        Me.GroupBox16.Location = New System.Drawing.Point(12, 33)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(474, 78)
        Me.GroupBox16.TabIndex = 71
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Hoist Position"
        '
        'TextBoxLaserErr
        '
        Me.TextBoxLaserErr.Location = New System.Drawing.Point(12, 7)
        Me.TextBoxLaserErr.Name = "TextBoxLaserErr"
        Me.TextBoxLaserErr.Size = New System.Drawing.Size(675, 20)
        Me.TextBoxLaserErr.TabIndex = 74
        '
        'Measurement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1368, 989)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBoxLaserErr)
        Me.Controls.Add(Me.GroupBox16)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox17)
        Me.Controls.Add(Me.GroupBox15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Measurement"
        Me.Text = "Measurement"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout()
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox18.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBoxSercom.ResumeLayout(False)
        Me.GroupBoxDataReceived.ResumeLayout(False)
        Me.GroupBoxDataReceived.PerformLayout()
        Me.GroupBoxDatRec.ResumeLayout(False)
        Me.GroupBoxDatRec.PerformLayout()
        Me.GroupBoxComport.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBoxSensorValue.ResumeLayout(False)
        Me.GroupBoxSensorValue.PerformLayout()
        Me.GBResult.ResumeLayout(False)
        Me.GroupBox26.ResumeLayout(False)
        Me.GroupBox26.PerformLayout()
        Me.GroupBox25.ResumeLayout(False)
        Me.GroupBox25.PerformLayout()
        Me.GroupBox24.ResumeLayout(False)
        Me.GroupBox24.PerformLayout()
        Me.GroupBox23.ResumeLayout(False)
        Me.GroupBox23.PerformLayout()
        Me.GroupBox22.ResumeLayout(False)
        Me.GroupBox22.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox21.ResumeLayout(False)
        Me.GroupBox21.PerformLayout()
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox20.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents TextBox_OrderNr As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_InputA0 As System.Windows.Forms.TextBox
    Friend WithEvents BtnStartUS As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_LaserControlPos As System.Windows.Forms.TextBox
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents DMCPoll1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonGoMeasureLaser As System.Windows.Forms.Button
    Friend WithEvents ButtonOpenComPort As System.Windows.Forms.Button
    Friend WithEvents ButtonSend As System.Windows.Forms.Button
    Friend WithEvents TextBoxSend As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxReceive As System.Windows.Forms.TextBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents PortComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonSerialPortClose As System.Windows.Forms.Button
    Friend WithEvents TextBoxResultLaser As System.Windows.Forms.TextBox
    Friend WithEvents GBResult As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxCalcResultLaser As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxSercom As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxDataReceived As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxDatRec As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxComport As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxMeasurePositionUS As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxSensorValue As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxCycleLaser As System.Windows.Forms.TextBox
    Friend WithEvents TimerM As System.Windows.Forms.Timer
    Friend WithEvents textboxnrof As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCalibUS As System.Windows.Forms.Button
    Friend WithEvents TextBoxSSwUs As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCB0_0 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCB1_0 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAlfa As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSensposToRef1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDistSensors As System.Windows.Forms.TextBox
    Friend WithEvents calibmeasure1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCB0_1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCB1_1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCalcCalib As System.Windows.Forms.TextBox
    Friend WithEvents ErrorUSVolts As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxResultUSCalcA As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxMeasuredDropA As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLog As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSaveLog As System.Windows.Forms.Button
    Friend WithEvents TextBoxFname As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxTheoDrop As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxVertMountOffset As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSkipCcalib As System.Windows.Forms.Button
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox18 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxResultCalibLaser As System.Windows.Forms.TextBox
    Friend WithEvents ButtonStartCalibLaser As System.Windows.Forms.Button
    Friend WithEvents GroupBox19 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxWidthResult As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox20 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxVertLaserMeasureOffset As System.Windows.Forms.TextBox
    Friend WithEvents ButtonStopContUS As System.Windows.Forms.Button
    Friend WithEvents ButtonStartContUS As System.Windows.Forms.Button
    Friend WithEvents ButtonSaveCalib As System.Windows.Forms.Button
    Friend WithEvents GroupBox21 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxProdbotbarrad As System.Windows.Forms.TextBox
    Friend WithEvents ButtonBotBarCalib As System.Windows.Forms.Button
    Friend WithEvents GroupBox23 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxMeasuredDropC As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox22 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxMeasuredDropB As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxResultUSCalcC As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxResultUSCalcB As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox26 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxPointsC As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox25 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxPointsB As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox24 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxPointsA As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLaserErr As System.Windows.Forms.TextBox
End Class
