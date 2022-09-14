Imports System.Data.OleDb

Public Class ParamFiles
    Dim ParamFileName As String = "testFile"
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=..\Paramfiles\Params.xlsx ;" & "Extended Properties=Excel 12.0;"
    Dim ParamDataAdapter As New OleDbDataAdapter("SELECT * FROM [Sheet1$]", connectionString)
    Dim ParamDataAdapter1 As New OleDbDataAdapter("SELECT * FROM [Sheet1$]", connectionString)
    Dim ParamdataCommandbuilder As OleDbCommandBuilder = New OleDbCommandBuilder(ParamDataAdapter)
    Dim ParamData As New DataSet()
    Dim ParamData1 As New DataSet()

    Private Function MakeUpdatecommand() As Boolean
        ParamDataAdapter.UpdateCommand = New OleDbCommand("UPDATE [Sheet1$] SET ParameterIndex = ? , ParameterName = ?, ParameterValue = ?, ParameterUnits = ?, Comment = ?  WHERE ParameterIndex = ? AND ParameterName = ? AND ParameterValue = ? AND ParameterUnits = ? AND Comment = ?  ")
        ParamDataAdapter.UpdateCommand.Parameters.Add("@ParameterIndex", OleDbType.Char, 255).SourceColumn = "ParameterIndex"
        ParamDataAdapter.UpdateCommand.Parameters.Add("@ParameterName", OleDbType.Char, 255).SourceColumn = "ParameterName"
        ParamDataAdapter.UpdateCommand.Parameters.Add("@ParameterValue", OleDbType.Char, 255).SourceColumn = "ParameterValue"
        ParamDataAdapter.UpdateCommand.Parameters.Add("@ParameterUnits", OleDbType.Char, 255).SourceColumn = "ParameterUnits"
        ParamDataAdapter.UpdateCommand.Parameters.Add("@Comment", OleDbType.Char, 255).SourceColumn = "Comment"

        ' For Updates, we need to provide the old values so that we only update the corresponding row.
        ParamDataAdapter.UpdateCommand.Parameters.Add("@OldParameterIndex", OleDbType.Char, 255, "ParameterIndex").SourceVersion = DataRowVersion.Original
        ParamDataAdapter.UpdateCommand.Parameters.Add("@OldParameterName", OleDbType.Char, 255, "ParameterName").SourceVersion = DataRowVersion.Original
        ParamDataAdapter.UpdateCommand.Parameters.Add("@OldParameterValue", OleDbType.Char, 255, "ParameterValue").SourceVersion = DataRowVersion.Original
        ParamDataAdapter.UpdateCommand.Parameters.Add("@OldParameterUnits", OleDbType.Char, 255, "ParameterUnits").SourceVersion = DataRowVersion.Original
        ParamDataAdapter.UpdateCommand.Parameters.Add("@OldComment", OleDbType.Char, 255, "Comment").SourceVersion = DataRowVersion.Original

        Return (True)
    End Function


    Private Sub ButtonOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOpenParamFile.Click
        Dim result As DialogResult = OpenFileDialogParams.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Try
                OpenParamFile(OpenFileDialogParams.FileName, DataGridView1)
                GroupBoxParamFile.Text = OpenFileDialogParams.FileName
            Catch ex As Exception
                MsgBox(ex)
            End Try
        End If
    End Sub


    Public Function OpenParamFile(ByVal aName As String, ByRef GridView As DataGridView)
        ParamFileName = aName
        connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source= " & ParamFileName & " ;" & "Extended Properties=Excel 12.0;"
        ParamDataAdapter = New OleDbDataAdapter("SELECT * FROM [Sheet1$]", connectionString)
        ParamDataAdapter.TableMappings.Add("Table", "ExcelSheet")
        ParamData.Clear()
        ParamDataAdapter.Fill(ParamData)

        GridView.DataSource = vbNull ' empty the grid 
        GridView.Refresh()

        GridView.DataSource = ParamData.Tables(0)
        For i = 0 To GridView.Columns.Count - 1
            GridView.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            GridView.Columns(i).ReadOnly = True
        Next
        GridView.Columns("ParameterValue").ReadOnly = False

        Me.Refresh()

        ParamdataCommandbuilder = New OleDbCommandBuilder(ParamDataAdapter) ' for when we need to update the excelsheet

        Return True
    End Function

    Public Function OpenReadParamFile(ByVal aName As String, ByVal ParamName As String, ByRef Param As Double) As Boolean
        Dim Ok = True
        ParamFileName = aName
        connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source= " & ParamFileName & " ;" & "Extended Properties=Excel 12.0;"
        ParamDataAdapter1 = New OleDbDataAdapter("SELECT * FROM [Sheet1$]", connectionString)
        ParamDataAdapter1.TableMappings.Add("Table", "ExcelSheet")
        ParamData1.Clear()
        ParamDataAdapter1.Fill(ParamData1)
        Dim FoundOK As Boolean = False

        Dim i As Integer = 0
        For i = 0 To ParamData1.Tables(0).Rows.Count - 1
            If (ParamData1.Tables(0).Rows(i)("ParameterName").Equals(ParamName)) Then
                FoundOK = True
                Exit For
            End If
        Next
        'MsgBox("offsetH found? i=" + i.ToString)

        If (FoundOK) Then
            Param = ParamData1.Tables(0).Rows(i)("ParameterValue")
        Else
            Ok = False
            MsgBox("ParameterName " + ParamName + " not found")
            Param = 0
        End If


        Return Ok
    End Function

    

    Public Function SaveParams() As Boolean
        Try
            MakeUpdatecommand()
            ParamDataAdapter.Update(ParamData, "Table")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        'MsgBox("Updated ")
        Return (True)
    End Function

    Public Function SaveOneParam(ByVal aFname As String, ByVal Paramname As String, ByVal aValue As Double) As Boolean

        Dim Ok = True
        ParamFileName = aFname
        connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source= " & ParamFileName & " ;" & "Extended Properties=Excel 12.0;"
        ParamDataAdapter1 = New OleDbDataAdapter("SELECT * FROM [Sheet1$]", connectionString)
        ParamDataAdapter1.TableMappings.Add("Table", "ExcelSheet")
        ParamData1.Clear()
        ParamDataAdapter1.Fill(ParamData1)
        Dim FoundOK As Boolean = False

        Dim i As Integer = 0
        For i = 0 To ParamData1.Tables(0).Rows.Count - 1
            If (ParamData1.Tables(0).Rows(i)("ParameterName").Equals(ParamName)) Then
                FoundOK = True
                Exit For
            End If
        Next
        ' MsgBox("param" + Paramname + " found? i=" + i.ToString)

        If (FoundOK) Then
            ParamData1.Tables(0).Rows(i)("ParameterValue") = aValue
            Ok = True
        Else
            Ok = False
        End If
        'MsgBox("ok ? " + Ok.ToString)

        If Ok Then

            Try
                MakeUpdatecommand()
                ParamDataAdapter.Update(ParamData1, "Table")
            Catch ex As Exception
                MsgBox(ex.ToString)
                Ok = False
            End Try
            'MsgBox("Updated ")

        End If

        Return (Ok)
    End Function




    Private Sub ParamFiles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            OpenParamFile(ParamFileName, DataGridView1)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ButtonSaveParamfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSaveParamfile.Click
        SaveParams()
    End Sub

    Private Sub Exit_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_Btn.Click
        Me.Close()
    End Sub
End Class
