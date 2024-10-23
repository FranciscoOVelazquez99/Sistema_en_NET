Imports System.Data.OleDb
Public Class FormReparaciones

    Private Sub FrmReparaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Crear conexión a la base de datos
        Dim conexionDB As New ConexionDB()
        Dim conexion As OleDbConnection = conexionDB.AbrirConexion()

        ' Crear consulta SQL para seleccionar todas las reparaciones
        Dim query As String = "SELECT id, cliente, descripcion_problema, tecnico_asignado, estado_reparacion, fecha_ingreso, fecha_salida FROM reparaciones ORDER BY estado_reparacion asc"
        Dim cmd As New OleDbCommand(query, conexion)

        ' Crear un adaptador para llenar el DataGridView
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()

        Try
            ' Llenar el DataTable con los datos de la consulta
            adapter.Fill(dt)
            ' Asignar el DataTable al DataGridView para mostrar los datos
            DataGridViewReparaciones.DataSource = dt

            ' Hacer que la columna ID no sea editable
            DataGridViewReparaciones.Columns("id").ReadOnly = True

            ' Ocultar la columna original de estado_reparacion para reemplazarla con el ComboBox
            DataGridViewReparaciones.Columns("estado_reparacion").Visible = False

            ' Agregar la columna personalizada para el estado de reparación
            Dim comboEstado As New DataGridViewComboBoxColumn()
            comboEstado.HeaderText = "Estado de Reparación"
            comboEstado.DataPropertyName = "estado_reparacion" ' Campo de la BD
            comboEstado.Items.AddRange("Completada", "Pendiente") ' Opciones disponibles
            DataGridViewReparaciones.Columns.Insert(4, comboEstado)

            ' Agregar la columna personalizada para la fecha de ingreso
            Dim dateColumn As New DataGridViewCalendarColumn()
            dateColumn.HeaderText = "Fecha de Ingreso"
            dateColumn.DataPropertyName = "fecha_ingreso" ' Campo de la BD
            DataGridViewReparaciones.Columns.Insert(5, dateColumn)

            ' Ocultar la columna original de fecha_ingreso
            DataGridViewReparaciones.Columns("fecha_ingreso").Visible = False

            ' Agregar la columna personalizada para la fecha de salida
            Dim dateColumnSalida As New DataGridViewCalendarColumn()
            dateColumnSalida.HeaderText = "Fecha de Salida"
            dateColumnSalida.DataPropertyName = "fecha_salida" ' Campo de la BD
            DataGridViewReparaciones.Columns.Insert(6, dateColumnSalida)

            ' Ocultar la columna original de fecha_salida
            DataGridViewReparaciones.Columns("fecha_salida").Visible = False

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
        Dim query As String = "SELECT id, cliente, descripcion_problema, tecnico_asignado, estado_reparacion, fecha_ingreso, fecha_salida FROM reparaciones"
        Dim cmd As New OleDbCommand(query, conexion)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim builder As New OleDbCommandBuilder(adapter)

        ' Obtener los cambios realizados en el DataGridView
        Dim dt As DataTable = CType(DataGridViewReparaciones.DataSource, DataTable)

        Try
            ' Guardar los cambios en la base de datos
            adapter.Update(dt)
            MessageBox.Show("Los cambios han sido guardados exitosamente.")
        Catch ex As Exception
            MessageBox.Show("Error al guardar los cambios: " & ex.Message)
        Finally
            conexionDB.CerrarConexion()
        End Try
    End Sub

    Private Sub btn_atras_Click(sender As Object, e As EventArgs) Handles btn_atras.Click
        FormDashboard.Show()
        Me.Close()
    End Sub

End Class