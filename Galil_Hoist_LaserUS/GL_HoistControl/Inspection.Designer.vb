<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inspection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inspection))
        Me.ComboBoxModel = New System.Windows.Forms.ComboBox()
        Me.GroupBoxModel = New System.Windows.Forms.GroupBox()
        Me.TextBoxModel = New System.Windows.Forms.TextBox()
        Me.TextBoxWidth = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxDrop = New System.Windows.Forms.TextBox()
        Me.GroupBoxHorzOffSet = New System.Windows.Forms.GroupBox()
        Me.TextBoxOffSetLaserOnProd = New System.Windows.Forms.TextBox()
        Me.GroupBoxVertOffSet = New System.Windows.Forms.GroupBox()
        Me.TextBoxMountOffSetVertical = New System.Windows.Forms.TextBox()
        Me.ButtonEditModels = New System.Windows.Forms.Button()
        Me.GroupBoxSetValue = New System.Windows.Forms.GroupBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.TextBoxTolDropDif = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.TextBoxTolDropMinus = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.TextBoxTolWidthMinus = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBoxPrefMeasDist = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TextBoxBottombarradius = New System.Windows.Forms.TextBox()
        Me.GroupBoxTolHorz = New System.Windows.Forms.GroupBox()
        Me.TextBoxTolWidthPlus = New System.Windows.Forms.TextBox()
        Me.GroupBoxTolVert = New System.Windows.Forms.GroupBox()
        Me.TextBoxTolDropPlus = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBoxLaserCalib = New System.Windows.Forms.TextBox()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.TextBoxActions = New System.Windows.Forms.TextBox()
        Me.TextBoxCycleStat = New System.Windows.Forms.TextBox()
        Me.ButtonContDropMeasure = New System.Windows.Forms.Button()
        Me.ButtonFullMeasurement = New System.Windows.Forms.Button()
        Me.TextBoxLaserErr = New System.Windows.Forms.TextBox()
        Me.NButton = New GL_HoistControl.NextButtonColor()
        Me.GoodBadDropEnd = New GL_HoistControl.GoodBad()
        Me.GoodBadW = New GL_HoistControl.GoodBad()
        Me.GoodBadC = New GL_HoistControl.GoodBad()
        Me.GoodBadB = New GL_HoistControl.GoodBad()
        Me.GoodBadA = New GL_HoistControl.GoodBad()
        Me.TextBoxLog = New System.Windows.Forms.TextBox()
        Me.TextBoxCnt = New System.Windows.Forms.TextBox()
        Me.GroupBoxModel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBoxHorzOffSet.SuspendLayout()
        Me.GroupBoxVertOffSet.SuspendLayout()
        Me.GroupBoxSetValue.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBoxTolHorz.SuspendLayout()
        Me.GroupBoxTolVert.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxModel
        '
        Me.ComboBoxModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxModel.Location = New System.Drawing.Point(7, 30)
        Me.ComboBoxModel.Name = "ComboBoxModel"
        Me.ComboBoxModel.Size = New System.Drawing.Size(228, 33)
        Me.ComboBoxModel.TabIndex = 20
        '
        'GroupBoxModel
        '
        Me.GroupBoxModel.Controls.Add(Me.TextBoxModel)
        Me.GroupBoxModel.Controls.Add(Me.ComboBoxModel)
        Me.GroupBoxModel.Location = New System.Drawing.Point(280, 712)
        Me.GroupBoxModel.Name = "GroupBoxModel"
        Me.GroupBoxModel.Size = New System.Drawing.Size(246, 79)
        Me.GroupBoxModel.TabIndex = 1
        Me.GroupBoxModel.TabStop = False
        Me.GroupBoxModel.Text = "Model"
        '
        'TextBoxModel
        '
        Me.TextBoxModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxModel.Location = New System.Drawing.Point(7, 30)
        Me.TextBoxModel.Name = "TextBoxModel"
        Me.TextBoxModel.Size = New System.Drawing.Size(228, 31)
        Me.TextBoxModel.TabIndex = 19
        Me.TextBoxModel.Visible = False
        '
        'TextBoxWidth
        '
        Me.TextBoxWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxWidth.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxWidth.Name = "TextBoxWidth"
        Me.TextBoxWidth.Size = New System.Drawing.Size(228, 31)
        Me.TextBoxWidth.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxWidth)
        Me.GroupBox1.Location = New System.Drawing.Point(280, 862)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 70)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Width"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxDrop)
        Me.GroupBox2.Location = New System.Drawing.Point(280, 792)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(246, 64)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Drop"
        '
        'TextBoxDrop
        '
        Me.TextBoxDrop.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDrop.Location = New System.Drawing.Point(7, 19)
        Me.TextBoxDrop.Name = "TextBoxDrop"
        Me.TextBoxDrop.Size = New System.Drawing.Size(228, 31)
        Me.TextBoxDrop.TabIndex = 2
        '
        'GroupBoxHorzOffSet
        '
        Me.GroupBoxHorzOffSet.Controls.Add(Me.TextBoxOffSetLaserOnProd)
        Me.GroupBoxHorzOffSet.Location = New System.Drawing.Point(10, 19)
        Me.GroupBoxHorzOffSet.Name = "GroupBoxHorzOffSet"
        Me.GroupBoxHorzOffSet.Size = New System.Drawing.Size(246, 42)
        Me.GroupBoxHorzOffSet.TabIndex = 5
        Me.GroupBoxHorzOffSet.TabStop = False
        Me.GroupBoxHorzOffSet.Text = "OffSetLaserOnProd"
        '
        'TextBoxOffSetLaserOnProd
        '
        Me.TextBoxOffSetLaserOnProd.Location = New System.Drawing.Point(6, 16)
        Me.TextBoxOffSetLaserOnProd.Name = "TextBoxOffSetLaserOnProd"
        Me.TextBoxOffSetLaserOnProd.Size = New System.Drawing.Size(228, 20)
        Me.TextBoxOffSetLaserOnProd.TabIndex = 2
        '
        'GroupBoxVertOffSet
        '
        Me.GroupBoxVertOffSet.Controls.Add(Me.TextBoxMountOffSetVertical)
        Me.GroupBoxVertOffSet.Location = New System.Drawing.Point(10, 67)
        Me.GroupBoxVertOffSet.Name = "GroupBoxVertOffSet"
        Me.GroupBoxVertOffSet.Size = New System.Drawing.Size(246, 42)
        Me.GroupBoxVertOffSet.TabIndex = 6
        Me.GroupBoxVertOffSet.TabStop = False
        Me.GroupBoxVertOffSet.Text = "MountOffSetVertical"
        '
        'TextBoxMountOffSetVertical
        '
        Me.TextBoxMountOffSetVertical.Location = New System.Drawing.Point(6, 15)
        Me.TextBoxMountOffSetVertical.Name = "TextBoxMountOffSetVertical"
        Me.TextBoxMountOffSetVertical.Size = New System.Drawing.Size(228, 20)
        Me.TextBoxMountOffSetVertical.TabIndex = 2
        '
        'ButtonEditModels
        '
        Me.ButtonEditModels.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditModels.Location = New System.Drawing.Point(570, 807)
        Me.ButtonEditModels.Name = "ButtonEditModels"
        Me.ButtonEditModels.Size = New System.Drawing.Size(143, 65)
        Me.ButtonEditModels.TabIndex = 7
        Me.ButtonEditModels.Text = "Edit Models"
        Me.ButtonEditModels.UseVisualStyleBackColor = True
        '
        'GroupBoxSetValue
        '
        Me.GroupBoxSetValue.Controls.Add(Me.GroupBox14)
        Me.GroupBoxSetValue.Controls.Add(Me.GroupBox10)
        Me.GroupBoxSetValue.Controls.Add(Me.GroupBox9)
        Me.GroupBoxSetValue.Controls.Add(Me.GroupBox3)
        Me.GroupBoxSetValue.Controls.Add(Me.GroupBox7)
        Me.GroupBoxSetValue.Controls.Add(Me.GroupBoxTolHorz)
        Me.GroupBoxSetValue.Controls.Add(Me.GroupBoxTolVert)
        Me.GroupBoxSetValue.Controls.Add(Me.GroupBox4)
        Me.GroupBoxSetValue.Controls.Add(Me.GroupBoxHorzOffSet)
        Me.GroupBoxSetValue.Controls.Add(Me.GroupBoxVertOffSet)
        Me.GroupBoxSetValue.Location = New System.Drawing.Point(9, 347)
        Me.GroupBoxSetValue.Name = "GroupBoxSetValue"
        Me.GroupBoxSetValue.Size = New System.Drawing.Size(262, 585)
        Me.GroupBoxSetValue.TabIndex = 11
        Me.GroupBoxSetValue.TabStop = False
        Me.GroupBoxSetValue.Text = "Set Values"
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.TextBoxTolDropDif)
        Me.GroupBox14.Location = New System.Drawing.Point(10, 471)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(246, 47)
        Me.GroupBox14.TabIndex = 19
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Tolerance Drop difference"
        '
        'TextBoxTolDropDif
        '
        Me.TextBoxTolDropDif.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxTolDropDif.Name = "TextBoxTolDropDif"
        Me.TextBoxTolDropDif.Size = New System.Drawing.Size(228, 20)
        Me.TextBoxTolDropDif.TabIndex = 2
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.TextBoxTolDropMinus)
        Me.GroupBox10.Location = New System.Drawing.Point(11, 418)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(246, 47)
        Me.GroupBox10.TabIndex = 18
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Tolerance Drop Minus"
        '
        'TextBoxTolDropMinus
        '
        Me.TextBoxTolDropMinus.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxTolDropMinus.Name = "TextBoxTolDropMinus"
        Me.TextBoxTolDropMinus.Size = New System.Drawing.Size(228, 20)
        Me.TextBoxTolDropMinus.TabIndex = 2
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.TextBoxTolWidthMinus)
        Me.GroupBox9.Location = New System.Drawing.Point(10, 317)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(246, 47)
        Me.GroupBox9.TabIndex = 18
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Tolerance Width Minus"
        '
        'TextBoxTolWidthMinus
        '
        Me.TextBoxTolWidthMinus.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxTolWidthMinus.Name = "TextBoxTolWidthMinus"
        Me.TextBoxTolWidthMinus.Size = New System.Drawing.Size(228, 20)
        Me.TextBoxTolWidthMinus.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBoxPrefMeasDist)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 165)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(246, 42)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PreferredMeasureDist"
        '
        'TextBoxPrefMeasDist
        '
        Me.TextBoxPrefMeasDist.Location = New System.Drawing.Point(6, 15)
        Me.TextBoxPrefMeasDist.Name = "TextBoxPrefMeasDist"
        Me.TextBoxPrefMeasDist.Size = New System.Drawing.Size(228, 20)
        Me.TextBoxPrefMeasDist.TabIndex = 2
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TextBoxBottombarradius)
        Me.GroupBox7.Location = New System.Drawing.Point(10, 119)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(246, 42)
        Me.GroupBox7.TabIndex = 12
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "BottomBarRadius"
        '
        'TextBoxBottombarradius
        '
        Me.TextBoxBottombarradius.Location = New System.Drawing.Point(6, 15)
        Me.TextBoxBottombarradius.Name = "TextBoxBottombarradius"
        Me.TextBoxBottombarradius.Size = New System.Drawing.Size(228, 20)
        Me.TextBoxBottombarradius.TabIndex = 2
        '
        'GroupBoxTolHorz
        '
        Me.GroupBoxTolHorz.Controls.Add(Me.TextBoxTolWidthPlus)
        Me.GroupBoxTolHorz.Location = New System.Drawing.Point(10, 267)
        Me.GroupBoxTolHorz.Name = "GroupBoxTolHorz"
        Me.GroupBoxTolHorz.Size = New System.Drawing.Size(246, 47)
        Me.GroupBoxTolHorz.TabIndex = 11
        Me.GroupBoxTolHorz.TabStop = False
        Me.GroupBoxTolHorz.Text = "Tolerance Width Plus"
        '
        'TextBoxTolWidthPlus
        '
        Me.TextBoxTolWidthPlus.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxTolWidthPlus.Name = "TextBoxTolWidthPlus"
        Me.TextBoxTolWidthPlus.Size = New System.Drawing.Size(228, 20)
        Me.TextBoxTolWidthPlus.TabIndex = 2
        '
        'GroupBoxTolVert
        '
        Me.GroupBoxTolVert.Controls.Add(Me.TextBoxTolDropPlus)
        Me.GroupBoxTolVert.Location = New System.Drawing.Point(11, 368)
        Me.GroupBoxTolVert.Name = "GroupBoxTolVert"
        Me.GroupBoxTolVert.Size = New System.Drawing.Size(246, 47)
        Me.GroupBoxTolVert.TabIndex = 10
        Me.GroupBoxTolVert.TabStop = False
        Me.GroupBoxTolVert.Text = "Tolerance Drop Plus"
        '
        'TextBoxTolDropPlus
        '
        Me.TextBoxTolDropPlus.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxTolDropPlus.Name = "TextBoxTolDropPlus"
        Me.TextBoxTolDropPlus.Size = New System.Drawing.Size(228, 20)
        Me.TextBoxTolDropPlus.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBoxLaserCalib)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 213)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(246, 47)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "LaserCalibrationValue"
        '
        'TextBoxLaserCalib
        '
        Me.TextBoxLaserCalib.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxLaserCalib.Name = "TextBoxLaserCalib"
        Me.TextBoxLaserCalib.Size = New System.Drawing.Size(228, 20)
        Me.TextBoxLaserCalib.TabIndex = 2
        '
        'ButtonExit
        '
        Me.ButtonExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.Location = New System.Drawing.Point(1118, 548)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(153, 65)
        Me.ButtonExit.TabIndex = 13
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'TextBoxActions
        '
        Me.TextBoxActions.Font = New System.Drawing.Font("Arial Narrow", 36.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxActions.ForeColor = System.Drawing.Color.DarkRed
        Me.TextBoxActions.Location = New System.Drawing.Point(791, 639)
        Me.TextBoxActions.Multiline = True
        Me.TextBoxActions.Name = "TextBoxActions"
        Me.TextBoxActions.Size = New System.Drawing.Size(480, 194)
        Me.TextBoxActions.TabIndex = 14
        '
        'TextBoxCycleStat
        '
        Me.TextBoxCycleStat.Location = New System.Drawing.Point(593, 903)
        Me.TextBoxCycleStat.Name = "TextBoxCycleStat"
        Me.TextBoxCycleStat.Size = New System.Drawing.Size(90, 20)
        Me.TextBoxCycleStat.TabIndex = 15
        '
        'ButtonContDropMeasure
        '
        Me.ButtonContDropMeasure.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonContDropMeasure.Location = New System.Drawing.Point(787, 550)
        Me.ButtonContDropMeasure.Name = "ButtonContDropMeasure"
        Me.ButtonContDropMeasure.Size = New System.Drawing.Size(153, 64)
        Me.ButtonContDropMeasure.TabIndex = 17
        Me.ButtonContDropMeasure.Text = "Continous drop m."
        Me.ButtonContDropMeasure.UseVisualStyleBackColor = True
        '
        'ButtonFullMeasurement
        '
        Me.ButtonFullMeasurement.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFullMeasurement.Location = New System.Drawing.Point(953, 549)
        Me.ButtonFullMeasurement.Name = "ButtonFullMeasurement"
        Me.ButtonFullMeasurement.Size = New System.Drawing.Size(153, 64)
        Me.ButtonFullMeasurement.TabIndex = 23
        Me.ButtonFullMeasurement.Text = "Full measurement"
        Me.ButtonFullMeasurement.UseVisualStyleBackColor = True
        '
        'TextBoxLaserErr
        '
        Me.TextBoxLaserErr.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLaserErr.ForeColor = System.Drawing.Color.Red
        Me.TextBoxLaserErr.Location = New System.Drawing.Point(277, 576)
        Me.TextBoxLaserErr.Name = "TextBoxLaserErr"
        Me.TextBoxLaserErr.Size = New System.Drawing.Size(994, 38)
        Me.TextBoxLaserErr.TabIndex = 24
        '
        'NButton
        '
        Me.NButton.Location = New System.Drawing.Point(791, 839)
        Me.NButton.Name = "NButton"
        Me.NButton.Size = New System.Drawing.Size(484, 92)
        Me.NButton.TabIndex = 25
        '
        'GoodBadDropEnd
        '
        Me.GoodBadDropEnd.GBText = "DELTA Drop End"
        Me.GoodBadDropEnd.Location = New System.Drawing.Point(449, 321)
        Me.GoodBadDropEnd.Name = "GoodBadDropEnd"
        Me.GoodBadDropEnd.Size = New System.Drawing.Size(375, 209)
        Me.GoodBadDropEnd.TabIndex = 22
        '
        'GoodBadW
        '
        Me.GoodBadW.GBText = "Width"
        Me.GoodBadW.Location = New System.Drawing.Point(902, 322)
        Me.GoodBadW.Name = "GoodBadW"
        Me.GoodBadW.Size = New System.Drawing.Size(374, 208)
        Me.GoodBadW.TabIndex = 21
        '
        'GoodBadC
        '
        Me.GoodBadC.GBText = "Drop C"
        Me.GoodBadC.Location = New System.Drawing.Point(9, 12)
        Me.GoodBadC.Name = "GoodBadC"
        Me.GoodBadC.Size = New System.Drawing.Size(375, 311)
        Me.GoodBadC.TabIndex = 20
        '
        'GoodBadB
        '
        Me.GoodBadB.GBText = "Drop B"
        Me.GoodBadB.Location = New System.Drawing.Point(448, 12)
        Me.GoodBadB.Name = "GoodBadB"
        Me.GoodBadB.Size = New System.Drawing.Size(376, 311)
        Me.GoodBadB.TabIndex = 19
        '
        'GoodBadA
        '
        Me.GoodBadA.GBText = "Drop A"
        Me.GoodBadA.Location = New System.Drawing.Point(902, 12)
        Me.GoodBadA.Name = "GoodBadA"
        Me.GoodBadA.Size = New System.Drawing.Size(373, 311)
        Me.GoodBadA.TabIndex = 18
        '
        'TextBoxLog
        '
        Me.TextBoxLog.Location = New System.Drawing.Point(335, 366)
        Me.TextBoxLog.Multiline = True
        Me.TextBoxLog.Name = "TextBoxLog"
        Me.TextBoxLog.Size = New System.Drawing.Size(100, 83)
        Me.TextBoxLog.TabIndex = 26
        '
        'TextBoxCnt
        '
        Me.TextBoxCnt.Location = New System.Drawing.Point(335, 464)
        Me.TextBoxCnt.Name = "TextBoxCnt"
        Me.TextBoxCnt.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCnt.TabIndex = 27
        Me.TextBoxCnt.Text = "0"
        '
        'Inspection
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1291, 935)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBoxCnt)
        Me.Controls.Add(Me.TextBoxLog)
        Me.Controls.Add(Me.TextBoxLaserErr)
        Me.Controls.Add(Me.NButton)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonEditModels)
        Me.Controls.Add(Me.ButtonFullMeasurement)
        Me.Controls.Add(Me.ButtonContDropMeasure)
        Me.Controls.Add(Me.GoodBadDropEnd)
        Me.Controls.Add(Me.GoodBadW)
        Me.Controls.Add(Me.GoodBadC)
        Me.Controls.Add(Me.GoodBadB)
        Me.Controls.Add(Me.GoodBadA)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxModel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TextBoxCycleStat)
        Me.Controls.Add(Me.TextBoxActions)
        Me.Controls.Add(Me.GroupBoxSetValue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inspection"
        Me.Text = "Inspection"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBoxModel.ResumeLayout(False)
        Me.GroupBoxModel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBoxHorzOffSet.ResumeLayout(False)
        Me.GroupBoxHorzOffSet.PerformLayout()
        Me.GroupBoxVertOffSet.ResumeLayout(False)
        Me.GroupBoxVertOffSet.PerformLayout()
        Me.GroupBoxSetValue.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBoxTolHorz.ResumeLayout(False)
        Me.GroupBoxTolHorz.PerformLayout()
        Me.GroupBoxTolVert.ResumeLayout(False)
        Me.GroupBoxTolVert.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxModel As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBoxModel As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxWidth As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxDrop As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxHorzOffSet As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxOffSetLaserOnProd As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxVertOffSet As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxMountOffSetVertical As System.Windows.Forms.TextBox
    Friend WithEvents ButtonEditModels As System.Windows.Forms.Button
    Friend WithEvents GroupBoxSetValue As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents TextBoxActions As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCycleStat As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxLaserCalib As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxTolHorz As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxTolWidthPlus As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxTolVert As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxTolDropPlus As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxBottombarradius As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxPrefMeasDist As System.Windows.Forms.TextBox
    Friend WithEvents ButtonContDropMeasure As System.Windows.Forms.Button
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxTolDropMinus As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxTolWidthMinus As System.Windows.Forms.TextBox
    Friend WithEvents GoodBadA As GL_HoistControl.GoodBad
    Friend WithEvents GoodBadB As GL_HoistControl.GoodBad
    Friend WithEvents GoodBadC As GL_HoistControl.GoodBad
    Friend WithEvents GoodBadW As GL_HoistControl.GoodBad
    Friend WithEvents GoodBadDropEnd As GL_HoistControl.GoodBad
    Friend WithEvents TextBoxModel As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxTolDropDif As System.Windows.Forms.TextBox
    Friend WithEvents ButtonFullMeasurement As System.Windows.Forms.Button
    Friend WithEvents TextBoxLaserErr As System.Windows.Forms.TextBox
    Friend WithEvents NButton As GL_HoistControl.NextButtonColor
    Friend WithEvents TextBoxLog As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCnt As System.Windows.Forms.TextBox
End Class
