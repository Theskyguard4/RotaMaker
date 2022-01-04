Public Class PickEditMode

    Private Sub EditButt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButt.Click
        EditForm.Show()
    End Sub

    Private Sub AddButt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButt.Click
        AddEmployeeForm.Show()
    End Sub
End Class