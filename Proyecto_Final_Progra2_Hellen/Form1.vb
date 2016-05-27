Public Class frm_Cargar_Palabras
    
    Dim tamañodelasletras As Long 'esto me a contar cuantas letras tiene la palabra
    Private Sub btn_Cargar_Click(sender As Object, e As EventArgs) Handles btn_Cargar.Click

        For i = 0 To vArrayPalabras.Length - 1
et2:
            vPalabra = InputBox("Digite palabras") ' le dice al usuario que digite una letra y la guardara en el variable
            tamañodelasletras = Len(vPalabra) 'convierto la palabra en numeros 
            If tamañodelasletras < 6 Or tamañodelasletras > 13 Then 'aqui si la palabra tiene menos de 6 caracteres o mas de 12 no lo deja pasar.

                MessageBox.Show("Vuelva a digitar otra palabra, la palabra debe ser mayor a 6 y menor a 15")
                GoTo et2

            End If

            If cargar_datos(vPalabra) Then
                MessageBox.Show("Informacion guardada con exito", "Mensaje  del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            vArrayPalabras(i) = vPalabra 'guarda la palabra en el arreglo


        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To vArrayPalabras.Length - 1
            lbl.Text = lbl.Text & vArrayPalabras(i) & vbCrLf 'esto quiere decir que me va a mostrar cada letra que se cargo anterior
        Next
    End Sub

End Class
