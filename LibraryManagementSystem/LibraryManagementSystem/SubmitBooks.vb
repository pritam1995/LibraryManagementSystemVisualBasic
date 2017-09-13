Public Class SubmitBooks

    Private Sub btGoUserPortal_Click(sender As Object, e As EventArgs) Handles btGoUserPortal.Click
        Me.Hide()
        User.Show()
    End Sub

    Private Sub btAddBooks_Click(sender As Object, e As EventArgs) Handles btAddBooks.Click
        cmdLib = New SqlClient.SqlCommand("INSERT  into BookReturn(BookId,BookName,Author,ReturnDate,UserID,Name)Values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox4.Text & "')", conn)
        cmdLib.ExecuteNonQuery()
        cmdLib = New SqlClient.SqlCommand("UPDATE Books SET [Availability]='Yes' WHERE [BookID]='" & TextBox1.Text & "'", conn)
        cmdLib.ExecuteNonQuery()
        MessageBox.Show("Successfully Submitted")
    End Sub

    Private Sub SubmitBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
    End Sub
End Class