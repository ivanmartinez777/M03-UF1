Public Class AdivinarUnNumero2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor As Integer
        Dim acierto As Integer
        Dim cnt As Integer = 4
        Dim nombre As String

        nombre = InputBox("Como te llamas gusano?")
        MessageBox.Show("Muy bien" + " " + nombre + "." + " " + " Bienvenida al juego de la muerte!")

        Randomize()
        acierto = Rnd() * 10


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
            MessageBox.Show("Este era el número!" + " " + acierto.ToString
                            )

        End If



    End Sub
End Class