
Public Class InicioSesion
    Private Sub BIngresar_Click() Handles BIngresar.Click
        If (TBUsuario.Text = "vendedor" And TBContraseña.Text = "vendedor") Then
            vendedor.Show()
            Hide()
        ElseIf (TBUsuario.Text = "gerente" And TBContraseña.Text = "gerente") Then
            gerente.Show()
            Hide()
        ElseIf (TBUsuario.Text = "admin" And TBContraseña.Text = "admin") Then
            administrador.Show()
            Hide()
        Else
            MsgBox("Usuario o contraseña incorrectos", 0 + 0 + 64, "Atencion")
        End If
        TBUsuario.Text = ""
        TBContraseña.Text = ""
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub TBContraseña_TextChanged(sender As Object, e As EventArgs) Handles TBContraseña.TextChanged
        TBContraseña.PasswordChar = "*"
    End Sub

    Private Sub InicioSesion_Show(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.TBUsuario.Focus()
    End Sub

    Private Sub TBUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles TBUsuario.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Me.TBContraseña.Focus()
        End If
    End Sub

    Private Sub TBContraseña_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TBContraseña.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            BIngresar_Click()
        End If
    End Sub

End Class
