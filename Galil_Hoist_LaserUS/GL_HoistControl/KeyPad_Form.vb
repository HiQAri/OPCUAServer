Public Class KeyPad_Form

    Private Sub Button_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_0.Click
        txtValueKeyPad.AppendText("0")
    End Sub

    Private Sub Button_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_1.Click
        txtValueKeyPad.AppendText("1")
    End Sub

    Private Sub Button_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_2.Click
        txtValueKeyPad.AppendText("2")
    End Sub

    Private Sub Button_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_3.Click
        txtValueKeyPad.AppendText("3")
    End Sub
    Private Sub Button_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_4.Click
        txtValueKeyPad.AppendText("4")
    End Sub
    Private Sub Button_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_5.Click
        txtValueKeyPad.AppendText("5")
    End Sub
    Private Sub Button_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_6.Click
        txtValueKeyPad.AppendText("6")
    End Sub
    Private Sub Button_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_7.Click
        txtValueKeyPad.AppendText("7")
    End Sub
    Private Sub Button_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_8.Click
        txtValueKeyPad.AppendText("8")
    End Sub
    Private Sub Button_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_9.Click
        txtValueKeyPad.AppendText("9")
    End Sub

    Private Sub Button_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_OK.Click
        Close()
    End Sub

    Private Sub Button_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Del.Click
        If txtValueKeyPad.Text.Length > 0 Then
            txtValueKeyPad.Text = txtValueKeyPad.Text.Remove(txtValueKeyPad.Text.Length - 1, 1)
        End If
        If MaskedTextBox1.Text.Length > 0 Then
            MaskedTextBox1.Text = MaskedTextBox1.Text.Remove(MaskedTextBox1.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub KeyPad_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtValueKeyPad.Text = ""
        MaskedTextBox1.Text = ""

    End Sub

    Private Sub Button_Clr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Clr.Click
        txtValueKeyPad.Text = ""
    End Sub

    Private Sub ButtonQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQ.Click
        txtValueKeyPad.AppendText("Q")
        MaskedTextBox1.AppendText("Q")
    End Sub

    Private Sub ButtonW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonW.Click
        txtValueKeyPad.AppendText("W")
        MaskedTextBox1.AppendText("W")
    End Sub

    Private Sub ButtonE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonE.Click
        txtValueKeyPad.AppendText("E")
        MaskedTextBox1.AppendText("E")
    End Sub

    Private Sub ButtonR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonR.Click
        txtValueKeyPad.AppendText("R")
        MaskedTextBox1.AppendText("R")
    End Sub

    Private Sub ButtonT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonT.Click
        txtValueKeyPad.AppendText("T")
        MaskedTextBox1.AppendText("T")
    End Sub

    Private Sub ButtonY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonY.Click
        txtValueKeyPad.AppendText("Y")
        MaskedTextBox1.AppendText("Y")
    End Sub

    Private Sub ButtonU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonU.Click
        txtValueKeyPad.AppendText("U")
        MaskedTextBox1.AppendText("U")
    End Sub

    Private Sub ButtonI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonI.Click
        txtValueKeyPad.AppendText("I")
        MaskedTextBox1.AppendText("I")
    End Sub

    Private Sub ButtonO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonO.Click
        txtValueKeyPad.AppendText("O")
        MaskedTextBox1.AppendText("O")
    End Sub

    Private Sub ButtonA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonA.Click
        txtValueKeyPad.AppendText("A")
        MaskedTextBox1.AppendText("A")
    End Sub

    Private Sub ButtonS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonS.Click
        txtValueKeyPad.AppendText("S")
        MaskedTextBox1.AppendText("S")
    End Sub

    Private Sub ButtonD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonD.Click
        txtValueKeyPad.AppendText("D")
        MaskedTextBox1.AppendText("D")
    End Sub

    Private Sub ButtonF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonF.Click
        txtValueKeyPad.AppendText("F")
        MaskedTextBox1.AppendText("F")
    End Sub

    Private Sub ButtonG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonG.Click
        txtValueKeyPad.AppendText("G")
        MaskedTextBox1.AppendText("G")
    End Sub

    Private Sub ButtonH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonH.Click
        txtValueKeyPad.AppendText("H")
        MaskedTextBox1.AppendText("H")
    End Sub

    Private Sub ButtonJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonJ.Click
        txtValueKeyPad.AppendText("J")
        MaskedTextBox1.AppendText("J")
    End Sub

    Private Sub ButtonK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonK.Click
        txtValueKeyPad.AppendText("K")
        MaskedTextBox1.AppendText("K")
    End Sub

    Private Sub ButtonL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonL.Click
        txtValueKeyPad.AppendText("L")
        MaskedTextBox1.AppendText("L")
    End Sub

    Private Sub ButtonZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonZ.Click
        txtValueKeyPad.AppendText("Z")
        MaskedTextBox1.AppendText("Z")
    End Sub

    Private Sub ButtonX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX.Click
        txtValueKeyPad.AppendText("X")
        MaskedTextBox1.AppendText("X")
    End Sub

    Private Sub ButtonC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonC.Click
        txtValueKeyPad.AppendText("C")
        MaskedTextBox1.AppendText("C")
    End Sub

    Private Sub ButtonV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonV.Click
        txtValueKeyPad.AppendText("V")
        MaskedTextBox1.AppendText("V")
    End Sub

    Private Sub ButtonB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonB.Click
        txtValueKeyPad.AppendText("B")
        MaskedTextBox1.AppendText("B")
    End Sub

    Private Sub ButtonN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonN.Click
        txtValueKeyPad.AppendText("N")
        MaskedTextBox1.AppendText("N")
    End Sub

    Private Sub ButtonM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonM.Click
        txtValueKeyPad.AppendText("M")
        MaskedTextBox1.AppendText("M")
    End Sub

    Private Sub Button_Comma1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Comma1.Click
        txtValueKeyPad.AppendText(",")
        MaskedTextBox1.AppendText(",")
    End Sub

    Private Sub Button_Dot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Dot.Click
        txtValueKeyPad.AppendText(".")
        MaskedTextBox1.AppendText(".")
    End Sub

    Private Sub Button_Slash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Slash.Click
        txtValueKeyPad.AppendText("/")
        MaskedTextBox1.AppendText("/")
    End Sub

    Private Sub Button_Enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Enter.Click
        Close()
    End Sub

    Private Sub Button_Comma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Comma.Click
        If txtValueKeyPad.Text.Contains(".") Then
            Exit Sub
        Else
            txtValueKeyPad.AppendText(".")
            MaskedTextBox1.AppendText(".")
        End If
    End Sub

    Private Sub ButtonP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonP.Click
        txtValueKeyPad.AppendText("P")
        MaskedTextBox1.AppendText("P")
    End Sub
End Class