<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedorEdicion
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
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPersonaC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.txtReferencia)
        Me.grbDatos.Controls.Add(Me.Label6)
        Me.grbDatos.Controls.Add(Me.txtTelefono)
        Me.grbDatos.Controls.Add(Me.Label5)
        Me.grbDatos.Controls.Add(Me.txtDireccion)
        Me.grbDatos.Controls.Add(Me.Label4)
        Me.grbDatos.Controls.Add(Me.txtPersonaC)
        Me.grbDatos.Controls.Add(Me.Label3)
        Me.grbDatos.Controls.Add(Me.txtEmpresa)
        Me.grbDatos.Controls.Add(Me.Label2)
        Me.grbDatos.Size = New System.Drawing.Size(569, 189)
        Me.grbDatos.Controls.SetChildIndex(Me.Label1, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtId, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.Label2, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtEmpresa, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.Label3, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtPersonaC, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.Label4, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtDireccion, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.Label5, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtTelefono, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.Label6, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtReferencia, 0)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(358, 22)
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.Text = "RUC EMPRESA"
        '
        'btnGrabarb
        '
        Me.btnGrabarb.Location = New System.Drawing.Point(124, 242)
        '
        'btnModificarb
        '
        Me.btnModificarb.Location = New System.Drawing.Point(202, 242)
        '
        'btnNuevob
        '
        Me.btnNuevob.Location = New System.Drawing.Point(326, 242)
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(121, 149)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(428, 20)
        Me.txtReferencia.TabIndex = 105
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "REFERENCIA :"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(121, 123)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(151, 20)
        Me.txtTelefono.TabIndex = 103
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 102
        Me.Label5.Text = "TEL. O CEL. : :"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(121, 97)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(428, 20)
        Me.txtDireccion.TabIndex = 101
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "DIRECCIÒN :"
        '
        'txtPersonaC
        '
        Me.txtPersonaC.Location = New System.Drawing.Point(121, 71)
        Me.txtPersonaC.Name = "txtPersonaC"
        Me.txtPersonaC.Size = New System.Drawing.Size(428, 20)
        Me.txtPersonaC.TabIndex = 99
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "PERSONA CARG. :"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Location = New System.Drawing.Point(121, 45)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(428, 20)
        Me.txtEmpresa.TabIndex = 97
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "NOMBRE EMPR. :"
        '
        'frmProveedorEdicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(594, 334)
        Me.Name = "frmProveedorEdicion"
        Me.Text = ".:. EDICION DE LA TABLA PROVEEDOR .:."
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtReferencia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPersonaC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmpresa As TextBox
    Friend WithEvents Label2 As Label
End Class
