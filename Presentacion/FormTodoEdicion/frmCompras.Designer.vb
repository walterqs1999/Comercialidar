<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompras
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
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.Label2)
        Me.grbDatos.Controls.Add(Me.LinkLabel1)
        Me.grbDatos.Controls.SetChildIndex(Me.Label1, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.txtId, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.LinkLabel1, 0)
        Me.grbDatos.Controls.SetChildIndex(Me.Label2, 0)
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(51, 74)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel1.TabIndex = 41
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Label2"
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(594, 335)
        Me.Name = "frmCompras"
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
End Class
