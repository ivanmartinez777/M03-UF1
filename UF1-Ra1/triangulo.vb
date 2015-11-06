Public Class triangulo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim salida As String = ""
        Dim i, j As Integer
        For i = 0 To 5 ' filas
            For j = 0 To i 'columnas
                salida = salida + "*"
            Next 'fin de fila
            salida = salida + vbNewLine
        Next 'fin de todas las filas
        MessageBox.Show(salida)

    End Sub
End Class