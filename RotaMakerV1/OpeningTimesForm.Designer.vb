<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpeningTimesForm
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
        Me.MondayBUTT = New System.Windows.Forms.Button()
        Me.TuesdayBUTT = New System.Windows.Forms.Button()
        Me.WednesdayButt = New System.Windows.Forms.Button()
        Me.FridayButt = New System.Windows.Forms.Button()
        Me.SaturdayButt = New System.Windows.Forms.Button()
        Me.SundayButt = New System.Windows.Forms.Button()
        Me.ThursdayBUTT = New System.Windows.Forms.Button()
        Me.SaveAndExitButt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MondayBUTT
        '
        Me.MondayBUTT.Location = New System.Drawing.Point(13, 13)
        Me.MondayBUTT.Name = "MondayBUTT"
        Me.MondayBUTT.Size = New System.Drawing.Size(300, 300)
        Me.MondayBUTT.TabIndex = 0
        Me.MondayBUTT.Text = "Monday"
        Me.MondayBUTT.UseVisualStyleBackColor = True
        '
        'TuesdayBUTT
        '
        Me.TuesdayBUTT.Location = New System.Drawing.Point(319, 13)
        Me.TuesdayBUTT.Name = "TuesdayBUTT"
        Me.TuesdayBUTT.Size = New System.Drawing.Size(300, 300)
        Me.TuesdayBUTT.TabIndex = 1
        Me.TuesdayBUTT.Text = "Tuesday"
        Me.TuesdayBUTT.UseVisualStyleBackColor = True
        '
        'WednesdayButt
        '
        Me.WednesdayButt.Location = New System.Drawing.Point(625, 13)
        Me.WednesdayButt.Name = "WednesdayButt"
        Me.WednesdayButt.Size = New System.Drawing.Size(300, 300)
        Me.WednesdayButt.TabIndex = 2
        Me.WednesdayButt.Text = "Wednesday"
        Me.WednesdayButt.UseVisualStyleBackColor = True
        '
        'FridayButt
        '
        Me.FridayButt.Location = New System.Drawing.Point(13, 319)
        Me.FridayButt.Name = "FridayButt"
        Me.FridayButt.Size = New System.Drawing.Size(300, 300)
        Me.FridayButt.TabIndex = 3
        Me.FridayButt.Text = "Friday"
        Me.FridayButt.UseVisualStyleBackColor = True
        '
        'SaturdayButt
        '
        Me.SaturdayButt.Location = New System.Drawing.Point(319, 319)
        Me.SaturdayButt.Name = "SaturdayButt"
        Me.SaturdayButt.Size = New System.Drawing.Size(300, 300)
        Me.SaturdayButt.TabIndex = 4
        Me.SaturdayButt.Text = "Saturday"
        Me.SaturdayButt.UseVisualStyleBackColor = True
        '
        'SundayButt
        '
        Me.SundayButt.Location = New System.Drawing.Point(625, 319)
        Me.SundayButt.Name = "SundayButt"
        Me.SundayButt.Size = New System.Drawing.Size(300, 300)
        Me.SundayButt.TabIndex = 5
        Me.SundayButt.Text = "Sunday"
        Me.SundayButt.UseVisualStyleBackColor = True
        '
        'ThursdayBUTT
        '
        Me.ThursdayBUTT.Location = New System.Drawing.Point(931, 13)
        Me.ThursdayBUTT.Name = "ThursdayBUTT"
        Me.ThursdayBUTT.Size = New System.Drawing.Size(300, 300)
        Me.ThursdayBUTT.TabIndex = 6
        Me.ThursdayBUTT.Text = "Thursday"
        Me.ThursdayBUTT.UseVisualStyleBackColor = True
        '
        'SaveAndExitButt
        '
        Me.SaveAndExitButt.Location = New System.Drawing.Point(931, 319)
        Me.SaveAndExitButt.Name = "SaveAndExitButt"
        Me.SaveAndExitButt.Size = New System.Drawing.Size(300, 300)
        Me.SaveAndExitButt.TabIndex = 7
        Me.SaveAndExitButt.Text = "Save and Exit"
        Me.SaveAndExitButt.UseVisualStyleBackColor = True
        '
        'OpeningTimesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 638)
        Me.Controls.Add(Me.SaveAndExitButt)
        Me.Controls.Add(Me.ThursdayBUTT)
        Me.Controls.Add(Me.SundayButt)
        Me.Controls.Add(Me.SaturdayButt)
        Me.Controls.Add(Me.FridayButt)
        Me.Controls.Add(Me.WednesdayButt)
        Me.Controls.Add(Me.TuesdayBUTT)
        Me.Controls.Add(Me.MondayBUTT)
        Me.Name = "OpeningTimesForm"
        Me.ShowIcon = False
        Me.Text = "OpeningTimesForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MondayBUTT As System.Windows.Forms.Button
    Friend WithEvents TuesdayBUTT As System.Windows.Forms.Button
    Friend WithEvents WednesdayButt As System.Windows.Forms.Button
    Friend WithEvents FridayButt As System.Windows.Forms.Button
    Friend WithEvents SaturdayButt As System.Windows.Forms.Button
    Friend WithEvents SundayButt As System.Windows.Forms.Button
    Friend WithEvents ThursdayBUTT As System.Windows.Forms.Button
    Friend WithEvents SaveAndExitButt As System.Windows.Forms.Button
End Class
