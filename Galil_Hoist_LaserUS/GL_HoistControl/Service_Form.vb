Public Class Service_Form
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        scalefact = Val(txtScale.Text)
        MainForm.galil.command("SCALE=" & Str$(scalefact))
        jog_speed = Val(txtJogSpeed.Text)
        MainForm.galil.command("JOGSPD=" & Str$(jog_speed))
        move_speed = Val(txtMovespeed.Text)
        MainForm.galil.command("MOVSPD=" & Str$(move_speed))
        accel = Val(txtAccel.Text)
        MainForm.galil.command("ACCEL=" & Str$(accel))
        decel = Val(txtDecel.Text)
        MainForm.galil.command("DECEL=" & Str$(decel))
        home = Val(txtHome.Text)
        MainForm.galil.command("HOME=" & Str$(home))
        homeoffset = Val(txtHomeoffset.Text)
        MainForm.galil.command("HOMEOFF=" & Str$(homeoffset))
        MainForm.galil.command("BV") 'burn values
        System.Threading.Thread.Sleep(1000)

    End Sub

    Private Sub txtJogSpeed_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJogSpeed.Click
        KeyPad_Form.txtValueKeyPad.Text = txtJogSpeed.Text
        KeyPad_Form.ShowDialog()
        txtJogSpeed.Text = KeyPad_Form.txtValueKeyPad.Text
    End Sub

    Private Sub txtMovespeed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMovespeed.Click
        KeyPad_Form.txtValueKeyPad.Text = txtMovespeed.Text 'KeyPad_Form.txtValueKeyPad.Text = ""
        KeyPad_Form.ShowDialog()
        txtMovespeed.Text = KeyPad_Form.txtValueKeyPad.Text
    End Sub

    Private Sub txtAccel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccel.Click
        KeyPad_Form.txtValueKeyPad.Text = txtAccel.Text
        KeyPad_Form.ShowDialog()
        txtAccel.Text = KeyPad_Form.txtValueKeyPad.Text
    End Sub

    Private Sub txtDecel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDecel.Click
        KeyPad_Form.txtValueKeyPad.Text = txtDecel.Text
        KeyPad_Form.ShowDialog()
        txtDecel.Text = KeyPad_Form.txtValueKeyPad.Text
    End Sub

    Private Sub txtScale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtScale.Click
        KeyPad_Form.txtValueKeyPad.Text = txtScale.Text
        KeyPad_Form.ShowDialog()
        txtScale.Text = KeyPad_Form.txtValueKeyPad.Text
    End Sub

    Private Sub txtHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHome.Click
        KeyPad_Form.txtValueKeyPad.Text = txtHome.Text
        KeyPad_Form.ShowDialog()
        txtHome.Text = KeyPad_Form.txtValueKeyPad.Text
    End Sub

    Private Sub txtHomeoffset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHomeoffset.Click
        KeyPad_Form.txtValueKeyPad.Text = txtHomeoffset.Text
        KeyPad_Form.ShowDialog()
        txtHomeoffset.Text = KeyPad_Form.txtValueKeyPad.Text
    End Sub

    Private Sub CmdSave2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSave2.Click
        MainForm.galil.command("KPA=" & txtKp.Text)
        MainForm.galil.command("KIA=" & txtKi.Text)
        MainForm.galil.command("KDA=" & txtKd.Text)
        MainForm.galil.command("BN") '
        MainForm.galil.command("BV") 'burn values
        System.Threading.Thread.Sleep(500)
    End Sub
    Private Sub txtKp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKp.Click
        KeyPad_Form.txtValueKeyPad.Text = txtKp.Text
        KeyPad_Form.ShowDialog()
        txtKp.Text = KeyPad_Form.txtValueKeyPad.Text
    End Sub
    Private Sub txtKi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKi.Click
        KeyPad_Form.txtValueKeyPad.Text = txtKi.Text
        KeyPad_Form.ShowDialog()
        txtKi.Text = KeyPad_Form.txtValueKeyPad.Text
    End Sub
    Private Sub txtKd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKd.Click
        KeyPad_Form.txtValueKeyPad.Text = txtKd.Text
        KeyPad_Form.ShowDialog()
        txtKd.Text = KeyPad_Form.txtValueKeyPad.Text
    End Sub

    Private Sub CmdSave3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSave3.Click
        Debug.Print("MGRD=" & txtRingDist.Text)
        MainForm.galil.command("MGRD=" & txtRingDist.Text)
        Debug.Print("MGLR=" & txtLastRing.Text)
        MainForm.galil.command("MGLR=" & txtLastRing.Text)
        Debug.Print("MGDTT=" & txtDropToTable.Text)
        MainForm.galil.command("MGDTT=" & txtDropToTable.Text)
        Debug.Print("MGSS=" & txtShadeSlack.Text)
        MainForm.galil.command("MGSS=" & txtShadeSlack.Text)
        Debug.Print("MGBL=" & txtBarLevel.Text)
        MainForm.galil.command("MGBL=" & txtBarLevel.Text)
        Debug.Print("HIGHLIM" & txtHighLimit.Text)
        MainForm.galil.command("HIGHLIM=" & txtHighLimit.Text)
        Debug.Print("LOWLIM=" & txtLowLimit.Text)
        MainForm.galil.command("LOWLIM=" & txtLowLimit.Text)
        'Debug.Print("MGDTT=" & txtDropToTable.Text)
        'Form1.galil.command("MGDTT=" & txtDropToTable.Text)
        'Debug.Print("MGSS=" & txtShadeSlack.Text)
        'Form1.galil.command("MGSS=" & txtShadeSlack.Text)
        'Debug.Print("MGEL=" & txtBarLevel.Text)
        'Form1.galil.command("MGEL=" & txtBarLevel.Text)
        'Debug.Print("HIGHLIM" & txtHighLimit.Text)
        'Form1.galil.command("HIGHLIM=" & txtHighLimit.Text)
        'Debug.Print("LOWLIM=" & txtLowLimit.Text)
        'Form1.galil.command("LOWLIM=" & txtLowLimit.Text)
        'Call frmMain.Query_MGvars
        MainForm.galil.command("BV")
        System.Threading.Thread.Sleep(500)
    End Sub
    Private Sub txtDropToTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDropToTable.Click
        KeyPad_Form.txtValueKeyPad.Text = txtDropToTable.Text
        KeyPad_Form.ShowDialog()
        txtDropToTable.Text = KeyPad_Form.txtValueKeyPad.Text
    End Sub
    Private Sub txtShadeSlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtShadeSlack.Click
        KeyPad_Form.txtValueKeyPad.Text = txtShadeSlack.Text
        KeyPad_Form.ShowDialog()
        txtShadeSlack.Text = KeyPad_Form.txtValueKeyPad.Text
    End Sub
    Private Sub txtEyeLevel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarLevel.Click
        KeyPad_Form.txtValueKeyPad.Text = txtBarLevel.Text
        KeyPad_Form.ShowDialog()
        txtBarLevel.Text = KeyPad_Form.txtValueKeyPad.Text
    End Sub
    Private Sub txtHighLimit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHighLimit.Click
        KeyPad_Form.txtValueKeyPad.Text = txtHighLimit.Text
        KeyPad_Form.ShowDialog()
        txtHighLimit.Text = KeyPad_Form.txtValueKeyPad.Text
    End Sub
    Private Sub txtLowLimit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLowLimit.Click
        KeyPad_Form.txtValueKeyPad.Text = txtLowLimit.Text
        KeyPad_Form.ShowDialog()
        txtLowLimit.Text = KeyPad_Form.txtValueKeyPad.Text
    End Sub
    Private Sub Service_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KeyPad_Form.txtValueKeyPad.Text = ""
        KeyPad_Form.MaskedTextBox1.Text = ""
        KeyPad_Form.txtValueKeyPad.Visible = True
        KeyPad_Form.KeyBoard.Visible = False
        KeyPad_Form.MaskedTextBox1.Visible = False
        KeyPad_Form.Numpad.Visible = True
        KeyPad_Form.Size = New Size(291, 392) '   (746, 392)
        'TODO: This line of code loads data into the 'GalilHoistDataSet.RollUpDist' table. You can move, or remove it, as needed.
        Me.RollUpDistTableAdapter.Fill(Me.GalilHoistDataSet.RollUpDist)

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
End Class