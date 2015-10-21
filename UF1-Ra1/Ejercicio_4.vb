Public Class Ejercicio_4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim posicion As Integer
        Dim letra As String

        letra = TextBox1.Text

        posicion = InStr("aeioubcdfghjklmnñopqrstvwxyz", letra)

        If posicion < 5 And posicion > 0 Then
            MessageBox.Show("vocal")
        ElseIf posicion > 5 Then
            MessageBox.Show("consonante")
        Else
            MessageBox.Show("error")
        End If
    End Sub
End Class