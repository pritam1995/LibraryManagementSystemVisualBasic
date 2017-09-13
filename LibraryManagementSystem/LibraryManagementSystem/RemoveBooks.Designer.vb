<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoveBooks
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
        Me.btGoAdmin = New System.Windows.Forms.Button()
        Me.btdelBook = New System.Windows.Forms.Button()
        Me.tbrmvBooks = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btGoAdmin
        '
        Me.btGoAdmin.Location = New System.Drawing.Point(339, 285)
        Me.btGoAdmin.Name = "btGoAdmin"
        Me.btGoAdmin.Size = New System.Drawing.Size(100, 20)
        Me.btGoAdmin.TabIndex = 7
        Me.btGoAdmin.Text = "Back"
        Me.btGoAdmin.UseVisualStyleBackColor = True
        '
        'btdelBook
        '
        Me.btdelBook.Location = New System.Drawing.Point(339, 230)
        Me.btdelBook.Name = "btdelBook"
        Me.btdelBook.Size = New System.Drawing.Size(100, 20)
        Me.btdelBook.TabIndex = 6
        Me.btdelBook.Text = "Delete Book"
        Me.btdelBook.UseVisualStyleBackColor = True
        '
        'tbrmvBooks
        '
        Me.tbrmvBooks.Location = New System.Drawing.Point(342, 176)
        Me.tbrmvBooks.Name = "tbrmvBooks"
        Me.tbrmvBooks.Size = New System.Drawing.Size(100, 20)
        Me.tbrmvBooks.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(351, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter Book ID"
        '
        'RemoveBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 440)
        Me.Controls.Add(Me.btGoAdmin)
        Me.Controls.Add(Me.btdelBook)
        Me.Controls.Add(Me.tbrmvBooks)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RemoveBooks"
        Me.Text = "RemoveBooks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btGoAdmin As System.Windows.Forms.Button
    Friend WithEvents btdelBook As System.Windows.Forms.Button
    Friend WithEvents tbrmvBooks As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
