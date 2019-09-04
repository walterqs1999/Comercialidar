<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoriaEdicion
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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.txtNombre)
        Me.grbDatos.Controls.Add(Me.Label2)
        Me.grbDatos.Size = New System.Drawing.Size(569, 113)
        Me.grbDatos.Controls.SetChildIndex(Me.Label1, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtId, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.Label2, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtNombre, 0)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(323, 22)
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.Text = "CODIGO CATEGORIA :"
        '
        'btnGrabarb
        '
        Me.btnGrabarb.Location = New System.Drawing.Point(291, 153)
        '
        'btnModificarb
        '
        Me.btnModificarb.Location = New System.Drawing.Point(192, 153)
        '
        'btnNuevob
        '
        Me.btnNuevob.Location = New System.Drawing.Point(99, 153)
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(144, 54)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(405, 20)
        Me.txtNombre.TabIndex = 97
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "NOMBRE CATEGORIA :"
        '
        'frmCategoriaEdicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(594, 209)
        Me.Name = "frmCategoriaEdicion"
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
End Class
