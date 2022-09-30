<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABMCliente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GBFiltrar = New System.Windows.Forms.GroupBox()
        Me.RBEliminados = New System.Windows.Forms.RadioButton()
        Me.RBActivos = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBDni = New System.Windows.Forms.TextBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
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
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBFiltrar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBMail.SuspendLayout()
        Me.GBdni.SuspendLayout()
        Me.GBTelefono.SuspendLayout()
        Me.GBDireccion.SuspendLayout()
        Me.GBNyA.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.GBFiltrar)
        Me.Panel1.Controls.Add(Me.BSalir)
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
        Me.Panel1.Size = New System.Drawing.Size(688, 457)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(32, 232)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(622, 207)
        Me.DataGridView1.TabIndex = 10
        '
        'GBFiltrar
        '
        Me.GBFiltrar.BackColor = System.Drawing.Color.Black
        Me.GBFiltrar.Controls.Add(Me.RBEliminados)
        Me.GBFiltrar.Controls.Add(Me.RBActivos)
        Me.GBFiltrar.Controls.Add(Me.GroupBox1)
        Me.GBFiltrar.Controls.Add(Me.BBuscar)
        Me.GBFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBFiltrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBFiltrar.Location = New System.Drawing.Point(32, 148)
        Me.GBFiltrar.Name = "GBFiltrar"
        Me.GBFiltrar.Size = New System.Drawing.Size(622, 77)
        Me.GBFiltrar.TabIndex = 11
        Me.GBFiltrar.TabStop = False
        Me.GBFiltrar.Text = "Filtrar Por"
        '
        'RBEliminados
        '
        Me.RBEliminados.AutoSize = True
        Me.RBEliminados.Location = New System.Drawing.Point(514, 39)
        Me.RBEliminados.Margin = New System.Windows.Forms.Padding(2)
        Me.RBEliminados.Name = "RBEliminados"
        Me.RBEliminados.Size = New System.Drawing.Size(75, 17)
        Me.RBEliminados.TabIndex = 8
        Me.RBEliminados.TabStop = True
        Me.RBEliminados.Text = "Eliminados"
        Me.RBEliminados.UseVisualStyleBackColor = True
        '
        'RBActivos
        '
        Me.RBActivos.AutoSize = True
        Me.RBActivos.Location = New System.Drawing.Point(414, 39)
        Me.RBActivos.Margin = New System.Windows.Forms.Padding(2)
        Me.RBActivos.Name = "RBActivos"
        Me.RBActivos.Size = New System.Drawing.Size(60, 17)
        Me.RBActivos.TabIndex = 7
        Me.RBActivos.TabStop = True
        Me.RBActivos.Text = "Activos"
        Me.RBActivos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TBDni)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(199, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 51)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DNI"
        '
        'TBDni
        '
        Me.TBDni.Location = New System.Drawing.Point(20, 20)
        Me.TBDni.Name = "TBDni"
        Me.TBDni.Size = New System.Drawing.Size(134, 20)
        Me.TBDni.TabIndex = 0
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.Color.Black
        Me.BBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscar.Location = New System.Drawing.Point(58, 30)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(117, 27)
        Me.BBuscar.TabIndex = 6
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'BSalir
        '
        Me.BSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BSalir.BackColor = System.Drawing.Color.Black
        Me.BSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSalir.ForeColor = System.Drawing.Color.White
        Me.BSalir.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BSalir.Location = New System.Drawing.Point(13, 13)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.BSalir.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BSalir.Size = New System.Drawing.Size(25, 26)
        Me.BSalir.TabIndex = 65
        Me.BSalir.Text = "X"
        Me.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'GBMail
        '
        Me.GBMail.BackColor = System.Drawing.Color.Transparent
        Me.GBMail.Controls.Add(Me.TxtMail)
        Me.GBMail.ForeColor = System.Drawing.SystemColors.Window
        Me.GBMail.Location = New System.Drawing.Point(253, 91)
        Me.GBMail.Name = "GBMail"
        Me.GBMail.Size = New System.Drawing.Size(159, 49)
        Me.GBMail.TabIndex = 63
        Me.GBMail.TabStop = False
        Me.GBMail.Text = "Mail"
        '
        'TxtMail
        '
        Me.TxtMail.BackColor = System.Drawing.SystemColors.Window
        Me.TxtMail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtMail.Location = New System.Drawing.Point(15, 19)
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
        Me.BModificar.Location = New System.Drawing.Point(436, 118)
        Me.BModificar.Margin = New System.Windows.Forms.Padding(0)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(159, 27)
        Me.BModificar.TabIndex = 64
        Me.BModificar.Text = "Modificar Datos"
        Me.BModificar.UseVisualStyleBackColor = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BGuardar.ForeColor = System.Drawing.Color.White
        Me.BGuardar.Location = New System.Drawing.Point(436, 88)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(159, 27)
        Me.BGuardar.TabIndex = 61
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'GBdni
        '
        Me.GBdni.BackColor = System.Drawing.Color.Transparent
        Me.GBdni.Controls.Add(Me.TxtDNI)
        Me.GBdni.ForeColor = System.Drawing.SystemColors.Window
        Me.GBdni.Location = New System.Drawing.Point(75, 28)
        Me.GBdni.Name = "GBdni"
        Me.GBdni.Size = New System.Drawing.Size(159, 49)
        Me.GBdni.TabIndex = 56
        Me.GBdni.TabStop = False
        Me.GBdni.Text = "DNI"
        '
        'TxtDNI
        '
        Me.TxtDNI.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDNI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtDNI.Location = New System.Drawing.Point(15, 18)
        Me.TxtDNI.MaxLength = 8
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(134, 20)
        Me.TxtDNI.TabIndex = 2
        '
        'GBTelefono
        '
        Me.GBTelefono.BackColor = System.Drawing.Color.Transparent
        Me.GBTelefono.Controls.Add(Me.TxtTelefono)
        Me.GBTelefono.ForeColor = System.Drawing.SystemColors.Window
        Me.GBTelefono.Location = New System.Drawing.Point(75, 91)
        Me.GBTelefono.Name = "GBTelefono"
        Me.GBTelefono.Size = New System.Drawing.Size(159, 49)
        Me.GBTelefono.TabIndex = 58
        Me.GBTelefono.TabStop = False
        Me.GBTelefono.Text = "Telefono"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtTelefono.Location = New System.Drawing.Point(15, 19)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(134, 20)
        Me.TxtTelefono.TabIndex = 3
        '
        'GBDireccion
        '
        Me.GBDireccion.BackColor = System.Drawing.Color.Transparent
        Me.GBDireccion.Controls.Add(Me.TxtDireccion)
        Me.GBDireccion.ForeColor = System.Drawing.SystemColors.Window
        Me.GBDireccion.Location = New System.Drawing.Point(436, 28)
        Me.GBDireccion.Name = "GBDireccion"
        Me.GBDireccion.Size = New System.Drawing.Size(159, 49)
        Me.GBDireccion.TabIndex = 54
        Me.GBDireccion.TabStop = False
        Me.GBDireccion.Text = "Direccion"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDireccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtDireccion.Location = New System.Drawing.Point(15, 18)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(134, 20)
        Me.TxtDireccion.TabIndex = 1
        '
        'GBNyA
        '
        Me.GBNyA.BackColor = System.Drawing.Color.Transparent
        Me.GBNyA.Controls.Add(Me.TxtNyA)
        Me.GBNyA.ForeColor = System.Drawing.SystemColors.Window
        Me.GBNyA.Location = New System.Drawing.Point(253, 28)
        Me.GBNyA.Name = "GBNyA"
        Me.GBNyA.Size = New System.Drawing.Size(159, 49)
        Me.GBNyA.TabIndex = 53
        Me.GBNyA.TabStop = False
        Me.GBNyA.Text = "Nombre y Apellido"
        '
        'TxtNyA
        '
        Me.TxtNyA.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNyA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtNyA.Location = New System.Drawing.Point(15, 18)
        Me.TxtNyA.Name = "TxtNyA"
        Me.TxtNyA.Size = New System.Drawing.Size(134, 20)
        Me.TxtNyA.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 457)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(688, 604)
        Me.Panel2.TabIndex = 1
        '
        'ABMCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 457)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(494, 196)
        Me.MaximumSize = New System.Drawing.Size(688, 457)
        Me.MinimumSize = New System.Drawing.Size(688, 457)
        Me.Name = "ABMCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBFiltrar.ResumeLayout(False)
        Me.GBFiltrar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents RBEliminados As RadioButton
    Friend WithEvents RBActivos As RadioButton
    Friend WithEvents BSalir As Button
End Class
