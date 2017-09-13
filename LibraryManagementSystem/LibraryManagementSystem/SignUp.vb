Public Class SignUp

    Private Sub btSignIn_Click(sender As Object, e As EventArgs) Handles btSignIn.Click
        If rb1.Checked = True Then
            cmdUser = New SqlClient.SqlCommand("INSERT into Info(UserID,Name,UniqueID,Password) Values('" & TextBox1.Text & "','" & TextBox2.Text & "','User','" & TextBox3.Text & "')", conn)
            cmdUser.ExecuteNonQuery()
            MessageBox.Show("SignUp is complete!")
        Else
            cmdUser = New SqlClient.SqlCommand("INSERT into Info(UserID,Name,UniqueID,Password) Values('" & TextBox1.Text & "','" & TextBox2.Text & "','Admin','" & TextBox3.Text & "')", conn)
            cmdUser.ExecuteNonQuery()
            MessageBox.Show("SignUp is complete!")
        End If
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
    End Sub
End Class