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
        Me.BIngresar.Location = New System.Drawing.Point(269, 359)
        Me.BIngresar.Margin = New System.Windows.Forms.Padding(4)
        Me.BIngresar.Name = "BIngresar"
        Me.BIngresar.Size = New System.Drawing.Size(100, 28)
        Me.BIngresar.TabIndex = 0
        Me.BIngresar.Text = "Ingresar"
        Me.BIngresar.UseVisualStyleBackColor = True
        '
        'BSalir
        '
        Me.BSalir.Location = New System.Drawing.Point(395, 359)
        Me.BSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(100, 28)
        Me.BSalir.TabIndex = 1
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Location = New System.Drawing.Point(268, 260)
        Me.LUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(61, 17)
        Me.LUsuario.TabIndex = 2
        Me.LUsuario.Text = "Usuario:"
        '
        'LContraseña
        '
        Me.LContraseña.AutoSize = True
        Me.LContraseña.Location = New System.Drawing.Point(268, 302)
        Me.LContraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LContraseña.Name = "LContraseña"
        Me.LContraseña.Size = New System.Drawing.Size(85, 17)
        Me.LContraseña.TabIndex = 3
        Me.LContraseña.Text = "Contraseña:"
        '
        'TBUsuario
        '
        Me.TBUsuario.Location = New System.Drawing.Point(363, 257)
        Me.TBUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.TBUsuario.Name = "TBUsuario"
        Me.TBUsuario.Size = New System.Drawing.Size(132, 22)
        Me.TBUsuario.TabIndex = 4
        '
        'TBContraseña
        '
        Me.TBContraseña.Location = New System.Drawing.Point(363, 297)
        Me.TBContraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.TBContraseña.Name = "TBContraseña"
        Me.TBContraseña.Size = New System.Drawing.Size(132, 22)
        Me.TBContraseña.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RincondeLectura.My.Resources.Resources.logopng
        Me.PictureBox1.Location = New System.Drawing.Point(181, 30)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(389, 197)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 406)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TBContraseña)
        Me.Controls.Add(Me.TBUsuario)
        Me.Controls.Add(Me.LContraseña)
        Me.Controls.Add(Me.LUsuario)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BIngresar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(767, 453)
        Me.MinimumSize = New System.Drawing.Size(767, 453)
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
