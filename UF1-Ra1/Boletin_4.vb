Public Class Boletin_4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim origen() As Integer = {1, 4, 10, 32, 60, 91, 34, 56, 73, 88, 86}
        Dim destino() As Integer
        Dim cnt As Integer
        Dim znt As Integer = 0
        Dim salida As String = 0
        Dim zalida As String = 0




        For cnt = 0 To 11
            If origen(cnt) > 25 And origen(cnt) Mod 2 Then
                destino(znt) = origen(cnt)
                znt = znt + 1
            End If
        Next
        For cnt = 0 To origen.Length
            salida = salida + " " + origen(cnt).ToString + " "
        Next
        For znt = 0 To destino.Length
            zalida = zalida + " " + origen(cnt).ToString + " "
        Next
        MessageBox.Show(salida + Environment.NewLine + zalida)

    End Sub
End Class
