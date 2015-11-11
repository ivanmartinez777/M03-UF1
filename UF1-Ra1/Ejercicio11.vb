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

        For cnt = 0 To Numero
            If cnt Mod 2 = 0 Then
                Resultado = Resultado + cnt

            End If
        Next
        MessageBox.Show(Resultado)

    End Sub
End Class