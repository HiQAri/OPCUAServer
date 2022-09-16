Public Class HoistCalculations

    Public Function CalcMedian(ByRef aSource As Double(,), ByVal aSensor As Integer, ByVal TotalNrOf As Integer) As Double

        insertionSort(aSource, aSensor, TotalNrOf)
        Dim ind As Integer = TotalNrOf
        If ((ind Mod 2) > 0) Then
            Return (aSource(aSensor, TotalNrOf / 2) + aSource(aSensor, (TotalNrOf / 2) + 1)) / 2 'even number so take the average of the two middle values
        Else
            Return aSource(aSensor, (TotalNrOf / 2) + 1)
        End If
    End Function

    Sub insertionSort(ByRef dataset As Double(,), ByVal aSensor As Integer, ByVal n As Integer)
        Dim i, j As Integer

        For i = 1 To n - 1 Step 1

            Dim pick_item As Double = dataset(aSensor, i)
            Dim inserted As Integer = 0

            j = i - 1
            While (j >= 0 And inserted <> 1)
                If (pick_item < dataset(aSensor, j)) Then
                    dataset(aSensor, j + 1) = dataset(aSensor, j)
                    j -= 1
                    dataset(aSensor, j + 1) = pick_item
                Else : inserted = 1
                End If
            End While
        Next
    End Sub

    Public Function calculate_average(ByVal aMeasureMents As Double(), ByVal TotalNrOf As Integer, ByVal skip As Integer) As Double
        Dim Sum As Double = 0
        Dim ind As Integer
        For ind = skip To (TotalNrOf - 1)
            Sum += aMeasureMents(ind)
        Next
        Return Sum / (TotalNrOf - skip)
    End Function

    Public Function calculate_median_outliers_average(ByRef aMeasureMents As Double(,), ByVal aSensor As Integer, ByRef TotalNrOf As Integer, ByVal DevCrit As Double, ByVal LogLevel As Integer, ByRef aNrPointsLeft As Integer) As Double
        Dim Medium As Double = 0
        Dim Valid(100) As Boolean

        Medium = CalcMedian(aMeasureMents, aSensor, TotalNrOf)

        'TextBoxLog.AppendText("median is " + Medium.ToString() + vbCrLf)

        For cnt = 0 To TotalNrOf - 1
            ' If (Math.Abs(aMeasureMents(aSensor, cnt) - Medium) > ((Perc / 100) * Math.Abs(Medium))) Then
            If (Math.Abs(aMeasureMents(aSensor, cnt) - Medium) > DevCrit) Then
                Valid(cnt) = False
            Else
                Valid(cnt) = True
            End If
        Next

        Dim Sum As Double = 0
        Dim Count As Integer = 0
        Dim ind As Integer
        For ind = 0 To (TotalNrOf - 1)
            If (Valid(ind)) Then
                Sum += aMeasureMents(aSensor, ind)
                Count += 1
            End If
        Next

        ' If (LogLevel > 0) Then
        ' TextBoxLog.AppendText("sensor is: " + aSensor.ToString() + vbCrLf)
        ' TextBoxLog.AppendText("number of valid points in calc med-outl-avg is = " & Count.ToString & vbCrLf)
        ' TextBoxLog.AppendText("taken out " & (TotalNrOf - Count).ToString & " points " & vbCrLf)
        ' End If
        aNrPointsLeft = Count
        Return Sum / (Count)
    End Function




    ' sens pair is 0,1,2
    Public Function CalcCalibrationTriangle(ByVal aSensPair As Integer, ByVal DoMirrorX0 As Boolean, ByVal BarRad As Double, ByVal aMeasureMentsSens0 As Double(), ByVal aMeasureMentsSens1 As Double(), ByRef AlfaS0S1Refline As Double, ByRef Dist_Z As Double, ByRef RefHeightFromS1 As Double, ByRef Dist_C As Double) As Double
        'barrad is the radius of the calibration bar. It is added to the measurement value so we use the distance to the centre line of the bar.
        ' Dim O As Double = aMeasureMentsSens0(1) + BarRad  ' High object
        ' Dim N As Double = aMeasureMentsSens0(0) + BarRad   ' low object
        ' Dim Q As Double = aMeasureMentsSens1(1) + BarRad   ' High object
        ' Dim P As Double = aMeasureMentsSens1(0) + BarRad   ' low object
        ' Dim Z As Double = Dist_Z
        If (aMeasureMentsSens1(0 + (2 * aSensPair)) = -1) Or (aMeasureMentsSens0(0 + (2 * aSensPair)) = -1) Or (aMeasureMentsSens1(1 + (2 * aSensPair)) = -1) Or (aMeasureMentsSens0(1 + (2 * aSensPair)) = -1) Then

            AlfaS0S1Refline = -1000
            RefHeightFromS1 = -1000
            Dist_C = -1000
        Else


            Dim O As Double = aMeasureMentsSens1(0 + (2 * aSensPair)) + BarRad  ' High object first sensor 
            Dim N As Double = aMeasureMentsSens0(0 + (2 * aSensPair)) + BarRad  ' low object first sensor
            Dim Q As Double = aMeasureMentsSens1(1 + (2 * aSensPair)) + BarRad  ' High object second sensor
            Dim P As Double = aMeasureMentsSens0(1 + (2 * aSensPair)) + BarRad  ' low object second sensor
            Dim Z As Double = Dist_Z




            'Dim TB As System.Windows.Forms.TextBox
            'TB = TextBoxCalcCalib


            'TB.Text = " "
            'TB.AppendText("calibration calc" + vbCrLf)
            '
            '           TB.AppendText("O= " + O.ToString("###0.0000") + vbCrLf)
            '           TB.AppendText("N= " + N.ToString("###0.0000") + vbCrLf)
            '           TB.AppendText("P= " + P.ToString("###0.0000") + vbCrLf)
            '          TB.AppendText("Q= " + Q.ToString("###0.0000") + vbCrLf)
            '          TB.AppendText("Z= " + Z.ToString("###0.0000") + vbCrLf)

            Dim Y0 As Double = 0

            If (Z > 0) Then
                Y0 = ((Z * Z) + (O * O) - (N * N)) / (2 * Z)
            Else
                Y0 = 0
                Return False
            End If

            ' TB.AppendText("Y0= " + Y0.ToString("###0.0000") + vbCrLf)

            Dim X0 = Math.Sqrt((O * O) - (Y0 * Y0))

            If (DoMirrorX0) Then
                X0 = -X0
            End If

            ' TB.AppendText("X0= " + X0.ToString("###0.0000") + vbCrLf)

            Dim Y1 As Double = 0

            If (Z > 0) Then
                Y1 = ((Z * Z) + (Q * Q) - (P * P)) / (2 * Z)
            Else
                Y1 = 0
                Return False
            End If

            'TB.AppendText("Y1= " + Y1.ToString("###0.0000") + vbCrLf)

            Dim X1 = Math.Sqrt((Q * Q) - (Y1 * Y1))

            'TB.AppendText("X1= " + X1.ToString("###0.0000") + vbCrLf)

            Dim M0 = Y0 - Z
            'TB.AppendText("M0= " + M0.ToString("###0.0000") + vbCrLf)

            Dim M1 = Y1 - Z

            'TB.AppendText("M1= " + M1.ToString("###0.0000") + vbCrLf)

            Dim Alfa = Math.Atan((M0 - M1) / (X0 + X1))

            'TB.AppendText("alfa= " + Alfa.ToString("###0.0000") + vbCrLf)
            Dim C = (X1 + X0) / Math.Cos(Alfa)

            'TB.AppendText("c= " + C.ToString("###0.0000") + vbCrLf)

            AlfaS0S1Refline = Alfa
            RefHeightFromS1 = M1
            Dist_C = C
        End If

        Return True
    End Function


    Public Function CalcDistFromTriangle(ByVal BarRad As Double, ByVal aMeasureMentsSens0 As Double, ByVal aMeasureMentsSens1 As Double, ByRef aMeasureMentsResult As Double, ByVal Dist_M As Double, ByVal Dist_S As Double, ByVal AlfaS0S1Refline As Double, ByVal aloglevel As Integer) As Boolean
        Dim A As Double = aMeasureMentsSens0 + BarRad
        Dim B As Double = aMeasureMentsSens1 + BarRad
        Dim C As Double = Dist_S            'distance from sensor 0 to sensor1 , must be greater then zero, to calculate E
        Dim M As Double = Dist_M            'distance from sensor 1 to the Reference Line
        Dim Alfa As Double = AlfaS0S1Refline     'angle of the line through sensor 0 and sensor 1 to the reference line 

        Dim E As Double = 0

        If (aMeasureMentsSens0 = -1) Or (aMeasureMentsSens1 = -1) Then

            aMeasureMentsResult = -1
        Else
            If (C > 0) Then
                E = ((B * B) - (A * A) + (C * C)) / (2 * C)
            Else
                E = 0
            End If


            Dim D As Double = Math.Sqrt((B * B) - (E * E))


            Dim F As Double = D * Math.Cos(Alfa)

            Dim G As Double = E * Math.Sin(Alfa)


            Dim H As Double = F - G - M

            aMeasureMentsResult = H - BarRad
        End If

        Return True
    End Function


End Class
