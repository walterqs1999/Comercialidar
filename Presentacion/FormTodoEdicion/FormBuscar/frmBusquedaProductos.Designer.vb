<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaProductos
    Inherits Presentacion.frmTodoBusqueda

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
        Me.dgvProductosB = New System.Windows.Forms.DataGridView()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductosB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(205, 19)
        Me.Label1.Size = New System.Drawing.Size(324, 25)
        Me.Label1.Text = "BUSQUEDA DE PRODUCTOS"
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnBuscar.Location = New System.Drawing.Point(357, 471)
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(49, 481)
        '
        'btnImportar
        '
        Me.btnImportar.FlatAppearance.BorderSize = 0
        Me.btnImportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnImportar.Location = New System.Drawing.Point(546, 468)
        '
        'dgvProductosB
        '
        Me.dgvProductosB.AllowDrop = True
        Me.dgvProductosB.AllowUserToAddRows = False
        Me.dgvProductosB.AllowUserToDeleteRows = False
        Me.dgvProductosB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductosB.Location = New System.Drawing.Point(49, 60)
        Me.dgvProductosB.MultiSelect = False
        Me.dgvProductosB.Name = "dgvProductosB"
        Me.dgvProductosB.ReadOnly = True
        Me.dgvProductosB.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProductosB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductosB.Size = New System.Drawing.Size(655, 380)
        Me.dgvProductosB.TabIndex = 26
        '
        'frmBusquedaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(759, 527)
        Me.Controls.Add(Me.dgvProductosB)
        Me.Name = "frmBusquedaProductos"
        Me.Controls.SetChildIndex(Me.btnImportar, 0)
        Me.Controls.SetChildIndex(Me.txtBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnCerrar, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.dgvProductosB, 0)
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductosB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents dgvProductosB As DataGridView
End Class
