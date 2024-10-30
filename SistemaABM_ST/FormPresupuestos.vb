Imports System.Data.OleDb

Public Class FormPresupuestos
    Private idReparacion As Integer

    ' Constructor que recibe el id de la reparación
    Public Sub New(idReparacion As Integer)
        InitializeComponent()
        Me.idReparacion = idReparacion
    End Sub

    Private Sub FormPresupuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPresupuestos()

        ' Añadir botón de eliminar si no está ya añadido
        If DataGridViewPresupuestos.Columns("btnEliminar") Is Nothing Then
            Dim btnEliminar As New DataGridViewButtonColumn()
            btnEliminar.Name = "btnEliminar"
            btnEliminar.HeaderText = "Eliminar"
            btnEliminar.Text = "Eliminar"
            btnEliminar.UseColumnTextForButtonValue = True
            DataGridViewPresupuestos.Columns.Add(btnEliminar)
        End If

        ' Añadir botón de "Aprobar/Rechazar" si no está ya añadido
        If DataGridViewPresupuestos.Columns("btnAprobar") Is Nothing Then
            Dim btnAprobar As New DataGridViewButtonColumn()
            btnAprobar.Name = "btnAprobar"
            btnAprobar.HeaderText = "Estado de Aprobación"
            btnAprobar.Text = "Aprobar/Rechazar"
            btnAprobar.UseColumnTextForButtonValue = True
            DataGridViewPresupuestos.Columns.Add(btnAprobar)
        End If
        DataGridViewPresupuestos.Columns("id").ReadOnly = True
        DataGridViewPresupuestos.Columns("id_reparacion").Visible = False
    End Sub

    ' Método para cargar los presupuestos relacionados con la reparación
    Private Sub CargarPresupuestos()
        Dim conexionDB As New ConexionDB()
        Dim conexion As OleDbConnection = conexionDB.AbrirConexion()

        ' Consulta para seleccionar los presupuestos de la reparación
        Dim query As String = "SELECT * FROM presupuesto WHERE id_reparacion = @id_reparacion"
        Dim cmd As New OleDbCommand(query, conexion)
        cmd.Parameters.AddWithValue("@id_reparacion", idReparacion)

        Dim adapter As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()

        Try
            adapter.Fill(dt)
            DataGridViewPresupuestos.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al cargar los presupuestos: " & ex.Message)
        Finally
            conexionDB.CerrarConexion()
        End Try
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Dim frmNuevoPresupuesto As New FormNuevoPresupuesto(idReparacion)
        frmNuevoPresupuesto.ShowDialog()
        CargarPresupuestos() ' Recargar la lista de presupuestos después de añadir uno nuevo
    End Sub

    Private Sub DataGridViewPresupuestos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPresupuestos.CellContentClick
        If e.ColumnIndex = DataGridViewPresupuestos.Columns("btnEliminar").Index AndAlso e.RowIndex >= 0 Then
            Dim idPresupuesto As Integer = CInt(DataGridViewPresupuestos.Rows(e.RowIndex).Cells("id").Value)

            ' Confirmación para eliminar
            Dim result As DialogResult = MessageBox.Show("¿Seguro que deseas eliminar este presupuesto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                EliminarPresupuesto(idPresupuesto)
                CargarPresupuestos() ' Recargar datos después de eliminar
            End If
        End If

        ' Verifica si se hizo clic en la columna de "Aprobar"
        If e.ColumnIndex = DataGridViewPresupuestos.Columns("btnAprobar").Index AndAlso e.RowIndex >= 0 Then
            Dim idPresupuesto As Integer = CInt(DataGridViewPresupuestos.Rows(e.RowIndex).Cells("id").Value)
            Dim estadoActual As Boolean = CBool(DataGridViewPresupuestos.Rows(e.RowIndex).Cells("aprobado").Value)

            ' Cambiar el estado de aprobado (si está en True, cambiar a False y viceversa)
            Dim nuevoEstado As Boolean = Not estadoActual
            ActualizarEstadoAprobado(idPresupuesto, nuevoEstado)

            ' Recargar los datos después de cambiar el estado
            CargarPresupuestos()
        End If
    End Sub

    Private Sub EliminarPresupuesto(id As Integer)
        Dim conexionDB As New ConexionDB()
        Dim conexion As OleDbConnection = conexionDB.AbrirConexion()
        Dim query As String = "DELETE FROM presupuesto WHERE id = @id"

        Try
            Using cmd As New OleDbCommand(query, conexion)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Presupuesto eliminado correctamente.")
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el presupuesto: " & ex.Message)
        Finally
            conexionDB.CerrarConexion()
        End Try
    End Sub

    Private Sub ActualizarEstadoAprobado(idPresupuesto As Integer, estadoAprobado As Boolean)
        Dim conexionDB As New ConexionDB()
        Dim conexion As OleDbConnection = conexionDB.AbrirConexion()
        Dim query As String = "UPDATE presupuesto SET aprobado = @estadoAprobado WHERE Id = @idPresupuesto"

        Try
            Using cmd As New OleDbCommand(query, conexion)
                cmd.Parameters.AddWithValue("@estadoAprobado", estadoAprobado)
                cmd.Parameters.AddWithValue("@idPresupuesto", idPresupuesto)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("El estado de aprobación ha sido actualizado.")
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el estado de aprobación: " & ex.Message)
        Finally
            conexionDB.CerrarConexion()
        End Try
    End Sub

    Private Sub btn_atras_Click(sender As Object, e As EventArgs) Handles btn_atras.Click
        FormReparaciones.Show()
        Me.Close()
    End Sub


End Class
