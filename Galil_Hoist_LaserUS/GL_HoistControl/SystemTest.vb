Public Class SystemTest
    Dim NrOfCycles_int As Integer
    Private Sub Homing_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Homing_Btn.Click
        MainForm.galil.command("SHX;") ' Servo_ON()
        Index = "off"
        homestatus = "inprocess"
        Try
            MainForm.galil.command("ST")
            MainForm.galil.command("SB 0") 'set bit 0  'DMCShell1.DMCCommand = "SB 0"
            System.Threading.Thread.Sleep(200) 'Sleep(200)
            MainForm.galil.command("DP0,0") 'define position A and B to zero
            ' If switch_state = 0 Then ' if already on the ref sensor
            'Call find_edge()
            'Else
            MainForm.galil.command("JGA=-20000")
            'DMCShell1.DMCCommand = "HMA"
            MainForm.galil.command("BGA") 'begin motion
        Catch exception As System.Runtime.InteropServices.COMException
            Console.WriteLine(exception) 'print error message
            If exception.Message.Contains("COMMAND ERROR") Then
                MessageBox.Show("Controller Error occurred: " + exception.Message) 'special processing for command errors
            End If
        End Try
        System.Threading.Thread.Sleep(200) 'Sleep 200
    End Sub


    Private Sub Man_Up_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Man_Up.MouseDown
        scaled_speed = jog_speed * scalefact
        'servoready = "on"
        If scaled_speed > 0 Then
            Try
                MainForm.galil.command("SB 0")
                System.Threading.Thread.Sleep(200) 'Sleep(200)
                MainForm.galil.command("ACA=" & Str$(accel * scalefact))
                MainForm.galil.command("DCA=" & Str$(decel * scalefact))
                MainForm.galil.command("JGA=" & Str$(scaled_speed))
                MainForm.galil.command("BGA")
            Catch exception As System.Runtime.InteropServices.COMException
                Console.WriteLine(exception) 'print error message
                If exception.Message.Contains("COMMAND ERROR") Then
                    MessageBox.Show("Controller Error occurred: " + exception.Message) 'special processing for command errors
                End If
            End Try
            System.Threading.Thread.Sleep(200) 'Sleep(200)

        Else : MsgBox("Zero Speed Error" + vbCrLf + " Please check speed and scale" + vbCrLf + " in service screen")
        End If
    End Sub

    Private Sub Man_Dn_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Man_Dn.MouseDown
        scaled_speed = jog_speed * scalefact * -1

        If scaled_speed < 0 Then

            MainForm.galil.command("SB 0")
            System.Threading.Thread.Sleep(200) 'Sleep(200)
            Try
                MainForm.galil.command("ACA=" & Str$(accel * scalefact))
                MainForm.galil.command("DCA=" & Str$(decel * scalefact))
                MainForm.galil.command("JGA=" & Str$(scaled_speed))
                MainForm.galil.command("BGA")
            Catch exception As System.Runtime.InteropServices.COMException
                Console.WriteLine(exception) 'print error message
                If exception.Message.Contains("COMMAND ERROR") Then
                    MessageBox.Show("Controller Error occurred: " + exception.Message) 'special processing for command errors
                End If
            End Try
            System.Threading.Thread.Sleep(200) 'Sleep(200)


        Else : MsgBox("Zero Speed Error" + vbCrLf + " Please check speed and scale" + vbCrLf + " in service screen")

        End If
    End Sub
    Private Sub Man_Up_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Man_Up.MouseUp
        MainForm.galil.command("STA")
    End Sub
    Private Sub Man_Dn_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Man_Dn.MouseUp
        MainForm.galil.command("STA")
    End Sub

    Private Sub TargetPos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TargetPos.Click
        KeyPad_Form.txtValueKeyPad.Text = TargetPos.Text
        KeyPad_Form.MaskedTextBox1.Text = ""
        KeyPad_Form.txtValueKeyPad.Visible = True
        KeyPad_Form.KeyBoard.Visible = False
        KeyPad_Form.MaskedTextBox1.Visible = False
        KeyPad_Form.Numpad.Visible = True
        KeyPad_Form.Size = New Size(291, 392) '   (746, 392)
        KeyPad_Form.ShowDialog()
        TargetPos.Text = KeyPad_Form.txtValueKeyPad.Text
    End Sub

    Private Sub HomePos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HomePos.Click
        KeyPad_Form.txtValueKeyPad.Text = HomePos.Text
        KeyPad_Form.MaskedTextBox1.Text = ""
        KeyPad_Form.txtValueKeyPad.Visible = True
        KeyPad_Form.KeyBoard.Visible = False
        KeyPad_Form.MaskedTextBox1.Visible = False
        KeyPad_Form.Numpad.Visible = True
        KeyPad_Form.Size = New Size(291, 392) '   (746, 392)
        KeyPad_Form.ShowDialog()
        HomePos.Text = KeyPad_Form.txtValueKeyPad.Text
    End Sub

    Private Sub StartCycle_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartCycle_Btn.Click
        If Not IsNumeric(TargetPos.Text) Or Not IsNumeric(HomePos.Text) Or Not IsNumeric(NrOfCycles.Text) Then
            MsgBox("Target position, home postion and #Cycles" + vbCrLf + "All must contain numeric values!")
            Exit Sub
        End If
        If (Val(TargetPos.Text) > HighLimit) Then
            MsgBox("Target position > Upper Soft Limit!" + vbCrLf + "Check parameters!")
            Exit Sub
        End If
        'homestatus = "complete"
        If homestatus = "complete" Then
            position = TargetPos.Text
            If position <= 0 Then
                MsgBox("Target position is not valid")
                Exit Sub
            End If
            scaled_position = position * scalefact
            scaled_speed = move_speed * scalefact
            If scaled_speed > 0 And servoready = "on" Then
                Try
                    MainForm.galil.command("SB 0")
                    System.Threading.Thread.Sleep(200) 'Sleep(200)
                    MainForm.galil.command("PAA=" & Str$(scaled_position))
                    MainForm.galil.command("ACA=" & Str$(accel * scalefact))
                    MainForm.galil.command("DCA=" & Str$(decel * scalefact))
                    MainForm.galil.command("SPA=" & Str$(scaled_speed))
                    MainForm.galil.command("BGA")
                    System.Threading.Thread.Sleep(200) 'Sleep(200)
                    SystemTest_Go_ON = True
                    systemtest_currentTarget = TargetPos.Text

                Catch exception As System.Runtime.InteropServices.COMException
                    Console.WriteLine(exception) 'print error message
                    If exception.Message.Contains("COMMAND ERROR") Then
                        MessageBox.Show("Controller Error occurred: " + exception.Message) 'special processing for command errors

                    End If
                End Try

            Else : MsgBox("Zero Speed or Servo Not Ready Error")
                : Exit Sub
            End If
        Else : MsgBox("Home Servo First")
            : Exit Sub
        End If
        HomePos.Enabled = False
        TargetPos.Enabled = False
    End Sub

    Private Sub STOP_MOTION_paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles STOP_MOTION.Paint
        e.Graphics.TranslateTransform(25, 30)
        e.Graphics.RotateTransform(90)
        e.Graphics.DrawString(Me.STOP_MOTION.Text, Me.Font, Brushes.Yellow, 25, 0)
    End Sub
    Public Sub DoCycle_seq()
        If switch_state = 143 Then Exit Sub
        System.Threading.Thread.Sleep(1000)
        If systemtest_currentTarget = TargetPos.Text Then
            systemtest_currentTarget = HomePos.Text
            If Convert.ToInt16(NrOfCycles.Text) > 0 Then
                NrOfCycles_int = Convert.ToInt16(NrOfCycles.Text)
                NrOfCycles_int = NrOfCycles_int - 1
                NrOfCycles.Text = NrOfCycles_int
            Else
                SystemTest_Go_ON = False
                HomePos.Enabled = True
                TargetPos.Enabled = True
                Exit Sub
            End If
        Else
            If Convert.ToInt16(NrOfCycles.Text) <= 0 Then
                SystemTest_Go_ON = False
                HomePos.Enabled = True
                TargetPos.Enabled = True
                Exit Sub
            End If
            systemtest_currentTarget = TargetPos.Text
        End If
        If homestatus = "complete" Then
            position = systemtest_currentTarget
            scaled_position = position * scalefact
            scaled_speed = move_speed * scalefact
            If scaled_speed > 0 And servoready = "on" Then
                Try
                    MainForm.galil.command("SB 0")
                    System.Threading.Thread.Sleep(200) 'Sleep(200)
                    MainForm.galil.command("PAA=" & Str$(scaled_position))
                    MainForm.galil.command("ACA=" & Str$(accel * scalefact))
                    MainForm.galil.command("DCA=" & Str$(decel * scalefact))
                    MainForm.galil.command("SPA=" & Str$(scaled_speed))
                    MainForm.galil.command("BGA")
                    System.Threading.Thread.Sleep(200) 'Sleep(200)
                    SystemTest_Go_ON = True
                Catch exception As System.Runtime.InteropServices.COMException
                    Console.WriteLine(exception) 'print error message
                    If exception.Message.Contains("COMMAND ERROR") Then
                        MessageBox.Show("Controller Error occurred: " + exception.Message) 'special processing for command errors

                    End If
                End Try

            Else : MsgBox("Zero Speed or Servo Not Ready Error")
            End If
        Else : MsgBox("Home Servo First")
        End If
    End Sub

    Private Sub cmdServo_on_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdServo_on.Click
        Call MainForm.Servo_ON()

    End Sub

    Private Sub cmdServo_off_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdServo_off.Click
        Call MainForm.Servo_OFF()
    End Sub

    Private Sub STOP_MOTION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STOP_MOTION.Click
        SystemTest_Go_ON = False
        MainForm.galil.command("STA")
        HomePos.Enabled = True
        TargetPos.Enabled = True

    End Sub

    Private Sub SystemTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HomePos.Text = GalilActVal_Form.txtHomeoffset.Text
        HomePos.Enabled = True
        TargetPos.Enabled = True
    End Sub

    Private Sub NrOfCycles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NrOfCycles.Click
        KeyPad_Form.txtValueKeyPad.Text = ""
        KeyPad_Form.MaskedTextBox1.Text = ""
        KeyPad_Form.txtValueKeyPad.Visible = True
        KeyPad_Form.KeyBoard.Visible = False
        KeyPad_Form.MaskedTextBox1.Visible = False
        KeyPad_Form.Numpad.Visible = True
        KeyPad_Form.Size = New Size(291, 392) '   (746, 392)
        KeyPad_Form.ShowDialog()
        NrOfCycles.Text = KeyPad_Form.txtValueKeyPad.Text
    End Sub

    Private Sub CmdResetServo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdResetServo.Click
        Try
            MainForm.galil.command("AB") 'ABORT ALL MOTION
            MainForm.galil.command("MOA") 'TURN OFF AXIS
            MainForm.galil.command("SB2") 'Reset servo drive
        Catch exception As System.Runtime.InteropServices.COMException
            Console.WriteLine(exception) 'print error message
            If exception.Message.Contains("COMMAND ERROR") Then
                MessageBox.Show("Galil Error occurred: " + exception.Message) 'special processing for command errors
            End If
        End Try
        System.Threading.Thread.Sleep(500)
        'galil.command("SB 2") 'Turn on Servo Reset
        MainForm.Tmr_reset_Servo.Enabled = True
    End Sub

    Private Sub Exit_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_Btn.Click
        Me.Close()
    End Sub
End Class



