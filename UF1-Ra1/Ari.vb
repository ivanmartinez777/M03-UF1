Public Class Ari
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intru As Object
        Dim archivo As Object
        Dim salida As String = ""

        Dim nombre As String = ""
        Dim n As Integer
        Dim nomcom As String = ""



        intru = CreateObject("Scripting.FileSystemObject­")
        archivo = intru.CreateTextFile("C:\Users\ivanm\Desktop\Ari/testarchivo.txt", True)

        nombre = InputBox("Introduce el nombre del alumno")

        MessageBox.Show("1. El niño se porta muy bien" + vbNewLine + "2. El niño está un poco disperso en clase" + vbNewLine +
                        "3. El niño pare que está un poco cansado" + vbNewLine + "4. El niño es satan")

        n = InputBox("introduce una opción")
        Select Case n
            Case 1
                salida = nombre + " se porta muy bien. "
            Case 2
                salida = nombre + " está un poco disperso en clase. "
            Case 3
                salida = nombre + " parece que está un poco cansado"
            Case 4
                salida = nombre + " es satán. "
        End Select

        archivo.WriteLine(salida)
        archivo.close()






    End Sub


End Class