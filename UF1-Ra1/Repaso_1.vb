Public Class Repaso_1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dada una tabla de 5x5, rellenar con 0 excepto la cruz del medio que será con 1"
        Dim v(4, 4) As Integer
        Dim i, j As Integer
        Dim salida As String = ""

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
        Dim suma As Integer = 0
        Dim salida As String = " "
        Dim resultado As String = ""


        For i = 0 To 4
            For j = 0 To 4
                v(i, j) = r.Next(1, 10)
                salida = salida + v(i, j).ToString + " "
                If i = 0 Or i = 4 Or j = 0 Or j = 4 Then
                    suma = suma + v(i, j)
                    'o suma += v(i,j)
                End If

            Next
            salida = salida + vbNewLine

        Next
        MessageBox.Show(salida + "la suma de los bordes es " + " " + suma.ToString)
    End Sub

    Private Function imprimir(ByVal tabla(,) As Integer, ByVal filas As Integer, ByVal cols As Integer)
        Dim salida As String = " "
        Dim i, j As Integer
        For i = 0 To filas
            For j = 0 To cols
                salida += tabla(i, j).ToString + " "
            Next
            salida += vbNewLine
        Next
        Return salida

    End Function


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'dos arrays con las mismas dimensiones que se sumaran
        Dim tabla1(4, 4) As Integer
        Dim tabla2(4, 4) As Integer
        Dim tablas(4, 4) As Integer
        Dim i, j As Integer
        Dim r As New Random
        Dim salida As String = " "
        Dim salida1 As String = " "
        Dim salida2 As String = " "
        For i = 0 To 4
            For j = 0 To 4
                tabla1(i, j) = r.Next(0, 9)
                salida1 = salida1 + tabla1(i, j).ToString + " "
                tabla2(i, j) = r.Next(0, 9)
                salida2 = salida2 + tabla2(i, j).ToString + " "
                tablas(i, j) = tabla1(i, j) + tabla2(i, j)
                salida = salida + tablas(i, j).ToString + " "
            Next
            salida1 = salida1 + vbNewLine
            salida2 = salida2 + vbNewLine
            salida = salida + vbNewLine
        Next
        MessageBox.Show(salida1 + vbNewLine + vbNewLine + salida2 + vbNewLine + vbNewLine + salida)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim tabla1(4, 4) As Integer
        Dim tabla2(4, 4) As Integer
        Dim tabla3(4, 4) As Integer
        Dim i, j As Integer
        Dim r As New Random
        Dim salida1, salida2, salida3 As String

        For i = 0 To 4
            For j = 0 To 4
                tabla1(i, j) = r.Next(0, 9)
                tabla2(i, j) = r.Next(0, 9)

            Next
        Next

        For i = 0 To 4
            For j = 0 To 4
                tabla3(i, j) = tabla1(i, j) + tabla2(i, j)

            Next
        Next


        salida1 = Me.imprimir(tabla1, 4, 4)
        salida2 = Me.imprimir(tabla2, 4, 4)
        salida3 = Me.imprimir(tabla3, 4, 4)

        MessageBox.Show(salida1 + vbNewLine + salida2 + vbNewLine + salida3 + vbNewLine)
    End Sub
End Class