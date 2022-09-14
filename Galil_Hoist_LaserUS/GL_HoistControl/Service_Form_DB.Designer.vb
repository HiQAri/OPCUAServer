<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Service_Form_DB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Service_Form_DB))
        Me.Exit_Btn = New System.Windows.Forms.Button()
        Me.SystemTST_btn = New System.Windows.Forms.Button()
        Me.Exit_Service_btn = New System.Windows.Forms.Button()
        Me.ButtonMeasurementTest = New System.Windows.Forms.Button()
        Me.DataGridViewSettings = New System.Windows.Forms.DataGridView()
        Me.ButtonSaveSpeed = New System.Windows.Forms.Button()
        Me.GroupBoxSettings = New System.Windows.Forms.GroupBox()
        Me.ButtonEditSpeedSetting = New System.Windows.Forms.Button()
        Me.ButtonUploadGalilValues = New System.Windows.Forms.Button()
        Me.ButtonModelFiles = New System.Windows.Forms.Button()
        CType(Me.DataGridViewSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'Exit_Btn
        '
        Me.Exit_Btn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Btn.Location = New System.Drawing.Point(838, 690)
        Me.Exit_Btn.Name = "Exit_Btn"
        Me.Exit_Btn.Size = New System.Drawing.Size(95, 52)
        Me.Exit_Btn.TabIndex = 25
        Me.Exit_Btn.Text = "Main screen"
        Me.Exit_Btn.UseVisualStyleBackColor = True
        '
        'SystemTST_btn
        '
        Me.SystemTST_btn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemTST_btn.Location = New System.Drawing.Point(838, 31)
        Me.SystemTST_btn.Name = "SystemTST_btn"
        Me.SystemTST_btn.Size = New System.Drawing.Size(95, 52)
        Me.SystemTST_btn.TabIndex = 26
        Me.SystemTST_btn.Text = "System test"
        Me.SystemTST_btn.UseVisualStyleBackColor = True
        '
        'Exit_Service_btn
        '
        Me.Exit_Service_btn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Service_btn.Location = New System.Drawing.Point(838, 752)
        Me.Exit_Service_btn.Name = "Exit_Service_btn"
        Me.Exit_Service_btn.Size = New System.Drawing.Size(95, 52)
        Me.Exit_Service_btn.TabIndex = 27
        Me.Exit_Service_btn.Text = "Exit"
        Me.Exit_Service_btn.UseVisualStyleBackColor = True
        '
        'ButtonMeasurementTest
        '
        Me.ButtonMeasurementTest.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMeasurementTest.Location = New System.Drawing.Point(838, 113)
        Me.ButtonMeasurementTest.Name = "ButtonMeasurementTest"
        Me.ButtonMeasurementTest.Size = New System.Drawing.Size(95, 52)
        Me.ButtonMeasurementTest.TabIndex = 28
        Me.ButtonMeasurementTest.Text = "Measure test"
        Me.ButtonMeasurementTest.UseVisualStyleBackColor = True
        '
        'DataGridViewSettings
        '
        Me.DataGridViewSettings.AllowUserToAddRows = False
        Me.DataGridViewSettings.AllowUserToDeleteRows = False
        Me.DataGridViewSettings.AllowUserToResizeRows = False
        Me.DataGridViewSettings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSettings.Location = New System.Drawing.Point(6, 19)
        Me.DataGridViewSettings.MultiSelect = False
        Me.DataGridViewSettings.Name = "DataGridViewSettings"
        Me.DataGridViewSettings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridViewSettings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewSettings.Size = New System.Drawing.Size(808, 692)
        Me.DataGridViewSettings.TabIndex = 29
        '
        'ButtonSaveSpeed
        '
        Me.ButtonSaveSpeed.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveSpeed.Location = New System.Drawing.Point(6, 717)
        Me.ButtonSaveSpeed.Name = "ButtonSaveSpeed"
        Me.ButtonSaveSpeed.Size = New System.Drawing.Size(95, 52)
        Me.ButtonSaveSpeed.TabIndex = 30
        Me.ButtonSaveSpeed.Text = "Save"
        Me.ButtonSaveSpeed.UseVisualStyleBackColor = True
        '
        'GroupBoxSettings
        '
        Me.GroupBoxSettings.Controls.Add(Me.ButtonEditSpeedSetting)
        Me.GroupBoxSettings.Controls.Add(Me.DataGridViewSettings)
        Me.GroupBoxSettings.Controls.Add(Me.ButtonSaveSpeed)
        Me.GroupBoxSettings.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxSettings.Name = "GroupBoxSettings"
        Me.GroupBoxSettings.Size = New System.Drawing.Size(820, 784)
        Me.GroupBoxSettings.TabIndex = 31
        Me.GroupBoxSettings.TabStop = False
        Me.GroupBoxSettings.Text = "Settings"
        '
        'ButtonEditSpeedSetting
        '
        Me.ButtonEditSpeedSetting.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditSpeedSetting.Location = New System.Drawing.Point(107, 717)
        Me.ButtonEditSpeedSetting.Name = "ButtonEditSpeedSetting"
        Me.ButtonEditSpeedSetting.Size = New System.Drawing.Size(95, 52)
        Me.ButtonEditSpeedSetting.TabIndex = 34
        Me.ButtonEditSpeedSetting.Text = "Edit"
        Me.ButtonEditSpeedSetting.UseVisualStyleBackColor = True
        '
        'ButtonUploadGalilValues
        '
        Me.ButtonUploadGalilValues.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUploadGalilValues.Location = New System.Drawing.Point(838, 214)
        Me.ButtonUploadGalilValues.Name = "ButtonUploadGalilValues"
        Me.ButtonUploadGalilValues.Size = New System.Drawing.Size(95, 52)
        Me.ButtonUploadGalilValues.TabIndex = 34
        Me.ButtonUploadGalilValues.Text = "Upload GalilValues"
        Me.ButtonUploadGalilValues.UseVisualStyleBackColor = True
        '
        'ButtonModelFiles
        '
        Me.ButtonModelFiles.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModelFiles.Location = New System.Drawing.Point(838, 489)
        Me.ButtonModelFiles.Name = "ButtonModelFiles"
        Me.ButtonModelFiles.Size = New System.Drawing.Size(95, 52)
        Me.ButtonModelFiles.TabIndex = 36
        Me.ButtonModelFiles.Text = "Model Files"
        Me.ButtonModelFiles.UseVisualStyleBackColor = True
        '
        'Service_Form_DB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 817)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonModelFiles)
        Me.Controls.Add(Me.ButtonUploadGalilValues)
        Me.Controls.Add(Me.GroupBoxSettings)
        Me.Controls.Add(Me.ButtonMeasurementTest)
        Me.Controls.Add(Me.Exit_Service_btn)
        Me.Controls.Add(Me.SystemTST_btn)
        Me.Controls.Add(Me.Exit_Btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Service_Form_DB"
        Me.Text = "Service_Form"
        CType(Me.DataGridViewSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxSettings.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Exit_Btn As System.Windows.Forms.Button
    Friend WithEvents SystemTST_btn As System.Windows.Forms.Button
    Friend WithEvents Exit_Service_btn As System.Windows.Forms.Button
    Friend WithEvents ButtonMeasurementTest As System.Windows.Forms.Button


    Friend WithEvents IndexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ParamNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ParamValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewSettings As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonSaveSpeed As System.Windows.Forms.Button
    Friend WithEvents GroupBoxSettings As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonEditSpeedSetting As System.Windows.Forms.Button
    Friend WithEvents ButtonUploadGalilValues As System.Windows.Forms.Button
    Friend WithEvents ButtonModelFiles As System.Windows.Forms.Button

End Class
