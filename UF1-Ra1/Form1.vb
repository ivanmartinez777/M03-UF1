Public Class Form1
    Dim op1 As Integer = 0
    Dim op2 As Integer = 0
    Dim resultado As Integer = 0

    Private Sub DividirBtn_Click(sender As Object, e As EventArgs) Handles DividirBtn.Click
        op1 = CInt(TextBox1.Text)
        op2 = CInt(TextBox2.Text)
        'Se usa cint para pasar textbox a numero  
        'lo que hay a la izqueirda del = tiene que ser del mismo tipo que lo que esta a la derecha del igual

        resultado = op1 / op2

        Label1.Text = resultado.ToString()
    End Sub

    Private Sub MultiplicarBtn_Click(sender As Object, e As EventArgs) Handles MultiplicarBtn.Click
        op1 = CInt(TextBox1.Text)
        op2 = CInt(TextBox2.Text)
        'Se usa cint para pasar textbox a numero  
        'lo que hay a la izqueirda del = tiene que ser del mismo tipo que lo que esta a la derecha del igual

        resultado = op1 * op2

        Label1.Text = resultado.ToString()
    End Sub
    'Al ponerlo aqui, se hace visible en todos los bloques de evento. 



    Private Sub RestarBtn_Click(sender As Object, e As EventArgs) Handles RestarBtn.Click
        op1 = CInt(TextBox1.Text)
        op2 = CInt(TextBox2.Text)
        'Se usa cint para pasar textbox a numero  
        'lo que hay a la izqueirda del = tiene que ser del mismo tipo que lo que esta a la derecha del igual

        resultado = op1 - op2

        Label1.Text = resultado.ToString()
    End Sub

    Private Sub sumaBtn_Click(sender As Object, e As EventArgs) Handles sumaBtn.Click


        op1 = CInt(TextBox1.Text)
        op2 = CInt(TextBox2.Text)
        'Se usa cint para pasar textbox a numero  
        'lo que hay a la izqueirda del = tiene que ser del mismo tipo que lo que esta a la derecha del igual

        resultado = op1 + op2

        Label1.Text = resultado.ToString()



    End Sub



End Class
