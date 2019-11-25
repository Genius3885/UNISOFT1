<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Unisoft
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Unisoft))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.Alumno = New System.Windows.Forms.TabPage()
        Me.promoydif = New System.Windows.Forms.TabPage()
        Me.buscar = New System.Windows.Forms.Button()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Fin = New System.Windows.Forms.TabPage()
        Me.EscolOrd = New System.Windows.Forms.TabPage()
        Me.Plan = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DetallesEst = New System.Windows.Forms.Button()
        Me.Cicloesc = New System.Windows.Forms.Button()
        Me.PlanEstud = New System.Windows.Forms.Button()
        Me.Grupo = New System.Windows.Forms.Button()
        Me.Profes = New System.Windows.Forms.Button()
        Me.Materia = New System.Windows.Forms.Button()
        Me.Licen = New System.Windows.Forms.Button()
        Me.Aud = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Cerrarsession = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Alumnos = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Auditoria = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Finanzas = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Plante = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EscolarOrd = New System.Windows.Forms.Button()
        Me.PromoyDifu = New System.Windows.Forms.Button()
        Me.TabControl.SuspendLayout()
        Me.promoydif.SuspendLayout()
        Me.Plan.SuspendLayout()
        Me.Aud.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.Alumno)
        Me.TabControl.Controls.Add(Me.promoydif)
        Me.TabControl.Controls.Add(Me.Fin)
        Me.TabControl.Controls.Add(Me.EscolOrd)
        Me.TabControl.Controls.Add(Me.Plan)
        Me.TabControl.Controls.Add(Me.Aud)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1225, 741)
        Me.TabControl.TabIndex = 1
        '
        'Alumno
        '
        Me.Alumno.BackColor = System.Drawing.Color.Khaki
        Me.Alumno.Location = New System.Drawing.Point(4, 22)
        Me.Alumno.Name = "Alumno"
        Me.Alumno.Padding = New System.Windows.Forms.Padding(3)
        Me.Alumno.Size = New System.Drawing.Size(1217, 715)
        Me.Alumno.TabIndex = 0
        Me.Alumno.Text = "Alumnos"
        '
        'promoydif
        '
        Me.promoydif.BackColor = System.Drawing.Color.Khaki
        Me.promoydif.Controls.Add(Me.buscar)
        Me.promoydif.Controls.Add(Me.nuevo)
        Me.promoydif.Controls.Add(Me.Label3)
        Me.promoydif.Controls.Add(Me.Label2)
        Me.promoydif.Location = New System.Drawing.Point(4, 22)
        Me.promoydif.Name = "promoydif"
        Me.promoydif.Padding = New System.Windows.Forms.Padding(3)
        Me.promoydif.Size = New System.Drawing.Size(1217, 715)
        Me.promoydif.TabIndex = 1
        Me.promoydif.Text = "Promoción y Difusion"
        '
        'buscar
        '
        Me.buscar.Location = New System.Drawing.Point(662, 182)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(156, 74)
        Me.buscar.TabIndex = 18
        Me.buscar.Text = "BUSCAR PROSPECTO"
        Me.buscar.UseVisualStyleBackColor = True
        '
        'nuevo
        '
        Me.nuevo.Location = New System.Drawing.Point(299, 182)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(156, 74)
        Me.nuevo.TabIndex = 17
        Me.nuevo.Text = " NUEVO PROSPECTO"
        Me.nuevo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(513, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 42)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "MENÚ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(301, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(501, 42)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "PROMOSIÓN Y DIFUSIÓN "
        '
        'Fin
        '
        Me.Fin.BackColor = System.Drawing.Color.Khaki
        Me.Fin.Location = New System.Drawing.Point(4, 22)
        Me.Fin.Name = "Fin"
        Me.Fin.Padding = New System.Windows.Forms.Padding(3)
        Me.Fin.Size = New System.Drawing.Size(1217, 715)
        Me.Fin.TabIndex = 2
        Me.Fin.Text = "Finanzas"
        '
        'EscolOrd
        '
        Me.EscolOrd.BackColor = System.Drawing.Color.Khaki
        Me.EscolOrd.Location = New System.Drawing.Point(4, 22)
        Me.EscolOrd.Name = "EscolOrd"
        Me.EscolOrd.Padding = New System.Windows.Forms.Padding(3)
        Me.EscolOrd.Size = New System.Drawing.Size(1217, 715)
        Me.EscolOrd.TabIndex = 3
        Me.EscolOrd.Text = "Escolar Ordinario"
        '
        'Plan
        '
        Me.Plan.BackColor = System.Drawing.Color.Khaki
        Me.Plan.Controls.Add(Me.Label1)
        Me.Plan.Controls.Add(Me.DetallesEst)
        Me.Plan.Controls.Add(Me.Cicloesc)
        Me.Plan.Controls.Add(Me.PlanEstud)
        Me.Plan.Controls.Add(Me.Grupo)
        Me.Plan.Controls.Add(Me.Profes)
        Me.Plan.Controls.Add(Me.Materia)
        Me.Plan.Controls.Add(Me.Licen)
        Me.Plan.Location = New System.Drawing.Point(4, 22)
        Me.Plan.Name = "Plan"
        Me.Plan.Padding = New System.Windows.Forms.Padding(3)
        Me.Plan.Size = New System.Drawing.Size(1217, 715)
        Me.Plan.TabIndex = 4
        Me.Plan.Text = "Plantel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(329, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 42)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "MENU PLANTEL"
        '
        'DetallesEst
        '
        Me.DetallesEst.Location = New System.Drawing.Point(336, 226)
        Me.DetallesEst.Name = "DetallesEst"
        Me.DetallesEst.Size = New System.Drawing.Size(160, 61)
        Me.DetallesEst.TabIndex = 13
        Me.DetallesEst.Text = "DETALLE PLAN ESTUDIO"
        Me.DetallesEst.UseVisualStyleBackColor = True
        '
        'Cicloesc
        '
        Me.Cicloesc.Location = New System.Drawing.Point(526, 226)
        Me.Cicloesc.Name = "Cicloesc"
        Me.Cicloesc.Size = New System.Drawing.Size(160, 61)
        Me.Cicloesc.TabIndex = 12
        Me.Cicloesc.Text = "CICLO ESCOLAR"
        Me.Cicloesc.UseVisualStyleBackColor = True
        '
        'PlanEstud
        '
        Me.PlanEstud.Location = New System.Drawing.Point(142, 226)
        Me.PlanEstud.Name = "PlanEstud"
        Me.PlanEstud.Size = New System.Drawing.Size(158, 61)
        Me.PlanEstud.TabIndex = 11
        Me.PlanEstud.Text = "PLAN DE ESTUDIO"
        Me.PlanEstud.UseVisualStyleBackColor = True
        '
        'Grupo
        '
        Me.Grupo.Location = New System.Drawing.Point(721, 129)
        Me.Grupo.Name = "Grupo"
        Me.Grupo.Size = New System.Drawing.Size(161, 58)
        Me.Grupo.TabIndex = 10
        Me.Grupo.Text = "GRUPOS"
        Me.Grupo.UseVisualStyleBackColor = True
        '
        'Profes
        '
        Me.Profes.Location = New System.Drawing.Point(526, 129)
        Me.Profes.Name = "Profes"
        Me.Profes.Size = New System.Drawing.Size(160, 57)
        Me.Profes.TabIndex = 9
        Me.Profes.Text = "PROFESORES"
        Me.Profes.UseVisualStyleBackColor = True
        '
        'Materia
        '
        Me.Materia.Location = New System.Drawing.Point(336, 129)
        Me.Materia.Name = "Materia"
        Me.Materia.Size = New System.Drawing.Size(160, 58)
        Me.Materia.TabIndex = 8
        Me.Materia.Text = "MATERIAS"
        Me.Materia.UseVisualStyleBackColor = True
        '
        'Licen
        '
        Me.Licen.Location = New System.Drawing.Point(142, 129)
        Me.Licen.Name = "Licen"
        Me.Licen.Size = New System.Drawing.Size(156, 58)
        Me.Licen.TabIndex = 1
        Me.Licen.Text = "LICENCIATURAS"
        Me.Licen.UseVisualStyleBackColor = True
        '
        'Aud
        '
        Me.Aud.BackColor = System.Drawing.Color.Khaki
        Me.Aud.Controls.Add(Me.Label6)
        Me.Aud.Location = New System.Drawing.Point(4, 22)
        Me.Aud.Name = "Aud"
        Me.Aud.Padding = New System.Windows.Forms.Padding(3)
        Me.Aud.Size = New System.Drawing.Size(1217, 715)
        Me.Aud.TabIndex = 5
        Me.Aud.Text = "Auditoria"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(338, 624)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Label6"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.Cerrarsession)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Alumnos)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Auditoria)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Finanzas)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Plante)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.EscolarOrd)
        Me.Panel2.Controls.Add(Me.PromoyDifu)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1225, 79)
        Me.Panel2.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UNISOFT.My.Resources.Resources.Imagen2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Black
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Khaki
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Transparent
        Me.Button7.Location = New System.Drawing.Point(1071, 11)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(142, 41)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Cerrar Session"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Cerrarsession
        '
        Me.Cerrarsession.BackColor = System.Drawing.Color.Black
        Me.Cerrarsession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cerrarsession.FlatAppearance.BorderColor = System.Drawing.Color.Khaki
        Me.Cerrarsession.FlatAppearance.BorderSize = 0
        Me.Cerrarsession.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.Cerrarsession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod
        Me.Cerrarsession.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cerrarsession.ForeColor = System.Drawing.Color.Transparent
        Me.Cerrarsession.Location = New System.Drawing.Point(1071, 20)
        Me.Cerrarsession.Name = "Cerrarsession"
        Me.Cerrarsession.Size = New System.Drawing.Size(142, 41)
        Me.Cerrarsession.TabIndex = 8
        Me.Cerrarsession.Text = "Cerrar Session"
        Me.Cerrarsession.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Black
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Khaki
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Transparent
        Me.Button6.Location = New System.Drawing.Point(126, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(142, 41)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "Alumnos"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Khaki
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Transparent
        Me.Button5.Location = New System.Drawing.Point(794, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(142, 41)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Auditoria"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Alumnos
        '
        Me.Alumnos.BackColor = System.Drawing.Color.Black
        Me.Alumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Alumnos.FlatAppearance.BorderColor = System.Drawing.Color.Khaki
        Me.Alumnos.FlatAppearance.BorderSize = 0
        Me.Alumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.Alumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod
        Me.Alumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Alumnos.ForeColor = System.Drawing.Color.Transparent
        Me.Alumnos.Location = New System.Drawing.Point(126, 21)
        Me.Alumnos.Name = "Alumnos"
        Me.Alumnos.Size = New System.Drawing.Size(142, 41)
        Me.Alumnos.TabIndex = 1
        Me.Alumnos.Text = "Alumnos"
        Me.Alumnos.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Khaki
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Transparent
        Me.Button4.Location = New System.Drawing.Point(409, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(142, 41)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Finanzas"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Auditoria
        '
        Me.Auditoria.BackColor = System.Drawing.Color.Black
        Me.Auditoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Auditoria.FlatAppearance.BorderColor = System.Drawing.Color.Khaki
        Me.Auditoria.FlatAppearance.BorderSize = 0
        Me.Auditoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.Auditoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod
        Me.Auditoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Auditoria.ForeColor = System.Drawing.Color.Transparent
        Me.Auditoria.Location = New System.Drawing.Point(794, 21)
        Me.Auditoria.Name = "Auditoria"
        Me.Auditoria.Size = New System.Drawing.Size(142, 41)
        Me.Auditoria.TabIndex = 6
        Me.Auditoria.Text = "Auditoria"
        Me.Auditoria.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Khaki
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(664, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(142, 41)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Plantel"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Finanzas
        '
        Me.Finanzas.BackColor = System.Drawing.Color.Black
        Me.Finanzas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Finanzas.FlatAppearance.BorderColor = System.Drawing.Color.Khaki
        Me.Finanzas.FlatAppearance.BorderSize = 0
        Me.Finanzas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.Finanzas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod
        Me.Finanzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Finanzas.ForeColor = System.Drawing.Color.Transparent
        Me.Finanzas.Location = New System.Drawing.Point(409, 21)
        Me.Finanzas.Name = "Finanzas"
        Me.Finanzas.Size = New System.Drawing.Size(142, 41)
        Me.Finanzas.TabIndex = 2
        Me.Finanzas.Text = "Finanzas"
        Me.Finanzas.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Khaki
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(540, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 41)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Escolar Ordinario"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Plante
        '
        Me.Plante.BackColor = System.Drawing.Color.Black
        Me.Plante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Plante.FlatAppearance.BorderColor = System.Drawing.Color.Khaki
        Me.Plante.FlatAppearance.BorderSize = 0
        Me.Plante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.Plante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod
        Me.Plante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Plante.ForeColor = System.Drawing.Color.Transparent
        Me.Plante.Location = New System.Drawing.Point(664, 21)
        Me.Plante.Name = "Plante"
        Me.Plante.Size = New System.Drawing.Size(142, 41)
        Me.Plante.TabIndex = 4
        Me.Plante.Text = "Plantel"
        Me.Plante.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Khaki
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(261, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 41)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Promoción y Difusion"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'EscolarOrd
        '
        Me.EscolarOrd.BackColor = System.Drawing.Color.Black
        Me.EscolarOrd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.EscolarOrd.FlatAppearance.BorderColor = System.Drawing.Color.Khaki
        Me.EscolarOrd.FlatAppearance.BorderSize = 0
        Me.EscolarOrd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.EscolarOrd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod
        Me.EscolarOrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EscolarOrd.ForeColor = System.Drawing.Color.Transparent
        Me.EscolarOrd.Location = New System.Drawing.Point(540, 21)
        Me.EscolarOrd.Name = "EscolarOrd"
        Me.EscolarOrd.Size = New System.Drawing.Size(142, 41)
        Me.EscolarOrd.TabIndex = 5
        Me.EscolarOrd.Text = "Escolar Ordinario"
        Me.EscolarOrd.UseVisualStyleBackColor = False
        '
        'PromoyDifu
        '
        Me.PromoyDifu.BackColor = System.Drawing.Color.Black
        Me.PromoyDifu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PromoyDifu.FlatAppearance.BorderColor = System.Drawing.Color.Khaki
        Me.PromoyDifu.FlatAppearance.BorderSize = 0
        Me.PromoyDifu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.PromoyDifu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod
        Me.PromoyDifu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PromoyDifu.ForeColor = System.Drawing.Color.Transparent
        Me.PromoyDifu.Location = New System.Drawing.Point(261, 21)
        Me.PromoyDifu.Name = "PromoyDifu"
        Me.PromoyDifu.Size = New System.Drawing.Size(142, 41)
        Me.PromoyDifu.TabIndex = 7
        Me.PromoyDifu.Text = "Promoción y Difusion"
        Me.PromoyDifu.UseVisualStyleBackColor = False
        '
        'Unisoft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(1225, 741)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximumSize = New System.Drawing.Size(1241, 780)
        Me.MinimumSize = New System.Drawing.Size(1241, 726)
        Me.Name = "Unisoft"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Unisoft"
        Me.TabControl.ResumeLayout(False)
        Me.promoydif.ResumeLayout(False)
        Me.promoydif.PerformLayout()
        Me.Plan.ResumeLayout(False)
        Me.Plan.PerformLayout()
        Me.Aud.ResumeLayout(False)
        Me.Aud.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabControl As TabControl
    Friend WithEvents Alumno As TabPage
    Friend WithEvents promoydif As TabPage
    Friend WithEvents Fin As TabPage
    Friend WithEvents EscolOrd As TabPage
    Friend WithEvents Plan As TabPage
    Friend WithEvents Aud As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Cerrarsession As Button
    Friend WithEvents Alumnos As Button
    Friend WithEvents Auditoria As Button
    Friend WithEvents Finanzas As Button
    Friend WithEvents Plante As Button
    Friend WithEvents EscolarOrd As Button
    Friend WithEvents PromoyDifu As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DetallesEst As Button
    Friend WithEvents Cicloesc As Button
    Friend WithEvents PlanEstud As Button
    Friend WithEvents Grupo As Button
    Friend WithEvents Profes As Button
    Friend WithEvents Materia As Button
    Friend WithEvents Licen As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents buscar As Button
    Friend WithEvents nuevo As Button
End Class
