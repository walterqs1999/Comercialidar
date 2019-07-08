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
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numedoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pvu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.newstock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grbDetalle.SuspendLayout()
        Me.grbDatos.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(492, 537)
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(437, 541)
        '
        'txtIgv
        '
        Me.txtIgv.Location = New System.Drawing.Point(309, 537)
        '
        'lblIgv
        '
        Me.lblIgv.Location = New System.Drawing.Point(261, 541)
        '
        'txtSubT
        '
        Me.txtSubT.Location = New System.Drawing.Point(144, 537)
        '
        'lblSubT
        '
        Me.lblSubT.Location = New System.Drawing.Point(69, 541)
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
        Me.grbDetalle.Controls.Add(Me.txtPrecioVenta)
        Me.grbDetalle.Controls.Add(Me.Label2)
        Me.grbDetalle.Controls.Add(Me.btnBuscar)
        Me.grbDetalle.Controls.Add(Me.txtStock)
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
        Me.grbDetalle.Controls.SetChildIndex(Me.txtStock, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.Label2, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.txtPrecioVenta, 0)
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
        'txtRUCDNI
        '
        '
        'cboTipo
        '
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
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(226, 63)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(72, 22)
        Me.txtStock.TabIndex = 93
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
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Location = New System.Drawing.Point(72, 60)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(72, 22)
        Me.txtPrecioVenta.TabIndex = 96
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
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.numedoc, Me.tipo, Me.codigo, Me.producto, Me.pvu, Me.cantidad, Me.total, Me.newstock})
        Me.dgvDatos.Location = New System.Drawing.Point(49, 306)
        Me.dgvDatos.MultiSelect = False
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(564, 220)
        Me.dgvDatos.TabIndex = 104
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'numedoc
        '
        Me.numedoc.HeaderText = "numedoc"
        Me.numedoc.Name = "numedoc"
        Me.numedoc.ReadOnly = True
        Me.numedoc.Visible = False
        '
        'tipo
        '
        Me.tipo.HeaderText = "tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Visible = False
        '
        'codigo
        '
        Me.codigo.HeaderText = "codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Visible = False
        '
        'producto
        '
        Me.producto.HeaderText = "PRODUCTO"
        Me.producto.Name = "producto"
        Me.producto.ReadOnly = True
        Me.producto.Width = 200
        '
        'pvu
        '
        Me.pvu.HeaderText = "PRECIO VENT. U."
        Me.pvu.Name = "pvu"
        Me.pvu.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "CANTIDAD"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "TOTAL"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'newstock
        '
        Me.newstock.HeaderText = "newstock"
        Me.newstock.Name = "newstock"
        Me.newstock.ReadOnly = True
        Me.newstock.Visible = False
        '
        'frmVentasEdicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1091, 644)
        Me.Controls.Add(Me.dgvDatos)
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
        Me.Controls.SetChildIndex(Me.dgvDatos, 0)
        Me.grbDetalle.ResumeLayout(False)
        Me.grbDetalle.PerformLayout()
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRazon As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtPrecioVenta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents numedoc As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents producto As DataGridViewTextBoxColumn
    Friend WithEvents pvu As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents newstock As DataGridViewTextBoxColumn
End Class
