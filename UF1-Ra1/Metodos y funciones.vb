Public Class Metodos_y_funciones
    Dim nombre As String = "Iván"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hello(nombre)
    End Sub
    Public Sub Hello(ByVal nombre As String)
        MessageBox.Show("Hello, " + nombre + "!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hello("Jose")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hello2(nombre)

    End Sub
    Public Sub Hello2(ByRef nombre As String)
        nombre = "modificado"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim resultado As Integer
        Me.sumar(4, 7, resultado)
        MessageBox.Show(resultado)
    End Sub
    Public Sub sumar(ByVal n1 As Integer, n2 As Integer, ByRef suma As Integer)

        suma = n1 + n2

    End Sub
    Public Function sumar2(ByVal n1 As Integer, n2 As Integer) As Integer

        Return n1 + n2


    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim resultado As Integer = Me.sumar2(3, 5)




    End Sub
End Class