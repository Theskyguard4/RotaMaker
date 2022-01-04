Public Class AddEmployeeForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If IsNumeric(Me.HourlyPay_TB.Text) = True Then
            Try
                Form1.AllEmployees(Form1.EmployeeCount).AddEmployee(Me.Name_TB.Text, Me.ID_TB.Text, Me.HoursPerWeekMin_TB.Value, Me.OvertimeCheckBox.Checked, CDec(Me.HourlyPay_TB.Text), Me.JobTitle_TB.Text)
                Form1.UpdateList()
                Form1.EmployeeCount += 1
                PickEditMode.Close()
                Me.Close()

            Catch ex As Exception

                MsgBox("Error: Invalid Input")
            End Try
            

        Else
            MsgBox("Error: Invalid Hourly Input")
        End If
        

    End Sub
End Class