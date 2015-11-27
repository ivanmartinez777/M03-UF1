Public Class EstaArray
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numeros() As Integer = {4, 20, 10, 12, 0, 7}
        Dim buscar As Boolean
        Dim cnt As Integer = 0


        buscar = InputBox("introduce un numero mayor que 0")


        For cnt = 0 To numeros.Length
            buscar = numeros(cnt)




            MessageBox.Show(buscar)
        Next

    End Sub
End Class