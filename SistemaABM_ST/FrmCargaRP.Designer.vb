<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCargaRP
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.input_cliente = New System.Windows.Forms.TextBox()
        Me.btn_subir = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.input_descripcion = New System.Windows.Forms.RichTextBox()
        Me.ListBoxUsuarios = New System.Windows.Forms.ListBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(180, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripcion del problema"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 111)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tecnico asignado"
        '
        'input_cliente
        '
        Me.input_cliente.Location = New System.Drawing.Point(34, 71)
        Me.input_cliente.Margin = New System.Windows.Forms.Padding(2)
        Me.input_cliente.Name = "input_cliente"
        Me.input_cliente.Size = New System.Drawing.Size(68, 20)
        Me.input_cliente.TabIndex = 4
        '
        'btn_subir
        '
        Me.btn_subir.Location = New System.Drawing.Point(34, 281)
        Me.btn_subir.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_subir.Name = "btn_subir"
        Me.btn_subir.Size = New System.Drawing.Size(95, 29)
        Me.btn_subir.TabIndex = 7
        Me.btn_subir.Text = "Subir"
        Me.btn_subir.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(182, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem1.Text = "ToolStripMenuItem1"
        '
        'input_descripcion
        '
        Me.input_descripcion.Location = New System.Drawing.Point(183, 71)
        Me.input_descripcion.Name = "input_descripcion"
        Me.input_descripcion.Size = New System.Drawing.Size(386, 186)
        Me.input_descripcion.TabIndex = 8
        Me.input_descripcion.Text = ""
        '
        'ListBoxUsuarios
        '
        Me.ListBoxUsuarios.FormattingEnabled = True
        Me.ListBoxUsuarios.Location = New System.Drawing.Point(34, 136)
        Me.ListBoxUsuarios.Name = "ListBoxUsuarios"
        Me.ListBoxUsuarios.Size = New System.Drawing.Size(125, 121)
        Me.ListBoxUsuarios.TabIndex = 9
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(143, 281)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(95, 29)
        Me.btn_cancelar.TabIndex = 10
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'FrmCargaRP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 321)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.ListBoxUsuarios)
        Me.Controls.Add(Me.input_descripcion)
        Me.Controls.Add(Me.btn_subir)
        Me.Controls.Add(Me.input_cliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmCargaRP"
        Me.Text = "Nueva Reparación"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents input_cliente As System.Windows.Forms.TextBox
    Friend WithEvents btn_subir As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents input_descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents ListBoxUsuarios As System.Windows.Forms.ListBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
End Class
