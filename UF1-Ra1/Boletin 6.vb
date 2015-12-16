Public Class Boletin_6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim diagonal(4, 4) As Integer
        Dim i, j As Integer
        Dim salida As String = ""

        For i = 0 To 4
            For j = 0 To 4
                If i = j Then
                    diagonal(i, j) = 0
                Else
                    diagonal(i, j) = 1
                End If
                salida = salida + diagonal(i, j).ToString + " "
            Next
            salida = salida + vbNewLine
        Next
        MessageBox.Show(salida)
    End Sub
End Class