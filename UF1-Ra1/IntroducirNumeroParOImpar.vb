Public Class IntroducirNumeroParOImpar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer

        Dim cnt As Integer




        For cnt = 0 To 9
            numero = InputBox("Veremos si el número es par o immpar")
            If numero Mod 2 = 0 Then
                MessageBox.Show("Es par")
            Else
                MessageBox.Show("Es impar")
            End If
        Next



    End Sub
End Class