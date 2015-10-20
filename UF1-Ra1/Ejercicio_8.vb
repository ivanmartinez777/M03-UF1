Public Class Ejercicio_8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nota As Integer
        Dim resultado As String

        nota = CInt(TextBox1.Text)


        Select Case nota
            Case 0 To 4
                resultado = "S"
            Case 5, 6
                resultado = "A"
            Case 7, 8
                resultado = "N"
            Case 9
                resultado = "E"
            Case 10
                resultado = "M"


        End Select

        Label1.Text = resultado

    End Sub
End Class