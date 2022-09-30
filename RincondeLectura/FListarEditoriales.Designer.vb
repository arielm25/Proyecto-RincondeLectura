<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FListarEditoriales
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
        Me.GBTelefono = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GBDireccion = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GBMail = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GBNombre = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id_editorial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GBFiltrar.SuspendLayout()
        Me.GBTelefono.SuspendLayout()
        Me.GBDireccion.SuspendLayout()
        Me.GBMail.SuspendLayout()
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
        Me.GBFiltrar.Controls.Add(Me.GBDireccion)
        Me.GBFiltrar.Controls.Add(Me.BBuscar)
        Me.GBFiltrar.Controls.Add(Me.GBTelefono)
        Me.GBFiltrar.Controls.Add(Me.GBMail)
        Me.GBFiltrar.Controls.Add(Me.GBNombre)
        Me.GBFiltrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBFiltrar.Location = New System.Drawing.Point(12, 55)
        Me.GBFiltrar.Name = "GBFiltrar"
        Me.GBFiltrar.Size = New System.Drawing.Size(664, 98)
        Me.GBFiltrar.TabIndex = 3
        Me.GBFiltrar.TabStop = False
        Me.GBFiltrar.Text = "Filtrar Por"
        '
        'CBTodos
        '
        Me.CBTodos.AutoSize = True
        Me.CBTodos.Location = New System.Drawing.Point(6, 25)
        Me.CBTodos.Name = "CBTodos"
        Me.CBTodos.Size = New System.Drawing.Size(122, 17)
        Me.CBTodos.TabIndex = 6
        Me.CBTodos.Text = "Todas las editoriales"
        Me.CBTodos.UseVisualStyleBackColor = True
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BBuscar.Location = New System.Drawing.Point(6, 54)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(117, 27)
        Me.BBuscar.TabIndex = 4
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'GBTelefono
        '
        Me.GBTelefono.Controls.Add(Me.TextBox4)
        Me.GBTelefono.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBTelefono.Location = New System.Drawing.Point(406, 31)
        Me.GBTelefono.Name = "GBTelefono"
        Me.GBTelefono.Size = New System.Drawing.Size(125, 50)
        Me.GBTelefono.TabIndex = 2
        Me.GBTelefono.TabStop = False
        Me.GBTelefono.Text = "Telefono"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(6, 17)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(112, 20)
        Me.TextBox4.TabIndex = 1
        '
        'GBDireccion
        '
        Me.GBDireccion.Controls.Add(Me.TextBox3)
        Me.GBDireccion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBDireccion.Location = New System.Drawing.Point(536, 31)
        Me.GBDireccion.Name = "GBDireccion"
        Me.GBDireccion.Size = New System.Drawing.Size(122, 50)
        Me.GBDireccion.TabIndex = 3
        Me.GBDireccion.TabStop = False
        Me.GBDireccion.Text = "Direccion"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(6, 17)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(110, 20)
        Me.TextBox3.TabIndex = 2
        '
        'GBMail
        '
        Me.GBMail.Controls.Add(Me.TextBox2)
        Me.GBMail.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBMail.Location = New System.Drawing.Point(267, 31)
        Me.GBMail.Name = "GBMail"
        Me.GBMail.Size = New System.Drawing.Size(133, 50)
        Me.GBMail.TabIndex = 1
        Me.GBMail.TabStop = False
        Me.GBMail.Text = "Mail"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 17)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(117, 20)
        Me.TextBox2.TabIndex = 2
        '
        'GBNombre
        '
        Me.GBNombre.Controls.Add(Me.TextBox1)
        Me.GBNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBNombre.Location = New System.Drawing.Point(129, 31)
        Me.GBNombre.Name = "GBNombre"
        Me.GBNombre.Size = New System.Drawing.Size(133, 50)
        Me.GBNombre.TabIndex = 0
        Me.GBNombre.TabStop = False
        Me.GBNombre.Text = "Nombre"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(117, 20)
        Me.TextBox1.TabIndex = 1
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_editorial, Me.nombre, Me.telefono, Me.mail, Me.direccion})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 168)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(663, 262)
        Me.DataGridView1.TabIndex = 2
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
        'FListarEditoriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 457)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(494, 196)
        Me.MaximumSize = New System.Drawing.Size(688, 457)
        Me.MinimumSize = New System.Drawing.Size(688, 457)
        Me.Name = "FListarEditoriales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Lista Editoriales"
        Me.Panel1.ResumeLayout(False)
        Me.GBFiltrar.ResumeLayout(False)
        Me.GBFiltrar.PerformLayout()
        Me.GBTelefono.ResumeLayout(False)
        Me.GBTelefono.PerformLayout()
        Me.GBDireccion.ResumeLayout(False)
        Me.GBDireccion.PerformLayout()
        Me.GBMail.ResumeLayout(False)
        Me.GBMail.PerformLayout()
        Me.GBNombre.ResumeLayout(False)
        Me.GBNombre.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GBFiltrar As GroupBox
    Friend WithEvents CBTodos As CheckBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents GBTelefono As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents GBDireccion As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GBMail As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GBNombre As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BSalir As Button
    Friend WithEvents id_editorial As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents mail As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
End Class
