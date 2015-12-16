Public Class Ejercicio1
    Dim tabla(149, 149) As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim i, j As Integer
        Dim r As New Random
        Dim salida As String

        For i = 0 To 149
            For j = 0 To 149
                tabla(i, j) = r.Next(0, 100)
                salida = salida + tabla(i, j).ToString + " "
            Next
            salida = salida + vbNewLine
        Next
        MessageBox.Show(salida)
    End Sub
End Class