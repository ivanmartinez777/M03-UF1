Public Class Ejercicio_7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ndia As Integer
        Dim dia As String

        ndia = CInt(TextBox1.Text)

        If ndia = 1 Then
            dia = "Dilluns"
        ElseIf ndia = 2 Then
            dia = "Dimarts"
        ElseIf ndia = 3
            dia = "Dimecres"
        ElseIf ndia = 4
            dia = "Dijous"
        ElseIf ndia = 5
            dia = "Divendres"
        ElseIf ndia = 6
            dia = "Dissabte"
        Else
            dia = "Diumenge"

        End If
        Label1.Text = dia

    End Sub
End Class