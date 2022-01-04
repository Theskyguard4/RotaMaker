Public Class Hour
    Protected Open As Boolean
    Protected WorkerId As String
    Protected Job As String
    Protected HourIndex As Integer
    Protected DayIndex As Integer
    Public Sub New(ByVal OpenH As Form1.OpeningTimes, ByVal H As Integer, ByVal D As Integer)
        Me.HourIndex = H
        Me.DayIndex = D
        Dim opening As Integer = Int(OpenH.OpenTime.Split(":")(0))
        Dim close As Integer = Int(OpenH.closeTime.Split(":")(0))
        If Me.HourIndex > opening And Me.HourIndex < close Then
            Me.Open = True
        Else
            Me.Open = False
        End If
    End Sub
    Public Sub CreateHour(ByVal Hour_Index As Integer, ByVal Day_Index As Integer, ByVal Open_Bool As Boolean, ByVal WorkerId_Str As String, ByVal Job_Str As String)
        Me.Open = Open_Bool
        Me.WorkerId = WorkerId_Str
        Me.Job = Job_Str
        Me.HourIndex = Hour_Index
        Me.DayIndex = Day_Index
    End Sub
End Class
