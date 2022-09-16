<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTest
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
        Me.GoodBadW = New GL_HoistControl.GoodBad()
        Me.GoodBadC = New GL_HoistControl.GoodBad()
        Me.GoodBadB = New GL_HoistControl.GoodBad()
        Me.GoodBadA = New GL_HoistControl.GoodBad()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GoodBadW
        '
        Me.GoodBadW.GBText = "Width"
        Me.GoodBadW.Location = New System.Drawing.Point(42, 399)
        Me.GoodBadW.Name = "GoodBadW"
        Me.GoodBadW.Size = New System.Drawing.Size(492, 126)
        Me.GoodBadW.TabIndex = 25
        '
        'GoodBadC
        '
        Me.GoodBadC.GBText = "Drop C"
        Me.GoodBadC.Location = New System.Drawing.Point(42, 274)
        Me.GoodBadC.Name = "GoodBadC"
        Me.GoodBadC.Size = New System.Drawing.Size(492, 126)
        Me.GoodBadC.TabIndex = 24
        '
        'GoodBadB
        '
        Me.GoodBadB.GBText = "Drop B"
        Me.GoodBadB.Location = New System.Drawing.Point(42, 141)
        Me.GoodBadB.Name = "GoodBadB"
        Me.GoodBadB.Size = New System.Drawing.Size(492, 127)
        Me.GoodBadB.TabIndex = 23
        '
        'GoodBadA
        '
        Me.GoodBadA.GBText = "Drop A"
        Me.GoodBadA.Location = New System.Drawing.Point(42, 12)
        Me.GoodBadA.Name = "GoodBadA"
        Me.GoodBadA.Size = New System.Drawing.Size(492, 123)
        Me.GoodBadA.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(774, 234)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 547)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GoodBadW)
        Me.Controls.Add(Me.GoodBadC)
        Me.Controls.Add(Me.GoodBadB)
        Me.Controls.Add(Me.GoodBadA)
        Me.Name = "FormTest"
        Me.Text = "FormTest"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GoodBadW As GL_HoistControl.GoodBad
    Friend WithEvents GoodBadC As GL_HoistControl.GoodBad
    Friend WithEvents GoodBadB As GL_HoistControl.GoodBad
    Friend WithEvents GoodBadA As GL_HoistControl.GoodBad
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
