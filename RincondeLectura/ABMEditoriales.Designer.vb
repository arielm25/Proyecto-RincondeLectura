<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMEditoriales
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
        Me.BSalir = New System.Windows.Forms.Button()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.GBMail = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GBTelefono = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GBDescr = New System.Windows.Forms.GroupBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.GBDir = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GBNombre = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GBFiltrar = New System.Windows.Forms.GroupBox()
        Me.RBEliminados = New System.Windows.Forms.RadioButton()
        Me.RBActivos = New System.Windows.Forms.RadioButton()
        Me.CBTodos = New System.Windows.Forms.CheckBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.GBDireccion = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id_editorial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBMail.SuspendLayout()
        Me.GBTelefono.SuspendLayout()
        Me.GBDescr.SuspendLayout()
        Me.GBDir.SuspendLayout()
        Me.GBNombre.SuspendLayout()
        Me.GBFiltrar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBDireccion.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'BModificar
        '
        Me.BModificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BModificar.CausesValidation = False
        Me.BModificar.ForeColor = System.Drawing.Color.White
        Me.BModificar.Location = New System.Drawing.Point(374, 117)
        Me.BModificar.Margin = New System.Windows.Forms.Padding(0)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(136, 27)
        Me.BModificar.TabIndex = 98
        Me.BModificar.Text = "Modificar Datos"
        Me.BModificar.UseVisualStyleBackColor = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BGuardar.ForeColor = System.Drawing.Color.White
        Me.BGuardar.Location = New System.Drawing.Point(221, 118)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(136, 27)
        Me.BGuardar.TabIndex = 97
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'GBMail
        '
        Me.GBMail.BackColor = System.Drawing.Color.Transparent
        Me.GBMail.Controls.Add(Me.TextBox1)
        Me.GBMail.ForeColor = System.Drawing.SystemColors.Window
        Me.GBMail.Location = New System.Drawing.Point(74, 71)
        Me.GBMail.Name = "GBMail"
        Me.GBMail.Size = New System.Drawing.Size(169, 40)
        Me.GBMail.TabIndex = 112
        Me.GBMail.TabStop = False
        Me.GBMail.Text = "Mail"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox1.Location = New System.Drawing.Point(9, 14)
        Me.TextBox1.MaxLength = 8
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(154, 20)
        Me.TextBox1.TabIndex = 2
        '
        'GBTelefono
        '
        Me.GBTelefono.BackColor = System.Drawing.Color.Transparent
        Me.GBTelefono.Controls.Add(Me.TextBox4)
        Me.GBTelefono.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBTelefono.Location = New System.Drawing.Point(260, 71)
        Me.GBTelefono.Name = "GBTelefono"
        Me.GBTelefono.Size = New System.Drawing.Size(169, 40)
        Me.GBTelefono.TabIndex = 110
        Me.GBTelefono.TabStop = False
        Me.GBTelefono.Text = "Telefono"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox4.Location = New System.Drawing.Point(10, 13)
        Me.TextBox4.MaxLength = 8
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(154, 20)
        Me.TextBox4.TabIndex = 3
        '
        'GBDescr
        '
        Me.GBDescr.BackColor = System.Drawing.Color.Transparent
        Me.GBDescr.Controls.Add(Me.TxtTelefono)
        Me.GBDescr.ForeColor = System.Drawing.SystemColors.Window
        Me.GBDescr.Location = New System.Drawing.Point(446, 25)
        Me.GBDescr.Name = "GBDescr"
        Me.GBDescr.Size = New System.Drawing.Size(182, 86)
        Me.GBDescr.TabIndex = 107
        Me.GBDescr.TabStop = False
        Me.GBDescr.Text = "Descripcion"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtTelefono.Location = New System.Drawing.Point(7, 14)
        Me.TxtTelefono.Multiline = True
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(167, 65)
        Me.TxtTelefono.TabIndex = 3
        '
        'GBDir
        '
        Me.GBDir.BackColor = System.Drawing.Color.Transparent
        Me.GBDir.Controls.Add(Me.TextBox3)
        Me.GBDir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBDir.Location = New System.Drawing.Point(260, 25)
        Me.GBDir.Name = "GBDir"
        Me.GBDir.Size = New System.Drawing.Size(169, 40)
        Me.GBDir.TabIndex = 111
        Me.GBDir.TabStop = False
        Me.GBDir.Text = "Direccion"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox3.Location = New System.Drawing.Point(8, 13)
        Me.TextBox3.MaxLength = 8
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(154, 20)
        Me.TextBox3.TabIndex = 3
        '
        'GBNombre
        '
        Me.GBNombre.BackColor = System.Drawing.Color.Transparent
        Me.GBNombre.Controls.Add(Me.TextBox2)
        Me.GBNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBNombre.Location = New System.Drawing.Point(74, 25)
        Me.GBNombre.Name = "GBNombre"
        Me.GBNombre.Size = New System.Drawing.Size(169, 40)
        Me.GBNombre.TabIndex = 109
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
        Me.TextBox2.Size = New System.Drawing.Size(154, 20)
        Me.TextBox2.TabIndex = 3
        '
        'GBFiltrar
        '
        Me.GBFiltrar.BackColor = System.Drawing.Color.Transparent
        Me.GBFiltrar.Controls.Add(Me.RBEliminados)
        Me.GBFiltrar.Controls.Add(Me.RBActivos)
        Me.GBFiltrar.Controls.Add(Me.CBTodos)
        Me.GBFiltrar.Controls.Add(Me.BBuscar)
        Me.GBFiltrar.Controls.Add(Me.GroupBox1)
        Me.GBFiltrar.Controls.Add(Me.GBDireccion)
        Me.GBFiltrar.Controls.Add(Me.GroupBox2)
        Me.GBFiltrar.Controls.Add(Me.GroupBox3)
        Me.GBFiltrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBFiltrar.Location = New System.Drawing.Point(42, 150)
        Me.GBFiltrar.Name = "GBFiltrar"
        Me.GBFiltrar.Size = New System.Drawing.Size(611, 119)
        Me.GBFiltrar.TabIndex = 114
        Me.GBFiltrar.TabStop = False
        Me.GBFiltrar.Text = "Filtrar Por"
        '
        'RBEliminados
        '
        Me.RBEliminados.AutoSize = True
        Me.RBEliminados.Location = New System.Drawing.Point(506, 67)
        Me.RBEliminados.Margin = New System.Windows.Forms.Padding(2)
        Me.RBEliminados.Name = "RBEliminados"
        Me.RBEliminados.Size = New System.Drawing.Size(75, 17)
        Me.RBEliminados.TabIndex = 12
        Me.RBEliminados.TabStop = True
        Me.RBEliminados.Text = "Eliminados"
        Me.RBEliminados.UseVisualStyleBackColor = True
        '
        'RBActivos
        '
        Me.RBActivos.AutoSize = True
        Me.RBActivos.Location = New System.Drawing.Point(506, 44)
        Me.RBActivos.Margin = New System.Windows.Forms.Padding(2)
        Me.RBActivos.Name = "RBActivos"
        Me.RBActivos.Size = New System.Drawing.Size(60, 17)
        Me.RBActivos.TabIndex = 11
        Me.RBActivos.TabStop = True
        Me.RBActivos.Text = "Activos"
        Me.RBActivos.UseVisualStyleBackColor = True
        '
        'CBTodos
        '
        Me.CBTodos.AutoSize = True
        Me.CBTodos.Location = New System.Drawing.Point(32, 37)
        Me.CBTodos.Name = "CBTodos"
        Me.CBTodos.Size = New System.Drawing.Size(122, 17)
        Me.CBTodos.TabIndex = 6
        Me.CBTodos.Text = "Todas las editoriales"
        Me.CBTodos.UseVisualStyleBackColor = True
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BBuscar.Location = New System.Drawing.Point(32, 66)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(117, 27)
        Me.BBuscar.TabIndex = 4
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(335, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(139, 50)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Telefono"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(6, 17)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(127, 20)
        Me.TextBox5.TabIndex = 1
        '
        'GBDireccion
        '
        Me.GBDireccion.Controls.Add(Me.TextBox6)
        Me.GBDireccion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBDireccion.Location = New System.Drawing.Point(335, 63)
        Me.GBDireccion.Name = "GBDireccion"
        Me.GBDireccion.Size = New System.Drawing.Size(139, 50)
        Me.GBDireccion.TabIndex = 3
        Me.GBDireccion.TabStop = False
        Me.GBDireccion.Text = "Direccion"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(6, 17)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(127, 20)
        Me.TextBox6.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(176, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(139, 50)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mail"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(6, 17)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(127, 20)
        Me.TextBox7.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox8)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(176, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(139, 50)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Nombre"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(6, 17)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(127, 20)
        Me.TextBox8.TabIndex = 1
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_editorial, Me.nombre, Me.telefono, Me.mail, Me.direccion, Me.Eliminar})
        Me.DataGridView1.Location = New System.Drawing.Point(42, 275)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(611, 170)
        Me.DataGridView1.TabIndex = 113
        '
        'id_editorial
        '
        Me.id_editorial.HeaderText = "Id_editorial"
        Me.id_editorial.MinimumWidth = 6
        Me.id_editorial.Name = "id_editorial"
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.MinimumWidth = 6
        Me.nombre.Name = "nombre"
        '
        'telefono
        '
        Me.telefono.HeaderText = "Telefono"
        Me.telefono.MinimumWidth = 6
        Me.telefono.Name = "telefono"
        '
        'mail
        '
        Me.mail.HeaderText = "Mail"
        Me.mail.MinimumWidth = 6
        Me.mail.Name = "mail"
        '
        'direccion
        '
        Me.direccion.HeaderText = "Direccion"
        Me.direccion.MinimumWidth = 6
        Me.direccion.Name = "direccion"
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        '
        'ABMEditoriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(688, 457)
        Me.Controls.Add(Me.GBFiltrar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GBMail)
        Me.Controls.Add(Me.GBTelefono)
        Me.Controls.Add(Me.GBDescr)
        Me.Controls.Add(Me.GBDir)
        Me.Controls.Add(Me.GBNombre)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BModificar)
        Me.Controls.Add(Me.BGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(494, 196)
        Me.Name = "ABMEditoriales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ABMEditoriales"
        Me.GBMail.ResumeLayout(False)
        Me.GBMail.PerformLayout()
        Me.GBTelefono.ResumeLayout(False)
        Me.GBTelefono.PerformLayout()
        Me.GBDescr.ResumeLayout(False)
        Me.GBDescr.PerformLayout()
        Me.GBDir.ResumeLayout(False)
        Me.GBDir.PerformLayout()
        Me.GBNombre.ResumeLayout(False)
        Me.GBNombre.PerformLayout()
        Me.GBFiltrar.ResumeLayout(False)
        Me.GBFiltrar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBDireccion.ResumeLayout(False)
        Me.GBDireccion.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BSalir As Button
    Friend WithEvents BModificar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents GBMail As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GBTelefono As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents GBDescr As GroupBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents GBDir As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GBNombre As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GBFiltrar As GroupBox
    Friend WithEvents CBTodos As CheckBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents GBDireccion As GroupBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RBEliminados As RadioButton
    Friend WithEvents RBActivos As RadioButton
    Friend WithEvents id_editorial As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents mail As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewTextBoxColumn
End Class
