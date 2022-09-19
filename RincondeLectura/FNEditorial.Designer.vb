<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FNEditorial
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
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtCorreoEdi = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtTelefEdi = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtDireEdi = New System.Windows.Forms.TextBox()
        Me.GBTitulo = New System.Windows.Forms.GroupBox()
        Me.TxtNombreEdi = New System.Windows.Forms.TextBox()
        Me.GBSinopsis = New System.Windows.Forms.GroupBox()
        Me.TxtDescEdi = New System.Windows.Forms.TextBox()
        Me.GBPortada = New System.Windows.Forms.GroupBox()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.BExaminar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBTitulo.SuspendLayout()
        Me.GBSinopsis.SuspendLayout()
        Me.GBPortada.SuspendLayout()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.BCancelar)
        Me.Panel1.Controls.Add(Me.BGuardar)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GBTitulo)
        Me.Panel1.Controls.Add(Me.GBSinopsis)
        Me.Panel1.Controls.Add(Me.GBPortada)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 0
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BCancelar.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelar.ForeColor = System.Drawing.SystemColors.Window
        Me.BCancelar.Location = New System.Drawing.Point(144, 378)
        Me.BCancelar.Margin = New System.Windows.Forms.Padding(0)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(117, 27)
        Me.BCancelar.TabIndex = 49
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BGuardar.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGuardar.ForeColor = System.Drawing.SystemColors.Window
        Me.BGuardar.Location = New System.Drawing.Point(278, 378)
        Me.BGuardar.Margin = New System.Windows.Forms.Padding(0)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(117, 27)
        Me.BGuardar.TabIndex = 48
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TxtCorreoEdi)
        Me.GroupBox2.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox2.Location = New System.Drawing.Point(167, 282)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(167, 57)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Correo"
        '
        'TxtCorreoEdi
        '
        Me.TxtCorreoEdi.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCorreoEdi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtCorreoEdi.Location = New System.Drawing.Point(22, 21)
        Me.TxtCorreoEdi.Name = "TxtCorreoEdi"
        Me.TxtCorreoEdi.Size = New System.Drawing.Size(134, 22)
        Me.TxtCorreoEdi.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TxtTelefEdi)
        Me.GroupBox3.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox3.Location = New System.Drawing.Point(167, 203)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(167, 57)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Telefono"
        '
        'TxtTelefEdi
        '
        Me.TxtTelefEdi.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTelefEdi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtTelefEdi.Location = New System.Drawing.Point(22, 21)
        Me.TxtTelefEdi.Name = "TxtTelefEdi"
        Me.TxtTelefEdi.Size = New System.Drawing.Size(134, 22)
        Me.TxtTelefEdi.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtDireEdi)
        Me.GroupBox1.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(167, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(167, 57)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Direccion"
        '
        'TxtDireEdi
        '
        Me.TxtDireEdi.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDireEdi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtDireEdi.Location = New System.Drawing.Point(22, 21)
        Me.TxtDireEdi.Name = "TxtDireEdi"
        Me.TxtDireEdi.Size = New System.Drawing.Size(134, 22)
        Me.TxtDireEdi.TabIndex = 1
        '
        'GBTitulo
        '
        Me.GBTitulo.BackColor = System.Drawing.Color.Transparent
        Me.GBTitulo.Controls.Add(Me.TxtNombreEdi)
        Me.GBTitulo.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBTitulo.ForeColor = System.Drawing.SystemColors.Window
        Me.GBTitulo.Location = New System.Drawing.Point(167, 46)
        Me.GBTitulo.Name = "GBTitulo"
        Me.GBTitulo.Size = New System.Drawing.Size(167, 57)
        Me.GBTitulo.TabIndex = 50
        Me.GBTitulo.TabStop = False
        Me.GBTitulo.Text = "Nombre"
        '
        'TxtNombreEdi
        '
        Me.TxtNombreEdi.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNombreEdi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtNombreEdi.Location = New System.Drawing.Point(22, 21)
        Me.TxtNombreEdi.Name = "TxtNombreEdi"
        Me.TxtNombreEdi.Size = New System.Drawing.Size(134, 22)
        Me.TxtNombreEdi.TabIndex = 0
        '
        'GBSinopsis
        '
        Me.GBSinopsis.BackColor = System.Drawing.Color.Transparent
        Me.GBSinopsis.Controls.Add(Me.TxtDescEdi)
        Me.GBSinopsis.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBSinopsis.ForeColor = System.Drawing.SystemColors.Window
        Me.GBSinopsis.Location = New System.Drawing.Point(366, 46)
        Me.GBSinopsis.Name = "GBSinopsis"
        Me.GBSinopsis.Size = New System.Drawing.Size(290, 151)
        Me.GBSinopsis.TabIndex = 51
        Me.GBSinopsis.TabStop = False
        Me.GBSinopsis.Text = "Descripcion"
        '
        'TxtDescEdi
        '
        Me.TxtDescEdi.Location = New System.Drawing.Point(19, 25)
        Me.TxtDescEdi.Multiline = True
        Me.TxtDescEdi.Name = "TxtDescEdi"
        Me.TxtDescEdi.Size = New System.Drawing.Size(246, 102)
        Me.TxtDescEdi.TabIndex = 4
        '
        'GBPortada
        '
        Me.GBPortada.BackColor = System.Drawing.Color.Transparent
        Me.GBPortada.Controls.Add(Me.PBLogo)
        Me.GBPortada.Controls.Add(Me.BExaminar)
        Me.GBPortada.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBPortada.ForeColor = System.Drawing.SystemColors.Window
        Me.GBPortada.Location = New System.Drawing.Point(408, 203)
        Me.GBPortada.Name = "GBPortada"
        Me.GBPortada.Size = New System.Drawing.Size(196, 198)
        Me.GBPortada.TabIndex = 52
        Me.GBPortada.TabStop = False
        Me.GBPortada.Text = "Logo"
        '
        'PBLogo
        '
        Me.PBLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBLogo.Location = New System.Drawing.Point(21, 21)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(150, 128)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 16
        Me.PBLogo.TabStop = False
        '
        'BExaminar
        '
        Me.BExaminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BExaminar.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BExaminar.Location = New System.Drawing.Point(34, 158)
        Me.BExaminar.Margin = New System.Windows.Forms.Padding(0)
        Me.BExaminar.Name = "BExaminar"
        Me.BExaminar.Size = New System.Drawing.Size(117, 27)
        Me.BExaminar.TabIndex = 5
        Me.BExaminar.Text = "Examinar"
        Me.BExaminar.UseVisualStyleBackColor = False
        '
        'FNEditorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FNEditorial"
        Me.Text = "Nuevo Editorial"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBTitulo.ResumeLayout(False)
        Me.GBTitulo.PerformLayout()
        Me.GBSinopsis.ResumeLayout(False)
        Me.GBSinopsis.PerformLayout()
        Me.GBPortada.ResumeLayout(False)
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BCancelar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtCorreoEdi As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtTelefEdi As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtDireEdi As TextBox
    Friend WithEvents GBTitulo As GroupBox
    Friend WithEvents TxtNombreEdi As TextBox
    Friend WithEvents GBSinopsis As GroupBox
    Friend WithEvents TxtDescEdi As TextBox
    Friend WithEvents GBPortada As GroupBox
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents BExaminar As Button
End Class
