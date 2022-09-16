Public Class NextButtonColor

    Dim DoNextStep = False


    Public Overloads Property Text As String

        Set(ByVal value As String)
            nextButton.Text = value
        End Set
        Get
            Return nextButton.Text
        End Get
    End Property

    Public Overloads Property visible As Boolean

        Set(ByVal value As Boolean)
            nextButton.Visible = value
        End Set
        Get
            Return nextButton.Visible
        End Get
    End Property
    Public Function GoNextstep()
        DoNextStep = True
        Return True
    End Function

    Public Function NextStep() As Boolean
        If (DoNextStep) Then
            nextButton.Enabled = False

            nextButton.BackColor = Color.Azure
            DoNextStep = False
            Return True
        Else
            nextButton.Enabled = True
            nextButton.BackColor = Color.LightGreen
            Return False
        End If

    End Function


    Private Sub nextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextButton.Click
        DoNextStep = True
    End Sub

    Private Sub NextButtonColor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nextButton.Enabled = False
        nextButton.BackColor = Color.Azure
        DoNextStep = False
    End Sub
End Class
