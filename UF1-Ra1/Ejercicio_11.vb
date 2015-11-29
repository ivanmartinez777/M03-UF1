Public Class Ejercicio_11
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Resultado As Integer = 0
        Dim Numero As Integer
        Dim cnt As Integer = 1


        Numero = InputBox("introduce un número")

        Do While cnt <= Numero
            Resultado = Resultado + (cnt * 2)
            cnt = cnt + 1
        Loop


        MessageBox.Show(Resultado)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Resultado As Integer = 0
        Dim Numero As Integer
        Dim cnt As Integer = 1


        Numero = InputBox("introduce un número")

        While cnt <= Numero
            Resultado = Resultado + (cnt * 2)
            cnt = cnt + 1
        End While



        MessageBox.Show(Resultado)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Resultado As Integer = 0
        Dim Numero As Integer
        Dim cnt As Integer = 1

        Numero = InputBox("introduce un número")
        For cnt = 0 To Numero
            Resultado = Resultado + (cnt * 2)

        Next


        MessageBox.Show(Resultado)
    End Sub
End Class