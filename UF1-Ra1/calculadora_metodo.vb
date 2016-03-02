Public Class calculadora_metodo
    Dim n1 As Integer
    Dim n2 As Integer
    Dim resul As Integer
    Dim oper As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        oper = 1
    End Sub

    Private Sub textbox1_TextChanged(sender As Object, e As EventArgs) Handles textbox1.TextChanged
        n1 = textbox1.Text
    End Sub

    Private Sub textbox2_TextChanged(sender As Object, e As EventArgs) Handles textbox2.TextChanged
        n2 = textbox2.Text

    End Sub

    Public Sub resultado_TextChanged(sender As Object, e As EventArgs) Handles textbox3.TextChanged
        textbox3.Text = Me.operacion(n1, n2)

    End Sub

    Public Function operacion(ByVal n1 As Integer, n2 As Integer) As Integer
        Select Case oper
            Case 1
                Return n1 + n2
            Case 2
                Return n1 - n2
            Case 3
                Return n1 * n2
            Case 4
                Return n1 / n2

        End Select
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        oper = 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        oper = 3
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        oper = 4
    End Sub
End Class