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
        Me.PClientes = New System.Windows.Forms.Panel()
        Me.BNEditorial = New System.Windows.Forms.Button()
        Me.BClientes = New System.Windows.Forms.Button()
        Me.PVentas = New System.Windows.Forms.Panel()
        Me.BLVentas = New System.Windows.Forms.Button()
        Me.BVentas = New System.Windows.Forms.Button()
        Me.PEditorial = New System.Windows.Forms.Panel()
        Me.BLEditorial = New System.Windows.Forms.Button()
        Me.BModEditorial = New System.Windows.Forms.Button()
        Me.BNuevaEditorial = New System.Windows.Forms.Button()
        Me.BEditorial = New System.Windows.Forms.Button()
        Me.PAutores = New System.Windows.Forms.Panel()
        Me.BLAutores = New System.Windows.Forms.Button()
        Me.BModAutor = New System.Windows.Forms.Button()
        Me.BNuevoAutor = New System.Windows.Forms.Button()
        Me.BAutores = New System.Windows.Forms.Button()
        Me.BBackup = New System.Windows.Forms.Button()
        Me.BCerrarSesion = New System.Windows.Forms.Button()
        Me.PUsuarios = New System.Windows.Forms.Panel()
        Me.BLUsuarios = New System.Windows.Forms.Button()
        Me.BModificarUsuario = New System.Windows.Forms.Button()
        Me.BNuevoUsuario = New System.Windows.Forms.Button()
        Me.BUsuarios = New System.Windows.Forms.Button()
        Me.PLogoVendedor = New System.Windows.Forms.Panel()
        Me.LVendedor = New System.Windows.Forms.Label()
        Me.P.SuspendLayout()
        Me.PClientes.SuspendLayout()
        Me.PVentas.SuspendLayout()
        Me.PEditorial.SuspendLayout()
        Me.PAutores.SuspendLayout()
        Me.PUsuarios.SuspendLayout()
        Me.PLogoVendedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'P
        '
        Me.P.AutoScroll = True
        Me.P.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.P.Controls.Add(Me.PClientes)
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
        Me.P.Name = "P"
        Me.P.Size = New System.Drawing.Size(158, 536)
        Me.P.TabIndex = 10
        '
        'PClientes
        '
        Me.PClientes.Controls.Add(Me.BNEditorial)
        Me.PClientes.Controls.Add(Me.BClientes)
        Me.PClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PClientes.Location = New System.Drawing.Point(0, 430)
        Me.PClientes.Name = "PClientes"
        Me.PClientes.Size = New System.Drawing.Size(141, 49)
        Me.PClientes.TabIndex = 41
        '
        'BNEditorial
        '
        Me.BNEditorial.BackColor = System.Drawing.Color.White
        Me.BNEditorial.Dock = System.Windows.Forms.DockStyle.Top
        Me.BNEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BNEditorial.Location = New System.Drawing.Point(0, 23)
        Me.BNEditorial.Name = "BNEditorial"
        Me.BNEditorial.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BNEditorial.Size = New System.Drawing.Size(141, 26)
        Me.BNEditorial.TabIndex = 34
        Me.BNEditorial.Text = "Listas de Clientes"
        Me.BNEditorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BNEditorial.UseVisualStyleBackColor = False
        '
        'BClientes
        '
        Me.BClientes.BackColor = System.Drawing.Color.Silver
        Me.BClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BClientes.FlatAppearance.BorderSize = 0
        Me.BClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BClientes.Location = New System.Drawing.Point(0, 0)
        Me.BClientes.Name = "BClientes"
        Me.BClientes.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BClientes.Size = New System.Drawing.Size(141, 23)
        Me.BClientes.TabIndex = 35
        Me.BClientes.Text = "Clientes"
        Me.BClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BClientes.UseVisualStyleBackColor = False
        '
        'PVentas
        '
        Me.PVentas.Controls.Add(Me.BLVentas)
        Me.PVentas.Controls.Add(Me.BVentas)
        Me.PVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PVentas.Location = New System.Drawing.Point(0, 381)
        Me.PVentas.Name = "PVentas"
        Me.PVentas.Size = New System.Drawing.Size(141, 49)
        Me.PVentas.TabIndex = 40
        '
        'BLVentas
        '
        Me.BLVentas.BackColor = System.Drawing.Color.White
        Me.BLVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BLVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLVentas.Location = New System.Drawing.Point(0, 25)
        Me.BLVentas.Name = "BLVentas"
        Me.BLVentas.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BLVentas.Size = New System.Drawing.Size(141, 24)
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
        Me.BVentas.Location = New System.Drawing.Point(0, 0)
        Me.BVentas.Name = "BVentas"
        Me.BVentas.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BVentas.Size = New System.Drawing.Size(141, 25)
        Me.BVentas.TabIndex = 35
        Me.BVentas.Text = "Ventas"
        Me.BVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVentas.UseVisualStyleBackColor = False
        '
        'PEditorial
        '
        Me.PEditorial.Controls.Add(Me.BLEditorial)
        Me.PEditorial.Controls.Add(Me.BModEditorial)
        Me.PEditorial.Controls.Add(Me.BNuevaEditorial)
        Me.PEditorial.Controls.Add(Me.BEditorial)
        Me.PEditorial.Dock = System.Windows.Forms.DockStyle.Top
        Me.PEditorial.Location = New System.Drawing.Point(0, 287)
        Me.PEditorial.Name = "PEditorial"
        Me.PEditorial.Size = New System.Drawing.Size(141, 94)
        Me.PEditorial.TabIndex = 39
        '
        'BLEditorial
        '
        Me.BLEditorial.BackColor = System.Drawing.Color.White
        Me.BLEditorial.Dock = System.Windows.Forms.DockStyle.Top
        Me.BLEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLEditorial.Location = New System.Drawing.Point(0, 69)
        Me.BLEditorial.Name = "BLEditorial"
        Me.BLEditorial.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BLEditorial.Size = New System.Drawing.Size(141, 25)
        Me.BLEditorial.TabIndex = 37
        Me.BLEditorial.Text = "Listas de Editorial"
        Me.BLEditorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLEditorial.UseVisualStyleBackColor = False
        '
        'BModEditorial
        '
        Me.BModEditorial.BackColor = System.Drawing.Color.White
        Me.BModEditorial.Dock = System.Windows.Forms.DockStyle.Top
        Me.BModEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModEditorial.Location = New System.Drawing.Point(0, 46)
        Me.BModEditorial.Name = "BModEditorial"
        Me.BModEditorial.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BModEditorial.Size = New System.Drawing.Size(141, 23)
        Me.BModEditorial.TabIndex = 36
        Me.BModEditorial.Text = "Modificar Editorial"
        Me.BModEditorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BModEditorial.UseVisualStyleBackColor = False
        '
        'BNuevaEditorial
        '
        Me.BNuevaEditorial.BackColor = System.Drawing.Color.White
        Me.BNuevaEditorial.Dock = System.Windows.Forms.DockStyle.Top
        Me.BNuevaEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BNuevaEditorial.Location = New System.Drawing.Point(0, 23)
        Me.BNuevaEditorial.Name = "BNuevaEditorial"
        Me.BNuevaEditorial.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BNuevaEditorial.Size = New System.Drawing.Size(141, 23)
        Me.BNuevaEditorial.TabIndex = 34
        Me.BNuevaEditorial.Text = "Nueva Editorial"
        Me.BNuevaEditorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BNuevaEditorial.UseVisualStyleBackColor = False
        '
        'BEditorial
        '
        Me.BEditorial.BackColor = System.Drawing.Color.Silver
        Me.BEditorial.Dock = System.Windows.Forms.DockStyle.Top
        Me.BEditorial.FlatAppearance.BorderSize = 0
        Me.BEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEditorial.Location = New System.Drawing.Point(0, 0)
        Me.BEditorial.Name = "BEditorial"
        Me.BEditorial.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BEditorial.Size = New System.Drawing.Size(141, 23)
        Me.BEditorial.TabIndex = 35
        Me.BEditorial.Text = "Editoriales"
        Me.BEditorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BEditorial.UseVisualStyleBackColor = False
        '
        'PAutores
        '
        Me.PAutores.Controls.Add(Me.BLAutores)
        Me.PAutores.Controls.Add(Me.BModAutor)
        Me.PAutores.Controls.Add(Me.BNuevoAutor)
        Me.PAutores.Controls.Add(Me.BAutores)
        Me.PAutores.Dock = System.Windows.Forms.DockStyle.Top
        Me.PAutores.Location = New System.Drawing.Point(0, 195)
        Me.PAutores.Name = "PAutores"
        Me.PAutores.Size = New System.Drawing.Size(141, 92)
        Me.PAutores.TabIndex = 38
        '
        'BLAutores
        '
        Me.BLAutores.BackColor = System.Drawing.Color.White
        Me.BLAutores.Dock = System.Windows.Forms.DockStyle.Top
        Me.BLAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLAutores.Location = New System.Drawing.Point(0, 69)
        Me.BLAutores.Name = "BLAutores"
        Me.BLAutores.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BLAutores.Size = New System.Drawing.Size(141, 23)
        Me.BLAutores.TabIndex = 37
        Me.BLAutores.Text = "Listas de Autores"
        Me.BLAutores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLAutores.UseVisualStyleBackColor = False
        '
        'BModAutor
        '
        Me.BModAutor.BackColor = System.Drawing.Color.White
        Me.BModAutor.Dock = System.Windows.Forms.DockStyle.Top
        Me.BModAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModAutor.Location = New System.Drawing.Point(0, 46)
        Me.BModAutor.Name = "BModAutor"
        Me.BModAutor.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BModAutor.Size = New System.Drawing.Size(141, 23)
        Me.BModAutor.TabIndex = 36
        Me.BModAutor.Text = "Modificar Autor"
        Me.BModAutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BModAutor.UseVisualStyleBackColor = False
        '
        'BNuevoAutor
        '
        Me.BNuevoAutor.BackColor = System.Drawing.Color.White
        Me.BNuevoAutor.Dock = System.Windows.Forms.DockStyle.Top
        Me.BNuevoAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BNuevoAutor.Location = New System.Drawing.Point(0, 23)
        Me.BNuevoAutor.Name = "BNuevoAutor"
        Me.BNuevoAutor.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BNuevoAutor.Size = New System.Drawing.Size(141, 23)
        Me.BNuevoAutor.TabIndex = 34
        Me.BNuevoAutor.Text = "Nuevo Autor"
        Me.BNuevoAutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BNuevoAutor.UseVisualStyleBackColor = False
        '
        'BAutores
        '
        Me.BAutores.BackColor = System.Drawing.Color.Silver
        Me.BAutores.Dock = System.Windows.Forms.DockStyle.Top
        Me.BAutores.FlatAppearance.BorderSize = 0
        Me.BAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAutores.Location = New System.Drawing.Point(0, 0)
        Me.BAutores.Name = "BAutores"
        Me.BAutores.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BAutores.Size = New System.Drawing.Size(141, 23)
        Me.BAutores.TabIndex = 35
        Me.BAutores.Text = "Autores"
        Me.BAutores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BAutores.UseVisualStyleBackColor = False
        '
        'BBackup
        '
        Me.BBackup.BackgroundImage = CType(resources.GetObject("BBackup.BackgroundImage"), System.Drawing.Image)
        Me.BBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BBackup.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BBackup.FlatAppearance.BorderSize = 0
        Me.BBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBackup.ForeColor = System.Drawing.SystemColors.Control
        Me.BBackup.Location = New System.Drawing.Point(0, 479)
        Me.BBackup.Name = "BBackup"
        Me.BBackup.Size = New System.Drawing.Size(141, 26)
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
        Me.BCerrarSesion.ForeColor = System.Drawing.SystemColors.Control
        Me.BCerrarSesion.Location = New System.Drawing.Point(0, 505)
        Me.BCerrarSesion.Name = "BCerrarSesion"
        Me.BCerrarSesion.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BCerrarSesion.Size = New System.Drawing.Size(141, 33)
        Me.BCerrarSesion.TabIndex = 36
        Me.BCerrarSesion.Text = "Cerrar Sesion"
        Me.BCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCerrarSesion.UseVisualStyleBackColor = False
        '
        'PUsuarios
        '
        Me.PUsuarios.BackColor = System.Drawing.Color.White
        Me.PUsuarios.Controls.Add(Me.BLUsuarios)
        Me.PUsuarios.Controls.Add(Me.BModificarUsuario)
        Me.PUsuarios.Controls.Add(Me.BNuevoUsuario)
        Me.PUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.PUsuarios.Location = New System.Drawing.Point(0, 120)
        Me.PUsuarios.Name = "PUsuarios"
        Me.PUsuarios.Size = New System.Drawing.Size(141, 75)
        Me.PUsuarios.TabIndex = 11
        '
        'BLUsuarios
        '
        Me.BLUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BLUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLUsuarios.Location = New System.Drawing.Point(0, 50)
        Me.BLUsuarios.Name = "BLUsuarios"
        Me.BLUsuarios.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BLUsuarios.Size = New System.Drawing.Size(141, 24)
        Me.BLUsuarios.TabIndex = 2
        Me.BLUsuarios.Text = "Listas de Usuarios"
        Me.BLUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLUsuarios.UseVisualStyleBackColor = True
        '
        'BModificarUsuario
        '
        Me.BModificarUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.BModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarUsuario.Location = New System.Drawing.Point(0, 27)
        Me.BModificarUsuario.Name = "BModificarUsuario"
        Me.BModificarUsuario.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BModificarUsuario.Size = New System.Drawing.Size(141, 23)
        Me.BModificarUsuario.TabIndex = 1
        Me.BModificarUsuario.Text = "Modificar Usuario"
        Me.BModificarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BModificarUsuario.UseVisualStyleBackColor = True
        '
        'BNuevoUsuario
        '
        Me.BNuevoUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.BNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BNuevoUsuario.Location = New System.Drawing.Point(0, 0)
        Me.BNuevoUsuario.Name = "BNuevoUsuario"
        Me.BNuevoUsuario.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BNuevoUsuario.Size = New System.Drawing.Size(141, 27)
        Me.BNuevoUsuario.TabIndex = 0
        Me.BNuevoUsuario.Text = "Nuevo Usuario"
        Me.BNuevoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BNuevoUsuario.UseVisualStyleBackColor = True
        '
        'BUsuarios
        '
        Me.BUsuarios.BackColor = System.Drawing.Color.Silver
        Me.BUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BUsuarios.FlatAppearance.BorderSize = 0
        Me.BUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BUsuarios.Location = New System.Drawing.Point(0, 92)
        Me.BUsuarios.Name = "BUsuarios"
        Me.BUsuarios.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BUsuarios.Size = New System.Drawing.Size(141, 28)
        Me.BUsuarios.TabIndex = 9
        Me.BUsuarios.Text = "Usuarios"
        Me.BUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BUsuarios.UseVisualStyleBackColor = False
        '
        'PLogoVendedor
        '
        Me.PLogoVendedor.Controls.Add(Me.LVendedor)
        Me.PLogoVendedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.PLogoVendedor.Location = New System.Drawing.Point(0, 0)
        Me.PLogoVendedor.Name = "PLogoVendedor"
        Me.PLogoVendedor.Size = New System.Drawing.Size(141, 92)
        Me.PLogoVendedor.TabIndex = 8
        '
        'LVendedor
        '
        Me.LVendedor.AutoSize = True
        Me.LVendedor.ForeColor = System.Drawing.SystemColors.Control
        Me.LVendedor.Location = New System.Drawing.Point(43, 51)
        Me.LVendedor.Name = "LVendedor"
        Me.LVendedor.Size = New System.Drawing.Size(57, 13)
        Me.LVendedor.TabIndex = 0
        Me.LVendedor.Text = "Mi Usuario"
        '
        'administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 536)
        Me.Controls.Add(Me.P)
        Me.IsMdiContainer = True
        Me.Name = "administrador"
        Me.Text = "MDIParent4"
        Me.P.ResumeLayout(False)
        Me.PClientes.ResumeLayout(False)
        Me.PVentas.ResumeLayout(False)
        Me.PEditorial.ResumeLayout(False)
        Me.PAutores.ResumeLayout(False)
        Me.PUsuarios.ResumeLayout(False)
        Me.PLogoVendedor.ResumeLayout(False)
        Me.PLogoVendedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents P As Panel
    Friend WithEvents PClientes As Panel
    Friend WithEvents BNEditorial As Button
    Friend WithEvents BClientes As Button
    Friend WithEvents PVentas As Panel
    Friend WithEvents BLVentas As Button
    Friend WithEvents BVentas As Button
    Friend WithEvents PEditorial As Panel
    Friend WithEvents BLEditorial As Button
    Friend WithEvents BModEditorial As Button
    Friend WithEvents BNuevaEditorial As Button
    Friend WithEvents BEditorial As Button
    Friend WithEvents PAutores As Panel
    Friend WithEvents BLAutores As Button
    Friend WithEvents BModAutor As Button
    Friend WithEvents BNuevoAutor As Button
    Friend WithEvents BAutores As Button
    Friend WithEvents BCerrarSesion As Button
    Friend WithEvents PUsuarios As Panel
    Friend WithEvents BLUsuarios As Button
    Friend WithEvents BModificarUsuario As Button
    Friend WithEvents BNuevoUsuario As Button
    Friend WithEvents BUsuarios As Button
    Friend WithEvents PLogoVendedor As Panel
    Friend WithEvents LVendedor As Label
    Friend WithEvents BBackup As Button
End Class
