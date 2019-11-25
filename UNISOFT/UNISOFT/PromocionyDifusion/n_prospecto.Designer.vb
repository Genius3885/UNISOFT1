<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class N_Prospecto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(N_Prospecto))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.edad = New System.Windows.Forms.TextBox()
        Me.folio = New System.Windows.Forms.TextBox()
        Me.ap_materno = New System.Windows.Forms.TextBox()
        Me.ap_paterno = New System.Windows.Forms.TextBox()
        Me.nombres = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.telefono = New System.Windows.Forms.TextBox()
        Me.correo = New System.Windows.Forms.TextBox()
        Me.nacion = New System.Windows.Forms.TextBox()
        Me.curp = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.num_int = New System.Windows.Forms.TextBox()
        Me.celular = New System.Windows.Forms.TextBox()
        Me.num_ext = New System.Windows.Forms.TextBox()
        Me.calle = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.fecha_alta = New System.Windows.Forms.TextBox()
        Me.alcaldia = New System.Windows.Forms.TextBox()
        Me.ciudad = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ciclo = New System.Windows.Forms.TextBox()
        Me.procedencia = New System.Windows.Forms.TextBox()
        Me.promedio = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.ocupacion = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.sexo = New System.Windows.Forms.ComboBox()
        Me.est_civil = New System.Windows.Forms.ComboBox()
        Me.guardar = New System.Windows.Forms.Button()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.imprimir = New System.Windows.Forms.Button()
        Me.menu = New System.Windows.Forms.Button()
        Me.documentos = New System.Windows.Forms.ComboBox()
        Me.estatus = New System.Windows.Forms.ComboBox()
        Me.licenciatura = New System.Windows.Forms.ComboBox()
        Me.duracion = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(415, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(422, 42)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "NUEVO PROSPECTO "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(945, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Edad:"
        '
        'edad
        '
        Me.edad.Location = New System.Drawing.Point(986, 181)
        Me.edad.Name = "edad"
        Me.edad.Size = New System.Drawing.Size(97, 20)
        Me.edad.TabIndex = 35
        '
        'folio
        '
        Me.folio.Location = New System.Drawing.Point(135, 178)
        Me.folio.Name = "folio"
        Me.folio.Size = New System.Drawing.Size(97, 20)
        Me.folio.TabIndex = 34
        '
        'ap_materno
        '
        Me.ap_materno.Location = New System.Drawing.Point(790, 178)
        Me.ap_materno.Name = "ap_materno"
        Me.ap_materno.Size = New System.Drawing.Size(97, 20)
        Me.ap_materno.TabIndex = 33
        '
        'ap_paterno
        '
        Me.ap_paterno.Location = New System.Drawing.Point(576, 178)
        Me.ap_paterno.Name = "ap_paterno"
        Me.ap_paterno.Size = New System.Drawing.Size(97, 20)
        Me.ap_paterno.TabIndex = 32
        '
        'nombres
        '
        Me.nombres.Location = New System.Drawing.Point(369, 178)
        Me.nombres.Name = "nombres"
        Me.nombres.Size = New System.Drawing.Size(97, 20)
        Me.nombres.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(97, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Folio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(695, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Apellido Materno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(483, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Apellido Paterno:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(305, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Nombre(s):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(928, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Teléfono:"
        '
        'telefono
        '
        Me.telefono.Location = New System.Drawing.Point(986, 224)
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(97, 20)
        Me.telefono.TabIndex = 45
        '
        'correo
        '
        Me.correo.Location = New System.Drawing.Point(790, 224)
        Me.correo.Name = "correo"
        Me.correo.Size = New System.Drawing.Size(97, 20)
        Me.correo.TabIndex = 43
        '
        'nacion
        '
        Me.nacion.Location = New System.Drawing.Point(576, 224)
        Me.nacion.Name = "nacion"
        Me.nacion.Size = New System.Drawing.Size(97, 20)
        Me.nacion.TabIndex = 42
        '
        'curp
        '
        Me.curp.Location = New System.Drawing.Point(369, 224)
        Me.curp.Name = "curp"
        Me.curp.Size = New System.Drawing.Size(97, 20)
        Me.curp.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(97, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Sexo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(742, 227)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Correo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(498, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Nacionalidad:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(323, 227)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "CURP:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(898, 271)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Número Interior:"
        '
        'num_int
        '
        Me.num_int.Location = New System.Drawing.Point(986, 268)
        Me.num_int.Name = "num_int"
        Me.num_int.Size = New System.Drawing.Size(97, 20)
        Me.num_int.TabIndex = 55
        '
        'celular
        '
        Me.celular.Location = New System.Drawing.Point(135, 268)
        Me.celular.Name = "celular"
        Me.celular.Size = New System.Drawing.Size(97, 20)
        Me.celular.TabIndex = 54
        '
        'num_ext
        '
        Me.num_ext.Location = New System.Drawing.Point(790, 268)
        Me.num_ext.Name = "num_ext"
        Me.num_ext.Size = New System.Drawing.Size(97, 20)
        Me.num_ext.TabIndex = 53
        '
        'calle
        '
        Me.calle.Location = New System.Drawing.Point(576, 268)
        Me.calle.Name = "calle"
        Me.calle.Size = New System.Drawing.Size(97, 20)
        Me.calle.TabIndex = 52
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(87, 271)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Celular:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(694, 271)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 13)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Número Exterior:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(537, 271)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Calle:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(298, 271)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 13)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "Estado Civil:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(716, 315)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 13)
        Me.Label17.TabIndex = 66
        Me.Label17.Text = "Licenciatura:"
        '
        'fecha_alta
        '
        Me.fecha_alta.Location = New System.Drawing.Point(576, 312)
        Me.fecha_alta.Name = "fecha_alta"
        Me.fecha_alta.Size = New System.Drawing.Size(97, 20)
        Me.fecha_alta.TabIndex = 63
        '
        'alcaldia
        '
        Me.alcaldia.Location = New System.Drawing.Point(369, 312)
        Me.alcaldia.Name = "alcaldia"
        Me.alcaldia.Size = New System.Drawing.Size(97, 20)
        Me.alcaldia.TabIndex = 62
        '
        'ciudad
        '
        Me.ciudad.Location = New System.Drawing.Point(135, 312)
        Me.ciudad.Name = "ciudad"
        Me.ciudad.Size = New System.Drawing.Size(97, 20)
        Me.ciudad.TabIndex = 61
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(494, 315)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 13)
        Me.Label19.TabIndex = 59
        Me.Label19.Text = "Fecha de alta:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(316, 315)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 13)
        Me.Label20.TabIndex = 58
        Me.Label20.Text = "Alcaldia:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(86, 315)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 13)
        Me.Label21.TabIndex = 57
        Me.Label21.Text = "Ciudad:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(746, 358)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(33, 13)
        Me.Label22.TabIndex = 76
        Me.Label22.Text = "Ciclo:"
        '
        'ciclo
        '
        Me.ciclo.Location = New System.Drawing.Point(790, 355)
        Me.ciclo.Name = "ciclo"
        Me.ciclo.Size = New System.Drawing.Size(97, 20)
        Me.ciclo.TabIndex = 75
        '
        'procedencia
        '
        Me.procedencia.Location = New System.Drawing.Point(369, 355)
        Me.procedencia.Name = "procedencia"
        Me.procedencia.Size = New System.Drawing.Size(97, 20)
        Me.procedencia.TabIndex = 72
        '
        'promedio
        '
        Me.promedio.Location = New System.Drawing.Point(135, 355)
        Me.promedio.Name = "promedio"
        Me.promedio.Size = New System.Drawing.Size(97, 20)
        Me.promedio.TabIndex = 71
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(927, 315)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 13)
        Me.Label23.TabIndex = 70
        Me.Label23.Text = "Duracion:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(524, 358)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(45, 13)
        Me.Label24.TabIndex = 69
        Me.Label24.Text = "Estatus:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(238, 358)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(126, 13)
        Me.Label25.TabIndex = 68
        Me.Label25.Text = "Escuela de Procedencia:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(29, 358)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(100, 13)
        Me.Label26.TabIndex = 67
        Me.Label26.Text = "Promedio de Prepa:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(59, 399)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(70, 13)
        Me.Label27.TabIndex = 80
        Me.Label27.Text = "Documentos:"
        '
        'ocupacion
        '
        Me.ocupacion.Location = New System.Drawing.Point(986, 355)
        Me.ocupacion.Name = "ocupacion"
        Me.ocupacion.Size = New System.Drawing.Size(97, 20)
        Me.ocupacion.TabIndex = 78
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(918, 358)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(62, 13)
        Me.Label28.TabIndex = 77
        Me.Label28.Text = "Ocupación:"
        '
        'sexo
        '
        Me.sexo.FormattingEnabled = True
        Me.sexo.Items.AddRange(New Object() {"----", "HOMBRE", "MUJER", "OTRO"})
        Me.sexo.Location = New System.Drawing.Point(137, 224)
        Me.sexo.Name = "sexo"
        Me.sexo.Size = New System.Drawing.Size(95, 21)
        Me.sexo.TabIndex = 81
        '
        'est_civil
        '
        Me.est_civil.FormattingEnabled = True
        Me.est_civil.Items.AddRange(New Object() {"------", "SOLTERO/A", "CASADO/A", "DIVORCIADO/A", "VIUDO/A"})
        Me.est_civil.Location = New System.Drawing.Point(369, 268)
        Me.est_civil.Name = "est_civil"
        Me.est_civil.Size = New System.Drawing.Size(97, 21)
        Me.est_civil.TabIndex = 82
        '
        'guardar
        '
        Me.guardar.Location = New System.Drawing.Point(135, 477)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(156, 74)
        Me.guardar.TabIndex = 83
        Me.guardar.Text = "GUARDAR"
        Me.guardar.UseVisualStyleBackColor = True
        '
        'limpiar
        '
        Me.limpiar.Location = New System.Drawing.Point(365, 477)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(156, 74)
        Me.limpiar.TabIndex = 84
        Me.limpiar.Text = "LIMPIAR"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'imprimir
        '
        Me.imprimir.Location = New System.Drawing.Point(623, 477)
        Me.imprimir.Name = "imprimir"
        Me.imprimir.Size = New System.Drawing.Size(156, 74)
        Me.imprimir.TabIndex = 85
        Me.imprimir.Text = "IMPRIMIR"
        Me.imprimir.UseVisualStyleBackColor = True
        '
        'menu
        '
        Me.menu.Location = New System.Drawing.Point(892, 477)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(156, 74)
        Me.menu.TabIndex = 86
        Me.menu.Text = "MENÚ"
        Me.menu.UseVisualStyleBackColor = True
        '
        'documentos
        '
        Me.documentos.FormattingEnabled = True
        Me.documentos.Items.AddRange(New Object() {"--------", "SI", "NO"})
        Me.documentos.Location = New System.Drawing.Point(135, 396)
        Me.documentos.Name = "documentos"
        Me.documentos.Size = New System.Drawing.Size(97, 21)
        Me.documentos.TabIndex = 87
        '
        'estatus
        '
        Me.estatus.FormattingEnabled = True
        Me.estatus.Items.AddRange(New Object() {"------", "0", "1"})
        Me.estatus.Location = New System.Drawing.Point(576, 355)
        Me.estatus.Name = "estatus"
        Me.estatus.Size = New System.Drawing.Size(97, 21)
        Me.estatus.TabIndex = 88
        '
        'licenciatura
        '
        Me.licenciatura.FormattingEnabled = True
        Me.licenciatura.Items.AddRange(New Object() {"------------", "Infotmática", "Psicología", "Derecho", "Contaduria", "Administración", "Comunicación", "Mercadotecnia", "Pedagogía", "Turismo"})
        Me.licenciatura.Location = New System.Drawing.Point(790, 312)
        Me.licenciatura.Name = "licenciatura"
        Me.licenciatura.Size = New System.Drawing.Size(97, 21)
        Me.licenciatura.TabIndex = 89
        '
        'duracion
        '
        Me.duracion.FormattingEnabled = True
        Me.duracion.Items.AddRange(New Object() {"3 ", "4", "5"})
        Me.duracion.Location = New System.Drawing.Point(986, 312)
        Me.duracion.Name = "duracion"
        Me.duracion.Size = New System.Drawing.Size(97, 21)
        Me.duracion.TabIndex = 90
        '
        'N_Prospecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(1225, 741)
        Me.Controls.Add(Me.duracion)
        Me.Controls.Add(Me.licenciatura)
        Me.Controls.Add(Me.estatus)
        Me.Controls.Add(Me.documentos)
        Me.Controls.Add(Me.menu)
        Me.Controls.Add(Me.imprimir)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.guardar)
        Me.Controls.Add(Me.est_civil)
        Me.Controls.Add(Me.sexo)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.ocupacion)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.ciclo)
        Me.Controls.Add(Me.procedencia)
        Me.Controls.Add(Me.promedio)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.fecha_alta)
        Me.Controls.Add(Me.alcaldia)
        Me.Controls.Add(Me.ciudad)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.num_int)
        Me.Controls.Add(Me.celular)
        Me.Controls.Add(Me.num_ext)
        Me.Controls.Add(Me.calle)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.telefono)
        Me.Controls.Add(Me.correo)
        Me.Controls.Add(Me.nacion)
        Me.Controls.Add(Me.curp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.edad)
        Me.Controls.Add(Me.folio)
        Me.Controls.Add(Me.ap_materno)
        Me.Controls.Add(Me.ap_paterno)
        Me.Controls.Add(Me.nombres)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "N_Prospecto"
        Me.Text = "Nuevo Prospecto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents edad As TextBox
    Friend WithEvents folio As TextBox
    Friend WithEvents ap_materno As TextBox
    Friend WithEvents ap_paterno As TextBox
    Friend WithEvents nombres As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents telefono As TextBox
    Friend WithEvents correo As TextBox
    Friend WithEvents nacion As TextBox
    Friend WithEvents curp As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents num_int As TextBox
    Friend WithEvents celular As TextBox
    Friend WithEvents num_ext As TextBox
    Friend WithEvents calle As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents fecha_alta As TextBox
    Friend WithEvents alcaldia As TextBox
    Friend WithEvents ciudad As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents ciclo As TextBox
    Friend WithEvents procedencia As TextBox
    Friend WithEvents promedio As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents ocupacion As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents sexo As ComboBox
    Friend WithEvents est_civil As ComboBox
    Friend WithEvents guardar As Button
    Friend WithEvents limpiar As Button
    Friend WithEvents imprimir As Button
    Friend WithEvents menu As Button
    Friend WithEvents documentos As ComboBox
    Friend WithEvents estatus As ComboBox
    Friend WithEvents licenciatura As ComboBox
    Friend WithEvents duracion As ComboBox
End Class
