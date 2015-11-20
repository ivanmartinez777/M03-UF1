Public Class Ejercicio_18
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim cont As Integer
        Dim resultado As String

        n = InputBox("Escribe un numero superior a 0")

        For cont = 1 To n
            resultado = "2" ^ n

        Next
        MessageBox.Show(resultado.ToString + Environment.NewLine
                         )
    End Sub
End Class