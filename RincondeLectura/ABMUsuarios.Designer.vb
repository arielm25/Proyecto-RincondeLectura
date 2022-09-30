<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMUsuarios
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NyA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBFiltrar = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.RBEliminados = New System.Windows.Forms.RadioButton()
        Me.RBActivos = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBDni = New System.Windows.Forms.TextBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.GBMail = New System.Windows.Forms.GroupBox()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.GBdni = New System.Windows.Forms.GroupBox()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.GBTelefono = New System.Windows.Forms.GroupBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.GBDireccion = New System.Windows.Forms.GroupBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.GBusername = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GBApellido = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GBNombre = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GBContraseña = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GBTipo = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBFiltrar.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBMail.SuspendLayout()
        Me.GBdni.SuspendLayout()
        Me.GBTelefono.SuspendLayout()
        Me.GBDireccion.SuspendLayout()
        Me.GBusername.SuspendLayout()
        Me.GBApellido.SuspendLayout()
        Me.GBNombre.SuspendLayout()
        Me.GBContraseña.SuspendLayout()
        Me.GBTipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DNI, Me.NyA, Me.Direccion, Me.Telefono, Me.Mail, Me.Eliminar})
        Me.DataGridView1.Location = New System.Drawing.Point(45, 235)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(611, 207)
        Me.DataGridView1.TabIndex = 66
        '
        'DNI
        '
        Me.DNI.HeaderText = "DNI"
        Me.DNI.MinimumWidth = 6
        Me.DNI.Name = "DNI"
        '
        'NyA
        '
        Me.NyA.HeaderText = "Nombre y Apellido"
        Me.NyA.MinimumWidth = 6
        Me.NyA.Name = "NyA"
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.MinimumWidth = 6
        Me.Direccion.Name = "Direccion"
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.MinimumWidth = 6
        Me.Telefono.Name = "Telefono"
        '
        'Mail
        '
        Me.Mail.HeaderText = "Mail"
        Me.Mail.MinimumWidth = 6
        Me.Mail.Name = "Mail"
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        '
        'GBFiltrar
        '
        Me.GBFiltrar.BackColor = System.Drawing.Color.Black
        Me.GBFiltrar.Controls.Add(Me.GroupBox2)
        Me.GBFiltrar.Controls.Add(Me.RBEliminados)
        Me.GBFiltrar.Controls.Add(Me.RBActivos)
        Me.GBFiltrar.Controls.Add(Me.GroupBox1)
        Me.GBFiltrar.Controls.Add(Me.BBuscar)
        Me.GBFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBFiltrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBFiltrar.Location = New System.Drawing.Point(45, 151)
        Me.GBFiltrar.Name = "GBFiltrar"
        Me.GBFiltrar.Size = New System.Drawing.Size(611, 77)
        Me.GBFiltrar.TabIndex = 67
        Me.GBFiltrar.TabStop = False
        Me.GBFiltrar.Text = "Filtrar Por"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(323, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(123, 40)
        Me.GroupBox2.TabIndex = 78
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nombre de usuario"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(9, 13)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(105, 20)
        Me.TextBox5.TabIndex = 1
        '
        'RBEliminados
        '
        Me.RBEliminados.AutoSize = True
        Me.RBEliminados.Location = New System.Drawing.Point(483, 44)
        Me.RBEliminados.Margin = New System.Windows.Forms.Padding(2)
        Me.RBEliminados.Name = "RBEliminados"
        Me.RBEliminados.Size = New System.Drawing.Size(75, 17)
        Me.RBEliminados.TabIndex = 8
        Me.RBEliminados.TabStop = True
        Me.RBEliminados.Text = "Eliminados"
        Me.RBEliminados.UseVisualStyleBackColor = True
        '
        'RBActivos
        '
        Me.RBActivos.AutoSize = True
        Me.RBActivos.Location = New System.Drawing.Point(483, 21)
        Me.RBActivos.Margin = New System.Windows.Forms.Padding(2)
        Me.RBActivos.Name = "RBActivos"
        Me.RBActivos.Size = New System.Drawing.Size(60, 17)
        Me.RBActivos.TabIndex = 7
        Me.RBActivos.TabStop = True
        Me.RBActivos.Text = "Activos"
        Me.RBActivos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TBDni)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(177, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(123, 40)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DNI"
        '
        'TBDni
        '
        Me.TBDni.Location = New System.Drawing.Point(9, 13)
        Me.TBDni.Name = "TBDni"
        Me.TBDni.Size = New System.Drawing.Size(105, 20)
        Me.TBDni.TabIndex = 0
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.Color.Black
        Me.BBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscar.Location = New System.Drawing.Point(32, 32)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(117, 27)
        Me.BBuscar.TabIndex = 6
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'BSalir
        '
        Me.BSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BSalir.BackColor = System.Drawing.Color.Black
        Me.BSalir.Font = New System.Drawing.Font("Doppio One", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSalir.ForeColor = System.Drawing.Color.White
        Me.BSalir.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BSalir.Location = New System.Drawing.Point(13, 13)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.BSalir.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BSalir.Size = New System.Drawing.Size(25, 26)
        Me.BSalir.TabIndex = 75
        Me.BSalir.Text = "X"
        Me.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'GBMail
        '
        Me.GBMail.BackColor = System.Drawing.Color.Transparent
        Me.GBMail.Controls.Add(Me.TxtMail)
        Me.GBMail.ForeColor = System.Drawing.SystemColors.Window
        Me.GBMail.Location = New System.Drawing.Point(295, 73)
        Me.GBMail.Name = "GBMail"
        Me.GBMail.Size = New System.Drawing.Size(120, 40)
        Me.GBMail.TabIndex = 73
        Me.GBMail.TabStop = False
        Me.GBMail.Text = "Mail"
        '
        'TxtMail
        '
        Me.TxtMail.BackColor = System.Drawing.SystemColors.Window
        Me.TxtMail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtMail.Location = New System.Drawing.Point(8, 14)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(105, 20)
        Me.TxtMail.TabIndex = 3
        '
        'BModificar
        '
        Me.BModificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BModificar.CausesValidation = False
        Me.BModificar.ForeColor = System.Drawing.Color.White
        Me.BModificar.Location = New System.Drawing.Point(356, 118)
        Me.BModificar.Margin = New System.Windows.Forms.Padding(0)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(136, 27)
        Me.BModificar.TabIndex = 74
        Me.BModificar.Text = "Modificar Datos"
        Me.BModificar.UseVisualStyleBackColor = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BGuardar.ForeColor = System.Drawing.Color.White
        Me.BGuardar.Location = New System.Drawing.Point(203, 119)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(136, 27)
        Me.BGuardar.TabIndex = 72
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'GBdni
        '
        Me.GBdni.BackColor = System.Drawing.Color.Transparent
        Me.GBdni.Controls.Add(Me.TxtDNI)
        Me.GBdni.ForeColor = System.Drawing.SystemColors.Window
        Me.GBdni.Location = New System.Drawing.Point(45, 28)
        Me.GBdni.Name = "GBdni"
        Me.GBdni.Size = New System.Drawing.Size(120, 40)
        Me.GBdni.TabIndex = 70
        Me.GBdni.TabStop = False
        Me.GBdni.Text = "DNI"
        '
        'TxtDNI
        '
        Me.TxtDNI.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDNI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtDNI.Location = New System.Drawing.Point(9, 13)
        Me.TxtDNI.MaxLength = 8
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(105, 20)
        Me.TxtDNI.TabIndex = 2
        '
        'GBTelefono
        '
        Me.GBTelefono.BackColor = System.Drawing.Color.Transparent
        Me.GBTelefono.Controls.Add(Me.TxtTelefono)
        Me.GBTelefono.ForeColor = System.Drawing.SystemColors.Window
        Me.GBTelefono.Location = New System.Drawing.Point(170, 73)
        Me.GBTelefono.Name = "GBTelefono"
        Me.GBTelefono.Size = New System.Drawing.Size(120, 40)
        Me.GBTelefono.TabIndex = 71
        Me.GBTelefono.TabStop = False
        Me.GBTelefono.Text = "Telefono"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtTelefono.Location = New System.Drawing.Point(9, 14)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(105, 20)
        Me.TxtTelefono.TabIndex = 3
        '
        'GBDireccion
        '
        Me.GBDireccion.BackColor = System.Drawing.Color.Transparent
        Me.GBDireccion.Controls.Add(Me.TxtDireccion)
        Me.GBDireccion.ForeColor = System.Drawing.SystemColors.Window
        Me.GBDireccion.Location = New System.Drawing.Point(420, 73)
        Me.GBDireccion.Name = "GBDireccion"
        Me.GBDireccion.Size = New System.Drawing.Size(120, 40)
        Me.GBDireccion.TabIndex = 69
        Me.GBDireccion.TabStop = False
        Me.GBDireccion.Text = "Direccion"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDireccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtDireccion.Location = New System.Drawing.Point(10, 14)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(105, 20)
        Me.TxtDireccion.TabIndex = 1
        '
        'GBusername
        '
        Me.GBusername.BackColor = System.Drawing.Color.Transparent
        Me.GBusername.Controls.Add(Me.TextBox4)
        Me.GBusername.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBusername.Location = New System.Drawing.Point(420, 28)
        Me.GBusername.Name = "GBusername"
        Me.GBusername.Size = New System.Drawing.Size(120, 40)
        Me.GBusername.TabIndex = 77
        Me.GBusername.TabStop = False
        Me.GBusername.Text = "Nombre de usuario"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox4.Location = New System.Drawing.Point(10, 13)
        Me.TextBox4.MaxLength = 8
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(105, 20)
        Me.TextBox4.TabIndex = 3
        '
        'GBApellido
        '
        Me.GBApellido.BackColor = System.Drawing.Color.Transparent
        Me.GBApellido.Controls.Add(Me.TextBox3)
        Me.GBApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBApellido.Location = New System.Drawing.Point(295, 28)
        Me.GBApellido.Name = "GBApellido"
        Me.GBApellido.Size = New System.Drawing.Size(120, 40)
        Me.GBApellido.TabIndex = 78
        Me.GBApellido.TabStop = False
        Me.GBApellido.Text = "Apellido"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox3.Location = New System.Drawing.Point(8, 13)
        Me.TextBox3.MaxLength = 8
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(105, 20)
        Me.TextBox3.TabIndex = 3
        '
        'GBNombre
        '
        Me.GBNombre.BackColor = System.Drawing.Color.Transparent
        Me.GBNombre.Controls.Add(Me.TextBox2)
        Me.GBNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBNombre.Location = New System.Drawing.Point(170, 28)
        Me.GBNombre.Name = "GBNombre"
        Me.GBNombre.Size = New System.Drawing.Size(120, 40)
        Me.GBNombre.TabIndex = 76
        Me.GBNombre.TabStop = False
        Me.GBNombre.Text = "Nombre"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox2.Location = New System.Drawing.Point(9, 13)
        Me.TextBox2.MaxLength = 8
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(105, 20)
        Me.TextBox2.TabIndex = 3
        '
        'GBContraseña
        '
        Me.GBContraseña.BackColor = System.Drawing.Color.Transparent
        Me.GBContraseña.Controls.Add(Me.TextBox1)
        Me.GBContraseña.ForeColor = System.Drawing.SystemColors.Window
        Me.GBContraseña.Location = New System.Drawing.Point(45, 73)
        Me.GBContraseña.Name = "GBContraseña"
        Me.GBContraseña.Size = New System.Drawing.Size(120, 40)
        Me.GBContraseña.TabIndex = 79
        Me.GBContraseña.TabStop = False
        Me.GBContraseña.Text = "Contraseña"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox1.Location = New System.Drawing.Point(9, 14)
        Me.TextBox1.MaxLength = 8
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(105, 20)
        Me.TextBox1.TabIndex = 2
        '
        'GBTipo
        '
        Me.GBTipo.BackColor = System.Drawing.Color.Transparent
        Me.GBTipo.Controls.Add(Me.RadioButton3)
        Me.GBTipo.Controls.Add(Me.RadioButton2)
        Me.GBTipo.Controls.Add(Me.RadioButton1)
        Me.GBTipo.ForeColor = System.Drawing.Color.White
        Me.GBTipo.Location = New System.Drawing.Point(549, 28)
        Me.GBTipo.Name = "GBTipo"
        Me.GBTipo.Size = New System.Drawing.Size(107, 85)
        Me.GBTipo.TabIndex = 80
        Me.GBTipo.TabStop = False
        Me.GBTipo.Text = "Tipo Usuario"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 60)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(71, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Vendedor"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 38)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(63, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Gerente"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 17)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(88, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Administrador"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ABMUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(688, 457)
        Me.Controls.Add(Me.GBTipo)
        Me.Controls.Add(Me.GBContraseña)
        Me.Controls.Add(Me.GBusername)
        Me.Controls.Add(Me.GBTelefono)
        Me.Controls.Add(Me.GBApellido)
        Me.Controls.Add(Me.GBNombre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GBMail)
        Me.Controls.Add(Me.GBFiltrar)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BModificar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.GBdni)
        Me.Controls.Add(Me.GBDireccion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(494, 196)
        Me.Name = "ABMUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBFiltrar.ResumeLayout(False)
        Me.GBFiltrar.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBMail.ResumeLayout(False)
        Me.GBMail.PerformLayout()
        Me.GBdni.ResumeLayout(False)
        Me.GBdni.PerformLayout()
        Me.GBTelefono.ResumeLayout(False)
        Me.GBTelefono.PerformLayout()
        Me.GBDireccion.ResumeLayout(False)
        Me.GBDireccion.PerformLayout()
        Me.GBusername.ResumeLayout(False)
        Me.GBusername.PerformLayout()
        Me.GBApellido.ResumeLayout(False)
        Me.GBApellido.PerformLayout()
        Me.GBNombre.ResumeLayout(False)
        Me.GBNombre.PerformLayout()
        Me.GBContraseña.ResumeLayout(False)
        Me.GBContraseña.PerformLayout()
        Me.GBTipo.ResumeLayout(False)
        Me.GBTipo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GBFiltrar As GroupBox
    Friend WithEvents RBEliminados As RadioButton
    Friend WithEvents RBActivos As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TBDni As TextBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents BSalir As Button
    Friend WithEvents GBMail As GroupBox
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents BModificar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents GBdni As GroupBox
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents GBTelefono As GroupBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents GBDireccion As GroupBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents DNI As DataGridViewTextBoxColumn
    Friend WithEvents NyA As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Mail As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents GBusername As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents GBApellido As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GBNombre As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GBContraseña As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GBTipo As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
