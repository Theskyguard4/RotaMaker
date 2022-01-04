<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEmployeeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.AddUnavalibleDateBUTT = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.MondayTimeBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OvertimeCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HoursPerWeekMin_TB = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ID_TB = New System.Windows.Forms.TextBox()
        Me.JobTitle_TB = New System.Windows.Forms.TextBox()
        Me.Name_TB = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.HourlyPay_TB = New System.Windows.Forms.TextBox()
        CType(Me.HoursPerWeekMin_TB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(540, 346)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(115, 17)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Unavalible Dates"
        '
        'AddUnavalibleDateBUTT
        '
        Me.AddUnavalibleDateBUTT.Location = New System.Drawing.Point(540, 594)
        Me.AddUnavalibleDateBUTT.Name = "AddUnavalibleDateBUTT"
        Me.AddUnavalibleDateBUTT.Size = New System.Drawing.Size(304, 33)
        Me.AddUnavalibleDateBUTT.TabIndex = 59
        Me.AddUnavalibleDateBUTT.Text = "Add/Remove Unavalible Dates"
        Me.AddUnavalibleDateBUTT.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(540, 375)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 58
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(639, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 17)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Avalible Times"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(580, 286)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 17)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Sunday"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(571, 256)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 17)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Saturday"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(589, 226)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 17)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Friday"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(553, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 17)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Wednesday"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(568, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 17)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Thursday"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(573, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 17)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Tuesday"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(578, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 17)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Monday"
        '
        'ComboBox7
        '
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Items.AddRange(New Object() {"All Day 6:00AM - 10:00PM", "Early 6:00AM - 2:00PM", "Late 2:00AM - 10:00PM", "Other (Limited Hours)"})
        Me.ComboBox7.Location = New System.Drawing.Point(642, 286)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(197, 24)
        Me.ComboBox7.TabIndex = 49
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"All Day 6:00AM - 10:00PM", "Early 6:00AM - 2:00PM", "Late 2:00AM - 10:00PM", "Other (Limited Hours)"})
        Me.ComboBox6.Location = New System.Drawing.Point(642, 256)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(197, 24)
        Me.ComboBox6.TabIndex = 48
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"All Day 6:00AM - 10:00PM", "Early 6:00AM - 2:00PM", "Late 2:00AM - 10:00PM", "Other (Limited Hours)"})
        Me.ComboBox5.Location = New System.Drawing.Point(642, 226)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(197, 24)
        Me.ComboBox5.TabIndex = 47
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"All Day 6:00AM - 10:00PM", "Early 6:00AM - 2:00PM", "Late 2:00AM - 10:00PM", "Other (Limited Hours)"})
        Me.ComboBox4.Location = New System.Drawing.Point(642, 193)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(197, 24)
        Me.ComboBox4.TabIndex = 46
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"All Day 6:00AM - 10:00PM", "Early 6:00AM - 2:00PM", "Late 2:00AM - 10:00PM", "Other (Limited Hours)"})
        Me.ComboBox3.Location = New System.Drawing.Point(642, 163)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(197, 24)
        Me.ComboBox3.TabIndex = 45
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"All Day 6:00AM - 10:00PM", "Early 6:00AM - 2:00PM", "Late 2:00AM - 10:00PM", "Other (Limited Hours)"})
        Me.ComboBox2.Location = New System.Drawing.Point(642, 133)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(197, 24)
        Me.ComboBox2.TabIndex = 44
        '
        'MondayTimeBox
        '
        Me.MondayTimeBox.FormattingEnabled = True
        Me.MondayTimeBox.Items.AddRange(New Object() {"All Day 6:00AM - 10:00PM", "Early 6:00AM - 2:00PM", "Late 2:00AM - 10:00PM", "Other (Limited Hours)"})
        Me.MondayTimeBox.Location = New System.Drawing.Point(642, 103)
        Me.MondayTimeBox.Name = "MondayTimeBox"
        Me.MondayTimeBox.Size = New System.Drawing.Size(197, 24)
        Me.MondayTimeBox.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 17)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Can Cover Shifts?"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(179, 224)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(18, 17)
        Me.CheckBox1.TabIndex = 41
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 17)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Can Work Over Time?"
        '
        'OvertimeCheckBox
        '
        Me.OvertimeCheckBox.AutoSize = True
        Me.OvertimeCheckBox.Location = New System.Drawing.Point(179, 201)
        Me.OvertimeCheckBox.Name = "OvertimeCheckBox"
        Me.OvertimeCheckBox.Size = New System.Drawing.Size(18, 17)
        Me.OvertimeCheckBox.TabIndex = 39
        Me.OvertimeCheckBox.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 17)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Minimum Hours Per Week"
        '
        'HoursPerWeekMin_TB
        '
        Me.HoursPerWeekMin_TB.Location = New System.Drawing.Point(169, 162)
        Me.HoursPerWeekMin_TB.Name = "HoursPerWeekMin_TB"
        Me.HoursPerWeekMin_TB.Size = New System.Drawing.Size(238, 56)
        Me.HoursPerWeekMin_TB.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(100, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Id Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Job Title"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(128, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Name"
        '
        'ID_TB
        '
        Me.ID_TB.Location = New System.Drawing.Point(179, 134)
        Me.ID_TB.Name = "ID_TB"
        Me.ID_TB.Size = New System.Drawing.Size(238, 22)
        Me.ID_TB.TabIndex = 33
        '
        'JobTitle_TB
        '
        Me.JobTitle_TB.Location = New System.Drawing.Point(179, 106)
        Me.JobTitle_TB.Name = "JobTitle_TB"
        Me.JobTitle_TB.Size = New System.Drawing.Size(238, 22)
        Me.JobTitle_TB.TabIndex = 32
        '
        'Name_TB
        '
        Me.Name_TB.Location = New System.Drawing.Point(179, 78)
        Me.Name_TB.Name = "Name_TB"
        Me.Name_TB.Size = New System.Drawing.Size(238, 22)
        Me.Name_TB.TabIndex = 31
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(13, 13)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 17)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "Add Employee"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 594)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(486, 33)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Add To Employee List"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(96, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 17)
        Me.Label17.TabIndex = 64
        Me.Label17.Text = "Hourly Pay"
        '
        'HourlyPay_TB
        '
        Me.HourlyPay_TB.Location = New System.Drawing.Point(179, 50)
        Me.HourlyPay_TB.Name = "HourlyPay_TB"
        Me.HourlyPay_TB.Size = New System.Drawing.Size(238, 22)
        Me.HourlyPay_TB.TabIndex = 63
        '
        'AddEmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 642)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.HourlyPay_TB)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.AddUnavalibleDateBUTT)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.MondayTimeBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.OvertimeCheckBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.HoursPerWeekMin_TB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ID_TB)
        Me.Controls.Add(Me.JobTitle_TB)
        Me.Controls.Add(Me.Name_TB)
        Me.Name = "AddEmployeeForm"
        Me.Text = "AddEmployeeForm"
        CType(Me.HoursPerWeekMin_TB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents AddUnavalibleDateBUTT As System.Windows.Forms.Button
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents MondayTimeBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OvertimeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents HoursPerWeekMin_TB As System.Windows.Forms.TrackBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ID_TB As System.Windows.Forms.TextBox
    Friend WithEvents JobTitle_TB As System.Windows.Forms.TextBox
    Friend WithEvents Name_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents HourlyPay_TB As System.Windows.Forms.TextBox
End Class
