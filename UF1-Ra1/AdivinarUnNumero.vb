Public Class AdivinarUnNumero
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim cont As Integer = 4
        Dim acierto As Integer = 4
        Dim salida As String

        n = InputBox(Prompt:="prueba suerte muchacho")

        If n = 4 Then
            MsgBox("Eres un crack")
        Else

            Do Until cont = 0 Or n = acierto
                n = InputBox(Prompt:="prueba suerte muchacho")
                cont = cont - 1
                salida = MsgBox("Te quedan " & cont & " oportunidades amigo")

            Loop
        End If

        MsgBox("Game over")



    End Sub
End Class