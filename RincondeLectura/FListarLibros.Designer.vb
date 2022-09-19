<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FListarLibros
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cod_libro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.autor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editorial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_min = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.portada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.año_edicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBFiltro = New System.Windows.Forms.GroupBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.CBTodos = New System.Windows.Forms.CheckBox()
        Me.GBGenero = New System.Windows.Forms.GroupBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.GBAnioEdicion = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.GBEditorial = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.GBAutores = New System.Windows.Forms.GroupBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBFiltro.SuspendLayout()
        Me.GBGenero.SuspendLayout()
        Me.GBAnioEdicion.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBEditorial.SuspendLayout()
        Me.GBAutores.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.BCancelar)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.GBFiltro)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 0
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BCancelar.Location = New System.Drawing.Point(283, 366)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(117, 27)
        Me.BCancelar.TabIndex = 9
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_libro, Me.autor, Me.genero, Me.nombre, Me.editorial, Me.stock, Me.stock_min, Me.precio, Me.portada, Me.año_edicion, Me.costo})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 146)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(716, 202)
        Me.DataGridView1.TabIndex = 8
        '
        'cod_libro
        '
        Me.cod_libro.HeaderText = "cod_libro"
        Me.cod_libro.Name = "cod_libro"
        '
        'autor
        '
        Me.autor.HeaderText = "autor"
        Me.autor.Name = "autor"
        '
        'genero
        '
        Me.genero.HeaderText = "genero"
        Me.genero.Name = "genero"
        '
        'nombre
        '
        Me.nombre.HeaderText = "nombre"
        Me.nombre.Name = "nombre"
        '
        'editorial
        '
        Me.editorial.HeaderText = "editorial"
        Me.editorial.Name = "editorial"
        '
        'stock
        '
        Me.stock.HeaderText = "stock"
        Me.stock.Name = "stock"
        '
        'stock_min
        '
        Me.stock_min.HeaderText = "stock minimo"
        Me.stock_min.Name = "stock_min"
        '
        'precio
        '
        Me.precio.HeaderText = "precio"
        Me.precio.Name = "precio"
        '
        'portada
        '
        Me.portada.HeaderText = "portada"
        Me.portada.Name = "portada"
        '
        'año_edicion
        '
        Me.año_edicion.HeaderText = "año_edicion"
        Me.año_edicion.Name = "año_edicion"
        '
        'costo
        '
        Me.costo.HeaderText = "costo"
        Me.costo.Name = "costo"
        '
        'GBFiltro
        '
        Me.GBFiltro.BackColor = System.Drawing.Color.Transparent
        Me.GBFiltro.Controls.Add(Me.BBuscar)
        Me.GBFiltro.Controls.Add(Me.CBTodos)
        Me.GBFiltro.Controls.Add(Me.GBGenero)
        Me.GBFiltro.Controls.Add(Me.GBAnioEdicion)
        Me.GBFiltro.Controls.Add(Me.GBEditorial)
        Me.GBFiltro.Controls.Add(Me.GBAutores)
        Me.GBFiltro.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBFiltro.Location = New System.Drawing.Point(12, 44)
        Me.GBFiltro.Name = "GBFiltro"
        Me.GBFiltro.Size = New System.Drawing.Size(696, 84)
        Me.GBFiltro.TabIndex = 7
        Me.GBFiltro.TabStop = False
        Me.GBFiltro.Text = "Filtrar Por"
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BBuscar.Location = New System.Drawing.Point(16, 45)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(117, 27)
        Me.BBuscar.TabIndex = 21
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'CBTodos
        '
        Me.CBTodos.AutoSize = True
        Me.CBTodos.Location = New System.Drawing.Point(16, 21)
        Me.CBTodos.Name = "CBTodos"
        Me.CBTodos.Size = New System.Drawing.Size(99, 17)
        Me.CBTodos.TabIndex = 20
        Me.CBTodos.Text = "Todas los libros"
        Me.CBTodos.UseVisualStyleBackColor = True
        '
        'GBGenero
        '
        Me.GBGenero.Controls.Add(Me.ComboBox3)
        Me.GBGenero.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBGenero.Location = New System.Drawing.Point(289, 19)
        Me.GBGenero.Name = "GBGenero"
        Me.GBGenero.Size = New System.Drawing.Size(139, 52)
        Me.GBGenero.TabIndex = 17
        Me.GBGenero.TabStop = False
        Me.GBGenero.Text = "Genero"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Romance", "Comedia", "Misterio- Terror", "Policial", "Ciencia Ficcion", "Paranormal", "Distopica", "Poesia", "Teatro", "Fantasia", "Gotica", "Mitologia"})
        Me.ComboBox3.Location = New System.Drawing.Point(6, 19)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 13
        '
        'GBAnioEdicion
        '
        Me.GBAnioEdicion.Controls.Add(Me.NumericUpDown1)
        Me.GBAnioEdicion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBAnioEdicion.Location = New System.Drawing.Point(579, 19)
        Me.GBAnioEdicion.Name = "GBAnioEdicion"
        Me.GBAnioEdicion.Size = New System.Drawing.Size(111, 52)
        Me.GBAnioEdicion.TabIndex = 19
        Me.GBAnioEdicion.TabStop = False
        Me.GBAnioEdicion.Text = "Año de Edicion"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(6, 19)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1700, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(95, 20)
        Me.NumericUpDown1.TabIndex = 0
        Me.NumericUpDown1.Value = New Decimal(New Integer() {2020, 0, 0, 0})
        '
        'GBEditorial
        '
        Me.GBEditorial.Controls.Add(Me.ComboBox2)
        Me.GBEditorial.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBEditorial.Location = New System.Drawing.Point(434, 19)
        Me.GBEditorial.Name = "GBEditorial"
        Me.GBEditorial.Size = New System.Drawing.Size(139, 52)
        Me.GBEditorial.TabIndex = 18
        Me.GBEditorial.TabStop = False
        Me.GBEditorial.Text = "Editorial"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Montena", "Javier Vergara", "Duomo", "Planeta", "Alba", "Aleguara", "Ivrea", "B de Bolsillo", "Blok", "El Ateneo", "Trakatra", "Emece", "Bloomsbury Publishing"})
        Me.ComboBox2.Location = New System.Drawing.Point(6, 19)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 13
        '
        'GBAutores
        '
        Me.GBAutores.Controls.Add(Me.ComboBox4)
        Me.GBAutores.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBAutores.Location = New System.Drawing.Point(144, 19)
        Me.GBAutores.Name = "GBAutores"
        Me.GBAutores.Size = New System.Drawing.Size(139, 52)
        Me.GBAutores.TabIndex = 16
        Me.GBAutores.TabStop = False
        Me.GBAutores.Text = "Autores"
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Jhon Katzenbach", "Sebastian Fitzek", "Stephenie Meyer", "Cassandra Claire", "Carolyn Jess-Cooke", "J. K. Rowling", "R. R. Tolkien", "Agatha Christie"})
        Me.ComboBox4.Location = New System.Drawing.Point(12, 19)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox4.TabIndex = 13
        '
        'FListarLibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FListarLibros"
        Me.Text = "Listar Libros"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBFiltro.ResumeLayout(False)
        Me.GBFiltro.PerformLayout()
        Me.GBGenero.ResumeLayout(False)
        Me.GBAnioEdicion.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBEditorial.ResumeLayout(False)
        Me.GBAutores.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BCancelar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cod_libro As DataGridViewTextBoxColumn
    Friend WithEvents autor As DataGridViewTextBoxColumn
    Friend WithEvents genero As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents editorial As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents stock_min As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents portada As DataGridViewTextBoxColumn
    Friend WithEvents año_edicion As DataGridViewTextBoxColumn
    Friend WithEvents costo As DataGridViewTextBoxColumn
    Friend WithEvents GBFiltro As GroupBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents CBTodos As CheckBox
    Friend WithEvents GBGenero As GroupBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents GBAnioEdicion As GroupBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents GBEditorial As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents GBAutores As GroupBox
    Friend WithEvents ComboBox4 As ComboBox
End Class
