Public Class Ejercicio_5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nota As Double

        Dim resultado As String

        nota = CDbl(TextBox1.Text)

        If nota >= 0 And nota < 5 Then
            resultado = "S"
        ElseIf nota >= 5 And nota < 6.5 Then
            resultado = "A"
        ElseIf nota >= 6.5 And nota < 8.5 Then
            resultado = "N"
        ElseIf nota >= 8.5 And nota < 9.75 Then
            resultado = "E"
        Else
            resultado = "M"
        End If
        Label2.Text = resultado

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class