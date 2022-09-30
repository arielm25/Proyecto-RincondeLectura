<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class administrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(administrador))
        Me.P = New System.Windows.Forms.Panel()
        Me.PVentas = New System.Windows.Forms.Panel()
        Me.BLVentas = New System.Windows.Forms.Button()
        Me.BVentas = New System.Windows.Forms.Button()
        Me.PEditorial = New System.Windows.Forms.Panel()
        Me.BABMGeneros = New System.Windows.Forms.Button()
        Me.BAMBEditoriales = New System.Windows.Forms.Button()
        Me.BABMAutores = New System.Windows.Forms.Button()
        Me.BABMLibros = New System.Windows.Forms.Button()
        Me.BLibros = New System.Windows.Forms.Button()
        Me.PAutores = New System.Windows.Forms.Panel()
        Me.BAMBClientes = New System.Windows.Forms.Button()
        Me.BClientes = New System.Windows.Forms.Button()
        Me.BBackup = New System.Windows.Forms.Button()
        Me.BCerrarSesion = New System.Windows.Forms.Button()
        Me.PUsuarios = New System.Windows.Forms.Panel()
        Me.BABMUsuarios = New System.Windows.Forms.Button()
        Me.BUsuarios = New System.Windows.Forms.Button()
        Me.PLogoVendedor = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.P.SuspendLayout()
        Me.PVentas.SuspendLayout()
        Me.PEditorial.SuspendLayout()
        Me.PAutores.SuspendLayout()
        Me.PUsuarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'P
        '
        Me.P.AutoScroll = True
        Me.P.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.P.Controls.Add(Me.PVentas)
        Me.P.Controls.Add(Me.PEditorial)
        Me.P.Controls.Add(Me.PAutores)
        Me.P.Controls.Add(Me.BBackup)
        Me.P.Controls.Add(Me.BCerrarSesion)
        Me.P.Controls.Add(Me.PUsuarios)
        Me.P.Controls.Add(Me.BUsuarios)
        Me.P.Controls.Add(Me.PLogoVendedor)
        Me.P.Dock = System.Windows.Forms.DockStyle.Left
        Me.P.Location = New System.Drawing.Point(0, 0)
        Me.P.Margin = New System.Windows.Forms.Padding(4)
        Me.P.Name = "P"
        Me.P.Size = New System.Drawing.Size(189, 556)
        Me.P.TabIndex = 10
        '
        'PVentas
        '
        Me.PVentas.Controls.Add(Me.BLVentas)
        Me.PVentas.Controls.Add(Me.BVentas)
        Me.PVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PVentas.Location = New System.Drawing.Point(0, 384)
        Me.PVentas.Margin = New System.Windows.Forms.Padding(4)
        Me.PVentas.Name = "PVentas"
        Me.PVentas.Size = New System.Drawing.Size(189, 60)
        Me.PVentas.TabIndex = 40
        '
        'BLVentas
        '
        Me.BLVentas.BackColor = System.Drawing.Color.White
        Me.BLVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BLVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLVentas.Location = New System.Drawing.Point(0, 31)
        Me.BLVentas.Margin = New System.Windows.Forms.Padding(4)
        Me.BLVentas.Name = "BLVentas"
        Me.BLVentas.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BLVentas.Size = New System.Drawing.Size(189, 30)
        Me.BLVentas.TabIndex = 34
        Me.BLVentas.Text = "Lista de Ventas"
        Me.BLVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLVentas.UseVisualStyleBackColor = False
        '
        'BVentas
        '
        Me.BVentas.BackColor = System.Drawing.Color.Silver
        Me.BVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BVentas.FlatAppearance.BorderSize = 0
        Me.BVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVentas.Location = New System.Drawing.Point(0, 0)
        Me.BVentas.Margin = New System.Windows.Forms.Padding(4)
        Me.BVentas.Name = "BVentas"
        Me.BVentas.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.BVentas.Size = New System.Drawing.Size(189, 31)
        Me.BVentas.TabIndex = 35
        Me.BVentas.Text = "Ventas"
        Me.BVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVentas.UseVisualStyleBackColor = False
        '
        'PEditorial
        '
        Me.PEditorial.Controls.Add(Me.BABMGeneros)
        Me.PEditorial.Controls.Add(Me.BAMBEditoriales)
        Me.PEditorial.Controls.Add(Me.BABMAutores)
        Me.PEditorial.Controls.Add(Me.BABMLibros)
        Me.PEditorial.Controls.Add(Me.BLibros)
        Me.PEditorial.Dock = System.Windows.Forms.DockStyle.Top
        Me.PEditorial.Location = New System.Drawing.Point(0, 238)
        Me.PEditorial.Margin = New System.Windows.Forms.Padding(4)
        Me.PEditorial.Name = "PEditorial"
        Me.PEditorial.Size = New System.Drawing.Size(189, 146)
        Me.PEditorial.TabIndex = 39
        '
        'BABMGeneros
        '
        Me.BABMGeneros.BackColor = System.Drawing.Color.White
        Me.BABMGeneros.Dock = System.Windows.Forms.DockStyle.Top
        Me.BABMGeneros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BABMGeneros.Location = New System.Drawing.Point(0, 114)
        Me.BABMGeneros.Margin = New System.Windows.Forms.Padding(4)
        Me.BABMGeneros.Name = "BABMGeneros"
        Me.BABMGeneros.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BABMGeneros.Size = New System.Drawing.Size(189, 31)
        Me.BABMGeneros.TabIndex = 39
        Me.BABMGeneros.Text = "ABM Generos"
        Me.BABMGeneros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BABMGeneros.UseVisualStyleBackColor = False
        '
        'BAMBEditoriales
        '
        Me.BAMBEditoriales.BackColor = System.Drawing.Color.White
        Me.BAMBEditoriales.Dock = System.Windows.Forms.DockStyle.Top
        Me.BAMBEditoriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAMBEditoriales.Location = New System.Drawing.Point(0, 84)
        Me.BAMBEditoriales.Margin = New System.Windows.Forms.Padding(4)
        Me.BAMBEditoriales.Name = "BAMBEditoriales"
        Me.BAMBEditoriales.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BAMBEditoriales.Size = New System.Drawing.Size(189, 30)
        Me.BAMBEditoriales.TabIndex = 38
        Me.BAMBEditoriales.Text = "ABM Editoriales"
        Me.BAMBEditoriales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BAMBEditoriales.UseVisualStyleBackColor = False
        '
        'BABMAutores
        '
        Me.BABMAutores.BackColor = System.Drawing.Color.White
        Me.BABMAutores.Dock = System.Windows.Forms.DockStyle.Top
        Me.BABMAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BABMAutores.Location = New System.Drawing.Point(0, 56)
        Me.BABMAutores.Margin = New System.Windows.Forms.Padding(4)
        Me.BABMAutores.Name = "BABMAutores"
        Me.BABMAutores.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BABMAutores.Size = New System.Drawing.Size(189, 28)
        Me.BABMAutores.TabIndex = 37
        Me.BABMAutores.Text = "ABM Autores"
        Me.BABMAutores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BABMAutores.UseVisualStyleBackColor = False
        '
        'BABMLibros
        '
        Me.BABMLibros.BackColor = System.Drawing.Color.White
        Me.BABMLibros.Dock = System.Windows.Forms.DockStyle.Top
        Me.BABMLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BABMLibros.Location = New System.Drawing.Point(0, 28)
        Me.BABMLibros.Margin = New System.Windows.Forms.Padding(4)
        Me.BABMLibros.Name = "BABMLibros"
        Me.BABMLibros.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BABMLibros.Size = New System.Drawing.Size(189, 28)
        Me.BABMLibros.TabIndex = 34
        Me.BABMLibros.Text = "ABM Libros"
        Me.BABMLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BABMLibros.UseVisualStyleBackColor = False
        '
        'BLibros
        '
        Me.BLibros.BackColor = System.Drawing.Color.Silver
        Me.BLibros.Dock = System.Windows.Forms.DockStyle.Top
        Me.BLibros.FlatAppearance.BorderSize = 0
        Me.BLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLibros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLibros.Location = New System.Drawing.Point(0, 0)
        Me.BLibros.Margin = New System.Windows.Forms.Padding(4)
        Me.BLibros.Name = "BLibros"
        Me.BLibros.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.BLibros.Size = New System.Drawing.Size(189, 28)
        Me.BLibros.TabIndex = 35
        Me.BLibros.Text = "Libros"
        Me.BLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLibros.UseVisualStyleBackColor = False
        '
        'PAutores
        '
        Me.PAutores.Controls.Add(Me.BAMBClientes)
        Me.PAutores.Controls.Add(Me.BClientes)
        Me.PAutores.Dock = System.Windows.Forms.DockStyle.Top
        Me.PAutores.Location = New System.Drawing.Point(0, 181)
        Me.PAutores.Margin = New System.Windows.Forms.Padding(4)
        Me.PAutores.Name = "PAutores"
        Me.PAutores.Size = New System.Drawing.Size(189, 57)
        Me.PAutores.TabIndex = 38
        '
        'BAMBClientes
        '
        Me.BAMBClientes.BackColor = System.Drawing.Color.White
        Me.BAMBClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BAMBClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAMBClientes.Location = New System.Drawing.Point(0, 28)
        Me.BAMBClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.BAMBClientes.Name = "BAMBClientes"
        Me.BAMBClientes.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BAMBClientes.Size = New System.Drawing.Size(189, 28)
        Me.BAMBClientes.TabIndex = 36
        Me.BAMBClientes.Text = "ABM Clientes"
        Me.BAMBClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BAMBClientes.UseVisualStyleBackColor = False
        '
        'BClientes
        '
        Me.BClientes.BackColor = System.Drawing.Color.Silver
        Me.BClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BClientes.FlatAppearance.BorderSize = 0
        Me.BClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BClientes.Location = New System.Drawing.Point(0, 0)
        Me.BClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.BClientes.Name = "BClientes"
        Me.BClientes.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.BClientes.Size = New System.Drawing.Size(189, 28)
        Me.BClientes.TabIndex = 35
        Me.BClientes.Text = "Clientes"
        Me.BClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BClientes.UseVisualStyleBackColor = False
        '
        'BBackup
        '
        Me.BBackup.BackgroundImage = CType(resources.GetObject("BBackup.BackgroundImage"), System.Drawing.Image)
        Me.BBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BBackup.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BBackup.FlatAppearance.BorderSize = 0
        Me.BBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBackup.ForeColor = System.Drawing.SystemColors.Control
        Me.BBackup.Location = New System.Drawing.Point(0, 483)
        Me.BBackup.Margin = New System.Windows.Forms.Padding(4)
        Me.BBackup.Name = "BBackup"
        Me.BBackup.Size = New System.Drawing.Size(189, 32)
        Me.BBackup.TabIndex = 37
        Me.BBackup.Text = "  Backup"
        Me.BBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BBackup.UseVisualStyleBackColor = True
        '
        'BCerrarSesion
        '
        Me.BCerrarSesion.BackColor = System.Drawing.Color.Transparent
        Me.BCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BCerrarSesion.FlatAppearance.BorderSize = 0
        Me.BCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCerrarSesion.ForeColor = System.Drawing.SystemColors.Control
        Me.BCerrarSesion.Location = New System.Drawing.Point(0, 515)
        Me.BCerrarSesion.Margin = New System.Windows.Forms.Padding(4)
        Me.BCerrarSesion.Name = "BCerrarSesion"
        Me.BCerrarSesion.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.BCerrarSesion.Size = New System.Drawing.Size(189, 41)
        Me.BCerrarSesion.TabIndex = 36
        Me.BCerrarSesion.Text = "Cerrar Sesion"
        Me.BCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCerrarSesion.UseVisualStyleBackColor = False
        '
        'PUsuarios
        '
        Me.PUsuarios.BackColor = System.Drawing.Color.White
        Me.PUsuarios.Controls.Add(Me.BABMUsuarios)
        Me.PUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.PUsuarios.Location = New System.Drawing.Point(0, 147)
        Me.PUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.PUsuarios.Name = "PUsuarios"
        Me.PUsuarios.Size = New System.Drawing.Size(189, 34)
        Me.PUsuarios.TabIndex = 11
        '
        'BABMUsuarios
        '
        Me.BABMUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BABMUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BABMUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.BABMUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.BABMUsuarios.Name = "BABMUsuarios"
        Me.BABMUsuarios.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BABMUsuarios.Size = New System.Drawing.Size(189, 33)
        Me.BABMUsuarios.TabIndex = 0
        Me.BABMUsuarios.Text = "ABM Usuarios"
        Me.BABMUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BABMUsuarios.UseVisualStyleBackColor = True
        '
        'BUsuarios
        '
        Me.BUsuarios.BackColor = System.Drawing.Color.Silver
        Me.BUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BUsuarios.FlatAppearance.BorderSize = 0
        Me.BUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUsuarios.Location = New System.Drawing.Point(0, 113)
        Me.BUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.BUsuarios.Name = "BUsuarios"
        Me.BUsuarios.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.BUsuarios.Size = New System.Drawing.Size(189, 34)
        Me.BUsuarios.TabIndex = 9
        Me.BUsuarios.Text = "Usuarios"
        Me.BUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BUsuarios.UseVisualStyleBackColor = False
        '
        'PLogoVendedor
        '
        Me.PLogoVendedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.PLogoVendedor.Location = New System.Drawing.Point(0, 0)
        Me.PLogoVendedor.Margin = New System.Windows.Forms.Padding(4)
        Me.PLogoVendedor.Name = "PLogoVendedor"
        Me.PLogoVendedor.Size = New System.Drawing.Size(189, 113)
        Me.PLogoVendedor.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(189, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(919, 556)
        Me.Panel1.TabIndex = 13
        '
        'administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 556)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.P)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(1126, 603)
        Me.MinimumSize = New System.Drawing.Size(1126, 603)
        Me.Name = "administrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador"
        Me.P.ResumeLayout(False)
        Me.PVentas.ResumeLayout(False)
        Me.PEditorial.ResumeLayout(False)
        Me.PAutores.ResumeLayout(False)
        Me.PUsuarios.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents P As Panel
    Friend WithEvents PVentas As Panel
    Friend WithEvents BLVentas As Button
    Friend WithEvents BVentas As Button
    Friend WithEvents PEditorial As Panel
    Friend WithEvents BABMLibros As Button
    Friend WithEvents BLibros As Button
    Friend WithEvents PAutores As Panel
    Friend WithEvents BClientes As Button
    Friend WithEvents BCerrarSesion As Button
    Friend WithEvents BUsuarios As Button
    Friend WithEvents PLogoVendedor As Panel
    Friend WithEvents BBackup As Button
    Friend WithEvents PUsuarios As Panel
    Friend WithEvents BABMUsuarios As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BAMBClientes As Button
    Friend WithEvents BABMAutores As Button
    Friend WithEvents BABMGeneros As Button
    Friend WithEvents BAMBEditoriales As Button
End Class
