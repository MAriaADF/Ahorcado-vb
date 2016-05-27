Module Module1
    Public vPalabra As String
    Public vArrayPalabras(14) As String 'en este arreglo se guardaran las palabras que el usuario ingrese
    Public vArrayLetras() As String
    Public vArrayLetrasTemp() As String

    Public Function cargar_datos(vPalabra)
        Try
            FileOpen(1, "G:\palabras.txt", OpenMode.Append) 'crea el archivo, sino se encuentra 
            WriteLine(1, vPalabra)
            Return True
        Catch ex As Exception

            MsgBox(ex.Message) 'mensaje con el que tiene la ex 
            Return False
        Finally
            FileClose() 'finaliza 
        End Try
    End Function
End Module
