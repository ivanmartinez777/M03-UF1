Public Class Entrega_Arrays
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Ejercicio7.Click

        Dim matriz(9, 9) As Integer

        Dim i, j As Integer
        Dim sumaF As Integer
        Dim sumaC As Integer
        Dim salidaF As String = ""
        Dim salidaC As String = ""
        Dim salida As String = ""
        Dim r As New Random



        For i = 0 To 9
            For j = 0 To 9
                matriz(i, j) = r.Next(0, 99)
                salida = salida + " " + matriz(i, j).ToString
            Next
            salida = salida + vbNewLine
        Next
        MessageBox.Show(salida)


        For i = 0 To 9
            sumaF = 0
            For j = 0 To 9

                sumaF = sumaF + matriz(i, j)

            Next
            salidaF = salidaF + "fila" + i.ToString + "= " + sumaF.ToString + " "

        Next

        For j = 0 To 9
            sumaC = 0
            For i = 0 To 9

                sumaC = sumaC + matriz(i, j)

            Next
            salidaC = salidaC + "columna" + j.ToString + "= " + sumaC.ToString + " "

        Next


        MessageBox.Show("La suma de las filas es :" + " " + salidaF.ToString + vbNewLine + "La suma de las columnas es:" + " " + salidaC.ToString)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Ejercicio6.Click
        Dim diagonal(4, 4) As Integer
        Dim i, j As Integer
        Dim salida As String = ""

        For i = 0 To 4
            For j = 0 To 4
                If i = j Then
                    diagonal(i, j) = 1
                Else
                    diagonal(i, j) = 0
                End If
                salida = salida + diagonal(i, j).ToString + " "
            Next
            salida = salida + vbNewLine
        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Ejercicio5.Click
        Dim tabla(9, 9) As Integer
        Dim i, j As Integer
        Dim salida As String = ""

        For i = 0 To 9
            For j = 0 To 9
                If i Mod 2 = 0 Then
                    tabla(i, j) = 1
                Else
                    tabla(i, j) = 0

                End If
                salida = salida + tabla(i, j).ToString + " "
            Next
            salida = salida + vbNewLine
        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Ejercicio3.Click
        Dim tabla(19) As Integer
        Dim cnt As Integer
        Dim salida As String = ""
        Dim cnt0 As Integer = 0
        Dim r As New Random

        For cnt = 0 To tabla.Length - 1
            tabla(cnt) = r.Next(0, 100)

        Next
        For cnt = 0 To 19
            If tabla(cnt) > 30 Then
                salida = salida + " " + tabla(cnt).ToString + " " + " cuya posición en la tabla es " + cnt.ToString + " " + Environment.NewLine
            Else
                cnt0 = cnt0 + 1
            End If
        Next
        If cnt0 = 20 Then
            MessageBox.Show("NO HAY NUMEROS MAYORES DE 30")
        Else
            MessageBox.Show(salida.ToString)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Ejercicio2.Click
        Dim vector(14) As Integer
        Dim n As Integer
        Dim cnt As Integer
        Dim salida As String = ""
        Dim suma As Integer
        Dim r As New Random






        For cnt = 0 To 14
            vector(cnt) = r.Next(0, 9)
            salida = salida + " " + vector(cnt).ToString + " " + Environment.NewLine
        Next

        n = InputBox("introduce un número menor que 15")

        For cnt = 0 To n - 1
            suma = suma + vector(cnt)

        Next

        MessageBox.Show(salida.ToString + vbNewLine + "La suma de los " + n.ToString + " primeros números es: " + suma.ToString)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Ejercicio1.Click
        Dim numeros(9) As Integer
        Dim n2 As Integer
        Dim n3 As Integer
        Dim cnt As Integer
        Dim salida As String = ""
        For cnt = 0 To 9
            numeros(cnt) = InputBox("introduce un numero diferente de 0")


        Next
        For cnt = 0 To 9
            n2 = numeros(cnt) ^ 2
            n3 = numeros(cnt) ^ 3
            salida = salida + (numeros(cnt).ToString + " " + n2.ToString + " " + n3.ToString + Environment.NewLine())
        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Ejercicio8.Click
        Dim marco(4, 14) As Integer
        Dim i, j As Integer
        Dim salida As String = ""

        For i = 0 To 4
            For j = 0 To 14
                marco(i, j) = 0
            Next
        Next

        For i = 0 To 4
            For j = 0 To 14
                If i = 0 Or i = 4 Then
                    marco(i, j) = 1
                End If
                If j = 0 Or j = 14 Then
                    marco(i, j) = 1

                End If
                salida = salida + marco(i, j).ToString
            Next
            salida = salida + vbNewLine

        Next
        MessageBox.Show(salida)
    End Sub




    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Ejercicio10.Click
        Dim vector(4) As Integer
        Dim cnt As Integer
        Dim suma As Integer
        Dim salida As String = ""

        For cnt = 0 To 4
            vector(cnt) = InputBox("Introduce un numero")


        Next
        suma = vector(0)

        For cnt = 1 To 4
            suma = suma + vector(cnt)
            salida = salida + "La suma de los " + (cnt + 1).ToString + " primeros números es: " + suma.ToString + " " + vbNewLine

        Next

        MessageBox.Show(salida)

    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Ejercicio11.Click
        Dim r As New Random
        Dim vector(9) As Integer

        Dim cnt As Integer

        Dim min As Integer
        Dim salida As String = ""
        Dim indice As String = ""

        For cnt = 0 To 9
            vector(cnt) = r.Next(0, 100)
            salida = salida + " " + vector(cnt).ToString + " " + vbNewLine


        Next

        min = vector(0)

        For cnt = 1 To 9
            If vector(cnt) < min Then
                min = vector(cnt)
                indice = (cnt)
            End If
        Next
        MessageBox.Show(salida + " La posicion del indice más pequeño es  " + indice.ToString)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Ejercicio13.Click
        Dim v(4) As Integer
        Dim w(4) As Integer
        Dim x(4) As Integer
        Dim salida As String = ""
        For cnt = 0 To 4
            v(cnt) = InputBox("introduce un número para la variable v")


        Next
        For cnt = 0 To 4
            w(cnt) = InputBox("introduce un número para la variable w")


        Next


        For cnt = 0 To 4
            x(cnt) = (v(cnt) + w(cnt))
            salida = salida + x(cnt).ToString + vbNewLine

        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Ejercicio14.Click
        Dim vector(9) As Integer
        Dim cnt As Integer = 0
        Dim salida As String = ""
        Dim num As Integer = 0



        Do Until num < 0 Or cnt > 9
            num = InputBox("Introduce un número positivo")

            vector(cnt) = num
            salida += vector(cnt).ToString + vbNewLine
            cnt = cnt + 1
        Loop

        MessageBox.Show(salida)
    End Sub

    Private Sub Ejercicio15_Click(sender As Object, e As EventArgs) Handles Ejercicio15.Click
        Dim v(4) As Integer
        Dim w(4) As Integer
        Dim x(9) As Integer
        Dim salida As String = " "
        Dim cnt As Integer
        Dim suma As Integer = 0
        Dim num As Integer


        For cnt = 0 To 4
            v(cnt) = InputBox("introduce un número para v")

        Next
        For cnt = 0 To 4
            w(cnt) = InputBox("introduce un número para w")


        Next

        For cnt = 0 To 4
            x(cnt * 2) = v(cnt)
            salida = salida + v(cnt).ToString + vbNewLine
            If cnt = 0 Then
                num = 1
            ElseIf cnt <> 0 Then
                num = 2
            End If
            suma = suma + num
            x(suma) = w(cnt)
            salida = salida + w(cnt).ToString + vbNewLine


        Next


        MessageBox.Show(salida)
    End Sub

    Private Sub Ejercicio12_Click(sender As Object, e As EventArgs) Handles Ejercicio12.Click
        Dim v(4) As Integer
        Dim w(4) As Integer
        Dim cnt As Integer
        Dim num As Integer
        Dim salida As String = " "

        For cnt = 0 To 4
            v(cnt) = InputBox("Introduce un número")
        Next
        cnt = 4
        For num = 0 To 4

            w(num) = v(cnt)
            salida = salida + w(num).ToString + vbNewLine
            cnt = cnt - 1


        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Ejercicio4_Click(sender As Object, e As EventArgs) Handles Ejercicio4.Click
        Dim origen() As Integer = {1, 4, 10, 32, 60, 91, 34, 56, 73, 88, 86}
        Dim destino(9) As Integer
        Dim cnt As Integer
        Dim conta As Integer = 0
        Dim salida As String = " "
        Dim salidades As String = " "

        For cnt = 0 To 10
            salida = salida + origen(cnt).ToString + " "
        Next

        destino(conta) = 0
        For cnt = 0 To 10
            If origen(cnt) > 25 Then
                destino(conta) = origen(cnt)
                salidades = salidades + destino(conta).ToString + " "
                conta = conta + 1
            End If
        Next


        MessageBox.Show(salida + vbNewLine + "Los números mayores que 25 son: " + salidades + vbNewLine)
    End Sub

    Private Sub Ejercicio9_Click(sender As Object, e As EventArgs) Handles Ejercicio9.Click
        Dim par(9) As Integer
        Dim impar(9) As Integer
        Dim suma(9) As Integer
        Dim numero(9) As Integer
        Dim salida As String = " "
        Dim cnt As Integer
        Dim cnti As Integer = 0
        Dim cntp As Integer = 0
        Dim salidap As String = " "
        Dim salidai As String = " "




        For cnt = 0 To 9
            numero(cnt) = InputBox("introduce un numero")
            If numero(cnt) Mod 2 = 0 Then
                par(cntp) = numero(cnt)
                salidap = salidap + par(cntp).ToString + " "
                cntp = cntp + 1

            Else
                impar(cnti) = numero(cnt)
                salidai = salidai + impar(cnti).ToString + " "
                cnti = cnti + 1

            End If
        Next
        cntp = 0
        cnti = 0
        cnt = 0

        For cnt = 0 To 9
            If par(cntp) = 0 And impar(cnti) = 0 Then
                Exit For
            End If
            suma(cnt) = impar(cnti) + par(cntp)
            salida = salida + suma(cnt).ToString + " "
            cntp = cntp + 1
            cnti = cnti + 1
        Next
        MessageBox.Show(" par" + salidap + vbNewLine + "impar" + salidai + vbNewLine + "suma" + salida)

    End Sub

    Private Sub Ejercicio16_Click(sender As Object, e As EventArgs) Handles Ejercicio16.Click
        Dim v(9) As Integer
        Dim i(9) As Integer
        Dim p(9) As Integer
        Dim cnt As Integer
        Dim cntp As Integer
        Dim cnti As Integer
        Dim salida As String = " "
        Dim salidai As String = " "
        Dim salidap As String = " "
        For cnt = 0 To 9
            v(cnt) = InputBox("introduce un numero")
            If v(cnt) Mod 2 = 0 Then
                p(cntp) = v(cnt)

                salidap = salidap + p(cntp).ToString + " "
                cntp += 1
            Else
                i(cnti) = v(cnt)

                salidai = salidai + i(cnti).ToString + " "
                cnti += 1
            End If
            salida = salida + v(cnt).ToString + " "
        Next
        MessageBox.Show(" El vector v es : " + salida + vbNewLine + "el vector p es : " + salidap + vbNewLine + "el vector i es : " + salidai + vbNewLine)
    End Sub

    Private Sub Ejercicio17_Click(sender As Object, e As EventArgs) Handles Ejercicio17.Click
        Dim v(4) As Integer
        Dim may(5) As Integer
        Dim men(5) As Integer
        Dim m As Double
        Dim cnt As Integer
        Dim cntmen As Integer = 0
        Dim cntmay As Integer = 0
        Dim salidamen As String = " "
        Dim salidamay As String = " "


        For cnt = 0 To 4

            v(cnt) = InputBox("Introducza una nota")

            m = (m + v(cnt))
        Next
        m = m / 5
        MessageBox.Show("la media es " + m.ToString)
        For cnt = 0 To 4
            If v(cnt) < m Then
                men(cntmen) = v(cnt)
                salidamen = salidamen + men(cntmen).ToString + " "
                cntmen = cntmen + 1
            Else

                may(cntmay) = v(cnt)
                salidamay = salidamay + may(cntmay).ToString + " "
                cntmay = cntmay + 1
            End If

        Next
        MessageBox.Show("Los mayores son : " + salidamay + vbNewLine + "Los menores son : " + salidamen)

    End Sub

    Private Sub Ejercicio18_Click(sender As Object, e As EventArgs) Handles Ejercicio18.Click
        Dim liminf() As Integer = {0, 1000000, 2500001, 3800001, 6000001}
        Dim limsup() As Integer = {1000000, 2500000, 3800000, 6000000}
        Dim pct() As Integer = {5, 12, 15, 22, 30}
        Dim cnt As Integer
        Dim salario As Integer
        Dim npagas As Integer
        Dim salarioanual As Integer
        Dim salida As String = " "

        salario = InputBox("Introduzca su salario mensual")
        npagas = InputBox("Introduzca el numero de pagas que recibe anualmente")
        salarioanual = salario * npagas

        For cnt = 0 To 4
            If salarioanual > liminf(cnt) And salarioanual < limsup(cnt) Then
                salida = pct(cnt).ToString
                Exit For


            ElseIf salarioanual > limsup(3) Then
                salida = pct(4).ToString
                Exit For
            End If



        Next
        MessageBox.Show("Con un salario de: " + salario.ToString + " " + "en " + npagas.ToString + " pagas anuales" + vbNewLine + "el porcentaje que deberás pagar es de : " + salida + "%")


    End Sub

    Private Sub Ejercicio19_Click(sender As Object, e As EventArgs) Handles Ejercicio19.Click
        Dim nombre(2) As String
        Dim notas(nombre.Length, 1) As Double
        Dim i As Integer
        Dim j As Integer
        Dim final(nombre.Length) As Double
        Dim suma As Double
        Dim sumam As Double
        Dim media(nombre.Length) As Double
        Dim salida As String = ""
        Dim Aprobado As String = " "
        Dim suspendido As String = " "
        Dim nmax As Double = final(0)
        Dim almax As String = " "
        Dim parcial1 As Integer


        For i = 0 To 2
            nombre(i) = InputBox("Introduce un nombre")

            For j = 0 To 1
                notas(i, j) = InputBox("nota")


            Next


        Next


        parcial1 = InputBox("introduce el porcentaje del primer parcial dentro de la nota final")


        For i = 0 To 2
            For j = 0 To 1
                sumam = sumam + (notas(i, j))
                If j = 0 Then
                    notas(i, j) = notas(i, j) * (parcial1 / 100)
                Else
                    notas(i, j) = notas(i, j) * ((100 - parcial1) / 100)
                End If

                suma = suma + notas(i, j)
                final(i) = suma


            Next
            media(i) = sumam / 2
            salida = salida + "La nota final de " + (nombre(i)) + " es " + final(i).ToString + " y la media es de " + media(i).ToString + vbNewLine
            suma = 0
            sumam = 0
        Next

        MessageBox.Show(salida)

        For i = 0 To nombre.Length - 1
            If nmax < final(i) Then
                nmax = final(i)
            End If

        Next
        For i = 0 To nombre.Length - 1
            If final(i) = nmax Then
                almax = almax + nombre(i) + vbNewLine
            End If
        Next


        For i = 0 To nombre.Length - 1

            If final(i) >= 5 Then
                Aprobado = Aprobado + nombre(i) + vbNewLine
            Else
                suspendido = suspendido + nombre(i) + vbNewLine

            End If

        Next


        MessageBox.Show("Aprobados:  " + vbNewLine + Aprobado + vbNewLine + "Suspendidos: " + vbNewLine + suspendido + vbNewLine + "La nota máxima es: " + nmax.ToString + vbNewLine + "Alumnos con la mejor nota: " + vbNewLine + almax
                        )
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim v(4) As Integer
        Dim w(4) As Integer
        Dim x(9) As Integer
        Dim cnt As Integer
        Dim cntw As Integer = 0
        Dim cntv As Integer = 0
        Dim salida As String = " "

        For cnt = 0 To 4
            v(cnt) = InputBox("valor para v")

        Next

        For cnt = 0 To 4

            w(cnt) = InputBox("valor para w")
        Next

        For cnt = 0 To 9
            If cnt Mod 2 = 0 Then
                x(cnt) = v(cntv)
                cntv += 1
            Else
                x(cnt) = w(cntw)
                cntw += 1
            End If
            salida = salida + x(cnt).ToString

        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Ejercicio20_Click(sender As Object, e As EventArgs) Handles Ejercicio20.Click
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
        salida = " "
        For i = 0 To 10
            For j = 0 To 10
                salida = salida + tablero(i, j).ToString + "  "
            Next
            salida = salida + vbNewLine
        Next
        MessageBox.Show(salida)
    End Sub

End Class