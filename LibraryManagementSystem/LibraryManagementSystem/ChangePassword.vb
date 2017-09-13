Public Class ChangePassword
    Dim ans As String
    Private Sub btGo_Click(sender As Object, e As EventArgs) Handles btGo.Click
        Dim permission As Integer
        daUser = New SqlClient.SqlDataAdapter("SELECT * FROM Info WHERE [UserID]= " & tbfinalPW.Text.Trim, conn)
        daUser.Fill(tblUser)


        If tblUser.Rows.Count = 0 Then

            MessageBox.Show("Please enter correct user ID")
            tbfinalPW.Clear()
        Else
            ans = InputBox("Please enter your password :", " Password Change Step ", "Enter your password here")
            permission = MessageBox.Show("Are you sure to change your password?", "Confirmaton", MessageBoxButtons.OKCancel)
            If permission = DialogResult.Cancel Then
                Exit Sub
            End If
            tblUser.Rows(0)("Password") = ans.Trim()
            cbUser = New SqlClient.SqlCommandBuilder(daUser)
            daUser.Update(tblUser)
            MessageBox.Show("Record updated Successfully!!")
            tbfinalPW.Clear()
            Me.Hide()
            Login.Show()
        End If
    End Sub
End Class