<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUsuarios))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_atras = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_update = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_new_user = New System.Windows.Forms.ToolStripButton()
        Me.DataGridUsers = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_atras, Me.ToolStripSeparator1, Me.btn_update, Me.ToolStripSeparator2, Me.btn_new_user})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(611, 25)
        Me.ToolStrip1.TabIndex = 0
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btn_update
        '
        Me.btn_update.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_update.Image = CType(resources.GetObject("btn_update.Image"), System.Drawing.Image)
        Me.btn_update.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(63, 22)
        Me.btn_update.Text = "Actualizar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btn_new_user
        '
        Me.btn_new_user.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_new_user.Image = CType(resources.GetObject("btn_new_user.Image"), System.Drawing.Image)
        Me.btn_new_user.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_new_user.Name = "btn_new_user"
        Me.btn_new_user.Size = New System.Drawing.Size(89, 22)
        Me.btn_new_user.Text = "Nuevo Usuario"
        '
        'DataGridUsers
        '
        Me.DataGridUsers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridUsers.Location = New System.Drawing.Point(12, 28)
        Me.DataGridUsers.Name = "DataGridUsers"
        Me.DataGridUsers.Size = New System.Drawing.Size(587, 322)
        Me.DataGridUsers.TabIndex = 1
        '
        'FormUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 362)
        Me.Controls.Add(Me.DataGridUsers)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FormUsuarios"
        Me.Text = "Usuarios"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_atras As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_new_user As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridUsers As System.Windows.Forms.DataGridView
    Friend WithEvents btn_update As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
