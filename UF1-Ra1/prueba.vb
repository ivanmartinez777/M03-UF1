Public Class prueba
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim np As Integer
        Dim r As New Random
        Dim salida As String = " "
        Dim i, j As Integer
        Dim tablero(10, 10) As Integer
        Dim ng As Integer
        Dim cnte As Integer = 0


        For i = 0 To 10
            For j = 0 To 10
                ng = r.Next(0, 10)
                'If ng < 4 Then
                tablero(i, j) = 0 '
                If ng >= 0 And ng < 5 Then
                    tablero(i, j) = 1
                ElseIf ng >= 5 And ng < 8 Then
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
        np = r.Next(1, 5)

        Do
            MessageBox.Show("i = " + i.ToString + "  j = " + j.ToString)

            If cnte > 0 Then
                MessageBox.Show("Vaya pedo lleva la hormiga. Le quedan " + cnte.ToString + " pasos para volver en si")
                np = r.Next(1, 5)
                Select Case np
                    Case 1
                        i = i - 1

                         If i < 0 Then
                        i = 10

                        End If
                        Select Case tablero(i, j)
                            Case 0
                                salida = "nada"

                            Case 1
                                salida = "azucar. Se lo come y sigue su camino"
                                tablero(i, j) = 0
                            Case 2
                                salida = "azucar y vino. Se lo come y sigue su camino"
                                tablero(i, j) = 0
                                cnte = cnte + 2
                            Case 3
                                MessageBox.Show("La hormiga borracha, ha comido veneno. R.I.P hormiga")
                                Exit Do

                        End Select
                        MessageBox.Show("La hormiga da un paso arriba y se encuentra ... " + salida)
                    Case 2
                        i = i + 1

                        i = i Mod 11
                        Select Case tablero(i, j)
                            Case 0
                                salida = "nada"
                            Case 1
                                salida = "azucar. Se lo come y sigue su camino"
                                tablero(i, j) = 0
                            Case 2
                                salida = "azucar y vino. Se lo come y sigue su camino"
                                cnte = cnte + 2
                                tablero(i, j) = 0
                            Case 3
                                MessageBox.Show("La hormiga borracha, ha comido veneno. R.I.P hormiga")
                                Exit Do

                        End Select
                        MessageBox.Show("La hormiga da un paso a abajo y se encuentra... " + salida)

                    Case 3
                        j = j - 1

                        If j < 0 Then
                            j = 10
                        End If
                        Select Case tablero(i, j)
                            Case 0
                                salida = "nada"
                            Case 1
                                salida = "azucar. Se lo come y sigue su camino"
                                tablero(i, j) = 0
                            Case 2
                                salida = "azucar y vino. Se lo come y sigue su camino"
                                cnte = cnte + 2
                                tablero(i, j) = 0
                            Case 3
                                MessageBox.Show("La hormiga borracha, ha comido veneno. R.I.P hormiga")
                                Exit Do

                        End Select
                        MessageBox.Show("La hormiga da un paso a la izquierda y se encuentra..." + salida)
                    Case 4
                        j = j + 1

                        j = j Mod 11
                        Select Case tablero(i, j)
                            Case 0
                                salida = "nada"
                            Case 1
                                salida = "azucar. Se lo come y sigue su camino"
                                tablero(i, j) = 0
                            Case 2
                                salida = "azucar y vino. Se lo come y sigue su camino"
                                cnte = cnte + 2
                                tablero(i, j) = 0
                            Case 3
                                MessageBox.Show("La hormiga borracha, ha comido veneno. R.I.P hormiga")
                                Exit Do

                        End Select
                        MessageBox.Show("La hormiga da un paso a la derecha y se encuentra ..." + salida)
                End Select
                cnte = cnte - 1

            Else


                Select Case np
                    Case 1
                        i = i - 1

                        If i < 0 Then
                            i = 10
                        End If
                        Select Case tablero(i, j)
                            Case 0
                                salida = "nada"
                            Case 1
                                salida = "azucar. Se lo come y sigue su camino"
                                tablero(i, j) = 0
                            Case 2
                                salida = "azucar y vino. Se lo come y sigue su camino"
                                tablero(i, j) = 0
                                cnte = cnte + 2
                            Case 3
                                salida = "azucar y veneno. No se lo come"


                        End Select
                        MessageBox.Show("La hormiga da un paso arriba y se encuentra ... " + salida)
                    Case 2
                        i = i + 1

                        i = i Mod 11
                        Select Case tablero(i, j)
                            Case 0
                                salida = "nada"
                            Case 1
                                salida = "azucar. Se lo come y sigue su camino"
                                tablero(i, j) = 0
                            Case 2
                                salida = "azucar y vino. Se lo come y sigue su camino"
                                tablero(i, j) = 0
                                cnte = cnte + 2
                            Case 3
                                salida = "azucar y veneno. No se lo come"

                        End Select
                        MessageBox.Show("La hormiga da un paso a abajo y se encuentra... " + salida)

                    Case 3
                        j = j - 1

                        If j < 0 Then
                            j = 10
                        End If
                        Select Case tablero(i, j)
                            Case 0
                                salida = "nada"
                            Case 1
                                salida = "azucar. Se lo come y sigue su camino"
                                tablero(i, j) = 0
                            Case 2
                                salida = "azucar y vino. Se lo come y sigue su camino"
                                tablero(i, j) = 0
                                cnte = cnte + 2
                            Case 3
                                salida = "azucar y veneno. No se lo come"

                        End Select
                        MessageBox.Show("La hormiga da un paso a la izquierda y se encuentra..." + salida)
                    Case 4
                        j = j + 1

                        j = j Mod 11
                        Select Case tablero(i, j)
                            Case 0
                                salida = "nada"
                            Case 1
                                salida = "azucar. Se lo come y sigue su camino"
                                tablero(i, j) = 0
                            Case 2
                                salida = "azucar y vino. Se lo come y sigue su camino"
                                tablero(i, j) = 0
                                cnte = cnte + 2
                            Case 3
                                salida = "azucar y veneno. No se lo come"

                        End Select
                        MessageBox.Show("La hormiga da un paso a la derecha y se encuentra ..." + salida)
                End Select
            End If
        Loop
        For i = 0 To 10
            For j = 0 To 10
                salida = salida + tablero(i, j).ToString + "  "
            Next
            salida = salida + vbNewLine
        Next
        MessageBox.Show(salida)
    End Sub

End Class