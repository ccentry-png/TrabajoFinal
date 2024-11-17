Imports Microsoft.VisualBasic.ApplicationServices

Public Class FormClientes

    Dim codigoClienteSelecionado As Integer
    Dim nombreClienteSelecionado As String


    Private Sub ButtonVolverALogin_Click(sender As Object, e As EventArgs) Handles ButtonVolverALogin.Click
        FormMain.Show()
        Me.Hide()
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        cargarDatos()

        ButtonModificarProducto.Enabled = False
        ButtonBorrarProducto.Enabled = False


    End Sub

    Private Sub ButtonCrearProducto_Click(sender As Object, e As EventArgs) Handles ButtonCrearProducto.Click
        ' VVVVVVVVV
        FormClienteNuevo.Text = "Añadiendo cliente..."
        If (FormClienteNuevo.ShowDialog() = DialogResult.OK) Then

            cargarDatos()

        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick, DataGridView1.CellDoubleClick, DataGridView1.CellContentClick


        Dim nombre = DataGridView1.CurrentRow.Cells(0).Value

        Dim foundRows() As DataRow = DataSetProductos.Cliente.Select("Nombre = '" & nombre & "'")
        If foundRows.Length > 0 Then
            Dim foundRow As DataRow = foundRows(0)

            codigoClienteSelecionado = foundRow(0)
            nombreClienteSelecionado = foundRow(1)

            LabelProductoSelecionado.Text = "Cliente selecionado: " + nombre

            ButtonBorrarProducto.Enabled = True
            ButtonModificarProducto.Enabled = True
            'modificar formnuevoproducto para permitir modificacion de producto
            'como mando datos al abrir form???


        End If

    End Sub



    Sub cargarDatos()
        'TODO: esta línea de código carga datos en la tabla 'DataSetProductos.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.DataSetProductos.Cliente)
    End Sub

    Private Sub ButtonBorrarProducto_Click(sender As Object, e As EventArgs) Handles ButtonBorrarProducto.Click

        ClienteTableAdapter.DeleteById(codigoClienteSelecionado)
        cargarDatos()

    End Sub

    Private Sub FormMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub ButtonModificarProducto_Click(sender As Object, e As EventArgs) Handles ButtonModificarProducto.Click
        'TODO HACER EL FORM DE CREACION DE CLIENTES
        Dim f2 As New FormClienteNuevo()
        f2.Text = "Modificando " + nombreClienteSelecionado
        If (f2.ShowDialogModificar(codigoClienteSelecionado) = DialogResult.OK) Then

            cargarDatos()

        End If
    End Sub
End Class