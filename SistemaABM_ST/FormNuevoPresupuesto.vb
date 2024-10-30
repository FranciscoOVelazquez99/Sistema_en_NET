Imports System.Data.OleDb

Public Class FormNuevoPresupuesto
    Private idReparacion As Integer

    ' Constructor que recibe el id de la reparación
    Public Sub New(idReparacion As Integer)
        InitializeComponent()
        Me.idReparacion = idReparacion
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click
        Dim conexionDB As New ConexionDB()
        Dim conexion As OleDbConnection = conexionDB.AbrirConexion()

        ' Consulta para insertar un nuevo presupuesto
        Dim query As String = "INSERT INTO presupuesto (id_reparacion, tipo, descripcion, unidades, precio, total, aprobado) " &
                              "VALUES (@id_reparacion, @tipo, @descripcion, @unidades, @precio, @total, @aprobado)"
        Dim cmd As New OleDbCommand(query, conexion)
        cmd.Parameters.AddWithValue("@id_reparacion", idReparacion)
        cmd.Parameters.AddWithValue("@tipo", txtTipo.Text)
        cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text)
        cmd.Parameters.AddWithValue("@unidades", CInt(txtUnidades.Text))
        cmd.Parameters.AddWithValue("@precio", CDbl(txtPrecio.Text))
        cmd.Parameters.AddWithValue("@total", CDbl(txtUnidades.Text) * CDbl(txtPrecio.Text))
        cmd.Parameters.AddWithValue("@aprobado", chkAprobado.Checked)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Presupuesto añadido correctamente.")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error al añadir el presupuesto: " & ex.Message)
        Finally
            conexionDB.CerrarConexion()
        End Try
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub

End Class
