Public Class GalilActVal_form

    Private Sub GalilActVal_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Query_Speed()
        'query scale variable, display and use for calcs
        scalefact = MainForm.galil.commandValue("SCALE=?")
        'DMCPoll1.DMCScale = (1 / scalefact)
        txtScale.Text = Str$(scalefact)

        'query jog speed and display it
        jog_speed = MainForm.galil.commandValue("JOGSPD=?")
        txtJogSpeed.Text = Format(jog_speed, "#0.00")

        'query move speed and display it
        move_speed = MainForm.galil.commandValue("MOVSPD=?")
        txtMovespeed.Text = Format(move_speed, "#0.00")

        'query accel and display it
        accel = MainForm.galil.commandValue("ACCEL=?")
        txtAccel.Text = Format(accel, "#0.00")

        'query decel and display it
        decel = MainForm.galil.commandValue("DECEL=?")
        txtDecel.Text = Format(decel, "#0.00")

        'query home value and display it
        home = MainForm.galil.commandValue("HOME=?")
        txtHome.Text = Format(home, "#0.00")

        'query home value and display it
        homeoffset = MainForm.galil.commandValue("HOMEOFF=?")
        txtHomeoffset.Text = Format(homeoffset, "#0.00")
    End Sub
   
    Public Sub Query_Gains()
        'query gains
        txtKp.Text = MainForm.galil.commandValue("KPA=?")

        txtKi.Text = MainForm.galil.commandValue("KIA=?")

        txtKd.Text = MainForm.galil.commandValue("KDA=?")
    End Sub

    Private Sub Exit_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_Btn.Click
        Me.Close()
    End Sub

    Private Sub ButtonUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpload.Click
        UploadGalilVal()
    End Sub

    Public Sub UploadGalilVal()
        If debugmode <> True Then
            System.Threading.Thread.Sleep(1000)
            Call Query_Speed()
            System.Threading.Thread.Sleep(200)
            Call Query_Gains()
           
        End If
    End Sub
End Class