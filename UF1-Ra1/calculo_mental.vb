Public Class calculo_mental
    Dim cnt As Integer = 4
    Dim resp As Integer
    Dim op As Integer
    Dim op2 As Integer
    Dim pregunta As Integer

    Dim r As New Random
    Dim juicio As Boolean

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For cnt = 0 To 4
            pregunta = r.Next(1, 3)
            op = r.Next(10, 100)

            op2 = r.Next(10, 100)



            Select Case pregunta
                Case 1
                    pregunta = op - op2
                    TextBox1.Text = op.ToString + " - " + op2.ToString




                Case 2
                    pregunta = op + op2
                    TextBox1.Text = op.ToString + " + " + op2.ToString



            End Select
            resp = InputBox("La respuesta es")
            Me.Button2.PerformClick()


        Next




    End Sub




    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If pregunta = resp Then
                juicio = True
            End If
            MessageBox.Show(juicio.ToString)



    End Sub
End Class