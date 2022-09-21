<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABMUsuario
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GBdni = New System.Windows.Forms.GroupBox()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.GBRPass = New System.Windows.Forms.GroupBox()
        Me.TxtContraseña2 = New System.Windows.Forms.TextBox()
        Me.GBPass = New System.Windows.Forms.GroupBox()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.LEtiqueta = New System.Windows.Forms.Label()
        Me.GBUsername = New System.Windows.Forms.GroupBox()
        Me.Txtusuario = New System.Windows.Forms.TextBox()
        Me.GBApellido = New System.Windows.Forms.GroupBox()
        Me.TxtApe = New System.Windows.Forms.TextBox()
        Me.GBNombre = New System.Windows.Forms.GroupBox()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GBTipo = New System.Windows.Forms.GroupBox()
        Me.RBGerente = New System.Windows.Forms.RadioButton()
        Me.RBAdmin = New System.Windows.Forms.RadioButton()
        Me.RBEmpleado = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBFiltrar = New System.Windows.Forms.GroupBox()
        Me.RBtodos = New System.Windows.Forms.RadioButton()
        Me.RBusername = New System.Windows.Forms.RadioButton()
        Me.RBdni = New System.Windows.Forms.RadioButton()
        Me.RBape = New System.Windows.Forms.RadioButton()
        Me.RBnom = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBdni = New System.Windows.Forms.ComboBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CBusername = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CBape = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CBnom = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GBdni.SuspendLayout()
        Me.GBRPass.SuspendLayout()
        Me.GBPass.SuspendLayout()
        Me.GBUsername.SuspendLayout()
        Me.GBApellido.SuspendLayout()
        Me.GBNombre.SuspendLayout()
        Me.GBTipo.SuspendLayout()
        Me.GBFiltrar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.GBFiltrar)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.GBdni)
        Me.Panel1.Controls.Add(Me.GBRPass)
        Me.Panel1.Controls.Add(Me.GBPass)
        Me.Panel1.Controls.Add(Me.GBUsername)
        Me.Panel1.Controls.Add(Me.GBApellido)
        Me.Panel1.Controls.Add(Me.GBNombre)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.GBTipo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(861, 508)
        Me.Panel1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(149, 157)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 27)
        Me.Button3.TabIndex = 61
        Me.Button3.Text = "Guardar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GBdni
        '
        Me.GBdni.BackColor = System.Drawing.Color.Transparent
        Me.GBdni.Controls.Add(Me.TxtDNI)
        Me.GBdni.ForeColor = System.Drawing.SystemColors.Window
        Me.GBdni.Location = New System.Drawing.Point(34, 20)
        Me.GBdni.Name = "GBdni"
        Me.GBdni.Size = New System.Drawing.Size(167, 57)
        Me.GBdni.TabIndex = 56
        Me.GBdni.TabStop = False
        Me.GBdni.Text = "DNI"
        '
        'TxtDNI
        '
        Me.TxtDNI.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDNI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtDNI.Location = New System.Drawing.Point(18, 21)
        Me.TxtDNI.MaxLength = 8
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(133, 20)
        Me.TxtDNI.TabIndex = 2
        '
        'GBRPass
        '
        Me.GBRPass.BackColor = System.Drawing.Color.Transparent
        Me.GBRPass.Controls.Add(Me.TxtContraseña2)
        Me.GBRPass.ForeColor = System.Drawing.SystemColors.Window
        Me.GBRPass.Location = New System.Drawing.Point(431, 95)
        Me.GBRPass.Name = "GBRPass"
        Me.GBRPass.Size = New System.Drawing.Size(199, 47)
        Me.GBRPass.TabIndex = 57
        Me.GBRPass.TabStop = False
        Me.GBRPass.Text = "Repetir Contraseña"
        '
        'TxtContraseña2
        '
        Me.TxtContraseña2.BackColor = System.Drawing.SystemColors.Window
        Me.TxtContraseña2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtContraseña2.Location = New System.Drawing.Point(17, 21)
        Me.TxtContraseña2.Name = "TxtContraseña2"
        Me.TxtContraseña2.Size = New System.Drawing.Size(164, 20)
        Me.TxtContraseña2.TabIndex = 6
        '
        'GBPass
        '
        Me.GBPass.BackColor = System.Drawing.Color.Transparent
        Me.GBPass.Controls.Add(Me.TxtContraseña)
        Me.GBPass.Controls.Add(Me.LEtiqueta)
        Me.GBPass.ForeColor = System.Drawing.SystemColors.Window
        Me.GBPass.Location = New System.Drawing.Point(217, 95)
        Me.GBPass.Name = "GBPass"
        Me.GBPass.Size = New System.Drawing.Size(199, 45)
        Me.GBPass.TabIndex = 59
        Me.GBPass.TabStop = False
        Me.GBPass.Text = "Contraseña"
        '
        'TxtContraseña
        '
        Me.TxtContraseña.BackColor = System.Drawing.SystemColors.Window
        Me.TxtContraseña.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtContraseña.Location = New System.Drawing.Point(18, 21)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(163, 20)
        Me.TxtContraseña.TabIndex = 4
        '
        'LEtiqueta
        '
        Me.LEtiqueta.AutoSize = True
        Me.LEtiqueta.Location = New System.Drawing.Point(16, 46)
        Me.LEtiqueta.Name = "LEtiqueta"
        Me.LEtiqueta.Size = New System.Drawing.Size(0, 13)
        Me.LEtiqueta.TabIndex = 41
        '
        'GBUsername
        '
        Me.GBUsername.BackColor = System.Drawing.Color.Transparent
        Me.GBUsername.Controls.Add(Me.Txtusuario)
        Me.GBUsername.ForeColor = System.Drawing.SystemColors.Window
        Me.GBUsername.Location = New System.Drawing.Point(34, 83)
        Me.GBUsername.Name = "GBUsername"
        Me.GBUsername.Size = New System.Drawing.Size(167, 57)
        Me.GBUsername.TabIndex = 58
        Me.GBUsername.TabStop = False
        Me.GBUsername.Text = "Nombre de Usuario"
        '
        'Txtusuario
        '
        Me.Txtusuario.BackColor = System.Drawing.SystemColors.Window
        Me.Txtusuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txtusuario.Location = New System.Drawing.Point(17, 21)
        Me.Txtusuario.Name = "Txtusuario"
        Me.Txtusuario.Size = New System.Drawing.Size(134, 20)
        Me.Txtusuario.TabIndex = 3
        '
        'GBApellido
        '
        Me.GBApellido.BackColor = System.Drawing.Color.Transparent
        Me.GBApellido.Controls.Add(Me.TxtApe)
        Me.GBApellido.ForeColor = System.Drawing.SystemColors.Window
        Me.GBApellido.Location = New System.Drawing.Point(394, 20)
        Me.GBApellido.Name = "GBApellido"
        Me.GBApellido.Size = New System.Drawing.Size(167, 57)
        Me.GBApellido.TabIndex = 54
        Me.GBApellido.TabStop = False
        Me.GBApellido.Text = "Apellido"
        '
        'TxtApe
        '
        Me.TxtApe.BackColor = System.Drawing.SystemColors.Window
        Me.TxtApe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtApe.Location = New System.Drawing.Point(18, 21)
        Me.TxtApe.Name = "TxtApe"
        Me.TxtApe.Size = New System.Drawing.Size(134, 20)
        Me.TxtApe.TabIndex = 1
        '
        'GBNombre
        '
        Me.GBNombre.BackColor = System.Drawing.Color.Transparent
        Me.GBNombre.Controls.Add(Me.TxtNom)
        Me.GBNombre.ForeColor = System.Drawing.SystemColors.Window
        Me.GBNombre.Location = New System.Drawing.Point(217, 20)
        Me.GBNombre.Name = "GBNombre"
        Me.GBNombre.Size = New System.Drawing.Size(167, 57)
        Me.GBNombre.TabIndex = 53
        Me.GBNombre.TabStop = False
        Me.GBNombre.Text = "Nombre"
        '
        'TxtNom
        '
        Me.TxtNom.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtNom.Location = New System.Drawing.Point(17, 21)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(134, 20)
        Me.TxtNom.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(290, 157)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 27)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GBTipo
        '
        Me.GBTipo.BackColor = System.Drawing.Color.Transparent
        Me.GBTipo.Controls.Add(Me.RBGerente)
        Me.GBTipo.Controls.Add(Me.RBAdmin)
        Me.GBTipo.Controls.Add(Me.RBEmpleado)
        Me.GBTipo.ForeColor = System.Drawing.SystemColors.Window
        Me.GBTipo.Location = New System.Drawing.Point(655, 20)
        Me.GBTipo.Name = "GBTipo"
        Me.GBTipo.Size = New System.Drawing.Size(144, 107)
        Me.GBTipo.TabIndex = 60
        Me.GBTipo.TabStop = False
        Me.GBTipo.Text = "Tipo de Usuario"
        '
        'RBGerente
        '
        Me.RBGerente.AutoSize = True
        Me.RBGerente.Location = New System.Drawing.Point(18, 51)
        Me.RBGerente.Name = "RBGerente"
        Me.RBGerente.Size = New System.Drawing.Size(63, 17)
        Me.RBGerente.TabIndex = 11
        Me.RBGerente.TabStop = True
        Me.RBGerente.Text = "Gerente"
        Me.RBGerente.UseVisualStyleBackColor = True
        '
        'RBAdmin
        '
        Me.RBAdmin.AutoSize = True
        Me.RBAdmin.Location = New System.Drawing.Point(18, 23)
        Me.RBAdmin.Name = "RBAdmin"
        Me.RBAdmin.Size = New System.Drawing.Size(88, 17)
        Me.RBAdmin.TabIndex = 8
        Me.RBAdmin.TabStop = True
        Me.RBAdmin.Text = "Administrador"
        Me.RBAdmin.UseVisualStyleBackColor = True
        '
        'RBEmpleado
        '
        Me.RBEmpleado.AutoSize = True
        Me.RBEmpleado.Location = New System.Drawing.Point(18, 75)
        Me.RBEmpleado.Name = "RBEmpleado"
        Me.RBEmpleado.Size = New System.Drawing.Size(72, 17)
        Me.RBEmpleado.TabIndex = 10
        Me.RBEmpleado.TabStop = True
        Me.RBEmpleado.Text = "Empleado"
        Me.RBEmpleado.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Registrar usuario"
        '
        'GBFiltrar
        '
        Me.GBFiltrar.BackColor = System.Drawing.Color.Transparent
        Me.GBFiltrar.Controls.Add(Me.RBtodos)
        Me.GBFiltrar.Controls.Add(Me.RBusername)
        Me.GBFiltrar.Controls.Add(Me.RBdni)
        Me.GBFiltrar.Controls.Add(Me.RBape)
        Me.GBFiltrar.Controls.Add(Me.RBnom)
        Me.GBFiltrar.Controls.Add(Me.GroupBox1)
        Me.GBFiltrar.Controls.Add(Me.BBuscar)
        Me.GBFiltrar.Controls.Add(Me.GroupBox2)
        Me.GBFiltrar.Controls.Add(Me.GroupBox3)
        Me.GBFiltrar.Controls.Add(Me.GroupBox4)
        Me.GBFiltrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBFiltrar.Location = New System.Drawing.Point(34, 187)
        Me.GBFiltrar.Name = "GBFiltrar"
        Me.GBFiltrar.Size = New System.Drawing.Size(681, 117)
        Me.GBFiltrar.TabIndex = 64
        Me.GBFiltrar.TabStop = False
        Me.GBFiltrar.Text = "Filtrar Por"
        '
        'RBtodos
        '
        Me.RBtodos.AutoSize = True
        Me.RBtodos.Location = New System.Drawing.Point(9, 33)
        Me.RBtodos.Name = "RBtodos"
        Me.RBtodos.Size = New System.Drawing.Size(115, 17)
        Me.RBtodos.TabIndex = 26
        Me.RBtodos.TabStop = True
        Me.RBtodos.Text = "Todos los Usuarios"
        Me.RBtodos.UseVisualStyleBackColor = True
        '
        'RBusername
        '
        Me.RBusername.AutoSize = True
        Me.RBusername.Location = New System.Drawing.Point(539, 20)
        Me.RBusername.Name = "RBusername"
        Me.RBusername.Size = New System.Drawing.Size(116, 17)
        Me.RBusername.TabIndex = 25
        Me.RBusername.TabStop = True
        Me.RBusername.Text = "Nombre de Usuario"
        Me.RBusername.UseVisualStyleBackColor = True
        '
        'RBdni
        '
        Me.RBdni.AutoSize = True
        Me.RBdni.Location = New System.Drawing.Point(139, 21)
        Me.RBdni.Name = "RBdni"
        Me.RBdni.Size = New System.Drawing.Size(41, 17)
        Me.RBdni.TabIndex = 24
        Me.RBdni.TabStop = True
        Me.RBdni.Text = "Dni"
        Me.RBdni.UseVisualStyleBackColor = True
        '
        'RBape
        '
        Me.RBape.AutoSize = True
        Me.RBape.Location = New System.Drawing.Point(399, 20)
        Me.RBape.Name = "RBape"
        Me.RBape.Size = New System.Drawing.Size(62, 17)
        Me.RBape.TabIndex = 23
        Me.RBape.TabStop = True
        Me.RBape.Text = "Apellido"
        Me.RBape.UseVisualStyleBackColor = True
        '
        'RBnom
        '
        Me.RBnom.AutoSize = True
        Me.RBnom.Location = New System.Drawing.Point(266, 20)
        Me.RBnom.Name = "RBnom"
        Me.RBnom.Size = New System.Drawing.Size(62, 17)
        Me.RBnom.TabIndex = 22
        Me.RBnom.TabStop = True
        Me.RBnom.Text = "Nombre"
        Me.RBnom.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CBdni)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(133, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 51)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "dni"
        '
        'CBdni
        '
        Me.CBdni.FormattingEnabled = True
        Me.CBdni.Location = New System.Drawing.Point(6, 18)
        Me.CBdni.Name = "CBdni"
        Me.CBdni.Size = New System.Drawing.Size(115, 21)
        Me.CBdni.TabIndex = 2
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BBuscar.Location = New System.Drawing.Point(9, 66)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(117, 27)
        Me.BBuscar.TabIndex = 6
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CBusername)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(539, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(127, 51)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "nombre de usuario"
        '
        'CBusername
        '
        Me.CBusername.FormattingEnabled = True
        Me.CBusername.Location = New System.Drawing.Point(6, 16)
        Me.CBusername.Name = "CBusername"
        Me.CBusername.Size = New System.Drawing.Size(115, 21)
        Me.CBusername.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.CBape)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(399, 44)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(127, 51)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "apellido"
        '
        'CBape
        '
        Me.CBape.FormattingEnabled = True
        Me.CBape.Location = New System.Drawing.Point(6, 18)
        Me.CBape.Name = "CBape"
        Me.CBape.Size = New System.Drawing.Size(115, 21)
        Me.CBape.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.CBnom)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox4.Location = New System.Drawing.Point(266, 43)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(127, 51)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "nombre"
        '
        'CBnom
        '
        Me.CBnom.FormattingEnabled = True
        Me.CBnom.Location = New System.Drawing.Point(6, 19)
        Me.CBnom.Name = "CBnom"
        Me.CBnom.Size = New System.Drawing.Size(115, 21)
        Me.CBnom.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(30, 320)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowTemplate.Height = 50
        Me.DataGridView1.Size = New System.Drawing.Size(686, 177)
        Me.DataGridView1.TabIndex = 63
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 508)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GBdni.ResumeLayout(False)
        Me.GBdni.PerformLayout()
        Me.GBRPass.ResumeLayout(False)
        Me.GBRPass.PerformLayout()
        Me.GBPass.ResumeLayout(False)
        Me.GBPass.PerformLayout()
        Me.GBUsername.ResumeLayout(False)
        Me.GBUsername.PerformLayout()
        Me.GBApellido.ResumeLayout(False)
        Me.GBApellido.PerformLayout()
        Me.GBNombre.ResumeLayout(False)
        Me.GBNombre.PerformLayout()
        Me.GBTipo.ResumeLayout(False)
        Me.GBTipo.PerformLayout()
        Me.GBFiltrar.ResumeLayout(False)
        Me.GBFiltrar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents GBdni As GroupBox
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents GBRPass As GroupBox
    Friend WithEvents TxtContraseña2 As TextBox
    Friend WithEvents GBPass As GroupBox
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents LEtiqueta As Label
    Friend WithEvents GBUsername As GroupBox
    Friend WithEvents Txtusuario As TextBox
    Friend WithEvents GBApellido As GroupBox
    Friend WithEvents TxtApe As TextBox
    Friend WithEvents GBNombre As GroupBox
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents GBTipo As GroupBox
    Friend WithEvents RBGerente As RadioButton
    Friend WithEvents RBAdmin As RadioButton
    Friend WithEvents RBEmpleado As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents GBFiltrar As GroupBox
    Friend WithEvents RBtodos As RadioButton
    Friend WithEvents RBusername As RadioButton
    Friend WithEvents RBdni As RadioButton
    Friend WithEvents RBape As RadioButton
    Friend WithEvents RBnom As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBdni As ComboBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CBusername As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CBape As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CBnom As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
