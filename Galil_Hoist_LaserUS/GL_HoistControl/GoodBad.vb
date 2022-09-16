Public Class GoodBad
    Dim OK As Boolean
    Dim AlmostOk As Boolean
    Dim DirUp As Boolean
    Dim lGBText As String
    Public Property GBText() As String
        Get
            Return GroupBoxGoodBad.Text
        End Get
        Set(ByVal value As String)
            lGBText = value
            GroupBoxGoodBad.Text = lGBText
        End Set
    End Property
    

    Public Function Show_Status(ByVal aMValue As Double, ByVal aTValue As Double, ByVal PlusTol As Double, ByVal MinTol As Double, ByVal aAlmostFactor As Double, ByVal aShowDir As Boolean) As Boolean
        OK = True
        AlmostOk = True

        If (aMValue = -1) Or (aMValue = -2) Then
            If aMValue = -1 Then
                TextBoxGoodBad.Text = "Error"
            End If
            If aMValue = -2 Then
                TextBoxGoodBad.Text = " "
                Me.Visible = False
            End If

            TextBoxValue.Text = " "
            PictureBoxUpDown.Visible = False
            TextBoxGoodBad.BackColor = Color.White
            OK = False
        Else
            TextBoxValue.Text = aMValue.ToString("###0.0000")

            If ((aMValue - aTValue) > 0) And ((aMValue - aTValue) > PlusTol) Then

                OK = False
            End If
            If (((aMValue - aTValue) < 0)) And (Math.Abs(aMValue - aTValue) > Math.Abs(MinTol)) Then
                OK = False
            End If

            ' almost?

            If ((aMValue - aTValue) > 0) And ((aMValue - aTValue) > (PlusTol * aAlmostFactor)) Then
                AlmostOk = False
            End If

            If (((aMValue - aTValue) < 0)) And (Math.Abs(aMValue - aTValue) > Math.Abs(MinTol) * aAlmostFactor) Then
                AlmostOk = False
            End If

            DirUp = ((aMValue - aTValue) > 0)

            If OK Then
                TextBoxGoodBad.Text = "GOOD"
                TextBoxGoodBad.BackColor = Color.Green
                PictureBoxUpDown.Visible = False
            Else
                If (aShowDir) Then
                    PictureBoxUpDown.Visible = True
                    If (DirUp) Then
                        TextBoxGoodBad.Text = "GO UP"
                        PictureBoxUpDown.Image = GL_HoistControl.My.Resources.Resources.Up1
                    Else
                        TextBoxGoodBad.Text = "GO DOWN"
                        PictureBoxUpDown.Image = GL_HoistControl.My.Resources.Resources.Dn1
                    End If
                Else
                    TextBoxGoodBad.Text = "BAD"
                    PictureBoxUpDown.Visible = False
                End If
                If AlmostOk Then
                    TextBoxGoodBad.BackColor = Color.Yellow
                Else
                    TextBoxGoodBad.BackColor = Color.Red
                End If
            End If
        End If
        If aMValue = -2 Then
            OK = True  ' sensor is out of reach of the blind thus we will not use this sensor in the evaluation
        End If

        Return OK
    End Function

    Public Function GoodBad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBoxUpDown.Image = GL_HoistControl.My.Resources.Resources.Up1
        ' Visible = False
        Return True
    End Function


    Public Function ClearValue() As Boolean
        TextBoxValue.Text = " "
        Return (True)
    End Function
End Class
