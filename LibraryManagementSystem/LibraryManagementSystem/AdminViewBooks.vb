Imports System.Data.SqlClient

Public Class AdminViewBooks

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Admin.Show()
    End Sub

    Private Sub AdminViewBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Pritam\Documents\Visual Studio 2012\Projects\LibraryManagementSystem\LibraryManagementSystem\LMSDatabase.mdf;Integrated Security=True;Connect Timeout=30"

        Dim con As New SqlConnection(str)

        Dim com As String = "Select * from Books"

        Dim Adpt As New SqlDataAdapter(com, con)

        Dim ds As New DataSet()

        Adpt.Fill(ds, "Books")

        DataGridView1.DataSource = ds.Tables(0)
    End Sub
End Class