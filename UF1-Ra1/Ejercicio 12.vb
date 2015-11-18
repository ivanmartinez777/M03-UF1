Public Class Ejercicio_12
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cnt As Integer = 1
        Dim suma As Integer = 0
        Dim n As Integer

        n = InputBox("introduce un numero mayor que 0")

        If n <= 0 Then
            MessageBox.Show("error, el número es menor que 0")
        Else


            While cnt <= n
                suma = suma + (cnt)
                cnt = cnt + 1

            End While
        End If
        MessageBox.Show(suma.ToString)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cnt As Integer = 1
        Dim suma As Integer = 0
        Dim n As Integer

        n = InputBox("Elige un número mayor que 0")

        If n < 0 Then
            MessageBox.Show("error, el número es menor que 0")
        Else

            Do While cnt <= n
                suma = suma + cnt
                cnt = cnt + 1
            Loop
        End If
        MessageBox.Show(suma)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cnt As Integer
        Dim suma As Integer
        Dim n As Integer

        n = InputBox("introduce un número mayor que 0")

        If n <= 0 Then
            MessageBox.Show("error, introduce un número mayor que 0")
        Else
            For cnt = 1 To n
                suma = suma + cnt

            Next
        End If
        MessageBox.Show(suma)
    End Sub
End Class