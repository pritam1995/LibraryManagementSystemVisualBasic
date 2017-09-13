<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Me.btSubmitBook = New System.Windows.Forms.Button()
        Me.btIssueBook = New System.Windows.Forms.Button()
        Me.btLogOut = New System.Windows.Forms.Button()
        Me.btSearchBooks = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btSubmitBook
        '
        Me.btSubmitBook.Location = New System.Drawing.Point(223, 272)
        Me.btSubmitBook.Name = "btSubmitBook"
        Me.btSubmitBook.Size = New System.Drawing.Size(139, 23)
        Me.btSubmitBook.TabIndex = 7
        Me.btSubmitBook.Text = "Submit Book"
        Me.btSubmitBook.UseVisualStyleBackColor = True
        '
        'btIssueBook
        '
        Me.btIssueBook.Location = New System.Drawing.Point(223, 221)
        Me.btIssueBook.Name = "btIssueBook"
        Me.btIssueBook.Size = New System.Drawing.Size(139, 23)
        Me.btIssueBook.TabIndex = 6
        Me.btIssueBook.Text = "Issue Book"
        Me.btIssueBook.UseVisualStyleBackColor = True
        '
        'btLogOut
        '
        Me.btLogOut.Location = New System.Drawing.Point(401, 137)
        Me.btLogOut.Name = "btLogOut"
        Me.btLogOut.Size = New System.Drawing.Size(75, 23)
        Me.btLogOut.TabIndex = 5
        Me.btLogOut.Text = "Log Out"
        Me.btLogOut.UseVisualStyleBackColor = True
        '
        'btSearchBooks
        '
        Me.btSearchBooks.Location = New System.Drawing.Point(223, 170)
        Me.btSearchBooks.Name = "btSearchBooks"
        Me.btSearchBooks.Size = New System.Drawing.Size(139, 23)
        Me.btSearchBooks.TabIndex = 4
        Me.btSearchBooks.Text = "View Books "
        Me.btSearchBooks.UseVisualStyleBackColor = True
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 433)
        Me.Controls.Add(Me.btSubmitBook)
        Me.Controls.Add(Me.btIssueBook)
        Me.Controls.Add(Me.btLogOut)
        Me.Controls.Add(Me.btSearchBooks)
        Me.Name = "User"
        Me.Text = "User"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btSubmitBook As System.Windows.Forms.Button
    Friend WithEvents btIssueBook As System.Windows.Forms.Button
    Friend WithEvents btLogOut As System.Windows.Forms.Button
    Friend WithEvents btSearchBooks As System.Windows.Forms.Button
End Class
