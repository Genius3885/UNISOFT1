<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class B_Proscpecto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(B_Proscpecto))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.ap_paterno = New System.Windows.Forms.TextBox()
        Me.ap_materno = New System.Windows.Forms.TextBox()
        Me.folio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.menu = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.estatus = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(438, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(435, 42)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "BUSCAR PROSPECTO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(337, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nombre(s):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(523, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Apellido Paterno:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(740, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Apellido Materno:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(196, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Folio:"
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(401, 121)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(97, 20)
        Me.nombre.TabIndex = 21
        '
        'ap_paterno
        '
        Me.ap_paterno.Location = New System.Drawing.Point(622, 121)
        Me.ap_paterno.Name = "ap_paterno"
        Me.ap_paterno.Size = New System.Drawing.Size(97, 20)
        Me.ap_paterno.TabIndex = 22
        '
        'ap_materno
        '
        Me.ap_materno.Location = New System.Drawing.Point(836, 121)
        Me.ap_materno.Name = "ap_materno"
        Me.ap_materno.Size = New System.Drawing.Size(97, 20)
        Me.ap_materno.TabIndex = 23
        '
        'folio
        '
        Me.folio.Location = New System.Drawing.Point(234, 121)
        Me.folio.Name = "folio"
        Me.folio.Size = New System.Drawing.Size(97, 20)
        Me.folio.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(944, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Estatus:"
        '
        'nuevo
        '
        Me.nuevo.Location = New System.Drawing.Point(194, 569)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(156, 74)
        Me.nuevo.TabIndex = 27
        Me.nuevo.Text = "BUSCAR PROSPECTO"
        Me.nuevo.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(574, 569)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(156, 74)
        Me.Limpiar.TabIndex = 28
        Me.Limpiar.Text = "LIMPIAR"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'menu
        '
        Me.menu.Location = New System.Drawing.Point(931, 569)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(156, 74)
        Me.menu.TabIndex = 29
        Me.menu.Text = "MENÚ"
        Me.menu.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(93, 183)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1096, 301)
        Me.DataGridView1.TabIndex = 30
        '
        'estatus
        '
        Me.estatus.FormattingEnabled = True
        Me.estatus.Location = New System.Drawing.Point(995, 121)
        Me.estatus.Name = "estatus"
        Me.estatus.Size = New System.Drawing.Size(96, 21)
        Me.estatus.TabIndex = 31
        '
        'B_Proscpecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(1225, 741)
        Me.Controls.Add(Me.estatus)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.menu)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.nuevo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.folio)
        Me.Controls.Add(Me.ap_materno)
        Me.Controls.Add(Me.ap_paterno)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "B_Proscpecto"
        Me.Text = "Buscar Prospecto"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nombre As TextBox
    Friend WithEvents ap_paterno As TextBox
    Friend WithEvents ap_materno As TextBox
    Friend WithEvents folio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents nuevo As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents menu As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents estatus As ComboBox
End Class
