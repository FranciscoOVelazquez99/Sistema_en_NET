﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.input_dni = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.input_contacto = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(187, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Datos del equipo e informacion del probelma"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 191)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tecnico asignado"
        '
        'input_cliente
        '
        Me.input_cliente.Location = New System.Drawing.Point(21, 31)
        Me.input_cliente.Margin = New System.Windows.Forms.Padding(2)
        Me.input_cliente.Name = "input_cliente"
        Me.input_cliente.Size = New System.Drawing.Size(128, 20)
        Me.input_cliente.TabIndex = 4
        '
        'btn_subir
        '
        Me.btn_subir.Location = New System.Drawing.Point(12, 292)
        Me.btn_subir.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_subir.Name = "btn_subir"
        Me.btn_subir.Size = New System.Drawing.Size(89, 29)
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
        Me.input_descripcion.Location = New System.Drawing.Point(190, 24)
        Me.input_descripcion.Name = "input_descripcion"
        Me.input_descripcion.Size = New System.Drawing.Size(386, 252)
        Me.input_descripcion.TabIndex = 8
        Me.input_descripcion.Text = ""
        '
        'ListBoxUsuarios
        '
        Me.ListBoxUsuarios.FormattingEnabled = True
        Me.ListBoxUsuarios.Location = New System.Drawing.Point(12, 207)
        Me.ListBoxUsuarios.Name = "ListBoxUsuarios"
        Me.ListBoxUsuarios.Size = New System.Drawing.Size(170, 69)
        Me.ListBoxUsuarios.TabIndex = 9
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(105, 292)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(77, 29)
        Me.btn_cancelar.TabIndex = 10
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "DNI"
        '
        'input_dni
        '
        Me.input_dni.AcceptsReturn = True
        Me.input_dni.Location = New System.Drawing.Point(21, 80)
        Me.input_dni.Margin = New System.Windows.Forms.Padding(2)
        Me.input_dni.Name = "input_dni"
        Me.input_dni.Size = New System.Drawing.Size(128, 20)
        Me.input_dni.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 111)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Contacto"
        '
        'input_contacto
        '
        Me.input_contacto.Location = New System.Drawing.Point(21, 126)
        Me.input_contacto.Margin = New System.Windows.Forms.Padding(2)
        Me.input_contacto.Name = "input_contacto"
        Me.input_contacto.Size = New System.Drawing.Size(128, 20)
        Me.input_contacto.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.input_dni)
        Me.Panel1.Controls.Add(Me.input_cliente)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.input_contacto)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(170, 164)
        Me.Panel1.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 8)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Datos del cliente"
        '
        'FrmCargaRP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 332)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.ListBoxUsuarios)
        Me.Controls.Add(Me.input_descripcion)
        Me.Controls.Add(Me.btn_subir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmCargaRP"
        Me.Text = "Nueva Reparación"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents input_dni As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents input_contacto As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
