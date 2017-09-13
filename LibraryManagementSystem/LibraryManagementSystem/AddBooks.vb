Public Class AddBooks

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btgo_Click(sender As Object, e As EventArgs) Handles btgo.Click
        Me.Hide()
        Admin.Show()
    End Sub

    Private Sub btAddBooks_Click(sender As Object, e As EventArgs) Handles btAddBooks.Click
        cmdLib = New SqlClient.SqlCommand("INSERT into Books(BookID,BookName,Author,Availability) Values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')", conn)
        cmdLib.ExecuteNonQuery()
        MessageBox.Show("Successfully Added!!")
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub
End Class
