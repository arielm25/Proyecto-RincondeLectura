<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMLibros
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.GBSinopsis = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.GBEditorial = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GBGenero = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GBPrecio = New System.Windows.Forms.GroupBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.GBAutor = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GBStock = New System.Windows.Forms.GroupBox()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.GBISBN = New System.Windows.Forms.GroupBox()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.GBAño = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GBFiltro = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.CBTodos = New System.Windows.Forms.CheckBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GBTitulo = New System.Windows.Forms.GroupBox()
        Me.RBEliminados = New System.Windows.Forms.RadioButton()
        Me.RBActivos = New System.Windows.Forms.RadioButton()
        Me.cod_libro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.autor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editorial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.portada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.año_edicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBSinopsis.SuspendLayout()
        Me.GBEditorial.SuspendLayout()
        Me.GBGenero.SuspendLayout()
        Me.GBPrecio.SuspendLayout()
        Me.GBAutor.SuspendLayout()
        Me.GBStock.SuspendLayout()
        Me.GBISBN.SuspendLayout()
        Me.GBAño.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBFiltro.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBTitulo.SuspendLayout()
        Me.SuspendLayout()
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
        Me.BSalir.TabIndex = 99
        Me.BSalir.Text = "X"
        Me.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'GBSinopsis
        '
        Me.GBSinopsis.BackColor = System.Drawing.Color.Transparent
        Me.GBSinopsis.Controls.Add(Me.TextBox5)
        Me.GBSinopsis.ForeColor = System.Drawing.Color.White
        Me.GBSinopsis.Location = New System.Drawing.Point(519, 54)
        Me.GBSinopsis.Name = "GBSinopsis"
        Me.GBSinopsis.Size = New System.Drawing.Size(157, 85)
        Me.GBSinopsis.TabIndex = 91
        Me.GBSinopsis.TabStop = False
        Me.GBSinopsis.Text = "Sinopsis"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(6, 14)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(145, 64)
        Me.TextBox5.TabIndex = 94
        '
        'GBEditorial
        '
        Me.GBEditorial.BackColor = System.Drawing.Color.Transparent
        Me.GBEditorial.Controls.Add(Me.TextBox1)
        Me.GBEditorial.ForeColor = System.Drawing.SystemColors.Window
        Me.GBEditorial.Location = New System.Drawing.Point(18, 99)
        Me.GBEditorial.Name = "GBEditorial"
        Me.GBEditorial.Size = New System.Drawing.Size(120, 40)
        Me.GBEditorial.TabIndex = 90
        Me.GBEditorial.TabStop = False
        Me.GBEditorial.Text = "Id Editorial"
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
        'GBGenero
        '
        Me.GBGenero.BackColor = System.Drawing.Color.Transparent
        Me.GBGenero.Controls.Add(Me.TextBox4)
        Me.GBGenero.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBGenero.Location = New System.Drawing.Point(393, 54)
        Me.GBGenero.Name = "GBGenero"
        Me.GBGenero.Size = New System.Drawing.Size(120, 40)
        Me.GBGenero.TabIndex = 88
        Me.GBGenero.TabStop = False
        Me.GBGenero.Text = "Id Genero"
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
        'GBPrecio
        '
        Me.GBPrecio.BackColor = System.Drawing.Color.Transparent
        Me.GBPrecio.Controls.Add(Me.TxtTelefono)
        Me.GBPrecio.ForeColor = System.Drawing.SystemColors.Window
        Me.GBPrecio.Location = New System.Drawing.Point(143, 99)
        Me.GBPrecio.Name = "GBPrecio"
        Me.GBPrecio.Size = New System.Drawing.Size(120, 40)
        Me.GBPrecio.TabIndex = 83
        Me.GBPrecio.TabStop = False
        Me.GBPrecio.Text = "Precio"
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
        'GBAutor
        '
        Me.GBAutor.BackColor = System.Drawing.Color.Transparent
        Me.GBAutor.Controls.Add(Me.TextBox3)
        Me.GBAutor.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBAutor.Location = New System.Drawing.Point(268, 54)
        Me.GBAutor.Name = "GBAutor"
        Me.GBAutor.Size = New System.Drawing.Size(120, 40)
        Me.GBAutor.TabIndex = 89
        Me.GBAutor.TabStop = False
        Me.GBAutor.Text = "Id Autor"
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
        'GBStock
        '
        Me.GBStock.BackColor = System.Drawing.Color.Transparent
        Me.GBStock.Controls.Add(Me.TxtMail)
        Me.GBStock.ForeColor = System.Drawing.SystemColors.Window
        Me.GBStock.Location = New System.Drawing.Point(268, 99)
        Me.GBStock.Name = "GBStock"
        Me.GBStock.Size = New System.Drawing.Size(120, 40)
        Me.GBStock.TabIndex = 85
        Me.GBStock.TabStop = False
        Me.GBStock.Text = "Stock"
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
        Me.BModificar.Location = New System.Drawing.Point(353, 144)
        Me.BModificar.Margin = New System.Windows.Forms.Padding(0)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(136, 27)
        Me.BModificar.TabIndex = 86
        Me.BModificar.Text = "Modificar Datos"
        Me.BModificar.UseVisualStyleBackColor = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BGuardar.ForeColor = System.Drawing.Color.White
        Me.BGuardar.Location = New System.Drawing.Point(200, 145)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(136, 27)
        Me.BGuardar.TabIndex = 84
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'GBISBN
        '
        Me.GBISBN.BackColor = System.Drawing.Color.Transparent
        Me.GBISBN.Controls.Add(Me.TxtDNI)
        Me.GBISBN.ForeColor = System.Drawing.SystemColors.Window
        Me.GBISBN.Location = New System.Drawing.Point(18, 54)
        Me.GBISBN.Name = "GBISBN"
        Me.GBISBN.Size = New System.Drawing.Size(120, 40)
        Me.GBISBN.TabIndex = 82
        Me.GBISBN.TabStop = False
        Me.GBISBN.Text = "ISBN"
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
        'GBAño
        '
        Me.GBAño.BackColor = System.Drawing.Color.Transparent
        Me.GBAño.Controls.Add(Me.NumericUpDown2)
        Me.GBAño.ForeColor = System.Drawing.SystemColors.Window
        Me.GBAño.Location = New System.Drawing.Point(393, 99)
        Me.GBAño.Name = "GBAño"
        Me.GBAño.Size = New System.Drawing.Size(120, 40)
        Me.GBAño.TabIndex = 81
        Me.GBAño.TabStop = False
        Me.GBAño.Text = "Año Edicion"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(9, 13)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1700, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(104, 20)
        Me.NumericUpDown2.TabIndex = 1
        Me.NumericUpDown2.Value = New Decimal(New Integer() {2020, 0, 0, 0})
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_libro, Me.autor, Me.genero, Me.nombre, Me.Eliminar, Me.editorial, Me.stock, Me.precio, Me.portada, Me.año_edicion})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 263)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(664, 182)
        Me.DataGridView1.TabIndex = 101
        '
        'GBFiltro
        '
        Me.GBFiltro.BackColor = System.Drawing.Color.Transparent
        Me.GBFiltro.Controls.Add(Me.RBEliminados)
        Me.GBFiltro.Controls.Add(Me.RBActivos)
        Me.GBFiltro.Controls.Add(Me.GroupBox3)
        Me.GBFiltro.Controls.Add(Me.GroupBox2)
        Me.GBFiltro.Controls.Add(Me.GroupBox1)
        Me.GBFiltro.Controls.Add(Me.BBuscar)
        Me.GBFiltro.Controls.Add(Me.CBTodos)
        Me.GBFiltro.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBFiltro.Location = New System.Drawing.Point(12, 178)
        Me.GBFiltro.Name = "GBFiltro"
        Me.GBFiltro.Size = New System.Drawing.Size(664, 79)
        Me.GBFiltro.TabIndex = 100
        Me.GBFiltro.TabStop = False
        Me.GBFiltro.Text = "Filtrar Por"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TextBox8)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(416, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(120, 40)
        Me.GroupBox3.TabIndex = 90
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Id Autor"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox8.Location = New System.Drawing.Point(8, 13)
        Me.TextBox8.MaxLength = 8
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(105, 20)
        Me.TextBox8.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(285, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(120, 40)
        Me.GroupBox2.TabIndex = 88
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Titulo"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox7.Location = New System.Drawing.Point(9, 13)
        Me.TextBox7.MaxLength = 8
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(105, 20)
        Me.TextBox7.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(154, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 40)
        Me.GroupBox1.TabIndex = 83
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ISBN"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox6.Location = New System.Drawing.Point(9, 13)
        Me.TextBox6.MaxLength = 8
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(105, 20)
        Me.TextBox6.TabIndex = 2
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BBuscar.Location = New System.Drawing.Point(35, 44)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(98, 27)
        Me.BBuscar.TabIndex = 21
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'CBTodos
        '
        Me.CBTodos.AutoSize = True
        Me.CBTodos.Location = New System.Drawing.Point(37, 20)
        Me.CBTodos.Name = "CBTodos"
        Me.CBTodos.Size = New System.Drawing.Size(99, 17)
        Me.CBTodos.TabIndex = 20
        Me.CBTodos.Text = "Todos los libros"
        Me.CBTodos.UseVisualStyleBackColor = True
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
        'GBTitulo
        '
        Me.GBTitulo.BackColor = System.Drawing.Color.Transparent
        Me.GBTitulo.Controls.Add(Me.TextBox2)
        Me.GBTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBTitulo.Location = New System.Drawing.Point(143, 54)
        Me.GBTitulo.Name = "GBTitulo"
        Me.GBTitulo.Size = New System.Drawing.Size(120, 40)
        Me.GBTitulo.TabIndex = 87
        Me.GBTitulo.TabStop = False
        Me.GBTitulo.Text = "Titulo"
        '
        'RBEliminados
        '
        Me.RBEliminados.AutoSize = True
        Me.RBEliminados.Location = New System.Drawing.Point(554, 46)
        Me.RBEliminados.Margin = New System.Windows.Forms.Padding(2)
        Me.RBEliminados.Name = "RBEliminados"
        Me.RBEliminados.Size = New System.Drawing.Size(75, 17)
        Me.RBEliminados.TabIndex = 92
        Me.RBEliminados.TabStop = True
        Me.RBEliminados.Text = "Eliminados"
        Me.RBEliminados.UseVisualStyleBackColor = True
        '
        'RBActivos
        '
        Me.RBActivos.AutoSize = True
        Me.RBActivos.Location = New System.Drawing.Point(554, 23)
        Me.RBActivos.Margin = New System.Windows.Forms.Padding(2)
        Me.RBActivos.Name = "RBActivos"
        Me.RBActivos.Size = New System.Drawing.Size(60, 17)
        Me.RBActivos.TabIndex = 91
        Me.RBActivos.TabStop = True
        Me.RBActivos.Text = "Activos"
        Me.RBActivos.UseVisualStyleBackColor = True
        '
        'cod_libro
        '
        Me.cod_libro.HeaderText = "Cod_libro"
        Me.cod_libro.MinimumWidth = 6
        Me.cod_libro.Name = "cod_libro"
        Me.cod_libro.Width = 125
        '
        'autor
        '
        Me.autor.HeaderText = "Autor"
        Me.autor.MinimumWidth = 6
        Me.autor.Name = "autor"
        Me.autor.Width = 125
        '
        'genero
        '
        Me.genero.HeaderText = "Genero"
        Me.genero.MinimumWidth = 6
        Me.genero.Name = "genero"
        Me.genero.Width = 125
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.MinimumWidth = 6
        Me.nombre.Name = "nombre"
        Me.nombre.Width = 125
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        '
        'editorial
        '
        Me.editorial.HeaderText = "Editorial"
        Me.editorial.MinimumWidth = 6
        Me.editorial.Name = "editorial"
        Me.editorial.Width = 125
        '
        'stock
        '
        Me.stock.HeaderText = "Stock"
        Me.stock.MinimumWidth = 6
        Me.stock.Name = "stock"
        Me.stock.Width = 125
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.MinimumWidth = 6
        Me.precio.Name = "precio"
        Me.precio.Width = 125
        '
        'portada
        '
        Me.portada.HeaderText = "Portada"
        Me.portada.MinimumWidth = 6
        Me.portada.Name = "portada"
        Me.portada.Width = 125
        '
        'año_edicion
        '
        Me.año_edicion.HeaderText = "Año_edicion"
        Me.año_edicion.MinimumWidth = 6
        Me.año_edicion.Name = "año_edicion"
        Me.año_edicion.Width = 125
        '
        'ABMLibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(688, 457)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GBFiltro)
        Me.Controls.Add(Me.GBSinopsis)
        Me.Controls.Add(Me.GBEditorial)
        Me.Controls.Add(Me.GBGenero)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.GBPrecio)
        Me.Controls.Add(Me.GBISBN)
        Me.Controls.Add(Me.GBAutor)
        Me.Controls.Add(Me.GBAño)
        Me.Controls.Add(Me.GBTitulo)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.GBStock)
        Me.Controls.Add(Me.BModificar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(494, 196)
        Me.Name = "ABMLibros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ABMLibros"
        Me.GBSinopsis.ResumeLayout(False)
        Me.GBSinopsis.PerformLayout()
        Me.GBEditorial.ResumeLayout(False)
        Me.GBEditorial.PerformLayout()
        Me.GBGenero.ResumeLayout(False)
        Me.GBGenero.PerformLayout()
        Me.GBPrecio.ResumeLayout(False)
        Me.GBPrecio.PerformLayout()
        Me.GBAutor.ResumeLayout(False)
        Me.GBAutor.PerformLayout()
        Me.GBStock.ResumeLayout(False)
        Me.GBStock.PerformLayout()
        Me.GBISBN.ResumeLayout(False)
        Me.GBISBN.PerformLayout()
        Me.GBAño.ResumeLayout(False)
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBFiltro.ResumeLayout(False)
        Me.GBFiltro.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBTitulo.ResumeLayout(False)
        Me.GBTitulo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BSalir As Button
    Friend WithEvents GBSinopsis As GroupBox
    Friend WithEvents GBEditorial As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GBGenero As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents GBPrecio As GroupBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents GBAutor As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GBStock As GroupBox
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents BModificar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents GBISBN As GroupBox
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents GBAño As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GBFiltro As GroupBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents CBTodos As CheckBox
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GBTitulo As GroupBox
    Friend WithEvents RBEliminados As RadioButton
    Friend WithEvents RBActivos As RadioButton
    Friend WithEvents cod_libro As DataGridViewTextBoxColumn
    Friend WithEvents autor As DataGridViewTextBoxColumn
    Friend WithEvents genero As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewTextBoxColumn
    Friend WithEvents editorial As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents portada As DataGridViewTextBoxColumn
    Friend WithEvents año_edicion As DataGridViewTextBoxColumn
End Class
