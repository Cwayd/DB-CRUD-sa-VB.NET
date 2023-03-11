Public Class Form1
    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        FormEmployee.ShowDialog()

    End Sub

    Private Sub Btntimeinout_Click(sender As Object, e As EventArgs) Handles Btntimeinout.Click
        FormTimeInOut.ShowDialog()

    End Sub
End Class
