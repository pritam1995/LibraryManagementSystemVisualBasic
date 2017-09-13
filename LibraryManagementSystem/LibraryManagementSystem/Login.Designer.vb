<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.btiniSignUp = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btChangePW = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btExit = New System.Windows.Forms.Button()
        Me.btReset = New System.Windows.Forms.Button()
        Me.btLogin = New System.Windows.Forms.Button()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbUserID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbAdmin = New System.Windows.Forms.RadioButton()
        Me.rbUser = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btiniSignUp
        '
        Me.btiniSignUp.Location = New System.Drawing.Point(252, 324)
        Me.btiniSignUp.Name = "btiniSignUp"
        Me.btiniSignUp.Size = New System.Drawing.Size(75, 23)
        Me.btiniSignUp.TabIndex = 23
        Me.btiniSignUp.Text = "Sign Up"
        Me.btiniSignUp.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(161, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "New member?"
        '
        'btChangePW
        '
        Me.btChangePW.Location = New System.Drawing.Point(577, 324)
        Me.btChangePW.Name = "btChangePW"
        Me.btChangePW.Size = New System.Drawing.Size(75, 23)
        Me.btChangePW.TabIndex = 21
        Me.btChangePW.Text = "Click Here"
        Me.btChangePW.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(469, 329)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Change Password? "
        '
        'btExit
        '
        Me.btExit.Location = New System.Drawing.Point(521, 254)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(75, 23)
        Me.btExit.TabIndex = 19
        Me.btExit.Text = "Exit"
        Me.btExit.UseVisualStyleBackColor = True
        '
        'btReset
        '
        Me.btReset.Location = New System.Drawing.Point(363, 254)
        Me.btReset.Name = "btReset"
        Me.btReset.Size = New System.Drawing.Size(75, 23)
        Me.btReset.TabIndex = 18
        Me.btReset.Text = "Reset"
        Me.btReset.UseVisualStyleBackColor = True
        '
        'btLogin
        '
        Me.btLogin.Location = New System.Drawing.Point(205, 254)
        Me.btLogin.Name = "btLogin"
        Me.btLogin.Size = New System.Drawing.Size(75, 23)
        Me.btLogin.TabIndex = 17
        Me.btLogin.Text = "Log In"
        Me.btLogin.UseVisualStyleBackColor = True
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(397, 203)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(100, 20)
        Me.tbPassword.TabIndex = 16
        '
        'tbUserID
        '
        Me.tbUserID.Location = New System.Drawing.Point(397, 171)
        Me.tbUserID.Name = "tbUserID"
        Me.tbUserID.Size = New System.Drawing.Size(100, 20)
        Me.tbUserID.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(303, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(303, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "User ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbAdmin)
        Me.GroupBox1.Controls.Add(Me.rbUser)
        Me.GroupBox1.Location = New System.Drawing.Point(205, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 57)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select"
        '
        'rbAdmin
        '
        Me.rbAdmin.AutoSize = True
        Me.rbAdmin.Location = New System.Drawing.Point(240, 20)
        Me.rbAdmin.Name = "rbAdmin"
        Me.rbAdmin.Size = New System.Drawing.Size(85, 17)
        Me.rbAdmin.TabIndex = 1
        Me.rbAdmin.Text = "Administrator"
        Me.rbAdmin.UseVisualStyleBackColor = True
        '
        'rbUser
        '
        Me.rbUser.AutoSize = True
        Me.rbUser.Checked = True
        Me.rbUser.Location = New System.Drawing.Point(66, 20)
        Me.rbUser.Name = "rbUser"
        Me.rbUser.Size = New System.Drawing.Size(47, 17)
        Me.rbUser.TabIndex = 0
        Me.rbUser.TabStop = True
        Me.rbUser.Text = "User"
        Me.rbUser.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 462)
        Me.Controls.Add(Me.btiniSignUp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btChangePW)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.btReset)
        Me.Controls.Add(Me.btLogin)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUserID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btiniSignUp As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btChangePW As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btExit As System.Windows.Forms.Button
    Friend WithEvents btReset As System.Windows.Forms.Button
    Friend WithEvents btLogin As System.Windows.Forms.Button
    Friend WithEvents tbPassword As System.Windows.Forms.TextBox
    Friend WithEvents tbUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents rbUser As System.Windows.Forms.RadioButton
End Class
