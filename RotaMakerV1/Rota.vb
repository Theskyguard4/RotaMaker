Public Class Rota
    Protected Hours(6, 23) As Hour
    Public Sub New()

    End Sub
    Public Sub CreateRota(ByVal Employees() As Employee, ByVal Open_Hours() As Form1.OpeningTimes)
        For D = 0 To 6
            For H = 0 To 23
                Me.Hours(D, H) = New Hour(Open_Hours(D), H, D)
            Next
        Next
       
    End Sub
    
End Class
