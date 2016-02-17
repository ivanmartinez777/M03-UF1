Public Class preparación
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        n = InputBox("introduce las dimensiones de la tabla")
        Dim tabla(n - 1, n - 1) As Integer
        Dim sg(n - 1, n - 1) As Integer
        Dim i, j As Integer
        Dim salida As String = ""
        Dim r As New Random
        Dim max As Integer
        Dim msalida As String = ""
        For i = 0 To n - 1
            For j = 0 To n - 1
                tabla(i, j) = r.Next(0, 10)
                salida = salida + " " + tabla(i, j).ToString
            Next
            salida = salida + vbNewLine
        Next
        MessageBox.Show(salida)

        salida = ""
        For i = 0 To n - 1
            For j = 0 To n - 1
                If i = 0 And j = 0 Then
                    sg(i, j) = tabla(i, j + 1) + tabla(i + 1, j + 1) + tabla(i + 1, j)

                ElseIf i = 0 And j = n - 1 Then
                    sg(i, j) = tabla(i, j - 1) + tabla(i + 1, j - 1) + tabla(i + 1, j)

                ElseIf i = 0 And j <> 0 And j <> n - 1 Then
                    sg(i, j) = tabla(i, j - 1) + tabla(i + 1, j - 1) + tabla(i + 1, j) + tabla(i + 1, j + 1) +
                    tabla(i, j + 1)

                ElseIf j = 0 And i <> 0 And i <> n - 1 Then
                    sg(i, j) = tabla(i - 1, j) + tabla(i - 1, j + 1) + tabla(i, j + 1) + tabla(i + 1, j + 1) + tabla(i + 1, j)

                ElseIf j = 0 And i = n - 1 Then
                    sg(i, j) = tabla(i - 1, j) + tabla(i - 1, j + 1) + tabla(i, j + 1)

                ElseIf i = n - 1 And j <> 0 And j <> n - 1 Then
                    sg(i, j) = tabla(i, j - 1) + tabla(i - 1, j - 1) + tabla(i - 1, j) + tabla(i - 1, j + 1) + tabla(i, j + 1)

                ElseIf i = n - 1 And j = n - 1 Then
                    sg(i, j) = tabla(i, j - 1) + tabla(i - 1, j - 1) + tabla(i - 1, j)

                ElseIf j = n - 1 And i <> 0 And i <> n - 1 Then
                    sg(i, j) = tabla(i + 1, j) + tabla(i + 1, j - 1) + tabla(i, j - 1) + tabla(i - 1, j - 1) + tabla(i - 1, j)

                Else
                    sg(i, j) = tabla(i - 1, j - 1) + tabla(i - 1, j) + tabla(i - 1, j + 1) + tabla(i, j - 1) + tabla(i, j + 1) + tabla(i + 1, j - 1) +
                        tabla(i + 1, j) + tabla(i + 1, j + 1)



                End If
            Next
        Next




        max = sg(0, 0)
        For i = 0 To n - 1
            For j = 0 To n - 1
                salida = salida + sg(i, j).ToString + "  "
                If sg(i, j) > max Then
                    max = sg(i, j)
                    msalida = "El elemento que obtiene la mayor suma de sus elementos vecinos es: " + max.ToString + " " + i.ToString + "," + j.ToString

                End If
            Next
            salida = salida + vbNewLine
        Next


        MessageBox.Show(salida + vbNewLine + msalida)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim alarma As Boolean
        Dim salida As String = ""
        Dim s1, s2, s3 As Integer
        Dim r As New Random

        s1 = r.Next(0, 2)
        s2 = r.Next(0, 2)
        s3 = r.Next(0, 2)
        MessageBox.Show(s1.ToString + " " + s2.ToString + " " + s3.ToString)
        If s2 = 1 And (s1 = 0 Or s1 = 1) And (s3 = 0 Or s3 = 1) Then
            alarma = True
            salida = "alarma activada"
        Else
            alarma = False
            salida = "alarma no activada"
        End If

        MessageBox.Show(salida)





    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim n1, n2, n3 As Integer
        Dim salida As String = ""
        Dim min, max, mid As Integer

        n1 = InputBox("introduce un numero")
        n2 = InputBox("introduce un numero")
        n3 = InputBox("introduce un numero")

        If n1 < n2 And n1 < n3 Then
            min = n1
        ElseIf n2 < n1 And n2 < n3 Then
            min = n2
        Else
            min = n3
        End If
        If n1 > n2 And n1 > n3 Then
            max = n1
        ElseIf n2 > n1 And n2 > n3 Then
            max = n2
        Else
            max = n3
        End If
        If n1 <> min And n1 <> max Then
            mid = n1
        ElseIf n2 <> min And n2 <> max Then
            mid = n2
        Else
            mid = n3
        End If

        MessageBox.Show(min.ToString + " " + mid.ToString + " " + max.ToString)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cnt As Integer
        Dim cuadrado As Integer
        Dim salida As String = ""

        For cnt = 0 To 99
            cuadrado = (cnt + 1) ^ 2
            salida = salida + (cnt + 1).ToString + " " + cuadrado.ToString + vbNewLine
        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim a, b, c As Double
        Dim salida As String = ""
        Dim cnt As Integer

        a = 0
        b = 1


        For cnt = 0 To 97
            If a = 0 Then
                salida = salida + a.ToString + " " + b.ToString
            End If
            c = a + b
            salida = salida + " " + c.ToString
            a = b
            b = c
        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim i, j As Integer
        Dim tabla(2, 2) As Integer
        Dim salida As String = ""
        Dim r As New Random

        For i = 0 To 2
            For j = 0 To 2
                tabla(i, j) = r.Next(0, 2)

            Next

        Next
        salida = "es simetrica"
        For i = 0 To 2
            For j = 0 To 2
                If tabla(i, j) <> tabla(j, i) Then
                    salida = "No es simetrica"
                    Exit For
                End If
            Next
        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim n As Integer
        n = InputBox(" ")
        Dim factorial As Integer = n
        Dim f As Integer = n - 1

        Do Until f = 0
            factorial = factorial * f
            f = f - 1

        Loop

        MessageBox.Show(factorial.ToString)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim i, j As Integer
        Dim tabla(9, 9) As Integer
        Dim suma As Integer

        For i = 0 To 9
            For j = 0 To 9
                tabla(i, j) = 1
            Next
        Next

        For i = 0 To 9
            For j = 0 To 9
                suma = suma + tabla(i, j)
            Next
        Next
        MessageBox.Show(suma.ToString)
    End Sub
End Class