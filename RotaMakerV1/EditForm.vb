Public Class EditForm

    Private Sub AddUnavalibleDateBUTT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUnavalibleDateBUTT.Click
        Dim selectedDate As Date = Me.MonthCalendar1.SelectionRange.Start
        Dim isokay As Boolean = False
        For Each Dates In Me.MonthCalendar1.BoldedDates
            If Dates = selectedDate Then
                isokay = True
            End If
        Next
        If isokay = True Then
            Me.MonthCalendar1.RemoveBoldedDate(selectedDate)
            Me.MonthCalendar1.UpdateBoldedDates()
        Else
            Me.MonthCalendar1.AddBoldedDate(selectedDate)
            Me.MonthCalendar1.UpdateBoldedDates()
        End If
    End Sub
End Class