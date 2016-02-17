Public Class Calculadora_nueva
    Dim n1 As Integer
    Dim n2 As Integer
    Dim salida As String
    Dim resultado As Integer
    Dim operacion As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        salida = salida + "1"
        Label1.Text = salida
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        salida = salida + "2"
        Label1.Text = salida
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        n1 = CInt(salida)
        operacion = 1
        salida = ""


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        n2 = CInt(salida)
        Select Case operacion
            Case 1
                resultado = n1 + n2
            Case 2
                resultado = n1 - n2
            Case 3
                resultado = n1 * n2
            Case 4
                resultado = n1 / n2
            Case 5
                resultado = n1 ^ 2
            Case 6
                resultado = n1 ^ n2
        End Select
        salida = resultado.ToString
        Label1.Text = resultado.ToString
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        salida = salida + "3"
        Label1.Text = salida
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        salida = salida + "4"
        Label1.Text = salida
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        salida = salida + "5"
        Label1.Text = salida
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        salida = salida + "6"
        Label1.Text = salida
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        salida = salida + "7"
        Label1.Text = salida
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        salida = salida + "8"
        Label1.Text = salida
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        salida = salida + "9"
        Label1.Text = salida
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        salida = salida + "0"
        Label1.Text = salida
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        n1 = CInt(salida)
        operacion = 2
        salida = ""
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        n1 = CInt(salida)
        operacion = 3
        salida = ""
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        n1 = CInt(salida)
        operacion = 4
        salida = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        n1 = 0
        n2 = 0
        operacion = 0
        salida = ""
        Label1.Text = ""

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

        n1 = CInt(salida)
        resultado = n1 ^ 2

        salida = resultado.ToString
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        n1 = CInt(salida)
        operacion = 6
        salida = ""
    End Sub
End Class