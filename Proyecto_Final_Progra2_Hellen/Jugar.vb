Public Class frm_Jugar

    Dim vTextoLabel As String
    Dim vFallos As Integer = 5 'esta variable es para las vidas que tendra el juego 

    Private Sub btn_Cargar_Random_Click(sender As Object, e As EventArgs) Handles btn_Cargar_Random.Click
        Dim vRandom As New Random 'este variable es el random
        Dim vNumeroRandom As Integer 'esta variable sera ultilizada para guardar el numero del random
        Dim vPalabra As String ' se guardara  la palabra del array 
        vNumeroRandom = vRandom.Next(0, vArrayPalabras.Length - 1) 'Obtenemos el numero aleatorio del objeto Random
        If vArrayPalabras(vNumeroRandom) = "" Then
            MessageBox.Show("primero cargue las palabras")
        Else
            vPalabra = vArrayPalabras(vNumeroRandom) 'Obtenemos la palabra del arreglo
        End If

        GenerarLabel(vPalabra) 'me lleva a general label, con la palabra del random
    End Sub

    Private Sub GenerarLabel(pFrase As String)
        Dim i As Integer ' sera utilizada en el for
        ReDim vArrayLetras(Len(pFrase) - 1)
        ReDim vArrayLetrasTemp(Len(pFrase) - 1)

        For i = 1 To Len(pFrase)
            vArrayLetras(i - 1) = Mid(pFrase, i, 1) 'me divide las letras 
            vArrayLetrasTemp(i - 1) = "_"
        Next i

        Pintar() 'lo lleva al metodo 

    End Sub


    Private Sub Pintar()

        Dim vPalabras As String

        For i = 0 To vArrayLetrasTemp.Length - 1
            vPalabras = vPalabras + vArrayLetrasTemp(i) + " " ' pinta la letra  en las estanciones que van 

        Next i

        lbPalabra.Text = vPalabras
        If Not lbPalabra.Text.Contains("_") Then
            MessageBox.Show("Has ganado ")
            btn_Adivinar.Enabled = False
            btn_Cargar_Random.Enabled = False
        End If

    End Sub
    Private Function Adivinar(pLetra As String) As Boolean 'lo que fue introducido en textbox lo paso a la variable pLetra 
        Dim encontro As Boolean = False

        For i = 0 To vArrayLetras.Length - 1

            If vArrayLetras(i) = pLetra Then 'Me compara  la letra que introducio en las letras  que estan en la variable 
                vArrayLetrasTemp(i) = pLetra 'me guarda la palabra en la posicion  que corresponde
                encontro = True
            Else ' si la letra no se encuentra entonces me hace eso 
                If vArrayLetrasTemp(i) = "_" Then 'me vuelve a poner un _
                    vArrayLetrasTemp(i) = "_"
                End If
            End If
        Next i
 
        Pintar()

        Return encontro

    End Function

    Private Sub btn_Adivinar_Click(sender As Object, e As EventArgs) Handles btn_Adivinar.Click

        Dim encontro As Boolean = False 'variable boleana que me dira si la palabra es encontrada o no 
        If txt_palabra_entrada.Text = "" Then
            MessageBox.Show("Digite una letra")
        Else
            encontro = Adivinar(txt_palabra_entrada.Text) ' aqui me va a llevar a la referencia de adivinar  con lo que fue introducido en el textbox 

            If encontro <> True Then 'esto es una decision si encontrado es diferente a true  me hacer esto
                lbl_Digita.Text = lbl_Digita.Text + txt_palabra_entrada.Text + ""
                vFallos = vFallos - 1
                PintarAhorcado() ' me lleva a donde se van a mostrar las imagenes
            End If
        End If

    End Sub

    Private Sub PintarAhorcado() 'muestra las imagenes del ahorcado

        Select Case vFallos
            Case 4
                pint1.Visible = True 'muestra las piernas
                pint2.Visible = False
                pint3.Visible = False
                pint4.Visible = False
                pintu5.Visible = False
                lblvidas.Text = "Te quedan 4 vidas "
            Case 3
                pint1.Visible = False
                pint2.Visible = True 'muestra el torso 
                pint3.Visible = False
                pint4.Visible = False
                pintu5.Visible = False
                lblvidas.Text = "Te quedan 3 vidas "
            Case 2
                pint1.Visible = False
                pint2.Visible = False
                pint3.Visible = True  ' muestra la cabeza 
                pint4.Visible = False
                pintu5.Visible = False
                lblvidas.Text = "Te quedan 2 vidas "
            Case 1
                pint1.Visible = False
                pint2.Visible = False
                pint3.Visible = False
                pint4.Visible = True ' muestra las manos 
                pintu5.Visible = False
                lblvidas.Text = "Te quedan 1 vidas "
            Case 0
                pint1.Visible = False
                pint2.Visible = False
                pint3.Visible = False
                pint4.Visible = False
                pintu5.Visible = True 'muestra la cuerda
                lblvidas.Text = "Te quedan 0 vidas "

                MessageBox.Show("Has perdido, lo lamento")
                btn_Adivinar.Enabled = False
                btn_Cargar_Random.Enabled = False

        End Select

    End Sub

   
  
    Private Sub btn_Volver_Jugar_Click(sender As Object, e As EventArgs) Handles btn_Volver_Jugar.Click
        vTextoLabel = ""
        vFallos = 0
        lbPalabra.Text = ""
        lbl_Digita.Text = ""
        txt_palabra_entrada.Clear()
        pint1.Visible = False
        pint2.Visible = False
        pint3.Visible = False
        pint4.Visible = False
        pintu5.Visible = False
        btn_Adivinar.Enabled = True
        btn_Cargar_Random.Enabled = True
    End Sub
End Class