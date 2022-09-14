Imports System.Data.OleDb

Public Class ModelFiles
    Public Structure tModelDat   ' info from modelfiles
        Dim Drop As Double
        Dim Width As Double
        Dim MeasureWidth As Double
        Dim MeasureDrop As Double
        Dim MeasureSquareness As Double
        Dim HasCords As Double
        Dim MountOffSetVert As Double
        Dim OffsetLaserOnProd As Double
        Dim ToleranceWidthPlus As Double
        Dim ToleranceDropPlus As Double
        Dim ToleranceWidthMinus As Double
        Dim ToleranceDropMinus As Double
        Dim ToleranceDropDiff As Double
        Dim BottomBarRadius As Double
        Dim PrefMeasDist As Double
        Dim Endcapcompensation As Double
    End Structure

    Dim ModelFileName As String = "testFile"
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=..\model1.xlsx ;" & "Extended Properties=Excel 12.0;"
    Dim ModelDataAdapter As New OleDbDataAdapter("SELECT * FROM [Sheet1$]", connectionString)
    Dim ModeldataCommandbuilder As OleDbCommandBuilder = New OleDbCommandBuilder(ModelDataAdapter)
    Dim ModelData As New DataSet()

    Private Function MakeUpdatecommand() As Boolean
        ModelDataAdapter.UpdateCommand = New OleDbCommand("UPDATE [Sheet1$] SET ParameterName = ?, ParameterValue = ? WHERE ParameterName = ? AND ParameterValue = ? ")
        ModelDataAdapter.UpdateCommand.Parameters.Add("@ParameterName", OleDbType.Char, 255).SourceColumn = "ParameterName"
        ModelDataAdapter.UpdateCommand.Parameters.Add("@ParameterValue", OleDbType.Char, 255).SourceColumn = "ParameterValue"
        ' For Updates, we need to provide the old values so that we only update the corresponding row.
        ModelDataAdapter.UpdateCommand.Parameters.Add("@OldParameterName", OleDbType.Char, 255, "ParameterName").SourceVersion = DataRowVersion.Original
        ModelDataAdapter.UpdateCommand.Parameters.Add("@OldParameterValue", OleDbType.Char, 255, "ParameterValue").SourceVersion = DataRowVersion.Original
        Return (True)
    End Function


    Private Sub ButtonOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOpenModelFile.Click
        Dim result As DialogResult = OpenFileDialogModel.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Try
                OpenModelFile(OpenFileDialogModel.FileName, DataGridView1)
                GroupBoxModelFile.Text = OpenFileDialogModel.FileName
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub


    Private Function OpenModelFile(ByVal aName As String, ByRef GridView As DataGridView)
        ModelFileName = aName
        connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source= " & ModelFileName & " ;" & "Extended Properties=Excel 12.0;"
        ModelDataAdapter = New OleDbDataAdapter("SELECT * FROM [Sheet1$]", connectionString)
        ModelDataAdapter.TableMappings.Add("Table", "ExcelSheet")
        ModelData.Clear()
        ModelDataAdapter.Fill(ModelData)

        GridView.DataSource = vbNull ' empty the grid 
        GridView.Refresh()
       


        GridView.DataSource = ModelData.Tables(0)
        For i = 0 To GridView.Columns.Count - 1
            GridView.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        GridView.Columns(0).ReadOnly = True
        GridView.Columns(1).ReadOnly = False


        Me.Refresh()

        ModeldataCommandbuilder = New OleDbCommandBuilder(ModelDataAdapter) ' for when we need to update the excelsheet

        Return True
    End Function

    Public Function OpenReadModelFile(ByVal aName As String, ByRef aModelDatSet As tModelDat) As Boolean
        Dim Ok = True
        ModelFileName = aName
        connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source= " & ModelFileName & " ;" & "Extended Properties=Excel 12.0;"
        ModelDataAdapter = New OleDbDataAdapter("SELECT * FROM [Sheet1$]", connectionString)
        ModelDataAdapter.TableMappings.Add("Table", "ExcelSheet")
        ModelData.Clear()
        ModelDataAdapter.Fill(ModelData)
        Dim FoundOK As Boolean = False

        Dim i As Integer = 0
        '/////////////////////
        For i = 0 To ModelData.Tables(0).Rows.Count - 1
            If (ModelData.Tables(0).Rows(i)("ParameterName").Equals("MountOffSetVert")) Then
                FoundOK = True
                Exit For
            End If
        Next

        If (FoundOK) Then
            aModelDatSet.MountOffSetVert = ModelData.Tables(0).Rows(i)("ParameterValue")
        Else
            Ok = False
            aModelDatSet.MountOffSetVert = 0
            MsgBox("ModelParam " + "MountOffSetVert" + " not found")
        End If
        '/////////////////////

        i = 0
        FoundOK = False
        For i = 0 To ModelData.Tables(0).Rows.Count - 1
            If (ModelData.Tables(0).Rows(i)("ParameterName").Equals("OffsetLaserOnProd")) Then
                FoundOK = True
                Exit For
            End If
        Next

        If (FoundOK) Then
            aModelDatSet.OffsetLaserOnProd = ModelData.Tables(0).Rows(i)("ParameterValue")
        Else
            Ok = False
            aModelDatSet.OffsetLaserOnProd = 0
            MsgBox("ModelParam " + "OffsetLaserOnProd" + " not found")
        End If
        '/////////////////////
        i = 0
        FoundOK = False
        For i = 0 To ModelData.Tables(0).Rows.Count - 1
            If (ModelData.Tables(0).Rows(i)("ParameterName").Equals("BottomBarRadius")) Then
                FoundOK = True
                Exit For
            End If
        Next

        If (FoundOK) Then
            aModelDatSet.BottomBarRadius = ModelData.Tables(0).Rows(i)("ParameterValue")
        Else
            Ok = False
            aModelDatSet.BottomBarRadius = 0
            MsgBox("ModelParam " + "BottomBarRadius" + " not found")
        End If
        '/////////////////////

        i = 0
        FoundOK = False
        For i = 0 To ModelData.Tables(0).Rows.Count - 1
            If (ModelData.Tables(0).Rows(i)("ParameterName").Equals("ToleranceWidthPlus")) Then
                FoundOK = True
                Exit For
            End If
        Next

        If (FoundOK) Then
            aModelDatSet.ToleranceWidthPlus = ModelData.Tables(0).Rows(i)("ParameterValue")
        Else
            Ok = False
            aModelDatSet.ToleranceWidthPlus = 0
            MsgBox("ModelParam " + "ToleranceWidthPlus" + " not found")
        End If
        '/////////////////////
        i = 0
        FoundOK = False
        For i = 0 To ModelData.Tables(0).Rows.Count - 1
            If (ModelData.Tables(0).Rows(i)("ParameterName").Equals("ToleranceWidthMinus")) Then
                FoundOK = True
                Exit For
            End If
        Next

        If (FoundOK) Then
            aModelDatSet.ToleranceWidthMinus = ModelData.Tables(0).Rows(i)("ParameterValue")
        Else
            Ok = False
            aModelDatSet.ToleranceWidthMinus = 0
            MsgBox("ModelParam " + "ToleranceWidthMinus" + " not found")
        End If
        '/////////////////////

        i = 0
        FoundOK = False
        For i = 0 To ModelData.Tables(0).Rows.Count - 1
            If (ModelData.Tables(0).Rows(i)("ParameterName").Equals("ToleranceDropPlus")) Then
                FoundOK = True
                Exit For
            End If
        Next

        If (FoundOK) Then
            aModelDatSet.ToleranceDropPlus = ModelData.Tables(0).Rows(i)("ParameterValue")
        Else
            Ok = False
            aModelDatSet.ToleranceDropPlus = 0
            MsgBox("ModelParam " + "ToleranceDropPlus" + " not found")
        End If

        '/////////////////////

        i = 0
        FoundOK = False
        For i = 0 To ModelData.Tables(0).Rows.Count - 1
            If (ModelData.Tables(0).Rows(i)("ParameterName").Equals("ToleranceDropMinus")) Then
                FoundOK = True
                Exit For
            End If
        Next

        If (FoundOK) Then
            aModelDatSet.ToleranceDropMinus = ModelData.Tables(0).Rows(i)("ParameterValue")
        Else
            Ok = False
            aModelDatSet.ToleranceDropMinus = 0
            MsgBox("ModelParam " + "ToleranceDropMinus" + " not found")
        End If

        '/////////////////////

        i = 0
        FoundOK = False
        For i = 0 To ModelData.Tables(0).Rows.Count - 1
            If (ModelData.Tables(0).Rows(i)("ParameterName").Equals("PrefMeasDist")) Then
                FoundOK = True
                Exit For
            End If
        Next

        If (FoundOK) Then
            aModelDatSet.PrefMeasDist = ModelData.Tables(0).Rows(i)("ParameterValue")
        Else
            Ok = False
            aModelDatSet.PrefMeasDist = 0
            MsgBox("ModelParam " + "PrefMeasDist" + " not found")
        End If
        
        '/////////////////////
        i = 0
        FoundOK = False
        For i = 0 To ModelData.Tables(0).Rows.Count - 1
            If (ModelData.Tables(0).Rows(i)("ParameterName").Equals("Endcapcompensation")) Then
                FoundOK = True
                Exit For
            End If
        Next

        If (FoundOK) Then
            aModelDatSet.Endcapcompensation = ModelData.Tables(0).Rows(i)("ParameterValue")
        Else
            Ok = False
            aModelDatSet.Endcapcompensation = 0
            MsgBox("ModelParam " + "Endcapcompensation" + " not found")
        End If
        '/////////////////////ToleranceDropDiff

        i = 0
        FoundOK = False
        For i = 0 To ModelData.Tables(0).Rows.Count - 1
            If (ModelData.Tables(0).Rows(i)("ParameterName").Equals("ToleranceDropDiff")) Then
                FoundOK = True
                Exit For
            End If
        Next

        If (FoundOK) Then
            aModelDatSet.ToleranceDropDiff = ModelData.Tables(0).Rows(i)("ParameterValue")
        Else
            Ok = False
            aModelDatSet.ToleranceDropDiff = 0
            MsgBox("ModelParam " + "ToleranceDropDiff" + " not found")
        End If
        '/////////////////////

        i = 0
        FoundOK = False
        For i = 0 To ModelData.Tables(0).Rows.Count - 1
            If (ModelData.Tables(0).Rows(i)("ParameterName").Equals("MeasureWidth")) Then
                FoundOK = True
                Exit For
            End If
        Next

        If (FoundOK) Then
            aModelDatSet.MeasureWidth = ModelData.Tables(0).Rows(i)("ParameterValue")
        Else
            Ok = False
            aModelDatSet.MeasureWidth = 0
            MsgBox("ModelParam " + "MeasureWidth" + " not found")
        End If
        '/////////////////////

        i = 0
        FoundOK = False
        For i = 0 To ModelData.Tables(0).Rows.Count - 1
            If (ModelData.Tables(0).Rows(i)("ParameterName").Equals("MeasureDrop")) Then
                FoundOK = True
                Exit For
            End If
        Next

        If (FoundOK) Then
            aModelDatSet.MeasureDrop = ModelData.Tables(0).Rows(i)("ParameterValue")
        Else
            Ok = False
            aModelDatSet.MeasureDrop = 0
            MsgBox("ModelParam " + "MeasureDrop" + " not found")
        End If
        '/////////////////////
        i = 0
        FoundOK = False
        For i = 0 To ModelData.Tables(0).Rows.Count - 1
            If (ModelData.Tables(0).Rows(i)("ParameterName").Equals("MeasureSquareness")) Then
                FoundOK = True
                Exit For
            End If
        Next

        If (FoundOK) Then
            aModelDatSet.MeasureSquareness = ModelData.Tables(0).Rows(i)("ParameterValue")
        Else
            Ok = False
            aModelDatSet.MeasureSquareness = 0
            MsgBox("ModelParam " + "MeasureSquareness" + " not found")
        End If
        '/////////////////////
        i = 0
        FoundOK = False
        For i = 0 To ModelData.Tables(0).Rows.Count - 1
            If (ModelData.Tables(0).Rows(i)("ParameterName").Equals("HasCords")) Then
                FoundOK = True
                Exit For
            End If
        Next

        If (FoundOK) Then
            aModelDatSet.HasCords = ModelData.Tables(0).Rows(i)("ParameterValue")
        Else
            Ok = False
            aModelDatSet.HasCords = 0
            MsgBox("ModelParam " + "HasCords" + " not found")
        End If
        Return Ok
    End Function




    Public Function OpenReadHasCordsModelFile(ByVal aName As String, ByRef HasCords As Double) As Boolean
        Dim Ok = True
        ModelFileName = aName
        connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source= " & ModelFileName & " ;" & "Extended Properties=Excel 12.0;"
        ModelDataAdapter = New OleDbDataAdapter("SELECT * FROM [Sheet1$]", connectionString)
        ModelDataAdapter.TableMappings.Add("Table", "ExcelSheet")
        ModelData.Clear()
        ModelDataAdapter.Fill(ModelData)
        Dim FoundOK As Boolean = False

        Dim i As Integer = 0
        '/////////////////////
        For i = 0 To ModelData.Tables(0).Rows.Count - 1
            If (ModelData.Tables(0).Rows(i)("ParameterName").Equals("HasCords")) Then
                FoundOK = True
                Exit For
            End If
        Next

        If (FoundOK) Then
            HasCords = ModelData.Tables(0).Rows(i)("ParameterValue")
        Else
            Ok = False
            HasCords = 0
        End If

        Return Ok
    End Function

    Private Sub ButtonSaveModelfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSaveModelfile.Click
        ' ModeldataCommandbuilder.GetUpdateCommand() does not work, we have to do it ourselves, because there is no primary key in an excel sheet
        Try
            MakeUpdatecommand()
            ModelDataAdapter.Update(ModelData, "Table")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        'MsgBox("Updated ")
        DataGridView1.DataSource = vbNull ' empty the grid 
        DataGridView1.Refresh()
    End Sub


    Private Sub ModelFiles_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        DataGridView1.DataSource = vbNull ' empty the grid 
        DataGridView1.Refresh()
    End Sub

    Private Sub Exit_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_Btn.Click
        Me.Close()
    End Sub
End Class
