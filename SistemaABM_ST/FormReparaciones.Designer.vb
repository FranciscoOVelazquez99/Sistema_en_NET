<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReparaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReparaciones))
        Me.DataGridViewReparaciones = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_atras = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_añadir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_reload = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridViewReparaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewReparaciones
        '
        Me.DataGridViewReparaciones.AllowUserToAddRows = False
        Me.DataGridViewReparaciones.AllowUserToDeleteRows = False
        Me.DataGridViewReparaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewReparaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewReparaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewReparaciones.Location = New System.Drawing.Point(0, 28)
        Me.DataGridViewReparaciones.Name = "DataGridViewReparaciones"
        Me.DataGridViewReparaciones.Size = New System.Drawing.Size(1000, 403)
        Me.DataGridViewReparaciones.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_atras, Me.ToolStripSeparator2, Me.btn_añadir, Me.ToolStripSeparator3, Me.btn_reload})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 25)
        Me.ToolStrip1.TabIndex = 4
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btn_añadir
        '
        Me.btn_añadir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_añadir.Image = CType(resources.GetObject("btn_añadir.Image"), System.Drawing.Image)
        Me.btn_añadir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_añadir.Name = "btn_añadir"
        Me.btn_añadir.Size = New System.Drawing.Size(46, 22)
        Me.btn_añadir.Text = "Nuevo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btn_reload
        '
        Me.btn_reload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_reload.Image = CType(resources.GetObject("btn_reload.Image"), System.Drawing.Image)
        Me.btn_reload.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_reload.Name = "btn_reload"
        Me.btn_reload.Size = New System.Drawing.Size(63, 22)
        Me.btn_reload.Text = "Actualizar"
        '
        'FormReparaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 431)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridViewReparaciones)
        Me.Name = "FormReparaciones"
        Me.Text = "Reparaciones"
        CType(Me.DataGridViewReparaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewReparaciones As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_añadir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_atras As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_reload As System.Windows.Forms.ToolStripButton
End Class
