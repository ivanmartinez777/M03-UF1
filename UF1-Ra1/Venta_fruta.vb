Public Class Venta_fruta
    Dim total As Double = 400
    Const precio As Double = 7.5
    Dim stock As Double = 40
    Const precio2 As Double = 8.5
    Dim stock2 As Double = 40
    Dim parcial As Double
    Dim stock3 As Double = 40
    Dim precio3 As Double = 8.3





    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        parcial = TextBox1.Text
        total = total + parcial
        TextBox2.Text = total
        stock = Label2.Text
        stock2 = Label3.Text
        stock3 = Label10.Text

        numero1.Text = 0
        numero2.Text = 0
        numero3.Text = 0
        efectivot.Text = 0

    End Sub


    Private Sub efectivot_TextChanged(sender As Object, e As EventArgs) Handles efectivot.TextChanged
        If IsNumeric(efectivot.Text) Then
            cambiot.Text = efectivot.Text - TextBox1.Text
        End If
    End Sub

    Private Sub numero1_TextChanged(sender As Object, e As EventArgs) Handles numero1.TextChanged

        If numero1.Text = "" Then
            IsNumeric(numero1.Text)

        ElseIf numero1.Text >= stock Then
            numero1.Text = stock


        Else

            If IsNumeric(numero1.Text) And IsNumeric(numero2.Text) And IsNumeric(numero3.Text) Then
                TextBox1.Text = numero1.Text * precio + numero2.Text * precio2 + numero3.Text * precio3

            ElseIf IsNumeric(numero1.Text) And IsNumeric(numero2.Text) Then
                TextBox1.Text = numero1.Text * precio + numero2.Text * precio2

            ElseIf IsNumeric(numero1.Text) And IsNumeric(numero3.Text) Then
                TextBox1.Text = numero1.Text * precio + numero3.Text * precio3

            ElseIf IsNumeric(numero1.Text) Then
                TextBox1.Text = numero1.Text * precio


            End If
        End If
        If IsNumeric(numero1.Text) Then
            Label2.Text = stock - numero1.Text
        ElseIf (numero1.Text) = "" Then

            Label2.Text = stock - 0
        End If


    End Sub

    Private Sub numero2_TextChanged(sender As Object, e As EventArgs) Handles numero2.TextChanged
        If numero2.Text = "" Then
            IsNumeric(numero2.Text)

        ElseIf numero2.Text >= stock2 Then
            numero2.Text = stock2

        Else

            If IsNumeric(numero2.Text) And IsNumeric(numero1.Text) And IsNumeric(numero3.Text) Then
                TextBox1.Text = numero1.Text * precio + numero2.Text * precio2 + numero3.Text * precio3

            ElseIf IsNumeric(numero2.Text) And IsNumeric(numero1.Text) Then
                TextBox1.Text = numero2.Text * precio2 + numero1.Text * precio
            ElseIf IsNumeric(numero2.Text) And IsNumeric(numero3.Text) Then
                TextBox1.Text = numero2.Text * precio2 + numero3.Text * precio3
            ElseIf IsNumeric(numero2.Text) Then
                TextBox1.Text = numero2.Text * precio2

            End If
        End If
        If IsNumeric(numero2.Text) Then
            Label3.Text = stock2 - numero2.Text
        ElseIf (numero2.Text) = "" Then

            Label3.Text = stock2 - 0
        End If
    End Sub
    Private Sub Venta_fruta_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox2.Text = total
    End Sub

    Private Sub numero3_TextChanged(sender As Object, e As EventArgs) Handles numero3.TextChanged
        If numero3.Text = "" Then
            IsNumeric(numero3.Text)

        ElseIf numero3.Text >= stock3 Then
            numero3.Text = stock3

        Else

            If IsNumeric(numero2.Text) And IsNumeric(numero1.Text) And IsNumeric(numero3.Text) Then
                TextBox1.Text = numero1.Text * precio + numero2.Text * precio2 + numero3.Text * precio3

            ElseIf IsNumeric(numero3.Text) And IsNumeric(numero1.Text) Then
                TextBox1.Text = numero3.Text * precio3 + numero1.Text * precio
            ElseIf IsNumeric(numero3.Text) And IsNumeric(numero2.Text) Then
                TextBox1.Text = numero3.Text * precio3 + numero2.Text * precio2
            ElseIf IsNumeric(numero3.Text) Then
                TextBox1.Text = numero3.Text * precio3

            End If
        End If
        If IsNumeric(numero3.Text) Then
            Label10.Text = stock3 - numero3.Text
        ElseIf (numero3.Text) = "" Then

            Label10.Text = stock3 - 0
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub


End Class