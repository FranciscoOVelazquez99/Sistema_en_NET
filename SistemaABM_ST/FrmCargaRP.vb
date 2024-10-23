Imports System.Data.OleDb


Public Class FrmCargaRP

    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Crear conexión a la base de datos
        Dim conexionDB As New ConexionDB()
        Dim conexion As OleDbConnection = conexionDB.AbrirConexion()

        ' Crear consulta SQL
        Dim query As String = "SELECT usuario FROM usuarios"
        Dim cmd As New OleDbCommand(query, conexion)

        Try
            ' Ejecutar consulta
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            ' Leer resultados
            While reader.Read()
                ' Obtener el valor de la columna "usuario" y mostrarlo en un control (como un ListBox o un ComboBox)
                ListBoxUsuarios.Items.Add(reader("usuario").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al obtener usuarios: " & ex.Message)
        Finally
            ' Cerrar la conexión
            conexionDB.CerrarConexion()
        End Try
    End Sub

    Private Sub btn_subir_Click(sender As Object, e As EventArgs) Handles btn_subir.Click
        Dim conexionDB As New ConexionDB()
        Dim conexion As OleDbConnection = conexionDB.AbrirConexion()

        Dim query As String = "INSERT INTO Reparaciones (cliente, fecha_ingreso, descripcion_problema, tecnico_asignado, estado_reparacion) VALUES (?, ?, ?, ?, ?)"
        Dim cmd As New OleDbCommand(query, conexion)

        cmd.Parameters.Add("cliente", OleDbType.VarChar).Value = input_cliente.Text
        cmd.Parameters.Add("fecha_ingreso", OleDbType.Date).Value = Date.Now
        cmd.Parameters.Add("descripcion_problema", OleDbType.VarChar).Value = input_descripcion.Text
        cmd.Parameters.Add("tecnico_asignado", OleDbType.VarChar).Value = ListBoxUsuarios.SelectedItem
        cmd.Parameters.Add("estado_reparacion", OleDbType.VarChar).Value = "Pendiente"

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Reparación agregada exitosamente.")
            FormReparaciones.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error al agregar reparación: " & ex.Message)
        Finally
            conexionDB.CerrarConexion()
        End Try
    End Sub



    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        FormReparaciones.Show()
        Me.Close()
    End Sub
End Class