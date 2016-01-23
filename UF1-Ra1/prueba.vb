Public Class prueba
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim np As Integer
        Dim r As New Random
        Dim salida As String = " "
        Dim i, j As Integer
        Dim tablero(10, 10) As Integer
        Dim ng As Integer
        Dim cnte As Integer


        For i = 0 To 9
            For j = 0 To 9
                ng = r.Next(0, 10)
                If ng < 5 Then
                    tablero(i, j) = 0
                ElseIf ng >= 5 And ng < 7 Then
                    tablero(i, j) = 1
                ElseIf ng >= 7 And ng < 9 Then
                    tablero(i, j) = 2
                Else
                    tablero(i, j) = 3
                End If

                salida = salida + tablero(i, j).ToString + "  "
            Next
            salida = salida + vbNewLine
        Next
        salida = salida + vbNewLine
        MessageBox.Show(salida)

        i = r.Next(0, 11)
        j = r.Next(0, 11)


        Do
            MessageBox.Show(tablero(i, j).ToString + "   " + "i = " + i.ToString + "  j = " + j.ToString)
            np = r.Next(1, 5)
                Select Case np
                    Case 1
                    i = i - 1
                    MessageBox.Show("La hormiga da un paso arriba")
                    If i < 0 Then
                        MessageBox.Show("La hormiga esta harta de pasear y se va a su casa")
                        Exit Do
                    End If

                Case 2
                    i = i + 1
                    MessageBox.Show("La hormiga da un paso a abajo")
                    If i > 11 Then
                        MessageBox.Show("La hormiga esta harta de pasear y se va a su casa")
                        Exit Do
                    End If


                Case 3
                    j = j - 1
                    MessageBox.Show("La hormga da un paso a la izquierda")
                    If j < 0 Then
                        MessageBox.Show("La hormiga esta harta de pasear y se va a su casa")
                        Exit Do
                    End If

                Case 4
                    j = j + 1
                    MessageBox.Show("La hormiga da un a la derecha")
                    If i > 11 Then
                        MessageBox.Show("La hormiga esta harta de pasear y se va a su casa")
                        Exit Do
                    End If

            End Select
            Loop

    End Sub
    Public Class borrachera
        Dim cnte As Integer



    End Class

End Class