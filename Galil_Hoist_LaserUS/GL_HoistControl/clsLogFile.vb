
Imports System.IO 'StreamWriter
Public Class clsLogFile
    Public LogFilePath As String = "LogFile.txt"

    Public Sub SaveLog(ByRef myTextBox As TextBox)
        ' Create an instance of StreamWriter to write text to a file.
        Try
            Dim sw As StreamWriter = New StreamWriter(LogFilePath)
            ' Add some text to the file.
            sw.Write(myTextBox.Text)
            sw.Close()
        Catch E As Exception
            ' Let the user know what went wrong.
            myTextBox.Text = myTextBox.Text & vbCrLf & "The log could not be written:" & E.Message
        End Try
    End Sub

    Public Sub Setfilename(ByRef afname As String)
        LogFilePath = afname
    End Sub

    Public Sub LoadLog(ByRef myTextBox As TextBox)
        ' Create an instance of StreamReader for reading.
        Try
            Dim sr As StreamReader = New StreamReader(LogFilePath)
            Dim FilInfo As FileInfo = New FileInfo(LogFilePath)
            Dim myText As String = ""
            Dim Buff As String
            ' read the text to the file.
            Do
                Buff = sr.ReadLine()
                myText = myText & Buff & vbCrLf
            Loop Until Buff Is Nothing

            myText = "LOGFILE WRITTEN ON :" & FilInfo.LastWriteTime & vbCrLf & vbCrLf & myText
            myTextBox.Text = myText
            sr.Close()
        Catch E As Exception
            ' Let the user know what went wrong.
            myTextBox.Text = myTextBox.Text & vbCrLf & "The file could not be read:" & E.Message
        End Try
    End Sub


   
End Class


