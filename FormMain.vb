Public Class FormMain
    Private Sub ButtonVolverALogin_Click(sender As Object, e As EventArgs) Handles ButtonVolverALogin.Click
        Form1.Show()  ' Muestra el formulario de login
        Me.Hide()
    End Sub
End Class