﻿Public Class Form1


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub



    ' Parte de eventos+ç
    Dim originalSize As Size
    Private Sub btnCrearPersonaje_MouseEnter(sender As Object, e As EventArgs) Handles btnCrearPersonaje.MouseEnter
        originalSize = btnCrearPersonaje.Size
        btnCrearPersonaje.Size = New Size(btnCrearPersonaje.Width + 10, btnCrearPersonaje.Height + 10)
    End Sub

    Private Sub btnCrearPersonaje_MouseLeave(sender As Object, e As EventArgs) Handles btnCrearPersonaje.MouseLeave
        btnCrearPersonaje.Size = originalSize
    End Sub

    Private Sub btnPokedex_MouseEnter(sender As Object, e As EventArgs)
        originalSize = btnPokedex.Size
        btnPokedex.Size = New Size(btnPokedex.Width + 10, btnPokedex.Height + 10)
    End Sub

    Private Sub btnPokedex_MouseLeave(sender As Object, e As EventArgs)
        btnPokedex.Size = originalSize
    End Sub

    Private Sub btnCrearPersonaje_Click(sender As Object, e As EventArgs) Handles btnCrearPersonaje.Click
        Dim formgenero As FormGenero = New FormGenero()
        formgenero.ShowDialog()

    End Sub
End Class
