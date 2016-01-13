Public Class Repaso_1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dada una tabla de 5x5, rellenar con 0 excepto la cruz del medio que será con 1"
        Dim v(4, 4) As Integer
        Dim i, j As Integer
        Dim salida As String

        For i = 0 To 4


            For j = 0 To 4
                If (i = 2 Or j = 2) Then
                    v(i, j) = 1
                Else
                    v(i, j) = 0
                End If
                salida = salida + v(i, j).ToString + " "

            Next
            salida = salida + vbNewLine
        Next

        MessageBox.Show(salida)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'rellenar una tabla de 5 x 5 con números aleatoris y sumar unicamente los números de los bordes"

        Dim r As New Random
        Dim v(4, 4) As Integer
        Dim i, j As Integer
        Dim suma As Integer
        Dim salida As String
        Dim resultado As String


        For i = 0 To 4
            For j = 0 To 4
                v(i, j) = r.Next(1, 10)
                salida = salida + v(i, j).ToString + " "
                If i = 0 Or i = 4 Or j = 0 Or j = 4 Then
                    suma = suma + v(i, j)
                End If

            Next
            salida = salida + vbNewLine

        Next
        MessageBox.Show(salida + "la suma de el borde es " + " " + suma.ToString)
    End Sub
End Class