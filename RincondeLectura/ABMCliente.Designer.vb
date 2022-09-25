<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMCliente
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GBMail = New System.Windows.Forms.GroupBox()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.GBdni = New System.Windows.Forms.GroupBox()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.GBTelefono = New System.Windows.Forms.GroupBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.GBDireccion = New System.Windows.Forms.GroupBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.GBNyA = New System.Windows.Forms.GroupBox()
        Me.TxtNyA = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.GBFiltrar = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBDni = New System.Windows.Forms.TextBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GBMail.SuspendLayout()
        Me.GBdni.SuspendLayout()
        Me.GBTelefono.SuspendLayout()
        Me.GBDireccion.SuspendLayout()
        Me.GBNyA.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GBFiltrar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.GBMail)
        Me.Panel1.Controls.Add(Me.BModificar)
        Me.Panel1.Controls.Add(Me.BGuardar)
        Me.Panel1.Controls.Add(Me.GBdni)
        Me.Panel1.Controls.Add(Me.GBTelefono)
        Me.Panel1.Controls.Add(Me.GBDireccion)
        Me.Panel1.Controls.Add(Me.GBNyA)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(725, 153)
        Me.Panel1.TabIndex = 0
        '
        'GBMail
        '
        Me.GBMail.BackColor = System.Drawing.Color.Transparent
        Me.GBMail.Controls.Add(Me.TxtMail)
        Me.GBMail.ForeColor = System.Drawing.SystemColors.Window
        Me.GBMail.Location = New System.Drawing.Point(186, 85)
        Me.GBMail.Name = "GBMail"
        Me.GBMail.Size = New System.Drawing.Size(159, 57)
        Me.GBMail.TabIndex = 63
        Me.GBMail.TabStop = False
        Me.GBMail.Text = "Mail"
        '
        'TxtMail
        '
        Me.TxtMail.BackColor = System.Drawing.SystemColors.Window
        Me.TxtMail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtMail.Location = New System.Drawing.Point(17, 21)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(134, 20)
        Me.TxtMail.TabIndex = 3
        '
        'BModificar
        '
        Me.BModificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BModificar.CausesValidation = False
        Me.BModificar.ForeColor = System.Drawing.Color.White
        Me.BModificar.Location = New System.Drawing.Point(471, 99)
        Me.BModificar.Margin = New System.Windows.Forms.Padding(0)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(134, 27)
        Me.BModificar.TabIndex = 64
        Me.BModificar.Text = "Modificar Datos"
        Me.BModificar.UseVisualStyleBackColor = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BGuardar.ForeColor = System.Drawing.Color.White
        Me.BGuardar.Location = New System.Drawing.Point(351, 99)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(117, 27)
        Me.BGuardar.TabIndex = 61
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'GBdni
        '
        Me.GBdni.BackColor = System.Drawing.Color.Transparent
        Me.GBdni.Controls.Add(Me.TxtDNI)
        Me.GBdni.ForeColor = System.Drawing.SystemColors.Window
        Me.GBdni.Location = New System.Drawing.Point(21, 22)
        Me.GBdni.Name = "GBdni"
        Me.GBdni.Size = New System.Drawing.Size(159, 57)
        Me.GBdni.TabIndex = 56
        Me.GBdni.TabStop = False
        Me.GBdni.Text = "DNI"
        '
        'TxtDNI
        '
        Me.TxtDNI.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDNI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtDNI.Location = New System.Drawing.Point(18, 21)
        Me.TxtDNI.MaxLength = 8
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(133, 20)
        Me.TxtDNI.TabIndex = 2
        '
        'GBTelefono
        '
        Me.GBTelefono.BackColor = System.Drawing.Color.Transparent
        Me.GBTelefono.Controls.Add(Me.TxtTelefono)
        Me.GBTelefono.ForeColor = System.Drawing.SystemColors.Window
        Me.GBTelefono.Location = New System.Drawing.Point(21, 85)
        Me.GBTelefono.Name = "GBTelefono"
        Me.GBTelefono.Size = New System.Drawing.Size(159, 57)
        Me.GBTelefono.TabIndex = 58
        Me.GBTelefono.TabStop = False
        Me.GBTelefono.Text = "Telefono"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtTelefono.Location = New System.Drawing.Point(17, 21)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(134, 20)
        Me.TxtTelefono.TabIndex = 3
        '
        'GBDireccion
        '
        Me.GBDireccion.BackColor = System.Drawing.Color.Transparent
        Me.GBDireccion.Controls.Add(Me.TxtDireccion)
        Me.GBDireccion.ForeColor = System.Drawing.SystemColors.Window
        Me.GBDireccion.Location = New System.Drawing.Point(351, 22)
        Me.GBDireccion.Name = "GBDireccion"
        Me.GBDireccion.Size = New System.Drawing.Size(167, 57)
        Me.GBDireccion.TabIndex = 54
        Me.GBDireccion.TabStop = False
        Me.GBDireccion.Text = "Direccion"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDireccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtDireccion.Location = New System.Drawing.Point(18, 21)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(134, 20)
        Me.TxtDireccion.TabIndex = 1
        '
        'GBNyA
        '
        Me.GBNyA.BackColor = System.Drawing.Color.Transparent
        Me.GBNyA.Controls.Add(Me.TxtNyA)
        Me.GBNyA.ForeColor = System.Drawing.SystemColors.Window
        Me.GBNyA.Location = New System.Drawing.Point(186, 22)
        Me.GBNyA.Name = "GBNyA"
        Me.GBNyA.Size = New System.Drawing.Size(159, 57)
        Me.GBNyA.TabIndex = 53
        Me.GBNyA.TabStop = False
        Me.GBNyA.Text = "Nombre y Apellido"
        '
        'TxtNyA
        '
        Me.TxtNyA.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNyA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtNyA.Location = New System.Drawing.Point(17, 21)
        Me.TxtNyA.Name = "TxtNyA"
        Me.TxtNyA.Size = New System.Drawing.Size(134, 20)
        Me.TxtNyA.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.BEliminar)
        Me.Panel2.Controls.Add(Me.GBFiltrar)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 153)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(725, 604)
        Me.Panel2.TabIndex = 1
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BEliminar.CausesValidation = False
        Me.BEliminar.ForeColor = System.Drawing.Color.White
        Me.BEliminar.Location = New System.Drawing.Point(351, 38)
        Me.BEliminar.Margin = New System.Windows.Forms.Padding(0)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(134, 27)
        Me.BEliminar.TabIndex = 69
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = False
        '
        'GBFiltrar
        '
        Me.GBFiltrar.BackColor = System.Drawing.Color.Black
        Me.GBFiltrar.Controls.Add(Me.GroupBox1)
        Me.GBFiltrar.Controls.Add(Me.BBuscar)
        Me.GBFiltrar.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBFiltrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBFiltrar.Location = New System.Drawing.Point(10, 144)
        Me.GBFiltrar.Name = "GBFiltrar"
        Me.GBFiltrar.Size = New System.Drawing.Size(719, 86)
        Me.GBFiltrar.TabIndex = 11
        Me.GBFiltrar.TabStop = False
        Me.GBFiltrar.Text = "Filtrar Por"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TBDni)
        Me.GroupBox1.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(144, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 51)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DNI"
        '
        'TBDni
        '
        Me.TBDni.Location = New System.Drawing.Point(6, 21)
        Me.TBDni.Name = "TBDni"
        Me.TBDni.Size = New System.Drawing.Size(153, 22)
        Me.TBDni.TabIndex = 0
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.Color.Black
        Me.BBuscar.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscar.Location = New System.Drawing.Point(16, 36)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(117, 27)
        Me.BBuscar.TabIndex = 6
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 236)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(719, 217)
        Me.DataGridView1.TabIndex = 10
        '
        'ABMCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 618)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ABMCliente"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.GBMail.ResumeLayout(False)
        Me.GBMail.PerformLayout()
        Me.GBdni.ResumeLayout(False)
        Me.GBdni.PerformLayout()
        Me.GBTelefono.ResumeLayout(False)
        Me.GBTelefono.PerformLayout()
        Me.GBDireccion.ResumeLayout(False)
        Me.GBDireccion.PerformLayout()
        Me.GBNyA.ResumeLayout(False)
        Me.GBNyA.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GBFiltrar.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BGuardar As Button
    Friend WithEvents GBdni As GroupBox
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents GBTelefono As GroupBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents GBDireccion As GroupBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents GBNyA As GroupBox
    Friend WithEvents TxtNyA As TextBox
    Friend WithEvents GBMail As GroupBox
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BModificar As Button
    Friend WithEvents GBFiltrar As GroupBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TBDni As TextBox
    Friend WithEvents BEliminar As Button
End Class
