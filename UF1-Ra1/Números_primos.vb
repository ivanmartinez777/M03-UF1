Public Class Números_primos
    Dim cnt As Integer
    Dim cntp As Integer
    Dim cnti As Integer
    Dim cntf As Integer
    Dim primo(1000) As Integer
    Dim cnto As Integer
    Dim salida As String = ""


    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cnti = TextBox1.Text
        cntf = TextBox2.Text


        For cnt = cnti To cntf

            For cnto = 1 To cnt
                If cnt Mod cnto = 0 Then
                    cntp = cntp + 1
                End If
                If cntp <= 2 Then
                    salida = cntf.ToString + " "
                End If
                MessageBox.Show(cnto.ToString + " " + cntp.ToString)
            Next
            cntp = 0
        Next


            MessageBox.Show(salida)
    End Sub
End Class