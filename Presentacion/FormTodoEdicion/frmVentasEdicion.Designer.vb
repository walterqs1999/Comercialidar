<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentasEdicion
    Inherits Presentacion.frmTodoDocumentos

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblRazon = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtUnitario = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.grbDetalle.SuspendLayout()
        Me.grbDatos.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(492, 526)
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(437, 530)
        '
        'txtIgv
        '
        Me.txtIgv.Location = New System.Drawing.Point(309, 526)
        '
        'lblIgv
        '
        Me.lblIgv.Location = New System.Drawing.Point(261, 530)
        '
        'txtSubT
        '
        Me.txtSubT.Location = New System.Drawing.Point(144, 526)
        '
        'lblSubT
        '
        Me.lblSubT.Location = New System.Drawing.Point(69, 530)
        '
        'btnComprar
        '
        Me.btnComprar.Location = New System.Drawing.Point(205, 572)
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(492, 572)
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(195, 276)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(355, 572)
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(84, 572)
        '
        'grbDetalle
        '
        Me.grbDetalle.Controls.Add(Me.TextBox1)
        Me.grbDetalle.Controls.Add(Me.Label2)
        Me.grbDetalle.Controls.Add(Me.btnBuscar)
        Me.grbDetalle.Controls.Add(Me.txtUnitario)
        Me.grbDetalle.Controls.Add(Me.Label17)
        Me.grbDetalle.Controls.Add(Me.txtCantidad)
        Me.grbDetalle.Controls.Add(Me.Label5)
        Me.grbDetalle.Controls.Add(Me.Label16)
        Me.grbDetalle.Controls.Add(Me.txtDescripcion)
        Me.grbDetalle.Location = New System.Drawing.Point(52, 169)
        Me.grbDetalle.Size = New System.Drawing.Size(561, 101)
        Me.grbDetalle.Controls.SetChildIndex(Me.txtCodigo, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.Label15, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.Label16, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.Label5, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.txtCantidad, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.Label17, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.txtUnitario, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.Label2, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.TextBox1, 0)
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(7, 27)
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(72, 22)
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.lblRazon)
        Me.grbDatos.Controls.Add(Me.txtDireccion)
        Me.grbDatos.Controls.Add(Me.Label8)
        Me.grbDatos.Controls.Add(Me.txtNombres)
        Me.grbDatos.Controls.Add(Me.lblNombre)
        Me.grbDatos.Location = New System.Drawing.Point(51, 25)
        Me.grbDatos.Size = New System.Drawing.Size(562, 138)
        Me.grbDatos.Controls.SetChildIndex(Me.Label1, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtNumeroF, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.cboTipo, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.Label9, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.lbRUC, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtRUCDNI, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.lbDNI, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.lblNombre, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtNombres, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.Label8, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtDireccion, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.lblRazon, 0)
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(366, 276)
        '
        'Label
        '
        Me.Label.Location = New System.Drawing.Point(810, 25)
        Me.Label.Size = New System.Drawing.Size(102, 25)
        Me.Label.Text = "VENTAS"
        '
        'lblRazon
        '
        Me.lblRazon.AutoSize = True
        Me.lblRazon.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazon.Location = New System.Drawing.Point(17, 82)
        Me.lblRazon.Name = "lblRazon"
        Me.lblRazon.Size = New System.Drawing.Size(82, 14)
        Me.lblRazon.TabIndex = 99
        Me.lblRazon.Text = "Razon Social :"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(136, 108)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(307, 22)
        Me.txtDireccion.TabIndex = 98
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label8.Location = New System.Drawing.Point(17, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 14)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "Dirección:"
        '
        'txtNombres
        '
        Me.txtNombres.Enabled = False
        Me.txtNombres.Location = New System.Drawing.Point(136, 79)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(307, 22)
        Me.txtNombres.TabIndex = 96
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(17, 83)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(52, 14)
        Me.lblNombre.TabIndex = 95
        Me.lblNombre.Text = "Nombre:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(501, 23)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(53, 23)
        Me.btnBuscar.TabIndex = 94
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtUnitario
        '
        Me.txtUnitario.Location = New System.Drawing.Point(255, 61)
        Me.txtUnitario.Name = "txtUnitario"
        Me.txtUnitario.Size = New System.Drawing.Size(72, 22)
        Me.txtUnitario.TabIndex = 93
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label17.Location = New System.Drawing.Point(183, 66)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 14)
        Me.Label17.TabIndex = 92
        Me.Label17.Text = "Stock:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(426, 61)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(78, 22)
        Me.txtCantidad.TabIndex = 91
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label5.Location = New System.Drawing.Point(361, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 14)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Cantidad:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label16.Location = New System.Drawing.Point(207, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 14)
        Me.Label16.TabIndex = 88
        Me.Label16.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(279, 23)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(200, 22)
        Me.txtDescripcion.TabIndex = 89
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(72, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(72, 22)
        Me.TextBox1.TabIndex = 96
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(7, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 14)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "P. Venta"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(52, 306)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(561, 214)
        Me.DataGridView1.TabIndex = 104
        '
        'frmVentasEdicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1091, 644)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmVentasEdicion"
        Me.Controls.SetChildIndex(Me.grbDatos, 0)
        Me.Controls.SetChildIndex(Me.grbDetalle, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnCancelar, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnComprar, 0)
        Me.Controls.SetChildIndex(Me.lblSubT, 0)
        Me.Controls.SetChildIndex(Me.txtSubT, 0)
        Me.Controls.SetChildIndex(Me.lblIgv, 0)
        Me.Controls.SetChildIndex(Me.txtIgv, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.txtTotal, 0)
        Me.Controls.SetChildIndex(Me.btnVistaPrevia, 0)
        Me.Controls.SetChildIndex(Me.Label, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        Me.grbDetalle.ResumeLayout(False)
        Me.grbDetalle.PerformLayout()
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRazon As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtUnitario As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
