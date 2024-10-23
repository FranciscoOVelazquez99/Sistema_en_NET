Imports System.Data.OleDb
Public Class FrmRegistro
    Private Sub Load_rols(sender As Object, e As EventArgs) Handles MyBase.Load
        list_rol.Items.Add("ADMIN")
        list_rol.Items.Add("Técnico")
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        Dim conexionDB As New ConexionDB()
        Dim conexion As OleDbConnection = conexionDB.AbrirConexion()

        Dim query As String = "INSERT INTO usuarios (usuario, contraseña, rol) VALUES (?, ?, ?)"
        Dim cmd As New OleDbCommand(query, conexion)

        cmd.Parameters.AddWithValue("usuario", input_nombre.Text)
        cmd.Parameters.AddWithValue("contraseña", input_contraseña.Text)
        cmd.Parameters.AddWithValue("rol", list_rol.SelectedItem)


        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Reparación agregada exitosamente.")
        Catch ex As Exception
            MessageBox.Show("Error al agregar reparación: " & ex.Message)
        Finally
            conexionDB.CerrarConexion()
        End Try
    End Sub

    Private Sub btn_atras_Click(sender As Object, e As EventArgs) Handles btn_atras.Click
        FormUsuarios.Show()
        Me.Close()
    End Sub
End Class