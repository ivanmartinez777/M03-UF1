Public Class Entrega_Arrays
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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
                matriz(i, j) = r.Next(0, 100)
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
            salidaF = salidaF + sumaF.ToString + " "

        Next

        For j = 0 To 9
            sumaC = 0
            For i = 0 To 9

                sumaC = sumaC + matriz(i, j)

            Next
            salidaC = salidaC + sumaC.ToString + " "

        Next


        MessageBox.Show("La suma de las filas es :" + " " + salidaF.ToString + vbNewLine + "La suma de las columnas es:" + " " + salidaC.ToString)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim diagonal(4, 4) As Integer
        Dim i, j As Integer
        Dim salida As String = ""

        For i = 0 To 4
            For j = 0 To 4
                If i = j Then
                    diagonal(i, j) = 0
                Else
                    diagonal(i, j) = 1
                End If
                salida = salida + diagonal(i, j).ToString + " "
            Next
            salida = salida + vbNewLine
        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim tabla(19) As Integer
        Dim cnt As Integer
        Dim salida As String
        Dim cnt0 As Integer = 0

        For cnt = 0 To tabla.Length - 1
            Randomize()
            tabla(cnt) = Rnd() * 100

        Next
        For cnt = 0 To 19
            If tabla(cnt) > 30 Then
                salida = salida + " " + tabla(cnt).ToString + " " + cnt.ToString + " " + Environment.NewLine
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim vector(14) As Integer
        Dim n As Integer
        Dim cnt As Integer
        Dim salida As String
        Dim suma As String
        Dim r As New Random
        Dim min As Integer
        Dim max As Integer

        min = InputBox("introduce el número menor")
        max = InputBox("introduce el número mayor")



        For cnt = 0 To 14
            vector(cnt) = r.Next(min, max)
            salida = salida + " " + vector(cnt).ToString + " " + Environment.NewLine
        Next

        n = InputBox("introduce un número menor que 15")

        For cnt = 0 To n - 1
            suma = suma + vector(cnt)

        Next

        MessageBox.Show(salida.ToString + suma.ToString)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim numeros(9) As Integer
        Dim n2 As Integer
        Dim n3 As Integer
        Dim cnt As Integer
        Dim salida As String
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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
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

    Private Sub Button9_Click(sender As Object, e As EventArgs) 
        Dim vector(9) As Integer
        Dim cnt As Integer
        Dim suma As Integer

        Dim par(9) As Integer
        Dim impar(9) As Integer
        Dim cntp As Integer
        Dim cnti As Integer



        For cnt = 0 To 9
            vector(cnt) = InputBox("Introduce un número")


        Next

        For cnt = 0 To 9
            If vector(cnt) Mod 2 = 0 Then
                par(cntp) = vector(cnt)
                cntp = cntp + 1

            ElseIf vector(cnt) Mod 2 <> 0 Then


                impar(cnti) = vector(cnt)
                cnti = cnti + 1


            End If

        Next

        MessageBox.Show(impar(cnti))



        For cnt = 0 To 9
            suma = par(cntp) + impar(cnti)

            MessageBox.Show(suma)
        Next



    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) 
        Dim vector(9) As Integer
        Dim cnt As Integer = 0
        Dim suma As Integer = 0
        Dim salida As String = ""

        For cnt = 0 To 9
            vector(cnt) = InputBox("Introduce un número")
        Next

        For cnt = 0 To 9

        Next


        MessageBox.Show(suma)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim vector(4) As Integer
        Dim cnt As Integer
        Dim suma As Integer
        Dim salida As String

        For cnt = 0 To 4
            vector(cnt) = InputBox("Introduce un numero")


        Next
        suma = vector(0)

        For cnt = 1 To 4
            suma = suma + vector(cnt)
            salida = salida + " " + suma.ToString + " " + vbNewLine

        Next

        MessageBox.Show(salida)

    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        Dim r As New Random
        Dim vector(9) As Integer

        Dim cnt As Integer

        Dim min As Integer
        Dim salida As String
        Dim indice As String
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

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim v(4) As Integer
        Dim w(4) As Integer
        Dim x(4) As Integer
        Dim salida As String
        For cnt = 0 To 4
            v(cnt) = InputBox("introduce un número para la variable v")
            w(cnt) = InputBox("introduce un número para la variable w")

        Next


        For cnt = 0 To 4
            x(cnt) = v(cnt) + w(cnt)
            salida = salida + x(cnt).ToString + vbNewLine

        Next
        MessageBox.Show(salida)
    End Sub
End Class