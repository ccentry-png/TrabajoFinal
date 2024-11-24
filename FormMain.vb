Public Class FormMain
    Dim codigoVentaSeleccionada

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


    Private Sub ButtonCrearVenta_Click(sender As Object, e As EventArgs) Handles ButtonCrearVenta.Click
        If (FormNewInsertVentas.ShowDialog() = DialogResult.OK) Then
            'mostrar cambios NO SIRVE AAA
            cargarDatos()

            ButtonModificarVEnta.Enabled = False
            ButtonBorrarVenta.Enabled = False
        End If
    End Sub

    Private Sub cargarDatos()
        Me.DataTable1TableAdapter.Fill(Me.DataSetVentas.DataTable1)

    End Sub
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()

    End Sub
    Private Sub FormMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub ButtonBorrarVenta_Click(sender As Object, e As EventArgs) Handles ButtonBorrarVenta.Click

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick


        Dim idVenta = DataGridView1.CurrentRow.Cells(7).Value

        Dim foundRows() As DataRow = DataSetVentas.DataTable1.Select("DetalleVentaID = '" & idVenta & "'")
        If foundRows.Length > 0 Then
            Dim foundRow As DataRow = foundRows(0)


            codigoVentaSeleccionada = idVenta

            LabelProductoSelecionado.Text = "Venta selecionada: " + idVenta.ToString

            ButtonBorrarVenta.Enabled = True
            ButtonModificarVEnta.Enabled = True
        End If
    End Sub
End Class