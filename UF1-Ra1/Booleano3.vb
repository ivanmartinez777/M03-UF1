Public Class Booleano3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim expresion As Boolean

        expresion = 1 + 3 < 7 Or 5 > 6

        MessageBox.Show(expresion)

    End Sub
End Class