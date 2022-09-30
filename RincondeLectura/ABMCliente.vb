Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class ABMCliente

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Using conexion As New SqlConnection("Data Source=DESKTOP-RE6RPNF\SQLEXPRESS01;Initial Catalog=dbRincondeLectura;Integrated Security=True")
            Dim consultaSql As String = "SELECT COUNT(*) FROM cliente WHERE (dniCli=@dniCli)"
            Dim comd As New SqlCommand(consultaSql, conexion)
            comd.Parameters.AddWithValue("@dniCli", TxtDNI.Text)
            conexion.Open()
            Dim Existe As Boolean = Convert.ToInt32(comd.ExecuteScalar) > 0

            If (TxtDNI.Text = "") Or (TxtNyA.Text = "") Or (TxtTelefono.Text = "") Or (TxtDireccion.Text = "") Or (TxtMail.Text = "") Then
                MsgBox("Debe completar todos los campos", 0 + 0 + 64, "Alerta")
            Else
                If Existe Then
                    MsgBox("El dni ingresado ya existe", vbCritical, "Error")
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
                            TxtDNI.Clear()
                            TxtNyA.Clear()
                            TxtDireccion.Clear()
                            TxtTelefono.Clear()
                            TxtMail.Clear()
                        Catch ex As Exception : MsgBox(ex.Message)

                        End Try

                    End If
                End If
            End If
        End Using
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("lista_clientes", conexion)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            cerrar()
        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub
    Sub consultaDinamica(ByVal dni As String, ByVal dgv As DataGridView)
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("Select * from Cliente where dnicli like '" & dni + "%" & "'", conexion)
            dt = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TBDni_TextChanged(sender As Object, e As EventArgs) Handles TBDni.TextChanged
        consultaDinamica(TBDni.Text, DataGridView1)
    End Sub

    Public Function Modificar(dnicli As String, nomyape As String, telefono As String, direccion As String, mail As String) As Integer
        Dim act As New SqlCommand("pb_modificar", conexion)
        act.CommandType = CommandType.StoredProcedure
        act.Parameters.AddWithValue("@dnicli", dnicli)
        act.Parameters.AddWithValue("@nomyape", nomyape)
        act.Parameters.AddWithValue("@telefono", telefono)
        act.Parameters.AddWithValue("@direccion", direccion)
        act.Parameters.AddWithValue("@mail", mail)
        abrir()
        Dim actu1 As String = act.ExecuteNonQuery
        cerrar()
        Return actu1
    End Function

    Private Sub BModificar_Click(sender As Object, e As EventArgs) Handles BModificar.Click
        Try
            Modificar(TxtDNI.Text, TxtNyA.Text, TxtTelefono.Text, TxtDireccion.Text, TxtMail.Text)
            MsgBox("Se modifico al cliente con DNI: " + TxtDNI.Text)

            TxtNyA.Text = ""
            TxtTelefono.Text = ""
            TxtDireccion.Text = ""
            TxtMail.Text = ""


        Catch ex As Exception
            MsgBox("404 Error al modificar ")
        End Try
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub TxtDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDNI.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TBDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDni.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtNyA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNyA.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class