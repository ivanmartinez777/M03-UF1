Public Class IntroducciónYMenor
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer
        Dim cnt As Integer
        Dim menor As Integer

        menor = InputBox("introduce un numero")


        For cnt = 0 To 8
            numero = InputBox("introduce un numero")
            If numero < menor Then
                menor = numero


            End If


        Next
        MessageBox.Show(menor.ToString())

    End Sub
End Class