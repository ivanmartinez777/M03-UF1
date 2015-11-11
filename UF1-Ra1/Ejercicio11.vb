Public Class Ejercicio11
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Resultado As Integer = 0
        Dim Numero As Integer
        Dim cnt As Integer

        Numero = InputBox("introduce un número")

        Do While cnt <= Numero
            If cnt Mod 2 = 0 Then
                Resultado = Resultado + cnt

            End If
            cnt = cnt + 1
        Loop
        MessageBox.Show(Resultado)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Resultado As Integer
        Dim Numero As Integer
        Dim cnt As Integer

        Numero = InputBox("introduce un número")

        For cnt = 0 To Numero Step 2

            Resultado = Resultado + cnt


        Next
        MessageBox.Show(Resultado)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Resultado As Integer
        Dim Numero As Integer
        Dim cnt As Integer

        Numero = InputBox("introduce un número")

        While cnt <= Numero

            If cnt Mod 2 = 0 Then
                    Resultado = Resultado + cnt

                End If
                cnt = cnt + 1
        End While

        MessageBox.Show(Resultado)
    End Sub
End Class