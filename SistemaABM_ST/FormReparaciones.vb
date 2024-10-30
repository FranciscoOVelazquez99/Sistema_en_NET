Imports System.Data.OleDb
Public Class FormReparaciones

    Private Sub FrmReparaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llamar a CargarDatos para inicializar el DataGridView con botones correctos
        CargarDatos()
    End Sub

    Private Sub CargarDatos()
        ' Crear conexión a la base de datos
        Dim conexionDB As New ConexionDB()
        Dim conexion As OleDbConnection = conexionDB.AbrirConexion()

        ' Crear consulta SQL para seleccionar todas las reparaciones
        Dim query As String = "SELECT * FROM reparaciones ORDER BY estado_reparacion ASC"
        Dim cmd As New OleDbCommand(query, conexion)

        ' Crear un adaptador para llenar el DataGridView
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()

        Try
            ' Llenar el DataTable con los datos de la consulta
            adapter.Fill(dt)
            ' Asignar el DataTable al DataGridView para mostrar los datos
            DataGridViewReparaciones.DataSource = dt

            ' Asegurarse de que sólo se agreguen las columnas de botones una vez
            If DataGridViewReparaciones.Columns("btnPresupuesto") Is Nothing Then
                ' Botón "Presupuesto"
                Dim btnPresupuesto As New DataGridViewButtonColumn()
                btnPresupuesto.Name = "btnPresupuesto"
                btnPresupuesto.HeaderText = "Presupuesto"
                btnPresupuesto.Text = "Presupuesto"
                btnPresupuesto.UseColumnTextForButtonValue = True
                DataGridViewReparaciones.Columns.Add(btnPresupuesto)
            End If

            If DataGridViewReparaciones.Columns("btnVer") Is Nothing Then
                ' Botón "Ver"
                Dim btnVer As New DataGridViewButtonColumn()
                btnVer.Name = "btnVer"
                btnVer.HeaderText = "Acciones"
                btnVer.Text = "Ver"
                btnVer.UseColumnTextForButtonValue = True
                DataGridViewReparaciones.Columns.Add(btnVer)
            End If

            If DataGridViewReparaciones.Columns("btnEliminar") Is Nothing Then
                ' Botón "Eliminar"
                Dim btnEliminar As New DataGridViewButtonColumn()
                btnEliminar.Name = "btnEliminar"
                btnEliminar.HeaderText = ""
                btnEliminar.Text = "Eliminar"
                btnEliminar.UseColumnTextForButtonValue = True
                DataGridViewReparaciones.Columns.Add(btnEliminar)
            End If

           
            ' Configuración adicional de columnas
            DataGridViewReparaciones.Columns("id").ReadOnly = True
            DataGridViewReparaciones.Columns("descripcion_problema").Visible = False

        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        Finally
            conexionDB.CerrarConexion()
        End Try
    End Sub

    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click
        FrmCargaRP.Show()
        Me.Close()
    End Sub

    Private Sub btn_reload_Click(sender As Object, e As EventArgs) Handles btn_reload.Click
        CargarDatos()
    End Sub

    Private Sub DataGridViewReparaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewReparaciones.CellContentClick
        ' Verificación para el botón "Ver"
        If e.ColumnIndex = DataGridViewReparaciones.Columns("btnVer").Index AndAlso e.RowIndex >= 0 Then
            Try
                Dim id As Integer = CInt(DataGridViewReparaciones.Rows(e.RowIndex).Cells("id").Value)
                Dim frmDetalle As New FormDetalleReparacion()
                frmDetalle.CargarDatos(id)
                frmDetalle.Show()
            Catch ex As Exception
                MessageBox.Show("Carga los datos primero.")
            End Try
        End If

        ' Verificación para el botón "Eliminar"
        If e.ColumnIndex = DataGridViewReparaciones.Columns("btnEliminar").Index AndAlso e.RowIndex >= 0 Then
            Dim id As Integer = CInt(DataGridViewReparaciones.Rows(e.RowIndex).Cells("id").Value)
            Dim result As DialogResult = MessageBox.Show("¿Seguro que deseas eliminar esta reparación?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                EliminarReparacion(id)
                CargarDatos() ' Recargar los datos después de eliminar
            End If
        End If

        ' Verificación para el botón "Presupuesto"
        If e.ColumnIndex = DataGridViewReparaciones.Columns("btnPresupuesto").Index AndAlso e.RowIndex >= 0 Then
            Dim idReparacion As Integer = CInt(DataGridViewReparaciones.Rows(e.RowIndex).Cells("id").Value)
            Dim frmPresupuestos As New FormPresupuestos(idReparacion)
            frmPresupuestos.Show()
        End If
    End Sub

    Private Sub EliminarReparacion(id As Integer)
        Dim conexionDB As New ConexionDB()
        Dim conexion As OleDbConnection = conexionDB.AbrirConexion()
        Dim query As String = "DELETE FROM reparaciones WHERE id = @id"
        Try
            Using cmd As New OleDbCommand(query, conexion)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Reparación eliminada exitosamente.")
        Catch ex As Exception
            MessageBox.Show("Error al eliminar la reparación: " & ex.Message)
        Finally
            conexionDB.CerrarConexion()
        End Try
    End Sub

    Private Sub btn_atras_Click(sender As Object, e As EventArgs) Handles btn_atras.Click
        FormDashboard.Show()
        Me.Close()
    End Sub
End Class
