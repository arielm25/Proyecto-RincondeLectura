<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMGeneros
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
        Me.GBFiltrar = New System.Windows.Forms.GroupBox()
        Me.RBEliminados = New System.Windows.Forms.RadioButton()
        Me.RBActivos = New System.Windows.Forms.RadioButton()
        Me.CBTodos = New System.Windows.Forms.CheckBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.GBId = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.GBTitulo = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.GBTituloGenero = New System.Windows.Forms.GroupBox()
        Me.TxtTituloGenero = New System.Windows.Forms.TextBox()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.id_genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Titulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eliminar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBFiltrar.SuspendLayout()
        Me.GBId.SuspendLayout()
        Me.GBTitulo.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBTituloGenero.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBFiltrar
        '
        Me.GBFiltrar.BackColor = System.Drawing.Color.Transparent
        Me.GBFiltrar.Controls.Add(Me.RBEliminados)
        Me.GBFiltrar.Controls.Add(Me.RBActivos)
        Me.GBFiltrar.Controls.Add(Me.CBTodos)
        Me.GBFiltrar.Controls.Add(Me.BBuscar)
        Me.GBFiltrar.Controls.Add(Me.GBId)
        Me.GBFiltrar.Controls.Add(Me.GBTitulo)
        Me.GBFiltrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBFiltrar.Location = New System.Drawing.Point(71, 136)
        Me.GBFiltrar.Name = "GBFiltrar"
        Me.GBFiltrar.Size = New System.Drawing.Size(557, 88)
        Me.GBFiltrar.TabIndex = 104
        Me.GBFiltrar.TabStop = False
        Me.GBFiltrar.Text = "Filtrar Por"
        '
        'RBEliminados
        '
        Me.RBEliminados.AutoSize = True
        Me.RBEliminados.Location = New System.Drawing.Point(461, 55)
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
        Me.RBActivos.Location = New System.Drawing.Point(461, 32)
        Me.RBActivos.Margin = New System.Windows.Forms.Padding(2)
        Me.RBActivos.Name = "RBActivos"
        Me.RBActivos.Size = New System.Drawing.Size(60, 17)
        Me.RBActivos.TabIndex = 9
        Me.RBActivos.TabStop = True
        Me.RBActivos.Text = "Activos"
        Me.RBActivos.UseVisualStyleBackColor = True
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
        'GBId
        '
        Me.GBId.Controls.Add(Me.ComboBox2)
        Me.GBId.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBId.Location = New System.Drawing.Point(304, 21)
        Me.GBId.Name = "GBId"
        Me.GBId.Size = New System.Drawing.Size(136, 56)
        Me.GBId.TabIndex = 1
        Me.GBId.TabStop = False
        Me.GBId.Text = "Id"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(6, 21)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 0
        '
        'GBTitulo
        '
        Me.GBTitulo.Controls.Add(Me.ComboBox1)
        Me.GBTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBTitulo.Location = New System.Drawing.Point(158, 21)
        Me.GBTitulo.Name = "GBTitulo"
        Me.GBTitulo.Size = New System.Drawing.Size(136, 56)
        Me.GBTitulo.TabIndex = 0
        Me.GBTitulo.TabStop = False
        Me.GBTitulo.Text = "Titulo Genero"
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_genero, Me.Titulo, Me.eliminar})
        Me.DataGridView1.Location = New System.Drawing.Point(71, 227)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 70
        Me.DataGridView1.Size = New System.Drawing.Size(557, 198)
        Me.DataGridView1.TabIndex = 103
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
        'GBTituloGenero
        '
        Me.GBTituloGenero.BackColor = System.Drawing.Color.Transparent
        Me.GBTituloGenero.Controls.Add(Me.TxtTituloGenero)
        Me.GBTituloGenero.ForeColor = System.Drawing.SystemColors.Window
        Me.GBTituloGenero.Location = New System.Drawing.Point(178, 46)
        Me.GBTituloGenero.Name = "GBTituloGenero"
        Me.GBTituloGenero.Size = New System.Drawing.Size(167, 57)
        Me.GBTituloGenero.TabIndex = 107
        Me.GBTituloGenero.TabStop = False
        Me.GBTituloGenero.Text = "Titulo del Genero"
        '
        'TxtTituloGenero
        '
        Me.TxtTituloGenero.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTituloGenero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtTituloGenero.Location = New System.Drawing.Point(22, 21)
        Me.TxtTituloGenero.Name = "TxtTituloGenero"
        Me.TxtTituloGenero.Size = New System.Drawing.Size(134, 20)
        Me.TxtTituloGenero.TabIndex = 0
        '
        'BModificar
        '
        Me.BModificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BModificar.CausesValidation = False
        Me.BModificar.ForeColor = System.Drawing.Color.White
        Me.BModificar.Location = New System.Drawing.Point(364, 79)
        Me.BModificar.Margin = New System.Windows.Forms.Padding(0)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(136, 27)
        Me.BModificar.TabIndex = 109
        Me.BModificar.Text = "Modificar Datos"
        Me.BModificar.UseVisualStyleBackColor = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BGuardar.ForeColor = System.Drawing.Color.White
        Me.BGuardar.Location = New System.Drawing.Point(364, 49)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(136, 27)
        Me.BGuardar.TabIndex = 108
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'id_genero
        '
        Me.id_genero.HeaderText = "Id Genero"
        Me.id_genero.MinimumWidth = 6
        Me.id_genero.Name = "id_genero"
        '
        'Titulo
        '
        Me.Titulo.HeaderText = "Titulo"
        Me.Titulo.MinimumWidth = 6
        Me.Titulo.Name = "Titulo"
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.MinimumWidth = 6
        Me.eliminar.Name = "eliminar"
        '
        'ABMGeneros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(688, 457)
        Me.Controls.Add(Me.BModificar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.GBTituloGenero)
        Me.Controls.Add(Me.GBFiltrar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(494, 196)
        Me.Name = "ABMGeneros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ABMGeneros"
        Me.GBFiltrar.ResumeLayout(False)
        Me.GBFiltrar.PerformLayout()
        Me.GBId.ResumeLayout(False)
        Me.GBTitulo.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBTituloGenero.ResumeLayout(False)
        Me.GBTituloGenero.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBFiltrar As GroupBox
    Friend WithEvents RBEliminados As RadioButton
    Friend WithEvents RBActivos As RadioButton
    Friend WithEvents CBTodos As CheckBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents GBId As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents GBTitulo As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BSalir As Button
    Friend WithEvents GBTituloGenero As GroupBox
    Friend WithEvents TxtTituloGenero As TextBox
    Friend WithEvents BModificar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents id_genero As DataGridViewTextBoxColumn
    Friend WithEvents Titulo As DataGridViewTextBoxColumn
    Friend WithEvents eliminar As DataGridViewTextBoxColumn
End Class
