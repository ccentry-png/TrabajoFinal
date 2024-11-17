Public Class FormClienteNuevo
    Dim idAModificar As Integer
    Dim modificar As Boolean = False


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre = TextBox1.Text
        Dim email = TextBox2.Text
        Dim telefono As Integer = Integer.Parse(TextBox3.Text)




        If modificar = True Then

            ClienteTableAdapter1.UpdateById(nombre, email, telefono, idAModificar)

        Else

            ClienteTableAdapter1.Insert(nombre, email, telefono)
        End If


        modificar = False
        Button1.Text = "Agregar Cliente"
        Me.Close()



    End Sub

    Public Function ShowDialogModificar(id As Integer)

        idAModificar = id
        Button1.Text = "Modificar Cliente"
        modificar = True


        Return Me.ShowDialog()
    End Function

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class