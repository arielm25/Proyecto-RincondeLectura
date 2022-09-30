<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FBackup
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TRuta = New System.Windows.Forms.TextBox()
        Me.BExaminar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(245, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Seleccione una carpeta"
        '
        'TRuta
        '
        Me.TRuta.Location = New System.Drawing.Point(248, 235)
        Me.TRuta.Name = "TRuta"
        Me.TRuta.Size = New System.Drawing.Size(300, 22)
        Me.TRuta.TabIndex = 14
        '
        'BExaminar
        '
        Me.BExaminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BExaminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BExaminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BExaminar.Location = New System.Drawing.Point(566, 230)
        Me.BExaminar.Name = "BExaminar"
        Me.BExaminar.Size = New System.Drawing.Size(117, 27)
        Me.BExaminar.TabIndex = 13
        Me.BExaminar.Text = "Examinar"
        Me.BExaminar.UseVisualStyleBackColor = False
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BCancelar.Location = New System.Drawing.Point(349, 292)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(117, 27)
        Me.BCancelar.TabIndex = 12
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BGuardar.Location = New System.Drawing.Point(485, 292)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(117, 27)
        Me.BGuardar.TabIndex = 11
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'BSalir
        '
        Me.BSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BSalir.BackColor = System.Drawing.Color.Black
        Me.BSalir.Font = New System.Drawing.Font("Doppio One", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSalir.ForeColor = System.Drawing.Color.White
        Me.BSalir.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BSalir.Location = New System.Drawing.Point(13, 13)
        Me.BSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.BSalir.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BSalir.Size = New System.Drawing.Size(33, 32)
        Me.BSalir.TabIndex = 67
        Me.BSalir.Text = "X"
        Me.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'FBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(917, 562)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TRuta)
        Me.Controls.Add(Me.BExaminar)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(494, 196)
        Me.Name = "FBackup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FBackup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TRuta As TextBox
    Friend WithEvents BExaminar As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents BSalir As Button
End Class
