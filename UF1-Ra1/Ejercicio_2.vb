﻿Public Class Ejercicio_2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer
        Dim n2 As Integer
        Dim r As Integer

        Dim expresion As Boolean

        n1 = CInt(TextBox1.Text)
        n2 = CInt(TextBox2.Text)

        If expresion = n1 / n2 = r Then
            MessageBox.Show("Es divisible")
        Else
            MessageBox.Show("No es divisible")
        End If



    End Sub
End Class