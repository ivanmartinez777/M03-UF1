Public Class SumarIntervalos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim suma As Integer = 0
        Dim cnt As Integer
        Dim intervalo As Integer


        num1 = InputBox("Introduce un número")
        num2 = InputBox("Introduce otre número")

        intervalo = num2 - num1


        For cnt = 1 To intervalo

            suma = suma + (num1 + cnt)

        Next
        MessageBox.Show(suma.ToString)


    End Sub
End Class