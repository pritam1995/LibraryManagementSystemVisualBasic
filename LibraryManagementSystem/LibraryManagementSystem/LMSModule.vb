Imports System.Data.SqlClient

Module LMSModule
    Public userID As Integer
    Public userType As Char

    Public conn As New SqlConnection
    Public daUser As New SqlDataAdapter
    Public daLib As New SqlDataAdapter
    Public tblUser As New DataTable
    Public tblLib As New DataTable
    Public cmdUser As New SqlCommand
    Public cmdLib As New SqlCommand

    Public cbUser As New SqlCommandBuilder
    Public cbLib As New SqlCommandBuilder

    Public Sub connect()
        conn = New SqlConnection
        conn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Projects\Visual Studio Projects\LibraryManagementSystem\LibraryManagementSystem\LMSDatabase.mdf;Integrated Security=True;Connect Timeout=30"
        Try
            conn.Open()
            daLib = New SqlDataAdapter("SELECT * from Books", conn)
            cbLib = New SqlCommandBuilder(daLib)
            daLib.Fill(tblLib)

        Catch ex As Exception
            MessageBox.Show("Connection Error" + ex.Message)
            End
        End Try
    End Sub

End Module
