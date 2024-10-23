Imports System.Data.OleDb

Public Class FormUsuarios

    Private Sub btn_atras_Click(sender As Object, e As EventArgs) Handles btn_atras.Click

        FormDashboard.Show()
        Me.Close()

    End Sub

    Private Sub btn_new_user_Click(sender As Object, e As EventArgs) Handles btn_new_user.Click

        FrmRegistro.Show()
        Me.Close()

    End Sub


    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Crear conexión a la base de datos
        Dim conexionDB As New ConexionDB()
        Dim conexion As OleDbConnection = conexionDB.AbrirConexion()

        ' Crear consulta SQL para seleccionar todas las reparaciones
        Dim query As String = "SELECT * FROM usuarios"
        Dim cmd As New OleDbCommand(query, conexion)

        ' Crear un adaptador para llenar el DataGridView
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()

        Try
            ' Llenar el DataTable con los datos de la consulta
            adapter.Fill(dt)
            ' Asignar el DataTable al DataGridView para mostrar los datos
            DataGridUsers.DataSource = dt

            ' Permitir la edición de las celdas en el DataGridView
            DataGridUsers.ReadOnly = False

        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        Finally
            conexionDB.CerrarConexion()
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        ' Crear conexión a la base de datos
        Dim conexionDB As New ConexionDB()
        Dim conexion As OleDbConnection = conexionDB.AbrirConexion()

        ' Crear el DataAdapter con la consulta de selección
        Dim query As String = "SELECT * FROM usuarios"
        Dim cmd As New OleDbCommand(query, conexion)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim builder As New OleDbCommandBuilder(adapter)

        ' Obtener los cambios realizados en el DataGridView
        Dim dt As DataTable = CType(DataGridUsers.DataSource, DataTable)

        Try
            ' Guardar los cambios en la base de datos
            adapter.Update(dt)
            MessageBox.Show("Los cambios han sido guardados exitosamente.")
            Me.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error al guardar los cambios: " & ex.Message)
        Finally
            conexionDB.CerrarConexion()
        End Try
    End Sub

End Class