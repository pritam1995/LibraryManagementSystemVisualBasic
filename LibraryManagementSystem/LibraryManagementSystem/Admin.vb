Public Class Admin

    Private Sub btLogOut_Click(sender As Object, e As EventArgs) Handles btLogOut.Click
        Dim p1 As Integer = MessageBox.Show("Are you sure to log out?", "Confirmation", MessageBoxButtons.OKCancel)
        If p1 = DialogResult.Cancel Then
            Exit Sub
        Else
            Me.Hide()
            Login.Show()
        End If
    End Sub

    Private Sub btRemoveUser_Click(sender As Object, e As EventArgs) Handles btRemoveUser.Click
        RemoveUser.Show()
        Me.Hide()
    End Sub

    Private Sub btAddBooks_Click(sender As Object, e As EventArgs) Handles btAddBooks.Click
        AddBooks.Show()
        Me.Hide()
    End Sub

    Private Sub btRemoveBooks_Click(sender As Object, e As EventArgs) Handles btRemoveBooks.Click
        RemoveBooks.Show()
        Me.Hide()
    End Sub

    Private Sub btviewUser_Click(sender As Object, e As EventArgs) Handles btviewUser.Click
        Me.Hide()
        ViewInfo.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        IssuedBooks.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        ReturnedBooks.Show()
    End Sub

    Private Sub btviewBooks_Click(sender As Object, e As EventArgs) Handles btviewBooks.Click
        Me.Hide()
        AdminViewBooks.Show()
    End Sub

End Class