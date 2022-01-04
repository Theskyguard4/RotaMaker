<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.RotaGrid = New System.Windows.Forms.DataGridView()
        Me.EditEmployeesBUTT = New System.Windows.Forms.Button()
        Me.CreateNewRotaBUTT = New System.Windows.Forms.Button()
        Me.EmployeeListSelecter = New System.Windows.Forms.ComboBox()
        Me.AddShiftTimesButt = New System.Windows.Forms.Button()
        CType(Me.RotaGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RotaGrid
        '
        Me.RotaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RotaGrid.Location = New System.Drawing.Point(12, 184)
        Me.RotaGrid.Name = "RotaGrid"
        Me.RotaGrid.RowTemplate.Height = 24
        Me.RotaGrid.Size = New System.Drawing.Size(1245, 521)
        Me.RotaGrid.TabIndex = 0
        '
        'EditEmployeesBUTT
        '
        Me.EditEmployeesBUTT.Location = New System.Drawing.Point(12, 71)
        Me.EditEmployeesBUTT.Name = "EditEmployeesBUTT"
        Me.EditEmployeesBUTT.Size = New System.Drawing.Size(172, 107)
        Me.EditEmployeesBUTT.TabIndex = 1
        Me.EditEmployeesBUTT.Text = "Edit Employee List"
        Me.EditEmployeesBUTT.UseVisualStyleBackColor = True
        '
        'CreateNewRotaBUTT
        '
        Me.CreateNewRotaBUTT.Location = New System.Drawing.Point(190, 71)
        Me.CreateNewRotaBUTT.Name = "CreateNewRotaBUTT"
        Me.CreateNewRotaBUTT.Size = New System.Drawing.Size(172, 107)
        Me.CreateNewRotaBUTT.TabIndex = 2
        Me.CreateNewRotaBUTT.Text = "Create New Rota"
        Me.CreateNewRotaBUTT.UseVisualStyleBackColor = True
        '
        'EmployeeListSelecter
        '
        Me.EmployeeListSelecter.FormattingEnabled = True
        Me.EmployeeListSelecter.Location = New System.Drawing.Point(669, 143)
        Me.EmployeeListSelecter.Name = "EmployeeListSelecter"
        Me.EmployeeListSelecter.Size = New System.Drawing.Size(588, 24)
        Me.EmployeeListSelecter.TabIndex = 3
        '
        'AddShiftTimesButt
        '
        Me.AddShiftTimesButt.Location = New System.Drawing.Point(368, 71)
        Me.AddShiftTimesButt.Name = "AddShiftTimesButt"
        Me.AddShiftTimesButt.Size = New System.Drawing.Size(172, 107)
        Me.AddShiftTimesButt.TabIndex = 4
        Me.AddShiftTimesButt.Text = "Add Opening/Shift Times"
        Me.AddShiftTimesButt.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 717)
        Me.Controls.Add(Me.AddShiftTimesButt)
        Me.Controls.Add(Me.EmployeeListSelecter)
        Me.Controls.Add(Me.CreateNewRotaBUTT)
        Me.Controls.Add(Me.EditEmployeesBUTT)
        Me.Controls.Add(Me.RotaGrid)
        Me.Name = "Form1"
        Me.Text = "RotaMakerV1"
        CType(Me.RotaGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RotaGrid As System.Windows.Forms.DataGridView
    Friend WithEvents EditEmployeesBUTT As System.Windows.Forms.Button
    Friend WithEvents CreateNewRotaBUTT As System.Windows.Forms.Button
    Friend WithEvents EmployeeListSelecter As System.Windows.Forms.ComboBox
    Friend WithEvents AddShiftTimesButt As System.Windows.Forms.Button

End Class
