<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FNAutor
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtBAutor = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtApe = New System.Windows.Forms.TextBox()
        Me.GBTitulo = New System.Windows.Forms.GroupBox()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.PBAvatar = New System.Windows.Forms.PictureBox()
        Me.BExaminar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBTitulo.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PBAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GBTitulo)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TxtBAutor)
        Me.GroupBox2.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox2.Location = New System.Drawing.Point(164, 217)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(236, 114)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bibliografia"
        '
        'TxtBAutor
        '
        Me.TxtBAutor.BackColor = System.Drawing.SystemColors.Window
        Me.TxtBAutor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtBAutor.Location = New System.Drawing.Point(18, 21)
        Me.TxtBAutor.Multiline = True
        Me.TxtBAutor.Name = "TxtBAutor"
        Me.TxtBAutor.Size = New System.Drawing.Size(202, 79)
        Me.TxtBAutor.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtApe)
        Me.GroupBox1.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(178, 154)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 57)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Apellido"
        '
        'TxtApe
        '
        Me.TxtApe.BackColor = System.Drawing.SystemColors.Window
        Me.TxtApe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtApe.Location = New System.Drawing.Point(18, 21)
        Me.TxtApe.Name = "TxtApe"
        Me.TxtApe.Size = New System.Drawing.Size(170, 22)
        Me.TxtApe.TabIndex = 1
        '
        'GBTitulo
        '
        Me.GBTitulo.BackColor = System.Drawing.Color.Transparent
        Me.GBTitulo.Controls.Add(Me.TxtNom)
        Me.GBTitulo.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBTitulo.ForeColor = System.Drawing.SystemColors.Window
        Me.GBTitulo.Location = New System.Drawing.Point(178, 80)
        Me.GBTitulo.Name = "GBTitulo"
        Me.GBTitulo.Size = New System.Drawing.Size(206, 57)
        Me.GBTitulo.TabIndex = 50
        Me.GBTitulo.TabStop = False
        Me.GBTitulo.Text = "Nombre"
        '
        'TxtNom
        '
        Me.TxtNom.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtNom.Location = New System.Drawing.Point(17, 21)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(171, 22)
        Me.TxtNom.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Window
        Me.Button3.Location = New System.Drawing.Point(456, 344)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 27)
        Me.Button3.TabIndex = 48
        Me.Button3.Text = "Guardar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Window
        Me.Button2.Location = New System.Drawing.Point(267, 344)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 27)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.PBAvatar)
        Me.GroupBox6.Controls.Add(Me.BExaminar)
        Me.GroupBox6.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox6.Location = New System.Drawing.Point(429, 80)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(207, 251)
        Me.GroupBox6.TabIndex = 52
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Foto del Autor"
        '
        'PBAvatar
        '
        Me.PBAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBAvatar.Location = New System.Drawing.Point(27, 31)
        Me.PBAvatar.Name = "PBAvatar"
        Me.PBAvatar.Size = New System.Drawing.Size(157, 163)
        Me.PBAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBAvatar.TabIndex = 16
        Me.PBAvatar.TabStop = False
        '
        'BExaminar
        '
        Me.BExaminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BExaminar.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BExaminar.Location = New System.Drawing.Point(46, 210)
        Me.BExaminar.Margin = New System.Windows.Forms.Padding(0)
        Me.BExaminar.Name = "BExaminar"
        Me.BExaminar.Size = New System.Drawing.Size(117, 27)
        Me.BExaminar.TabIndex = 3
        Me.BExaminar.Text = "Examinar"
        Me.BExaminar.UseVisualStyleBackColor = False
        '
        'FNAutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FNAutor"
        Me.Text = "Nuevo Autor"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBTitulo.ResumeLayout(False)
        Me.GBTitulo.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.PBAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtBAutor As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtApe As TextBox
    Friend WithEvents GBTitulo As GroupBox
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents PBAvatar As PictureBox
    Friend WithEvents BExaminar As Button
End Class
