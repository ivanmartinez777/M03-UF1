Public Class Boletin6_1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numeros(9) As Integer
        Dim n2 As Integer
        Dim n3 As Integer
        Dim cnt As Integer
        Dim salida As String
        For cnt = 0 To 9
            numeros(cnt) = InputBox("introduce un numero diferente de 0")


        Next
        For cnt = 0 To 9
            n2 = numeros(cnt) ^ 2
            n3 = numeros(cnt) ^ 3
            salida = salida + (numeros(cnt).ToString + " " + n2.ToString + " " + n3.ToString + Environment.NewLine())
        Next
        MessageBox.Show(salida)
    End Sub
End Class