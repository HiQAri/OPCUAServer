<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Measurement_control_Form
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
        Me.nextButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_InputA2 = New System.Windows.Forms.TextBox()
        Me.TextBox_InputA1 = New System.Windows.Forms.TextBox()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.RichTextBoxUS = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_LaserControlPos = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.DMCPoll1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'nextButton
        '
        Me.nextButton.AutoSize = True
        Me.nextButton.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextButton.Location = New System.Drawing.Point(1028, 853)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(214, 86)
        Me.nextButton.TabIndex = 20
        Me.nextButton.Text = "EXIT"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(174, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 24)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Laser unit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(248, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 24)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Ultra sonic"
        '
        'TextBox_InputA2
        '
        Me.TextBox_InputA2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_InputA2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_InputA2.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_InputA2.Location = New System.Drawing.Point(6, 91)
        Me.TextBox_InputA2.Name = "TextBox_InputA2"
        Me.TextBox_InputA2.ReadOnly = True
        Me.TextBox_InputA2.Size = New System.Drawing.Size(162, 44)
        Me.TextBox_InputA2.TabIndex = 32
        '
        'TextBox_InputA1
        '
        Me.TextBox_InputA1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_InputA1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_InputA1.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_InputA1.Location = New System.Drawing.Point(6, 19)
        Me.TextBox_InputA1.Name = "TextBox_InputA1"
        Me.TextBox_InputA1.ReadOnly = True
        Me.TextBox_InputA1.Size = New System.Drawing.Size(236, 44)
        Me.TextBox_InputA1.TabIndex = 31
        '
        'BtnStop
        '
        Me.BtnStop.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStop.Location = New System.Drawing.Point(252, 181)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(111, 54)
        Me.BtnStop.TabIndex = 37
        Me.BtnStop.Text = "STOP"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'BtnStart
        '
        Me.BtnStart.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStart.Location = New System.Drawing.Point(252, 77)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(111, 54)
        Me.BtnStart.TabIndex = 35
        Me.BtnStart.Text = "START"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'RichTextBoxUS
        '
        Me.RichTextBoxUS.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxUS.Location = New System.Drawing.Point(6, 68)
        Me.RichTextBoxUS.Name = "RichTextBoxUS"
        Me.RichTextBoxUS.Size = New System.Drawing.Size(236, 622)
        Me.RichTextBoxUS.TabIndex = 36
        Me.RichTextBoxUS.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox_LaserControlPos)
        Me.GroupBox1.Controls.Add(Me.TextBox_InputA2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 682)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Laser unit"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(327, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 55)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "GO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Measure" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 24)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Laser control Position"
        '
        'TextBox_LaserControlPos
        '
        Me.TextBox_LaserControlPos.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_LaserControlPos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_LaserControlPos.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_LaserControlPos.Location = New System.Drawing.Point(6, 19)
        Me.TextBox_LaserControlPos.Name = "TextBox_LaserControlPos"
        Me.TextBox_LaserControlPos.Size = New System.Drawing.Size(162, 44)
        Me.TextBox_LaserControlPos.TabIndex = 35
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnClear)
        Me.GroupBox2.Controls.Add(Me.TextBox_InputA1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.BtnStop)
        Me.GroupBox2.Controls.Add(Me.RichTextBoxUS)
        Me.GroupBox2.Controls.Add(Me.BtnStart)
        Me.GroupBox2.Location = New System.Drawing.Point(513, 147)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(468, 696)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ultrasonic unit"
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(252, 636)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(111, 54)
        Me.BtnClear.TabIndex = 38
        Me.BtnClear.Text = "CLEAR"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'cmdStop
        '
        Me.cmdStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdStop.BackColor = System.Drawing.Color.DarkRed
        Me.cmdStop.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStop.ForeColor = System.Drawing.Color.White
        Me.cmdStop.Location = New System.Drawing.Point(319, 58)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(191, 55)
        Me.cmdStop.TabIndex = 41
        Me.cmdStop.Text = "STOP MOTION"
        Me.cmdStop.UseVisualStyleBackColor = False
        '
        'DMCPoll1
        '
        Me.DMCPoll1.BackColor = System.Drawing.SystemColors.Window
        Me.DMCPoll1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DMCPoll1.Font = New System.Drawing.Font("Arial Narrow", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DMCPoll1.Location = New System.Drawing.Point(12, 60)
        Me.DMCPoll1.Name = "DMCPoll1"
        Me.DMCPoll1.ReadOnly = True
        Me.DMCPoll1.Size = New System.Drawing.Size(301, 50)
        Me.DMCPoll1.TabIndex = 40
        '
        'Measurement_control_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 951)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.DMCPoll1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.nextButton)
        Me.Name = "Measurement_control_Form"
        Me.Text = "Measurement_control_Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nextButton As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_InputA2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_InputA1 As System.Windows.Forms.TextBox
    Friend WithEvents BtnStop As System.Windows.Forms.Button
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents RichTextBoxUS As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_LaserControlPos As System.Windows.Forms.TextBox
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents DMCPoll1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
