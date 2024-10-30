Imports System.Data.OleDb

Public Class FormDetalleReparacion

    Public Property ReparacionID As Integer

    Public Function ObtenerReparacionPorID(id As Integer) As DataTable
        Dim dt As New DataTable()
        Dim conexionDB As New ConexionDB()
        Dim conexion As OleDbConnection = conexionDB.AbrirConexion()

        Dim query As String = "SELECT * FROM reparaciones WHERE id = @id"

        Try
            Using cmd As New OleDbCommand(query, conexion)
                cmd.Parameters.AddWithValue("@id", id)
                Dim adapter As New OleDbDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener los datos: " & ex.Message)
        Finally
            conexionDB.CerrarConexion()
        End Try

        Return dt
    End Function

    Public Sub CargarDatos(id As Integer)
        ReparacionID = id
        Dim dt As DataTable = ObtenerReparacionPorID(id)

        If dt.Rows.Count > 0 Then
            input_cliente.Text = dt.Rows(0)("cliente").ToString()
            input_dni.Text = dt.Rows(0)("DNI").ToString()
            input_contacto.Text = dt.Rows(0)("contacto").ToString()
            ListBoxUsuarios.SelectedItem = dt.Rows(0)("tecnico_asignado").ToString()
            input_descripcion.Text = dt.Rows(0)("descripcion_problema").ToString()
        Else
            MessageBox.Show("No se encontraron datos para este ID.")
        End If
    End Sub

    Private Sub FormDetalleReparacion_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexionDB As New ConexionDB()
        Dim conexion As OleDbConnection = conexionDB.AbrirConexion()

        combox_estado.Items.Add("Pendiente")
        combox_estado.Items.Add("En Proceso")
        combox_estado.Items.Add("Completada")

        Dim query As String = "SELECT usuario FROM usuarios"
        Dim cmd As New OleDbCommand(query, conexion)

        Try
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                ListBoxUsuarios.Items.Add(reader("usuario").ToString())
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al obtener usuarios: " & ex.Message)
        Finally
            conexionDB.CerrarConexion()
        End Try
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Dim conexionDB As New ConexionDB()
        Dim conexion As OleDbConnection = conexionDB.AbrirConexion()

        Dim query As String = "UPDATE Reparaciones SET cliente = ?, DNI = ?, contacto = ?, descripcion_problema = ?"

        If ListBoxUsuarios.SelectedItem IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(ListBoxUsuarios.SelectedItem.ToString()) Then
            query &= ", tecnico_asignado = ?"
        End If

        If combox_estado.SelectedItem IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(combox_estado.SelectedItem.ToString()) Then
            query &= ", estado_reparacion = ?"
        End If

        ' Validar si el CheckBox para cambiar la fecha está marcado
        If chkCambiarFechaSalida.Checked Then
            query &= ", fecha_salida = ?"
        End If

        query &= " WHERE id = ?"
        Dim cmd As New OleDbCommand(query, conexion)

        ' Configurar los parámetros comunes
        cmd.Parameters.Add("cliente", OleDbType.VarChar).Value = input_cliente.Text
        cmd.Parameters.Add("DNI", OleDbType.Integer).Value = Convert.ToInt32(input_dni.Text)
        cmd.Parameters.Add("contacto", OleDbType.VarChar).Value = input_contacto.Text
        cmd.Parameters.Add("descripcion_problema", OleDbType.VarChar).Value = input_descripcion.Text

        If ListBoxUsuarios.SelectedItem IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(ListBoxUsuarios.SelectedItem.ToString()) Then
            cmd.Parameters.Add("tecnico_asignado", OleDbType.VarChar).Value = ListBoxUsuarios.SelectedItem.ToString()
        End If

        If combox_estado.SelectedItem IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(combox_estado.SelectedItem.ToString()) Then
            cmd.Parameters.Add("estado_reparacion", OleDbType.VarChar).Value = combox_estado.SelectedItem.ToString()
        End If

        ' Solo añadir la fecha si el CheckBox está marcado
        If chkCambiarFechaSalida.Checked Then
            cmd.Parameters.Add("fecha_salida", OleDbType.Date).Value = datePickerFechaSalida.Value.Date
        End If

        cmd.Parameters.Add("id", OleDbType.Integer).Value = Me.ReparacionID

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Reparación actualizada exitosamente.")
            FormReparaciones.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error al actualizar reparación: " & ex.Message)
        Finally
            conexionDB.CerrarConexion()
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        FormReparaciones.Show()
        FormReparaciones.Refresh()
        Me.Close()
    End Sub

End Class
