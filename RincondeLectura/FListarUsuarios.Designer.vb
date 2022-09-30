<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FListarUsuarios
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.GBFiltrar = New System.Windows.Forms.GroupBox()
        Me.RBtodos = New System.Windows.Forms.RadioButton()
        Me.GBdni = New System.Windows.Forms.GroupBox()
        Me.CBdni = New System.Windows.Forms.ComboBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.GBusername = New System.Windows.Forms.GroupBox()
        Me.CBusername = New System.Windows.Forms.ComboBox()
        Me.GBApellido = New System.Windows.Forms.GroupBox()
        Me.CBape = New System.Windows.Forms.ComboBox()
        Me.GBNombre = New System.Windows.Forms.GroupBox()
        Me.CBnom = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreUs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GBFiltrar.SuspendLayout()
        Me.GBdni.SuspendLayout()
        Me.GBusername.SuspendLayout()
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
        Me.BSalir.TabIndex = 67
        Me.BSalir.Text = "X"
        Me.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'GBFiltrar
        '
        Me.GBFiltrar.BackColor = System.Drawing.Color.Transparent
        Me.GBFiltrar.Controls.Add(Me.RBtodos)
        Me.GBFiltrar.Controls.Add(Me.GBdni)
        Me.GBFiltrar.Controls.Add(Me.BBuscar)
        Me.GBFiltrar.Controls.Add(Me.GBusername)
        Me.GBFiltrar.Controls.Add(Me.GBApellido)
        Me.GBFiltrar.Controls.Add(Me.GBNombre)
        Me.GBFiltrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBFiltrar.Location = New System.Drawing.Point(19, 65)
        Me.GBFiltrar.Name = "GBFiltrar"
        Me.GBFiltrar.Size = New System.Drawing.Size(649, 99)
        Me.GBFiltrar.TabIndex = 8
        Me.GBFiltrar.TabStop = False
        Me.GBFiltrar.Text = "Filtrar Por"
        '
        'RBtodos
        '
        Me.RBtodos.AutoSize = True
        Me.RBtodos.Location = New System.Drawing.Point(9, 29)
        Me.RBtodos.Name = "RBtodos"
        Me.RBtodos.Size = New System.Drawing.Size(115, 17)
        Me.RBtodos.TabIndex = 26
        Me.RBtodos.TabStop = True
        Me.RBtodos.Text = "Todos los Usuarios"
        Me.RBtodos.UseVisualStyleBackColor = True
        '
        'GBdni
        '
        Me.GBdni.BackColor = System.Drawing.Color.Transparent
        Me.GBdni.Controls.Add(Me.CBdni)
        Me.GBdni.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBdni.Location = New System.Drawing.Point(130, 30)
        Me.GBdni.Name = "GBdni"
        Me.GBdni.Size = New System.Drawing.Size(125, 51)
        Me.GBdni.TabIndex = 5
        Me.GBdni.TabStop = False
        Me.GBdni.Text = "DNI"
        '
        'CBdni
        '
        Me.CBdni.FormattingEnabled = True
        Me.CBdni.Location = New System.Drawing.Point(5, 18)
        Me.CBdni.Name = "CBdni"
        Me.CBdni.Size = New System.Drawing.Size(115, 21)
        Me.CBdni.TabIndex = 2
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BBuscar.Location = New System.Drawing.Point(9, 54)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(113, 27)
        Me.BBuscar.TabIndex = 6
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'GBusername
        '
        Me.GBusername.BackColor = System.Drawing.Color.Transparent
        Me.GBusername.Controls.Add(Me.CBusername)
        Me.GBusername.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBusername.Location = New System.Drawing.Point(517, 30)
        Me.GBusername.Name = "GBusername"
        Me.GBusername.Size = New System.Drawing.Size(123, 51)
        Me.GBusername.TabIndex = 3
        Me.GBusername.TabStop = False
        Me.GBusername.Text = "Nombre de Usuario"
        '
        'CBusername
        '
        Me.CBusername.FormattingEnabled = True
        Me.CBusername.Location = New System.Drawing.Point(6, 16)
        Me.CBusername.Name = "CBusername"
        Me.CBusername.Size = New System.Drawing.Size(112, 21)
        Me.CBusername.TabIndex = 2
        '
        'GBApellido
        '
        Me.GBApellido.BackColor = System.Drawing.Color.Transparent
        Me.GBApellido.Controls.Add(Me.CBape)
        Me.GBApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBApellido.Location = New System.Drawing.Point(388, 30)
        Me.GBApellido.Name = "GBApellido"
        Me.GBApellido.Size = New System.Drawing.Size(124, 51)
        Me.GBApellido.TabIndex = 4
        Me.GBApellido.TabStop = False
        Me.GBApellido.Text = "Apellido"
        '
        'CBape
        '
        Me.CBape.FormattingEnabled = True
        Me.CBape.Location = New System.Drawing.Point(6, 18)
        Me.CBape.Name = "CBape"
        Me.CBape.Size = New System.Drawing.Size(111, 21)
        Me.CBape.TabIndex = 2
        '
        'GBNombre
        '
        Me.GBNombre.BackColor = System.Drawing.Color.Transparent
        Me.GBNombre.Controls.Add(Me.CBnom)
        Me.GBNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBNombre.Location = New System.Drawing.Point(260, 30)
        Me.GBNombre.Name = "GBNombre"
        Me.GBNombre.Size = New System.Drawing.Size(123, 51)
        Me.GBNombre.TabIndex = 2
        Me.GBNombre.TabStop = False
        Me.GBNombre.Text = "Nombre"
        '
        'CBnom
        '
        Me.CBnom.FormattingEnabled = True
        Me.CBnom.Location = New System.Drawing.Point(5, 19)
        Me.CBnom.Name = "CBnom"
        Me.CBnom.Size = New System.Drawing.Size(113, 21)
        Me.CBnom.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUsuario, Me.NombreUs, Me.Nombre, Me.Apellido, Me.DNI})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(19, 174)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowTemplate.Height = 50
        Me.DataGridView1.Size = New System.Drawing.Size(649, 256)
        Me.DataGridView1.TabIndex = 7
        '
        'IdUsuario
        '
        Me.IdUsuario.HeaderText = "Id_Usuario"
        Me.IdUsuario.Name = "IdUsuario"
        '
        'NombreUs
        '
        Me.NombreUs.HeaderText = "Nombre Usuario"
        Me.NombreUs.Name = "NombreUs"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        '
        'DNI
        '
        Me.DNI.HeaderText = "DNI"
        Me.DNI.Name = "DNI"
        '
        'FListarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 457)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(494, 196)
        Me.Name = "FListarUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Lista Usuarios"
        Me.Panel1.ResumeLayout(False)
        Me.GBFiltrar.ResumeLayout(False)
        Me.GBFiltrar.PerformLayout()
        Me.GBdni.ResumeLayout(False)
        Me.GBusername.ResumeLayout(False)
        Me.GBApellido.ResumeLayout(False)
        Me.GBNombre.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GBFiltrar As GroupBox
    Friend WithEvents RBtodos As RadioButton
    Friend WithEvents GBdni As GroupBox
    Friend WithEvents CBdni As ComboBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents GBusername As GroupBox
    Friend WithEvents CBusername As ComboBox
    Friend WithEvents GBApellido As GroupBox
    Friend WithEvents CBape As ComboBox
    Friend WithEvents GBNombre As GroupBox
    Friend WithEvents CBnom As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdUsuario As DataGridViewTextBoxColumn
    Friend WithEvents NombreUs As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents DNI As DataGridViewTextBoxColumn
    Friend WithEvents BSalir As Button
End Class
