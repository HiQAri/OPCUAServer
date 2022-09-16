<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModelFiles
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
        Me.ButtonOpenModelFile = New System.Windows.Forms.Button()
        Me.ButtonSaveModelfile = New System.Windows.Forms.Button()
        Me.OpenFileDialogModel = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBoxModelFile = New System.Windows.Forms.GroupBox()
        Me.Exit_Btn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxModelFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(272, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(246, 470)
        Me.DataGridView1.TabIndex = 0
        '
        'ButtonOpenModelFile
        '
        Me.ButtonOpenModelFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOpenModelFile.Location = New System.Drawing.Point(6, 19)
        Me.ButtonOpenModelFile.Name = "ButtonOpenModelFile"
        Me.ButtonOpenModelFile.Size = New System.Drawing.Size(237, 117)
        Me.ButtonOpenModelFile.TabIndex = 1
        Me.ButtonOpenModelFile.Text = "open model file"
        Me.ButtonOpenModelFile.UseVisualStyleBackColor = True
        '
        'ButtonSaveModelfile
        '
        Me.ButtonSaveModelfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveModelfile.Location = New System.Drawing.Point(6, 184)
        Me.ButtonSaveModelfile.Name = "ButtonSaveModelfile"
        Me.ButtonSaveModelfile.Size = New System.Drawing.Size(237, 113)
        Me.ButtonSaveModelfile.TabIndex = 2
        Me.ButtonSaveModelfile.Text = "save model file"
        Me.ButtonSaveModelfile.UseVisualStyleBackColor = True
        '
        'OpenFileDialogModel
        '
        Me.OpenFileDialogModel.DefaultExt = "*.xlsx"
        Me.OpenFileDialogModel.Filter = "modelfile(*.xlsx)|*.xlsx"
        Me.OpenFileDialogModel.InitialDirectory = "../modelfiles/"
        '
        'GroupBoxModelFile
        '
        Me.GroupBoxModelFile.Controls.Add(Me.Exit_Btn)
        Me.GroupBoxModelFile.Controls.Add(Me.DataGridView1)
        Me.GroupBoxModelFile.Controls.Add(Me.ButtonSaveModelfile)
        Me.GroupBoxModelFile.Controls.Add(Me.ButtonOpenModelFile)
        Me.GroupBoxModelFile.Location = New System.Drawing.Point(26, 12)
        Me.GroupBoxModelFile.Name = "GroupBoxModelFile"
        Me.GroupBoxModelFile.Size = New System.Drawing.Size(544, 509)
        Me.GroupBoxModelFile.TabIndex = 3
        Me.GroupBoxModelFile.TabStop = False
        Me.GroupBoxModelFile.Text = "modelfile"
        '
        'Exit_Btn
        '
        Me.Exit_Btn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Btn.Location = New System.Drawing.Point(0, 457)
        Me.Exit_Btn.Name = "Exit_Btn"
        Me.Exit_Btn.Size = New System.Drawing.Size(95, 52)
        Me.Exit_Btn.TabIndex = 26
        Me.Exit_Btn.Text = "exit"
        Me.Exit_Btn.UseVisualStyleBackColor = True
        '
        'ModelFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 533)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBoxModelFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ModelFiles"
        Me.Text = "Modelfiles"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxModelFile.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonOpenModelFile As System.Windows.Forms.Button
    Friend WithEvents ButtonSaveModelfile As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialogModel As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBoxModelFile As System.Windows.Forms.GroupBox
    Friend WithEvents Exit_Btn As System.Windows.Forms.Button

End Class
