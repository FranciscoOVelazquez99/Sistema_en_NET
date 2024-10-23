Imports System.Data.OleDb

Public Class FrmLogin
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim conexionDB As New ConexionDB()
        Dim conexion As OleDbConnection = conexionDB.AbrirConexion()

        Dim query As String = "SELECT usuario, contraseña, rol FROM usuarios WHERE usuario = ? AND contraseña = ?"
        Dim cmd As New OleDbCommand(query, conexion)
        cmd.Parameters.AddWithValue("usuario", input_usuario.Text)
        cmd.Parameters.AddWithValue("contraseña", input_contraseña.Text)

        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            ' Usuario y contraseña correctos
            UsuarioSesion.UsuarioLogueado = reader("usuario").ToString()
            UsuarioSesion.RolUsuario = reader("rol").ToString()

            MessageBox.Show("Bienvenido, " & UsuarioSesion.UsuarioLogueado & " (" & UsuarioSesion.RolUsuario & ")")

            ' Abrir el formulario principal
            Dim frmPrincipal As New FormDashboard()
            frmPrincipal.Show()
            Me.Hide() ' Ocultar el formulario de login
        Else
            MessageBox.Show("Usuario o contraseña incorrectos.")
        End If

        conexionDB.CerrarConexion()
    End Sub

End Class
