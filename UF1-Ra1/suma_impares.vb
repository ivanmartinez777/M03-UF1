Public Class suma_impares
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim suma As Integer
        Dim cont As Integer

        For cont = 0 To 100
            If cont Mod 2 <> 0 Then
                suma = suma + cont
            End If

        Next
        MessageBox.Show(suma.ToString)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim suma As Integer

        Dim cont As Integer

        Dim hasta As Integer


        hasta = CInt(TextBox1.Text)

        For cont = 0 To hasta
            If cont Mod 2 <> 0 Then
                suma = suma + cont
            End If

        Next
        MessageBox.Show(suma.ToString)
    End Sub
End Class