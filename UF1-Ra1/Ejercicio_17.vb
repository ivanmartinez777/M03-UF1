Public Class Ejercicio_17
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        Dim pos As Integer
        Dim neg As Integer

        num = InputBox("introduce un número diferente de 0")

        While num < 0 Or num > 0
            If num > 0 Then
                pos = pos + 1
            Else
                neg = neg + 1
            End If
            num = InputBox("introduce un número diferente de 0")
        End While
        MessageBox.Show("positivos" + " " + pos.ToString + " " + "negativos" + " " + neg.ToString)
    End Sub
End Class