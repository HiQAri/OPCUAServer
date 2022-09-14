Imports System.Data.OleDb

Public Class FormExelData

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ds As New DataSet()
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=C:\ExcelDir\TestFile.xlsx ;" & "Extended Properties=Excel 12.0;"

        Dim excelData As New OleDbDataAdapter("SELECT * FROM [Sheet1$]", connectionString)
        excelData.TableMappings.Add("Table", "ExcelSheet")
        excelData.Fill(ds)

        Me.DataGridView1.DataSource = ds.Tables(0)
        Me.Refresh()
    End Sub
End Class