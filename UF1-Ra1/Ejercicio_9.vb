Public Class Ejercicio_9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mes As Integer
        Dim año As Integer
        Dim dias As Integer

        mes = CInt(TextBox1.Text)
        año = CInt(TextBox2.Text)

        If mes Mod 2 <> 0 And mes < 7 Then
            dias = 31
        Else
            dias = 30

        End If
        Label1.Text = dias
    End Sub
End Class