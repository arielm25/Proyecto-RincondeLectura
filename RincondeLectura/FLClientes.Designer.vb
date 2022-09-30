<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FLClientes
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
        Me.GBFiltrar = New System.Windows.Forms.GroupBox()
        Me.CBTodos = New System.Windows.Forms.CheckBox()
        Me.GBApellido = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.GBMail = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GBTelefono = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GBNombre = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GBFiltrar.SuspendLayout()
        Me.GBApellido.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBMail.SuspendLayout()
        Me.GBTelefono.SuspendLayout()
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
        Me.BSalir.TabIndex = 67
        Me.BSalir.Text = "X"
        Me.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'GBFiltrar
        '
        Me.GBFiltrar.BackColor = System.Drawing.Color.Transparent
        Me.GBFiltrar.Controls.Add(Me.CBTodos)
        Me.GBFiltrar.Controls.Add(Me.GBApellido)
        Me.GBFiltrar.Controls.Add(Me.GroupBox2)
        Me.GBFiltrar.Controls.Add(Me.GroupBox1)
        Me.GBFiltrar.Controls.Add(Me.BBuscar)
        Me.GBFiltrar.Controls.Add(Me.GBMail)
        Me.GBFiltrar.Controls.Add(Me.GBTelefono)
        Me.GBFiltrar.Controls.Add(Me.GBNombre)
        Me.GBFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBFiltrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBFiltrar.Location = New System.Drawing.Point(15, 49)
        Me.GBFiltrar.Name = "GBFiltrar"
        Me.GBFiltrar.Size = New System.Drawing.Size(657, 125)
        Me.GBFiltrar.TabIndex = 8
        Me.GBFiltrar.TabStop = False
        Me.GBFiltrar.Text = "Filtrar Por"
        '
        'CBTodos
        '
        Me.CBTodos.AutoSize = True
        Me.CBTodos.Location = New System.Drawing.Point(10, 42)
        Me.CBTodos.Name = "CBTodos"
        Me.CBTodos.Size = New System.Drawing.Size(111, 17)
        Me.CBTodos.TabIndex = 7
        Me.CBTodos.Text = "Todos los clientes"
        Me.CBTodos.UseVisualStyleBackColor = True
        '
        'GBApellido
        '
        Me.GBApellido.BackColor = System.Drawing.Color.Transparent
        Me.GBApellido.Controls.Add(Me.TextBox2)
        Me.GBApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBApellido.Location = New System.Drawing.Point(390, 19)
        Me.GBApellido.Name = "GBApellido"
        Me.GBApellido.Size = New System.Drawing.Size(127, 48)
        Me.GBApellido.TabIndex = 4
        Me.GBApellido.TabStop = False
        Me.GBApellido.Text = "Apellido"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 17)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(111, 20)
        Me.TextBox2.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(390, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 48)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Direccion"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(6, 17)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(244, 20)
        Me.TextBox6.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(127, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 48)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DNI"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(6, 17)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(111, 20)
        Me.TextBox5.TabIndex = 0
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscar.Location = New System.Drawing.Point(8, 72)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(111, 27)
        Me.BBuscar.TabIndex = 6
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'GBMail
        '
        Me.GBMail.BackColor = System.Drawing.Color.Transparent
        Me.GBMail.Controls.Add(Me.TextBox4)
        Me.GBMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBMail.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBMail.Location = New System.Drawing.Point(127, 66)
        Me.GBMail.Name = "GBMail"
        Me.GBMail.Size = New System.Drawing.Size(260, 48)
        Me.GBMail.TabIndex = 3
        Me.GBMail.TabStop = False
        Me.GBMail.Text = "Mail"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(6, 17)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(244, 20)
        Me.TextBox4.TabIndex = 0
        '
        'GBTelefono
        '
        Me.GBTelefono.BackColor = System.Drawing.Color.Transparent
        Me.GBTelefono.Controls.Add(Me.TextBox3)
        Me.GBTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBTelefono.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBTelefono.Location = New System.Drawing.Point(522, 19)
        Me.GBTelefono.Name = "GBTelefono"
        Me.GBTelefono.Size = New System.Drawing.Size(127, 48)
        Me.GBTelefono.TabIndex = 5
        Me.GBTelefono.TabStop = False
        Me.GBTelefono.Text = "Telefono"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(6, 17)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(111, 20)
        Me.TextBox3.TabIndex = 0
        '
        'GBNombre
        '
        Me.GBNombre.BackColor = System.Drawing.Color.Transparent
        Me.GBNombre.Controls.Add(Me.TextBox1)
        Me.GBNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBNombre.Location = New System.Drawing.Point(259, 19)
        Me.GBNombre.Name = "GBNombre"
        Me.GBNombre.Size = New System.Drawing.Size(127, 48)
        Me.GBNombre.TabIndex = 2
        Me.GBNombre.TabStop = False
        Me.GBNombre.Text = "Nombre"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(111, 20)
        Me.TextBox1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dni, Me.nombre, Me.apellido, Me.telefono, Me.mail, Me.Direccion})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 182)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(658, 253)
        Me.DataGridView1.TabIndex = 7
        '
        'dni
        '
        Me.dni.HeaderText = "DNI"
        Me.dni.Name = "dni"
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'apellido
        '
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        '
        'telefono
        '
        Me.telefono.HeaderText = "Telefono"
        Me.telefono.Name = "telefono"
        '
        'mail
        '
        Me.mail.HeaderText = "Mail"
        Me.mail.Name = "mail"
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        '
        'FLClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 457)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(494, 196)
        Me.Name = "FLClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.GBFiltrar.ResumeLayout(False)
        Me.GBFiltrar.PerformLayout()
        Me.GBApellido.ResumeLayout(False)
        Me.GBApellido.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBMail.ResumeLayout(False)
        Me.GBMail.PerformLayout()
        Me.GBTelefono.ResumeLayout(False)
        Me.GBTelefono.PerformLayout()
        Me.GBNombre.ResumeLayout(False)
        Me.GBNombre.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GBFiltrar As GroupBox
    Friend WithEvents CBTodos As CheckBox
    Friend WithEvents GBApellido As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents GBMail As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents GBTelefono As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GBNombre As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BSalir As Button
    Friend WithEvents dni As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents mail As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
End Class
