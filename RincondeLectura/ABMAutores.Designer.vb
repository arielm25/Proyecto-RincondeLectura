<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMAutores
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
        Me.GBApellido = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GBNombre = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GBFiltrar = New System.Windows.Forms.GroupBox()
        Me.CBTodos = New System.Windows.Forms.CheckBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RBEliminados = New System.Windows.Forms.RadioButton()
        Me.RBActivos = New System.Windows.Forms.RadioButton()
        Me.id_autor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBApellido.SuspendLayout()
        Me.GBNombre.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GBFiltrar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBApellido
        '
        Me.GBApellido.BackColor = System.Drawing.Color.Transparent
        Me.GBApellido.Controls.Add(Me.TextBox3)
        Me.GBApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBApellido.Location = New System.Drawing.Point(72, 69)
        Me.GBApellido.Name = "GBApellido"
        Me.GBApellido.Size = New System.Drawing.Size(171, 40)
        Me.GBApellido.TabIndex = 92
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
        Me.TextBox3.Size = New System.Drawing.Size(157, 20)
        Me.TextBox3.TabIndex = 3
        '
        'GBNombre
        '
        Me.GBNombre.BackColor = System.Drawing.Color.Transparent
        Me.GBNombre.Controls.Add(Me.TextBox2)
        Me.GBNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBNombre.Location = New System.Drawing.Point(72, 21)
        Me.GBNombre.Name = "GBNombre"
        Me.GBNombre.Size = New System.Drawing.Size(171, 40)
        Me.GBNombre.TabIndex = 90
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
        Me.TextBox2.Size = New System.Drawing.Size(156, 20)
        Me.TextBox2.TabIndex = 3
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
        Me.BSalir.TabIndex = 89
        Me.BSalir.Text = "X"
        Me.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'BModificar
        '
        Me.BModificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BModificar.CausesValidation = False
        Me.BModificar.ForeColor = System.Drawing.Color.White
        Me.BModificar.Location = New System.Drawing.Point(372, 119)
        Me.BModificar.Margin = New System.Windows.Forms.Padding(0)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(136, 27)
        Me.BModificar.TabIndex = 88
        Me.BModificar.Text = "Modificar Datos"
        Me.BModificar.UseVisualStyleBackColor = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BGuardar.ForeColor = System.Drawing.Color.White
        Me.BGuardar.Location = New System.Drawing.Point(219, 120)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(136, 27)
        Me.BGuardar.TabIndex = 86
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(8, 15)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(365, 64)
        Me.TextBox1.TabIndex = 93
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(249, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(380, 89)
        Me.GroupBox3.TabIndex = 94
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Biografia"
        '
        'GBFiltrar
        '
        Me.GBFiltrar.BackColor = System.Drawing.Color.Transparent
        Me.GBFiltrar.Controls.Add(Me.RBEliminados)
        Me.GBFiltrar.Controls.Add(Me.RBActivos)
        Me.GBFiltrar.Controls.Add(Me.CBTodos)
        Me.GBFiltrar.Controls.Add(Me.BBuscar)
        Me.GBFiltrar.Controls.Add(Me.GroupBox1)
        Me.GBFiltrar.Controls.Add(Me.GroupBox2)
        Me.GBFiltrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBFiltrar.Location = New System.Drawing.Point(72, 156)
        Me.GBFiltrar.Name = "GBFiltrar"
        Me.GBFiltrar.Size = New System.Drawing.Size(557, 88)
        Me.GBFiltrar.TabIndex = 96
        Me.GBFiltrar.TabStop = False
        Me.GBFiltrar.Text = "Filtrar Por"
        '
        'CBTodos
        '
        Me.CBTodos.AutoSize = True
        Me.CBTodos.Location = New System.Drawing.Point(30, 26)
        Me.CBTodos.Name = "CBTodos"
        Me.CBTodos.Size = New System.Drawing.Size(110, 17)
        Me.CBTodos.TabIndex = 7
        Me.CBTodos.Text = "Todos los autores"
        Me.CBTodos.UseVisualStyleBackColor = True
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BBuscar.Location = New System.Drawing.Point(30, 50)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(117, 27)
        Me.BBuscar.TabIndex = 2
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(304, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 56)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Apellido"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(6, 21)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(158, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(136, 56)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nombre"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(6, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_autor, Me.nombre, Me.apellido, Me.Eliminar})
        Me.DataGridView1.Location = New System.Drawing.Point(72, 247)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 70
        Me.DataGridView1.Size = New System.Drawing.Size(557, 198)
        Me.DataGridView1.TabIndex = 95
        '
        'RBEliminados
        '
        Me.RBEliminados.AutoSize = True
        Me.RBEliminados.Location = New System.Drawing.Point(465, 55)
        Me.RBEliminados.Margin = New System.Windows.Forms.Padding(2)
        Me.RBEliminados.Name = "RBEliminados"
        Me.RBEliminados.Size = New System.Drawing.Size(75, 17)
        Me.RBEliminados.TabIndex = 10
        Me.RBEliminados.TabStop = True
        Me.RBEliminados.Text = "Eliminados"
        Me.RBEliminados.UseVisualStyleBackColor = True
        '
        'RBActivos
        '
        Me.RBActivos.AutoSize = True
        Me.RBActivos.Location = New System.Drawing.Point(465, 32)
        Me.RBActivos.Margin = New System.Windows.Forms.Padding(2)
        Me.RBActivos.Name = "RBActivos"
        Me.RBActivos.Size = New System.Drawing.Size(60, 17)
        Me.RBActivos.TabIndex = 9
        Me.RBActivos.TabStop = True
        Me.RBActivos.Text = "Activos"
        Me.RBActivos.UseVisualStyleBackColor = True
        '
        'id_autor
        '
        Me.id_autor.HeaderText = "Id_autor"
        Me.id_autor.MinimumWidth = 6
        Me.id_autor.Name = "id_autor"
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.MinimumWidth = 6
        Me.nombre.Name = "nombre"
        '
        'apellido
        '
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.MinimumWidth = 6
        Me.apellido.Name = "apellido"
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        '
        'ABMAutores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(688, 457)
        Me.Controls.Add(Me.GBFiltrar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GBApellido)
        Me.Controls.Add(Me.GBNombre)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BModificar)
        Me.Controls.Add(Me.BGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(494, 196)
        Me.Name = "ABMAutores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ABMAutores"
        Me.GBApellido.ResumeLayout(False)
        Me.GBApellido.PerformLayout()
        Me.GBNombre.ResumeLayout(False)
        Me.GBNombre.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GBFiltrar.ResumeLayout(False)
        Me.GBFiltrar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBApellido As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GBNombre As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BSalir As Button
    Friend WithEvents BModificar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GBFiltrar As GroupBox
    Friend WithEvents CBTodos As CheckBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RBEliminados As RadioButton
    Friend WithEvents RBActivos As RadioButton
    Friend WithEvents id_autor As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewTextBoxColumn
End Class
