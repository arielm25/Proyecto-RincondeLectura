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
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.GBFiltrar = New System.Windows.Forms.GroupBox()
        Me.RBtodos = New System.Windows.Forms.RadioButton()
        Me.RBusername = New System.Windows.Forms.RadioButton()
        Me.RBdni = New System.Windows.Forms.RadioButton()
        Me.RBape = New System.Windows.Forms.RadioButton()
        Me.RBnom = New System.Windows.Forms.RadioButton()
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
        Me.Panel1.Controls.Add(Me.BCancelar)
        Me.Panel1.Controls.Add(Me.GBFiltrar)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(722, 391)
        Me.Panel1.TabIndex = 0
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BCancelar.Location = New System.Drawing.Point(306, 347)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(117, 27)
        Me.BCancelar.TabIndex = 9
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'GBFiltrar
        '
        Me.GBFiltrar.BackColor = System.Drawing.Color.Transparent
        Me.GBFiltrar.Controls.Add(Me.RBtodos)
        Me.GBFiltrar.Controls.Add(Me.RBusername)
        Me.GBFiltrar.Controls.Add(Me.RBdni)
        Me.GBFiltrar.Controls.Add(Me.RBape)
        Me.GBFiltrar.Controls.Add(Me.RBnom)
        Me.GBFiltrar.Controls.Add(Me.GBdni)
        Me.GBFiltrar.Controls.Add(Me.BBuscar)
        Me.GBFiltrar.Controls.Add(Me.GBusername)
        Me.GBFiltrar.Controls.Add(Me.GBApellido)
        Me.GBFiltrar.Controls.Add(Me.GBNombre)
        Me.GBFiltrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBFiltrar.Location = New System.Drawing.Point(30, 29)
        Me.GBFiltrar.Name = "GBFiltrar"
        Me.GBFiltrar.Size = New System.Drawing.Size(681, 117)
        Me.GBFiltrar.TabIndex = 8
        Me.GBFiltrar.TabStop = False
        Me.GBFiltrar.Text = "Filtrar Por"
        '
        'RBtodos
        '
        Me.RBtodos.AutoSize = True
        Me.RBtodos.Location = New System.Drawing.Point(9, 33)
        Me.RBtodos.Name = "RBtodos"
        Me.RBtodos.Size = New System.Drawing.Size(115, 17)
        Me.RBtodos.TabIndex = 26
        Me.RBtodos.TabStop = True
        Me.RBtodos.Text = "Todos los Usuarios"
        Me.RBtodos.UseVisualStyleBackColor = True
        '
        'RBusername
        '
        Me.RBusername.AutoSize = True
        Me.RBusername.Location = New System.Drawing.Point(539, 20)
        Me.RBusername.Name = "RBusername"
        Me.RBusername.Size = New System.Drawing.Size(116, 17)
        Me.RBusername.TabIndex = 25
        Me.RBusername.TabStop = True
        Me.RBusername.Text = "Nombre de Usuario"
        Me.RBusername.UseVisualStyleBackColor = True
        '
        'RBdni
        '
        Me.RBdni.AutoSize = True
        Me.RBdni.Location = New System.Drawing.Point(139, 21)
        Me.RBdni.Name = "RBdni"
        Me.RBdni.Size = New System.Drawing.Size(41, 17)
        Me.RBdni.TabIndex = 24
        Me.RBdni.TabStop = True
        Me.RBdni.Text = "Dni"
        Me.RBdni.UseVisualStyleBackColor = True
        '
        'RBape
        '
        Me.RBape.AutoSize = True
        Me.RBape.Location = New System.Drawing.Point(399, 20)
        Me.RBape.Name = "RBape"
        Me.RBape.Size = New System.Drawing.Size(62, 17)
        Me.RBape.TabIndex = 23
        Me.RBape.TabStop = True
        Me.RBape.Text = "Apellido"
        Me.RBape.UseVisualStyleBackColor = True
        '
        'RBnom
        '
        Me.RBnom.AutoSize = True
        Me.RBnom.Location = New System.Drawing.Point(266, 20)
        Me.RBnom.Name = "RBnom"
        Me.RBnom.Size = New System.Drawing.Size(62, 17)
        Me.RBnom.TabIndex = 22
        Me.RBnom.TabStop = True
        Me.RBnom.Text = "Nombre"
        Me.RBnom.UseVisualStyleBackColor = True
        '
        'GBdni
        '
        Me.GBdni.BackColor = System.Drawing.Color.Transparent
        Me.GBdni.Controls.Add(Me.CBdni)
        Me.GBdni.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBdni.Location = New System.Drawing.Point(133, 43)
        Me.GBdni.Name = "GBdni"
        Me.GBdni.Size = New System.Drawing.Size(127, 51)
        Me.GBdni.TabIndex = 5
        Me.GBdni.TabStop = False
        Me.GBdni.Text = "dni"
        '
        'CBdni
        '
        Me.CBdni.FormattingEnabled = True
        Me.CBdni.Location = New System.Drawing.Point(6, 18)
        Me.CBdni.Name = "CBdni"
        Me.CBdni.Size = New System.Drawing.Size(115, 21)
        Me.CBdni.TabIndex = 2
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BBuscar.Location = New System.Drawing.Point(9, 66)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(117, 27)
        Me.BBuscar.TabIndex = 6
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'GBusername
        '
        Me.GBusername.BackColor = System.Drawing.Color.Transparent
        Me.GBusername.Controls.Add(Me.CBusername)
        Me.GBusername.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBusername.Location = New System.Drawing.Point(539, 43)
        Me.GBusername.Name = "GBusername"
        Me.GBusername.Size = New System.Drawing.Size(127, 51)
        Me.GBusername.TabIndex = 3
        Me.GBusername.TabStop = False
        Me.GBusername.Text = "nombre de usuario"
        '
        'CBusername
        '
        Me.CBusername.FormattingEnabled = True
        Me.CBusername.Location = New System.Drawing.Point(6, 16)
        Me.CBusername.Name = "CBusername"
        Me.CBusername.Size = New System.Drawing.Size(115, 21)
        Me.CBusername.TabIndex = 2
        '
        'GBApellido
        '
        Me.GBApellido.BackColor = System.Drawing.Color.Transparent
        Me.GBApellido.Controls.Add(Me.CBape)
        Me.GBApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBApellido.Location = New System.Drawing.Point(399, 44)
        Me.GBApellido.Name = "GBApellido"
        Me.GBApellido.Size = New System.Drawing.Size(127, 51)
        Me.GBApellido.TabIndex = 4
        Me.GBApellido.TabStop = False
        Me.GBApellido.Text = "apellido"
        '
        'CBape
        '
        Me.CBape.FormattingEnabled = True
        Me.CBape.Location = New System.Drawing.Point(6, 18)
        Me.CBape.Name = "CBape"
        Me.CBape.Size = New System.Drawing.Size(115, 21)
        Me.CBape.TabIndex = 2
        '
        'GBNombre
        '
        Me.GBNombre.BackColor = System.Drawing.Color.Transparent
        Me.GBNombre.Controls.Add(Me.CBnom)
        Me.GBNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBNombre.Location = New System.Drawing.Point(266, 43)
        Me.GBNombre.Name = "GBNombre"
        Me.GBNombre.Size = New System.Drawing.Size(127, 51)
        Me.GBNombre.TabIndex = 2
        Me.GBNombre.TabStop = False
        Me.GBNombre.Text = "nombre"
        '
        'CBnom
        '
        Me.CBnom.FormattingEnabled = True
        Me.CBnom.Location = New System.Drawing.Point(6, 19)
        Me.CBnom.Name = "CBnom"
        Me.CBnom.Size = New System.Drawing.Size(115, 21)
        Me.CBnom.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(26, 162)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowTemplate.Height = 50
        Me.DataGridView1.Size = New System.Drawing.Size(686, 177)
        Me.DataGridView1.TabIndex = 7
        '
        'FListarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 391)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FListarUsuarios"
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
    Friend WithEvents BCancelar As Button
    Friend WithEvents GBFiltrar As GroupBox
    Friend WithEvents RBtodos As RadioButton
    Friend WithEvents RBusername As RadioButton
    Friend WithEvents RBdni As RadioButton
    Friend WithEvents RBape As RadioButton
    Friend WithEvents RBnom As RadioButton
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
End Class
