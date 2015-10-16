Public Class tablamultiplicar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer
        Dim salida As String = ""
        Dim cont As Integer
        Dim parcial As Integer

        n1 = TextBox1.Text()


        n1 = TextBox1.Text()

        For cont = 0 To 10
            parcial = n1 * cont
            salida = salida + n1.ToString() + "x" + cont.ToString + "=" + parcial.ToString() + Environment.NewLine
        Next

        MessageBox.Show(salida)


    End Sub
End Class