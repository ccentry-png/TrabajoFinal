Imports Microsoft.VisualBasic.ApplicationServices

Public Class FormMain

    Dim codigoProductoSelecionado As Integer
    Dim nombreProductoSelecionado As String


    Private Sub ButtonVolverALogin_Click(sender As Object, e As EventArgs) Handles ButtonVolverALogin.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()

        ButtonModificarProducto.Enabled = False
        ButtonBorrarProducto.Enabled = False


    End Sub

    Private Sub ButtonCrearProducto_Click(sender As Object, e As EventArgs) Handles ButtonCrearProducto.Click
        FormProductoNuevo.Text = "Creando nuevo producto"
        If (FormProductoNuevo.ShowDialog() = DialogResult.OK) Then
            'mostrar cambios NO SIRVE AAA
            cargarDatos()

        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick, DataGridView1.CellDoubleClick, DataGridView1.CellContentClick


        Dim nombre = DataGridView1.CurrentRow.Cells(0).Value

        Dim foundRows() As DataRow = DataSetProductos.Productos.Select("NombreProducto = '" & nombre & "'")
        If foundRows.Length > 0 Then
            Dim foundRow As DataRow = foundRows(0)

            codigoProductoSelecionado = foundRow(0)
            nombreProductoSelecionado = foundRow(1)

            LabelProductoSelecionado.Text = "Producto selecionado: " + nombre

            ButtonBorrarProducto.Enabled = True
            ButtonModificarProducto.Enabled = True
            'modificar formnuevoproducto para permitir modificacion de producto
            'como mando datos al abrir form???


        End If

    End Sub



    Sub cargarDatos()
        'TODO: esta línea de código carga datos en la tabla 'DataSetProductos.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.DataSetProductos.Productos)
    End Sub

    Private Sub ButtonBorrarProducto_Click(sender As Object, e As EventArgs) Handles ButtonBorrarProducto.Click

        ProductosTableAdapter.DeleteByID(codigoProductoSelecionado)
        cargarDatos()

    End Sub

    Private Sub FormMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub ButtonModificarProducto_Click(sender As Object, e As EventArgs) Handles ButtonModificarProducto.Click
        Dim f2 As New FormProductoNuevo()
        f2.Text = "Modificando " + nombreProductoSelecionado
        If (f2.ShowDialogModificar(codigoProductoSelecionado) = DialogResult.OK) Then

            cargarDatos()

        End If
    End Sub
End Class