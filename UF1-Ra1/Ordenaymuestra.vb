Public Class Ordenaymuestra
    Private Sub ordenador_Click(sender As Object, e As EventArgs) Handles ordenador.Click
        Dim n1 As Integer
        Dim n2 As Integer
        Dim n3 As Integer
        Dim result As String

        n1 = CInt(textbox1.Text)
        n2 = CInt(textbox2.Text)
        n3 = CInt(textbox3.Text)

        If n1 < n2 And n2 < n3 Then

            result = "          " + n1.ToString() + "          " + n2.ToString + "          " + n3.ToString

            '123
        ElseIf n1 < n3 And n3 < n2 Then
            result = "          " + n1.ToString() + "          " + n3.ToString + "          " + n2.ToString
            '132

        ElseIf n2 < n1 And n1 < n3 Then
            result = "          " + n2.ToString() + "          " + n1.ToString + "          " + n3.ToString
            '213

        ElseIf n3 < n1 And n1 < n2 Then
            result = "          " + n3.ToString() + "          " + n1.ToString + "          " + n2.ToString
            '231

        ElseIf n2 < n3 And n3 < n1 Then
            result = "          " + n2.ToString() + "          " + n3.ToString + "          " + n1.ToString
            '312


        Else

            result = "          " + n3.ToString() + "          " + n2.ToString + "          " + n1.ToString
            '321


        End If
        MessageBox.Show(result)
    End Sub

    Private Sub textbox1_TextChanged(sender As Object, e As EventArgs) Handles textbox1.TextChanged

    End Sub
End Class