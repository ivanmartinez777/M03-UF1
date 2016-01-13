Public Class E_9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vector(9) As Integer
        Dim cnt As Integer
        Dim par(9) As Integer
        Dim impar(9) As Integer
        Dim cntp As Integer = 1
        Dim cnti As Integer = 1
        Dim suma As Integer
        Dim cnt0 As Integer = 0
        Dim salida As String

        For cnt = 0 To 9
            vector(cnt) = InputBox("introduce un numero")
            If vector(cnt) Mod 2 = 0 Then
                par(cntp) = vector(cnt)
                cntp = cntp + 1

            Else

                impar(cnti) = vector(cnt)
                cnti = cnti + 1



            End If
        Next


        cnti = 0
        cntp = 0
        For cnt0 = 0 To 9
            MessageBox.Show(par(cntp))
            MessageBox.Show(impar(cnti))


        Next
        cnti = 0
        cntp = 0
        cnt0 = 0

        For cnti = 0 To 9
            suma = par(cntp) + impar(cnti)
            cntp = cntp + 1
            cnti = cnti + 1
            salida = salida + suma.ToString + " "
        Next

        MessageBox.Show(salida)

    End Sub
End Class