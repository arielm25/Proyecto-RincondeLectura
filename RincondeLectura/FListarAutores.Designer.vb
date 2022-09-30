<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FListarAutores
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.GBFiltrar = New System.Windows.Forms.GroupBox()
        Me.CBTodos = New System.Windows.Forms.CheckBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.GBApellido = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.GBNombre = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id_autor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GBFiltrar.SuspendLayout()
        Me.GBApellido.SuspendLayout()
        Me.GBNombre.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.BSalir)
        Me.Panel1.Controls.Add(Me.GBFiltrar)
        Me.Panel1.Controls.Add(Me.DataGridView1)
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
        'GBFiltrar
        '
        Me.GBFiltrar.BackColor = System.Drawing.Color.Transparent
        Me.GBFiltrar.Controls.Add(Me.CBTodos)
        Me.GBFiltrar.Controls.Add(Me.BBuscar)
        Me.GBFiltrar.Controls.Add(Me.GBApellido)
        Me.GBFiltrar.Controls.Add(Me.GBNombre)
        Me.GBFiltrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBFiltrar.Location = New System.Drawing.Point(68, 60)
        Me.GBFiltrar.Name = "GBFiltrar"
        Me.GBFiltrar.Size = New System.Drawing.Size(551, 101)
        Me.GBFiltrar.TabIndex = 3
        Me.GBFiltrar.TabStop = False
        Me.GBFiltrar.Text = "Filtrar Por"
        '
        'CBTodos
        '
        Me.CBTodos.AutoSize = True
        Me.CBTodos.Location = New System.Drawing.Point(49, 30)
        Me.CBTodos.Name = "CBTodos"
        Me.CBTodos.Size = New System.Drawing.Size(110, 17)
        Me.CBTodos.TabIndex = 7
        Me.CBTodos.Text = "Todos los autores"
        Me.CBTodos.UseVisualStyleBackColor = True
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BBuscar.Location = New System.Drawing.Point(49, 54)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(117, 27)
        Me.BBuscar.TabIndex = 2
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'GBApellido
        '
        Me.GBApellido.Controls.Add(Me.ComboBox2)
        Me.GBApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBApellido.Location = New System.Drawing.Point(363, 25)
        Me.GBApellido.Name = "GBApellido"
        Me.GBApellido.Size = New System.Drawing.Size(136, 56)
        Me.GBApellido.TabIndex = 1
        Me.GBApellido.TabStop = False
        Me.GBApellido.Text = "Apellido"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(6, 21)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 0
        '
        'GBNombre
        '
        Me.GBNombre.Controls.Add(Me.ComboBox1)
        Me.GBNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBNombre.Location = New System.Drawing.Point(199, 25)
        Me.GBNombre.Name = "GBNombre"
        Me.GBNombre.Size = New System.Drawing.Size(136, 56)
        Me.GBNombre.TabIndex = 0
        Me.GBNombre.TabStop = False
        Me.GBNombre.Text = "Nombre"
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_autor, Me.nombre, Me.apellido})
        Me.DataGridView1.Location = New System.Drawing.Point(68, 176)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 70
        Me.DataGridView1.Size = New System.Drawing.Size(551, 221)
        Me.DataGridView1.TabIndex = 2
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
        'FListarAutores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 457)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(494, 196)
        Me.MaximumSize = New System.Drawing.Size(688, 457)
        Me.MinimumSize = New System.Drawing.Size(688, 457)
        Me.Name = "FListarAutores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.GBFiltrar.ResumeLayout(False)
        Me.GBFiltrar.PerformLayout()
        Me.GBApellido.ResumeLayout(False)
        Me.GBNombre.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GBFiltrar As GroupBox
    Friend WithEvents CBTodos As CheckBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents GBApellido As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents GBNombre As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BSalir As Button
    Friend WithEvents id_autor As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
End Class
