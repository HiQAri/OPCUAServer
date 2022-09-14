<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParamFiles
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonOpenParamFile = New System.Windows.Forms.Button()
        Me.ButtonSaveParamfile = New System.Windows.Forms.Button()
        Me.OpenFileDialogParams = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBoxParamFile = New System.Windows.Forms.GroupBox()
        Me.Exit_Btn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxParamFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(272, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(801, 584)
        Me.DataGridView1.TabIndex = 0
        '
        'ButtonOpenParamFile
        '
        Me.ButtonOpenParamFile.Enabled = False
        Me.ButtonOpenParamFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOpenParamFile.Location = New System.Drawing.Point(0, 150)
        Me.ButtonOpenParamFile.Name = "ButtonOpenParamFile"
        Me.ButtonOpenParamFile.Size = New System.Drawing.Size(237, 117)
        Me.ButtonOpenParamFile.TabIndex = 1
        Me.ButtonOpenParamFile.Text = "open Parameter file"
        Me.ButtonOpenParamFile.UseVisualStyleBackColor = True
        Me.ButtonOpenParamFile.Visible = False
        '
        'ButtonSaveParamfile
        '
        Me.ButtonSaveParamfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveParamfile.Location = New System.Drawing.Point(0, 19)
        Me.ButtonSaveParamfile.Name = "ButtonSaveParamfile"
        Me.ButtonSaveParamfile.Size = New System.Drawing.Size(237, 113)
        Me.ButtonSaveParamfile.TabIndex = 2
        Me.ButtonSaveParamfile.Text = "save parameter file"
        Me.ButtonSaveParamfile.UseVisualStyleBackColor = True
        '
        'OpenFileDialogParams
        '
        Me.OpenFileDialogParams.DefaultExt = "*.xlsx"
        Me.OpenFileDialogParams.Filter = "paramfile(*.xlsx)|*.xlsx"
        Me.OpenFileDialogParams.InitialDirectory = "../ParamFiles/"
        '
        'GroupBoxParamFile
        '
        Me.GroupBoxParamFile.Controls.Add(Me.Exit_Btn)
        Me.GroupBoxParamFile.Controls.Add(Me.DataGridView1)
        Me.GroupBoxParamFile.Controls.Add(Me.ButtonSaveParamfile)
        Me.GroupBoxParamFile.Controls.Add(Me.ButtonOpenParamFile)
        Me.GroupBoxParamFile.Location = New System.Drawing.Point(26, 12)
        Me.GroupBoxParamFile.Name = "GroupBoxParamFile"
        Me.GroupBoxParamFile.Size = New System.Drawing.Size(1079, 620)
        Me.GroupBoxParamFile.TabIndex = 3
        Me.GroupBoxParamFile.TabStop = False
        Me.GroupBoxParamFile.Text = "Paramfile"
        '
        'Exit_Btn
        '
        Me.Exit_Btn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Btn.Location = New System.Drawing.Point(0, 568)
        Me.Exit_Btn.Name = "Exit_Btn"
        Me.Exit_Btn.Size = New System.Drawing.Size(95, 52)
        Me.Exit_Btn.TabIndex = 26
        Me.Exit_Btn.Text = "exit"
        Me.Exit_Btn.UseVisualStyleBackColor = True
        '
        'ParamFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 644)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBoxParamFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ParamFiles"
        Me.Text = "Paramfiles"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxParamFile.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonOpenParamFile As System.Windows.Forms.Button
    Friend WithEvents ButtonSaveParamfile As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialogParams As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBoxParamFile As System.Windows.Forms.GroupBox
    Friend WithEvents Exit_Btn As System.Windows.Forms.Button

End Class
