Public Class Pokedex

    Private mouseloc As Point
    Private idPokemon As Integer = 1

    Private Sub Pokedex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarImagen()
    End Sub


    Private Sub Fondo_MouseDown(sender As Object, e As MouseEventArgs) Handles Fondo.MouseDown

        Dim mouseloc = e.Location

    End Sub

    Private Sub Fondo_MouseMove(sender As Object, e As MouseEventArgs) Handles Fondo.MouseMove

        If e.Button = MouseButtons.Left Then
            Dim dx As Integer = e.Location.X - mouseloc.X
            Dim dy As Integer = e.Location.Y - mouseloc.Y
            dx += Me.Location.X
            dy += Me.Location.Y
            Me.Location = New Point(dx, dy)
        End If
    End Sub

    Private Sub CargarImagen()
        Dim file As String = idPokemon.ToString("000")
        Dim pfile As String = $"Kanto\{file}.png"
    End Sub

    Private Sub Derecha_Click(sender As Object, e As EventArgs) Handles Derecha.Click
        If idPokemon < 151 Then
            idPokemon += 1
            CargarImagen()
        End If
    End Sub

    Private Sub Izquierda_Click(sender As Object, e As EventArgs) Handles Izquierda.Click
        If idPokemon > 1 Then
            idPokemon -= 1
            CargarImagen()
        End If
    End Sub

    Private Sub Apagar_Click(sender As Object, e As EventArgs) Handles Apagar.Click
        Me.Close()
    End Sub
End Class