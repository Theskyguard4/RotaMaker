<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenTimeAdd
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StartTimeTB = New System.Windows.Forms.TextBox()
        Me.EndTimeTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumberOfShiftsTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(258, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Save and Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StartTimeTB
        '
        Me.StartTimeTB.Location = New System.Drawing.Point(12, 60)
        Me.StartTimeTB.Name = "StartTimeTB"
        Me.StartTimeTB.Size = New System.Drawing.Size(100, 22)
        Me.StartTimeTB.TabIndex = 1
        '
        'EndTimeTB
        '
        Me.EndTimeTB.Location = New System.Drawing.Point(170, 60)
        Me.EndTimeTB.Name = "EndTimeTB"
        Me.EndTimeTB.Size = New System.Drawing.Size(100, 22)
        Me.EndTimeTB.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter Opening/Closing Times"
        '
        'NumberOfShiftsTB
        '
        Me.NumberOfShiftsTB.Location = New System.Drawing.Point(130, 88)
        Me.NumberOfShiftsTB.Name = "NumberOfShiftsTB"
        Me.NumberOfShiftsTB.Size = New System.Drawing.Size(140, 22)
        Me.NumberOfShiftsTB.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Number Of Shifts"
        '
        'OpenTimeAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 188)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NumberOfShiftsTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EndTimeTB)
        Me.Controls.Add(Me.StartTimeTB)
        Me.Controls.Add(Me.Button1)
        Me.Name = "OpenTimeAdd"
        Me.ShowIcon = False
        Me.Text = "OpenTimeAdd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents StartTimeTB As System.Windows.Forms.TextBox
    Friend WithEvents EndTimeTB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumberOfShiftsTB As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
