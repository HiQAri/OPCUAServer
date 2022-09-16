<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NextButtonColor
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.SuspendLayout()
        '
        'nextButton
        '
        Me.nextButton.AutoSize = True
        Me.nextButton.BackColor = System.Drawing.Color.PaleGreen
        Me.nextButton.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextButton.Location = New System.Drawing.Point(0, 3)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(483, 83)
        Me.nextButton.TabIndex = 20
        Me.nextButton.Text = "NEXT"
        Me.nextButton.UseVisualStyleBackColor = False
        '
        'NextButtonColor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.nextButton)
        Me.Name = "NextButtonColor"
        Me.Size = New System.Drawing.Size(486, 90)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nextButton As System.Windows.Forms.Button

End Class
