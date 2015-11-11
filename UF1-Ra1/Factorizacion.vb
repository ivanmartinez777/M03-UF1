Public Class Factorizacion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cnt As Integer
        Dim Resultado As Integer = 1
        Dim Numero As Integer

        Numero = InputBox("introduce un numero para la factorizacion")

        For cnt = 1 To Numero
            Resultado = Resultado * cnt


        Next
        MessageBox.Show(Resultado)
    End Sub
End Class