<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gerente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gerente))
        Me.P = New System.Windows.Forms.Panel()
        Me.BLUsuarios = New System.Windows.Forms.Button()
        Me.BUsuarios = New System.Windows.Forms.Button()
        Me.PAutores = New System.Windows.Forms.Panel()
        Me.BLAutores = New System.Windows.Forms.Button()
        Me.PEditoriales = New System.Windows.Forms.Panel()
        Me.BLEditoriales = New System.Windows.Forms.Button()
        Me.BCerrarSesion = New System.Windows.Forms.Button()
        Me.PClientes = New System.Windows.Forms.Panel()
        Me.BLLibros = New System.Windows.Forms.Button()
        Me.BLibros = New System.Windows.Forms.Button()
        Me.PVentas = New System.Windows.Forms.Panel()
        Me.BLClientes = New System.Windows.Forms.Button()
        Me.BClientes = New System.Windows.Forms.Button()
        Me.PLibros = New System.Windows.Forms.Panel()
        Me.BLVentas = New System.Windows.Forms.Button()
        Me.BVentas = New System.Windows.Forms.Button()
        Me.PLogoVendedor = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.P.SuspendLayout()
        Me.PAutores.SuspendLayout()
        Me.PEditoriales.SuspendLayout()
        Me.PClientes.SuspendLayout()
        Me.PVentas.SuspendLayout()
        Me.PLibros.SuspendLayout()
        Me.SuspendLayout()
        '
        'P
        '
        Me.P.AutoScroll = True
        Me.P.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.P.Controls.Add(Me.BLUsuarios)
        Me.P.Controls.Add(Me.BUsuarios)
        Me.P.Controls.Add(Me.PAutores)
        Me.P.Controls.Add(Me.PEditoriales)
        Me.P.Controls.Add(Me.BCerrarSesion)
        Me.P.Controls.Add(Me.PClientes)
        Me.P.Controls.Add(Me.PVentas)
        Me.P.Controls.Add(Me.PLibros)
        Me.P.Controls.Add(Me.BVentas)
        Me.P.Controls.Add(Me.PLogoVendedor)
        Me.P.Dock = System.Windows.Forms.DockStyle.Left
        Me.P.Location = New System.Drawing.Point(0, 0)
        Me.P.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.P.Name = "P"
        Me.P.Size = New System.Drawing.Size(189, 556)
        Me.P.TabIndex = 9
        '
        'BLUsuarios
        '
        Me.BLUsuarios.BackColor = System.Drawing.Color.White
        Me.BLUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BLUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLUsuarios.Location = New System.Drawing.Point(0, 407)
        Me.BLUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BLUsuarios.Name = "BLUsuarios"
        Me.BLUsuarios.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BLUsuarios.Size = New System.Drawing.Size(189, 37)
        Me.BLUsuarios.TabIndex = 41
        Me.BLUsuarios.Text = "Lista de Usuarios"
        Me.BLUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLUsuarios.UseVisualStyleBackColor = False
        '
        'BUsuarios
        '
        Me.BUsuarios.BackColor = System.Drawing.Color.Silver
        Me.BUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BUsuarios.FlatAppearance.BorderSize = 0
        Me.BUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUsuarios.Location = New System.Drawing.Point(0, 377)
        Me.BUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BUsuarios.Name = "BUsuarios"
        Me.BUsuarios.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.BUsuarios.Size = New System.Drawing.Size(189, 30)
        Me.BUsuarios.TabIndex = 40
        Me.BUsuarios.Text = "Usuarios"
        Me.BUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BUsuarios.UseVisualStyleBackColor = False
        '
        'PAutores
        '
        Me.PAutores.Controls.Add(Me.BLAutores)
        Me.PAutores.Dock = System.Windows.Forms.DockStyle.Top
        Me.PAutores.Location = New System.Drawing.Point(0, 345)
        Me.PAutores.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PAutores.Name = "PAutores"
        Me.PAutores.Size = New System.Drawing.Size(189, 32)
        Me.PAutores.TabIndex = 38
        '
        'BLAutores
        '
        Me.BLAutores.BackColor = System.Drawing.Color.White
        Me.BLAutores.Dock = System.Windows.Forms.DockStyle.Top
        Me.BLAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLAutores.Location = New System.Drawing.Point(0, 0)
        Me.BLAutores.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BLAutores.Name = "BLAutores"
        Me.BLAutores.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BLAutores.Size = New System.Drawing.Size(189, 32)
        Me.BLAutores.TabIndex = 35
        Me.BLAutores.Text = "Lista de Autores"
        Me.BLAutores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLAutores.UseVisualStyleBackColor = False
        '
        'PEditoriales
        '
        Me.PEditoriales.Controls.Add(Me.BLEditoriales)
        Me.PEditoriales.Dock = System.Windows.Forms.DockStyle.Top
        Me.PEditoriales.Location = New System.Drawing.Point(0, 313)
        Me.PEditoriales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PEditoriales.Name = "PEditoriales"
        Me.PEditoriales.Size = New System.Drawing.Size(189, 32)
        Me.PEditoriales.TabIndex = 37
        '
        'BLEditoriales
        '
        Me.BLEditoriales.BackColor = System.Drawing.Color.White
        Me.BLEditoriales.Dock = System.Windows.Forms.DockStyle.Top
        Me.BLEditoriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLEditoriales.Location = New System.Drawing.Point(0, 0)
        Me.BLEditoriales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BLEditoriales.Name = "BLEditoriales"
        Me.BLEditoriales.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BLEditoriales.Size = New System.Drawing.Size(189, 33)
        Me.BLEditoriales.TabIndex = 34
        Me.BLEditoriales.Text = "Lista de Editoriales"
        Me.BLEditoriales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLEditoriales.UseVisualStyleBackColor = False
        '
        'BCerrarSesion
        '
        Me.BCerrarSesion.BackColor = System.Drawing.Color.Transparent
        Me.BCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BCerrarSesion.FlatAppearance.BorderSize = 0
        Me.BCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCerrarSesion.ForeColor = System.Drawing.SystemColors.Control
        Me.BCerrarSesion.Location = New System.Drawing.Point(0, 508)
        Me.BCerrarSesion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BCerrarSesion.Name = "BCerrarSesion"
        Me.BCerrarSesion.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.BCerrarSesion.Size = New System.Drawing.Size(189, 48)
        Me.BCerrarSesion.TabIndex = 36
        Me.BCerrarSesion.Text = "Cerrar Sesion"
        Me.BCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCerrarSesion.UseVisualStyleBackColor = False
        '
        'PClientes
        '
        Me.PClientes.Controls.Add(Me.BLLibros)
        Me.PClientes.Controls.Add(Me.BLibros)
        Me.PClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PClientes.Location = New System.Drawing.Point(0, 253)
        Me.PClientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PClientes.Name = "PClientes"
        Me.PClientes.Size = New System.Drawing.Size(189, 60)
        Me.PClientes.TabIndex = 13
        '
        'BLLibros
        '
        Me.BLLibros.BackColor = System.Drawing.Color.White
        Me.BLLibros.Dock = System.Windows.Forms.DockStyle.Top
        Me.BLLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLLibros.Location = New System.Drawing.Point(0, 30)
        Me.BLLibros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BLLibros.Name = "BLLibros"
        Me.BLLibros.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BLLibros.Size = New System.Drawing.Size(189, 37)
        Me.BLLibros.TabIndex = 34
        Me.BLLibros.Text = "Lista de Libros"
        Me.BLLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLLibros.UseVisualStyleBackColor = False
        '
        'BLibros
        '
        Me.BLibros.BackColor = System.Drawing.Color.Silver
        Me.BLibros.Dock = System.Windows.Forms.DockStyle.Top
        Me.BLibros.FlatAppearance.BorderSize = 0
        Me.BLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLibros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLibros.Location = New System.Drawing.Point(0, 0)
        Me.BLibros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BLibros.Name = "BLibros"
        Me.BLibros.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.BLibros.Size = New System.Drawing.Size(189, 30)
        Me.BLibros.TabIndex = 35
        Me.BLibros.Text = "Libros"
        Me.BLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLibros.UseVisualStyleBackColor = False
        '
        'PVentas
        '
        Me.PVentas.Controls.Add(Me.BLClientes)
        Me.PVentas.Controls.Add(Me.BClientes)
        Me.PVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PVentas.Location = New System.Drawing.Point(0, 190)
        Me.PVentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PVentas.Name = "PVentas"
        Me.PVentas.Size = New System.Drawing.Size(189, 63)
        Me.PVentas.TabIndex = 12
        '
        'BLClientes
        '
        Me.BLClientes.BackColor = System.Drawing.Color.White
        Me.BLClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BLClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLClientes.Location = New System.Drawing.Point(0, 33)
        Me.BLClientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BLClientes.Name = "BLClientes"
        Me.BLClientes.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BLClientes.Size = New System.Drawing.Size(189, 30)
        Me.BLClientes.TabIndex = 27
        Me.BLClientes.Text = "Lista de Clientes"
        Me.BLClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLClientes.UseVisualStyleBackColor = False
        '
        'BClientes
        '
        Me.BClientes.BackColor = System.Drawing.Color.Silver
        Me.BClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BClientes.FlatAppearance.BorderSize = 0
        Me.BClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BClientes.Location = New System.Drawing.Point(0, 0)
        Me.BClientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BClientes.Name = "BClientes"
        Me.BClientes.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.BClientes.Size = New System.Drawing.Size(189, 33)
        Me.BClientes.TabIndex = 29
        Me.BClientes.Text = "Clientes"
        Me.BClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BClientes.UseVisualStyleBackColor = False
        '
        'PLibros
        '
        Me.PLibros.BackColor = System.Drawing.Color.White
        Me.PLibros.Controls.Add(Me.BLVentas)
        Me.PLibros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PLibros.Location = New System.Drawing.Point(0, 153)
        Me.PLibros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PLibros.Name = "PLibros"
        Me.PLibros.Size = New System.Drawing.Size(189, 37)
        Me.PLibros.TabIndex = 11
        '
        'BLVentas
        '
        Me.BLVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BLVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLVentas.Location = New System.Drawing.Point(0, 0)
        Me.BLVentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BLVentas.Name = "BLVentas"
        Me.BLVentas.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BLVentas.Size = New System.Drawing.Size(189, 37)
        Me.BLVentas.TabIndex = 0
        Me.BLVentas.Text = "Lista de Ventas"
        Me.BLVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLVentas.UseVisualStyleBackColor = True
        '
        'BVentas
        '
        Me.BVentas.BackColor = System.Drawing.Color.Silver
        Me.BVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BVentas.FlatAppearance.BorderSize = 0
        Me.BVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVentas.Location = New System.Drawing.Point(0, 123)
        Me.BVentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BVentas.Name = "BVentas"
        Me.BVentas.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.BVentas.Size = New System.Drawing.Size(189, 30)
        Me.BVentas.TabIndex = 9
        Me.BVentas.Text = "Ventas"
        Me.BVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVentas.UseVisualStyleBackColor = False
        '
        'PLogoVendedor
        '
        Me.PLogoVendedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.PLogoVendedor.Location = New System.Drawing.Point(0, 0)
        Me.PLogoVendedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PLogoVendedor.Name = "PLogoVendedor"
        Me.PLogoVendedor.Size = New System.Drawing.Size(189, 123)
        Me.PLogoVendedor.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(189, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(919, 556)
        Me.Panel1.TabIndex = 11
        '
        'gerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 556)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.P)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximumSize = New System.Drawing.Size(1126, 603)
        Me.MinimumSize = New System.Drawing.Size(1126, 603)
        Me.Name = "gerente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerente"
        Me.P.ResumeLayout(False)
        Me.PAutores.ResumeLayout(False)
        Me.PEditoriales.ResumeLayout(False)
        Me.PClientes.ResumeLayout(False)
        Me.PVentas.ResumeLayout(False)
        Me.PLibros.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents P As Panel
    Friend WithEvents BCerrarSesion As Button
    Friend WithEvents PClientes As Panel
    Friend WithEvents BLLibros As Button
    Friend WithEvents BLibros As Button
    Friend WithEvents PVentas As Panel
    Friend WithEvents BLClientes As Button
    Friend WithEvents BClientes As Button
    Friend WithEvents PLibros As Panel
    Friend WithEvents BLVentas As Button
    Friend WithEvents BVentas As Button
    Friend WithEvents PLogoVendedor As Panel
    Friend WithEvents PEditoriales As Panel
    Friend WithEvents BLEditoriales As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PAutores As Panel
    Friend WithEvents BLAutores As Button
    Friend WithEvents BLUsuarios As Button
    Friend WithEvents BUsuarios As Button
End Class
