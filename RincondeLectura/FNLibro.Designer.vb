<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FNLibro
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.GBStock = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBGenero = New System.Windows.Forms.ComboBox()
        Me.GBEditorial = New System.Windows.Forms.GroupBox()
        Me.CBEditorial = New System.Windows.Forms.ComboBox()
        Me.GBTitulo = New System.Windows.Forms.GroupBox()
        Me.TxtTitulo = New System.Windows.Forms.TextBox()
        Me.GBISBN = New System.Windows.Forms.GroupBox()
        Me.RBISBN13 = New System.Windows.Forms.RadioButton()
        Me.RBISBN10 = New System.Windows.Forms.RadioButton()
        Me.TxtISBN = New System.Windows.Forms.TextBox()
        Me.GBAutor = New System.Windows.Forms.GroupBox()
        Me.CBAutor = New System.Windows.Forms.ComboBox()
        Me.GBSinopsis = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GBPrecio = New System.Windows.Forms.GroupBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.GBPortada = New System.Windows.Forms.GroupBox()
        Me.BExaminar = New System.Windows.Forms.Button()
        Me.PBAvatar = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBStock.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GBEditorial.SuspendLayout()
        Me.GBTitulo.SuspendLayout()
        Me.GBISBN.SuspendLayout()
        Me.GBAutor.SuspendLayout()
        Me.GBSinopsis.SuspendLayout()
        Me.GBPrecio.SuspendLayout()
        Me.GBPortada.SuspendLayout()
        CType(Me.PBAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GBStock)
        Me.Panel1.Controls.Add(Me.BGuardar)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GBEditorial)
        Me.Panel1.Controls.Add(Me.GBTitulo)
        Me.Panel1.Controls.Add(Me.GBISBN)
        Me.Panel1.Controls.Add(Me.GBAutor)
        Me.Panel1.Controls.Add(Me.GBSinopsis)
        Me.Panel1.Controls.Add(Me.GBPrecio)
        Me.Panel1.Controls.Add(Me.GBPortada)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.NumericUpDown3)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox3.Location = New System.Drawing.Point(341, 225)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(117, 51)
        Me.GroupBox3.TabIndex = 53
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Stock Minimo"
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.BackColor = System.Drawing.SystemColors.Window
        Me.NumericUpDown3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.NumericUpDown3.Location = New System.Drawing.Point(19, 17)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.NumericUpDown3.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(85, 20)
        Me.NumericUpDown3.TabIndex = 31
        Me.NumericUpDown3.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'GBStock
        '
        Me.GBStock.BackColor = System.Drawing.Color.Transparent
        Me.GBStock.Controls.Add(Me.NumericUpDown2)
        Me.GBStock.ForeColor = System.Drawing.SystemColors.Window
        Me.GBStock.Location = New System.Drawing.Point(341, 282)
        Me.GBStock.Name = "GBStock"
        Me.GBStock.Size = New System.Drawing.Size(117, 43)
        Me.GBStock.TabIndex = 52
        Me.GBStock.TabStop = False
        Me.GBStock.Text = "Stock"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.BackColor = System.Drawing.SystemColors.Window
        Me.NumericUpDown2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.NumericUpDown2.Location = New System.Drawing.Point(19, 15)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(85, 20)
        Me.NumericUpDown2.TabIndex = 31
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BGuardar.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGuardar.ForeColor = System.Drawing.SystemColors.Window
        Me.BGuardar.Location = New System.Drawing.Point(405, 406)
        Me.BGuardar.Margin = New System.Windows.Forms.Padding(0)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(117, 27)
        Me.BGuardar.TabIndex = 41
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Window
        Me.Button2.Location = New System.Drawing.Point(224, 406)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 27)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox2.Location = New System.Drawing.Point(341, 331)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(117, 59)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Año de Edicion"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.SystemColors.Window
        Me.NumericUpDown1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.NumericUpDown1.Location = New System.Drawing.Point(19, 21)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1700, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(85, 20)
        Me.NumericUpDown1.TabIndex = 26
        Me.NumericUpDown1.Value = New Decimal(New Integer() {2020, 0, 0, 0})
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CBGenero)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(134, 253)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(167, 59)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Genero"
        '
        'CBGenero
        '
        Me.CBGenero.BackColor = System.Drawing.SystemColors.Window
        Me.CBGenero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CBGenero.FormattingEnabled = True
        Me.CBGenero.Items.AddRange(New Object() {"Romance", "Comedia", "Misterio- Terror", "Policial", "Ciencia Ficcion", "Paranormal", "Distopica", "Poesia", "Teatro", "Fantasia", "Gotica", "Mitologia"})
        Me.CBGenero.Location = New System.Drawing.Point(21, 21)
        Me.CBGenero.Name = "CBGenero"
        Me.CBGenero.Size = New System.Drawing.Size(131, 21)
        Me.CBGenero.TabIndex = 25
        '
        'GBEditorial
        '
        Me.GBEditorial.BackColor = System.Drawing.Color.Transparent
        Me.GBEditorial.Controls.Add(Me.CBEditorial)
        Me.GBEditorial.ForeColor = System.Drawing.SystemColors.Window
        Me.GBEditorial.Location = New System.Drawing.Point(134, 332)
        Me.GBEditorial.Name = "GBEditorial"
        Me.GBEditorial.Size = New System.Drawing.Size(167, 59)
        Me.GBEditorial.TabIndex = 47
        Me.GBEditorial.TabStop = False
        Me.GBEditorial.Text = "Editorial"
        '
        'CBEditorial
        '
        Me.CBEditorial.BackColor = System.Drawing.SystemColors.Window
        Me.CBEditorial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CBEditorial.FormattingEnabled = True
        Me.CBEditorial.Items.AddRange(New Object() {"Montena", "Javier Vergara", "Duomo", "Planeta", "Alba", "Aleguara", "Ivrea", "B de Bolsillo", "Blok", "El Ateneo", "Trakatra", "Emece", "Bloomsbury Publishing"})
        Me.CBEditorial.Location = New System.Drawing.Point(20, 21)
        Me.CBEditorial.Name = "CBEditorial"
        Me.CBEditorial.Size = New System.Drawing.Size(132, 21)
        Me.CBEditorial.TabIndex = 24
        '
        'GBTitulo
        '
        Me.GBTitulo.BackColor = System.Drawing.Color.Transparent
        Me.GBTitulo.Controls.Add(Me.TxtTitulo)
        Me.GBTitulo.ForeColor = System.Drawing.SystemColors.Window
        Me.GBTitulo.Location = New System.Drawing.Point(134, 102)
        Me.GBTitulo.Name = "GBTitulo"
        Me.GBTitulo.Size = New System.Drawing.Size(167, 57)
        Me.GBTitulo.TabIndex = 44
        Me.GBTitulo.TabStop = False
        Me.GBTitulo.Text = "Titulo"
        '
        'TxtTitulo
        '
        Me.TxtTitulo.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtTitulo.Location = New System.Drawing.Point(22, 21)
        Me.TxtTitulo.Name = "TxtTitulo"
        Me.TxtTitulo.Size = New System.Drawing.Size(134, 20)
        Me.TxtTitulo.TabIndex = 1
        '
        'GBISBN
        '
        Me.GBISBN.BackColor = System.Drawing.Color.Transparent
        Me.GBISBN.Controls.Add(Me.RBISBN13)
        Me.GBISBN.Controls.Add(Me.RBISBN10)
        Me.GBISBN.Controls.Add(Me.TxtISBN)
        Me.GBISBN.ForeColor = System.Drawing.SystemColors.Window
        Me.GBISBN.Location = New System.Drawing.Point(133, 18)
        Me.GBISBN.Name = "GBISBN"
        Me.GBISBN.Size = New System.Drawing.Size(168, 72)
        Me.GBISBN.TabIndex = 43
        Me.GBISBN.TabStop = False
        Me.GBISBN.Text = "ISBN"
        '
        'RBISBN13
        '
        Me.RBISBN13.AutoSize = True
        Me.RBISBN13.Location = New System.Drawing.Point(91, 17)
        Me.RBISBN13.Name = "RBISBN13"
        Me.RBISBN13.Size = New System.Drawing.Size(65, 17)
        Me.RBISBN13.TabIndex = 21
        Me.RBISBN13.TabStop = True
        Me.RBISBN13.Text = "ISBN 13"
        Me.RBISBN13.UseVisualStyleBackColor = True
        '
        'RBISBN10
        '
        Me.RBISBN10.AutoSize = True
        Me.RBISBN10.Location = New System.Drawing.Point(9, 17)
        Me.RBISBN10.Name = "RBISBN10"
        Me.RBISBN10.Size = New System.Drawing.Size(65, 17)
        Me.RBISBN10.TabIndex = 20
        Me.RBISBN10.TabStop = True
        Me.RBISBN10.Text = "ISBN 10"
        Me.RBISBN10.UseVisualStyleBackColor = True
        '
        'TxtISBN
        '
        Me.TxtISBN.BackColor = System.Drawing.SystemColors.Window
        Me.TxtISBN.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtISBN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtISBN.Location = New System.Drawing.Point(23, 39)
        Me.TxtISBN.Name = "TxtISBN"
        Me.TxtISBN.Size = New System.Drawing.Size(134, 22)
        Me.TxtISBN.TabIndex = 0
        '
        'GBAutor
        '
        Me.GBAutor.BackColor = System.Drawing.Color.Transparent
        Me.GBAutor.Controls.Add(Me.CBAutor)
        Me.GBAutor.ForeColor = System.Drawing.SystemColors.Window
        Me.GBAutor.Location = New System.Drawing.Point(134, 176)
        Me.GBAutor.Name = "GBAutor"
        Me.GBAutor.Size = New System.Drawing.Size(167, 59)
        Me.GBAutor.TabIndex = 46
        Me.GBAutor.TabStop = False
        Me.GBAutor.Text = "Autor"
        '
        'CBAutor
        '
        Me.CBAutor.BackColor = System.Drawing.SystemColors.Window
        Me.CBAutor.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBAutor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CBAutor.FormattingEnabled = True
        Me.CBAutor.Items.AddRange(New Object() {"Jhon Katzenbach", "Sebastian Fitzek", "Stephenie Meyer", "Cassandra Claire", "Carolyn Jess-Cooke", "J. K. Rowling", "R. R. Tolkien", "Agatha Christie"})
        Me.CBAutor.Location = New System.Drawing.Point(22, 21)
        Me.CBAutor.Name = "CBAutor"
        Me.CBAutor.Size = New System.Drawing.Size(132, 22)
        Me.CBAutor.TabIndex = 23
        '
        'GBSinopsis
        '
        Me.GBSinopsis.BackColor = System.Drawing.Color.Transparent
        Me.GBSinopsis.Controls.Add(Me.TextBox1)
        Me.GBSinopsis.ForeColor = System.Drawing.SystemColors.Window
        Me.GBSinopsis.Location = New System.Drawing.Point(341, 18)
        Me.GBSinopsis.Name = "GBSinopsis"
        Me.GBSinopsis.Size = New System.Drawing.Size(326, 151)
        Me.GBSinopsis.TabIndex = 45
        Me.GBSinopsis.TabStop = False
        Me.GBSinopsis.Text = "Sinopsis"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(19, 25)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(283, 102)
        Me.TextBox1.TabIndex = 2
        '
        'GBPrecio
        '
        Me.GBPrecio.BackColor = System.Drawing.Color.Transparent
        Me.GBPrecio.Controls.Add(Me.TxtPrecio)
        Me.GBPrecio.ForeColor = System.Drawing.SystemColors.Window
        Me.GBPrecio.Location = New System.Drawing.Point(341, 175)
        Me.GBPrecio.Name = "GBPrecio"
        Me.GBPrecio.Size = New System.Drawing.Size(117, 44)
        Me.GBPrecio.TabIndex = 51
        Me.GBPrecio.TabStop = False
        Me.GBPrecio.Text = "Precio"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPrecio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtPrecio.Location = New System.Drawing.Point(19, 16)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(85, 20)
        Me.TxtPrecio.TabIndex = 3
        '
        'GBPortada
        '
        Me.GBPortada.BackColor = System.Drawing.Color.Transparent
        Me.GBPortada.Controls.Add(Me.PBAvatar)
        Me.GBPortada.Controls.Add(Me.BExaminar)
        Me.GBPortada.ForeColor = System.Drawing.SystemColors.Window
        Me.GBPortada.Location = New System.Drawing.Point(488, 185)
        Me.GBPortada.Name = "GBPortada"
        Me.GBPortada.Size = New System.Drawing.Size(167, 218)
        Me.GBPortada.TabIndex = 48
        Me.GBPortada.TabStop = False
        Me.GBPortada.Text = "Portada"
        '
        'BExaminar
        '
        Me.BExaminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BExaminar.Location = New System.Drawing.Point(25, 183)
        Me.BExaminar.Margin = New System.Windows.Forms.Padding(0)
        Me.BExaminar.Name = "BExaminar"
        Me.BExaminar.Size = New System.Drawing.Size(117, 27)
        Me.BExaminar.TabIndex = 4
        Me.BExaminar.Text = "Examinar"
        Me.BExaminar.UseVisualStyleBackColor = False
        '
        'PBAvatar
        '
        Me.PBAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBAvatar.Location = New System.Drawing.Point(30, 21)
        Me.PBAvatar.Name = "PBAvatar"
        Me.PBAvatar.Size = New System.Drawing.Size(110, 155)
        Me.PBAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBAvatar.TabIndex = 16
        Me.PBAvatar.TabStop = False
        '
        'FNLibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FNLibro"
        Me.Text = "Nuevo Libro"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBStock.ResumeLayout(False)
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GBEditorial.ResumeLayout(False)
        Me.GBTitulo.ResumeLayout(False)
        Me.GBTitulo.PerformLayout()
        Me.GBISBN.ResumeLayout(False)
        Me.GBISBN.PerformLayout()
        Me.GBAutor.ResumeLayout(False)
        Me.GBSinopsis.ResumeLayout(False)
        Me.GBSinopsis.PerformLayout()
        Me.GBPrecio.ResumeLayout(False)
        Me.GBPrecio.PerformLayout()
        Me.GBPortada.ResumeLayout(False)
        CType(Me.PBAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents GBStock As GroupBox
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents BGuardar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBGenero As ComboBox
    Friend WithEvents GBEditorial As GroupBox
    Friend WithEvents CBEditorial As ComboBox
    Friend WithEvents GBTitulo As GroupBox
    Friend WithEvents TxtTitulo As TextBox
    Friend WithEvents GBISBN As GroupBox
    Friend WithEvents RBISBN13 As RadioButton
    Friend WithEvents RBISBN10 As RadioButton
    Friend WithEvents TxtISBN As TextBox
    Friend WithEvents GBAutor As GroupBox
    Friend WithEvents CBAutor As ComboBox
    Friend WithEvents GBSinopsis As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GBPrecio As GroupBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents GBPortada As GroupBox
    Friend WithEvents PBAvatar As PictureBox
    Friend WithEvents BExaminar As Button
End Class
