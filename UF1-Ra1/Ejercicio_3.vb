Public Class Ejercicio_3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer
        Dim n2 As Integer
        Dim n3 As Integer
        Dim resultmax As String
        Dim resultmin As String


        n1 = CInt(TextBox1.Text)
        n2 = CInt(TextBox2.Text)
        n3 = CInt(TextBox3.Text)


        If n1 > n2 And n1 < n3 Then
            resultmax = n1.ToString
        ElseIf n2 < n1 And n2 < n3 Then
            resultmax = n2.ToString
        Else
            resultmax = n3.ToString
        End If
        Label1.Text = resultmax.ToString()
        Label2.Text = resultmin.ToString()




    End Sub
End Class