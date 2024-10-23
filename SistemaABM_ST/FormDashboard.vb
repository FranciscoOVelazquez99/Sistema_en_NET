Imports System.Data.OleDb

Public Class FormDashboard

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tool_label_name.Text = UsuarioSesion.UsuarioLogueado
        ' Verificar el rol del usuario al cargar el formulario
        If UsuarioSesion.RolUsuario <> "ADMIN" Then
            tool_btn_registro.Visible = False ' Ocultar botón solo visible para ADMIN
        End If

        Dim conexionDB As New ConexionDB()
        Dim conexion As OleDbConnection = conexionDB.AbrirConexion()

        Dim query As String = "SELECT count(*) FROM reparaciones"
        Dim cmd As New OleDbCommand(query, conexion)

        Dim totalReparaciones As Integer = Convert.ToInt32(cmd.ExecuteScalar())



        query = "SELECT count(*) FROM reparaciones WHERE estado_reparacion = 'Pendiente'"

        Dim pen As New OleDbCommand(query, conexion)
        Dim totalPendientes As Integer = Convert.ToInt32(pen.ExecuteScalar())

        query = "SELECT count(*) FROM reparaciones WHERE estado_reparacion = 'Completada'"

        Dim com As New OleDbCommand(query, conexion)
        Dim totalCompletadas As Integer = Convert.ToInt32(com.ExecuteScalar())


        lbl_pendientes.Text = totalPendientes.ToString()
        lbl_completas.Text = totalCompletadas.ToString()
        lbl_total.Text = totalReparaciones.ToString()


    End Sub

    Private Sub tool_btn_registro_Click(sender As Object, e As EventArgs) Handles tool_btn_registro.Click
        FormUsuarios.Show()
        Me.Close()
    End Sub

    Private Sub tool_btn_carga_Click(sender As Object, e As EventArgs) Handles tool_btn_carga.Click
        FormReparaciones.Show()
        Me.Close()
    End Sub




End Class