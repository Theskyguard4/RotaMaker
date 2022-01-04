Public Class OpeningTimesForm

    Private Sub MondayBUTT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MondayBUTT.Click
        OpenTimeAdd.Show()
        OpenTimeAdd.Text = "Monday"
    End Sub

    Private Sub TuesdayBUTT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TuesdayBUTT.Click
        OpenTimeAdd.Show()
        OpenTimeAdd.Text = "Tuesday"
    End Sub

    Private Sub WednesdayButt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WednesdayButt.Click
        OpenTimeAdd.Show()
        OpenTimeAdd.Text = "Wednesday"
    End Sub

    Private Sub ThursdayBUTT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThursdayBUTT.Click
        OpenTimeAdd.Show()
        OpenTimeAdd.Text = "Thursday"
    End Sub

    Private Sub FridayButt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FridayButt.Click
        OpenTimeAdd.Show()
        OpenTimeAdd.Text = "Friday"
    End Sub

    Private Sub SaturdayButt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaturdayButt.Click
        OpenTimeAdd.Show()
        OpenTimeAdd.Text = "Saturday"
    End Sub

    Private Sub SundayButt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SundayButt.Click
        OpenTimeAdd.Show()
        OpenTimeAdd.Text = "Sunday"
    End Sub

    Private Sub SaveAndExitButt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAndExitButt.Click
        
        Me.Close()
    End Sub

    Private Sub OpeningTimesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For II = 0 To Form1.OpenTimes.Length - 1
            If Form1.OpenTimes(II).OpenTime <> "" Then
                Select Case II
                    Case 0
                        MondayBUTT.Text = "Monday" & vbCrLf & Form1.OpenTimes(II).OpenTime & " To " & Form1.OpenTimes(II).closeTime
                    Case 1
                        TuesdayBUTT.Text = "Tuesday" & vbCrLf & Form1.OpenTimes(II).OpenTime & " To " & Form1.OpenTimes(II).closeTime
                    Case 2
                        WednesdayButt.Text = "Wednesday" & vbCrLf & Form1.OpenTimes(II).OpenTime & " To " & Form1.OpenTimes(II).closeTime
                    Case 3
                        ThursdayBUTT.Text = "Thursday" & vbCrLf & Form1.OpenTimes(II).OpenTime & " To " & Form1.OpenTimes(II).closeTime
                    Case 4
                        FridayButt.Text = "Friday" & vbCrLf & Form1.OpenTimes(II).OpenTime & " To " & Form1.OpenTimes(II).closeTime
                    Case 5
                        SaturdayButt.Text = "Saturday" & vbCrLf & Form1.OpenTimes(II).OpenTime & " To " & Form1.OpenTimes(II).closeTime
                    Case 6
                        SundayButt.Text = "Sunday" & vbCrLf & Form1.OpenTimes(II).OpenTime & " To " & Form1.OpenTimes(II).closeTime
                End Select
            End If

        Next
    End Sub
End Class