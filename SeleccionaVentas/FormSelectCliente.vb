Public Class FormSelectCliente
    Public nombre As String
    Public id As Integer
    Private Sub FormSelectCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetProductos.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.DataSetProductos.Cliente)

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim n = DataGridView1.CurrentRow.Cells(0).Value

        Dim foundRows() As DataRow = DataSetProductos.Cliente.Select("ClienteID = '" & n & "'")
        If foundRows.Length > 0 Then
            Dim foundRow As DataRow = foundRows(0)

            id = foundRow(0)
            nombre = foundRow(1)

            Me.DialogResult = DialogResult.OK
            Me.Close()

        End If
    End Sub
End Class