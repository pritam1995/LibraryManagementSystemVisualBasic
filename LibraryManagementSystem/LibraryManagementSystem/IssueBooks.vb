Public Class IssueBooks

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btAddBooks_Click(sender As Object, e As EventArgs) Handles btAddBooks.Click

        daUser = New SqlClient.SqlDataAdapter("SELECT * FROM Books WHERE [BookID] = " & TextBox1.Text.Trim, conn)
        daUser.Fill(tblUser)

        If tblUser.Rows.Count = 0 Then
            MessageBox.Show("Sorry")
        End If
        Dim dr As DataRow = tblUser.Rows(0)

        If dr("Availability").ToString.Trim() = "Yes" Then


            cmdLib = New SqlClient.SqlCommand("INSERT into BookIssue(BookID,BookName,Author,IssueDate,UserId,Name) Values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox4.Text & "')", conn)
            cmdLib.ExecuteNonQuery()
            cmdLib = New SqlClient.SqlCommand("UPDATE Books SET [Availability]='No' WHERE [BookID]='" & TextBox1.Text & "'", conn)
            cmdLib.ExecuteNonQuery()
            MessageBox.Show("Successfully Issued")

        Else
            MessageBox.Show("Sorry no such book")

        End If

    End Sub

    Private Sub btGoUserPortal_Click(sender As Object, e As EventArgs) Handles btGoUserPortal.Click
        Me.Hide()
        User.Show()

    End Sub

    Private Sub IssueBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
    End Sub
End Class