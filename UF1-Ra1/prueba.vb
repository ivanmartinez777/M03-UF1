﻿Public Class prueba
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim np As Integer
        Dim r As New Random
        Dim salida As String = " "
        Dim i, j As Integer
        Dim tablero(10, 10) As Integer
        Dim ng As Integer
        Dim cnte As Integer = 1


        For i = 0 To 9
            For j = 0 To 9
                ng = r.Next(0, 10)
                If ng < 4 Then
                    tablero(i, j) = 0
                ElseIf ng >= 4 And ng < 6 Then
                    tablero(i, j) = 1
                ElseIf ng >= 6 And ng < 8 Then
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
                MessageBox.Show("Vaya pedo lleva la hormiga")
                np = r.Next(1, 5)
                Select Case np
                    Case 1
                        i = i - 1

                        If i < 0 Then
                            MessageBox.Show("La hormiga esta harta de pasear y se va a su casa")
                            Exit Do
                        End If
                        Select Case tablero(i, j)
                            Case 0
                                salida = "nada"
                            Case 1
                                salida = "azucar"
                            Case 2
                                salida = "azucar y vino"
                            Case 3
                                MessageBox.Show("La hormiga borracha, ha comido veneno. R.I.P hormiga")
                                Exit Do

                        End Select
                        MessageBox.Show("La hormiga da un paso arriba y se encuentra ... " + salida)
                    Case 2
                        i = i + 1

                        If i > 10 Then
                            MessageBox.Show("La hormiga esta harta de pasear y se va a su casa")
                            Exit Do
                        End If
                        Select Case tablero(i, j)
                            Case 0
                                salida = "nada"
                            Case 1
                                salida = "azucar"
                            Case 2
                                salida = "azucar y vino"
                            Case 3
                                MessageBox.Show("La hormiga borracha, ha comido veneno. R.I.P hormiga")
                                Exit Do

                        End Select
                        MessageBox.Show("La hormiga da un paso a abajo y se encuentra... " + salida)

                    Case 3
                        j = j - 1

                        If j < 0 Then
                            MessageBox.Show("La hormiga esta harta de pasear y se va a su casa")
                            Exit Do
                        End If
                        Select Case tablero(i, j)
                            Case 0
                                salida = "nada"
                            Case 1
                                salida = "azucar"
                            Case 2
                                salida = "azucar y vino"
                            Case 3
                                MessageBox.Show("La hormiga borracha, ha comido veneno. R.I.P hormiga")
                                Exit Do

                        End Select
                        MessageBox.Show("La hormga da un paso a la izquierda y se encuentra..." + salida)
                    Case 4
                        j = j + 1

                        If j > 10 Then
                            MessageBox.Show("La hormiga esta harta de pasear y se va a su casa")
                            Exit Do
                        End If
                        Select Case tablero(i, j)
                            Case 0
                                salida = "nada"
                            Case 1
                                salida = "azucar"
                            Case 2
                                salida = "azucar y vino"
                            Case 3
                                MessageBox.Show("La hormiga borracha, ha comido veneno. R.I.P hormiga")
                                Exit Do

                        End Select
                        MessageBox.Show("La hormiga da un paso a la derecha y se encuentra ..." + salida)
                End Select


            Else


                Select Case np
                    Case 1
                        i = i - 1

                        If i < 0 Then
                            MessageBox.Show("La hormiga esta harta de pasear y se va a su casa")
                            Exit Do
                        End If
                        Select Case tablero(i, j)
                            Case 0
                                salida = "nada"
                            Case 1
                                salida = "azucar"
                            Case 2
                                salida = "azucar y vino"
                            Case 3
                                salida = "azucar y veneno"

                        End Select
                        MessageBox.Show("La hormiga da un paso arriba y se encuentra ... " + salida)
                    Case 2
                        i = i + 1

                        If i > 10 Then
                            MessageBox.Show("La hormiga esta harta de pasear y se va a su casa")
                            Exit Do
                        End If
                        Select Case tablero(i, j)
                            Case 0
                                salida = "nada"
                            Case 1
                                salida = "azucar"
                            Case 2
                                salida = "azucar y vino"
                            Case 3
                                salida = "azucar y veneno"

                        End Select
                        MessageBox.Show("La hormiga da un paso a abajo y se encuentra... " + salida)

                    Case 3
                        j = j - 1

                        If j < 0 Then
                            MessageBox.Show("La hormiga esta harta de pasear y se va a su casa")
                            Exit Do
                        End If
                        Select Case tablero(i, j)
                            Case 0
                                salida = "nada"
                            Case 1
                                salida = "azucar"
                            Case 2
                                salida = "azucar y vino"
                            Case 3
                                salida = "azucar y veneno"

                        End Select
                        MessageBox.Show("La hormga da un paso a la izquierda y se encuentra..." + salida)
                    Case 4
                        j = j + 1

                        If j > 10 Then
                            MessageBox.Show("La hormiga esta harta de pasear y se va a su casa")
                            Exit Do
                        End If
                        Select Case tablero(i, j)
                            Case 0
                                salida = "nada"
                            Case 1
                                salida = "azucar"
                            Case 2
                                salida = "azucar y vino"
                            Case 3
                                salida = "azucar y veneno"

                        End Select
                        MessageBox.Show("La hormiga da un paso a la derecha y se encuentra ..." + salida)
                End Select
            End If
        Loop

    End Sub
    Public Class borrachera
        Dim cnte As Integer



    End Class

End Class