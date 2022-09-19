
Imports HoistCalcLib1

Public Class Measurement

    Dim Calc As New HoistCalculations
    Dim myLogFile As New clsLogFile ' use to log various measurement to file
    Dim Loglevel As Integer = 4

    Dim USValueSensor(6, 100) As Double
    Dim USValueCombined(3, 100) As Double
    Dim USMeasurePosition As Double = 0
    Dim USNrOfMeasurements As Integer = 0
    Dim MeasureStatUS As Integer = 22
    Dim USCalcResultPair(3) As Double
    Dim CalculatedDropPair(3) As Double

    Dim nrGoodpoints As Integer

    Dim LaserErrNumber As Integer = 0

    'input from production for US measurement:
    Dim ProductMountOffset As Double = 0
    Dim ProdTheoDrop As Double = 0
    Dim ProdTheoWidth As Double = 0
    Dim ProdBarRadius As Double



    'input from production for laser
    Dim ProductVertLaserMeasureOffset As Double

    ' boolean for doing the continuous measurement for finding the right drop during clip installation
    Dim MeasureUsContinuous As Boolean = False

    'calib measurement for US
    Dim USCalibVal0(6) As Double  ' array of two for measurement result during calibration
    Dim USCalibVal1(6) As Double  ' array of two for measurement result during calibration

    Dim UsSensorSignalError(6) As Boolean
    ' for bottombar calibrations
    Dim NrOfMeasDistances As Double
    Dim MeasureDistanceStep As Double
    Dim FirstMeasureDist As Double
    Dim currentMeasureDist As Double
    Dim CntPointscalib As Integer

    'laser 
    Dim myPort As Array ' afrray of available serial ports 
    Delegate Sub SetTextCallBack(ByVal [text] As String) ' needed to set the received text from the serial port, the callback function commes from another context

    Dim LaserBeforeScale As Double = 0
    Dim LaserValue(20) As Double
    Dim LaserMeasurePosition As Double = 0
    Dim LaserCalibPos As Double
    Dim LaserNrOfMeasurements As Integer = 0        ' actual measurements as used for averaging
    Dim CalibLaserResult As Double = 0              ' reslut of the laser measurement on the calibration plate at the end of the product
    Dim LaserResult As Double = 0                   ' result of laser measurement on the endcap of the product
    Dim MeasuredWidthLaser As Double = 0            ' actual measured width of the product

    Dim MeasureStatLaser As Integer = 0
    Dim receiveText As String = ""
    Dim TimerReady As Boolean = False
    Dim FirstCRLFPos As Integer = 0
    Dim ComportOpen As Boolean = False


    Dim LaserErrnrToStrIndex(100) As Integer
    Dim Lasererrstr(20) As String


    Public Structure tMeasureParams

        Dim HasUS As Double
        Dim HasLaser As Double

        Dim UsADVoltsPerUnit As Double

        Dim UsMaxVolts As Double
        Dim UsMinVolts As Double
        Dim USPreferredMeasureDist As Double
        Dim PosWaitTimeCal As Double
        Dim PosWaitTimeProd As Double
        Dim ExtraDownMove As Double

        ' for the us triangle method:
        Dim UsSensorPosToRef1Pair0 As Double
        Dim UsRefAlfaPair0 As Double
        Dim USDistSensorsPair0 As Double

        Dim UsSensorPosToRef1Pair1 As Double
        Dim UsRefAlfaPair1 As Double
        Dim USDistSensorsPair1 As Double

        Dim UsSensorPosToRef1Pair2 As Double
        Dim UsRefAlfaPair2 As Double
        Dim USDistSensorsPair2 As Double

        Dim RefSensToRefHoist As Double
        Dim USOffset As Double

        Dim USMeasurePositionCalib0 As Double
        Dim USMeasurePositionCalib1 As Double
        Dim MeasureNtimesCalib As Double   'max 100
        Dim MeasureNtimes As Double        'max 100
        Dim MeasureNtimesCont As Double    'max 100
        Dim CalibBarRadius As Double
        Dim CalibBarDrop As Double
        Dim MirrorX1Position As Double  ' if sensor 0 is on the same side of the product as sensor 1, enter a 1 here to mirror the outcome of the x0 position calculation
        Dim MedianDeviationCalib As Double
        Dim MedianDeviationProd As Double
        Dim MedianDeviationCont As Double
        Dim SensorZeroLineToHoistForBBCal As Double

        Dim PosA As Double     ' position of the sensorpair
        Dim PosB As Double
        Dim PosC As Double
        Dim MountOffSetHorizontal As Double


        'for the laser
        Dim LaserScale As Double
        Dim LaserSensorPosition As Double
        Dim LaserCalibPlateOffset As Double
        Dim LaserTotalNrMeasurements As Double
        Dim Endcapcompensation As Double
        Dim ComportNr As Double
    End Structure

    Dim MeasureParams As tMeasureParams

    Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click
        MainForm.galil.command("STA")
        MeasureStatUS = 0
        MeasureStatLaser = 0
    End Sub

    Private Sub Measurement_control_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DoInit()
    End Sub

    Public Function DoInit() As Boolean
        LoadMeasureParams()

        If (MeasureParams.HasLaser = 1) Then
            myPort = IO.Ports.SerialPort.GetPortNames()
            If (PortComboBox.Items.Count = 0) Then
                PortComboBox.Items.AddRange(myPort)
            End If
            ButtonSend.Enabled = False
        End If
        'show the calibration values in the screen:(only of pair 0)
        TextBoxAlfa.Text = MeasureParams.UsRefAlfaPair0.ToString("###0.0000")
        TextBoxSensposToRef1.Text = MeasureParams.UsSensorPosToRef1Pair0.ToString("###0.0000")
        TextBoxDistSensors.Text = MeasureParams.USDistSensorsPair0.ToString("###0.0000")
        ' automatically start the initialisation of the laser, send setting to the laser via the com port
        If (MeasureStatLaser = 0) And (MeasureParams.HasLaser = 1) Then
            MeasureStatLaser = 1
        End If

        If (MeasureStatUS = 0) And (MeasureParams.HasUS = 1) Then
            MeasureStatUS = 22  '' auto skip calibration

        End If
        LaserErrnrToStrIndex(15) = 0
        LaserErrnrToStrIndex(16) = 1
        LaserErrnrToStrIndex(17) = 2
        LaserErrnrToStrIndex(18) = 3
        LaserErrnrToStrIndex(19) = 4
        LaserErrnrToStrIndex(23) = 5
        LaserErrnrToStrIndex(24) = 6
        LaserErrnrToStrIndex(31) = 7
        LaserErrnrToStrIndex(51) = 8
        LaserErrnrToStrIndex(52) = 9
        LaserErrnrToStrIndex(53) = 10
        LaserErrnrToStrIndex(54) = 11
        LaserErrnrToStrIndex(55) = 12
        LaserErrnrToStrIndex(61) = 13
        LaserErrnrToStrIndex(62) = 14
        LaserErrnrToStrIndex(63) = 15
        LaserErrnrToStrIndex(64) = 16

        Lasererrstr(0) = "Excessively poor reflexes; Distance sensor (Front edge) against target < 0.1m"
        Lasererrstr(1) = "Excessively strong reflexes"
        Lasererrstr(2) = "Too much steady light (for example sun)"
        Lasererrstr(3) = "Only in DX mode (50 Hz): too much differ­ ence between measured and pre-calculated value"
        Lasererrstr(4) = "Only in DX mode (50 Hz):Target motion speed > 10 m/s"
        Lasererrstr(5) = "Temperature below -10 °C"
        Lasererrstr(6) = "Temperature above +60 °C"
        Lasererrstr(7) = "Faulty EEPROM checksum, hardware error"
        Lasererrstr(8) = "Failure to set avalanche voltage of diode laser 1. straylight or 2. hardware error"
        Lasererrstr(9) = "Laser current too high / laser defective"
        Lasererrstr(10) = "One or more parameters in the EEPROM not set (Consequence: Division by 0)"
        Lasererrstr(11) = "Hardware error (PLL)"
        Lasererrstr(12) = "Hardware error"
        Lasererrstr(13) = "Used parameter is inadmissible, invalid command sent "
        Lasererrstr(14) = "1. Hardware error 2. wrong value in interface communication (Parity error SIO)"
        Lasererrstr(15) = "SIO overflow"
        Lasererrstr(16) = "Framing-Error SIO"




        Return True
    End Function

    Private Sub ButtonOpenComPort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOpenComPort.Click
        Try
            OpenComPort(PortComboBox.Text)
            ButtonSend.Enabled = True
            ComportOpen = True
        Catch
            MainForm.ShowErrorInMessageBox("laser comport not available")
        End Try

    End Sub

    Private Function OpenComPort(ByVal comportname As String) As Boolean
        Try
            SerialPort1.PortName = comportname
            SerialPort1.BaudRate = "38400"
            SerialPort1.Parity = 0
            SerialPort1.StopBits = 1
            SerialPort1.Open()
            ButtonSend.Enabled = True
        Catch e As Exception
            MainForm.ShowErrorInMessageBox("error opening comport") ' + e.ToString())
            Return (False)
        End Try
        Return (True)
    End Function

    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText(SerialPort1.ReadExisting())
    End Sub
    Private Sub ReceivedText(ByVal [text] As String)
        If ComportOpen Then
            If Me.TextBoxReceive.InvokeRequired Then
                Dim x As New SetTextCallBack(AddressOf ReceivedText)
                Me.Invoke(x, New Object() {(text)})
            Else
                receiveText = receiveText + [text]
                TextBoxReceive.AppendText([text])

            End If
        Else
            receiveText = receiveText + [text]
        End If
    End Sub


    Function CheckReceivetextforError() As Boolean

        If receiveText.Contains("E") Then
            Dim ind As Integer = receiveText.IndexOf("E")
            ' MsgBox("error number is: " + receiveText.Substring(ind + 1, 2))
            Integer.TryParse(receiveText.Substring(ind + 1, 2), LaserErrNumber)
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub Measurement_control_Form_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        MeasureUsContinuous = False
    End Sub

    Private Sub ButtonSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSend.Click
        SerialPort1Write(TextBoxSend.Text & vbCrLf)
        TextBoxSend.Clear()
        TextBoxReceive.Clear()
    End Sub
    Private Sub SerialPort1Write(ByVal SendStr As String)
        Try
            SerialPort1.Write(SendStr)
            TextBoxLog.AppendText(SendStr)
        Catch
            MainForm.ShowErrorInMessageBox("serial port not open")
        End Try

    End Sub

    Private Sub ButtonSerialPortClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSerialPortClose.Click
        SerialPort1.Close()
    End Sub


    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Public Function CheckSensorLevel(ByRef aSensorsignal As Double, ByVal sensor As Integer) As Boolean
        Dim ok As Boolean
        If (aSensorsignal > MeasureParams.UsMaxVolts) Then
            UsSensorSignalError(sensor) = True
            aSensorsignal = -1
            If Loglevel > 3 Then
                TextBoxLog.AppendText("error > sensor " & sensor.ToString() & vbCrLf)
            End If
        Else
            If (aSensorsignal < MeasureParams.UsMinVolts) Then
                UsSensorSignalError(sensor) = True
                aSensorsignal = -1
                If Loglevel > 3 Then
                    TextBoxLog.AppendText("error < sensor  " & sensor.ToString() & vbCrLf)
                End If
            End If
        End If


        Return ok
    End Function


    Public Function EnterUSMeasurement(ByVal USValue0 As String, ByVal USValue1 As String, ByVal USValue2 As String, ByVal USValue3 As String, ByVal USValue4 As String, ByVal USValue5 As String) As Boolean
        ' called from the main page when us values come in from the galil board
        TextBox_InputA0.Text = USValue0
        TextBox_OrderNr.Text = USValue1

        If Double.TryParse(USValue0, USValueSensor(0, USNrOfMeasurements)) Then
        Else
            USValueSensor(0, USNrOfMeasurements) = 0
        End If
        If Double.TryParse(USValue1, USValueSensor(1, USNrOfMeasurements)) Then
        Else
            USValueSensor(1, USNrOfMeasurements) = 0
        End If
        If Double.TryParse(USValue2, USValueSensor(2, USNrOfMeasurements)) Then
        Else
            USValueSensor(2, USNrOfMeasurements) = 0
        End If
        If Double.TryParse(USValue3, USValueSensor(3, USNrOfMeasurements)) Then
        Else
            USValueSensor(3, USNrOfMeasurements) = 0
        End If
        If Double.TryParse(USValue4, USValueSensor(4, USNrOfMeasurements)) Then
        Else
            USValueSensor(4, USNrOfMeasurements) = 0
        End If
        If Double.TryParse(USValue5, USValueSensor(5, USNrOfMeasurements)) Then
        Else
            USValueSensor(5, USNrOfMeasurements) = 0
        End If



        Double.TryParse(position, USMeasurePosition)


        CheckSensorLevel(USValueSensor(0, USNrOfMeasurements), 0)

        If NumberOfSensorUsed > 1 Then
            CheckSensorLevel(USValueSensor(1, USNrOfMeasurements), 1)
        End If
        If NumberOfSensorUsed > 2 Then
            CheckSensorLevel(USValueSensor(2, USNrOfMeasurements), 2)
        End If
        If NumberOfSensorUsed > 3 Then
            CheckSensorLevel(USValueSensor(3, USNrOfMeasurements), 3)
        End If
        If NumberOfSensorUsed > 4 Then
            CheckSensorLevel(USValueSensor(4, USNrOfMeasurements), 4)
        End If
        If NumberOfSensorUsed > 5 Then
            CheckSensorLevel(USValueSensor(5, USNrOfMeasurements), 5)
        End If
        USNrOfMeasurements += 1
        Return True
    End Function



    Private Function LogSensValues(ByVal aNrOfSensors As Integer, ByVal unitname As String)
        For cnt = 0 To USNrOfMeasurements - 1
            For senscnt = 0 To aNrOfSensors - 1
                TextBoxLog.AppendText(" USValue" + senscnt.ToString() + " " + unitname + "= ;" & USValueSensor(senscnt, cnt).ToString("###0.0000") & ";")
            Next
            TextBoxLog.AppendText(vbCrLf)
        Next
        Return True
    End Function

    Private Function ResetMeasErr() As Boolean
        For cnt = 0 To 5
            UsSensorSignalError(cnt) = False
        Next
        Return True
    End Function
    Private Function IsAnyMeasErr() As Boolean
        Dim ok As Boolean = False
        For cnt = 0 To 5
            If UsSensorSignalError(cnt) Then
                ok = False
            End If
        Next
        Return ok
    End Function

    ' in calibration if sensor error the whole calib is invalid for that sensorpair, value is -1
    ' in production a sensor error  puts -1 in sensor values array , triangle calc will prouce a -1 as well and that will filter out at taking the median etc.

    Public Function DoMeasureCyClic()
        DMCPoll1.Text = MainForm.DMCPoll1.Text
        'cycle for one measurement with all calculations and evaluation
        If (MeasureParams.HasUS = 1) Then
            StepperUS()
        Else
            MeasureStatUS = 0
        End If
        If (MeasureParams.HasLaser = 1) Then
            StepperLaser()
        Else
            MeasureStatLaser = 0
        End If
        TextBoxSSwUs.Text = MeasureStatUS.ToString
        TextBoxCycleLaser.Text = MeasureStatLaser.ToString()
        textboxnrof.Text = LaserNrOfMeasurements.ToString()
        Return True
    End Function

    Private Function StepperUS() As Boolean
        Select Case MeasureStatUS
            Case 0 ' wait for command to start calib

            Case 1 ' start calibration
                ErrorUSVolts.Visible = False
                ResetMeasErr()
                'MainForm.txtPosition.Text = MeasureParams.USMeasurePositionCalib0.ToString("###0.0000")
                MainForm.GoPosPosition = MeasureParams.USMeasurePositionCalib0
                MainForm.ExtraDownMove = MeasureParams.ExtraDownMove

                TextBoxLog.Text = " "
                TextBoxLog.AppendText("start of calibration" & vbCrLf)
                TextBoxLog.AppendText("first calibration position =" & MeasureParams.USMeasurePositionCalib0.ToString("###0.0000") & vbCrLf)
                ' MainForm.GoToPosition()
                MainForm.GoPosUpStat = 1
                MeasureStatUS += 1

            Case 2
                If MainForm.GoPosUpStat = 0 Then
                    Settimer(MeasureParams.PosWaitTimeCal)
                    USSensorsOn = True
                    MeasureStatUS += 1
                End If
            Case 3
                If (TimerReady) Then
                    USNrOfMeasurements = 0
                    ResetMeasErr()
                    DoUSMeasurement = True
                    MeasureStatUS += 1
                End If
            Case 4
                If (USNrOfMeasurements > MeasureParams.MeasureNtimesCalib) Then
                    DoUSMeasurement = False
                    USSensorsOn = False
                    If IsAnyMeasErr() Then
                        ErrorUSVolts.Visible = True
                    End If
                    MeasureStatUS += 1
                End If
            Case 5
                LogSensValues(NumberOfSensorUsed, "volts")

                For cnt = 0 To NumberOfSensorUsed - 1
                    ConvertUSToUnits(USValueSensor, USNrOfMeasurements, cnt, MeasureParams.UsADVoltsPerUnit, MeasureParams.USOffset, Loglevel)
                Next

                LogSensValues(NumberOfSensorUsed, "units")

                For Scnt = 0 To NumberOfSensorUsed - 1

                    TextBoxLog.AppendText("calc med outl avg sensor " + Scnt.ToString() + " " & vbCrLf)
                    If (UsSensorSignalError(Scnt) = False) Then
                        USCalibVal0(Scnt) = Calc.calculate_median_outliers_average(USValueSensor, Scnt, USNrOfMeasurements, MeasureParams.MedianDeviationCalib, Loglevel, nrGoodpoints)
                    Else
                        USCalibVal0(Scnt) = -1
                    End If
                    TextBoxLog.AppendText("med-outl-avg sensor" + Scnt.ToString() + " =" & USCalibVal0(Scnt).ToString("###0.0000") & vbCrLf)

                Next



                TextBoxCB0_0.Text = USCalibVal0(0).ToString("###0.0000")
                TextBoxCB1_0.Text = USCalibVal0(1).ToString("###0.0000")




                MeasureStatUS += 1
            Case 6
                'MainForm.txtPosition.Text = MeasureParams.USMeasurePositionCalib1.ToString("###0.0000")
                MainForm.GoPosPosition = MeasureParams.USMeasurePositionCalib1
                MainForm.ExtraDownMove = MeasureParams.ExtraDownMove
                TextBoxLog.AppendText("second calibration position =" & MeasureParams.USMeasurePositionCalib1.ToString("###0.0000") & vbCrLf)

                'MainForm.GoToPosition()
                MainForm.GoPosUpStat = 1
                MeasureStatUS += 1

            Case 7
                If MainForm.GoPosUpStat = 0 Then
                    Settimer(MeasureParams.PosWaitTimeCal)
                    USSensorsOn = True
                    MeasureStatUS += 1
                End If
            Case 8
                If (TimerReady) Then
                    USNrOfMeasurements = 0
                    ResetMeasErr()
                    DoUSMeasurement = True
                    MeasureStatUS += 1
                End If
            Case 9
                If (USNrOfMeasurements > MeasureParams.MeasureNtimesCalib) Then
                    DoUSMeasurement = False
                    USSensorsOn = False
                    If IsAnyMeasErr() Then
                        ErrorUSVolts.Visible = True
                    End If
                    MeasureStatUS += 1
                End If
            Case 10
                LogSensValues(NumberOfSensorUsed, "volts")

                For cnt = 0 To NumberOfSensorUsed - 1
                    ConvertUSToUnits(USValueSensor, USNrOfMeasurements, cnt, MeasureParams.UsADVoltsPerUnit, MeasureParams.USOffset, Loglevel)
                Next

                LogSensValues(NumberOfSensorUsed, "units")

                For Scnt = 0 To NumberOfSensorUsed - 1

                    TextBoxLog.AppendText("calc med outl avg sensor " + Scnt.ToString() + " " & vbCrLf)
                    If (UsSensorSignalError(Scnt) = False) Then
                        USCalibVal1(Scnt) = Calc.calculate_median_outliers_average(USValueSensor, Scnt, USNrOfMeasurements, MeasureParams.MedianDeviationCalib, Loglevel, nrGoodpoints)
                    Else
                        USCalibVal1(Scnt) = -1
                    End If
                    TextBoxLog.AppendText("med-outl-avg sensor" + Scnt.ToString() + " =" & USCalibVal1(Scnt).ToString("###0.0000") & vbCrLf)

                Next



                TextBoxCB0_1.Text = USCalibVal1(0).ToString("###0.0000")
                TextBoxCB1_1.Text = USCalibVal1(1).ToString("###0.0000")



                MeasureStatUS += 1

            Case 11
                'do calib calculation for pair0
                TextBoxLog.AppendText("pair0 " + vbCrLf)
                Calc.CalcCalibrationTriangle(0, (MeasureParams.MirrorX1Position = 1), MeasureParams.CalibBarRadius, USCalibVal0, USCalibVal1, MeasureParams.UsRefAlfaPair0, MeasureParams.USMeasurePositionCalib1 - MeasureParams.USMeasurePositionCalib0, MeasureParams.UsSensorPosToRef1Pair0, MeasureParams.USDistSensorsPair0)

                TextBoxAlfa.Text = MeasureParams.UsRefAlfaPair0.ToString("###0.0000")
                TextBoxSensposToRef1.Text = MeasureParams.UsSensorPosToRef1Pair0.ToString("###0.0000")
                TextBoxDistSensors.Text = MeasureParams.USDistSensorsPair0.ToString("###0.0000")

                TextBoxLog.AppendText("alfa =" & MeasureParams.UsRefAlfaPair0.ToString("###0.0000") & vbCrLf)
                TextBoxLog.AppendText("sens1pos toref =" & MeasureParams.UsSensorPosToRef1Pair0.ToString("###0.0000") & vbCrLf)
                TextBoxLog.AppendText("DistSensors =" & MeasureParams.USDistSensorsPair0.ToString("###0.0000") & vbCrLf)
                If ((NumberOfSensorUsed / 2) > 1) Then
                    'do calib calculation for pair1
                    TextBoxLog.AppendText("pair1 " + vbCrLf)
                    Calc.CalcCalibrationTriangle(1, (MeasureParams.MirrorX1Position = 1), MeasureParams.CalibBarRadius, USCalibVal0, USCalibVal1, MeasureParams.UsRefAlfaPair1, MeasureParams.USMeasurePositionCalib1 - MeasureParams.USMeasurePositionCalib0, MeasureParams.UsSensorPosToRef1Pair1, MeasureParams.USDistSensorsPair1)

                    'TextBoxAlfa.Text = MeasureParams.UsRefAlfaPair1.ToString("###0.0000")
                    'TextBoxSensposToRef1.Text = MeasureParams.UsSensorPosToRef1Pair1.ToString("###0.0000")
                    'TextBoxDistSensors.Text = MeasureParams.USDistSensorsPair1.ToString("###0.0000")

                    TextBoxLog.AppendText("alfa =" & MeasureParams.UsRefAlfaPair1.ToString("###0.0000") & vbCrLf)
                    TextBoxLog.AppendText("sens1pos toref =" & MeasureParams.UsSensorPosToRef1Pair1.ToString("###0.0000") & vbCrLf)
                    TextBoxLog.AppendText("DistSensors =" & MeasureParams.USDistSensorsPair1.ToString("###0.0000") & vbCrLf)
                End If

                'do calib calculation for Pair2
                If ((NumberOfSensorUsed / 2) > 2) Then
                    TextBoxLog.AppendText("pair2 " + vbCrLf)
                    Calc.CalcCalibrationTriangle(2, (MeasureParams.MirrorX1Position = 1), MeasureParams.CalibBarRadius, USCalibVal0, USCalibVal1, MeasureParams.UsRefAlfaPair2, MeasureParams.USMeasurePositionCalib1 - MeasureParams.USMeasurePositionCalib0, MeasureParams.UsSensorPosToRef1Pair2, MeasureParams.USDistSensorsPair2)

                    ' TextBoxAlfa.Text = MeasureParams.UsRefAlfaPair2.ToString("###0.0000")
                    ' TextBoxSensposToRef1.Text = MeasureParams.UsSensorPosToRef1Pair2.ToString("###0.0000")
                    ' TextBoxDistSensors.Text = MeasureParams.USDistSensorsPair2.ToString("###0.0000")

                    TextBoxLog.AppendText("alfa =" & MeasureParams.UsRefAlfaPair2.ToString("###0.0000") & vbCrLf)
                    TextBoxLog.AppendText("sens1pos toref =" & MeasureParams.UsSensorPosToRef1Pair2.ToString("###0.0000") & vbCrLf)
                    TextBoxLog.AppendText("DistSensors =" & MeasureParams.USDistSensorsPair2.ToString("###0.0000") & vbCrLf)
                End If



                MeasureParams.RefSensToRefHoist = CalcRefSensToRefHoist(MeasureParams.CalibBarDrop, 0, MeasureParams.CalibBarRadius, MeasureParams.USMeasurePositionCalib0)

                TextBoxLog.AppendText("RefSensToRefHoist =" & MeasureParams.RefSensToRefHoist.ToString("###0.0000") & vbCrLf)
                myLogFile.Setfilename("calibrationUS.txt ")
                myLogFile.SaveLog(TextBoxLog)
                TextBoxLog.Text = ""

                MeasureStatUS = 22

            Case 22  'idle 

            Case 23
                ' goto measurement position
                ErrorUSVolts.Visible = False
                ResetMeasErr()
                TextBoxLog.Text = ""

                USMeasurePosition = calcPreferredMeasurePos(ProductMountOffset, ProdTheoDrop, MeasureParams.USPreferredMeasureDist, MeasureParams.RefSensToRefHoist)
                TextBoxMeasurePositionUS.Text = USMeasurePosition.ToString("###0.0000")
                ' MainForm.txtPosition.Text = USMeasurePosition.ToString("###0.0000")
                MainForm.GoPosPosition = USMeasurePosition
                MainForm.ExtraDownMove = MeasureParams.ExtraDownMove
                'MainForm.GoToPosition()
                MainForm.GoPosUpStat = 1
                MeasureStatUS += 1

            Case 24
                If MainForm.GoPosUpStat = 0 Then
                    Settimer(MeasureParams.PosWaitTimeProd)
                    USSensorsOn = True
                    MeasureStatUS += 1
                End If

            Case 25
                If (TimerReady) Then
                    USNrOfMeasurements = 0
                    DoUSMeasurement = True
                    MeasureStatUS += 1
                End If

            Case 26
                If (USNrOfMeasurements > MeasureParams.MeasureNtimes) Then
                    DoUSMeasurement = False
                    USSensorsOn = False
                    If IsAnyMeasErr() Then
                        ErrorUSVolts.Visible = True
                    End If
                    MeasureStatUS += 1

                End If
            Case 27 ' do conversion and  calculate average
                TextBoxLog.AppendText("production measurement" & vbCrLf)

                LogSensValues(NumberOfSensorUsed, "volts")


                For Scnt = 0 To NumberOfSensorUsed - 1
                    ConvertUSToUnits(USValueSensor, USNrOfMeasurements, Scnt, MeasureParams.UsADVoltsPerUnit, MeasureParams.USOffset, Loglevel)
                Next

                LogSensValues(NumberOfSensorUsed, "units")



                '///
                TextBoxLog.AppendText("now doing the triangle calculation on all pairs of sensor values" + vbCrLf)
                CalcAllDistFromTriangle(0, ProdBarRadius, USValueSensor, USValueCombined, USNrOfMeasurements, MeasureParams.UsSensorPosToRef1Pair0, MeasureParams.USDistSensorsPair0, MeasureParams.UsRefAlfaPair0, 0) '  fill in calib values
                For cnt = 0 To USNrOfMeasurements - 1
                    TextBoxLog.AppendText(" USValueCombined  unit = ;" & USValueCombined(0, cnt).ToString("###0.0000") & ";" & vbCrLf)
                Next
                TextBoxLog.AppendText("med-outl-avg calc on combined us sensorpair  result" + vbCrLf)
                USCalcResultPair(0) = Calc.calculate_median_outliers_average(USValueCombined, 0, USNrOfMeasurements, MeasureParams.MedianDeviationProd, Loglevel, nrGoodpoints)
                ' MsgBox(" nr good points   " + nrGoodpoints.ToString + " USNrOfMeasurements    " + USNrOfMeasurements.ToString + "  USCalcResultPair(0)" + USCalcResultPair(0).ToString)
                If (nrGoodpoints < (USNrOfMeasurements / 4)) Then
                    TextBoxLog.AppendText("not enough valid measurements")
                    USCalcResultPair(0) = -1
                End If
                TextBoxResultUSCalcA.Text = USCalcResultPair(0).ToString("###0.0000")
                TextBoxLog.AppendText(" calc measuren by pair0 = " + USCalcResultPair(0).ToString("###0.0000"))
                CalculatedDropPair(0) = CalculateDrop(USCalcResultPair(0), ProductMountOffset, USMeasurePosition, MeasureParams.RefSensToRefHoist)

                If (nrGoodpoints < (USNrOfMeasurements / 4)) Or (USCalcResultPair(0) = -1) Then
                    CalculatedDropPair(0) = -1
                End If
                TextBoxMeasuredDropA.Text = CalculatedDropPair(0).ToString("###0.0000")
                TextBoxLog.AppendText(" drop measuren by pair0 = " + CalculatedDropPair(0).ToString("###0.0000") + vbCrLf)
                TextBoxPointsA.Text = nrGoodpoints
                '/////
                '///
                If (NumberOfSensorUsed / 2) > 1 Then
                    TextBoxLog.AppendText("now doing the triangle calculation on all pairs of sensor values" + vbCrLf)
                    CalcAllDistFromTriangle(1, ProdBarRadius, USValueSensor, USValueCombined, USNrOfMeasurements, MeasureParams.UsSensorPosToRef1Pair1, MeasureParams.USDistSensorsPair1, MeasureParams.UsRefAlfaPair1, 0) '  fill in calib values
                    For cnt = 0 To USNrOfMeasurements - 1
                        TextBoxLog.AppendText(" USValueCombined  unit = ;" & USValueCombined(1, cnt).ToString("###0.0000") & ";" & vbCrLf)
                    Next
                    TextBoxLog.AppendText("med-outl-avg calc on combined us sensorpair1 result" + vbCrLf)
                    USCalcResultPair(1) = Calc.calculate_median_outliers_average(USValueCombined, 1, USNrOfMeasurements, MeasureParams.MedianDeviationProd, Loglevel, nrGoodpoints)
                    If (nrGoodpoints < (USNrOfMeasurements / 4)) Then
                        USCalcResultPair(1) = -1
                    End If
                    TextBoxResultUSCalcB.Text = USCalcResultPair(1).ToString("###0.0000")
                    TextBoxLog.AppendText(" calc measuren by pair1 = " + USCalcResultPair(1).ToString("###0.0000"))
                    CalculatedDropPair(1) = CalculateDrop(USCalcResultPair(1), ProductMountOffset, USMeasurePosition, MeasureParams.RefSensToRefHoist)
                    If (nrGoodpoints < (USNrOfMeasurements / 4)) Or (USCalcResultPair(1) = -1) Then
                        CalculatedDropPair(1) = -1
                    End If
                    TextBoxLog.AppendText(" drop measuren by pair1 = " + CalculatedDropPair(1).ToString("###0.0000") + vbCrLf)
                    TextBoxMeasuredDropB.Text = CalculatedDropPair(1).ToString("###0.0000")
                    TextBoxPointsB.Text = nrGoodpoints

                    If (ProdTheoWidth > MeasureParams.PosB) Then
                    Else
                        CalculatedDropPair(1) = -2
                    End If
                End If
                '///
                If (NumberOfSensorUsed / 2) > 2 Then
                    TextBoxLog.AppendText("now doing the triangle calculation on all pairs of sensor values" + vbCrLf)
                    CalcAllDistFromTriangle(2, ProdBarRadius, USValueSensor, USValueCombined, USNrOfMeasurements, MeasureParams.UsSensorPosToRef1Pair2, MeasureParams.USDistSensorsPair2, MeasureParams.UsRefAlfaPair2, 0) '  fill in calib values
                    For cnt = 0 To USNrOfMeasurements - 1
                        TextBoxLog.AppendText(" USValueCombined  unit = ;" & USValueCombined(2, cnt).ToString("###0.0000") & ";" & vbCrLf)
                    Next
                    TextBoxLog.AppendText("med-outl-avg calc on combined us sensorpair2 result" + vbCrLf)
                    '/////

                    USCalcResultPair(2) = Calc.calculate_median_outliers_average(USValueCombined, 2, USNrOfMeasurements, MeasureParams.MedianDeviationProd, Loglevel, nrGoodpoints)
                    If (nrGoodpoints < (USNrOfMeasurements / 4)) Then
                        USCalcResultPair(2) = -1
                    End If
                    TextBoxResultUSCalcC.Text = USCalcResultPair(2).ToString("###0.0000")
                    TextBoxLog.AppendText(" calc measuren by pair2 = " + USCalcResultPair(2).ToString("###0.0000"))
                    CalculatedDropPair(2) = CalculateDrop(USCalcResultPair(2), ProductMountOffset, USMeasurePosition, MeasureParams.RefSensToRefHoist)
                    If (nrGoodpoints < (USNrOfMeasurements / 4)) Or (USCalcResultPair(2) = -1) Then
                        CalculatedDropPair(2) = -1
                    End If
                    TextBoxLog.AppendText(" drop measuren by pair2 = " + CalculatedDropPair(2).ToString("###0.0000") + vbCrLf)
                    TextBoxMeasuredDropC.Text = CalculatedDropPair(2).ToString("###0.0000")
                    TextBoxPointsC.Text = nrGoodpoints
                    If (ProdTheoWidth > MeasureParams.PosC) Then
                    Else
                        CalculatedDropPair(2) = -2
                    End If
                End If




                MeasureStatUS += 1
            Case 28
                myLogFile.Setfilename("productionUS.txt ")
                myLogFile.SaveLog(TextBoxLog)
                TextBoxLog.Text = ""
                MeasureStatUS = 22





                '///////////////// stepper part for continuous measurement of drop

            Case 33
                ' goto measurement position
                ErrorUSVolts.Visible = False
                ResetMeasErr()
                TextBoxLog.Text = ""
                USMeasurePosition = calcPreferredMeasurePos(ProductMountOffset, ProdTheoDrop, MeasureParams.USPreferredMeasureDist, MeasureParams.RefSensToRefHoist)
                'TextBoxMeasurePositionUS.Text = USMeasurePosition.ToString("###0.0000")
                MainForm.GoPosPosition = USMeasurePosition
                MainForm.ExtraDownMove = MeasureParams.ExtraDownMove
                'MainForm.txtPosition.Text = USMeasurePosition.ToString("###0.0000")
                'MainForm.GoToPosition()
                MainForm.GoPosUpStat = 1
                MeasureStatUS += 1

            Case 34
                If MainForm.GoPosUpStat = 0 Then
                    Settimer(1000)
                    USSensorsOn = True
                    MeasureStatUS += 1
                End If

            Case 35
                If (TimerReady) Then
                    USNrOfMeasurements = 0
                    DoUSMeasurement = True
                    MeasureStatUS += 1
                End If

            Case 36
                If (IsAnyMeasErr()) Then
                    If (MeasureUsContinuous) Then
                        ' MeasureStatUS = 35 we finish the cycle of nr of measurements if not operator stopped
                    Else
                        MeasureStatUS = 22
                        DoUSMeasurement = False
                        USSensorsOn = False
                        ResetMeasErr()
                        TextBoxResultUSCalcA.Text = " "
                        TextBoxMeasuredDropA.Text = " "
                        ErrorUSVolts.Visible = True
                    End If



                End If
                If (USNrOfMeasurements > MeasureParams.MeasureNtimesCont) Then
                    DoUSMeasurement = False
                    MeasureStatUS += 1
                End If

            Case 37 ' do conversion and  calculate average

                ConvertUSToUnits(USValueSensor, USNrOfMeasurements, 0, MeasureParams.UsADVoltsPerUnit, MeasureParams.USOffset, Loglevel)
                ConvertUSToUnits(USValueSensor, USNrOfMeasurements, 1, MeasureParams.UsADVoltsPerUnit, MeasureParams.USOffset, Loglevel)
                ConvertUSToUnits(USValueSensor, USNrOfMeasurements, 2, MeasureParams.UsADVoltsPerUnit, MeasureParams.USOffset, Loglevel)
                ConvertUSToUnits(USValueSensor, USNrOfMeasurements, 3, MeasureParams.UsADVoltsPerUnit, MeasureParams.USOffset, Loglevel)
                ConvertUSToUnits(USValueSensor, USNrOfMeasurements, 4, MeasureParams.UsADVoltsPerUnit, MeasureParams.USOffset, Loglevel)
                ConvertUSToUnits(USValueSensor, USNrOfMeasurements, 5, MeasureParams.UsADVoltsPerUnit, MeasureParams.USOffset, Loglevel)




                CalcAllDistFromTriangle(0, ProdBarRadius, USValueSensor, USValueCombined, USNrOfMeasurements, MeasureParams.UsSensorPosToRef1Pair0, MeasureParams.USDistSensorsPair0, MeasureParams.UsRefAlfaPair0, 0) '  fill in calib values
                USCalcResultPair(0) = Calc.calculate_median_outliers_average(USValueCombined, 0, USNrOfMeasurements, MeasureParams.MedianDeviationCont, 0, nrGoodpoints)
                If (nrGoodpoints < (USNrOfMeasurements / 4)) Then
                    USCalcResultPair(0) = -1
                End If
                TextBoxResultUSCalcA.Text = USCalcResultPair(0).ToString("###0.0000")
                CalculatedDropPair(0) = CalculateDrop(USCalcResultPair(0), ProductMountOffset, USMeasurePosition, MeasureParams.RefSensToRefHoist)
                If (nrGoodpoints < (USNrOfMeasurements / 4)) Or (USCalcResultPair(0) = -1) Then
                    CalculatedDropPair(0) = -1
                End If
                TextBoxMeasuredDropA.Text = CalculatedDropPair(0).ToString("###0.0000")
                TextBoxPointsA.Text = nrGoodpoints
                If ((NumberOfSensorUsed / 2) > 1) Then
                    CalcAllDistFromTriangle(1, ProdBarRadius, USValueSensor, USValueCombined, USNrOfMeasurements, MeasureParams.UsSensorPosToRef1Pair1, MeasureParams.USDistSensorsPair1, MeasureParams.UsRefAlfaPair1, 0) '  fill in calib values
                    USCalcResultPair(1) = Calc.calculate_median_outliers_average(USValueCombined, 1, USNrOfMeasurements, MeasureParams.MedianDeviationCont, 0, nrGoodpoints)
                    If (nrGoodpoints < (USNrOfMeasurements / 4)) Then
                        USCalcResultPair(1) = -1
                    End If
                    TextBoxResultUSCalcB.Text = USCalcResultPair(1).ToString("###0.0000")
                    CalculatedDropPair(1) = CalculateDrop(USCalcResultPair(1), ProductMountOffset, USMeasurePosition, MeasureParams.RefSensToRefHoist)
                    If (nrGoodpoints < (USNrOfMeasurements / 4)) Or (USCalcResultPair(1) = -1) Then
                        CalculatedDropPair(1) = -1
                    End If
                    TextBoxMeasuredDropB.Text = CalculatedDropPair(1).ToString("###0.0000")
                    TextBoxPointsB.Text = nrGoodpoints

                    If (ProdTheoWidth > MeasureParams.PosB) Then
                    Else
                        CalculatedDropPair(1) = -2
                    End If
                End If
                If ((NumberOfSensorUsed / 2) > 2) Then

                    CalcAllDistFromTriangle(2, ProdBarRadius, USValueSensor, USValueCombined, USNrOfMeasurements, MeasureParams.UsSensorPosToRef1Pair2, MeasureParams.USDistSensorsPair2, MeasureParams.UsRefAlfaPair2, 0) '  fill in calib values
                    USCalcResultPair(2) = Calc.calculate_median_outliers_average(USValueCombined, 2, USNrOfMeasurements, MeasureParams.MedianDeviationCont, 0, nrGoodpoints)
                    If (nrGoodpoints < (USNrOfMeasurements / 4)) Then
                        USCalcResultPair(2) = -1
                    End If
                    TextBoxResultUSCalcC.Text = USCalcResultPair(2).ToString("###0.0000")
                    CalculatedDropPair(2) = CalculateDrop(USCalcResultPair(2), ProductMountOffset, USMeasurePosition, MeasureParams.RefSensToRefHoist)
                    If (nrGoodpoints < (USNrOfMeasurements / 4)) Or (USCalcResultPair(2) = -1) Then
                        CalculatedDropPair(2) = -1
                    End If
                    TextBoxMeasuredDropC.Text = CalculatedDropPair(2).ToString("###0.0000")
                    TextBoxPointsC.Text = nrGoodpoints
                    If (ProdTheoWidth > MeasureParams.PosC) Then
                    Else
                        CalculatedDropPair(2) = -2
                    End If
                End If

                If MeasureUsContinuous Then
                    USNrOfMeasurements = 0
                    DoUSMeasurement = True
                    MeasureStatUS = 36
                Else
                    MeasureStatUS = 38
                End If

            Case 38
                TextBoxLog.Text = ""
                USSensorsOn = False
                ErrorUSVolts.Visible = False
                MeasureStatUS = 22

                '///////////////////////////////////////////////////////////////////////////////////////////////////////////////
                'measurement for calibating the sensors on variuous types of bars

                ' Dim NrOfMeasDistances As Double
                ' Dim MeasureDistanceStep As Double
                ' Dim FirstMeasureDist As Double
                ' Dim currentMeasureDist As Double
                ' Dim CntPoints As Integer

            Case 71
                TextBoxLog.Text = ""
                FirstMeasureDist = 225.0
                currentMeasureDist = FirstMeasureDist
                CntPointscalib = 0
                NrOfMeasDistances = 10
                MeasureDistanceStep = 25
                MeasureStatUS += 2
            Case 72
                currentMeasureDist += MeasureDistanceStep
                CntPointscalib += 1
                MeasureStatUS += 1
            Case 73
                ' goto measurement position
                ErrorUSVolts.Visible = False
                ResetMeasErr()
                TextBoxLog.AppendText(currentMeasureDist.ToString("###0.0000") + "; ; ; ; ;" + vbCrLf)

                USMeasurePosition = ProdTheoDrop + currentMeasureDist - MeasureParams.SensorZeroLineToHoistForBBCal
                TextBoxMeasurePositionUS.Text = USMeasurePosition.ToString("###0.0000")
                'MainForm.txtPosition.Text = USMeasurePosition.ToString("###0.0000")
                'MainForm.GoToPosition()
                MainForm.GoPosPosition = USMeasurePosition
                MainForm.ExtraDownMove = MeasureParams.ExtraDownMove
                MainForm.GoPosUpStat = 1

                MeasureStatUS += 1

            Case 74
                If MainForm.GoPosUpStat = 0 Then
                    Settimer(1000)
                    USSensorsOn = True
                    MeasureStatUS += 1
                End If

            Case 75
                If (TimerReady) Then
                    USNrOfMeasurements = 0
                    DoUSMeasurement = True
                    MeasureStatUS += 1
                End If

            Case 76
                If (USNrOfMeasurements > MeasureParams.MeasureNtimes) Then
                    DoUSMeasurement = False
                    USSensorsOn = False
                    MeasureStatUS += 1
                End If
            Case 77 ' do conversion and  calculate average

                If (USNrOfMeasurements > 100) Then
                    USNrOfMeasurements = 100
                End If
                ConvertUSToUnitsBBC(USValueSensor, USNrOfMeasurements, 0, Loglevel)
                'TextBoxResultUS1.Text = calc.calculate_median_outliers_average(USValueSensor, 0, USNrOfMeasurements, MeasureParams.MedianDeviationCalib, 0).ToString("###0.0000")
                'TextBoxResultUS2.Text = calc.calculate_median_outliers_average(USValueSensor, 1, USNrOfMeasurements, MeasureParams.MedianDeviationCalib, 0).ToString("###0.0000")
                TextBoxResultUSCalcA.Text = " "
                MeasureStatUS += 1

            Case 78
                If (CntPointscalib < NrOfMeasDistances - 1) Then
                    MeasureStatUS = 72
                Else
                    MeasureStatUS += 1
                End If

            Case 79
                myLogFile.Setfilename(TextBoxFname.Text)
                myLogFile.SaveLog(TextBoxLog)
                TextBoxLog.Text = ""
                MeasureStatUS = 22
                '///////////////////////////////////////////////////////////////////

        End Select
        Return True
    End Function

    Private Function StepperLaser() As Boolean
        Select Case MeasureStatLaser
            Case 0 ' wait for command to start initialisation
                ' MeasureStatLaser += 1
            Case 1
                Settimer(5000)
                MeasureStatLaser += 1
            Case 2 ' open com port
                If (TimerReady) Then
                    If OpenComPort("com" + MeasureParams.ComportNr.ToString("0")) Then
                        MeasureStatLaser += 1
                    Else
                        MeasureStatLaser = 300
                    End If
                End If
                LaserErrNumber = 0

            Case 3
                receiveText = ""
                ' TextBoxReceive.Text = ""
                SerialPort1Write("LO" & vbCrLf)
                MeasureStatLaser += 1
                Settimer(2000)

            Case 4
                If (receiveText.Equals("LO" & vbCrLf)) Then
                    TextBoxLog.AppendText("received: " & receiveText & vbCrLf)
                    receiveText = ""
                    SerialPort1Write("PR" & vbCrLf)
                    MeasureStatLaser += 1
                    Settimer(500)
                Else

                    If TimerReady Then
                        CheckReceivetextforError()
                        MeasureStatLaser = 301
                    End If
                End If

            Case 5

                If TimerReady Then
                    receiveText = ""
                    SerialPort1Write("ST0" & vbCrLf)
                    MeasureStatLaser += 1
                    Settimer(2000)
                End If

            Case 6

                If (receiveText.Equals("ST0" & vbCrLf)) Then
                    TextBoxLog.AppendText("received: " & receiveText & vbCrLf)
                    receiveText = ""
                    SerialPort1Write("SF10" & vbCrLf)
                    MeasureStatLaser += 1
                    Settimer(2000)
                Else

                    If TimerReady Then
                        CheckReceivetextforError()
                        MeasureStatLaser = 302
                    End If
                End If

            Case 7

                If (receiveText.Equals("SF10" & vbCrLf)) Then
                    TextBoxLog.AppendText("received: " & receiveText & vbCrLf)
                    receiveText = ""
                    SerialPort1Write("SA10" & vbCrLf)
                    MeasureStatLaser += 1
                    Settimer(2000)
                Else
                    If TimerReady Then
                        CheckReceivetextforError()
                        MeasureStatLaser = 303
                    End If
                End If

            Case 8

                If (receiveText.Equals("SA10" & vbCrLf)) Then
                    TextBoxLog.AppendText("received: " & receiveText & vbCrLf)
                    receiveText = ""
                    SerialPort1Write("RM5,004,3" & vbCrLf)
                    Settimer(2000)
                    MeasureStatLaser += 1
                Else
                    If TimerReady Then
                        MeasureStatLaser = 304
                        CheckReceivetextforError()
                    End If
                End If

            Case 9

                If (receiveText.Equals("RM5 0 0" & vbCrLf)) Then
                    TextBoxLog.AppendText("received: " & receiveText & vbCrLf)
                    receiveText = ""
                    SerialPort1Write("LF" & vbCrLf)
                    Settimer(2000)
                    MeasureStatLaser += 1
                Else
                    If TimerReady Then
                        CheckReceivetextforError()
                        MeasureStatLaser = 305
                    End If
                End If

            Case 10

                If (receiveText.Equals("LF" & vbCrLf)) Then
                    TextBoxLog.AppendText("received: " & receiveText & vbCrLf)
                    receiveText = ""
                    MeasureStatLaser += 1
                Else
                    If TimerReady Then
                        CheckReceivetextforError()
                        MeasureStatLaser = 306
                    End If
                End If
            Case 11
                myLogFile.Setfilename("initLaser.txt ")
                myLogFile.SaveLog(TextBoxLog)
                TextBoxLog.Text = " "
                MeasureStatLaser = 24

            Case 24
                'idle

            Case 25
                ' goto measurement position
                LaserMeasurePosition = CalculateLasermeasurementPosition(MeasureParams.LaserSensorPosition, ProductVertLaserMeasureOffset, ProductMountOffset)
                TextBox_LaserControlPos.Text = LaserMeasurePosition.ToString("###0.0000")
                'MainForm.txtPosition.Text = LaserMeasurePosition.ToString("###0.0000")
                'MainForm.GoToPosition()
                MainForm.GoPosPosition = LaserMeasurePosition
                MainForm.ExtraDownMove = MeasureParams.ExtraDownMove
                MainForm.GoPosUpStat = 1
                MeasureStatLaser += 1

            Case 26
                If MainForm.GoPosUpStat = 0 Then
                    Settimer(1000)
                    MeasureStatLaser = 30
                End If

            Case 30
                If (TimerReady) Then
                    LaserNrOfMeasurements = 0
                    SerialPort1Write("LO" & vbCrLf)
                    Settimer(2000)
                    MeasureStatLaser += 1
                End If

            Case 31
                If (receiveText.Equals("LO" & vbCrLf)) Then
                    TextBoxLog.AppendText("received: " & receiveText & vbCrLf)
                    receiveText = ""
                    SerialPort1Write("DT" & vbCrLf)
                    Settimer(3000)
                    MeasureStatLaser += 1
                Else
                    If TimerReady Then
                        MeasureStatLaser = 307
                        CheckReceivetextforError()
                    End If
                End If

            Case 32
                If (receiveText.Contains(vbCrLf)) Then
                    FirstCRLFPos = receiveText.IndexOf(vbCrLf)
                    If (FirstCRLFPos > 0) Then
                        receiveText = receiveText.Substring(0, FirstCRLFPos)
                        TextBoxLog.AppendText("received: " & receiveText & vbCrLf)
                        If Double.TryParse(receiveText, LaserBeforeScale) Then
                            ' LaserValue(LaserNrOfMeasurements) = LaserBeforeScale * (100 / 25.4)
                            LaserValue(LaserNrOfMeasurements) = LaserBeforeScale * MeasureParams.LaserScale
                            TextBoxResultLaser.Text = LaserValue(LaserNrOfMeasurements).ToString("###0.0000")
                            LaserNrOfMeasurements += 1
                        Else

                            MeasureStatLaser = 310
                        End If
                    End If
                    receiveText = ""
                    MeasureStatLaser += 1
                Else
                    If TimerReady Then
                        CheckReceivetextforError()
                        MeasureStatLaser = 308
                    End If
                End If


            Case 33
                If (LaserNrOfMeasurements > MeasureParams.LaserTotalNrMeasurements) Then
                    receiveText = ""
                    'TextBoxReceive.Text = ""
                    SerialPort1Write("DM" & vbCrLf)
                    Settimer(500)
                    MeasureStatLaser += 1
                Else
                    Settimer(8000)
                    MeasureStatLaser = 32
                End If

            Case 34
                If (TimerReady) Then
                    receiveText = ""
                    ' TextBoxReceive.Text = ""
                    SerialPort1Write("DM" & vbCrLf)
                    Settimer(2000)
                    MeasureStatLaser += 1
                End If
            Case 35
                If (receiveText.Contains(vbCrLf)) Then
                    receiveText = ""
                    SerialPort1Write("LF" & vbCrLf)
                    Settimer(2000)
                    MeasureStatLaser += 1
                Else
                    If TimerReady Then
                        CheckReceivetextforError()
                        MeasureStatLaser = 309
                    End If
                End If

            Case 36
                If (receiveText.Equals("LF" & vbCrLf)) Then
                    TextBoxLog.AppendText("received: " & receiveText & vbCrLf)
                    receiveText = ""
                    MeasureStatLaser += 1
                Else
                    If TimerReady Then
                        CheckReceivetextforError()
                        MeasureStatLaser = 310
                    End If
                End If

            Case 37 ' calculate average

                LaserResult = Calc.calculate_average(LaserValue, MeasureParams.LaserTotalNrMeasurements, 0) - MeasureParams.Endcapcompensation
                TextBoxCalcResultLaser.Text = LaserResult.ToString("###0.0000")
                MeasuredWidthLaser = (CalibLaserResult - LaserResult)
                TextBoxWidthResult.Text = MeasuredWidthLaser.ToString("###0.0000")
                myLogFile.Setfilename("LaserProduction.txt ")
                myLogFile.SaveLog(TextBoxLog)
                TextBoxLog.Text = " "
                MeasureStatLaser = 24



                '/////////////////////////////now laser measurement for calibration


            Case 45 'idle
                ' goto measurement position
                LaserCalibPos = CalculateLaserCalibMeasPosition(MeasureParams.LaserSensorPosition, MeasureParams.LaserCalibPlateOffset)
                TextBox_LaserControlPos.Text = LaserCalibPos.ToString("###0.0000")
                ' MainForm.txtPosition.Text = LaserCalibPos.ToString("###0.0000")
                'MainForm.GoToPosition()
                MainForm.GoPosPosition = LaserCalibPos
                MainForm.ExtraDownMove = MeasureParams.ExtraDownMove
                MainForm.GoPosUpStat = 1
                MeasureStatLaser += 1

            Case 46
                If MainForm.GoPosUpStat = 0 Then
                    Settimer(1000)
                    MeasureStatLaser = 50
                End If

            Case 50
                If (TimerReady) Then
                    LaserNrOfMeasurements = 0
                    SerialPort1Write("LO" & vbCrLf)
                    Settimer(2000)
                    MeasureStatLaser += 1
                End If

            Case 51
                If (receiveText.Equals("LO" & vbCrLf)) Then
                    TextBoxLog.AppendText("received: " & receiveText & vbCrLf)
                    receiveText = ""
                    SerialPort1Write("DT" & vbCrLf)
                    Settimer(3000)
                    MeasureStatLaser += 1
                Else
                    If TimerReady Then
                        CheckReceivetextforError()
                        MeasureStatLaser = 307
                    End If
                End If

            Case 52
                If (receiveText.Contains(vbCrLf)) Then
                    FirstCRLFPos = receiveText.IndexOf(vbCrLf)
                    If (FirstCRLFPos > 0) Then
                        receiveText = receiveText.Substring(0, FirstCRLFPos)
                        TextBoxLog.AppendText("received: " & receiveText & vbCrLf)
                        If Double.TryParse(receiveText, LaserBeforeScale) Then
                            'LaserValue(LaserNrOfMeasurements) = LaserBeforeScale * (100 / 25.4)
                            LaserValue(LaserNrOfMeasurements) = LaserBeforeScale * MeasureParams.LaserScale
                            TextBoxResultLaser.Text = LaserValue(LaserNrOfMeasurements).ToString("###0.0000")   ''''//////////////////////////////
                            LaserNrOfMeasurements += 1
                        Else
                            CheckReceivetextforError()
                            MeasureStatLaser = 309
                        End If
                    End If
                    receiveText = ""
                    MeasureStatLaser += 1
                Else
                    If TimerReady Then
                        CheckReceivetextforError()
                        MeasureStatLaser = 308
                    End If
                End If


            Case 53
                If (LaserNrOfMeasurements > MeasureParams.LaserTotalNrMeasurements) Then
                    receiveText = ""
                    'TextBoxReceive.Text = ""
                    SerialPort1Write("DM" & vbCrLf)
                    Settimer(500)
                    MeasureStatLaser += 1
                Else
                    Settimer(8000)
                    MeasureStatLaser = 52
                End If

            Case 54
                If (TimerReady) Then
                    receiveText = ""
                    ' TextBoxReceive.Text = ""
                    SerialPort1Write("DM" & vbCrLf)
                    Settimer(2000)
                    MeasureStatLaser += 1
                End If
            Case 55
                If (receiveText.Contains(vbCrLf)) Then
                    TextBoxLog.AppendText("received: " & receiveText & vbCrLf)
                    receiveText = ""
                    SerialPort1Write("LF" & vbCrLf)
                    Settimer(2000)
                    MeasureStatLaser += 1
                Else
                    If TimerReady Then
                        CheckReceivetextforError()
                        MeasureStatLaser = 309
                    End If
                End If

            Case 56
                If (receiveText.Equals("LF" & vbCrLf)) Then
                    TextBoxLog.AppendText("received: " & receiveText & vbCrLf)
                    receiveText = ""
                    MeasureStatLaser += 1
                Else
                    If TimerReady Then
                        CheckReceivetextforError()
                        MeasureStatLaser = 310
                    End If
                End If

            Case 57 ' calculate average
                CalibLaserResult = Calc.calculate_average(LaserValue, MeasureParams.LaserTotalNrMeasurements, 0)

                TextBoxResultCalibLaser.Text = CalibLaserResult.ToString("###0.0000")
                myLogFile.Setfilename("CalibLaser.txt ")
                myLogFile.SaveLog(TextBoxLog)
                TextBoxLog.Text = " "
                MeasureStatLaser = 24



            Case 300
                'error com port
        End Select

        Return True
    End Function


    Private Function Settimer(ByVal aTime As Integer) As Boolean
        'timer used for timing of certain steps in the measurement stepper
        TimerM.Interval = aTime
        TimerM.Enabled = True
        TimerReady = False
        Return True
    End Function

    '//////////////////////////////////////////////  US  CALCULATIONS //////////////////////////////////////



    Private Function ConvertUSToUnits(ByRef aMeasurement As Double(,), ByRef aNrOfMeasurements As Integer, ByVal aSensor As Integer, ByVal aUsADVoltsPerUnit As Double, ByVal aUSOffset As Double, ByVal Loglevel As Integer) As Boolean
        Dim ind As Integer = 0
        For ind = 0 To aNrOfMeasurements - 1

            If (Loglevel > 0) Then
                TextBoxLog.AppendText("; ;" + aMeasurement(aSensor, ind).ToString("###0.0000") + ";")
            End If

            If (aUsADVoltsPerUnit <> 0) Then
                If (aMeasurement(aSensor, ind) = -1) Then

                Else
                    aMeasurement(aSensor, ind) = (aMeasurement(aSensor, ind) - aUSOffset) / aUsADVoltsPerUnit
                End If
                If (Loglevel > 0) Then
                    TextBoxLog.AppendText(aMeasurement(aSensor, ind).ToString("###0.0000") + ";")
                End If
            Else
                aMeasurement(aSensor, ind) = 0
            End If

        Next
        Return True
    End Function
    Private Function ConvertUSToUnitsBBC(ByRef aMeasurement As Double(,), ByRef aNrOfMeasurements As Integer, ByVal aSensorPair As Integer, ByVal Loglevel As Integer) As Boolean
        Dim ind As Integer = 0
        TextBoxLog.AppendText("convert us to units bottom bar calib, sensorPair" + aSensorPair.ToString)

        For ind = 0 To aNrOfMeasurements - 1
            If (Loglevel > 0) Then
                TextBoxLog.AppendText(";" + aMeasurement(0 + aSensorPair, ind).ToString("###0.0000") + ";")
            End If


            If (MeasureParams.UsADVoltsPerUnit <> 0) Then
                aMeasurement(0 + aSensorPair, ind) = (aMeasurement(0 + aSensorPair, ind) - MeasureParams.USOffset) / MeasureParams.UsADVoltsPerUnit
                If (Loglevel > 0) Then
                    TextBoxLog.AppendText(aMeasurement(0 + aSensorPair, ind).ToString("###0.0000") + ";")
                End If
            Else
                aMeasurement(0 + aSensorPair, ind) = 0
            End If

            If (Loglevel > 0) Then
                TextBoxLog.AppendText(aMeasurement(1 + aSensorPair, ind).ToString("###0.0000") + ";")

            End If

            If (MeasureParams.UsADVoltsPerUnit <> 0) Then
                aMeasurement(1 + aSensorPair, ind) = (aMeasurement(1 + aSensorPair, ind) - MeasureParams.USOffset) / MeasureParams.UsADVoltsPerUnit
                If (Loglevel > 0) Then
                    TextBoxLog.AppendText(aMeasurement(1 + aSensorPair, ind).ToString("###0.0000") + ";" + vbCrLf)
                End If
            Else
                aMeasurement(1 + aSensorPair, ind) = 0
            End If
        Next
        Return True
    End Function

    Private Function CalcRefSensToRefHoist(ByVal CalibBarDrop As Double, ByVal UsMeasureDist As Double, ByVal CalibBarRad As Double, ByVal Calib0Position As Double) As Double
        'g = e + d - k - i
        Return UsMeasureDist + CalibBarDrop - CalibBarRad - Calib0Position
    End Function
    Private Function calcPreferredMeasurePos(ByVal VertOffsetProd As Double, ByVal TheoProdDrop As Double, ByVal DesiredUsDist As Double, ByVal RefLtoRefL As Double) As Double
        'h=b+c+n-g
        Return VertOffsetProd + TheoProdDrop + DesiredUsDist - RefLtoRefL
    End Function


    ' a pair is 0,1,2 sensor pair for triangulation
    Private Function CalcAllDistFromTriangle(ByVal aPair As Integer, ByVal BarRad As Double, ByVal aMeasureMentsSens As Double(,), ByRef aMeasureMentsResult As Double(,), ByVal TotalNr As Integer, ByVal Dist_M As Double, ByVal Dist_S As Double, ByVal AlfaS0S1Refline As Double, ByVal aloglevel As Integer) As Boolean
        Dim cnt As Integer = 0
        For cnt = 0 To TotalNr - 1
            Calc.CalcDistFromTriangle(BarRad, aMeasureMentsSens(0 + (2 * aPair), cnt), aMeasureMentsSens(1 + (2 * aPair), cnt), aMeasureMentsResult(aPair, cnt), Dist_M, Dist_S, AlfaS0S1Refline, aloglevel)
        Next

        Return True
    End Function

    Private Function CalculateDrop(ByVal MeasureVal As Double, ByVal VertOffsetProd As Double, ByVal HoistPos As Double, ByVal RefLtoRefL As Double) As Double
        'Drop = c = g + h - b - eP
        Return RefLtoRefL + HoistPos - VertOffsetProd - MeasureVal
    End Function
    '////////////////////////// end of US calculations  ///////////////////////////////////////////////////

    Private Function CalculateLasermeasurementPosition(ByVal LaserPosition As Double, ByVal ProdLaserMeasOffset As Double, ByVal VertMountOffset As Double)
        Return LaserPosition + ProdLaserMeasOffset + VertMountOffset
    End Function

    Private Function CalculateLaserCalibMeasPosition(ByVal LaserPosition As Double, ByVal CalibLaserMeasOffset As Double)
        Return LaserPosition + CalibLaserMeasOffset
    End Function

    '/////timer used in measurement steppers 
    Private Sub TimerM_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerM.Tick
        TimerReady = True
        TimerM.Enabled = False
    End Sub

    Private Sub TextBoxCycleLaser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxCycleLaser.Click
        SerialPort1.Close()
        MeasureStatLaser = 1
    End Sub

    Public Function LoadMeasureParams() As Boolean
        ParamFiles.OpenReadParamFile(ParamFileName, "HasLaser", MeasureParams.HasLaser)
        ParamFiles.OpenReadParamFile(ParamFileName, "HasUS", MeasureParams.HasUS)

        ParamFiles.OpenReadParamFile(ParamFileName, "LogLevel", Loglevel)
        ParamFiles.OpenReadParamFile(ParamFileName, "NumberOfSensorUsed", NumberOfSensorUsed)
        ParamFiles.OpenReadParamFile(ParamFileName, "PosWaitTimeCal", MeasureParams.PosWaitTimeCal)
        ParamFiles.OpenReadParamFile(ParamFileName, "PosWaitTimeProd", MeasureParams.PosWaitTimeProd)
        ParamFiles.OpenReadParamFile(ParamFileName, "Endcapcompensation", MeasureParams.Endcapcompensation)
        ParamFiles.OpenReadParamFile(ParamFileName, "UsADVoltsPerUnit", MeasureParams.UsADVoltsPerUnit)
        ParamFiles.OpenReadParamFile(ParamFileName, "USPreferredMeasureDist", MeasureParams.USPreferredMeasureDist) ' comes from model file when measurement called from inspection
        ParamFiles.OpenReadParamFile(ParamFileName, "UsMaxVolts", MeasureParams.UsMaxVolts)
        ParamFiles.OpenReadParamFile(ParamFileName, "UsMinVolts", MeasureParams.UsMinVolts)
        ParamFiles.OpenReadParamFile(ParamFileName, "UsSensorPosToRef1Pair0", MeasureParams.UsSensorPosToRef1Pair0)
        ParamFiles.OpenReadParamFile(ParamFileName, "UsRefAlfaPair0", MeasureParams.UsRefAlfaPair0)
        ParamFiles.OpenReadParamFile(ParamFileName, "USDistSensorsPair0", MeasureParams.USDistSensorsPair0)
        ParamFiles.OpenReadParamFile(ParamFileName, "UsSensorPosToRef1Pair1", MeasureParams.UsSensorPosToRef1Pair1)
        ParamFiles.OpenReadParamFile(ParamFileName, "UsRefAlfaPair1", MeasureParams.UsRefAlfaPair1)
        ParamFiles.OpenReadParamFile(ParamFileName, "USDistSensorsPair1", MeasureParams.USDistSensorsPair1)
        ParamFiles.OpenReadParamFile(ParamFileName, "UsSensorPosToRef1Pair2", MeasureParams.UsSensorPosToRef1Pair2)
        ParamFiles.OpenReadParamFile(ParamFileName, "UsRefAlfaPair2", MeasureParams.UsRefAlfaPair2)
        ParamFiles.OpenReadParamFile(ParamFileName, "USDistSensorsPair2", MeasureParams.USDistSensorsPair2)
        ParamFiles.OpenReadParamFile(ParamFileName, "RefSensToRefHoist", MeasureParams.RefSensToRefHoist)
        ParamFiles.OpenReadParamFile(ParamFileName, "USOffset", MeasureParams.USOffset)
        ParamFiles.OpenReadParamFile(ParamFileName, "USMeasurePositionCalib0", MeasureParams.USMeasurePositionCalib0)
        ParamFiles.OpenReadParamFile(ParamFileName, "USMeasurePositionCalib1", MeasureParams.USMeasurePositionCalib1)
        ParamFiles.OpenReadParamFile(ParamFileName, "MeasureNtimesCalib", MeasureParams.MeasureNtimesCalib)

        If (MeasureParams.MeasureNtimesCalib > 100) Then
            MeasureParams.MeasureNtimesCalib = 100
        End If

        ParamFiles.OpenReadParamFile(ParamFileName, "MeasureNtimes", MeasureParams.MeasureNtimes)
        If (MeasureParams.MeasureNtimes > 100) Then
            MeasureParams.MeasureNtimes = 100
        End If

        ParamFiles.OpenReadParamFile(ParamFileName, "MeasureNtimesCont", MeasureParams.MeasureNtimesCont)
        If (MeasureParams.MeasureNtimesCont > 100) Then
            MeasureParams.MeasureNtimesCont = 100
        End If



        ParamFiles.OpenReadParamFile(ParamFileName, "CalibBarRadius", MeasureParams.CalibBarRadius)
        ParamFiles.OpenReadParamFile(ParamFileName, "CalibBarDrop", MeasureParams.CalibBarDrop)
        ParamFiles.OpenReadParamFile(ParamFileName, "MirrorX1Position", MeasureParams.MirrorX1Position)
        ParamFiles.OpenReadParamFile(ParamFileName, "MedianDeviationCalib", MeasureParams.MedianDeviationCalib)
        ParamFiles.OpenReadParamFile(ParamFileName, "MedianDeviationProd", MeasureParams.MedianDeviationProd)
        ParamFiles.OpenReadParamFile(ParamFileName, "MedianDeviationCont", MeasureParams.MedianDeviationCont)
        ParamFiles.OpenReadParamFile(ParamFileName, "PosA", MeasureParams.PosA)    ' position of the sensorpairA
        ParamFiles.OpenReadParamFile(ParamFileName, "PosB", MeasureParams.PosB)    ' position of the sensorpairB
        ParamFiles.OpenReadParamFile(ParamFileName, "PosC", MeasureParams.PosC)    ' position of the sensorpairC

        ParamFiles.OpenReadParamFile(ParamFileName, "MountOffSetHorizontal", MeasureParams.MountOffSetHorizontal)

        ParamFiles.OpenReadParamFile(ParamFileName, "LaserScale", MeasureParams.LaserScale)
        ParamFiles.OpenReadParamFile(ParamFileName, "LaserSensorPosition", MeasureParams.LaserSensorPosition)
        ParamFiles.OpenReadParamFile(ParamFileName, "LaserCalibPlateOffset", MeasureParams.LaserCalibPlateOffset)
        ParamFiles.OpenReadParamFile(ParamFileName, "LaserTotalNrMeasurements", MeasureParams.LaserTotalNrMeasurements)
        ParamFiles.OpenReadParamFile(ParamFileName, "SensorZeroLineToHoistForBBCal", MeasureParams.SensorZeroLineToHoistForBBCal)
        ParamFiles.OpenReadParamFile(ParamFileName, "ComportNr", MeasureParams.ComportNr)
        ParamFiles.OpenReadParamFile(ParamFileName, "ExtraDownMove", MeasureParams.ExtraDownMove)
        'MsgBox("Extradownmove=  " + MeasureParams.ExtraDownMove.ToString)


        Return (True)
    End Function

    '///////////////// general stuff  interface with inspection page, click of buttons etc////////////////////////////////////////
    '
    '
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '
    '
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ' functions for starting US measurement after  button pushed on measurement page

    Public Function StartUSMeasurement() As Boolean
        If (MeasureStatUS = 22) Then
            MeasureStatUS = 23
            Return True
        Else
            Return False
        End If
    End Function
    ' entering all relevant production data for the us measurenet and starting it, 
    ' this is used from the inspection and main screen

    Public Function StartUSMeasurement(ByVal aProductMountOffset As Double, ByVal aProdTheoDrop As Double, ByVal aProdTheoWidth As Double, ByVal aProdBotBarRad As Double, ByVal aPrefMeasDist As Double) As Boolean
        ProductMountOffset = aProductMountOffset
        ProdTheoDrop = aProdTheoDrop
        ProdTheoWidth = aProdTheoWidth
        ProdBarRadius = aProdBotBarRad
        MeasureParams.USPreferredMeasureDist = aPrefMeasDist ' comes from model file! Overrules the value from the paramfile!
        StartUSMeasurement()
        Return True
    End Function
    ' used when button pressed on this from, uses data from the editboxes
    Public Function StartUSMeasurementCont() As Boolean

        If (MeasureStatUS = 22) Then
            MeasureStatUS = 33
            MeasureUsContinuous = True

            Return True
        Else
            Return False
        End If
    End Function
    ' entering all relevant production data for the us measurenet  continuous and starting it, 
    ' this is used from the inspection and main screen

    Public Function StartUSMeasuremenCont(ByVal aProductMountOffset As Double, ByVal aProdTheoDrop As Double, ByVal aProdTheoWidth As Double, ByVal aProdBotBarRad As Double, ByVal aPrefMeasDist As Double) As Boolean

        ProductMountOffset = aProductMountOffset
        ProdTheoDrop = aProdTheoDrop
        ProdTheoWidth = aProdTheoWidth
        ProdBarRadius = aProdBotBarRad
        MeasureParams.USPreferredMeasureDist = aPrefMeasDist ' comes from model file! Overrules the value from the paramfile!
        StartUSMeasurementCont()
        Return True
    End Function


    Public Function StopContMeasurement() As Boolean
        MeasureUsContinuous = False
        MeasureStatUS = 22
        Return True
    End Function

    Public Function ResetCycle()
        MeasureStatUS = 22
        Try
            SerialPort1.Close()
            DoUSMeasurement = False
            USSensorsOn = False
        Catch

        End Try

        MeasureStatLaser = 2
        Return True
    End Function

    ' this function only used from measurement screen, it is for automated measurement of bottom bar profiles and the effect on the sensor
    Public Function StartUSMeasurementBotBarCalib() As Boolean
        If (MeasureStatUS = 22) Then
            MeasureStatUS = 71
            Return True
        Else
            Return False
        End If
    End Function

    Public Function IsUSReady() As Boolean
        Return (MeasureStatUS = 22)
    End Function

    Public Function GiveUSCalcResult(ByVal aSensorPair As Integer) As Double
        Return USCalcResultPair(aSensorPair)
    End Function

    Public Function GiveUSDropResult(ByVal aSensorPair As Integer) As Double
        Return CalculatedDropPair(aSensorPair)
    End Function

    '////////////////////////functions to do laser measurement from other classes///////////////////////////////////////


    Public Function StartLaserMeasurement() As Boolean
        If (MeasureStatLaser = 24) Then
            MeasureStatLaser = 25
            Return True
        Else
            Return False
        End If
    End Function

    Public Function StartLaserMeasurement(ByVal aProductMountOffset As Double, ByVal aProductVertLaserMeasureOffset As Double, ByVal aEndcapCompensation As Double) As Boolean
        ' here we fill in the prod params , the actual measurement position will be calculated in the stepper
        ProductMountOffset = aProductMountOffset
        ProductVertLaserMeasureOffset = aProductVertLaserMeasureOffset
        MeasureParams.Endcapcompensation = aEndcapCompensation
        If (MeasureStatLaser = 24) Then
            MeasureStatLaser = 25
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub StartLaserCalib()
        If (MeasureStatLaser = 24) Then
            MeasureStatLaser = 45
        End If
    End Sub

    Public Function IsLaserReady() As Boolean
        Return (MeasureStatLaser = 24)
    End Function

    Public Function GiveLaserWidthResult() As Double
        Return MeasuredWidthLaser
    End Function

    Public Function GiveLaserCalibResult() As Double
        Return CalibLaserResult
    End Function
    '///////////////////// used in inspection to be able to read some settings

    Public Function GetActualMeasureParams(ByRef aSet As tMeasureParams) As Boolean
        ' function to give the measurement params to another class ( ispection)
        aSet = MeasureParams
        Return True
    End Function


    '//////////////////////////////buttons  ////////////////////////////////////
    Private Sub ButtonGoMeasureLaser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGoMeasureLaser.Click
        If (Double.TryParse(TextBoxVertMountOffset.Text, ProductMountOffset)) Then
            If (Double.TryParse(TextBoxVertLaserMeasureOffset.Text, ProductVertLaserMeasureOffset)) Then
                StartLaserMeasurement()
            End If
        End If
    End Sub

    Private Sub ButtonStartCalibLaser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStartCalibLaser.Click
        If (Double.TryParse(TextBoxVertMountOffset.Text, ProductMountOffset)) Then
            If (Double.TryParse(TextBoxVertLaserMeasureOffset.Text, ProductVertLaserMeasureOffset)) Then
                StartLaserCalib()
            End If
        End If
    End Sub

    Private Sub BtnStartUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStartUS.Click
        If (Double.TryParse(TextBoxTheoDrop.Text, ProdTheoDrop)) Then
            If (Double.TryParse(TextBoxVertMountOffset.Text, ProductMountOffset)) Then
                If (Double.TryParse(TextBoxProdbotbarrad.Text, ProdBarRadius)) Then
                    StartUSMeasurement()
                End If
            End If
        End If
    End Sub

    Private Sub ButtonStartContUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStartContUS.Click
        Dim Pos As Double = 0

        If (Double.TryParse(TextBoxTheoDrop.Text, ProdTheoDrop)) Then
            If (Double.TryParse(TextBoxVertMountOffset.Text, ProductMountOffset)) Then
                If (Double.TryParse(TextBoxProdbotbarrad.Text, ProdBarRadius)) Then
                    StartUSMeasurementCont()
                End If
            End If
        End If
    End Sub

    Private Sub ButtonStopContUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStopContUS.Click
        MeasureUsContinuous = False
    End Sub

    ' to start the calibration of the triagular measurements
    Private Sub ButtonCalibUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCalibUS.Click
        MeasureStatUS = 1
    End Sub

    Private Sub ButtonBotBarCalib_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBotBarCalib.Click
        If (Double.TryParse(TextBoxTheoDrop.Text, ProdTheoDrop)) Then
            StartUSMeasurementBotBarCalib()
        End If
    End Sub

    Private Sub ButtonSkipCalib_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSkipCcalib.Click
        MeasureStatUS = 22
    End Sub

    Private Sub ButtonSaveLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSaveLog.Click
        myLogFile.Setfilename(TextBoxFname.Text)
        myLogFile.SaveLog(TextBoxLog)
        TextBoxLog.Text = ""
    End Sub

    Private Sub ButtonSaveCalib_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSaveCalib.Click
        ParamFiles.SaveOneParam(ParamFileName, "UsSensorPosToRef1Pair0", MeasureParams.UsSensorPosToRef1Pair0)
        ParamFiles.SaveOneParam(ParamFileName, "UsRefAlfaPair0", MeasureParams.UsRefAlfaPair0)
        ParamFiles.SaveOneParam(ParamFileName, "USDistSensorsPair0", MeasureParams.USDistSensorsPair0)

        ParamFiles.SaveOneParam(ParamFileName, "UsSensorPosToRef1Pair1", MeasureParams.UsSensorPosToRef1Pair1)
        ParamFiles.SaveOneParam(ParamFileName, "UsRefAlfaPair1", MeasureParams.UsRefAlfaPair1)
        ParamFiles.SaveOneParam(ParamFileName, "USDistSensorsPair1", MeasureParams.USDistSensorsPair1)

        ParamFiles.SaveOneParam(ParamFileName, "UsSensorPosToRef1Pair2", MeasureParams.UsSensorPosToRef1Pair2)
        ParamFiles.SaveOneParam(ParamFileName, "UsRefAlfaPair2", MeasureParams.UsRefAlfaPair2)
        ParamFiles.SaveOneParam(ParamFileName, "USDistSensorsPair2", MeasureParams.USDistSensorsPair2)


        ParamFiles.SaveOneParam(ParamFileName, "RefSensToRefHoist", MeasureParams.RefSensToRefHoist)
    End Sub


    '////////////////edit fields////////////////////////////////////////////////

    Private Sub TextBoxAlfa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAlfa.Click
        Double.TryParse(EditBoxDoHandleIt(), MeasureParams.UsRefAlfaPair0)
        TextBoxAlfa.Text = MeasureParams.UsRefAlfaPair0.ToString("###0.0000")
    End Sub

    Private Sub TextBoxSensposToRef1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSensposToRef1.Click
        Double.TryParse(EditBoxDoHandleIt(), MeasureParams.UsSensorPosToRef1Pair0)
        TextBoxSensposToRef1.Text = MeasureParams.UsSensorPosToRef1Pair0.ToString("###0.0000")
    End Sub

    Private Sub TextBoxDistSensors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxDistSensors.Click
        Double.TryParse(EditBoxDoHandleIt(), MeasureParams.USDistSensorsPair0)
        TextBoxDistSensors.Text = MeasureParams.USDistSensorsPair0.ToString("###0.0000")
    End Sub

    Private Sub TextBoxMeasurePositionUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMeasurePositionUS.Click
        TextBoxMeasurePositionUS.Text = EditBoxDoHandleIt()
    End Sub

    Private Sub TextBox_LaserControlPos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_LaserControlPos.Click
        TextBox_LaserControlPos.Text = EditBoxDoHandleIt()
    End Sub

    Private Sub TextBoxVertMountOffset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxVertMountOffset.Click
        TextBoxVertMountOffset.Text = EditBoxDoHandleIt()
    End Sub

    Private Sub TextBoxVertLaserMeasureOffset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxVertLaserMeasureOffset.Click
        TextBoxVertLaserMeasureOffset.Text = EditBoxDoHandleIt()
    End Sub

    Private Sub TextBoxTheoDrop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxTheoDrop.Click
        TextBoxTheoDrop.Text = EditBoxDoHandleIt()
    End Sub

    Private Sub TextBoxProdbotbarrad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxProdbotbarrad.Click
        TextBoxProdbotbarrad.Text = EditBoxDoHandleIt()
    End Sub

    Private Function EditBoxDoHandleIt() As String
        KeyPad_Form.txtValueKeyPad.Text = ""
        KeyPad_Form.MaskedTextBox1.Text = ""
        KeyPad_Form.txtValueKeyPad.Visible = True
        KeyPad_Form.KeyBoard.Visible = False
        KeyPad_Form.MaskedTextBox1.Visible = False
        KeyPad_Form.Numpad.Visible = True
        KeyPad_Form.Size = New Size(291, 392)
        KeyPad_Form.ShowDialog()
        Return KeyPad_Form.txtValueKeyPad.Text
    End Function

    Public Function CalcDeltaDropAtEnd(ByVal aWidth As Double, ByVal aDropA As Double, ByVal aDropB As Double, ByVal aDropC As Double) As Double
        Dim lEndDeltaDrop As Double = -2
        Try
            If NumberOfSensorUsed > 4 Then
                TextBoxLog.AppendText("more the 4 sensors" + vbCrLf)
                If (aWidth + MeasureParams.MountOffSetHorizontal) > MeasureParams.PosC Then
                    TextBoxLog.AppendText("wide enough for pos C" + vbCrLf)
                    ' lEndDrop = aDropA + (((aWidth + MeasureParams.MountOffSetHorizontal - MeasureParams.PosA) / (MeasureParams.PosC - MeasureParams.PosA)) * (aDropC - aDropA))
                    lEndDeltaDrop = (((aWidth + MeasureParams.MountOffSetHorizontal - MeasureParams.PosA) / (MeasureParams.PosC - MeasureParams.PosA)) * (aDropC - aDropA))
                    TextBoxLog.AppendText("delta =  " + lEndDeltaDrop.ToString("####.000") + vbCrLf)
                Else
                    TextBoxLog.AppendText("NOT wide enough for pos C" + vbCrLf)
                    If (aWidth + MeasureParams.MountOffSetHorizontal) > MeasureParams.PosB Then
                        ' lEndDrop = aDropA + (((aWidth + MeasureParams.MountOffSetHorizontal - MeasureParams.PosA) / (MeasureParams.PosB - MeasureParams.PosA)) * (aDropB - aDropA))
                        lEndDeltaDrop = (((aWidth + MeasureParams.MountOffSetHorizontal - MeasureParams.PosA) / (MeasureParams.PosB - MeasureParams.PosA)) * (aDropB - aDropA))
                        TextBoxLog.AppendText("delta =  " + lEndDeltaDrop.ToString("####.000") + vbCrLf)
                    End If
                End If
            End If
            If (NumberOfSensorUsed > 2) And (NumberOfSensorUsed < 5) Then
                TextBoxLog.AppendText("more the 2  les the 5 sensors" + vbCrLf)
                If (aWidth + MeasureParams.MountOffSetHorizontal) > MeasureParams.PosB Then
                    TextBoxLog.AppendText("wide enough for pos B" + vbCrLf)
                    ' lEndDrop = aDropA + (((aWidth + MeasureParams.MountOffSetHorizontal - MeasureParams.PosA) / (MeasureParams.PosB - MeasureParams.PosA)) * (aDropB - aDropA))
                    lEndDeltaDrop = (((aWidth + MeasureParams.MountOffSetHorizontal - MeasureParams.PosA) / (MeasureParams.PosB - MeasureParams.PosA)) * (aDropB - aDropA))
                    TextBoxLog.AppendText("delta =  " + lEndDeltaDrop.ToString("####.000") + vbCrLf)
                End If
            End If
        Catch e As Exception


        End Try

        myLogFile.Setfilename("DeltaCalcdrop.txt ")
        myLogFile.SaveLog(TextBoxLog)
        TextBoxLog.Text = ""
        Return lEndDeltaDrop
    End Function

    Public Function givelaserErr() As Integer
        Return LaserErrNumber
    End Function

    Public Function givelaserErrStr() As String
        If LaserErrNumber > 0 Then
            Return Lasererrstr(LaserErrnrToStrIndex(LaserErrNumber))
        Else
            Return ""
        End If
    End Function

    Private Sub showLasererr()

        If (LaserErrNumber > 0) Then
            TextBoxLaserErr.Text = "Laser Error: " + givelaserErrStr()
            TextBoxLaserErr.Visible = True
        Else
            TextBoxLaserErr.Visible = False
        End If
    End Sub
End Class