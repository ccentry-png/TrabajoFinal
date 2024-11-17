Public Class FormProductoNuevo
    Dim idAModificar As Integer
    Dim modificar As Boolean = False


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre = TextBox1.Text
        Dim precio As Decimal = NumericUpDown1.Value

        Dim barcode = Nothing
        If CheckBox1.Checked Then
            'TODO agrega barcode

        End If


        If modificar = True Then

            ProductosTableAdapter1.UpdateById(nombre, precio, barcode, idAModificar)

        Else

            ProductosTableAdapter1.InsertNoBar(NombreProducto:=nombre, Precio:=precio)

        End If


        modificar = False
        Button1.Text = "Agregar Producto"
        Me.Close()



    End Sub

    Public Function ShowDialogModificar(id As Integer)

        idAModificar = id
        Button1.Text = "Modificar Producto"
        modificar = True


        Return Me.ShowDialog()
    End Function
End Class