
Imports MySql.Data.MySqlClient

Public Class FormEmployee

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Try
            create("INSERT INTO table_employee (EMPLOYEEID,FIRSTNAME,LASTNAME)VALUES('" & EMPLOYEEID.Text & " ','" & FIRSTNAME.Text & " ','" & LASTNAME.Text & " ')")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub FormEmployee_Load(sender As Object, e As EventArgs)
        loaddata()

    End Sub
    Public Sub loaddata()
        Try
            reload("SELECT * FROM table_employee", DataGridView1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        loaddata()

    End Sub




End Class