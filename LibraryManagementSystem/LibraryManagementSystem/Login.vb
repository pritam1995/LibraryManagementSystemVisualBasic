Public Class Login

    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        If tbUserID.Text = "" Then
            MessageBox.Show("Pls Enter your Id")
        ElseIf tbPassword.Text = "" Then
            MessageBox.Show("Enter password")
        ElseIf tbUserID.Text = "" And tbPassword.Text = "" Then
            MessageBox.Show("Enter the req fields")
        Else

            If rbUser.Checked = True Then
                userType = "U"c
                MessageBox.Show("Logging in as User")
            ElseIf rbAdmin.Checked = True Then
                userType = "A"c
                MessageBox.Show("Logging in as Admin")
            End If


            daUser = New SqlClient.SqlDataAdapter("SELECT * FROM Info WHERE [UserID]= " & tbUserID.Text.Trim, conn)
            daUser.Fill(tblUser)

            If tblUser.Rows.Count = 0 Then
                MessageBox.Show("Sorry no record for user id: " & tbUserID.Text & " is available")
                Exit Sub
            End If

            Dim dr As DataRow = tblUser.Rows(0)

            If dr("Password").ToString.Trim() <> tbPassword.Text.Trim() Then

                MessageBox.Show("Incorrect User ID or Password!")
                Exit Sub
            End If

            If userType = "U"c And dr("UniqueID").ToString.Trim() = "User" Then
                User.Show()
                Me.Hide()
            ElseIf userType = "A"c And dr("UniqueID").ToString.Trim() = "Admin" Then

                Admin.Show()
                Me.Hide()
            Else
                MessageBox.Show("Please enter correct ID to go or Please select right option")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub btiniSignUp_Click(sender As Object, e As EventArgs) Handles btiniSignUp.Click
        Me.Hide()
        SignUp.Show()
    End Sub

    Private Sub btReset_Click(sender As Object, e As EventArgs) Handles btReset.Click
        tbUserID.Clear()
        tbPassword.Clear()
    End Sub

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        End
    End Sub

    Private Sub btChangePW_Click(sender As Object, e As EventArgs) Handles btChangePW.Click
        Me.Hide()
        ChangePassword.Show()
    End Sub
End Class