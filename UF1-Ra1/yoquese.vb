Public Class yoquese
    Private Sub yoquese_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Public Class 




        Private Sub Button1_Click(sender As Object, e As EventArgs)
            Dim n1 As Integer
            Dim n2 As Integer
            Dim menor As Integer

            n1 = CInt(TextBox1.Text())
            n2 = CInt(TextBox2.Text())

            If (n1 < n2) Then
                menor = n1
            Else
                'else es directamente (sino), no hay que volver a poner el comando, simplemente lo pondrá en el caso de que if no se cumpla
                menor = n2

            End If


            TextBox3.Text = menor.ToString()




        End Sub

        Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        End Sub

    End Class
    End Sub
End Class