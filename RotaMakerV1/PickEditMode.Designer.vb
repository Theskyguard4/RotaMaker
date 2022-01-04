<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PickEditMode
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
        Me.EditButt = New System.Windows.Forms.Button()
        Me.AddButt = New System.Windows.Forms.Button()
        Me.DeleteButt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EditButt
        '
        Me.EditButt.Location = New System.Drawing.Point(13, 13)
        Me.EditButt.Name = "EditButt"
        Me.EditButt.Size = New System.Drawing.Size(320, 469)
        Me.EditButt.TabIndex = 0
        Me.EditButt.Text = "Edit"
        Me.EditButt.UseVisualStyleBackColor = True
        '
        'AddButt
        '
        Me.AddButt.Location = New System.Drawing.Point(334, 13)
        Me.AddButt.Name = "AddButt"
        Me.AddButt.Size = New System.Drawing.Size(320, 469)
        Me.AddButt.TabIndex = 1
        Me.AddButt.Text = "Add"
        Me.AddButt.UseVisualStyleBackColor = True
        '
        'DeleteButt
        '
        Me.DeleteButt.Location = New System.Drawing.Point(656, 13)
        Me.DeleteButt.Name = "DeleteButt"
        Me.DeleteButt.Size = New System.Drawing.Size(320, 469)
        Me.DeleteButt.TabIndex = 2
        Me.DeleteButt.Text = "Delete"
        Me.DeleteButt.UseVisualStyleBackColor = True
        '
        'PickEditMode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 494)
        Me.Controls.Add(Me.DeleteButt)
        Me.Controls.Add(Me.AddButt)
        Me.Controls.Add(Me.EditButt)
        Me.Name = "PickEditMode"
        Me.Text = "PickEditMode"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EditButt As System.Windows.Forms.Button
    Friend WithEvents AddButt As System.Windows.Forms.Button
    Friend WithEvents DeleteButt As System.Windows.Forms.Button
End Class
