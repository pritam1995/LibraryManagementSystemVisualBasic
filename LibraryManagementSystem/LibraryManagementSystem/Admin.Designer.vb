<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.btviewBooks = New System.Windows.Forms.Button()
        Me.btviewUser = New System.Windows.Forms.Button()
        Me.btRemoveBooks = New System.Windows.Forms.Button()
        Me.btAddBooks = New System.Windows.Forms.Button()
        Me.btRemoveUser = New System.Windows.Forms.Button()
        Me.btLogOut = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btviewBooks
        '
        Me.btviewBooks.Location = New System.Drawing.Point(528, 291)
        Me.btviewBooks.Name = "btviewBooks"
        Me.btviewBooks.Size = New System.Drawing.Size(45, 64)
        Me.btviewBooks.TabIndex = 11
        Me.btviewBooks.Text = "View All Books"
        Me.btviewBooks.UseVisualStyleBackColor = True
        '
        'btviewUser
        '
        Me.btviewUser.Location = New System.Drawing.Point(148, 291)
        Me.btviewUser.Name = "btviewUser"
        Me.btviewUser.Size = New System.Drawing.Size(75, 23)
        Me.btviewUser.TabIndex = 10
        Me.btviewUser.Text = "View Info"
        Me.btviewUser.UseVisualStyleBackColor = True
        '
        'btRemoveBooks
        '
        Me.btRemoveBooks.Location = New System.Drawing.Point(264, 238)
        Me.btRemoveBooks.Name = "btRemoveBooks"
        Me.btRemoveBooks.Size = New System.Drawing.Size(186, 23)
        Me.btRemoveBooks.TabIndex = 9
        Me.btRemoveBooks.Text = "Remove Books"
        Me.btRemoveBooks.UseVisualStyleBackColor = True
        '
        'btAddBooks
        '
        Me.btAddBooks.Location = New System.Drawing.Point(264, 199)
        Me.btAddBooks.Name = "btAddBooks"
        Me.btAddBooks.Size = New System.Drawing.Size(186, 23)
        Me.btAddBooks.TabIndex = 8
        Me.btAddBooks.Text = "Add Books"
        Me.btAddBooks.UseVisualStyleBackColor = True
        '
        'btRemoveUser
        '
        Me.btRemoveUser.Location = New System.Drawing.Point(264, 161)
        Me.btRemoveUser.Name = "btRemoveUser"
        Me.btRemoveUser.Size = New System.Drawing.Size(186, 23)
        Me.btRemoveUser.TabIndex = 7
        Me.btRemoveUser.Text = "Remove User"
        Me.btRemoveUser.UseVisualStyleBackColor = True
        '
        'btLogOut
        '
        Me.btLogOut.Location = New System.Drawing.Point(528, 118)
        Me.btLogOut.Name = "btLogOut"
        Me.btLogOut.Size = New System.Drawing.Size(75, 23)
        Me.btLogOut.TabIndex = 6
        Me.btLogOut.Text = "Log Out"
        Me.btLogOut.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(264, 290)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 46)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "View Issued Books"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(400, 291)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 50)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "View Returned Books"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 432)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btviewBooks)
        Me.Controls.Add(Me.btviewUser)
        Me.Controls.Add(Me.btRemoveBooks)
        Me.Controls.Add(Me.btAddBooks)
        Me.Controls.Add(Me.btRemoveUser)
        Me.Controls.Add(Me.btLogOut)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btviewBooks As System.Windows.Forms.Button
    Friend WithEvents btviewUser As System.Windows.Forms.Button
    Friend WithEvents btRemoveBooks As System.Windows.Forms.Button
    Friend WithEvents btAddBooks As System.Windows.Forms.Button
    Friend WithEvents btRemoveUser As System.Windows.Forms.Button
    Friend WithEvents btLogOut As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
