<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Me.btGo = New System.Windows.Forms.Button()
        Me.tbfinalPW = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btGo
        '
        Me.btGo.Location = New System.Drawing.Point(302, 233)
        Me.btGo.Name = "btGo"
        Me.btGo.Size = New System.Drawing.Size(75, 23)
        Me.btGo.TabIndex = 5
        Me.btGo.Text = "Go"
        Me.btGo.UseVisualStyleBackColor = True
        '
        'tbfinalPW
        '
        Me.tbfinalPW.Location = New System.Drawing.Point(289, 184)
        Me.tbfinalPW.Name = "tbfinalPW"
        Me.tbfinalPW.Size = New System.Drawing.Size(100, 20)
        Me.tbfinalPW.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(292, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter your User ID"
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 407)
        Me.Controls.Add(Me.btGo)
        Me.Controls.Add(Me.tbfinalPW)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ChangePassword"
        Me.Text = "ChangePassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btGo As System.Windows.Forms.Button
    Friend WithEvents tbfinalPW As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
