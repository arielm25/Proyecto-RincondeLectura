
Public Class InicioSesion
    Private Sub BIngresar_Click(sender As Object, e As EventArgs) Handles BIngresar.Click
        If (TBUsuario.Text = "vendedor" And TBContraseña.Text = "vendedor") Then
            vendedor.Show()
            Hide()
        ElseIf (TBUsuario.Text = "gerente" And TBContraseña.Text = "gerente") Then
            gerente.Show()
            Hide()
        ElseIf (TBUsuario.Text = "admin" And TBContraseña.Text = "admin") Then
            administrador.Show()
            vendedor.Show()
            Hide()
        ElseIf (TBUsuario.Text = "gerente" And TBContraseña.Text = "gerente") Then
            gerente.Show()
            Hide()
        ElseIf (TBUsuario.Text = "admin" And TBContraseña.Text = "admin") Then
            administrador.Show()
            Hide()
        End If
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub
End Class
