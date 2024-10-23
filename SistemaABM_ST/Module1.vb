Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class UsuarioSesion
    Public Shared UsuarioLogueado As String
    Public Shared RolUsuario As String
End Class

Public Class ConexionDB
    Private conexion As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb")

    Public Function AbrirConexion() As OleDbConnection
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al abrir la conexión: " & ex.Message)
        End Try
        Return conexion
    End Function

    Public Sub CerrarConexion()
        Try
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cerrar la conexión: " & ex.Message)
        End Try
    End Sub
End Class



Public Class DataGridViewCalendarColumn
    Inherits DataGridViewColumn

    Public Sub New()
        MyBase.New(New DataGridViewCalendarCell())
    End Sub

    Public Overrides Property CellTemplate() As DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(ByVal value As DataGridViewCell)
            ' Asegúrate de que la celda es de tipo DataGridViewCalendarCell.
            If (Not (value Is Nothing)) AndAlso Not value.GetType().IsAssignableFrom(GetType(DataGridViewCalendarCell)) Then
                Throw New InvalidCastException("Debe ser una instancia de DataGridViewCalendarCell")
            End If
            MyBase.CellTemplate = value
        End Set
    End Property
End Class

Public Class DataGridViewCalendarCell
    Inherits DataGridViewTextBoxCell

    Public Sub New()
        ' Usa el formato de fecha para la celda.
        Me.Style.Format = "d"
    End Sub

    Public Overrides Sub InitializeEditingControl(rowIndex As Integer, _
        ByVal initialFormattedValue As Object, _
        ByVal dataGridViewCellStyle As DataGridViewCellStyle)

        ' Llamar al método base
        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)

        ' Obtener el control de edición que será el DateTimePicker
        Dim ctl As DataGridViewCalendarEditingControl = CType(DataGridView.EditingControl, DataGridViewCalendarEditingControl)

        ' Usa el valor actual de la celda
        If IsDBNull(Me.Value) OrElse Me.Value Is Nothing Then
            ctl.Value = DateTime.Now
        Else
            ctl.Value = CType(Me.Value, DateTime)
        End If
    End Sub

    Public Overrides ReadOnly Property EditType() As Type
        Get
            ' Devuelve el tipo del control de edición que es el DateTimePicker
            Return GetType(DataGridViewCalendarEditingControl)
        End Get
    End Property

    Public Overrides ReadOnly Property ValueType() As Type
        Get
            ' El valor es de tipo DateTime.
            Return GetType(DateTime)
        End Get
    End Property

    Public Overrides ReadOnly Property DefaultNewRowValue() As Object
        Get
            ' El valor por defecto de una nueva fila es la fecha actual.
            Return DateTime.Now
        End Get
    End Property
End Class

Class DataGridViewCalendarEditingControl
    Inherits DateTimePicker
    Implements IDataGridViewEditingControl

    Private dataGridViewControl As DataGridView
    Private valueIsChanged As Boolean = False
    Private rowIndexNum As Integer

    Public Sub New()
        Me.Format = DateTimePickerFormat.Short
    End Sub

    Public Property EditingControlFormattedValue() As Object Implements IDataGridViewEditingControl.EditingControlFormattedValue
        Get
            Return Me.Value.ToShortDateString()
        End Get
        Set(ByVal value As Object)
            Try
                Me.Value = DateTime.Parse(CStr(value))
            Catch
                Me.Value = DateTime.Now
            End Try
        End Set
    End Property

    Public Function GetEditingControlFormattedValue(ByVal context As DataGridViewDataErrorContexts) As Object _
        Implements IDataGridViewEditingControl.GetEditingControlFormattedValue
        Return Me.Value.ToShortDateString()
    End Function

    Public Sub ApplyCellStyleToEditingControl(ByVal dataGridViewCellStyle As DataGridViewCellStyle) _
        Implements IDataGridViewEditingControl.ApplyCellStyleToEditingControl
        Me.Font = dataGridViewCellStyle.Font
        Me.CalendarForeColor = dataGridViewCellStyle.ForeColor
        Me.CalendarMonthBackground = dataGridViewCellStyle.BackColor
    End Sub

    Public Property EditingControlRowIndex() As Integer Implements IDataGridViewEditingControl.EditingControlRowIndex
        Get
            Return rowIndexNum
        End Get
        Set(ByVal value As Integer)
            rowIndexNum = value
        End Set
    End Property

    Public Function EditingControlWantsInputKey(ByVal key As Keys, _
        ByVal dataGridViewWantsInputKey As Boolean) As Boolean _
        Implements IDataGridViewEditingControl.EditingControlWantsInputKey
        ' Let the DateTimePicker handle the keys.
        Select Case key And Keys.KeyCode
            Case Keys.Left, Keys.Up, Keys.Down, Keys.Right, _
                Keys.Home, Keys.End, Keys.PageDown, Keys.PageUp
                Return True
            Case Else
                Return Not dataGridViewWantsInputKey
        End Select
    End Function

    Public Sub PrepareEditingControlForEdit(ByVal selectAll As Boolean) _
        Implements IDataGridViewEditingControl.PrepareEditingControlForEdit
        ' No preparation needed.
    End Sub

    Public ReadOnly Property RepositionEditingControlOnValueChange() As Boolean _
        Implements IDataGridViewEditingControl.RepositionEditingControlOnValueChange
        Get
            Return False
        End Get
    End Property

    Public Property EditingControlDataGridView() As DataGridView Implements IDataGridViewEditingControl.EditingControlDataGridView
        Get
            Return dataGridViewControl
        End Get
        Set(ByVal value As DataGridView)
            dataGridViewControl = value
        End Set
    End Property

    Public Property EditingControlValueChanged() As Boolean Implements IDataGridViewEditingControl.EditingControlValueChanged
        Get
            Return valueIsChanged
        End Get
        Set(ByVal value As Boolean)
            valueIsChanged = value
        End Set
    End Property

    Public ReadOnly Property EditingPanelCursor() As Cursor Implements IDataGridViewEditingControl.EditingPanelCursor
        Get
            Return MyBase.Cursor
        End Get
    End Property

    Protected Overrides Sub OnValueChanged(ByVal eventargs As EventArgs)
        ' Notify the DataGridView that the contents of the cell have changed.
        valueIsChanged = True
        Me.EditingControlDataGridView.NotifyCurrentCellDirty(True)
        MyBase.OnValueChanged(eventargs)
    End Sub
End Class
