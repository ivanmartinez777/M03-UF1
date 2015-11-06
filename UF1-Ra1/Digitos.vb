Public Class Digitos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer
        Dim cnt As Integer = 0

        numero = InputBox("introduce un número")

        Do While numero > 0
            numero = numero \ 10
            cnt = (cnt + 1)
        Loop

        MessageBox.Show(cnt.ToString)

    End Sub
End Class