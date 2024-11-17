Imports TrabajoFinal.DataSet1TableAdapters

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim user = TextBoxUsuario.Text
        Dim pass = TextBoxPassword.Text

        'buscar usuarios por nombre
        Dim foundRows() As DataRow = DataSet1.usuarios.Select("usuario = '" & user & "'")

        '.Select devuelve array, agarra primer resultado
        If foundRows.Length > 0 Then
            Dim foundRow As DataRow = foundRows(0)


            If foundRow IsNot Nothing Then
                If (foundRow(2).ToString = pass) Then
                    FormMain.Show()
                    Me.Hide()
                    TextBoxUsuario.Text = ""
                    TextBoxPassword.Text = ""

                Else
                    MsgBox("password incorrecto!")

                End If
            Else
                MsgBox("usuario no existe")
            End If
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'DataSet1.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.DataSet1.usuarios)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormProductos.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormClientes.ShowDialog()
    End Sub
End Class
