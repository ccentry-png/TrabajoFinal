Imports ZXing

Public Class FormProductoNuevo
    Dim idAModificar As Integer
    Dim modificar As Boolean = False
    Dim barcodeID As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre = TextBox1.Text
        Dim precio As Decimal = NumericUpDown1.Value

        Dim barcode = Nothing
        If CheckBox1.Checked Then
            'TODO agrega barcode
            barcode = barcodeID


        End If


        If modificar = True Then

            ProductosTableAdapter1.UpdateById(nombre, precio, barcode, idAModificar)

        Else

            ProductosTableAdapter1.Insert(NombreProducto:=nombre, Precio:=precio, barcode)

        End If


        modificar = False
        Button1.Text = "Agregar Producto"
        Me.Close()



    End Sub

    Public Function ShowDialogModificar(id As Integer)

        idAModificar = id
        Button1.Text = "Modificar Producto"
        modificar = True


        Return Me.ShowDialog()
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Dim rnd As Random = New Random

            barcodeID = rnd.Next(10000, 99999)

            Dim bw As BarcodeWriter = New BarcodeWriter

            bw.Format = BarcodeFormat.CODABAR
            bw.Options.Width = 100
            bw.Options.Height = 50

            PictureBox1.Image = bw.Write(barcodeID)
        Else
            barcodeID = Nothing
            PictureBox1.Image = Nothing
        End If

    End Sub

    Private Sub FormProductoNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class