Public Class Boletin_2


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim vector(14) As Integer
        Dim n As Integer
        Dim cnt As Integer
        Dim salida As String
        Dim suma As String
        Dim r As New Random
        Dim min As Integer
        Dim max As Integer

        min = InputBox("introduce el número menor")
        max = InputBox("introduce el número mayor")



        For cnt = 0 To 14
            vector(cnt) = r.Next(min, max)
            salida = salida + " " + vector(cnt).ToString + " " + Environment.NewLine
        Next



        For cnt = 0 To 14
            suma = suma + vector(cnt)

        Next

        MessageBox.Show(salida.ToString + suma.ToString)



    End Sub
End Class