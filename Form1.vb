﻿Imports TrabajoFinal.DataSet1TableAdapters

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim user = TextBoxUsuario.Text
        Dim pass = TextBoxPassword.Text



        Dim foundRows() As DataRow = DataSet1.usuarios.Select("usuario = '" & user & "'")

        If foundRows.Length > 0 Then
            Dim foundRow As DataRow = foundRows(0)


            If foundRow IsNot Nothing Then
                If (foundRow(2).ToString = pass) Then
                    FormMain.Show()
                    Me.Hide()

                Else
                    MsgBox("password incorrecto!")

                End If
            Else
                MsgBox("A row with the primary key of " & user & " could not be found")
            End If
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'DataSet1.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.DataSet1.usuarios)

    End Sub
End Class
