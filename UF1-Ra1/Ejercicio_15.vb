Public Class Ejercicio_15
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer = 12
        Dim j As Integer = 5
        Dim k As Integer = 0

        If x Mod 4 = 0 Then

            For j = 0 To 10 Step 4
                k = k + j
            Next




        Else

            For j = 0 To 10 Step 4

                k = k + j


            Next
        End If
        MessageBox.Show(j.ToString + " " + k.ToString)
    End Sub
End Class