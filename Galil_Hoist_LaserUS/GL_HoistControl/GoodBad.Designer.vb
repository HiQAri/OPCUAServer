<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GoodBad
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
        Me.TextBoxGoodBad = New System.Windows.Forms.TextBox()
        Me.GroupBoxGoodBad = New System.Windows.Forms.GroupBox()
        Me.TextBoxValue = New System.Windows.Forms.TextBox()
        Me.PictureBoxUpDown = New System.Windows.Forms.PictureBox()
        Me.GroupBoxGoodBad.SuspendLayout()
        CType(Me.PictureBoxUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxGoodBad
        '
        Me.TextBoxGoodBad.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxGoodBad.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxGoodBad.Name = "TextBoxGoodBad"
        Me.TextBoxGoodBad.Size = New System.Drawing.Size(352, 80)
        Me.TextBoxGoodBad.TabIndex = 26
        '
        'GroupBoxGoodBad
        '
        Me.GroupBoxGoodBad.Controls.Add(Me.TextBoxValue)
        Me.GroupBoxGoodBad.Controls.Add(Me.PictureBoxUpDown)
        Me.GroupBoxGoodBad.Controls.Add(Me.TextBoxGoodBad)
        Me.GroupBoxGoodBad.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxGoodBad.Name = "GroupBoxGoodBad"
        Me.GroupBoxGoodBad.Size = New System.Drawing.Size(365, 302)
        Me.GroupBoxGoodBad.TabIndex = 30
        Me.GroupBoxGoodBad.TabStop = False
        Me.GroupBoxGoodBad.Text = "MeasureStatus"
        '
        'TextBoxValue
        '
        Me.TextBoxValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxValue.Location = New System.Drawing.Point(6, 119)
        Me.TextBoxValue.Name = "TextBoxValue"
        Me.TextBoxValue.Size = New System.Drawing.Size(352, 80)
        Me.TextBoxValue.TabIndex = 31
        '
        'PictureBoxUpDown
        '
        Me.PictureBoxUpDown.Image = Global.GL_HoistControl.My.Resources.Resources.Up1
        Me.PictureBoxUpDown.Location = New System.Drawing.Point(139, 205)
        Me.PictureBoxUpDown.Name = "PictureBoxUpDown"
        Me.PictureBoxUpDown.Size = New System.Drawing.Size(83, 85)
        Me.PictureBoxUpDown.TabIndex = 27
        Me.PictureBoxUpDown.TabStop = False
        '
        'GoodBad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBoxGoodBad)
        Me.Name = "GoodBad"
        Me.Size = New System.Drawing.Size(373, 310)
        Me.GroupBoxGoodBad.ResumeLayout(False)
        Me.GroupBoxGoodBad.PerformLayout()
        CType(Me.PictureBoxUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBoxUpDown As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxGoodBad As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxGoodBad As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxValue As System.Windows.Forms.TextBox

End Class
