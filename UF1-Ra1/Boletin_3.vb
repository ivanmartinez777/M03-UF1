Public Class Boletin_3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tabla(19) As Integer
        Dim cnt As Integer
        Dim salida As String = " "
        Dim cnt0 As Integer = 0

        For cnt = 0 To tabla.Length - 1
            Randomize()
            tabla(cnt) = Rnd() * 100

        Next
        For cnt = 0 To 19
            If tabla(cnt) > 30 Then
                salida = salida + " " + tabla(cnt).ToString + " " + cnt.ToString + " " + Environment.NewLine
            Else
                cnt0 = cnt0 + 1
            End If
        Next
        If cnt0 = 20 Then
            MessageBox.Show("NO HAY NUMEROS MAYORES DE 30")
        Else
            MessageBox.Show(salida.ToString)
        End If

    End Sub
End Class