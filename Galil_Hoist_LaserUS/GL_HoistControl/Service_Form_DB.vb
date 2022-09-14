Public Class Service_Form_DB




   
    Private Sub Service_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       

        ParamFiles.OpenParamFile(ParamFileName, DataGridViewSettings)
        KeyPad_Form.txtValueKeyPad.Text = ""
        KeyPad_Form.MaskedTextBox1.Text = ""
        KeyPad_Form.txtValueKeyPad.Visible = True
        KeyPad_Form.KeyBoard.Visible = False
        KeyPad_Form.MaskedTextBox1.Visible = False
        KeyPad_Form.Numpad.Visible = True
        KeyPad_Form.Size = New Size(291, 392) '   (746, 392)

    End Sub



    Private Sub Exit_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_Btn.Click
        Close()
    End Sub

    Private Sub SystemTST_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemTST_btn.Click
        SystemTest.ShowDialog()
    End Sub

    Private Sub Exit_Service_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_Service_btn.Click
        Me.Close()
    End Sub

    Private Sub ButtonMeasurementTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMeasurementTest.Click
        Measurement.ShowDialog()
    End Sub

    Private Sub ButtonSaveSpeed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSaveSpeed.Click

        ParamFiles.SaveParams()
        If (debugmode = False) Then
            SpeedSetSaveToGalil()
            GainSetSaveToGalil()
            HoistDimSetSaveToGalil()
            GalilActVal_form.UploadGalilVal()
        End If

        Measurement.LoadMeasureParams()
    End Sub


    Private Sub SpeedSetSaveToGalil()
        Dim Succes = True
        If ParamFiles.OpenReadParamFile(ParamFileName, "scale", scalefact) Then
            MainForm.galil.command("SCALE=" & Str$(scalefact))
        Else
            Succes = False
        End If

        If ParamFiles.OpenReadParamFile(ParamFileName, "jog_speed", jog_speed) Then
            MainForm.galil.command("JOGSPD=" & Str$(jog_speed))
        Else
            Succes = False
        End If

        If ParamFiles.OpenReadParamFile(ParamFileName, "move_speed", move_speed) Then
            MainForm.galil.command("MOVSPD=" & Str$(move_speed))
        Else
            Succes = False
        End If

        If ParamFiles.OpenReadParamFile(ParamFileName, "accel", accel) Then
            MainForm.galil.command("ACCEL=" & Str$(accel))
        Else
            Succes = False
        End If

        If ParamFiles.OpenReadParamFile(ParamFileName, "decel", decel) Then
            MainForm.galil.command("DECEL=" & Str$(decel))
        Else
            Succes = False
        End If

        If ParamFiles.OpenReadParamFile(ParamFileName, "home", home) Then
            MainForm.galil.command("HOME=" & Str$(home))
        Else
            Succes = False
        End If

        If ParamFiles.OpenReadParamFile(ParamFileName, "home_offset", homeoffset) Then
            MainForm.galil.command("HOMEOFF=" & Str$(homeoffset))
        Else
            Succes = False
        End If

        MainForm.galil.command("BV") 'burn values
        System.Threading.Thread.Sleep(1000)
        If Not Succes Then
            MsgBox("error saving  speedsettings")
        End If
    End Sub


    Private Sub GainSetSaveToGalil()
        Dim Succes = True
        Dim Val As Single

        If ParamFiles.OpenReadParamFile(ParamFileName, "KPA", Val) Then

            MainForm.galil.command("KPA=" & Str$(Val))
        Else
            Succes = False
        End If
        If ParamFiles.OpenReadParamFile(ParamFileName, "KIA", Val) Then
            MainForm.galil.command("KIA=" & Str$(Val))
        Else
            Succes = False
        End If

        If ParamFiles.OpenReadParamFile(ParamFileName, "KDA", Val) Then
            MainForm.galil.command("KDA=" & Str$(Val))
        Else
            Succes = False
        End If
        MainForm.galil.command("BN") '
        MainForm.galil.command("BV") 'burn values
        System.Threading.Thread.Sleep(500)
        If Not Succes Then
            MsgBox("error saving  gainsettings")
        End If
    End Sub

    Private Sub HoistDimSetSaveToGalil()
        Dim Succes = True
        Dim Val As Single
        If ParamFiles.OpenReadParamFile(ParamFileName, "RingDist", Val) Then
            MainForm.galil.command("MGRD=" & Str$(Val))
        Else
            Succes = False
        End If

        If ParamFiles.OpenReadParamFile(ParamFileName, "LastRing", Val) Then
            MainForm.galil.command("MGLR=" & Str$(Val))
        Else
            Succes = False
        End If

        If ParamFiles.OpenReadParamFile(ParamFileName, "DropToTable", Val) Then
            MainForm.galil.command("MGDTT=" & Str$(Val))
        Else
            Succes = False
        End If

        If ParamFiles.OpenReadParamFile(ParamFileName, "ShadeSlack", Val) Then
            MainForm.galil.command("MGSS=" & Str$(Val))
        Else
            Succes = False
        End If

        If ParamFiles.OpenReadParamFile(ParamFileName, "Eye_Level", Val) Then
            MainForm.galil.command("MGBL=" & Str$(Val))
        Else
            Succes = False
        End If

        If ParamFiles.OpenReadParamFile(ParamFileName, "HighLimit", Val) Then
            MainForm.galil.command("HIGHLIM=" & Str$(Val))
        Else
            Succes = False
        End If

        If ParamFiles.OpenReadParamFile(ParamFileName, "LowLimit", Val) Then
            MainForm.galil.command("LOWLIM=" & Str$(Val))
        Else
            Succes = False
        End If

        MainForm.galil.command("BV") 'burn values
        System.Threading.Thread.Sleep(500)
        If Not Succes Then
            MsgBox("error saving  Hoist Dimensions")
        End If
    End Sub

    Private Sub EditCell(ByVal e As System.EventArgs, ByRef DataGridView As DataGridView)
        Dim i As Integer = DataGridView.SelectedRows(0).Index
        Dim Y As Integer = 0
        Dim ok As Boolean = False
        Dim Val As Single = 0
        For Y = 0 To DataGridView.Columns.Count - 1

            If (DataGridView.Columns(Y).HeaderText.Equals("ParameterValue")) Then
                ok = True
                Exit For
            End If
        Next
        If (ok) Then
            ' MsgBox(DataGridView.Rows(i).Cells(Y).Value.ToString)

            KeyPad_Form.txtValueKeyPad.Text = Math.Round(DataGridView.Rows(i).Cells(Y).Value, 4).ToString()

        KeyPad_Form.ShowDialog()
        Single.TryParse(KeyPad_Form.txtValueKeyPad.Text, Val)
            DataGridView.Rows(i).Cells(Y).Value = Math.Round(Val, 4)
        If (i < DataGridView.Rows.Count - 1) Then
            DataGridView.Rows(i + 1).Cells(Y).Selected = True  'otherwise the changed cell value does not show up in the update command 
        Else
            DataGridView.Rows(i - 1).Cells(Y).Selected = True  'otherwise the changed cell value does not show up in the update command 
        End If
        End If
    End Sub

    Private Sub ButtonEditSpeedSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEditSpeedSetting.Click
        EditCell(e, DataGridViewSettings)
    End Sub

    Private Sub ButtonUploadGalilValues_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUploadGalilValues.Click
        GalilActVal_form.ShowDialog()
    End Sub

    Private Sub ButtonParams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ParamFiles.ShowDialog()
    End Sub

   
    Private Sub ButtonModelFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModelFiles.Click
        ModelFiles.ShowDialog()
    End Sub
End Class