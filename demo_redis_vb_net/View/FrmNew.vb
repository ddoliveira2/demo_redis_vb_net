Public Class FrmNew
    Dim helper As New RedisHelper()
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Try
            If String.IsNullOrEmpty(txtName.Text) Or String.IsNullOrEmpty(txtAge.Text) Then
                MessageBox.Show("Campos obrigatorios não informados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                helper.SetValue("name", txtName.Text)
                helper.SetValue("age", txtAge.Text)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class