Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String

        name = InputBox(Prompt:="hola jefe, como te llamas?")


        MsgBox("Hola Don " & name & "")
    End Sub
End Class