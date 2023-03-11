Imports Org.BouncyCastle.Asn1.Misc

Public Class FormTimeInOut
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldate.Text = DateTime.Now.ToString("yyyy/M/dd")

    End Sub

    Private Sub BTNTIMEINOUT_Click(sender As Object, e As EventArgs) Handles BTNTIMEINOUT.Click
        Try
            If EMPLOYEEID.Text = "" Then
                MessageBox.Show("PLEASE ENTER EMPLOYEE ID", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                reloadtxt("SELECT * FROM table_employee WHERE EMPLOYEEID= '" & EMPLOYEEID.Text & "'")
                If dt.Rows.Count > 0 Then
                    reloadtxt("SELECT * FROM table_attendance WHERE EMPLOYEEID = '" & EMPLOYEEID.Text & "'AND LOGDATE= '" & lbldate.Text & "' AND AM_STATUS = 'Time In' AND PM_STATUS = 'Time Out'")
                    If dt.Rows.Count > 0 Then
                        MessageBox.Show("YOU HAVE ALREADY TIMED-IN AND OUT TODAY!!!", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        reloadtxt("SELECT * FROM table_attendance WHERE EMPLOYEEID = '" & EMPLOYEEID.Text & "' AND LOGDATE= '" & lbldate.Text & "'AND AM_STATUS= 'Time In' ")
                        If dt.Rows.Count > 0 Then
                            updateslogged("UPDATE table_attendance SET TIMEOUT = '" & TimeOfDay & "', PM_STATUS = 'Time Out',TOTALHOURS = TIMEOUT - TIMEIN  WHERE EMPLOYEEID= '" & EMPLOYEEID.Text & "', AND LOGDATE = '" & lbldate.Text & "' ")
                            MessageBox.Show("YOU HAVE SUCCESSFULLY TIMED-OUT!!", "TIMEOUT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            createlogged("INSERT INTO table_attendance (EMPLOYEEID,LOGDATE,TIMEIN,AM_STATUS)VALUES('" & EMPLOYEEID.Text & "', '" & lbldate.Text & "', '" & TimeOfDay & "', 'Time In') ")
                            MessageBox.Show("YOU HAVE SUCCESSFULLY TIMED-IN!!!", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Else
                    MessageBox.Show("EMPLOYEE ID NOT FOUND :( ", "NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FormTimeInOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub reloadattendance()
        Try
            reload("SELECT CONCAT(FIRSTNAME,'',LASTNAME)AS FULLNAME, LOGDATE, TIMEIN,AM_STATUS,TIMEOUT,PM_STATUS,TOTALHOURS  FROM table_attendance INNER JOIN table_employee ON table_attendance.EMPLOYEEID = table.employee.EMPLOYEEID", DataGridView1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        reloadattendance()

    End Sub


End Class