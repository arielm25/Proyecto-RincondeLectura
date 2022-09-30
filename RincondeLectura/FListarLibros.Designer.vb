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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BSalir = New System.Windows.Forms.Button()
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBFiltro.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.BSalir)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.GBFiltro)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(688, 457)
        Me.Panel1.TabIndex = 0
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
        Me.BSalir.TabIndex = 66
        Me.BSalir.Text = "X"
        Me.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BSalir.UseVisualStyleBackColor = False
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_libro, Me.autor, Me.genero, Me.nombre, Me.editorial, Me.stock, Me.stock_min, Me.precio, Me.portada, Me.año_edicion, Me.costo})
        Me.DataGridView1.Location = New System.Drawing.Point(8, 158)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(673, 246)
        Me.DataGridView1.TabIndex = 8
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
        'stock_min
        '
        Me.stock_min.HeaderText = "Stock minimo"
        Me.stock_min.MinimumWidth = 6
        Me.stock_min.Name = "stock_min"
        Me.stock_min.Width = 125
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
        'costo
        '
        Me.costo.HeaderText = "Costo"
        Me.costo.MinimumWidth = 6
        Me.costo.Name = "costo"
        Me.costo.Width = 125
        '
        'GBFiltro
        '
        Me.GBFiltro.BackColor = System.Drawing.Color.Transparent
        Me.GBFiltro.Controls.Add(Me.GroupBox4)
        Me.GBFiltro.Controls.Add(Me.GroupBox3)
        Me.GBFiltro.Controls.Add(Me.GroupBox2)
        Me.GBFiltro.Controls.Add(Me.GroupBox1)
        Me.GBFiltro.Controls.Add(Me.BBuscar)
        Me.GBFiltro.Controls.Add(Me.CBTodos)
        Me.GBFiltro.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBFiltro.Location = New System.Drawing.Point(6, 60)
        Me.GBFiltro.Name = "GBFiltro"
        Me.GBFiltro.Size = New System.Drawing.Size(677, 84)
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
        Me.CBTodos.Location = New System.Drawing.Point(18, 21)
        Me.CBTodos.Name = "CBTodos"
        Me.CBTodos.Size = New System.Drawing.Size(99, 17)
        Me.CBTodos.TabIndex = 20
        Me.CBTodos.Text = "Todos los libros"
        Me.CBTodos.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.TextBox9)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox4.Location = New System.Drawing.Point(540, 23)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(120, 40)
        Me.GroupBox4.TabIndex = 95
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Id Genero"
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox9.Location = New System.Drawing.Point(10, 13)
        Me.TextBox9.MaxLength = 8
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(105, 20)
        Me.TextBox9.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TextBox8)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(404, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(120, 40)
        Me.GroupBox3.TabIndex = 94
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
        Me.GroupBox2.Location = New System.Drawing.Point(278, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(120, 40)
        Me.GroupBox2.TabIndex = 93
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
        Me.GroupBox1.Location = New System.Drawing.Point(152, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 40)
        Me.GroupBox1.TabIndex = 92
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
        'FListarLibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 457)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(494, 196)
        Me.MaximumSize = New System.Drawing.Size(688, 457)
        Me.MinimumSize = New System.Drawing.Size(688, 457)
        Me.Name = "FListarLibros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Listar Libros"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBFiltro.ResumeLayout(False)
        Me.GBFiltro.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GBFiltro As GroupBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents CBTodos As CheckBox
    Friend WithEvents BSalir As Button
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
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox6 As TextBox
End Class
