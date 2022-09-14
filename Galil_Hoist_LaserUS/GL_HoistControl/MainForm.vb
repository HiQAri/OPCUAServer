Public Class MainForm
    Public WithEvents galil As New Galil.Galil


    Dim ProductionType As Integer = 0   ' 0 is old production and no laser or us measurement

    Dim Binding As Object
    Dim MemUSSensorsOn As Boolean

    Dim linerFlag As Boolean

    Public GoPosUpStat As Integer = 0
    Public GoPosPosition As Double = 0
    Public ExtraDownMove As Double = 0


    Dim lastposition, lastinstruction As String
    Dim DoGoBack As Boolean = False
    Dim Dropentered As Boolean = False
    Dim Widthentered As Boolean = False
    Dim Modelentered As Boolean = False

    Dim Eye_Level As Double = 0
    Dim Cut_Liner_level_delta As Double = 0
    Dim OldInspection_Delta As Double = 0 ' distance from drop to position for inspecting the blind. Is used in the original cycle

    Dim Mount_Ring_Pos As Double = 0
    Dim PopUpInspection As Boolean = False ' command to open the inspection page if set to true


    Dim MeasureDrop As Double = 1.0        'values from the parameter file. These will be combined with similar values from the model files.
    Dim MeasureWidth As Double = 1.0
    Dim MeasureSquareness As Double = 1.0

    Dim HasCords As Double = 1

    Function nextstep() As Boolean
        Return NextButton.NextStep()
    End Function

    Private Sub btnCLMPoff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLMPoff.Click
        galil.command("CB 3") 'Turn OFF Clamps
    End Sub

    Private Sub btnCLMPon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLMPon.Click
        galil.command("SB 3") 'Turn ON Clamps
    End Sub

    Private Sub cmdServo_on_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdServo_on.Click
        Call Servo_ON()
    End Sub

    Private Sub cmdServo_off_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdServo_off.Click
        Call Servo_OFF()
    End Sub

    Private Sub CmdResetServo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdResetServo.Click
        ResetServoDrive()
    End Sub

    Private Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGo.Click
        GoToPosition()
    End Sub

    Private Sub eighthDn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eighthDn.Click
        txtPosition.Text = Val(txtPosition.Text) - 0.125
        Call GoToPosition()
    End Sub

    Private Sub eighthUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eighthUp.Click
        txtPosition.Text = Val(txtPosition.Text) + 0.125
        Call GoToPosition()
    End Sub

    Private Sub cmdYPlus_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdYPlus.MouseDown
        JogServo(True)
    End Sub

    Private Sub cmdYPlus_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdYPlus.MouseUp
        StopServoMovement()
    End Sub
    Private Sub cmdYMinus_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdYMinus.MouseDown
        JogServo(False)
    End Sub

    Private Sub cmdYMinus_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdYMinus.MouseUp
        StopServoMovement()
    End Sub

    Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click
        StopServoMovement()
    End Sub
    ' initialisation of the galil

    Private Sub initializeCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles initializeCommand.Click
        Call initializeGalil()
    End Sub
    Private Sub initializeGalil()
        Try
            galil.address = "192.168.1.43"
            Label1.Text = galil.connection() + vbCrLf
            System.Threading.Thread.Sleep(1000)
            galil.recordsStart(50)

        Catch ex As Runtime.InteropServices.COMException
            Label1.Text = Label1.Text + ex.Message
        End Try
        Try
            galil.command("AB") 'ABORT ALL MOTION

        Catch exception As System.Runtime.InteropServices.COMException
            Console.WriteLine(exception) 'print error message
            If exception.Message.Contains("COMMAND ERROR") Then
                MessageBox.Show("Galil Error occurred: " + exception.Message) 'special processing for command errors
            End If
        End Try


        Tmr_reset_Servo.Enabled = True ' reset  the hardware  reset signal to the drive  even if not set 
        homestatus = "off"
        Index = "off"
        servoready = "off"

        initializeCommand.Visible = False
    End Sub

    Private Sub GoPosHandler()
        Select Case GoPosUpStat

            Case 0 ' do nothing wait for command (GoPosPosition filled in and GoPOsUpStat -> 1)
            Case 1
                txtPosition.Text = (GoPosPosition - ExtraDownMove).ToString("###0.0000")
                GoToPosition()
                GoPosUpStat += 1
            Case 2
                If switch_state <> 143 Then
                    txtPosition.Text = GoPosPosition.ToString("###0.0000")
                    GoToPosition()
                    GoPosUpStat += 1
                End If
            Case 3
                If switch_state <> 143 Then
                    GoPosUpStat = 0
                End If

        End Select

    End Sub

    ' galil event handeling sub 
    Private Sub galil_onRecord(ByVal record As Object) Handles galil.onRecord 'event to handle record

        GoPosHandler()

        DMCPoll1.Text = (Math.Round((galil.sourceValue(record, "_TPA") / scalefact), 3)).ToString + "" + vbCrLf 'print current servo position on the screen

        SystemTest.CurrentPos.Text = DMCPoll1.Text ' copy it also to the system test page

        switch_StatusX.Text = (galil.command("TSX")) '.ToString + vbCrLf   ' read the inputs
        switch_state = Convert.ToInt16(switch_StatusX.Text) ' used to find the input status in many places in the programm
        strXMoving = galil.sourceValue(record, "_BGA")   ' not used anywhere rs
        estop_state = galil.command("MG@IN[2]")

        If ProductionType > 0 Then ' zero is for hoist without us and laser

            If (USSensorsOn = True) And (MemUSSensorsOn = False) Then
                galil.command("CB 4")
            End If
            If (USSensorsOn = False) And (MemUSSensorsOn = True) Then
                galil.command("SB 4")
            End If


            MemUSSensorsOn = USSensorsOn

            'measurement actions
            If (DoUSMeasurement = True) Then
                Measurement.EnterUSMeasurement(galil.command("MG@AN[1]"), galil.command("MG@AN[2]"), galil.command("MG@AN[3]"), galil.command("MG@AN[4]"), galil.command("MG@AN[5]"), galil.command("MG@AN[6]"))
            End If
        End If


        'Estop actions
        If Val(estop_state) > 0 Then
            EstopLabel.BackColor = Color.DarkRed 'red
            EstopLabel.ForeColor = Color.LightYellow
            SystemTest_Go_ON = False 'Stop running system test seq, (just in case)
            galil.command("STA")    'stop axis and wait until stopped
            SystemTest.HomePos.Enabled = True
            SystemTest.TargetPos.Enabled = True
            If IsFormOpen(EM_Dlg) = False Then
                EM_Dlg.ShowDialog()
            End If
        Else
            EstopLabel.BackColor = Color.DarkGreen   'green
        End If
        ' show servo on or off in main and system test
        If Val(switch_state) <= 15 Or Val(switch_state) = 143 Or Val(switch_state) = 11 Or Val(switch_state) = 7 Then
            cmdServo_on.BackColor = Color.Green 'green
            SystemTest.cmdServo_on.BackColor = Color.Green
            cmdServo_on.ForeColor = Color.LightYellow
            SystemTest.cmdServo_on.ForeColor = Color.LightYellow

            servoready = "on"
        Else
            cmdServo_on.BackColor = Color.Red 'red
            SystemTest.cmdServo_on.BackColor = Color.Red
            cmdServo_on.ForeColor = Color.Black
            SystemTest.cmdServo_on.ForeColor = Color.Black
            servoready = "off"
        End If

        ' homing sequence 

        If homestatus = "inprocess" And Index = "off" And Val(switch_state) = 9 Then
            Call find_edge()
        End If
        If homestatus = "inprocess" And Index = "inprocess" And Val(switch_state) = 13 Then
            galil.command("DP " & Str$(home * scalefact))
            Index = "complete"
            Call finish_home()
        End If
        If homestatus = "inprocess" And Index = "inprocess" And Val(switch_state) = 9 Then 'if stopped after find edge but still sensor has signal
            Call MoveAwayFromSensor()
        End If

        If homestatus = "offset" And Index = "complete" And Val(switch_state) = 15 Then
            Index = "complete"
            homestatus = "complete"
            homeind.BackColor = Color.Green 'green
            homeind.ForeColor = Color.LightYellow
        End If

        ' call for systemtest window to make it cycle
        If SystemTest_Go_ON Then
            If switch_state <> 143 Then
                'Hoist not moving   or error 
                If switch_state = 15 Then
                    'hoist stands still not on limit switch
                    Call SystemTest.DoCycle_seq()
                End If
            End If

        End If
    End Sub

    '// servo command functions

    Public Sub StopServoMovement()
        galil.command("STA")
    End Sub
    Public Sub GoToPosition()
        If homestatus = "complete" Then
            position = txtPosition.Text
            scaled_position = position * scalefact
            scaled_speed = move_speed * scalefact
            If scaled_speed > 0 And servoready = "on" Then
                Try
                    galil.command("SB 0")
                    System.Threading.Thread.Sleep(200) 'Sleep(200)
                    galil.command("PAA=" & Str$(scaled_position))
                    galil.command("ACA=" & Str$(accel * scalefact))
                    galil.command("DCA=" & Str$(decel * scalefact))
                    galil.command("SPA=" & Str$(scaled_speed))
                    galil.command("BGA")
                    System.Threading.Thread.Sleep(200) 'Sleep(200)
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
    Public Sub Servo_ON()
        ResetServoDrive()
        System.Threading.Thread.Sleep(10) 'was(50)
        galil.command("SHX;")
    End Sub
    Public Sub Servo_OFF()
        galil.command("MOX;")
        homeind.BackColor = Color.Red '
        homeind.ForeColor = Color.White
    End Sub

    Public Sub JogServo(ByVal DirUp As Boolean)

        If DirUp Then  ' moved rs toavoid zero speed error when the scaled speed wasn't set anywhere else yet
            scaled_speed = jog_speed * scalefact
        Else
            scaled_speed = jog_speed * scalefact * -1
        End If

        If scaled_speed <> 0 Then

            If servoready = "on" Then
                galil.command("SB 0")
                System.Threading.Thread.Sleep(200) 'Sleep(200)
                Try
                    galil.command("ACA=" & Str$(accel * scalefact))
                    galil.command("DCA=" & Str$(decel * scalefact))
                    galil.command("JGA=" & Str$(scaled_speed))
                    galil.command("BGA")
                Catch exception As System.Runtime.InteropServices.COMException
                    Console.WriteLine(exception) 'print error message
                    If exception.Message.Contains("COMMAND ERROR") Then
                        MessageBox.Show("Controller Error occurred: " + exception.Message) 'special processing for command errors
                    End If
                End Try
                System.Threading.Thread.Sleep(200) 'Sleep(200)

            Else
                MsgBox("Servo Not Ready Error")
            End If
        Else
            MsgBox("Zero Speed error  JS=" + jog_speed.ToString + "   SC" + scalefact.ToString)
        End If
    End Sub

    Private Sub ResetServoDrive()
        Try
            galil.command("AB") 'ABORT ALL MOTION
            galil.command("MOA") 'TURN OFF AXIS
            galil.command("SB2") 'Reset servo drive
        Catch exception As System.Runtime.InteropServices.COMException
            Console.WriteLine(exception) 'print error message
            If exception.Message.Contains("COMMAND ERROR") Then
                MessageBox.Show("Galil Error occurred: " + exception.Message) 'special processing for command errors
            End If
        End Try
        System.Threading.Thread.Sleep(200)
        Tmr_reset_Servo.Enabled = True
    End Sub
    ' timer used for the drive hardware reset signal timing.
    Private Sub Tmr_reset_Servo_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tmr_reset_Servo.Tick
        galil.command("CB 2") 'Turn off Servo Reset hardwarevsignal to the drive
        Tmr_reset_Servo.Enabled = False
    End Sub

    Private Sub CloseDownGalil()
        galil.command("AB")
        galil.command("MOA")
        galil.command("CB 0")

        homestatus = "off"
        Index = "off"
        Try
            galil.address = "OFFLINE" 'OFFLINE causes the destructor to run, disconecting from the controller
        Catch ex As Exception 'OFFLINE throws an error so catch and ignore it

        End Try
    End Sub


    Private Sub btnHomeServo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHomeServo.Click
        HomeServo()
    End Sub

    '//// home sequence 

    Private Sub HomeServo()
        Call Servo_ON()
        Index = "off"
        homestatus = "inprocess"
        Try
            galil.command("ST")
            galil.command("SB 0") 'set bit 0  'DMCShell1.DMCCommand = "SB 0"
            System.Threading.Thread.Sleep(200) 'Sleep(200)
            galil.command("DP0,0") 'define position A and B to zero
            ' If switch_state = 0 Then ' if already on the ref sensor
            'Call find_edge()
            'Else
            galil.command("JGA=-20000")
            'DMCShell1.DMCCommand = "HMA"
            galil.command("BGA") 'begin motion
        Catch exception As System.Runtime.InteropServices.COMException
            Console.WriteLine(exception) 'print error message
            If exception.Message.Contains("COMMAND ERROR") Then
                MessageBox.Show("Controller Error occurred: " + exception.Message) 'special processing for command errors
            End If
        End Try
        System.Threading.Thread.Sleep(200) 'Sleep 200

    End Sub

    Private Sub MoveAwayFromSensor()
        System.Threading.Thread.Sleep(200) 'Sleep 200
        galil.command("JGA=2000")
        'DMCShell1.DMCCommand = "HMA"
        galil.command("BGA") 'begin motion
        While Val(switch_state) <> 141 And Val(switch_state) <> 9

        End While
        System.Threading.Thread.Sleep(200)
        galil.command("STA") 'stop axis and wait until stopped

    End Sub

    Private Sub find_edge()
        'galil.command("STA") 'stop axis and wait until stopped
        Try
            ' System.Threading.Thread.Sleep(200)
            galil.command("JGA=1000")
            galil.command("FIA")
            galil.command("BGA")
        Catch exception As System.Runtime.InteropServices.COMException
            Console.WriteLine(exception) 'print error message
            If exception.Message.Contains("COMMAND ERROR") Then
                MessageBox.Show("Controller Error occurred: " + exception.Message) 'special processing for command errors
            End If
        End Try
        System.Threading.Thread.Sleep(200) 'Sleep(200)
        homestatus = "inprocess"
        Index = "inprocess"
        'Debug.Print homestatus
    End Sub
    Private Sub finish_home()
        Debug.Print("finishing home")
        scaled_speed = move_speed * scalefact
        Try
            galil.command("PAA=" & Str$(homeoffset * scalefact))
            galil.command("ACA=" & Str$(accel * scalefact))
            galil.command("DCA=" & Str$(decel * scalefact))
            galil.command("SPA=" & Str$(scaled_speed))
            galil.command("BGA")
        Catch exception As System.Runtime.InteropServices.COMException
            Console.WriteLine(exception) 'print error message
            If exception.Message.Contains("COMMAND ERROR") Then
                MessageBox.Show("Controller Error occurred: " + exception.Message) 'special processing for command errors
            End If
        End Try
        homestatus = "offset"
        txtPosition.Text = GalilActVal_form.txtHomeoffset.Text
        System.Threading.Thread.Sleep(200) 'Sleep(200)
        'Debug.Print homestatus
    End Sub

    '/// end home sequence

    ' general form buttons and things

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HoistOrdersResultDataSet1.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter1.Fill(Me.HoistOrders1DataSet.Orders)

        LoadGenSettingsParams()

        If ProductionType > 0 Then

            Me.OrdersTableAdapter1.Fill(Me.HoistOrders1DataSet.Orders)


            Me.OrdersResultTableAdapter1.Fill(Me.HoistOrdersResultDataSet1.OrdersResult)

            DataGridViewRollUpDist.Visible = False
            DataGridViewOrders.Visible = True
            ButtonSave.Visible = True
            ButtonUseDatSelected.Visible = True
            ButtonInspection.Visible = True
            dcFabType.Visible = False
            LinerCombo.Visible = False
            cmbHem.Visible = False
            LabelLiner.Visible = False
            txtRollup.Visible = False
            LabelBottom.Visible = False
            LabelFabtype.Visible = False
            LabelWidth.Visible = True
            TxtWidth.Visible = True
            txtCLO.Visible = True
            LabelModel.Visible = True
            ComboBoxModel.Visible = True
            ComboBoxModel.Items.Clear()
            For Each foundFile As String In My.Computer.FileSystem.GetFiles("..\ModelFiles")
                ComboBoxModel.Items.Add(My.Computer.FileSystem.GetName(foundFile))
            Next

        Else
            Me.RollUpDistTableAdapter.Fill(Me.GalilHoistDataSet1.RollUpDist)
            DataGridViewRollUpDist.Visible = False
            DataGridViewOrders.Visible = False
            ButtonSave.Visible = False
            ButtonUseDatSelected.Visible = False
            ButtonInspection.Visible = False
            dcFabType.Visible = False 'True
            LinerCombo.Visible = False 'True
            cmbHem.Visible = False 'True
            LabelLiner.Visible = False 'True
            txtRollup.Visible = False 'True
            LabelBottom.Visible = False 'True
            LabelFabtype.Visible = False ' true
            LabelWidth.Visible = False
            TxtWidth.Visible = False
            LabelModel.Visible = False
            ComboBoxModel.Visible = False
        End If

        System_Label.Text = "Connecting"
        System_Label.Visible = True
        Update()

        lblEstcomm.Visible = True
        System_Label.Visible = False

        TextBox1.Text = SW_Version
        cmdGoBack.Visible = True

        SeqStep = 0
        homeind.BackColor = Color.Red '
        homeind.ForeColor = Color.White
        Me.Size = New Size(1300, 1024)
        If debugmode <> True Then
            System.Threading.Thread.Sleep(4000)
            Call initializeGalil()
            System.Threading.Thread.Sleep(1000) 'Sleep(200)
            lblEstcomm.Visible = False
            GalilActVal_form.UploadGalilVal() ' stores some values that are used for calculations on mainform
        End If

        System_Label.Text = "System is going down!"
        System_Label.Visible = False
        Update()
        TimerCyclicWork.Enabled = True
        If ProductionType > 0 Then
            Measurement.DoInit()  ' we need to do this to open the laser com port etc even whithout showing the form, so we can measure while in an other form
        End If

    End Sub

    Private Sub cmdQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuit.Click
        System_Label.Visible = True
        Me.Update()
        CloseDownGalil()
        If Not debugmode Then

            System.Diagnostics.Process.Start("ShutDown", "/s /t 00")
            End
        End If
    End Sub

    Private Function BlockInputFields(ByVal aBlock As Boolean) As Boolean
        txtDrop.ReadOnly = aBlock
        TxtWidth.ReadOnly = aBlock
        ComboBoxModel.Enabled = Not aBlock
        Return (True)
    End Function


    Public Sub ResultTodatabase(ByVal DateStr As String, ByVal TimeStr As String, ByVal OrderNr As String, ByVal Theodrop As String, ByVal TheoWidth As String, ByVal DropA As String, ByVal DropB As String, ByVal DropC As String, ByVal Width As String, ByVal Skew As String)
        Dim newrow As DataRow
        newrow = Me.HoistOrdersResultDataSet1.Tables(0).NewRow

        newrow.Item("DateStr") = DateStr
        newrow.Item("TimeStr") = TimeStr
        newrow.Item("OrderNr") = OrderNr
        newrow.Item("TheoDrop") = Theodrop
        newrow.Item("TheoWidth") = TheoWidth
        newrow.Item("DropA") = DropA
        newrow.Item("DropB") = DropB
        newrow.Item("DropC") = DropC
        newrow.Item("Width") = Width
        newrow.Item("Skew") = Skew


        Me.HoistOrdersResultDataSet1.Tables(0).Rows.Add(newrow)
        Me.OrdersResultTableAdapter1.Update(Me.HoistOrdersResultDataSet1)
    End Sub


    '////////////////////////////all things for the production cycle

    Private Sub ProductionCycleWithMeasurement()

        Select Case SeqStep

            Case 0
                'waiting for data to be entered
                If Dropentered Then
                    If (Len(txtDrop.Text) > 0) And (Val(txtDrop.Text) > 0) Then
                        txtCLO.Text = Format(Val(txtDrop.Text) / 2, "####.000")
                    End If
                End If

                If (Dropentered) And (Widthentered) And (Modelentered) Then
                    If (CorrectDataAvailableNewProd()) Then
                        If (Len(txtDrop.Text) > 0) And (Val(txtDrop.Text) > 0) Then
                            txtCLO.Text = Format(Val(txtDrop.Text) / 2, "####.000")
                            txtDrop.BackColor = Color.White
                            TxtWidth.BackColor = Color.White

                            ModelFiles.OpenReadHasCordsModelFile("..\ModelFiles\" + ComboBoxModel.SelectedItem.ToString(), HasCords)
                            If (HasCords = 1) Then
                                txtCLO.Visible = True
                                LabelCordLength.Visible = True
                            Else
                                txtCLO.Visible = False
                                LabelCordLength.Visible = False
                            End If
                            lastinstruction = instructionLabel.Text
                            NextButton.Text = "START"
                            instructionLabel.Text = "MOUNT THE SHADE, THEN HIT START"
                            SeqStep += 1
                        End If
                    Else
                        MsgBox(" fill in correct drop, width and model")

                    End If

                End If

                If (nextstep()) Then
                    MsgBox("Enter Shade Info, then hit START")
                    SeqStep += 1
                End If


            Case 1

                If (nextstep()) Then
                    If homestatus = "complete" Then
                        BlockInputFields(True)
                        lastposition = txtPosition.Text
                        txtPosition.Text = Val(txtDrop.Text)
                        GoToPosition()
                        lastinstruction = instructionLabel.Text
                        instructionLabel.Text = "INSPECT BOTTOM BAR, THEN HIT NEXT"
                        NextButton.Text = "NEXT"
                        SeqStep += 1
                    Else
                        MsgBox("Home servo first")
                    End If
                End If



            Case 2


                If (MeasureDrop = 1) Then
                    If (nextstep()) Then
                        PopUpInspection = True
                        lastinstruction = instructionLabel.Text
                        instructionLabel.Text = "SET DROP , THEN HIT NEXT"
                        NextButton.Text = "NEXT"
                        SeqStep += 1
                    End If
                Else
                    SeqStep = 4
                End If


            Case 3
                If (Inspection.isloaded()) Then ' waiting for the inspection screen to be loaded 
                    Inspection.SetDropWidthModel(txtDrop.Text, TxtWidth.Text, ComboBoxModel.SelectedItem.ToString(), TextBoxOrderNr.Text)
                    Inspection.DoContMeasurement()
                    lastinstruction = instructionLabel.Text
                    instructionLabel.Text = "SET DROP , THEN HIT NEXT"
                    NextButton.Text = "NEXT"
                    SeqStep += 1
                End If

            Case 4
                If (nextstep()) Then
                    'txtPosition.Text = Val(txtDrop.Text) + Mount_Ring_DeltaPos
                    If HasCords = 1 Then
                        instructionLabel.Text = "SET DROP, THEN HIT NEXT"
                        lastposition = txtPosition.Text
                        txtPosition.Text = Mount_Ring_Pos.ToString("###0.0000")
                        GoToPosition()
                    Else
                        instructionLabel.Text = "SET DROP, THEN HIT NEXT"
                    End If
                    lastinstruction = instructionLabel.Text
                    NextButton.Text = "NEXT"
                    SeqStep += 1
                End If


            Case 5

                If (MeasureDrop = 1) Or (MeasureWidth = 1) Then
                    If (nextstep()) Then
                        PopUpInspection = True
                        lastinstruction = instructionLabel.Text
                        instructionLabel.Text = "WAIT FOR THE FINAL MEASUREMENT, THEN HIT NEXT or BACK"
                        NextButton.Text = "NEXT"
                        SeqStep += 1
                    End If
                Else
                    SeqStep = 8
                End If


            Case 6
                If (Inspection.isloaded()) Then ' waiting for the inspection screen to be loaded 
                    Inspection.SetDropWidthModel(txtDrop.Text, TxtWidth.Text, ComboBoxModel.SelectedItem.ToString(), TextBoxOrderNr.Text)
                    Inspection.DofullMeasurement()
                    lastinstruction = instructionLabel.Text
                    instructionLabel.Text = "WAIT FOR THE FINAL MEASUREMENT "
                    NextButton.Text = "NEXT"
                    SeqStep += 1
                End If

            Case 7

                If (nextstep()) Then

                    lastinstruction = instructionLabel.Text
                    If (Inspection.GiveLastResultAll() = True) Then
                        instructionLabel.Text = "Measurement result " + " GOOD" + "  HIT NEXT"
                        NextButton.Text = "NEXT"
                    Else
                        instructionLabel.Text = "Measurement result " + "BAD    " + "  HIT Go On OR BACK"
                        NextButton.Text = "GO ON"
                    End If
                    SeqStep += 1
                End If


            Case 8

                If (nextstep()) Then
                    lastposition = txtPosition.Text
                    txtPosition.Text = Val(GalilActVal_form.txtHomeoffset.Text)
                    GoToPosition()
                    lastinstruction = instructionLabel.Text
                    instructionLabel.Text = "REMOVE THE SHADE"
                    txtDrop.BackColor = Color.FromArgb(100, 100, 100) ' RGB(100, 100, 100)
                    txtDrop.Text = ""

                    txtDrop.Focus() 'SetFocus()
                    TxtWidth.BackColor = Color.FromArgb(100, 100, 100) ' RGB(100, 100, 100)
                    TxtWidth.Text = ""
                    ComboBoxModel.Text = ""
                    NextButton.Text = "DONE"
                    Widthentered = False
                    Dropentered = False
                    Modelentered = False
                    BlockInputFields(False)
                    SeqStep += 1
                End If
                If (DoGoBack) Then
                    PopUpInspection = True
                    lastinstruction = instructionLabel.Text
                    instructionLabel.Text = "SET DROP , THEN HIT NEXT"
                    NextButton.Text = "NEXT"
                    SeqStep = 3
                End If
            Case 9
                If (nextstep()) Then
                    NextButton.Text = "START"
                    instructionLabel.Text = "ENTER DATA, MOUNT THE SHADE, THEN HIT START"
                    SeqStep = 0
                End If



            Case 30  ' reset the production cycle
                txtPosition.Text = Val(GalilActVal_form.txtHomeoffset.Text)
                lastposition = txtPosition.Text ' also set lastpositon to this position
                Call GoToPosition()
                txtDrop.BackColor = Color.FromArgb(100, 100, 100) ' RGB(100, 100, 100)
                txtDrop.Text = ""
                TxtWidth.Text = ""
                txtCLO.Text = ""
                txtDrop.Focus() 'SetFocus()
                ComboBoxModel.SelectedIndex = -1
                ComboBoxModel.SelectedText = ""
                ComboBoxModel.Refresh()
                BlockInputFields(False)
                Widthentered = False
                Dropentered = False
                Modelentered = False
                NextButton.Text = "START"
                instructionLabel.Text = "MOUNT THE SHADE, THEN HIT START"
                Measurement.StopContMeasurement()
                SeqStep = 0
                Inspection.ResetCycle()
                Measurement.ResetCycle()
        End Select
        TextBox2.Text = SeqStep.ToString()

        DoGoBack = False
    End Sub


    Private Sub ProductionCycleOrg()         ' original production cycle without measurements in it

        Select Case SeqStep

            Case 0
                'waiting for data to be entered
                If (Dropentered) Then
                    If (Len(txtDrop.Text) > 0) And (Val(txtDrop.Text) > 0) Then
                        txtCLO.Text = Format(Val(txtDrop.Text) / 2, "####.000")
                        txtDrop.BackColor = Color.White 'vbWhite
                        TxtWidth.BackColor = Color.White 'vbWhite
                        lastinstruction = instructionLabel.Text
                        NextButton.Text = "START"
                        instructionLabel.Text = "MOUNT THE SHADE, THEN HIT START"
                        SeqStep += 1
                    End If
                End If
                If (NextStep()) Then
                    MsgBox("Enter Shade Info, then hit START")
                End If

            Case 1 'data entered: check it 
                If (NextStep()) Then
                    If (CorrectDataAvailable()) Then
                        lastposition = txtPosition.Text
                        txtPosition.Text = Val(txtDrop.Text) + Eye_Level ' was 11 inch
                        GoToPosition()
                        lastinstruction = instructionLabel.Text
                        instructionLabel.Text = "SPLIT TWO CELLS, THEN HIT NEXT"
                        NextButton.Text = "NEXT"
                        SeqStep += 1
                    Else
                        SeqStep = 0
                    End If
                End If
            Case 2
                If (nextstep()) Then
                    lastposition = txtPosition.Text
                    txtPosition.Text = Val(txtDrop.Text) + Cut_Liner_level_delta  ' was -10 inch
                    GoToPosition()
                    lastinstruction = instructionLabel.Text
                    instructionLabel.Text = "CUT LINER, THEN HIT NEXT"
                    NextButton.Text = "NEXT"
                    SeqStep += 1
                End If
            Case 3
                If (nextstep()) Then
                    lastposition = txtPosition.Text
                    txtPosition.Text = Val(txtDrop.Text)
                    GoToPosition()
                    lastinstruction = instructionLabel.Text
                    instructionLabel.Text = "ATTACH BOTTOM BAR AND SET DROP, THEN HIT NEXT"
                    NextButton.Text = "NEXT"
                    SeqStep += 1
                End If
            Case 4
                If (nextstep()) Then
                    lastposition = txtPosition.Text
                    txtPosition.Text = Val(txtDrop.Text) + OldInspection_Delta
                    GoToPosition()
                    lastinstruction = instructionLabel.Text
                    instructionLabel.Text = "INSPECT SHADE, THEN HIT NEXT"
                    NextButton.Text = "NEXT"
                    SeqStep += 1
                End If
            Case 5
                If (nextstep()) Then
                    lastposition = txtPosition.Text
                    txtPosition.Text = Val(GalilActVal_form.txtHomeoffset.Text)
                    GoToPosition()
                    lastinstruction = instructionLabel.Text
                    instructionLabel.Text = "REMOVE THE SHADE"
                    txtDrop.BackColor = Color.FromArgb(100, 100, 100) ' RGB(100, 100, 100)
                    txtDrop.Text = ""
                    txtDrop.Focus() 'SetFocus()
                    NextButton.Text = "DONE"
                    SeqStep = 0
                End If
            Case 30  ' reset the production cycle
                txtPosition.Text = Val(GalilActVal_form.txtHomeoffset.Text)
                lastposition = txtPosition.Text
                Call GoToPosition()
                txtDrop.BackColor = Color.FromArgb(100, 100, 100) ' RGB(100, 100, 100)
                txtDrop.Text = ""
                txtDrop.Focus() 'SetFocus()

                NextButton.Text = "START"
                instructionLabel.Text = "MOUNT THE SHADE, THEN HIT START"
                lastinstruction = instructionLabel.Text
                SeqStep = 0

        End Select

        Dropentered = False
    End Sub

    Private Function CorrectDataAvailable() As Boolean
        If (Val(txtDrop.Text) < LowLimit) Or (Val(txtCLO.Text) < LowLimit) Then
            MsgBox("The Drop value or Cord Value is less than the soft stop.  Please change the values and proceed.", vbExclamation, "Below Soft Stop")
            Return False
        Else
            Return True
        End If
    End Function

    Private Function CorrectDataAvailableNewProd() As Boolean
        Dim ok As Boolean = True
        If (Val(txtDrop.Text) > 0) Then

        Else
            Dropentered = False
            ok = False
        End If
        If (Val(TxtWidth.Text) > 0) Then
        Else
            Widthentered = False
            ok = False
        End If
        If (ComboBoxModel.SelectedItem.ToString() <> "") Then
        Else
            Modelentered = False
            ok = False
        End If

        If ok Then ' if all is entered we need to check the drop value's
            If (Val(txtDrop.Text) < LowLimit) Or (Val(txtCLO.Text) < LowLimit) Then
                MsgBox("The Drop value or Cord Value is less than the soft stop. ", vbExclamation, "Below Soft Stop")
                Dropentered = False
                ok = False
            Else
                Modelentered = False  '' all is well so we reset these entered boolean for next cycle
                Dropentered = False
                Widthentered = False
            End If
        End If
        Return ok
    End Function

    Private Sub cmdGoBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGoBack.Click
        If (SeqStep = 8) And (ProductionType = 1) Then
            DoGoBack = True  ' this is to go back to setting the drop after final measurement failed
        Else
            SeqStep = SeqStep - 1 ' normally we just go back one step
            txtPosition.Text = lastposition
            instructionLabel.Text = lastinstruction
            Call GoToPosition()
            'MsgBox(" lastposition was " + lastposition + "currentpos= " + DMCPoll1.Text)
        End If
    End Sub

    Private Sub cmdResetSeq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResetSeq.Click
        Dim iResponse As Integer
        iResponse = MsgBox("Hoist will return to Eye Level", vbYesNo, "DELETE")
        If iResponse = vbYes Then ' They Clicked YES!

            SeqStep = 30  ' resets the production cycle
        End If
    End Sub




    '//////////////////end of things for production cycle

    Private Sub txtDrop_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDrop.Click
        If (txtDrop.ReadOnly = False) Then
            KeyPad_Form.txtValueKeyPad.Text = ""
            KeyPad_Form.MaskedTextBox1.Text = ""
            KeyPad_Form.txtValueKeyPad.Visible = True
            KeyPad_Form.KeyBoard.Visible = False
            KeyPad_Form.MaskedTextBox1.Visible = False
            KeyPad_Form.Numpad.Visible = True
            KeyPad_Form.Size = New Size(291, 392) '   (746, 392)
            KeyPad_Form.ShowDialog()
            txtDrop.Text = KeyPad_Form.txtValueKeyPad.Text
        End If
    End Sub

    Private Sub txtCLO_on_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCLO.Click
        KeyPad_Form.txtValueKeyPad.Text = ""
        KeyPad_Form.MaskedTextBox1.Text = ""
        KeyPad_Form.txtValueKeyPad.Visible = True
        KeyPad_Form.KeyBoard.Visible = False
        KeyPad_Form.MaskedTextBox1.Visible = False
        KeyPad_Form.Numpad.Visible = True
        KeyPad_Form.Size = New Size(291, 392) '   (746, 392)
        KeyPad_Form.ShowDialog()
        txtCLO.Text = KeyPad_Form.txtValueKeyPad.Text
    End Sub

    Private Sub txtPosition_on_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPosition.Click
        KeyPad_Form.txtValueKeyPad.Text = ""
        KeyPad_Form.MaskedTextBox1.Text = ""
        KeyPad_Form.txtValueKeyPad.Visible = True
        KeyPad_Form.KeyBoard.Visible = False
        KeyPad_Form.MaskedTextBox1.Visible = False
        KeyPad_Form.Numpad.Visible = True
        KeyPad_Form.Size = New Size(291, 392) '   (746, 392)
        KeyPad_Form.ShowDialog()
        txtPosition.Text = KeyPad_Form.txtValueKeyPad.Text
    End Sub

    Private Sub txtDrop_on_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDrop.TextChanged
        Dropentered = True
    End Sub
    Private Sub TxtWidth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtWidth.TextChanged
        Widthentered = True
    End Sub
    Private Sub ComboBoxModel_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxModel.SelectionChangeCommitted
        Modelentered = True
        ModelFiles.OpenReadHasCordsModelFile("..\ModelFiles\" + ComboBoxModel.SelectedItem.ToString(), HasCords)
        If (HasCords = 1) Then
            txtCLO.Visible = True
            LabelCordLength.Visible = True
        Else
            txtCLO.Visible = False
            LabelCordLength.Visible = False
        End If
    End Sub

    '// buttons to go to other pages 

    Private Sub ButtonInspection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonInspection.Click
        Inspection.ShowDialog()
    End Sub

    Private Sub service_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles service_btn.Click
        KeyPad_Form.txtValueKeyPad.Text = ""
        KeyPad_Form.MaskedTextBox1.Text = ""
        KeyPad_Form.Numpad.Visible = False
        KeyPad_Form.txtValueKeyPad.Visible = False
        KeyPad_Form.MaskedTextBox1.Visible = True
        KeyPad_Form.KeyBoard.Visible = True
        'KeyPad_Form.KeyBoard.Visible = True
        KeyPad_Form.Size = New Size(779, 278) '   (746, 392)
        KeyPad_Form.ShowDialog()
        If KeyPad_Form.MaskedTextBox1.Text = "SOLERA" Then
            'If KeyPad_Form.MaskedTextBox1.Text = "S" Then
            Service_Form_DB.ShowDialog()
        End If
    End Sub

    '//// timer for all non realtime cycli , measurement and inspection

    Private Sub TimerCyclicWork_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCyclicWork.Tick
        TimerCyclicWork.Enabled = False
        If (ProductionType > 0) Then
            ProductionCycleWithMeasurement()
            Inspection.InspectionCycle()
            Measurement.DoMeasureCyClic()
        Else
            ProductionCycleOrg()
        End If
        TimerCyclicWork.Enabled = True
    End Sub


    Private Sub TxtWidth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtWidth.Click
        If (TxtWidth.ReadOnly = False) Then
            KeyPad_Form.txtValueKeyPad.Text = ""
            KeyPad_Form.MaskedTextBox1.Text = ""
            KeyPad_Form.txtValueKeyPad.Visible = True
            KeyPad_Form.KeyBoard.Visible = False
            KeyPad_Form.MaskedTextBox1.Visible = False
            KeyPad_Form.Numpad.Visible = True
            KeyPad_Form.Size = New Size(291, 392) '   (746, 392)
            KeyPad_Form.ShowDialog()
            TxtWidth.Text = KeyPad_Form.txtValueKeyPad.Text
        End If
    End Sub
    ' this timer used to check the pop up request and do the showdialog of the inspection page
    ' i want to call the showdialog from this timer thread instead of calling it directly and lockup the main page.


    Private Sub TimerCheckPopup_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCheckPopup.Tick
        If ProductionType > 0 Then
            TimerCheckPopup.Enabled = False
            If (PopUpInspection) Then
                PopUpInspection = False
                Inspection.ShowDialog()
                NextButton.GoNextstep()
            End If
            TimerCheckPopup.Enabled = True
        End If

    End Sub

    Public Function LoadGenSettingsParams() As Boolean
        ' loading some of the parameters that are also called and used in the measurement page. We need some of them here ...

        ParamFiles.OpenReadParamFile(ParamFileName, "ProductionType", ProductionType) ' 0 is old , 1 is new, 2 is not used yet
        ParamFiles.OpenReadParamFile(ParamFileName, "Eye_Level", Eye_Level) ' 11 inches
        ParamFiles.OpenReadParamFile(ParamFileName, "Cut_Liner_level_delta", Cut_Liner_level_delta) '10 inches down, thus -10
        ParamFiles.OpenReadParamFile(ParamFileName, "OldInspection_Delta", OldInspection_Delta) '10 inches 
        ParamFiles.OpenReadParamFile(ParamFileName, "Mount_Ring_Pos", Mount_Ring_Pos)
        ParamFiles.OpenReadParamFile(ParamFileName, "LowLimit", LowLimit)
        ParamFiles.OpenReadParamFile(ParamFileName, "HighLimit", HighLimit)
        ParamFiles.OpenReadParamFile(ParamFileName, "MeasureDrop", MeasureDrop)
        ParamFiles.OpenReadParamFile(ParamFileName, "MeasureWidth", MeasureWidth)
        ParamFiles.OpenReadParamFile(ParamFileName, "MeasureSquareness", MeasureSquareness)

        Return (True)
    End Function


    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        OrdersTableAdapter1.Update(HoistOrders1DataSet)
    End Sub

    Private Sub ButtonUseDatSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUseDatSelected.Click
        Dim ind As Integer = 0


        For ind = 0 To DataGridViewOrders.Columns.Count - 1
            If (DataGridViewOrders.Columns(ind).HeaderText.Equals("OrderNr")) Then Exit For
        Next

        Dim value As Object = DataGridViewOrders.CurrentRow.Cells(ind).Value.ToString
        If IsDBNull(value) Then
            'txtDrop.Text = "" ' blank if dbnull values
        Else
            TextBoxOrderNr.Text = CType(value, String)
        End If

        For ind = 0 To DataGridViewOrders.Columns.Count - 1
            If (DataGridViewOrders.Columns(ind).HeaderText.Equals("Drop")) Then Exit For
        Next

        value = DataGridViewOrders.CurrentRow.Cells(ind).Value.ToString
        If IsDBNull(value) Then
            'txtDrop.Text = "" ' blank if dbnull values
        Else
            txtDrop.Text = CType(value, String)
        End If

        For ind = 0 To DataGridViewOrders.Columns.Count - 1
            If (DataGridViewOrders.Columns(ind).HeaderText.Equals("Width")) Then Exit For
        Next

        value = DataGridViewOrders.CurrentRow.Cells(ind).Value.ToString
        If IsDBNull(value) Then
            TxtWidth.Text = "" ' blank if dbnull values
        Else
            TxtWidth.Text = CType(value, String)
        End If

        For ind = 0 To DataGridViewOrders.Columns.Count - 1
            If (DataGridViewOrders.Columns(ind).HeaderText.Equals("Model")) Then Exit For
        Next
        If (ind < DataGridViewOrders.Columns.Count - 1) Then
            value = DataGridViewOrders.CurrentRow.Cells(ind).Value
            If IsDBNull(value) Then
                TxtWidth.Text = "" ' blank if dbnull values
            Else
                Dim itemind As Integer = ComboBoxModel.FindString(CType(value, String) + ".xlsx")

                ComboBoxModel.SelectedIndex = -1
                If itemind > -1 Then
                    ComboBoxModel.SelectedIndex = itemind
                    ComboBoxModel.Refresh()
                    Modelentered = True
                    ModelFiles.OpenReadHasCordsModelFile("..\ModelFiles\" + ComboBoxModel.SelectedItem.ToString(), HasCords)
                    If (HasCords = 1) Then
                        txtCLO.Visible = True
                        LabelCordLength.Visible = True
                    Else
                        txtCLO.Visible = False
                        LabelCordLength.Visible = False
                    End If
                Else
                    MsgBox("Modelfile not found")
                End If

            End If
        End If
    End Sub


   
    Private Sub DataGridViewRollUpDist_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridViewRollUpDist.SelectionChanged
        Dim value As Object = DataGridViewRollUpDist.CurrentRow.Cells(1).Value.ToString

        If IsDBNull(value) Then
            txtRollup.Text = "" ' blank if dbnull values
        Else
            txtRollup.Text = CType(value, String)
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinerCombo.SelectedIndexChanged
        If LinerCombo.Text = "Liner" Then
            linerFlag = True
        Else
            linerFlag = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHem.SelectedIndexChanged
        nextButton.Focus()
    End Sub

    Dim dt As Date = Today

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ResultTodatabase(dt.ToShortDateString, TimeOfDay.ToShortTimeString, "12345", "20", "40", "202", "203", "204", "205", "300")
    End Sub
End Class
