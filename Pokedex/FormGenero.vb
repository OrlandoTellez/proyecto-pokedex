Imports System.Reflection.Emit
Imports Dominio

Public Class FormGenero
    Private Sub FormGenero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDialogo.Text = dialogos(indiceDialogo)
        imgChico.Visible = False
        imgChica.Visible = False
        lblChico.Visible = False
        lblChica.Visible = False
    End Sub


    Dim dialogos As List(Of String) = New List(Of String) From {
        "Hola, un gusto, gracias por acompañarme a esta aventura...",
        "soy el profesor",
        "para empezar necesito que me brindes algunos datos sobre ti..."
    }

    Dim indiceDialogo As Integer = 0


    Private Sub lblDialogo_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub FormGenero_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        indiceDialogo += 1

        If indiceDialogo < dialogos.Count Then
            lblDialogo.Text = dialogos(indiceDialogo)
        Else
            imgProfesor.Visible = False
            imgChica.Visible = True
            imgChico.Visible = True
            lblChico.Visible = True
            lblChica.Visible = True
            lblDialogo.Text = "Que eres?..........."
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    ' Parte de eventos+ç

    Dim originalSize As Size
    Private Sub imgChico_MouseEnter(sender As Object, e As EventArgs) Handles imgChico.MouseEnter
        originalSize = imgChico.Size
        imgChico.Size = New Size(imgChico.Width + 10, imgChico.Height + 10)
    End Sub
    Private Sub imgChico_MouseLeave(sender As Object, e As EventArgs) Handles imgChico.MouseLeave
        imgChico.Size = originalSize
    End Sub

    Private Sub imgChica_MouseEnter(sender As Object, e As EventArgs) Handles imgChica.MouseEnter
        originalSize = imgChica.Size
        imgChica.Size = New Size(imgChica.Width + 10, imgChica.Height + 10)
    End Sub

    Private Sub imgChica_MouseLeave(sender As Object, e As EventArgs) Handles imgChica.MouseLeave
        imgChica.Size = originalSize
    End Sub

    Private Sub imgChico_Click(sender As Object, e As EventArgs) Handles imgChico.Click

    End Sub

    Private Sub imgChico_MouseClick(sender As Object, e As MouseEventArgs) Handles imgChico.MouseClick
        VariablesGlobales.sexo = "Chico"
        Dim formnombre As FormNombre = New FormNombre()
        formnombre.ShowDialog()
    End Sub

    Private Sub imgChica_MouseClick(sender As Object, e As MouseEventArgs) Handles imgChica.MouseClick
        VariablesGlobales.sexo = "Chica"
    End Sub
End Class