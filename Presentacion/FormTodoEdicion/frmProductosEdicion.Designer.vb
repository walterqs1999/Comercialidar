<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductosEdicion
    Inherits Presentacion.frmTodoEdicion

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
        Me.txtPrecioC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.txtPrecioV = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.txtStock)
        Me.grbDatos.Controls.Add(Me.Label6)
        Me.grbDatos.Controls.Add(Me.txtPrecioV)
        Me.grbDatos.Controls.Add(Me.Label5)
        Me.grbDatos.Controls.Add(Me.cboCategoria)
        Me.grbDatos.Controls.Add(Me.txtPrecioC)
        Me.grbDatos.Controls.Add(Me.Label4)
        Me.grbDatos.Controls.Add(Me.Label3)
        Me.grbDatos.Controls.Add(Me.txtNombre)
        Me.grbDatos.Controls.Add(Me.Label2)
        Me.grbDatos.Size = New System.Drawing.Size(569, 168)
        Me.grbDatos.Controls.SetChildIndex(Me.Label2, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.Label3, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.Label4, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtPrecioC, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.cboCategoria, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.Label1, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtId, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.Label5, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtPrecioV, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.Label6, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtStock, 0)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(324, 22)
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.Text = "CODIGO PRODUCTO :"
        '
        'btnGrabarb
        '
        Me.btnGrabarb.Location = New System.Drawing.Point(119, 213)
        '
        'btnModificarb
        '
        Me.btnModificarb.Location = New System.Drawing.Point(214, 213)
        '
        'btnNuevob
        '
        Me.btnNuevob.Location = New System.Drawing.Point(318, 213)
        '
        'txtPrecioC
        '
        Me.txtPrecioC.Location = New System.Drawing.Point(161, 100)
        Me.txtPrecioC.Name = "txtPrecioC"
        Me.txtPrecioC.Size = New System.Drawing.Size(66, 20)
        Me.txtPrecioC.TabIndex = 103
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "PRECIO . C :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "CATEGORIA :"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(161, 45)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(388, 20)
        Me.txtNombre.TabIndex = 99
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 13)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "NOMBRE PRODUCTO :"
        '
        'cboCategoria
        '
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(161, 71)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(388, 21)
        Me.cboCategoria.TabIndex = 104
        '
        'txtPrecioV
        '
        Me.txtPrecioV.Location = New System.Drawing.Point(334, 100)
        Me.txtPrecioV.Name = "txtPrecioV"
        Me.txtPrecioV.Size = New System.Drawing.Size(66, 20)
        Me.txtPrecioV.TabIndex = 106
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(251, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "PRECIO. V :"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(483, 100)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(66, 20)
        Me.txtStock.TabIndex = 108
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(418, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "STOCK :"
        '
        'frmProductosEdicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(594, 284)
        Me.Name = "frmProductosEdicion"
        Me.Text = ".:. EDICION DE LA TABLA PRODUCTO .:."
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPrecioV As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents txtPrecioC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
End Class
