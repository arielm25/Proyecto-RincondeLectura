<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FVentas
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
        Me.BSalir = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.LTotal2 = New System.Windows.Forms.Label()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.Cantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        CType(Me.Cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox17.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.BSalir)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.GroupBox8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(688, 457)
        Me.Panel1.TabIndex = 0
        '
        'BSalir
        '
        Me.BSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BSalir.BackColor = System.Drawing.Color.Black
        Me.BSalir.Font = New System.Drawing.Font("Doppio One", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSalir.ForeColor = System.Drawing.Color.White
        Me.BSalir.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BSalir.Location = New System.Drawing.Point(13, 13)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.BSalir.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BSalir.Size = New System.Drawing.Size(25, 26)
        Me.BSalir.TabIndex = 66
        Me.BSalir.Text = "X"
        Me.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Window
        Me.Button3.Location = New System.Drawing.Point(425, 401)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 22)
        Me.Button3.TabIndex = 55
        Me.Button3.Text = "Realizar Venta"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Window
        Me.Button2.Location = New System.Drawing.Point(164, 400)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 22)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.ListView1)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.GroupBox9)
        Me.GroupBox5.Controls.Add(Me.GroupBox10)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox5.Location = New System.Drawing.Point(339, 20)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(255, 367)
        Me.GroupBox5.TabIndex = 54
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Compra"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(70, 362)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = " "
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(8, 16)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(235, 150)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 338)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 20)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Total: $"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.GroupBox14)
        Me.GroupBox9.Controls.Add(Me.GroupBox13)
        Me.GroupBox9.Controls.Add(Me.GroupBox12)
        Me.GroupBox9.Controls.Add(Me.GroupBox11)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox9.Location = New System.Drawing.Point(7, 221)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox9.Size = New System.Drawing.Size(241, 106)
        Me.GroupBox9.TabIndex = 1
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Datos de la Tarjeta"
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.TextBox6)
        Me.GroupBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox14.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox14.Location = New System.Drawing.Point(122, 59)
        Me.GroupBox14.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox14.Size = New System.Drawing.Size(112, 39)
        Me.GroupBox14.TabIndex = 5
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Codigo"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(4, 14)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox6.MaxLength = 3
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(102, 20)
        Me.TextBox6.TabIndex = 12
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.TextBox5)
        Me.GroupBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox13.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox13.Location = New System.Drawing.Point(6, 59)
        Me.GroupBox13.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox13.Size = New System.Drawing.Size(112, 39)
        Me.GroupBox13.TabIndex = 4
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Fecha de venc"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(4, 14)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(102, 20)
        Me.TextBox5.TabIndex = 11
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.TextBox8)
        Me.GroupBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox12.Location = New System.Drawing.Point(122, 16)
        Me.GroupBox12.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox12.Size = New System.Drawing.Size(112, 39)
        Me.GroupBox12.TabIndex = 2
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Numero"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(4, 14)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox8.MaxLength = 15
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(102, 20)
        Me.TextBox8.TabIndex = 10
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.ComboBox2)
        Me.GroupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox11.Location = New System.Drawing.Point(6, 17)
        Me.GroupBox11.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox11.Size = New System.Drawing.Size(112, 39)
        Me.GroupBox11.TabIndex = 1
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Banco"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Naranja", "Banelco", "Master Card", "Makro", "Cabal", "Visa", "Santander Rio", "Galicia", "Credicop", "Hipotecario", "HSBC", "Patagonia", "Mercado Pago"})
        Me.ComboBox2.Location = New System.Drawing.Point(4, 12)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(102, 21)
        Me.ComboBox2.TabIndex = 9
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.RadioButton2)
        Me.GroupBox10.Controls.Add(Me.RadioButton1)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox10.Location = New System.Drawing.Point(30, 178)
        Me.GroupBox10.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox10.Size = New System.Drawing.Size(194, 37)
        Me.GroupBox10.TabIndex = 4
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Metodo de Pago"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(86, 13)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(109, 17)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.Text = "Tarjeta de Credito"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(13, 13)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(64, 17)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Efectivo"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox8.Controls.Add(Me.LTotal2)
        Me.GroupBox8.Controls.Add(Me.GroupBox15)
        Me.GroupBox8.Controls.Add(Me.GroupBox16)
        Me.GroupBox8.Controls.Add(Me.Label10)
        Me.GroupBox8.Controls.Add(Me.Button1)
        Me.GroupBox8.Controls.Add(Me.GroupBox17)
        Me.GroupBox8.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox8.Location = New System.Drawing.Point(86, 20)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox8.Size = New System.Drawing.Size(240, 367)
        Me.GroupBox8.TabIndex = 53
        Me.GroupBox8.TabStop = False
        '
        'LTotal2
        '
        Me.LTotal2.AutoSize = True
        Me.LTotal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotal2.Location = New System.Drawing.Point(99, 365)
        Me.LTotal2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LTotal2.Name = "LTotal2"
        Me.LTotal2.Size = New System.Drawing.Size(10, 13)
        Me.LTotal2.TabIndex = 12
        Me.LTotal2.Text = " "
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.TextBox1)
        Me.GroupBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox15.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox15.Location = New System.Drawing.Point(15, 86)
        Me.GroupBox15.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox15.Size = New System.Drawing.Size(214, 46)
        Me.GroupBox15.TabIndex = 1
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "ISBN Libro"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 18)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(184, 20)
        Me.TextBox1.TabIndex = 7
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.Cantidad)
        Me.GroupBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox16.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox16.Location = New System.Drawing.Point(15, 153)
        Me.GroupBox16.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox16.Size = New System.Drawing.Size(84, 42)
        Me.GroupBox16.TabIndex = 2
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Cantidad"
        '
        'Cantidad
        '
        Me.Cantidad.BackColor = System.Drawing.SystemColors.Window
        Me.Cantidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Cantidad.Location = New System.Drawing.Point(11, 16)
        Me.Cantidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Cantidad.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(61, 20)
        Me.Cantidad.TabIndex = 32
        Me.Cantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 223)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 20)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Subtotal: $"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(125, 169)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 22)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.TextBox7)
        Me.GroupBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox17.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox17.Location = New System.Drawing.Point(15, 23)
        Me.GroupBox17.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox17.Size = New System.Drawing.Size(214, 46)
        Me.GroupBox17.TabIndex = 4
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "DNI Cliente"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(15, 18)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(184, 20)
        Me.TextBox7.TabIndex = 6
        '
        'FVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 457)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(494, 196)
        Me.MaximumSize = New System.Drawing.Size(688, 457)
        Me.MinimumSize = New System.Drawing.Size(688, 457)
        Me.Name = "FVentas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Realizar Ventas"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        CType(Me.Cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents LTotal2 As Label
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents Cantidad As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BSalir As Button
End Class
