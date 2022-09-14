<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SystemTest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SystemTest))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TargetPos = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.HomePos = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.NrOfCycles = New System.Windows.Forms.TextBox()
        Me.StartCycle_Btn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CurrentPos = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CmdResetServo = New System.Windows.Forms.Button()
        Me.cmdServo_off = New System.Windows.Forms.Button()
        Me.Homing_Btn = New System.Windows.Forms.Button()
        Me.cmdServo_on = New System.Windows.Forms.Button()
        Me.Man_Up = New System.Windows.Forms.Button()
        Me.Man_Dn = New System.Windows.Forms.Button()
        Me.STOP_MOTION = New System.Windows.Forms.Button()
        Me.Exit_Btn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.TargetPos)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 61)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "                        Target Position                                "
        '
        'TargetPos
        '
        Me.TargetPos.Location = New System.Drawing.Point(67, 26)
        Me.TargetPos.Name = "TargetPos"
        Me.TargetPos.Size = New System.Drawing.Size(183, 26)
        Me.TargetPos.TabIndex = 0
        Me.TargetPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.HomePos)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(31, 265)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(319, 61)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "                        Home Position                                "
        '
        'HomePos
        '
        Me.HomePos.Location = New System.Drawing.Point(67, 26)
        Me.HomePos.Name = "HomePos"
        Me.HomePos.Size = New System.Drawing.Size(183, 26)
        Me.HomePos.TabIndex = 0
        Me.HomePos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.StartCycle_Btn)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 11)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(383, 456)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox5.Controls.Add(Me.NrOfCycles)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(6, 389)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(157, 61)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "           #Cycles                                "
        '
        'NrOfCycles
        '
        Me.NrOfCycles.Location = New System.Drawing.Point(37, 25)
        Me.NrOfCycles.Name = "NrOfCycles"
        Me.NrOfCycles.Size = New System.Drawing.Size(84, 26)
        Me.NrOfCycles.TabIndex = 0
        Me.NrOfCycles.Text = "10"
        Me.NrOfCycles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StartCycle_Btn
        '
        Me.StartCycle_Btn.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartCycle_Btn.Location = New System.Drawing.Point(204, 401)
        Me.StartCycle_Btn.Name = "StartCycle_Btn"
        Me.StartCycle_Btn.Size = New System.Drawing.Size(173, 49)
        Me.StartCycle_Btn.TabIndex = 4
        Me.StartCycle_Btn.Text = "Start Cycle"
        Me.StartCycle_Btn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.CurrentPos)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(31, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(319, 61)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "                        Current Position                                "
        '
        'CurrentPos
        '
        Me.CurrentPos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CurrentPos.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentPos.Location = New System.Drawing.Point(67, 29)
        Me.CurrentPos.Name = "CurrentPos"
        Me.CurrentPos.ReadOnly = True
        Me.CurrentPos.Size = New System.Drawing.Size(183, 29)
        Me.CurrentPos.TabIndex = 4
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CmdResetServo)
        Me.GroupBox6.Controls.Add(Me.cmdServo_off)
        Me.GroupBox6.Controls.Add(Me.Homing_Btn)
        Me.GroupBox6.Controls.Add(Me.cmdServo_on)
        Me.GroupBox6.Controls.Add(Me.Man_Up)
        Me.GroupBox6.Controls.Add(Me.Man_Dn)
        Me.GroupBox6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(439, 15)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(185, 452)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "     Manual Control      "
        '
        'CmdResetServo
        '
        Me.CmdResetServo.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdResetServo.Location = New System.Drawing.Point(6, 392)
        Me.CmdResetServo.Name = "CmdResetServo"
        Me.CmdResetServo.Size = New System.Drawing.Size(173, 54)
        Me.CmdResetServo.TabIndex = 14
        Me.CmdResetServo.Text = "RESET SERVO DRIVE"
        Me.CmdResetServo.UseVisualStyleBackColor = True
        '
        'cmdServo_off
        '
        Me.cmdServo_off.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdServo_off.Location = New System.Drawing.Point(94, 323)
        Me.cmdServo_off.Name = "cmdServo_off"
        Me.cmdServo_off.Size = New System.Drawing.Size(85, 49)
        Me.cmdServo_off.TabIndex = 8
        Me.cmdServo_off.Text = "SERVO OFF"
        Me.cmdServo_off.UseVisualStyleBackColor = True
        '
        'Homing_Btn
        '
        Me.Homing_Btn.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Homing_Btn.Location = New System.Drawing.Point(6, 255)
        Me.Homing_Btn.Name = "Homing_Btn"
        Me.Homing_Btn.Size = New System.Drawing.Size(173, 49)
        Me.Homing_Btn.TabIndex = 6
        Me.Homing_Btn.Text = "Do Homing"
        Me.Homing_Btn.UseVisualStyleBackColor = True
        '
        'cmdServo_on
        '
        Me.cmdServo_on.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdServo_on.Location = New System.Drawing.Point(6, 323)
        Me.cmdServo_on.Name = "cmdServo_on"
        Me.cmdServo_on.Size = New System.Drawing.Size(85, 49)
        Me.cmdServo_on.TabIndex = 7
        Me.cmdServo_on.Text = "SERVO ON"
        Me.cmdServo_on.UseVisualStyleBackColor = True
        '
        'Man_Up
        '
        Me.Man_Up.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Man_Up.BackColor = System.Drawing.SystemColors.Window
        Me.Man_Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Man_Up.Image = CType(resources.GetObject("Man_Up.Image"), System.Drawing.Image)
        Me.Man_Up.Location = New System.Drawing.Point(48, 28)
        Me.Man_Up.Name = "Man_Up"
        Me.Man_Up.Size = New System.Drawing.Size(82, 86)
        Me.Man_Up.TabIndex = 5
        Me.Man_Up.UseVisualStyleBackColor = False
        '
        'Man_Dn
        '
        Me.Man_Dn.Image = CType(resources.GetObject("Man_Dn.Image"), System.Drawing.Image)
        Me.Man_Dn.Location = New System.Drawing.Point(48, 129)
        Me.Man_Dn.Name = "Man_Dn"
        Me.Man_Dn.Size = New System.Drawing.Size(86, 86)
        Me.Man_Dn.TabIndex = 4
        Me.Man_Dn.UseVisualStyleBackColor = True
        '
        'STOP_MOTION
        '
        Me.STOP_MOTION.BackColor = System.Drawing.Color.DarkRed
        Me.STOP_MOTION.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STOP_MOTION.ForeColor = System.Drawing.Color.Gold
        Me.STOP_MOTION.Location = New System.Drawing.Point(715, 20)
        Me.STOP_MOTION.Name = "STOP_MOTION"
        Me.STOP_MOTION.Size = New System.Drawing.Size(89, 381)
        Me.STOP_MOTION.TabIndex = 7
        Me.STOP_MOTION.Text = "STOP "
        Me.STOP_MOTION.UseVisualStyleBackColor = False
        '
        'Exit_Btn
        '
        Me.Exit_Btn.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Btn.Location = New System.Drawing.Point(715, 430)
        Me.Exit_Btn.Name = "Exit_Btn"
        Me.Exit_Btn.Size = New System.Drawing.Size(89, 54)
        Me.Exit_Btn.TabIndex = 8
        Me.Exit_Btn.Text = "Exit"
        Me.Exit_Btn.UseVisualStyleBackColor = True
        '
        'SystemTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 496)
        Me.ControlBox = False
        Me.Controls.Add(Me.Exit_Btn)
        Me.Controls.Add(Me.STOP_MOTION)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SystemTest"
        Me.Text = "SystemTest"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TargetPos As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents HomePos As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents StartCycle_Btn As System.Windows.Forms.Button
    Friend WithEvents Man_Dn As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Homing_Btn As System.Windows.Forms.Button
    Friend WithEvents Man_Up As System.Windows.Forms.Button
    Friend WithEvents STOP_MOTION As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents NrOfCycles As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CurrentPos As System.Windows.Forms.TextBox
    Friend WithEvents cmdServo_off As System.Windows.Forms.Button
    Friend WithEvents cmdServo_on As System.Windows.Forms.Button
    Friend WithEvents CmdResetServo As System.Windows.Forms.Button
    Friend WithEvents Exit_Btn As System.Windows.Forms.Button
End Class
