Public Class suma100
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim suma As Integer
        Dim cont As Integer


        For cont = 0 To 100
            suma = suma + (cont)

        Next

        MessageBox.Show(suma.ToString())

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim suma As Integer = 0
        For cnt As Integer = 0 To 100
            suma = suma + cnt


        Next

        MessageBox.Show(suma.ToString())
    End Sub
End Class