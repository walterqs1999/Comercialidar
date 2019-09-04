<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCategorias

    Inherits Presentacion.frmTodoRegistro

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
        Me.dgvCategorias = New System.Windows.Forms.DataGridView()
        CType(Me.dgvCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(319, 25)
        Me.Label1.Text = "REGISTRO DE CATEGORIAS"
        '
        'btnRNuevo
        '
        Me.btnRNuevo.FlatAppearance.BorderSize = 0
        Me.btnRNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        '
        'btnRModificar
        '
        Me.btnRModificar.FlatAppearance.BorderSize = 0
        Me.btnRModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnRModificar.Location = New System.Drawing.Point(931, 209)
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
        'dgvCategorias
        '
        Me.dgvCategorias.AllowUserToAddRows = False
        Me.dgvCategorias.AllowUserToDeleteRows = False
        Me.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategorias.Location = New System.Drawing.Point(126, 77)
        Me.dgvCategorias.MultiSelect = False
        Me.dgvCategorias.Name = "dgvCategorias"
        Me.dgvCategorias.ReadOnly = True
        Me.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCategorias.Size = New System.Drawing.Size(747, 473)
        Me.dgvCategorias.TabIndex = 19
        '
        'frmCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1098, 620)
        Me.Controls.Add(Me.dgvCategorias)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "frmCategorias"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.btnRNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnRModificar, 0)
        Me.Controls.SetChildIndex(Me.btnREliminar, 0)
        Me.Controls.SetChildIndex(Me.btnRSalir, 0)
        Me.Controls.SetChildIndex(Me.dgvCategorias, 0)
        CType(Me.dgvCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents dgvCategorias As DataGridView
End Class
