Public Class esc
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim instru As Object
        Dim archivo As Object


        instru = CreateObject("Scripting.FileSystemObject­")
        archivo = instru.CreateTextFile("C:/exportgen/textarchivo.text", True)

        archivo.WriteLine("Hola")
        archivo.WriteLine("Segunda linea")
        archivo.WriteLine("Tercera Linea")
        archivo.WriteLine("Adios ! :D")
        archivo.Close()


    End Sub
End Class