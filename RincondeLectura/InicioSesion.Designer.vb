<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicioSesion))
        Me.BIngresar = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.LContraseña = New System.Windows.Forms.Label()
        Me.TBUsuario = New System.Windows.Forms.TextBox()
        Me.TBContraseña = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BIngresar
        '
        Me.BIngresar.Location = New System.Drawing.Point(202, 292)
        Me.BIngresar.Name = "BIngresar"
        Me.BIngresar.Size = New System.Drawing.Size(75, 23)
        Me.BIngresar.TabIndex = 0
        Me.BIngresar.Text = "Ingresar"
        Me.BIngresar.UseVisualStyleBackColor = True
        '
        'BSalir
        '
        Me.BSalir.Location = New System.Drawing.Point(296, 292)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(75, 23)
        Me.BSalir.TabIndex = 1
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Location = New System.Drawing.Point(201, 211)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(46, 13)
        Me.LUsuario.TabIndex = 2
        Me.LUsuario.Text = "Usuario:"
        '
        'LContraseña
        '
        Me.LContraseña.AutoSize = True
        Me.LContraseña.Location = New System.Drawing.Point(201, 245)
        Me.LContraseña.Name = "LContraseña"
        Me.LContraseña.Size = New System.Drawing.Size(64, 13)
        Me.LContraseña.TabIndex = 3
        Me.LContraseña.Text = "Contraseña:"
        '
        'TBUsuario
        '
        Me.TBUsuario.Location = New System.Drawing.Point(272, 209)
        Me.TBUsuario.Name = "TBUsuario"
        Me.TBUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TBUsuario.TabIndex = 4
        '
        'TBContraseña
        '
        Me.TBContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBContraseña.Location = New System.Drawing.Point(272, 241)
        Me.TBContraseña.Name = "TBContraseña"
        Me.TBContraseña.Size = New System.Drawing.Size(100, 23)
        Me.TBContraseña.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RincondeLectura.My.Resources.Resources.logopng
        Me.PictureBox1.Location = New System.Drawing.Point(136, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(292, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 336)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TBContraseña)
        Me.Controls.Add(Me.TBUsuario)
        Me.Controls.Add(Me.LContraseña)
        Me.Controls.Add(Me.LUsuario)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BIngresar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(579, 375)
        Me.MinimumSize = New System.Drawing.Size(579, 375)
        Me.Name = "InicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BIngresar As Button
    Friend WithEvents BSalir As Button
    Friend WithEvents LUsuario As Label
    Friend WithEvents LContraseña As Label
    Friend WithEvents TBUsuario As TextBox
    Friend WithEvents TBContraseña As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
