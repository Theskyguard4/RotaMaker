Public Class Form1
    Public Structure OpeningTimes
        Dim OpenTime As String
        Dim closeTime As String
        Dim shifts As Integer
    End Structure
    Public AllEmployees(50) As Employee
    Public AllemployeeName(50) As String
    Public EmployeeCount As Integer = 0
    Public OpenTimes(6) As OpeningTimes
    Public CurrentRota As Rota
    Public RotaCreated As Boolean = False


    Dim RandomName() As String = {"joe", "lewis", "jason", "olly", "Andrew", "jake", "Mia", "DM"}

    Private Sub EditEmployeesBUTT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditEmployeesBUTT.Click
        PickEditMode.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For II = 0 To AllEmployees.Length - 1
            AllEmployees(II) = New Employee
            If II < RandomName.Count Then
                AllemployeeName(II) = RandomName(II)
            Else
                AllemployeeName(II) = ""
            End If

        Next
        EmployeeCount = 8
        Me.EmployeeListSelecter.Items.AddRange(AllemployeeName)
        For II = 0 To OpenTimes.Length - 1
            OpenTimes(II).closeTime = "15:00"
            OpenTimes(II).OpenTime = "5:00"
            OpenTimes(II).shifts = 1
        Next


    End Sub

    Public Sub UpdateList()
        AllemployeeName(EmployeeCount) = AllEmployees(EmployeeCount).EmployeeName
        Me.EmployeeListSelecter.Items.Clear()
        Me.EmployeeListSelecter.Items.AddRange(AllemployeeName)
    End Sub

    Private Sub CreateNewRotaBUTT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNewRotaBUTT.Click
        If Me.RotaCreated = False Then
            Me.CurrentRota = New Rota
        End If
        DisplayRota(CurrentRota)
        Me.RotaCreated = True
        Me.CreateRota(CurrentRota)
    End Sub

    Private Sub AddShiftTimesButt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddShiftTimesButt.Click
        OpeningTimesForm.Show()
    End Sub

    Private Sub CreateRota(ByVal The_Rota As Rota)
        CurrentRota.CreateRota(AllEmployees, OpenTimes)
    End Sub
    Private Sub DisplayRota(ByVal The_Rota As Rota)
        RotaGrid.Columns.Clear()
        RotaGrid.Rows.Clear()
        RotaGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        RotaGrid.Columns.Add("Date", "Date")
        RotaGrid.Columns.Add("DoW", "Day")
        RotaGrid.Columns.Add("OpenBool", "Open?")
        For Each Emp In AllemployeeName
            RotaGrid.Columns.Add(Emp, Emp)
        Next

        Dim day As Integer = 1
        For II = 1 To Date.DaysInMonth(Date.Today.Year, Date.Today.Month)

            RotaGrid.Rows.Add(II, DateAndTime.WeekdayName(day, True))
            day += 1
            If day = 8 Then
                day = 1
            End If
        Next

    End Sub
End Class
