Public Class FormProductoNuevo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre = TextBox1.Text
        Dim precio As Decimal = NumericUpDown1.Value

        If CheckBox1.Checked Then
            'TODO agrega barcode

        End If




        ProductosTableAdapter1.InsertNoBar(NombreProducto:=nombre, Precio:=precio)


        Me.Close()



    End Sub
End Class