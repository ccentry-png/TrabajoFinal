Public Class FormMain



















    Private Sub ButtonVolverALogin_Click(sender As Object, e As EventArgs) Handles ButtonVolverALogin.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonVerClientes_Click(sender As Object, e As EventArgs) Handles ButtonVerClientes.Click
        FormClientes.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonVerProductos_Click(sender As Object, e As EventArgs) Handles ButtonVerProductos.Click
        FormProductos.Show()
        Me.Hide()
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetVentas.DataTable1' Puede moverla o quitarla según sea necesario.
        Me.DataTable1TableAdapter.Fill(Me.DataSetVentas.DataTable1)
        'TODO: esta línea de código carga datos en la tabla 'DataSetProductos.DetalleVenta' Puede moverla o quitarla según sea necesario.
        Me.DetalleVentaTableAdapter.Fill(Me.DataSetProductos.DetalleVenta)
        'TODO: esta línea de código carga datos en la tabla 'DataSetProductos.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.DataSetProductos.Productos)

    End Sub
End Class