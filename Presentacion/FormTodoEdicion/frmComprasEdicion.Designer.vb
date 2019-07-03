<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmComprasEdicion
    Inherits Presentacion.frmTodoDocumentos

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pcu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pvu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtUnitarioC = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUnitarioV = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grbDetalle.SuspendLayout()
        Me.grbDatos.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnComprar
        '
        '
        'btnEliminar
        '
        '
        'btnCancelar
        '
        '
        'btnNuevo
        '
        '
        'grbDetalle
        '
        Me.grbDetalle.Controls.Add(Me.txtStock)
        Me.grbDetalle.Controls.Add(Me.Label3)
        Me.grbDetalle.Controls.Add(Me.btnBuscar)
        Me.grbDetalle.Controls.Add(Me.txtUnitarioC)
        Me.grbDetalle.Controls.Add(Me.Label2)
        Me.grbDetalle.Controls.Add(Me.txtUnitarioV)
        Me.grbDetalle.Controls.Add(Me.Label17)
        Me.grbDetalle.Controls.Add(Me.txtCantidad)
        Me.grbDetalle.Controls.Add(Me.Label5)
        Me.grbDetalle.Controls.Add(Me.Label16)
        Me.grbDetalle.Controls.Add(Me.txtDescripcion)
        Me.grbDetalle.Location = New System.Drawing.Point(47, 179)
        Me.grbDetalle.Controls.SetChildIndex(Me.txtCodigo, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.Label15, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.Label16, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.Label5, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.txtCantidad, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.Label17, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.txtUnitarioV, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.Label2, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.txtUnitarioC, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.Label3, 0)
        Me.grbDetalle.Controls.SetChildIndex(Me.txtStock, 0)
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(5, 20)
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(70, 15)
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.txtDireccion)
        Me.grbDatos.Controls.Add(Me.Label8)
        Me.grbDatos.Controls.Add(Me.txtNombres)
        Me.grbDatos.Controls.Add(Me.Label4)
        Me.grbDatos.Size = New System.Drawing.Size(562, 141)
        Me.grbDatos.Controls.SetChildIndex(Me.Label1, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtNumeroF, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.cboTipo, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.Label9, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.lbRUC, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtRUCDNI, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.lbDNI, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.Label4, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtNombres, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.Label8, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtDireccion, 0)
        '
        'txtRUCDNI
        '
        '
        'cboTipo
        '
        '
        'btnAgregar
        '
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.tipo, Me.codigo, Me.producto, Me.pcu, Me.pvu, Me.cantidad, Me.total})
        Me.dgvDatos.Location = New System.Drawing.Point(44, 326)
        Me.dgvDatos.MultiSelect = False
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(564, 220)
        Me.dgvDatos.TabIndex = 103
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
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
        '
        'pcu
        '
        Me.pcu.HeaderText = "PRECIO COMP. U."
        Me.pcu.Name = "pcu"
        Me.pcu.ReadOnly = True
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
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(136, 110)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(307, 22)
        Me.txtDireccion.TabIndex = 98
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label8.Location = New System.Drawing.Point(13, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 14)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "Dirección:"
        '
        'txtNombres
        '
        Me.txtNombres.Enabled = False
        Me.txtNombres.Location = New System.Drawing.Point(136, 81)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(307, 22)
        Me.txtNombres.TabIndex = 96
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 14)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Nombre:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(501, 14)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(53, 23)
        Me.btnBuscar.TabIndex = 47
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtUnitarioC
        '
        Me.txtUnitarioC.Location = New System.Drawing.Point(51, 60)
        Me.txtUnitarioC.Name = "txtUnitarioC"
        Me.txtUnitarioC.Size = New System.Drawing.Size(71, 22)
        Me.txtUnitarioC.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 14)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "P.C.U :"
        '
        'txtUnitarioV
        '
        Me.txtUnitarioV.Location = New System.Drawing.Point(188, 60)
        Me.txtUnitarioV.Name = "txtUnitarioV"
        Me.txtUnitarioV.Size = New System.Drawing.Size(72, 22)
        Me.txtUnitarioV.TabIndex = 44
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label17.Location = New System.Drawing.Point(137, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 14)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "P.V.U :"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(479, 60)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(75, 22)
        Me.txtCantidad.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label5.Location = New System.Drawing.Point(413, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 14)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Cantidad:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label16.Location = New System.Drawing.Point(205, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 14)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(277, 15)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(221, 22)
        Me.txtDescripcion.TabIndex = 40
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(324, 60)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(72, 22)
        Me.txtStock.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label3.Location = New System.Drawing.Point(273, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 14)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Stock :"
        '
        'frmComprasEdicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1081, 644)
        Me.Controls.Add(Me.dgvDatos)
        Me.Name = "frmComprasEdicion"
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
        Me.Controls.SetChildIndex(Me.dgvDatos, 0)
        Me.grbDetalle.ResumeLayout(False)
        Me.grbDetalle.PerformLayout()
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtUnitarioC As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUnitarioV As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents producto As DataGridViewTextBoxColumn
    Friend WithEvents pcu As DataGridViewTextBoxColumn
    Friend WithEvents pvu As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label3 As Label
End Class
