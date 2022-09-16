Public Class Inspection


    Dim HasUS As Double
    Dim HasLaser As Double

    Dim CheckProdStat As Integer = 0

    Dim MeasuredDrop(4) As Double
    Dim MeasuredWidth As Double = 0
    Dim MeasuredWidthCalib As Double = 0
    Dim isloadedbool As Boolean = False
    Dim MeasureDrop As Boolean = True
    Dim MeasureWidth As Boolean = True
    Dim MeasureSquareness As Boolean = True
    Dim myLogFile As New clsLogFile ' use to log various measurement to file
    Dim Modelfilename As String
    Dim OrderNrStr As String
    Dim cnt As Integer

    Dim OkW As Boolean
    Dim OkA As Boolean
    Dim OkB As Boolean
    Dim OkC As Boolean
    Dim OKE As Boolean

    Dim almostfactor As Double = 1.2

    Public InspectionDat As ModelFiles.tModelDat

    Private Sub ComboBoxModel_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxModel.SelectionChangeCommitted
        ModelFiles.OpenReadModelFile("..\ModelFiles\" + ComboBoxModel.SelectedItem.ToString(), InspectionDat)
        UpDateInspectDatOnScreen()
    End Sub

    Private Sub ButtonEditModels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEditModels.Click
        ModelFiles.ShowDialog()
    End Sub

    Private Sub UpDateInspectDatOnScreen()
        TextBoxDrop.Text = InspectionDat.Drop.ToString("###0.0000")
        TextBoxWidth.Text = InspectionDat.Width.ToString("###0.0000")
        TextBoxOffSetLaserOnProd.Text = InspectionDat.OffsetLaserOnProd.ToString("###0.0000")
        TextBoxMountOffSetVertical.Text = InspectionDat.MountOffSetVert.ToString("###0.0000")
        TextBoxTolWidthPlus.Text = InspectionDat.ToleranceWidthPlus.ToString("###0.0000")
        TextBoxTolDropPlus.Text = InspectionDat.ToleranceDropPlus.ToString("###0.0000")
        TextBoxTolWidthMinus.Text = InspectionDat.ToleranceWidthMinus.ToString("###0.0000")
        TextBoxTolDropMinus.Text = InspectionDat.ToleranceDropMinus.ToString("###0.0000")
        TextBoxBottombarradius.Text = InspectionDat.BottomBarRadius.ToString("###0.0000")
        TextBoxPrefMeasDist.Text = InspectionDat.PrefMeasDist.ToString("###0.0000")

        TextBoxTolDropDif.Text = InspectionDat.ToleranceDropDiff.ToString("###0.0000")
    End Sub

    Private Sub Inspection_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (ComboBoxModel.Items.Count = 0) Then
            For Each foundFile As String In My.Computer.FileSystem.GetFiles("..\ModelFiles")
                ComboBoxModel.Items.Add(My.Computer.FileSystem.GetName(foundFile))
            Next
        End If

        UpDateInspectDatOnScreen()
        ButtonEditModels.Visible = True
        ' NButton.visible = True
        ButtonContDropMeasure.Visible = True
        ButtonExit.Visible = True
        ButtonFullMeasurement.Visible = True
        ParamFiles.OpenReadParamFile(ParamFileName, "HasLaser", HasLaser)
        ParamFiles.OpenReadParamFile(ParamFileName, "HasUS", HasUS)

        ParamFiles.OpenReadParamFile(ParamFileName, "MeasureDrop", MeasureDrop)
        ParamFiles.OpenReadParamFile(ParamFileName, "MeasureWidth", MeasureWidth)
        ParamFiles.OpenReadParamFile(ParamFileName, "MeasureSquareness", MeasureSquareness)

        If (HasLaser = 0) Then
            MeasureWidth = 0
        End If

        If (HasUS = 0) Then
            MeasureDrop = 0
            MeasureSquareness = 0
        End If


        'MsgBox(" inspection load ")
        isloadedbool = True
    End Sub
    Public Function isloaded() As Boolean
        Return isloadedbool
    End Function

    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        isloadedbool = False
        Me.Close()
    End Sub

    Public Function ResetCycle()
        CheckProdStat = 0
        Return True
    End Function

    Public Function SetDropWidthModel(ByVal aDrop As String, ByVal aWidth As String, ByVal aModel As String, ByVal aOrderNr As String) As Boolean
        Dim tVal As Double
        Double.TryParse(aDrop, tVal)
        InspectionDat.Drop = tVal
        Double.TryParse(aWidth, tVal)
        InspectionDat.Width = tVal

        ModelFiles.OpenReadModelFile("..\ModelFiles\" + aModel, InspectionDat)
        Modelfilename = aModel
        UpDateInspectDatOnScreen()
        ComboBoxModel.Visible = False
        TextBoxModel.Text = aModel
        TextBoxModel.Visible = True
        OrderNrStr = aOrderNr

        Return True
    End Function

    Public Function DoContMeasurement() As Boolean


        GoodBadA.ClearValue()
        GoodBadB.ClearValue()
        GoodBadC.ClearValue()
        GoodBadW.ClearValue()
        GoodBadDropEnd.ClearValue()


        ButtonEditModels.Visible = False
        ' NButton.visible = True
        ButtonContDropMeasure.Visible = False
        ButtonExit.Visible = False
        ButtonFullMeasurement.Visible = False

        CheckProdStat = 30
        TextBoxDrop.ReadOnly = True
        TextBoxWidth.ReadOnly = True
        ComboBoxModel.Enabled = False
        ComboBoxModel.Visible = False
        TextBoxModel.Visible = True
        Return True
    End Function

    Public Function DofullMeasurement() As Boolean
        GoodBadA.ClearValue()
        GoodBadB.ClearValue()
        GoodBadC.ClearValue()
        GoodBadW.ClearValue()
        GoodBadDropEnd.ClearValue()


        ButtonEditModels.Visible = False
        ' NButton.visible = True
        ButtonContDropMeasure.Visible = False
        ButtonExit.Visible = False
        ButtonFullMeasurement.Visible = False
        CheckProdStat = 2
        TextBoxDrop.ReadOnly = True
        TextBoxWidth.ReadOnly = True
        ComboBoxModel.Enabled = False
        ComboBoxModel.Visible = False
        TextBoxModel.Visible = True

        Return True
    End Function



    Public Function GiveLastResultAll() As Boolean
        Dim lOk = True

        If (OkA = False) Then
            lOk = False
        End If

        If ((NumberOfSensorUsed / 2) > 1) Then
            If (OkB = False) Then
                lOk = False
            End If
        End If
        If ((NumberOfSensorUsed / 2) > 2) Then
            If (OkC = False) Then
                lOk = False
            End If
        End If
        If (OkW = False) Then
            lOk = False
        End If

        If (OKE = False) Then
            lOk = False
        End If

        Return lOk
    End Function


    Public Sub InspectionCycle()
        Dim temp0 As Double = 0
        Dim temp1 As Double = 0
        Dim temp2 As Double = 0


        Select Case CheckProdStat
            Case 0
                TextBoxActions.Clear()
                TextBoxActions.Text = "choose modelfile,enter drop and width, then click next"
                CheckProdStat += 1

            Case 1
                If NButton.NextStep() Then

                    Double.TryParse(TextBoxDrop.Text, temp0)
                    Double.TryParse(TextBoxWidth.Text, temp1)
                    Double.TryParse(TextBoxMountOffSetVertical.Text, temp2)

                    If ((temp0 <> 0.0) And (temp1 <> 0.0) And (temp2 <> 0.0)) Then

                        CheckProdStat += 1
                        UpDateInspectDatOnScreen()
                    Else
                        TextBoxActions.Text = "choose modelfile,enter drop and width, then click next"
                        CheckProdStat = 0
                    End If

                End If

            Case 2
                If (InspectionDat.MeasureDrop = 1) And (MeasureDrop = True) Then
                    Measurement.StartUSMeasurement(InspectionDat.MountOffSetVert, InspectionDat.Drop, InspectionDat.Width, InspectionDat.BottomBarRadius, InspectionDat.PrefMeasDist)
                    TextBoxActions.Clear()
                    GoodBadA.Visible = False
                    GoodBadB.Visible = False
                    GoodBadC.Visible = False
                    GoodBadW.Visible = False
                    GoodBadDropEnd.Visible = False
                    TextBoxActions.Text = "Please wait: Running drop measurement"
                    CheckProdStat += 1
                Else
                    GoodBadA.Visible = False
                    GoodBadB.Visible = False
                    GoodBadC.Visible = False
                    GoodBadW.Visible = False
                    GoodBadDropEnd.Visible = False
                    TextBoxActions.Clear()
                    TextBoxActions.Text = "skipping drop measurement, push next"
                    CheckProdStat = 4
                End If

            Case 3
                If (Measurement.IsUSReady) Then
                    TextBoxActions.Clear()
                    TextBoxActions.Text = "Drop Measurement ready , Drop is:"

                    MeasuredDrop(0) = Measurement.GiveUSDropResult(0)
                    TextBoxActions.Text += "pair0 " + MeasuredDrop(0).ToString("###0.0000") + vbCrLf

                    GoodBadDropEnd.ClearValue()

                    If ((NumberOfSensorUsed / 2) > 1) Then
                        MeasuredDrop(2) = -1000
                        MeasuredDrop(1) = Measurement.GiveUSDropResult(1)
                        TextBoxActions.Text += "pair1 " + MeasuredDrop(1).ToString("###0.0000") + vbCrLf
                        If (InspectionDat.MeasureSquareness = 1) Then
                            MeasuredDrop(3) = Measurement.CalcDeltaDropAtEnd(InspectionDat.Width, MeasuredDrop(0), MeasuredDrop(1), MeasuredDrop(2))

                        End If
                    End If
                    If ((NumberOfSensorUsed / 2) > 2) Then
                        MeasuredDrop(2) = Measurement.GiveUSDropResult(2)
                        TextBoxActions.Text += "pair2 " + MeasuredDrop(2).ToString("###0.0000") + vbCrLf
                        If (InspectionDat.MeasureSquareness = 1) Then
                            MeasuredDrop(3) = Measurement.CalcDeltaDropAtEnd(InspectionDat.Width, MeasuredDrop(0), MeasuredDrop(1), MeasuredDrop(2))
                        End If
                    End If

                    TextBoxActions.Text = "Pull up blind then push next"
                    CheckProdStat += 1
                End If

            Case 4
                If NButton.NextStep() Or (InspectionDat.MeasureDrop = 0) Or (MeasureDrop = False) Then

                    TextBoxActions.Clear()
                    TextBoxActions.Text = "Pull up blind then push next"
                    CheckProdStat += 1
                End If

            Case 5 ' do calib measurement
                If (InspectionDat.MeasureWidth = 1) And (MeasureWidth = True) Then
                    UpDateInspectDatOnScreen()
                    Measurement.StartLaserCalib()
                    TextBoxActions.Clear()
                    TextBoxActions.Text = "Please Wait: Running calibration width measurement"
                    CheckProdStat += 1
                Else
                    TextBoxActions.Clear()
                    TextBoxActions.Text = "skipping width measurement, push next"
                    CheckProdStat = 9

                End If
            Case 6
                If (Measurement.IsLaserReady) Then
                    MeasuredWidthCalib = Measurement.GiveLaserCalibResult()
                    TextBoxLaserCalib.Text = MeasuredWidthCalib.ToString("###0.0000")
                    TextBoxActions.Clear()
                    TextBoxActions.Text = "Width calibration Measurement ready , Width is: " + MeasuredWidthCalib.ToString("###0.0000") + "Push next"
                    CheckProdStat += 1
                End If
            Case 7
                UpDateInspectDatOnScreen()
                Measurement.StartLaserMeasurement(InspectionDat.MountOffSetVert, InspectionDat.OffsetLaserOnProd, InspectionDat.Endcapcompensation)
                TextBoxActions.Clear()
                TextBoxActions.Text = "Please wait:Running width measurement"
                CheckProdStat += 1
            Case 8
                If (Measurement.IsLaserReady) Then
                    MeasuredWidth = Measurement.GiveLaserWidthResult()
                    TextBoxActions.Clear()
                    TextBoxActions.Text = "Width Measurement ready , Width is:" + MeasuredWidth.ToString("###0.0000") + "Hit next"
                    CheckProdStat += 1
                End If
            Case 9
                If (InspectionDat.MeasureWidth = 1) And (MeasureWidth = True) Then
                    GoodBadW.Visible = True
                    OkW = GoodBadW.Show_Status(MeasuredWidth, InspectionDat.Width, InspectionDat.ToleranceWidthPlus, InspectionDat.ToleranceWidthMinus, 2, False)
                End If

                If (InspectionDat.MeasureDrop = 1) Then
                    GoodBadA.Visible = True
                    OkA = GoodBadA.Show_Status(MeasuredDrop(0), InspectionDat.Drop, InspectionDat.ToleranceDropPlus, InspectionDat.ToleranceDropMinus, 2, False)
                    GoodBadC.Visible = False

                    If ((NumberOfSensorUsed / 2) > 1) Then
                        GoodBadB.Visible = True
                        OkB = GoodBadB.Show_Status(MeasuredDrop(1), InspectionDat.Drop, InspectionDat.ToleranceDropPlus, InspectionDat.ToleranceDropMinus, 2, False)
                        If (InspectionDat.MeasureSquareness = 1) And (MeasureSquareness = True) Then
                            OKE = GoodBadDropEnd.Show_Status(MeasuredDrop(3), 0, InspectionDat.ToleranceDropDiff, InspectionDat.ToleranceDropDiff, 2, False)
                            GoodBadDropEnd.Visible = True
                        End If
                    Else
                        GoodBadB.Visible = False
                        GoodBadDropEnd.Visible = False
                    End If
                    If ((NumberOfSensorUsed / 2) > 2) Then
                        GoodBadC.Visible = True
                        OkC = GoodBadC.Show_Status(MeasuredDrop(2), InspectionDat.Drop, InspectionDat.ToleranceDropPlus, InspectionDat.ToleranceDropMinus, 2, False)
                        If (InspectionDat.MeasureSquareness = 1) And (MeasureSquareness = True) Then
                            OKE = GoodBadDropEnd.Show_Status(MeasuredDrop(3), 0, InspectionDat.ToleranceDropDiff, InspectionDat.ToleranceDropDiff, 2, False)

                            GoodBadDropEnd.Visible = True
                        End If
                    Else
                        GoodBadC.Visible = False
                    End If
                End If
                TextBoxLog.Text = ""
                TextBoxLog.AppendText("OrderNr" + OrderNrStr + vbCrLf)
                TextBoxLog.AppendText("modelfile = " + Modelfilename + vbCrLf)
                TextBoxLog.AppendText("theodrop  " + InspectionDat.Drop.ToString("####.000") + vbCrLf)
                TextBoxLog.AppendText("theowidth  " + InspectionDat.Width.ToString("####.000") + vbCrLf)
                TextBoxLog.AppendText("DropA   " + MeasuredDrop(0).ToString("####.000") + vbCrLf)
                TextBoxLog.AppendText("DropB   " + MeasuredDrop(1).ToString("####.000") + vbCrLf)
                TextBoxLog.AppendText("DropC   " + MeasuredDrop(2).ToString("####.000") + vbCrLf)
                TextBoxLog.AppendText("DropE   " + MeasuredDrop(3).ToString("####.000") + vbCrLf)
                TextBoxLog.AppendText("width   " + MeasuredWidth.ToString("####.000") + vbCrLf)
                myLogFile.Setfilename("Inspect" + TextBoxCnt.Text + ".txt ")
                MainForm.ResultTodatabase(TimeOfDay.ToShortDateString, TimeOfDay.ToShortTimeString, OrderNrStr, InspectionDat.Drop.ToString("####.000"), InspectionDat.Width.ToString("####.000"), MeasuredDrop(0).ToString("####.000"), MeasuredDrop(1).ToString("####.000"), MeasuredDrop(2).ToString("####.000"), MeasuredWidth.ToString("####.000"), MeasuredDrop(0).ToString("####.000"))
                MainForm.ResultToOpc(TimeOfDay.ToShortDateString, TimeOfDay.ToShortTimeString, OrderNrStr, InspectionDat.Drop.ToString("####.000"), InspectionDat.Width.ToString("####.000"), MeasuredDrop(0).ToString("####.000"), MeasuredDrop(1).ToString("####.000"), MeasuredDrop(2).ToString("####.000"), MeasuredWidth.ToString("####.000"), MeasuredDrop(0).ToString("####.000"))

                Integer.TryParse(TextBoxCnt.Text, cnt)
                cnt += 1
                TextBoxCnt.Text = cnt.ToString()
                myLogFile.SaveLog(TextBoxLog)

                CheckProdStat += 1

            Case 10
                If NButton.NextStep() Then

                    CheckProdStat = 0
                    TextBoxDrop.ReadOnly = False
                    TextBoxWidth.ReadOnly = False
                    ComboBoxModel.Enabled = True
                    ComboBoxModel.Visible = True
                    TextBoxModel.Visible = False
                    Me.Close()
                End If


                'continous drop measurement
            Case 30
                If (InspectionDat.MeasureDrop = 1) And (MeasureDrop = True) Then
                    Measurement.StartUSMeasuremenCont(InspectionDat.MountOffSetVert, InspectionDat.Drop, InspectionDat.Width, InspectionDat.BottomBarRadius, InspectionDat.PrefMeasDist)
                    TextBoxActions.Clear()
                    TextBoxActions.Text = "Running continuous drop measurement"
                    CheckProdStat += 1
                Else
                    TextBoxActions.Clear()
                    TextBoxActions.Text = "Skipping continuous drop measurement, push next"
                    CheckProdStat = 10
                End If

            Case 31
                MeasuredDrop(0) = Measurement.GiveUSDropResult(0)

                If ((NumberOfSensorUsed / 2) > 1) Then
                    MeasuredDrop(1) = Measurement.GiveUSDropResult(1)
                End If
                If ((NumberOfSensorUsed / 2) > 2) Then
                    MeasuredDrop(2) = Measurement.GiveUSDropResult(2)
                End If


                GoodBadW.Visible = False
                GoodBadDropEnd.Visible = False

                GoodBadA.Visible = True
                GoodBadA.Show_Status(MeasuredDrop(0), InspectionDat.Drop, InspectionDat.ToleranceDropPlus, InspectionDat.ToleranceDropMinus, 2, True)


                If ((NumberOfSensorUsed / 2) > 1) Then
                    GoodBadB.Visible = True
                    GoodBadB.Show_Status(MeasuredDrop(1), InspectionDat.Drop, InspectionDat.ToleranceDropPlus, InspectionDat.ToleranceDropMinus, 2, True)
                Else
                    GoodBadB.Visible = False
                End If

                If ((NumberOfSensorUsed / 2) > 2) Then
                    GoodBadC.Visible = True
                    GoodBadC.Show_Status(MeasuredDrop(2), InspectionDat.Drop, InspectionDat.ToleranceDropPlus, InspectionDat.ToleranceDropMinus, 2, True)
                Else
                    GoodBadC.Visible = False
                End If

                If NButton.NextStep() Then

                    Measurement.StopContMeasurement()

                    CheckProdStat = 0
                    isloadedbool = False
                    TextBoxDrop.ReadOnly = False
                    TextBoxWidth.ReadOnly = False
                    ComboBoxModel.Enabled = True
                    ComboBoxModel.Visible = True
                    TextBoxModel.Visible = False
                    Me.Close()
                End If

        End Select

        TextBoxCycleStat.Text = CheckProdStat.ToString()
        If (Measurement.givelaserErr() > 0) Then
            TextBoxLaserErr.Text = "Laser Error: " + Measurement.givelaserErrStr()
            TextBoxLaserErr.Visible = True
        Else
            TextBoxLaserErr.Visible = False
        End If
    End Sub



    Private Sub TextBoxCycleStat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxCycleStat.Click
        CheckProdStat = 0
    End Sub

    Private Sub TextBoxWidth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxWidth.Click
        If (TextBoxWidth.ReadOnly = False) Then
            KeyPad_Form.txtValueKeyPad.Text = ""
            KeyPad_Form.MaskedTextBox1.Text = ""
            KeyPad_Form.txtValueKeyPad.Visible = True
            KeyPad_Form.KeyBoard.Visible = False
            KeyPad_Form.MaskedTextBox1.Visible = False
            KeyPad_Form.Numpad.Visible = True
            KeyPad_Form.Size = New Size(291, 392) '   (746, 392)
            KeyPad_Form.ShowDialog()
            TextBoxWidth.Text = KeyPad_Form.txtValueKeyPad.Text
            If (Double.TryParse(TextBoxWidth.Text, InspectionDat.Width)) Then
                TextBoxWidth.Text = InspectionDat.Width.ToString("###0.0000")
            End If
        End If
    End Sub

    Private Sub TextBoxDrop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxDrop.Click
        If (TextBoxDrop.ReadOnly = False) Then
            KeyPad_Form.txtValueKeyPad.Text = ""
            KeyPad_Form.MaskedTextBox1.Text = ""
            KeyPad_Form.txtValueKeyPad.Visible = True
            KeyPad_Form.KeyBoard.Visible = False
            KeyPad_Form.MaskedTextBox1.Visible = False
            KeyPad_Form.Numpad.Visible = True
            KeyPad_Form.Size = New Size(291, 392) '   (746, 392)
            KeyPad_Form.ShowDialog()
            TextBoxDrop.Text = KeyPad_Form.txtValueKeyPad.Text
            If (Double.TryParse(TextBoxDrop.Text, InspectionDat.Drop)) Then
                TextBoxDrop.Text = InspectionDat.Drop.ToString("###0.0000")
            End If
        End If

    End Sub

    Private Sub ButtonContDropMeasure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonContDropMeasure.Click
        CheckProdStat = 30
    End Sub

    Private Sub ButtonFullMeasurement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFullMeasurement.Click
        CheckProdStat = 1
    End Sub


End Class