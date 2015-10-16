Public Class Ejercicio_2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer
        Dim n2 As Integer




        n1 = CInt(TextBox1.Text)
        n2 = CInt(TextBox2.Text)

        If n1 Mod n2 = 0 Then
            'Mod es una operación que indica si, al dividir un numero, el resto es 0
            MessageBox.Show("Es divisible")
        Else
            MessageBox.Show("No es divisible")
        End If



    End Sub
End Class