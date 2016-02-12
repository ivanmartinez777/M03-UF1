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
                    msalida = "El elemento que obtiene la mayor suma de sus elementos vecinos es: " + i.ToString + "," + j.ToString

                End If
            Next
            salida = salida + vbNewLine
        Next


        MessageBox.Show(salida + vbNewLine + msalida)



    End Sub
End Class