﻿Public Class SumarIntervalos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim suma As Integer
        Dim cnt As Integer


        num1 = InputBox("Introduce un número")
        num2 = InputBox("Introduce otre número")

        For cnt = num1 To (num2 - 1)

            suma = suma + (cnt + 1)

        Next
        MessageBox.Show(suma.ToString)


    End Sub
End Class