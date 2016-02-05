Public Class Ejercicio20Hormiga

    Dim salida As String = " "
    Dim hi, hj As Integer
    Dim tablero(10, 10) As Integer
    Dim recorrido(10, 10) As String
    Dim rsalida As String = " "
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim np As Integer
        Dim r As New Random
        Dim i, j As Integer
        Dim ng As Integer
        Dim cnte As Integer = 0



        For i = 0 To 10
            For j = 0 To 10
                ng = r.Next(0, 10)

                If ng >= 0 And ng < 3 Then
                    tablero(i, j) = 1
                ElseIf ng >= 3 And ng < 8 Then
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






        Me.paseo()

        hi = r.Next(0, 11)
        hj = r.Next(0, 11)
        np = r.Next(1, 5)

        recorrido(hi, hj) = "@"


        Do
            i = hi
            j = hj
            Me.imprimir()
            rsalida = ""

            If cnte > 0 Then
                MessageBox.Show("Vaya pedo lleva la hormiga. Le quedan " + cnte.ToString + " pasos para volver en si")
                np = r.Next(1, 5)
                Select Case np
                    Case 1
                        hi = hi - 1

                        If hi < 0 Then
                            hi = 10

                        End If
                        Select Case tablero(hi, hj)
                            Case 0
                                salida = "nada"

                            Case 1
                                salida = "azucar. Se lo come y sigue su camino"
                                tablero(hi, hj) = 0
                            Case 2
                                salida = "azucar y vino. Se lo come y sigue su camino"
                                tablero(hi, hj) = 0
                                cnte = cnte + 2
                            Case 3
                                MessageBox.Show("La hormiga borracha, ha comido veneno. R.I.P hormiga")
                                Exit Do

                        End Select
                        MessageBox.Show("La hormiga da un paso arriba y encuentra ... " + salida)
                    Case 2
                        hi = hi + 1

                        hi = hi Mod 11
                        Select Case tablero(hi, hj)
                            Case 0
                                salida = "nada"
                            Case 1
                                salida = "azucar. Se lo come y sigue su camino"
                                tablero(hi, hj) = 0
                            Case 2
                                salida = "azucar y vino. Se lo come y sigue su camino"
                                cnte = cnte + 2
                                tablero(hi, hj) = 0
                            Case 3
                                MessageBox.Show("La hormiga borracha, ha comido veneno. R.I.P hormiga")
                                Exit Do

                        End Select
                        MessageBox.Show("La hormiga da un paso a abajo y encuentra... " + salida)

                    Case 3
                        hj = hj - 1

                        If hj < 0 Then
                            hj = 10
                        End If
                        Select Case tablero(hi, hj)
                            Case 0
                                salida = "nada"
                            Case 1
                                salida = "azucar. Se lo come y sigue su camino"
                                tablero(hi, hj) = 0
                            Case 2
                                salida = "azucar y vino. Se lo come y sigue su camino"
                                cnte = cnte + 2
                                tablero(hi, hj) = 0
                            Case 3
                                MessageBox.Show("La hormiga borracha, ha comido veneno. R.I.P hormiga")
                                Exit Do

                        End Select
                        MessageBox.Show("La hormiga da un paso a la izquierda y encuentra..." + salida)
                    Case 4
                        hj = hj + 1

                        hj = hj Mod 11
                        Select Case tablero(hi, hj)
                            Case 0
                                salida = "nada"
                            Case 1
                                salida = "azucar. Se lo come y sigue su camino"
                                tablero(hi, hj) = 0
                            Case 2
                                salida = "azucar y vino. Se lo come y sigue su camino"
                                cnte = cnte + 2
                                tablero(hi, hj) = 0
                            Case 3
                                MessageBox.Show("La hormiga borracha, ha comido veneno. R.I.P hormiga")
                                Exit Do

                        End Select
                        MessageBox.Show("La hormiga da un paso a la derecha y encuentra ..." + salida)
                End Select
                cnte = cnte - 1
                recorrido(hi, hj) = "@"
            Else


                Select Case np
                    Case 1
                        hi = hi - 1

                        If hi < 0 Then
                            hi = 10
                        End If
                        Select Case tablero(hi, hj)
                            Case 0
                                salida = "nada"
                            Case 1
                                salida = "azucar. Se lo come y sigue su camino"
                                tablero(hi, hj) = 0
                            Case 2
                                salida = "azucar y vino. Se lo come y sigue su camino"
                                tablero(hi, hj) = 0
                                cnte = cnte + 2
                            Case 3
                                salida = "azucar y veneno. No se lo come"


                        End Select
                        MessageBox.Show("La hormiga da un paso arriba y encuentra ... " + salida)
                    Case 2
                        hi = hi + 1

                        hi = hi Mod 11
                        Select Case tablero(hi, hj)
                            Case 0
                                salida = "nada"
                            Case 1
                                salida = "azucar. Se lo come y sigue su camino"
                                tablero(hi, hj) = 0
                            Case 2
                                salida = "azucar y vino. Se lo come y sigue su camino"
                                tablero(hi, hj) = 0
                                cnte = cnte + 2
                            Case 3
                                salida = "azucar y veneno. No se lo come"

                        End Select
                        MessageBox.Show("La hormiga da un paso a abajo y encuentra... " + salida)

                    Case 3
                        hj = hj - 1

                        If hj < 0 Then
                            hj = 10
                        End If
                        Select Case tablero(hi, hj)
                            Case 0
                                salida = "nada"
                            Case 1
                                salida = "azucar. Se lo come y sigue su camino"
                                tablero(hi, hj) = 0
                            Case 2
                                salida = "azucar y vino. Se lo come y sigue su camino"
                                tablero(hi, hj) = 0
                                cnte = cnte + 2
                            Case 3
                                salida = "azucar y veneno. No se lo come"

                        End Select
                        MessageBox.Show("La hormiga da un paso a la izquierda y encuentra..." + salida)
                    Case 4
                        hj = hj + 1

                        hj = hj Mod 11
                        Select Case tablero(hi, hj)
                            Case 0
                                salida = "nada"
                            Case 1
                                salida = "azucar. Se lo come y sigue su camino"
                                tablero(hi, hj) = 0
                            Case 2
                                salida = "azucar y vino. Se lo come y sigue su camino"
                                tablero(hi, hj) = 0
                                cnte = cnte + 2
                            Case 3
                                salida = "azucar y veneno. No se lo come"

                        End Select
                        MessageBox.Show("La hormiga da un paso a la derecha y encuentra ..." + salida)
                End Select
                recorrido(hi, hj) = "@"
            End If
        Loop
        salida = " "
        Me.imprimir()
        rsalida = ""
    End Sub



    Private Sub imprimir()
        For i = 0 To 10
            For j = 0 To 10
                rsalida = rsalida + recorrido(i, j).ToString + " "

            Next
            rsalida = rsalida + vbNewLine
        Next
        MessageBox.Show(rsalida)

    End Sub

    Private Sub paseo()
        For hi = 0 To 10
            For hj = 0 To 10
                recorrido(hi, hj) = "# "
            Next
        Next
    End Sub

End Class
