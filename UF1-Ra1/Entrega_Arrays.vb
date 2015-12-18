Public Class Entrega_Arrays
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim matriz(3, 3) As Integer

        Dim i, j As Integer
        Dim sumaF As Integer
        Dim sumaC As Integer
        Dim salidaF As String = ""
        Dim salidaC As String = ""
        Dim r As New Random



        For i = 0 To 3
            For j = 0 To 3
                matriz(i, j) = r.Next(0, 100)
            Next

        Next

        For i = 0 To 3
            sumaF = 0
            For j = 0 To 3

                sumaF = sumaF + matriz(i, j)

            Next
            salidaF = salidaF + sumaF.ToString + " "

        Next

        For j = 0 To 3
            sumaC = 0
            For i = 0 To 3

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
End Class