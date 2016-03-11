Public Class calculo_mental
    Dim cnt As Integer = 4
    Dim resp As Integer
    Dim op As Integer
    Dim op2 As Integer
    Dim pregunta As Integer
    Dim count As Integer = 10
    Dim cp As Integer = 0
    Dim cc As Integer = 0
    Dim ci As Integer = 0

    Dim r As New Random
    Dim juicio As Boolean

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Timer1.Start()



    End Sub




    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        count = 1



    End Sub


    Public Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If count = 10 Then

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

            End If
            Timer1.Enabled = True
            count = count - 1
            timerr1.Text = count.ToString

            If count < 1 Then
                count = 0
                Timer1.Enabled = False
            End If
            If count = 0 Then
                If TextBox2.Text = "" Then
                    resp = 0
                Else
                    resp = TextBox2.Text
                End If
                If pregunta = resp Then
                    juicio = True
                Else
                    juicio = False
                End If
            If juicio = True Then
                MessageBox.Show("tienes razón  ")
                cc = cc + 1
            Else
                MessageBox.Show("no sabes lo que dices")
                ci = ci + 1

            End If
            cp = cp + 1
            TextBox2.Text = ""
                count = 10
            End If



        If cp = 5 Then
            MessageBox.Show("Se acabó")

            TextBox2.Text = ""
            TextBox1.Text = ""
            Timer1.Enabled = False
            cp = 0
            If ci < cc Then
                MessageBox.Show("Eres un maestro, has aprobado. Has cometido " + ci.ToString + " errores y " + cc.ToString + " aciertos.")
            Else
                MessageBox.Show("Eres un zote, has suspendido. Has cometido " + ci.ToString + " errores y " + cc.ToString + " aciertos.")
            End If
            ci = 0
            cc = 0
            cp = 0

        Else
            Timer1.Enabled = True
        End If



    End Sub



End Class