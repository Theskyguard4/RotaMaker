Public Class Employee
    Protected Name As String
    Protected ID As String
    Protected HoursPerWeek As Integer
    Protected OverTimeCount As Integer
    Protected OverTimeBool As Boolean
    Protected HourlyPay As Decimal
    Protected JobTitle As String
    Protected PowerLevel As Integer
    Protected UnavalibleDays As List(Of Date)
    Public Sub New()
        UnavalibleDays = New List(Of Date)
    End Sub

    Public Sub AddEmployee(ByVal The_Name As String, ByVal The_ID As String, ByVal The_HPW As Integer, ByVal Do_Overtime As Boolean, ByVal The_HourPay As Decimal, ByVal The_JobTitle As String)
        Me.Name = The_Name
        Me.ID = The_ID
        Me.HoursPerWeek = The_HPW
        Me.OverTimeBool = Do_Overtime
        Me.HourlyPay = The_HourPay
        Me.JobTitle = The_JobTitle
    End Sub

    Public Function EmployeeName()
        Return Me.Name
    End Function
    Public Sub EmployeeName(ByVal NameStr As String)
        Me.Name = NameStr
    End Sub

    Public Function EmployeeID()
        Return Me.ID
    End Function
    Public Sub EmployeeID(ByVal IDStr As String)
        Me.ID = IDStr
    End Sub

    Public Function EmployeeHoursPerWeek()
        Return Me.HoursPerWeek
    End Function
    Public Sub EmployeeHoursPerWeek(ByVal HPWStr As String)
        Me.HoursPerWeek = HPWStr
    End Sub

    Public Function EmployeeOverTimeBool()
        Return Me.OverTimeBool
    End Function
    Public Sub EmployeeOverTimeBool(ByVal OverTimeBoolean As Boolean)
        Me.OverTimeBool = OverTimeBoolean
    End Sub

    Public Function EmployeeOverTimeCount()
        Return Me.OverTimeCount
    End Function
    Public Sub EmployeeOverTimeCount(ByVal OverTimerCounter As Integer)
        Me.OverTimeCount = OverTimerCounter
    End Sub

    Public Function EmployeeHourlyPay()
        Return Me.HourlyPay
    End Function
    Public Sub EmployeeHourlyPay(ByVal HourlyPayInt)
        Me.HourlyPay = HourlyPayInt
    End Sub

    Public Function EmployeeJobTitle()
        Return Me.JobTitle
    End Function
    Public Sub EmployeeJobTitle(ByVal JobTitleStr As String)
        Me.JobTitle = JobTitleStr
    End Sub

    Public Function EmployeePowerLevel()
        Return Me.PowerLevel
    End Function
    Public Sub EmployeePowerLevel(ByVal PowerLevelInt As Integer)
        Me.PowerLevel = PowerLevelInt
    End Sub
End Class
