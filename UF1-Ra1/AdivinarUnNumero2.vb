Public Class AdivinarUnNumero2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor As Integer
        Dim acierto As Integer
        Dim cnt As Integer = 4

        acierto = 4

        Do Until valor = acierto Or cnt = 0
            valor = InputBox("introduce un número amigo")
            cnt = cnt - 1
            If valor = acierto Then
                MessageBox.Show("you win!")

            ElseIf valor <> acierto And cnt > 0
                MessageBox.Show(cnt)

            End If

        Loop

        If cnt > 0 Then
            MessageBox.Show("esta vez lo has conseguido, pero no volverá a ocurrir!")

        Else
            MessageBox.Show("Se te acabaron los intentos amigo. Estas acabado!")

        End If



    End Sub
End Class