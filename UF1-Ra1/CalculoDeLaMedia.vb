Public Class CalculoDeLaMedia
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nota As Integer
        Dim sumaTotal As Double = 0
        Dim cnt As Integer
        Dim media As Double



        For cnt = 0 To 9
            'ponemos de 0 a 9 porque serán 10 notas

            nota = InputBox("introduce la nota")
            sumaTotal = sumaTotal + nota
        Next

        media = sumaTotal / 10

        MessageBox.Show(media.ToString)


    End Sub
End Class