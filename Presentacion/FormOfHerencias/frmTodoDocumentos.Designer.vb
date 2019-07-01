<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTodoDocumentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTodoDocumentos))
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtIgv = New System.Windows.Forms.TextBox()
        Me.lblIgv = New System.Windows.Forms.Label()
        Me.txtSubT = New System.Windows.Forms.TextBox()
        Me.lblSubT = New System.Windows.Forms.Label()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.grbDetalle = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.lbDNI = New System.Windows.Forms.Label()
        Me.txtRUCDNI = New System.Windows.Forms.TextBox()
        Me.lbRUC = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.txtNumeroF = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtMostrar = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnVistaPrevia = New System.Windows.Forms.Button()
        Me.grbDetalle.SuspendLayout()
        Me.grbDatos.SuspendLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(487, 552)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(97, 20)
        Me.txtTotal.TabIndex = 98
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Cambria", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(432, 556)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 12)
        Me.Label13.TabIndex = 97
        Me.Label13.Text = "Total :"
        '
        'txtIgv
        '
        Me.txtIgv.Location = New System.Drawing.Point(304, 552)
        Me.txtIgv.Name = "txtIgv"
        Me.txtIgv.Size = New System.Drawing.Size(97, 20)
        Me.txtIgv.TabIndex = 96
        '
        'lblIgv
        '
        Me.lblIgv.AutoSize = True
        Me.lblIgv.Font = New System.Drawing.Font("Cambria", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIgv.Location = New System.Drawing.Point(256, 556)
        Me.lblIgv.Name = "lblIgv"
        Me.lblIgv.Size = New System.Drawing.Size(28, 12)
        Me.lblIgv.TabIndex = 95
        Me.lblIgv.Text = "IGV :"
        '
        'txtSubT
        '
        Me.txtSubT.Location = New System.Drawing.Point(139, 552)
        Me.txtSubT.Name = "txtSubT"
        Me.txtSubT.Size = New System.Drawing.Size(97, 20)
        Me.txtSubT.TabIndex = 94
        '
        'lblSubT
        '
        Me.lblSubT.AutoSize = True
        Me.lblSubT.Font = New System.Drawing.Font("Cambria", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubT.Location = New System.Drawing.Point(64, 556)
        Me.lblSubT.Name = "lblSubT"
        Me.lblSubT.Size = New System.Drawing.Size(55, 12)
        Me.lblSubT.TabIndex = 93
        Me.lblSubT.Text = "Sub Total :"
        '
        'btnComprar
        '
        Me.btnComprar.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprar.Image = CType(resources.GetObject("btnComprar.Image"), System.Drawing.Image)
        Me.btnComprar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnComprar.Location = New System.Drawing.Point(200, 598)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(84, 34)
        Me.btnComprar.TabIndex = 92
        Me.btnComprar.Text = "&Comprar"
        Me.btnComprar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnComprar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(487, 598)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(84, 34)
        Me.btnSalir.TabIndex = 91
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(186, 296)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(73, 24)
        Me.btnEliminar.TabIndex = 90
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(350, 598)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(84, 34)
        Me.btnCancelar.TabIndex = 89
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(79, 598)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(84, 34)
        Me.btnNuevo.TabIndex = 88
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'grbDetalle
        '
        Me.grbDetalle.Controls.Add(Me.Label15)
        Me.grbDetalle.Controls.Add(Me.txtCodigo)
        Me.grbDetalle.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDetalle.Location = New System.Drawing.Point(47, 191)
        Me.grbDetalle.Name = "grbDetalle"
        Me.grbDetalle.Size = New System.Drawing.Size(561, 99)
        Me.grbDetalle.TabIndex = 87
        Me.grbDetalle.TabStop = False
        Me.grbDetalle.Text = "Detalle"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Cambria", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 33)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 12)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "CÓDIGO:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(81, 28)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(129, 22)
        Me.txtCodigo.TabIndex = 20
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.dtpFecha)
        Me.grbDatos.Controls.Add(Me.Label10)
        Me.grbDatos.Controls.Add(Me.lbDNI)
        Me.grbDatos.Controls.Add(Me.txtRUCDNI)
        Me.grbDatos.Controls.Add(Me.lbRUC)
        Me.grbDatos.Controls.Add(Me.Label9)
        Me.grbDatos.Controls.Add(Me.cboTipo)
        Me.grbDatos.Controls.Add(Me.txtNumeroF)
        Me.grbDatos.Controls.Add(Me.Label1)
        Me.grbDatos.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDatos.Location = New System.Drawing.Point(46, 32)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Size = New System.Drawing.Size(562, 153)
        Me.grbDatos.TabIndex = 86
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos del Cliente"
        '
        'lbDNI
        '
        Me.lbDNI.AutoSize = True
        Me.lbDNI.Font = New System.Drawing.Font("Cambria", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDNI.Location = New System.Drawing.Point(17, 55)
        Me.lbDNI.Name = "lbDNI"
        Me.lbDNI.Size = New System.Drawing.Size(39, 12)
        Me.lbDNI.TabIndex = 38
        Me.lbDNI.Text = "DNI N°:"
        '
        'txtRUCDNI
        '
        Me.txtRUCDNI.Location = New System.Drawing.Point(136, 51)
        Me.txtRUCDNI.Name = "txtRUCDNI"
        Me.txtRUCDNI.Size = New System.Drawing.Size(192, 22)
        Me.txtRUCDNI.TabIndex = 37
        '
        'lbRUC
        '
        Me.lbRUC.AutoSize = True
        Me.lbRUC.Font = New System.Drawing.Font("Cambria", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRUC.Location = New System.Drawing.Point(17, 55)
        Me.lbRUC.Name = "lbRUC"
        Me.lbRUC.Size = New System.Drawing.Size(41, 12)
        Me.lbRUC.TabIndex = 36
        Me.lbRUC.Text = "RUC N°:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cambria", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(351, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 12)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "N° DOCUMENTO:"
        '
        'cboTipo
        '
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"BOLETA", "FACTURA"})
        Me.cboTipo.Location = New System.Drawing.Point(136, 20)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(192, 22)
        Me.cboTipo.TabIndex = 4
        '
        'txtNumeroF
        '
        Me.txtNumeroF.Location = New System.Drawing.Point(441, 21)
        Me.txtNumeroF.Name = "txtNumeroF"
        Me.txtNumeroF.Size = New System.Drawing.Size(114, 22)
        Me.txtNumeroF.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TIPO DE DOCUMENTO:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(357, 296)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(73, 24)
        Me.btnAgregar.TabIndex = 90
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtMostrar
        '
        Me.txtMostrar.Location = New System.Drawing.Point(690, 57)
        Me.txtMostrar.Multiline = True
        Me.txtMostrar.Name = "txtMostrar"
        Me.txtMostrar.Size = New System.Drawing.Size(333, 480)
        Me.txtMostrar.TabIndex = 100
        '
        'btnCerrar
        '
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1062, 14)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(22, 24)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrar.TabIndex = 101
        Me.btnCerrar.TabStop = False
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(441, 51)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(114, 22)
        Me.dtpFecha.TabIndex = 94
        Me.dtpFecha.Value = New Date(2018, 11, 30, 12, 1, 32, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label10.Location = New System.Drawing.Point(334, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 14)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Fecha de Emisión:"
        '
        'btnVistaPrevia
        '
        Me.btnVistaPrevia.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVistaPrevia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVistaPrevia.Location = New System.Drawing.Point(813, 568)
        Me.btnVistaPrevia.Name = "btnVistaPrevia"
        Me.btnVistaPrevia.Size = New System.Drawing.Size(97, 24)
        Me.btnVistaPrevia.TabIndex = 102
        Me.btnVistaPrevia.Text = "Vista Previa"
        Me.btnVistaPrevia.UseVisualStyleBackColor = True
        '
        'frmTodoDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 644)
        Me.Controls.Add(Me.btnVistaPrevia)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtMostrar)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtIgv)
        Me.Controls.Add(Me.lblIgv)
        Me.Controls.Add(Me.txtSubT)
        Me.Controls.Add(Me.lblSubT)
        Me.Controls.Add(Me.btnComprar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.grbDetalle)
        Me.Controls.Add(Me.grbDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTodoDocumentos"
        Me.Text = "frmTodoDocumentos"
        Me.grbDetalle.ResumeLayout(False)
        Me.grbDetalle.PerformLayout()
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents txtTotal As TextBox
    Public WithEvents Label13 As Label
    Public WithEvents txtIgv As TextBox
    Public WithEvents lblIgv As Label
    Public WithEvents txtSubT As TextBox
    Public WithEvents lblSubT As Label
    Public WithEvents btnComprar As Button
    Public WithEvents btnSalir As Button
    Public WithEvents btnEliminar As Button
    Public WithEvents btnCancelar As Button
    Public WithEvents btnNuevo As Button
    Public WithEvents grbDetalle As GroupBox
    Public WithEvents Label15 As Label
    Public WithEvents txtCodigo As TextBox
    Public WithEvents grbDatos As GroupBox
    Public WithEvents lbDNI As Label
    Public WithEvents txtRUCDNI As TextBox
    Public WithEvents lbRUC As Label
    Public WithEvents Label9 As Label
    Public WithEvents cboTipo As ComboBox
    Public WithEvents txtNumeroF As TextBox
    Public WithEvents Label1 As Label
    Public WithEvents btnAgregar As Button
    Friend WithEvents txtMostrar As TextBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label10 As Label
    Public WithEvents btnVistaPrevia As Button
End Class
