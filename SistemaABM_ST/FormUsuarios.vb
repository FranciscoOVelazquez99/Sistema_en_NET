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
        grid_Load()
    End Sub

    Private Sub grid_Load()
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

            ' Añadir botón de eliminar si no está ya añadido
            If DataGridUsers.Columns("btnEliminar") Is Nothing Then
                Dim btnEliminar As New DataGridViewButtonColumn()
                btnEliminar.Name = "btnEliminar"
                btnEliminar.HeaderText = "Eliminar"
                btnEliminar.Text = "Eliminar"
                btnEliminar.UseColumnTextForButtonValue = True
                DataGridUsers.Columns.Add(btnEliminar)
            End If

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
            grid_Load()
        Catch ex As Exception
            MessageBox.Show("Error al guardar los cambios: " & ex.Message)
        Finally
            conexionDB.CerrarConexion()
        End Try
    End Sub

    Private Sub DataGridUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridUsers.CellContentClick
        If e.ColumnIndex = DataGridUsers.Columns("btnEliminar").Index AndAlso e.RowIndex >= 0 Then
            Dim idPresupuesto As Integer = CInt(DataGridUsers.Rows(e.RowIndex).Cells("id").Value)

            ' Confirmación para eliminar
            Dim result As DialogResult = MessageBox.Show("¿Seguro que deseas eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                EliminarUsuarip(idPresupuesto)
                grid_Load()
            End If
        End If
    End Sub

    Private Sub EliminarUsuarip(id As Integer)
        Dim conexionDB As New ConexionDB()
        Dim conexion As OleDbConnection = conexionDB.AbrirConexion()
        Dim query As String = "DELETE FROM usuarios WHERE id = @id"

        Try
            Using cmd As New OleDbCommand(query, conexion)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Usuario eliminado correctamente.")
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el presupuesto: " & ex.Message)
        Finally
            conexionDB.CerrarConexion()
        End Try
    End Sub


End Class