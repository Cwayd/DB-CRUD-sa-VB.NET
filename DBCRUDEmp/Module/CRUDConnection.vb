Imports MySql.Data.MySqlClient

Module CRUDConnection
    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public ds As New DataSet


    Public Sub create(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql


                Result = cmd.ExecuteNonQuery

                If Result = 0 Then
                    MessageBox.Show("Data failed to insert", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("data has successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        Try
            strcon.Open()
            dt = New DataTable

            With cmd
                .Connection = strcon
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.datasource = dt

        Catch ex As Exception
        Finally
            strcon.Close()
            da.Dispose()

        End Try
    End Sub
    Public Sub reloadtxt(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With

            dt = New DataTable
            da = New MySqlDataAdapter(sql, strcon)
            da.Fill(dt)
        Catch ex As Exception
        Finally
            strcon.Close()
            da.Dispose()

        End Try
    End Sub
    Public Sub createlogged(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With
            result = cmd.ExecuteNonQuery


        Catch ex As Exception
        Finally
            strcon.Close()

        End Try
    End Sub
    Public Sub updateslogged(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
            End With


        Catch ex As Exception
        Finally
            strcon.Close()

        End Try

    End Sub

End Module
