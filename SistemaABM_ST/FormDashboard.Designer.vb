<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDashboard))
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_label_name = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tool_btn_registro = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tool_btn_carga = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_pendientes = New System.Windows.Forms.Label()
        Me.lbl_completas = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(323, 184)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_label_name, Me.ToolStripSeparator2, Me.tool_btn_registro, Me.ToolStripSeparator1, Me.tool_btn_carga})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(589, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_label_name
        '
        Me.Tool_label_name.Name = "Tool_label_name"
        Me.Tool_label_name.Size = New System.Drawing.Size(147, 22)
        Me.Tool_label_name.Text = "Nombre de usuario"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tool_btn_registro
        '
        Me.tool_btn_registro.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.tool_btn_registro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tool_btn_registro.Image = CType(resources.GetObject("tool_btn_registro.Image"), System.Drawing.Image)
        Me.tool_btn_registro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_btn_registro.Name = "tool_btn_registro"
        Me.tool_btn_registro.Size = New System.Drawing.Size(77, 22)
        Me.tool_btn_registro.Text = "Usuarios"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tool_btn_carga
        '
        Me.tool_btn_carga.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.tool_btn_carga.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tool_btn_carga.Image = CType(resources.GetObject("tool_btn_carga.Image"), System.Drawing.Image)
        Me.tool_btn_carga.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_btn_carga.Name = "tool_btn_carga"
        Me.tool_btn_carga.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tool_btn_carga.Size = New System.Drawing.Size(114, 22)
        Me.tool_btn_carga.Text = "Reparaciones"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total de raparaciones:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Raparaciones Completadas:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Raparaciones Pendientes:"
        '
        'lbl_pendientes
        '
        Me.lbl_pendientes.AutoSize = True
        Me.lbl_pendientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pendientes.ForeColor = System.Drawing.Color.Red
        Me.lbl_pendientes.Location = New System.Drawing.Point(34, 94)
        Me.lbl_pendientes.Name = "lbl_pendientes"
        Me.lbl_pendientes.Size = New System.Drawing.Size(51, 25)
        Me.lbl_pendientes.TabIndex = 5
        Me.lbl_pendientes.Text = "000"
        '
        'lbl_completas
        '
        Me.lbl_completas.AutoSize = True
        Me.lbl_completas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_completas.ForeColor = System.Drawing.Color.LawnGreen
        Me.lbl_completas.Location = New System.Drawing.Point(34, 184)
        Me.lbl_completas.Name = "lbl_completas"
        Me.lbl_completas.Size = New System.Drawing.Size(51, 25)
        Me.lbl_completas.TabIndex = 6
        Me.lbl_completas.Text = "000"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbl_total.Location = New System.Drawing.Point(34, 273)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(51, 25)
        Me.lbl_total.TabIndex = 7
        Me.lbl_total.Text = "000"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(364, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'FormDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 364)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_completas)
        Me.Controls.Add(Me.lbl_pendientes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Name = "FormDashboard"
        Me.Text = "Dashboard"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tool_btn_registro As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tool_btn_carga As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_label_name As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_pendientes As System.Windows.Forms.Label
    Friend WithEvents lbl_completas As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
