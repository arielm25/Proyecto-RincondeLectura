<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FNGenero
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.GBTituloGenero = New System.Windows.Forms.GroupBox()
        Me.TxtTituloGenero = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GBTituloGenero.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.BAgregar)
        Me.Panel1.Controls.Add(Me.GBTituloGenero)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(506, 235)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button2.Location = New System.Drawing.Point(292, 140)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 27)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BAgregar
        '
        Me.BAgregar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BAgregar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.BAgregar.Location = New System.Drawing.Point(292, 93)
        Me.BAgregar.Margin = New System.Windows.Forms.Padding(0)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(117, 27)
        Me.BAgregar.TabIndex = 35
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.UseVisualStyleBackColor = False
        '
        'GBTituloGenero
        '
        Me.GBTituloGenero.BackColor = System.Drawing.Color.Transparent
        Me.GBTituloGenero.Controls.Add(Me.TxtTituloGenero)
        Me.GBTituloGenero.ForeColor = System.Drawing.SystemColors.Window
        Me.GBTituloGenero.Location = New System.Drawing.Point(94, 93)
        Me.GBTituloGenero.Name = "GBTituloGenero"
        Me.GBTituloGenero.Size = New System.Drawing.Size(167, 57)
        Me.GBTituloGenero.TabIndex = 37
        Me.GBTituloGenero.TabStop = False
        Me.GBTituloGenero.Text = "Titulo del Genero"
        '
        'TxtTituloGenero
        '
        Me.TxtTituloGenero.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTituloGenero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtTituloGenero.Location = New System.Drawing.Point(22, 21)
        Me.TxtTituloGenero.Name = "TxtTituloGenero"
        Me.TxtTituloGenero.Size = New System.Drawing.Size(134, 20)
        Me.TxtTituloGenero.TabIndex = 0
        '
        'FNGenero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 235)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FNGenero"
        Me.Text = "Nuevo Genero"
        Me.Panel1.ResumeLayout(False)
        Me.GBTituloGenero.ResumeLayout(False)
        Me.GBTituloGenero.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents BAgregar As Button
    Friend WithEvents GBTituloGenero As GroupBox
    Friend WithEvents TxtTituloGenero As TextBox
End Class
