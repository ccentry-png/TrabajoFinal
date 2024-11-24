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


    Private Sub ButtonCrearVenta_Click(sender As Object, e As EventArgs) Handles ButtonCrearVenta.Click
        If (FormNewInsertVentas.ShowDialog() = DialogResult.OK) Then
            'mostrar cambios NO SIRVE AAA
            cargarDatos()

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
End Class