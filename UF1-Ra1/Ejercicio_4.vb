Public Class Ejercicio_4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim caracter As String
        Dim Result As String
        caracter = TextBox1.Text

        If caracter = "a" Then
            Result = "vocal"
        ElseIf caracter = "e" Then
            Result = "vocal"
        ElseIf caracter = "i" Then
            Result = "vocal"
        ElseIf caracter = "o" Then
            Result = "vocal"
        ElseIf caracter = "u" Then
            Result = "vocal"
        ElseIf caracter = "b" Then
            Result = "consonante"
        ElseIf caracter = "c" Then
            Result = "consonante"
        ElseIf caracter = "d" Then
            Result = "consonante"
        ElseIf caracter = "f" Then
            Result = "consonante"
        ElseIf caracter = "g" Then
            Result = "consonante"
        ElseIf caracter = "h" Then
            Result = "consonante"
        ElseIf caracter = "j" Then
            Result = "consonante"
        ElseIf caracter = "k" Then
            Result = "consonante"
        ElseIf caracter = "l" Then
            Result = "consonante"
        ElseIf caracter = "m" Then
            Result = "consonante"
        ElseIf caracter = "n" Then
            Result = "consonante"
        ElseIf caracter = "ñ" Then
            Result = "consonante"
        ElseIf caracter = "p" Then
            Result = "consonante"
        ElseIf caracter = "q" Then
            Result = "consonante"
        ElseIf caracter = "r" Then
            Result = "consonante"
        ElseIf caracter = "s" Then
            Result = "consonante"
        ElseIf caracter = "t" Then
            Result = "consonante"
        ElseIf caracter = "v" Then
            Result = "consonante"
        ElseIf caracter = "w" Then
            Result = "consonante"
        ElseIf caracter = "x" Then
            Result = "consonante"
        ElseIf caracter = "y" Then
            Result = "consonante"
        ElseIf caracter = "z" Then
            Result = "consonante"
        Else
            Result = "error"
        End If
        MessageBox.Show(Result)



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class