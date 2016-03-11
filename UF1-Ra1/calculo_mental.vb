Public Class calculo_mental
    Dim cnt As Integer = 4
    Dim resp As Integer
    Dim op As Integer
    Dim op2 As Integer
    Dim pregunta As Integer
    Dim count As Integer = 0
    Dim cp As Integer = 0
    Dim cc As Integer = 0
    Dim ci As Integer = 0

    Dim r As New Random
    Dim juicio As Boolean

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (CheckBox1.Checked = True And CheckBox2.Checked = True) Or (CheckBox1.Checked = True And CheckBox3.Checked = True) Or (CheckBox3.Checked = True And CheckBox2.Checked = True) Then
            MessageBox.Show("Sólo puede seleccionar un nivel")

        ElseIf CheckBox1.Checked = True Then
            Label3.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            Timer1.Start()
            count = 10
            CheckBox1.Visible = False
            CheckBox2.Visible = False
            CheckBox3.Visible = False
            Button1.Visible = False
        ElseIf CheckBox2.Checked = True Then
            Timer2.Start()
            Label3.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            count = 20
            CheckBox1.Visible = False
            CheckBox2.Visible = False
            CheckBox3.Visible = False
            Button1.Visible = False
        ElseIf CheckBox3.Checked = True Then
            Label3.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            Timer3.Start()
            count = 30
            CheckBox1.Visible = False
            CheckBox2.Visible = False
            CheckBox3.Visible = False
            Button1.Visible = False

        Else
            MessageBox.Show("selecciona una dificultad por favor")
        End If



    End Sub




    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        count = 1



    End Sub


    Public Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If count = 10 Then

                pregunta = r.Next(1, 3)
            op = r.Next(1, 100)

            op2 = r.Next(1, 100)



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

                cc = cc + 1
                TextBox3.Text = cc
            Else

                ci = ci + 1
                TextBox4.Text = ci
            End If
            cp = cp + 1
            TextBox2.Text = ""
                count = 10
            End If



        If cp = 5 Then


            TextBox2.Text = ""
            TextBox1.Text = ""
            Timer1.Enabled = False
            cp = 0
            If ci < cc Then
                Label3.Text = "Aprobado"
            Else
                Label3.Text = "Suspedido"
            End If
            ci = 0
            cc = 0
            cp = 0

            CheckBox1.Visible = True
            CheckBox2.Visible = True
            CheckBox3.Visible = True
            Button1.Visible = True

        Else
            Timer1.Enabled = True
        End If



    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If count = 20 Then

            pregunta = r.Next(1, 5)
            op = r.Next(100, 1000)

            op2 = r.Next(100, 1000)



            Select Case pregunta
                Case 1
                    pregunta = op - op2
                    TextBox1.Text = op.ToString + " - " + op2.ToString


                Case 2
                    pregunta = op + op2
                    TextBox1.Text = op.ToString + " + " + op2.ToString
                Case 3
                    pregunta = op * op2
                    TextBox1.Text = op.ToString + " * " + op2.ToString
                Case 4
                    If op > op2 Then
                        pregunta = op / op2
                    Else
                        pregunta = op2 / op
                    End If


                    TextBox1.Text = op.ToString + " / " + op2.ToString
            End Select

        End If
        Timer2.Enabled = True
        count = count - 1
        timerr1.Text = count.ToString

        If count < 1 Then
            count = 0
            Timer2.Enabled = False
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

                cc = cc + 1
                TextBox3.Text = cc
            Else

                ci = ci + 1
                TextBox4.Text = ci
            End If
            cp = cp + 1
            TextBox2.Text = ""
            count = 20
        End If



        If cp = 5 Then


            TextBox2.Text = ""
            TextBox1.Text = ""
            Timer2.Enabled = False
            cp = 0
            If ci < cc Then
                Label3.Text = "Aprobado"
            Else
                Label3.Text = "Suspedido"
            End If
            ci = 0
            cc = 0
            cp = 0

            CheckBox1.Visible = True
            CheckBox2.Visible = True
            CheckBox3.Visible = True
            Button1.Visible = True
        Else
            Timer2.Enabled = True
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        If count = 30 Then

            pregunta = r.Next(1, 5)
            op = r.Next(1000, 10000)

            op2 = r.Next(1000, 10000)



            Select Case pregunta
                Case 1
                    pregunta = op - op2
                    TextBox1.Text = op.ToString + " - " + op2.ToString

                Case 2
                    pregunta = op + op2
                    TextBox1.Text = op.ToString + " + " + op2.ToString
                Case 3
                    pregunta = op * op2
                    TextBox1.Text = op.ToString + " * " + op2.ToString
                Case 4
                    If op > op2 Then
                        pregunta = op / op2
                    Else
                        pregunta = op2 / op
                    End If
            End Select

        End If
        Timer3.Enabled = True
        count = count - 1
        timerr1.Text = count.ToString

        If count < 1 Then
            count = 0
            Timer3.Enabled = False
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

                cc = cc + 1
                TextBox3.Text = cc
            Else

                ci = ci + 1
                TextBox4.Text = ci
            End If
            cp = cp + 1
            TextBox2.Text = ""
            count = 30
        End If



        If cp = 5 Then


            TextBox2.Text = ""
            TextBox1.Text = ""
            Timer3.Enabled = False
            cp = 0
            If ci < cc Then
                Label3.Text = "Aprobado"
            Else
                Label3.Text = "Suspedido"
            End If
            ci = 0
            cc = 0
            cp = 0

            CheckBox1.Visible = True
            CheckBox2.Visible = True
            CheckBox3.Visible = True
            Button1.Visible = True
        Else
            Timer3.Enabled = True
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class