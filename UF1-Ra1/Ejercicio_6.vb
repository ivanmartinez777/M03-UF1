Public Class Ejercicio_6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ndia As Integer
        Dim dia As String

        ndia = CInt(TextBox1.Text)

        Select Case ndia

            Case 1
                dia = "Dilluns"
            Case 2
                dia = "Dimarts"
            Case 3
                dia = "Dimecres"
            Case 4
                dia = "Dijous"
            Case 5
                dia = "Divendres"
            Case 6
                dia = "Dissabte"
            Case 7
                dia = "Diumenge"
        End Select

        Label1.Text = dia
    End Sub
End Class