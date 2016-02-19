Public Class Ari
    Dim salida As String
    Dim com As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        salida = salida + "Ve molt motivada a classe ï aquesta és una actitud que es manté sessió rere sessió. "
        pantalla.Text = salida
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        salida = salida + "Mostra un gran interès durant l'estona del conte, l'escolta amb gran atenció i pren part de
l'explicació. Això prova que escolta el CD regularment ja que aconsegueix reproduir parts de la
història. "
        pantalla.Text = salida
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        salida = salida + "Ve molt content(a) a classe i ho exterioritza. "
        pantalla.Text = salida
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        salida = salida + "Sap les cançons. "
        pantalla.Text = salida
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        salida = salida + vbNewLine
    End Sub



    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        com = InputBox("comente")
        salida = salida + com
        pantalla.Text = salida
    End Sub

    Private Sub Ari_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        salida = salida + "S'evidencia que passa una molt bona estona amb les activitats de grup. "
        pantalla.Text = salida
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        salida = salida + "Se'la veu molt contenta venint a classe. "
        pantalla.Text = salida
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        salida = salida + "Ha continuat mostrant satisfacció per tot allò que hem anat fent a classe i no ha mostrat cap
símptoma d'avorriment o disconformitat. "
        pantalla.Text = salida
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        salida = salida + "És molt alegre i es pren qualsevol activitat amb ganes I il∙lusió. "
        pantalla.Text = salida
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        salida = salida + "La seva motivació es veu condicionada per les activitats que s'estan duent a terme. "
        pantalla.Text = salida
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        salida = salida + "Sempre arriba a classe contenta i amb ganes de treballar. "
        pantalla.Text = salida
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        salida = salida + "Ha vingut motivat/da a classe i no ha posat cap problema a l'hora de participar en tot allò que
se li ha proposat. "
        pantalla.Text = salida
    End Sub
End Class