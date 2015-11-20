Public Class Ejercicio_14
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = 1
        Dim a As Integer = 0

        While i <= 20
            i = i + 2
            Do While a < 10
                MessageBox.Show("ivan mola")
                a = a + 1
            Loop

        End While


    End Sub
End Class