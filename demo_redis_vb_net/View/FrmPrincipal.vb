Public Class FrmPrincipal
    Dim helper As New RedisHelper()
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim novo As New FrmNew()
        novo.ShowDialog()

        Try
            txtName.Text = helper.GetValue("name")
            txtAge.Text = helper.GetValue("age")
        Catch ex As Exception

        End Try
    End Sub
End Class
