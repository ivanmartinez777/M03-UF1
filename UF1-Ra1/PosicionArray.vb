Public Class PosicionArray
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nota() As Integer = {4, 20, 10, 12, 0, 7}
        Dim cnt As Integer
        Dim mayor As Integer = nota(0)
        Dim posicion As Integer






        For cnt = 1 To 5
            If nota(cnt) > mayor Then
                mayor = nota(cnt)
                posicion = cnt
            End If

        Next

        MessageBox.Show(posicion.ToString)

    End Sub
End Class