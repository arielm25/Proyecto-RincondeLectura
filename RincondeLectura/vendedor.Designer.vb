<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vendedor
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
        Me.P = New System.Windows.Forms.Panel()
        Me.BCerrarSesion = New System.Windows.Forms.Button()
        Me.PClientes = New System.Windows.Forms.Panel()
        Me.BLClientes = New System.Windows.Forms.Button()
        Me.BClientes = New System.Windows.Forms.Button()
        Me.PVentas = New System.Windows.Forms.Panel()
        Me.BRVentas = New System.Windows.Forms.Button()
        Me.BLVentas = New System.Windows.Forms.Button()
        Me.BVentas = New System.Windows.Forms.Button()
        Me.PLibros = New System.Windows.Forms.Panel()
        Me.BLEditorial = New System.Windows.Forms.Button()
        Me.BLAutores = New System.Windows.Forms.Button()
        Me.BLLibros = New System.Windows.Forms.Button()
        Me.BLibros = New System.Windows.Forms.Button()
        Me.PLogoVendedor = New System.Windows.Forms.Panel()
        Me.LVendedor = New System.Windows.Forms.Label()
        Me.PLogoVendedorAbajo = New System.Windows.Forms.Panel()
        Me.PLogoCentro = New System.Windows.Forms.Panel()
        Me.P.SuspendLayout()
        Me.PClientes.SuspendLayout()
        Me.PVentas.SuspendLayout()
        Me.PLibros.SuspendLayout()
        Me.PLogoVendedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'P
        '
        Me.P.AutoScroll = True
        Me.P.BackColor = System.Drawing.Color.White
        Me.P.Controls.Add(Me.BCerrarSesion)
        Me.P.Controls.Add(Me.PClientes)
        Me.P.Controls.Add(Me.PVentas)
        Me.P.Controls.Add(Me.PLibros)
        Me.P.Controls.Add(Me.BLibros)
        Me.P.Controls.Add(Me.PLogoVendedor)
        Me.P.Dock = System.Windows.Forms.DockStyle.Left
        Me.P.Location = New System.Drawing.Point(0, 0)
        Me.P.Name = "P"
        Me.P.Size = New System.Drawing.Size(142, 561)
        Me.P.TabIndex = 7
        '
        'BCerrarSesion
        '
        Me.BCerrarSesion.BackColor = System.Drawing.Color.Black
        Me.BCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BCerrarSesion.FlatAppearance.BorderSize = 0
        Me.BCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCerrarSesion.ForeColor = System.Drawing.SystemColors.Control
        Me.BCerrarSesion.Location = New System.Drawing.Point(0, 522)
        Me.BCerrarSesion.Name = "BCerrarSesion"
        Me.BCerrarSesion.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BCerrarSesion.Size = New System.Drawing.Size(142, 39)
        Me.BCerrarSesion.TabIndex = 36
        Me.BCerrarSesion.Text = "Cerrar Sesion"
        Me.BCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCerrarSesion.UseVisualStyleBackColor = False
        '
        'PClientes
        '
        Me.PClientes.Controls.Add(Me.BLClientes)
        Me.PClientes.Controls.Add(Me.BClientes)
        Me.PClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PClientes.Location = New System.Drawing.Point(0, 274)
        Me.PClientes.Name = "PClientes"
        Me.PClientes.Size = New System.Drawing.Size(142, 49)
        Me.PClientes.TabIndex = 13
        '
        'BLClientes
        '
        Me.BLClientes.BackColor = System.Drawing.Color.White
        Me.BLClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BLClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLClientes.Location = New System.Drawing.Point(0, 23)
        Me.BLClientes.Name = "BLClientes"
        Me.BLClientes.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BLClientes.Size = New System.Drawing.Size(142, 25)
        Me.BLClientes.TabIndex = 34
        Me.BLClientes.Text = "Listas de Clientes"
        Me.BLClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLClientes.UseVisualStyleBackColor = False
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
        Me.BClientes.Size = New System.Drawing.Size(142, 23)
        Me.BClientes.TabIndex = 35
        Me.BClientes.Text = "Clientes"
        Me.BClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BClientes.UseVisualStyleBackColor = False
        '
        'PVentas
        '
        Me.PVentas.Controls.Add(Me.BRVentas)
        Me.PVentas.Controls.Add(Me.BLVentas)
        Me.PVentas.Controls.Add(Me.BVentas)
        Me.PVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PVentas.Location = New System.Drawing.Point(0, 202)
        Me.PVentas.Name = "PVentas"
        Me.PVentas.Size = New System.Drawing.Size(142, 72)
        Me.PVentas.TabIndex = 12
        '
        'BRVentas
        '
        Me.BRVentas.BackColor = System.Drawing.Color.White
        Me.BRVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BRVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRVentas.Location = New System.Drawing.Point(0, 49)
        Me.BRVentas.Name = "BRVentas"
        Me.BRVentas.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BRVentas.Size = New System.Drawing.Size(142, 22)
        Me.BRVentas.TabIndex = 28
        Me.BRVentas.Text = "Realizar Ventas"
        Me.BRVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BRVentas.UseVisualStyleBackColor = False
        '
        'BLVentas
        '
        Me.BLVentas.BackColor = System.Drawing.Color.White
        Me.BLVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BLVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLVentas.Location = New System.Drawing.Point(0, 27)
        Me.BLVentas.Name = "BLVentas"
        Me.BLVentas.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BLVentas.Size = New System.Drawing.Size(142, 22)
        Me.BLVentas.TabIndex = 27
        Me.BLVentas.Text = "Listas de Ventas"
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
        Me.BVentas.Size = New System.Drawing.Size(142, 27)
        Me.BVentas.TabIndex = 29
        Me.BVentas.Text = "Ventas"
        Me.BVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVentas.UseVisualStyleBackColor = False
        '
        'PLibros
        '
        Me.PLibros.BackColor = System.Drawing.Color.White
        Me.PLibros.Controls.Add(Me.BLEditorial)
        Me.PLibros.Controls.Add(Me.BLAutores)
        Me.PLibros.Controls.Add(Me.BLLibros)
        Me.PLibros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PLibros.Location = New System.Drawing.Point(0, 124)
        Me.PLibros.Name = "PLibros"
        Me.PLibros.Size = New System.Drawing.Size(142, 78)
        Me.PLibros.TabIndex = 11
        '
        'BLEditorial
        '
        Me.BLEditorial.Dock = System.Windows.Forms.DockStyle.Top
        Me.BLEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLEditorial.Location = New System.Drawing.Point(0, 52)
        Me.BLEditorial.Name = "BLEditorial"
        Me.BLEditorial.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BLEditorial.Size = New System.Drawing.Size(142, 26)
        Me.BLEditorial.TabIndex = 2
        Me.BLEditorial.Text = "Listas de Editorial"
        Me.BLEditorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLEditorial.UseVisualStyleBackColor = True
        '
        'BLAutores
        '
        Me.BLAutores.Dock = System.Windows.Forms.DockStyle.Top
        Me.BLAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLAutores.Location = New System.Drawing.Point(0, 29)
        Me.BLAutores.Name = "BLAutores"
        Me.BLAutores.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BLAutores.Size = New System.Drawing.Size(142, 23)
        Me.BLAutores.TabIndex = 1
        Me.BLAutores.Text = "Listas de Autores"
        Me.BLAutores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLAutores.UseVisualStyleBackColor = True
        '
        'BLLibros
        '
        Me.BLLibros.Dock = System.Windows.Forms.DockStyle.Top
        Me.BLLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLLibros.Location = New System.Drawing.Point(0, 0)
        Me.BLLibros.Name = "BLLibros"
        Me.BLLibros.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BLLibros.Size = New System.Drawing.Size(142, 29)
        Me.BLLibros.TabIndex = 0
        Me.BLLibros.Text = "Lista de Libros"
        Me.BLLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLLibros.UseVisualStyleBackColor = True
        '
        'BLibros
        '
        Me.BLibros.BackColor = System.Drawing.Color.Silver
        Me.BLibros.Dock = System.Windows.Forms.DockStyle.Top
        Me.BLibros.FlatAppearance.BorderSize = 0
        Me.BLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLibros.Location = New System.Drawing.Point(0, 100)
        Me.BLibros.Name = "BLibros"
        Me.BLibros.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BLibros.Size = New System.Drawing.Size(142, 24)
        Me.BLibros.TabIndex = 9
        Me.BLibros.Text = "Libros"
        Me.BLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLibros.UseVisualStyleBackColor = False
        '
        'PLogoVendedor
        '
        Me.PLogoVendedor.BackColor = System.Drawing.Color.Black
        Me.PLogoVendedor.Controls.Add(Me.LVendedor)
        Me.PLogoVendedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.PLogoVendedor.Location = New System.Drawing.Point(0, 0)
        Me.PLogoVendedor.Name = "PLogoVendedor"
        Me.PLogoVendedor.Size = New System.Drawing.Size(142, 100)
        Me.PLogoVendedor.TabIndex = 8
        '
        'LVendedor
        '
        Me.LVendedor.AutoSize = True
        Me.LVendedor.BackColor = System.Drawing.Color.Black
        Me.LVendedor.ForeColor = System.Drawing.SystemColors.Control
        Me.LVendedor.Location = New System.Drawing.Point(40, 50)
        Me.LVendedor.Name = "LVendedor"
        Me.LVendedor.Size = New System.Drawing.Size(57, 13)
        Me.LVendedor.TabIndex = 0
        Me.LVendedor.Text = "Mi Usuario"
        '
        'PLogoVendedorAbajo
        '
        Me.PLogoVendedorAbajo.BackColor = System.Drawing.SystemColors.Control
        Me.PLogoVendedorAbajo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PLogoVendedorAbajo.Location = New System.Drawing.Point(142, 441)
        Me.PLogoVendedorAbajo.Name = "PLogoVendedorAbajo"
        Me.PLogoVendedorAbajo.Size = New System.Drawing.Size(792, 120)
        Me.PLogoVendedorAbajo.TabIndex = 9
        '
        'PLogoCentro
        '
        Me.PLogoCentro.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PLogoCentro.BackgroundImage = Global.RincondeLectura.My.Resources.Resources.logo
        Me.PLogoCentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PLogoCentro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PLogoCentro.Location = New System.Drawing.Point(142, 0)
        Me.PLogoCentro.Name = "PLogoCentro"
        Me.PLogoCentro.Size = New System.Drawing.Size(792, 441)
        Me.PLogoCentro.TabIndex = 10
        '
        'vendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 561)
        Me.Controls.Add(Me.PLogoCentro)
        Me.Controls.Add(Me.PLogoVendedorAbajo)
        Me.Controls.Add(Me.P)
        Me.IsMdiContainer = True
        Me.MinimumSize = New System.Drawing.Size(950, 600)
        Me.Name = "vendedor"
        Me.Text = "Libros"
        Me.P.ResumeLayout(False)
        Me.PClientes.ResumeLayout(False)
        Me.PVentas.ResumeLayout(False)
        Me.PLibros.ResumeLayout(False)
        Me.PLogoVendedor.ResumeLayout(False)
        Me.PLogoVendedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents P As Panel
    Friend WithEvents BLibros As Button
    Friend WithEvents PLogoVendedor As Panel
    Friend WithEvents PClientes As Panel
    Friend WithEvents BLClientes As Button
    Friend WithEvents BClientes As Button
    Friend WithEvents PVentas As Panel
    Friend WithEvents BRVentas As Button
    Friend WithEvents BLVentas As Button
    Friend WithEvents BVentas As Button
    Friend WithEvents PLibros As Panel
    Friend WithEvents BLEditorial As Button
    Friend WithEvents BLLibros As Button
    Friend WithEvents BCerrarSesion As Button
    Friend WithEvents BLAutores As Button
    Friend WithEvents LVendedor As Label
    Friend WithEvents PLogoVendedorAbajo As Panel
    Friend WithEvents PLogoCentro As Panel
End Class
