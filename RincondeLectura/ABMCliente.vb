Imports System.Data.SqlClient
Public Class ABMCliente

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If (TxtDNI.Text = "") Or (TxtNyA.Text = "") Or (TxtTelefono.Text = "") Or (TxtDireccion.Text = "") Or (TxtMail.Text = "") Then
            MsgBox("Debe completar todos los campos", 0 + 0 + 64, "Alerta")
        Else
            Dim result As MsgBoxResult
            result = MsgBox("¿Desea terminar y registrar el nuevo cliente?", 4 + 256 + 32, "Confirmación")

            If result = vbYes Then
                Try
                    Dim cmd As New SqlCommand
                    abrir()
                    cmd = New SqlCommand("pa_clientes_insertar", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@dnicli", TxtDNI.Text)
                    cmd.Parameters.AddWithValue("@nomyape", TxtNyA.Text)
                    cmd.Parameters.AddWithValue("@telefono", TxtTelefono.Text)
                    cmd.Parameters.AddWithValue("@direccion", TxtDireccion.Text)
                    cmd.Parameters.AddWithValue("@mail", TxtMail.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("Cliente registrado", MsgBoxStyle.OkOnly)
                    cerrar()

                Catch ex As Exception : MsgBox(ex.Message)

                End Try

            End If
        End If

    End Sub

    Private Sub BModificar_Click(sender As Object, e As EventArgs) Handles BModificar.Click

    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click

    End Sub
End Class