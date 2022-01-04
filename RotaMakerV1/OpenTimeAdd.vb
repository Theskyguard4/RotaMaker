Public Class OpenTimeAdd

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.StartTimeTB.Text <> "" And Me.EndTimeTB.Text <> "" And IsNumeric(Me.StartTimeTB.Text(0)) = True And IsNumeric(Me.EndTimeTB.Text(0)) = True And InStr(Me.StartTimeTB.Text, ":") > 0 And InStr(Me.EndTimeTB.Text, ":") > 0 And Int(NumberOfShiftsTB.Text) < 10 And NumberOfShiftsTB.Text <> "" And IsNumeric(NumberOfShiftsTB.Text) = True Then
            Select Case Me.Text
                Case "Monday"
                    Form1.OpenTimes(0).OpenTime = StartTimeTB.Text
                    Form1.OpenTimes(0).closeTime = EndTimeTB.Text
                Case "Tuesday"
                    Form1.OpenTimes(1).OpenTime = StartTimeTB.Text
                    Form1.OpenTimes(1).closeTime = EndTimeTB.Text
                Case "Wednesday"
                    Form1.OpenTimes(2).OpenTime = StartTimeTB.Text
                    Form1.OpenTimes(2).closeTime = EndTimeTB.Text
                Case "Thursday"
                    Form1.OpenTimes(3).OpenTime = StartTimeTB.Text
                    Form1.OpenTimes(3).closeTime = EndTimeTB.Text
                Case "Friday"
                    Form1.OpenTimes(4).OpenTime = StartTimeTB.Text
                    Form1.OpenTimes(4).closeTime = EndTimeTB.Text
                Case "Saturday"
                    Form1.OpenTimes(5).OpenTime = StartTimeTB.Text
                    Form1.OpenTimes(5).closeTime = EndTimeTB.Text
                Case "Sunday"
                    Form1.OpenTimes(6).OpenTime = StartTimeTB.Text
                    Form1.OpenTimes(6).closeTime = EndTimeTB.Text
            End Select
            For II = 0 To Form1.OpenTimes.Length - 1
                If Form1.OpenTimes(II).OpenTime <> "" Then
                    Select Case II
                        Case 0
                            OpeningTimesForm.MondayBUTT.Text = "Monday" & vbCrLf & Form1.OpenTimes(II).OpenTime & " To " & Form1.OpenTimes(II).closeTime & vbCrLf & Form1.OpenTimes(II).OpenTime & " Shifts"
                        Case 1
                            OpeningTimesForm.TuesdayBUTT.Text = "Tuesday" & vbCrLf & Form1.OpenTimes(II).OpenTime & " To " & Form1.OpenTimes(II).closeTime & vbCrLf & Form1.OpenTimes(II).OpenTime & " Shifts"
                        Case 2
                            OpeningTimesForm.WednesdayButt.Text = "Wednesday" & vbCrLf & Form1.OpenTimes(II).OpenTime & " To " & Form1.OpenTimes(II).closeTime & vbCrLf & Form1.OpenTimes(II).OpenTime & " Shifts"
                        Case 3
                            OpeningTimesForm.ThursdayBUTT.Text = "Thursday" & vbCrLf & Form1.OpenTimes(II).OpenTime & " To " & Form1.OpenTimes(II).closeTime & vbCrLf & Form1.OpenTimes(II).OpenTime & " Shifts"
                        Case 4
                            OpeningTimesForm.FridayButt.Text = "Friday" & vbCrLf & Form1.OpenTimes(II).OpenTime & " To " & Form1.OpenTimes(II).closeTime & vbCrLf & Form1.OpenTimes(II).OpenTime & " Shifts"
                        Case 5
                            OpeningTimesForm.SaturdayButt.Text = "Saturday" & vbCrLf & Form1.OpenTimes(II).OpenTime & " To " & Form1.OpenTimes(II).closeTime & vbCrLf & Form1.OpenTimes(II).OpenTime & " Shifts"
                        Case 6
                            OpeningTimesForm.SundayButt.Text = "Sunday" & vbCrLf & Form1.OpenTimes(II).OpenTime & " To " & Form1.OpenTimes(II).closeTime & vbCrLf & Form1.OpenTimes(II).OpenTime & " Shifts"
                    End Select
                End If
            Next
            Me.Close()
        Else
            MsgBox("Please Enter Times in A 24H Clock Format such as (8:00 or 16:00)")
        End If

        
    End Sub
End Class