<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistro))
        Me.lbl_nombre_usuario = New System.Windows.Forms.Label()
        Me.input_nombre = New System.Windows.Forms.TextBox()
        Me.input_contraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_atras = New System.Windows.Forms.ToolStripButton()
        Me.list_rol = New System.Windows.Forms.ListBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_nombre_usuario
        '
        Me.lbl_nombre_usuario.AutoSize = True
        Me.lbl_nombre_usuario.Location = New System.Drawing.Point(8, 65)
        Me.lbl_nombre_usuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nombre_usuario.Name = "lbl_nombre_usuario"
        Me.lbl_nombre_usuario.Size = New System.Drawing.Size(96, 13)
        Me.lbl_nombre_usuario.TabIndex = 0
        Me.lbl_nombre_usuario.Text = "Nombre de usuario"
        '
        'input_nombre
        '
        Me.input_nombre.Location = New System.Drawing.Point(10, 80)
        Me.input_nombre.Margin = New System.Windows.Forms.Padding(2)
        Me.input_nombre.Name = "input_nombre"
        Me.input_nombre.Size = New System.Drawing.Size(94, 20)
        Me.input_nombre.TabIndex = 1
        '
        'input_contraseña
        '
        Me.input_contraseña.Location = New System.Drawing.Point(10, 155)
        Me.input_contraseña.Margin = New System.Windows.Forms.Padding(2)
        Me.input_contraseña.Name = "input_contraseña"
        Me.input_contraseña.Size = New System.Drawing.Size(127, 20)
        Me.input_contraseña.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 131)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Rol"
        '
        'btn_registrar
        '
        Me.btn_registrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_registrar.Location = New System.Drawing.Point(11, 223)
        Me.btn_registrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(72, 34)
        Me.btn_registrar.TabIndex = 6
        Me.btn_registrar.Text = "Registrar"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_atras})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(344, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_atras
        '
        Me.btn_atras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_atras.Image = CType(resources.GetObject("btn_atras.Image"), System.Drawing.Image)
        Me.btn_atras.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_atras.Name = "btn_atras"
        Me.btn_atras.Size = New System.Drawing.Size(38, 22)
        Me.btn_atras.Text = "Atras"
        '
        'list_rol
        '
        Me.list_rol.FormattingEnabled = True
        Me.list_rol.Location = New System.Drawing.Point(182, 80)
        Me.list_rol.Name = "list_rol"
        Me.list_rol.Size = New System.Drawing.Size(120, 95)
        Me.list_rol.TabIndex = 8
        '
        'FrmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 268)
        Me.Controls.Add(Me.list_rol)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.input_contraseña)
        Me.Controls.Add(Me.input_nombre)
        Me.Controls.Add(Me.lbl_nombre_usuario)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmRegistro"
        Me.Text = "Registro"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nombre_usuario As System.Windows.Forms.Label
    Friend WithEvents input_nombre As System.Windows.Forms.TextBox
    Friend WithEvents input_contraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_registrar As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_atras As System.Windows.Forms.ToolStripButton
    Friend WithEvents list_rol As System.Windows.Forms.ListBox
End Class
