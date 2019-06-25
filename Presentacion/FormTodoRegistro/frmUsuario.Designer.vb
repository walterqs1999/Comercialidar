<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
    Inherits Presentacion.frmTodoRegistro

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
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(407, 28)
        Me.Label1.Size = New System.Drawing.Size(274, 25)
        Me.Label1.Text = "REGISTRO DE USUARIO"
        '
        'btnRNuevo
        '
        Me.btnRNuevo.FlatAppearance.BorderSize = 0
        Me.btnRNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        '
        'btnRGrabar
        '
        Me.btnRGrabar.FlatAppearance.BorderSize = 0
        Me.btnRGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        '
        'btnRModificar
        '
        Me.btnRModificar.FlatAppearance.BorderSize = 0
        Me.btnRModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        '
        'btnREliminar
        '
        Me.btnREliminar.FlatAppearance.BorderSize = 0
        Me.btnREliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        '
        'btnRSalir
        '
        Me.btnRSalir.FlatAppearance.BorderSize = 0
        Me.btnRSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Location = New System.Drawing.Point(199, 77)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.Size = New System.Drawing.Size(646, 480)
        Me.dgvUsuarios.TabIndex = 18
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1098, 620)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "frmUsuario"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.btnRNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnRGrabar, 0)
        Me.Controls.SetChildIndex(Me.btnRModificar, 0)
        Me.Controls.SetChildIndex(Me.btnREliminar, 0)
        Me.Controls.SetChildIndex(Me.btnRSalir, 0)
        Me.Controls.SetChildIndex(Me.dgvUsuarios, 0)
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvUsuarios As DataGridView
End Class
