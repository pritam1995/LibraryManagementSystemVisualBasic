Public Class BookSearch
    Dim rno As Integer
    Dim r As Integer
    Private Sub btGoUserPortal_Click(sender As Object, e As EventArgs) Handles btGoUserPortal.Click
        Me.Hide()
        User.Show()

    End Sub

    Private Sub btNext_Click(sender As Object, e As EventArgs) Handles btNext.Click
        If r < rno - 1 Then
            r = r + 1
            disp(r)
        Else
            MessageBox.Show("Reached to the last book")
            Exit Sub
        End If
    End Sub

    Private Sub btPrevious_Click(sender As Object, e As EventArgs) Handles btPrevious.Click
        If r > 0 Then
            r = r - 1
            disp(r)
        Else
            MessageBox.Show("Reached to the first book")
            Exit Sub
        End If
    End Sub

    Private Sub BookSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        daLib = New SqlClient.SqlDataAdapter("SELECT * FROM Books", conn)
        daLib.Fill(tblLib)

        rno = tblLib.Rows.Count
        r = 0
        disp(r)
    End Sub
    Private Sub disp(r As Integer)
        TextBox1.Text = tblLib(r)("BookID")
        TextBox2.Text = tblLib(r)("BookName")
        TextBox3.Text = tblLib(r)("Author")
        TextBox4.Text = tblLib(r)("Availability")
    End Sub
End Class