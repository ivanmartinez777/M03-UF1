Public Class Boletin7vb
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim matriz(3, 3) As Integer

        Dim i, j As Integer
        Dim sumaF As Integer
        Dim sumaC As Integer
        Dim salidaF As String = ""
        Dim salidaC As String = ""
        Dim r As New Random



        For i = 0 To 3
            For j = 0 To 3
                matriz(i, j) = r.Next(0, 100)
            Next

        Next

        For i = 0 To 3
            sumaF = 0
            For j = 0 To 3

                sumaF = sumaF + matriz(i, j)

            Next
            salidaF = salidaF + sumaF.ToString + " "

        Next

        For j = 0 To 3
            sumaC = 0
            For i = 0 To 3

                sumaC = sumaC + matriz(i, j)

            Next
            salidaC = salidaC + sumaC.ToString + " "

        Next


        MessageBox.Show("La suma de las filas es :" + " " + salidaF.ToString + vbNewLine + "La suma de las columnas es:" + " " + salidaC.ToString)
    End Sub
End Class