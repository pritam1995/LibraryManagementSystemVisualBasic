Public Class User

    Private Sub btLogOut_Click(sender As Object, e As EventArgs) Handles btLogOut.Click
        Dim p1 As Integer = MessageBox.Show("Are you sure to log out?", "Confirmation", MessageBoxButtons.OKCancel)
        If p1 = DialogResult.Cancel Then
            Exit Sub
        Else
            Me.Hide()
            Login.Show()
        End If
    End Sub

    Private Sub btSearchBooks_Click(sender As Object, e As EventArgs) Handles btSearchBooks.Click
        Me.Hide()
        BookSearch.Show()
    End Sub

    Private Sub btIssueBook_Click(sender As Object, e As EventArgs) Handles btIssueBook.Click
        Me.Hide()
        IssueBooks.Show()
    End Sub

    Private Sub btSubmitBook_Click(sender As Object, e As EventArgs) Handles btSubmitBook.Click
        Me.Hide()
        SubmitBooks.Show()
    End Sub
End Class