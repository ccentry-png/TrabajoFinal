Public Class FormSelectProducto
    Public nombre As String
    Public id As Integer
    Public precio As Decimal
    Private Sub FormSelectProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetProductos.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.DataSetProductos.Productos)

    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim n = DataGridView1.CurrentRow.Cells(0).Value

        Dim foundRows() As DataRow = DataSetProductos.Productos.Select("ProductoID = '" & n & "'")
        If foundRows.Length > 0 Then
            Dim foundRow As DataRow = foundRows(0)

            id = foundRow(0)
            nombre = foundRow(1)
            precio = foundRow(2)

            Me.DialogResult = DialogResult.OK
            Me.Close()

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class