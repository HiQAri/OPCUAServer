Module Module1
    Public debugmode As Boolean = True
    Public NumberOfSensorUsed = 2
    Public SW_Version As String = "Version:" + vbCrLf + "2.0"
    Public int_strlgth As Integer
    Public jog_speed As Single
    Public move_speed As Single
    Public accel As Single
    Public decel As Single
    Public position As Double 'Single
    Public scalefact As Single
    Public scaled_position As Double 'Single
    Public real_response As Single
    Public scaled_speed As Single
    Public scaled_accel As Single
    Public scaled_decel As Single
    Public home As Single
    Public homeoffset As Single

    Public response As String
    Public switch_state As Integer
    Public estop_state As String
    Public homestatus As String
    Public Index As String

    Public servoready As String

    Public SeqStep As Integer
    Public NumPad_Enter As Double
    Public RequestField As String
    Public strEntry As String
    Public strXMoving As Integer
    Public XHoming As Boolean
    Public SystemTest_Go_ON As Boolean
    Public inputA1 As Double
    Public inputA2 As Double
    Public systemtest_currentTarget As Double
    Public Start_US_measurement As Boolean
    Public onRecord_countDown As Long
    Public DoUSMeasurement As Boolean = False
    Public ParamFileName As String = "..\Paramfiles\params.xlsx"
    Public HighLimit As Double
    Public LowLimit As Double
    Public USSensorsOn As Boolean

    Public Function IsFormOpen(ByVal frm As Form) As Boolean
        If Application.OpenForms.OfType(Of Form).Contains(frm) Then
            Return True
        Else
            Return False
        End If
    End Function


End Module
