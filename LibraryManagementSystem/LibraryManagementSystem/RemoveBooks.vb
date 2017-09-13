Public Class RemoveBooks

    Private Sub btdelBook_Click(sender As Object, e As EventArgs) Handles btdelBook.Click
        cmdLib = New SqlClient.SqlCommand("DELETE FROM Books WHERE [BookID]= " & tbrmvBooks.Text.Trim(), conn)
        cmdLib.ExecuteNonQuery()
        MessageBox.Show("Successfully Deleted!!")
        tbrmvBooks.Clear()
    End Sub

    Private Sub btGoAdmin_Click(sender As Object, e As EventArgs) Handles btGoAdmin.Click
        Me.Hide()
        Admin.Show()
    End Sub
End Class