Public Class Bucles_pares
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim salida1 As String = ""
        Dim pares As Integer

        For pares = 0 To 20 Step 2
            salida1 = salida1 + " " + pares.ToString()
            'ponemos environment.newline para que cada resultado salga en una linea nueva, sino saldrán todos en una misma linea

        Next

        MessageBox.Show(salida1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim salida As String = ""
        Dim cnt As Integer = 0



        While cnt <= 20
            salida = salida + " " + cnt.ToString()

            cnt = cnt + 2


        End While
        MessageBox.Show(salida)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cnt As Integer
        Dim salida As String = ""


        Do While cnt <= 20



            salida = salida + " " + cnt.ToString()

            cnt = cnt + 2

        Loop
        MessageBox.Show(salida)
    End Sub
End Class