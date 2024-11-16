Imports Microsoft.VisualBasic.ApplicationServices

Public Class FormMain


    'al cerrar taria weno que la aplicacion se cerrara
    'no se cierra porque form 1 todavia esta
    '(no tan importante)
    Private Sub ButtonVolverALogin_Click(sender As Object, e As EventArgs) Handles ButtonVolverALogin.Click
        Form1.Show()  ' Muestra el formulario de login
        Me.Hide()
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetProductos.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.DataSetProductos.Productos)

        ButtonModificarProducto.Enabled = False


    End Sub

    Private Sub ButtonCrearProducto_Click(sender As Object, e As EventArgs) Handles ButtonCrearProducto.Click
        FormProductoNuevo.Text = "Creando nuevo producto"
        If (FormProductoNuevo.ShowDialog() = DialogResult.OK) Then
            'mostrar cambios NO SIRVE AAA
            Me.ProductosTableAdapter.Fill(Me.DataSetProductos.Productos)
        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick, DataGridView1.CellDoubleClick, DataGridView1.CellContentClick


        Dim nombre = DataGridView1.CurrentRow.Cells(0).Value

        Dim foundRows() As DataRow = DataSetProductos.Productos.Select("NombreProducto = '" & nombre & "'")
        If foundRows.Length > 0 Then
            Dim foundRow As DataRow = foundRows(0)

            Dim codigoProducto = foundRow(0)

            LabelProductoSelecionado.Text = "Producto selecionado: " + nombre

            ButtonModificarProducto.Enabled = True
            'modificar formnuevoproducto para permitir modificacion de producto
            'como mando datos al abrir form???


        End If








    End Sub

End Class