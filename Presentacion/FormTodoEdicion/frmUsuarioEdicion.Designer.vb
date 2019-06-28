<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarioEdicion
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
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grbConfidencial = New System.Windows.Forms.GroupBox()
        Me.grbDatos.SuspendLayout()
        Me.grbConfidencial.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(307, 335)
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.grbConfidencial)
        Me.grbDatos.Controls.Add(Me.cboTipo)
        Me.grbDatos.Controls.Add(Me.Label8)
        Me.grbDatos.Controls.Add(Me.txtEmail)
        Me.grbDatos.Controls.Add(Me.Label7)
        Me.grbDatos.Controls.Add(Me.txtTelefono)
        Me.grbDatos.Controls.Add(Me.Label4)
        Me.grbDatos.Controls.Add(Me.txtDireccion)
        Me.grbDatos.Controls.Add(Me.Label3)
        Me.grbDatos.Controls.Add(Me.txtNombre)
        Me.grbDatos.Controls.Add(Me.Label2)
        Me.grbDatos.Size = New System.Drawing.Size(569, 301)
        Me.grbDatos.Controls.SetChildIndex(Me.Label1, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtId, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.Label2, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.Label3, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtDireccion, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.Label4, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtTelefono, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.Label7, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtEmail, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.Label8, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.cboTipo, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.grbConfidencial, 0)
        '
        'txtId
        '
        '
        'btnGrabarb
        '
        Me.btnGrabarb.Location = New System.Drawing.Point(139, 335)
        '
        'btnModificarb
        '
        Me.btnModificarb.Location = New System.Drawing.Point(139, 335)
        '
        'btnNuevob
        '
        Me.btnNuevob.Location = New System.Drawing.Point(222, 377)
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(290, 36)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.TabIndex = 94
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'cboTipo
        '
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"Administrador", "Empleado"})
        Me.cboTipo.Location = New System.Drawing.Point(372, 123)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(135, 21)
        Me.cboTipo.TabIndex = 93
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(255, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "TIPO USUARIO :"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(99, 97)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(449, 20)
        Me.txtEmail.TabIndex = 91
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "EMAIL :"
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(119, 52)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(135, 20)
        Me.txtClave.TabIndex = 89
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "CONTRASEÑA :"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(119, 26)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(135, 20)
        Me.txtUsuario.TabIndex = 87
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "USUARIO :"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(99, 123)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(135, 20)
        Me.txtTelefono.TabIndex = 85
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "TELEFONO :"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(100, 71)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(449, 20)
        Me.txtDireccion.TabIndex = 83
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "DIRECCIÒN :"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(100, 45)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(449, 20)
        Me.txtNombre.TabIndex = 81
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "NOMBRE :"
        '
        'grbConfidencial
        '
        Me.grbConfidencial.Controls.Add(Me.btnGenerar)
        Me.grbConfidencial.Controls.Add(Me.Label5)
        Me.grbConfidencial.Controls.Add(Me.txtUsuario)
        Me.grbConfidencial.Controls.Add(Me.Label6)
        Me.grbConfidencial.Controls.Add(Me.txtClave)
        Me.grbConfidencial.Location = New System.Drawing.Point(20, 177)
        Me.grbConfidencial.Name = "grbConfidencial"
        Me.grbConfidencial.Size = New System.Drawing.Size(511, 94)
        Me.grbConfidencial.TabIndex = 95
        Me.grbConfidencial.TabStop = False
        Me.grbConfidencial.Text = "Confidencial"
        '
        'frmUsuarioEdicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(594, 424)
        Me.Name = "frmUsuarioEdicion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:. EDICION EN LA TABLA USUARIO .:."
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.grbConfidencial.ResumeLayout(False)
        Me.grbConfidencial.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbConfidencial As GroupBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtClave As TextBox
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
End Class
