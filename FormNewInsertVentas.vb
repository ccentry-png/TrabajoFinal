Public Class FormNewInsertVentas
    Dim idAModificar As Integer
    Dim modificar As Boolean = False

    Dim idProducto As Integer
    Dim precioProducto As Decimal
    Dim idCliente As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cantidad = NumericUpDown1.Value
        Dim fecha As Date = MonthCalendar1.SelectionStart

        Dim total = precioProducto * cantidad


        If modificar = True Then

            'VentaTableAdapter1.UpdateQuery(idCliente, fecha, total, )


        Else

            ' ProductosTableAdapter1.InsertNoBar(NombreProducto:=nombre, Precio:=precio)
            Dim idVentaCreada As Integer
            idVentaCreada = CInt(VentaTableAdapter1.InsertYdaID(idCliente, fecha, total))

            DetalleVentaTableAdapter1.Insert(idVentaCreada, idProducto, cantidad, precioProducto)



        End If


        modificar = False
        Button1.Text = "Agregar "
        Me.Close()



    End Sub

    Public Function ShowDialogModificar(id As Integer)

        idAModificar = id
        Button1.Text = "Modificar Producto"
        modificar = True


        Return Me.ShowDialog()
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim form As New FormSelectProducto()

        If form.ShowDialog() = DialogResult.OK Then

            Label1.Text = "Producto seleccionado: " + form.nombre
            idProducto = form.id
            precioProducto = form.precio


        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form As New FormSelectCliente()

        If form.ShowDialog() = DialogResult.OK Then

            Label3.Text = "Cliente seleccionado: " + form.nombre
            idCliente = form.id


        End If
    End Sub


End Class