<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Jugar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Jugar))
        Me.btn_Cargar_Random = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_palabra_entrada = New System.Windows.Forms.TextBox()
        Me.btn_Adivinar = New System.Windows.Forms.Button()
        Me.lbPalabra = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_Volver_Jugar = New System.Windows.Forms.Button()
        Me.pint1 = New System.Windows.Forms.PictureBox()
        Me.pint3 = New System.Windows.Forms.PictureBox()
        Me.pint2 = New System.Windows.Forms.PictureBox()
        Me.pintu5 = New System.Windows.Forms.PictureBox()
        Me.pint4 = New System.Windows.Forms.PictureBox()
        Me.lbl_Digita = New System.Windows.Forms.Label()
        Me.lblvidas = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.pint1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pint3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pint2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pintu5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pint4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cargar_Random
        '
        Me.btn_Cargar_Random.Location = New System.Drawing.Point(18, 12)
        Me.btn_Cargar_Random.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Cargar_Random.Name = "btn_Cargar_Random"
        Me.btn_Cargar_Random.Size = New System.Drawing.Size(157, 42)
        Me.btn_Cargar_Random.TabIndex = 1
        Me.btn_Cargar_Random.Text = "Cargar palabra "
        Me.btn_Cargar_Random.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Digite una letra"
        '
        'txt_palabra_entrada
        '
        Me.txt_palabra_entrada.Location = New System.Drawing.Point(120, 140)
        Me.txt_palabra_entrada.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_palabra_entrada.Name = "txt_palabra_entrada"
        Me.txt_palabra_entrada.Size = New System.Drawing.Size(73, 26)
        Me.txt_palabra_entrada.TabIndex = 1
        '
        'btn_Adivinar
        '
        Me.btn_Adivinar.Location = New System.Drawing.Point(204, 136)
        Me.btn_Adivinar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Adivinar.Name = "btn_Adivinar"
        Me.btn_Adivinar.Size = New System.Drawing.Size(112, 32)
        Me.btn_Adivinar.TabIndex = 2
        Me.btn_Adivinar.Text = "Adivinar "
        Me.btn_Adivinar.UseVisualStyleBackColor = True
        '
        'lbPalabra
        '
        Me.lbPalabra.BackColor = System.Drawing.Color.Transparent
        Me.lbPalabra.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPalabra.Location = New System.Drawing.Point(22, 227)
        Me.lbPalabra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPalabra.Name = "lbPalabra"
        Me.lbPalabra.Size = New System.Drawing.Size(386, 54)
        Me.lbPalabra.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1222, 460)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 32)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_Volver_Jugar
        '
        Me.btn_Volver_Jugar.Location = New System.Drawing.Point(89, 393)
        Me.btn_Volver_Jugar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Volver_Jugar.Name = "btn_Volver_Jugar"
        Me.btn_Volver_Jugar.Size = New System.Drawing.Size(145, 32)
        Me.btn_Volver_Jugar.TabIndex = 13
        Me.btn_Volver_Jugar.Text = "Volver a Jugar"
        Me.btn_Volver_Jugar.UseVisualStyleBackColor = True
        '
        'pint1
        '
        Me.pint1.Image = CType(resources.GetObject("pint1.Image"), System.Drawing.Image)
        Me.pint1.Location = New System.Drawing.Point(363, 214)
        Me.pint1.Name = "pint1"
        Me.pint1.Size = New System.Drawing.Size(369, 453)
        Me.pint1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pint1.TabIndex = 15
        Me.pint1.TabStop = False
        Me.pint1.Visible = False
        '
        'pint3
        '
        Me.pint3.Image = CType(resources.GetObject("pint3.Image"), System.Drawing.Image)
        Me.pint3.Location = New System.Drawing.Point(363, 214)
        Me.pint3.Name = "pint3"
        Me.pint3.Size = New System.Drawing.Size(369, 453)
        Me.pint3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pint3.TabIndex = 16
        Me.pint3.TabStop = False
        Me.pint3.Visible = False
        '
        'pint2
        '
        Me.pint2.Image = CType(resources.GetObject("pint2.Image"), System.Drawing.Image)
        Me.pint2.Location = New System.Drawing.Point(363, 214)
        Me.pint2.Name = "pint2"
        Me.pint2.Size = New System.Drawing.Size(369, 453)
        Me.pint2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pint2.TabIndex = 17
        Me.pint2.TabStop = False
        Me.pint2.Visible = False
        '
        'pintu5
        '
        Me.pintu5.Image = CType(resources.GetObject("pintu5.Image"), System.Drawing.Image)
        Me.pintu5.Location = New System.Drawing.Point(363, 214)
        Me.pintu5.Name = "pintu5"
        Me.pintu5.Size = New System.Drawing.Size(369, 453)
        Me.pintu5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pintu5.TabIndex = 18
        Me.pintu5.TabStop = False
        Me.pintu5.Visible = False
        '
        'pint4
        '
        Me.pint4.Image = CType(resources.GetObject("pint4.Image"), System.Drawing.Image)
        Me.pint4.Location = New System.Drawing.Point(363, 214)
        Me.pint4.Name = "pint4"
        Me.pint4.Size = New System.Drawing.Size(369, 453)
        Me.pint4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pint4.TabIndex = 19
        Me.pint4.TabStop = False
        Me.pint4.Visible = False
        '
        'lbl_Digita
        '
        Me.lbl_Digita.Location = New System.Drawing.Point(117, 322)
        Me.lbl_Digita.Name = "lbl_Digita"
        Me.lbl_Digita.Size = New System.Drawing.Size(117, 26)
        Me.lbl_Digita.TabIndex = 20
        '
        'lblvidas
        '
        Me.lblvidas.BackColor = System.Drawing.Color.Transparent
        Me.lblvidas.ForeColor = System.Drawing.Color.Black
        Me.lblvidas.Location = New System.Drawing.Point(434, 169)
        Me.lblvidas.Name = "lblvidas"
        Me.lblvidas.Size = New System.Drawing.Size(160, 27)
        Me.lblvidas.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Palabras incorrecta "
        '
        'frm_Jugar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(945, 701)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblvidas)
        Me.Controls.Add(Me.lbl_Digita)
        Me.Controls.Add(Me.pint2)
        Me.Controls.Add(Me.pint3)
        Me.Controls.Add(Me.pint1)
        Me.Controls.Add(Me.btn_Volver_Jugar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbPalabra)
        Me.Controls.Add(Me.btn_Adivinar)
        Me.Controls.Add(Me.txt_palabra_entrada)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Cargar_Random)
        Me.Controls.Add(Me.pint4)
        Me.Controls.Add(Me.pintu5)
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_Jugar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Jugar"
        CType(Me.pint1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pint3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pint2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pintu5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pint4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Cargar_Random As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_palabra_entrada As System.Windows.Forms.TextBox
    Friend WithEvents btn_Adivinar As System.Windows.Forms.Button
    Friend WithEvents lbPalabra As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_Volver_Jugar As System.Windows.Forms.Button
    Friend WithEvents pint1 As System.Windows.Forms.PictureBox
    Friend WithEvents pint3 As System.Windows.Forms.PictureBox
    Friend WithEvents pint2 As System.Windows.Forms.PictureBox
    Friend WithEvents pintu5 As System.Windows.Forms.PictureBox
    Friend WithEvents pint4 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Digita As System.Windows.Forms.Label
    Friend WithEvents lblvidas As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
