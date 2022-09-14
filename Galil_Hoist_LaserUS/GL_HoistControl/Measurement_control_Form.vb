Public Class Measurement_control_Form

    Private Sub nextButton_Click(sender As System.Object, e As System.EventArgs) Handles nextButton.Click
        Me.Close()
    End Sub

    Private Sub BtnClear_Click(sender As System.Object, e As System.EventArgs) Handles BtnClear.Click
        RichTextBoxUS.Clear()
    End Sub

    Private Sub BtnStart_Click(sender As System.Object, e As System.EventArgs) Handles BtnStart.Click
        Start_US_measurement = True
    End Sub

    Private Sub BtnStop_Click(sender As System.Object, e As System.EventArgs) Handles BtnStop.Click
        Start_US_measurement = False
    End Sub

    Private Sub cmdStop_Click(sender As System.Object, e As System.EventArgs) Handles cmdStop.Click
        MainForm.galil.command("STA")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If (TextBox_LaserControlPos.Text <> "") Then

            Select Case SeqStep
                Case 1
                    MainForm.txtPosition.Text = Val(TextBox_LaserControlPos.Text)
                    SeqStep = 2
                    Button1.Text = "GO" + vbCrLf + "HOME"
                Case 2
                    MainForm.txtPosition.Text = Val(Service_Form.txtHomeoffset.Text)
                    SeqStep = 1
                    Button1.Text = "GO" + vbCrLf + "MEASURE"
            End Select
            MainForm.Go()
        End If
    End Sub

    Private Sub TextBox_LaserControlPos_Click(sender As System.Object, e As System.EventArgs) Handles TextBox_LaserControlPos.Click
        KeyPad_Form.txtValueKeyPad.Text = ""
        KeyPad_Form.MaskedTextBox1.Text = ""
        KeyPad_Form.txtValueKeyPad.Visible = True
        KeyPad_Form.KeyBoard.Visible = False
        KeyPad_Form.MaskedTextBox1.Visible = False
        KeyPad_Form.Numpad.Visible = True
        KeyPad_Form.Size = New Size(291, 392) '   (746, 392)
        KeyPad_Form.ShowDialog()
        TextBox_LaserControlPos.Text = KeyPad_Form.txtValueKeyPad.Text
    End Sub
End Class