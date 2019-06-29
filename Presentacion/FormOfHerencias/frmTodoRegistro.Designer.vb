<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTodoRegistro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTodoRegistro))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRNuevo = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.btnRModificar = New System.Windows.Forms.Button()
        Me.btnREliminar = New System.Windows.Forms.Button()
        Me.btnRSalir = New System.Windows.Forms.Button()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(331, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "label1"
        '
        'btnRNuevo
        '
        Me.btnRNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnRNuevo.FlatAppearance.BorderSize = 0
        Me.btnRNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnRNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRNuevo.ForeColor = System.Drawing.Color.White
        Me.btnRNuevo.Image = CType(resources.GetObject("btnRNuevo.Image"), System.Drawing.Image)
        Me.btnRNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRNuevo.Location = New System.Drawing.Point(931, 77)
        Me.btnRNuevo.Name = "btnRNuevo"
        Me.btnRNuevo.Size = New System.Drawing.Size(155, 49)
        Me.btnRNuevo.TabIndex = 8
        Me.btnRNuevo.Text = "NUEVO"
        Me.btnRNuevo.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1064, 12)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(22, 24)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrar.TabIndex = 13
        Me.btnCerrar.TabStop = False
        '
        'btnRModificar
        '
        Me.btnRModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnRModificar.FlatAppearance.BorderSize = 0
        Me.btnRModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnRModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRModificar.ForeColor = System.Drawing.Color.White
        Me.btnRModificar.Image = CType(resources.GetObject("btnRModificar.Image"), System.Drawing.Image)
        Me.btnRModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRModificar.Location = New System.Drawing.Point(931, 206)
        Me.btnRModificar.Name = "btnRModificar"
        Me.btnRModificar.Size = New System.Drawing.Size(155, 49)
        Me.btnRModificar.TabIndex = 15
        Me.btnRModificar.Text = "MODIFICAR"
        Me.btnRModificar.UseVisualStyleBackColor = False
        '
        'btnREliminar
        '
        Me.btnREliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnREliminar.FlatAppearance.BorderSize = 0
        Me.btnREliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnREliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnREliminar.ForeColor = System.Drawing.Color.White
        Me.btnREliminar.Image = CType(resources.GetObject("btnREliminar.Image"), System.Drawing.Image)
        Me.btnREliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnREliminar.Location = New System.Drawing.Point(931, 337)
        Me.btnREliminar.Name = "btnREliminar"
        Me.btnREliminar.Size = New System.Drawing.Size(155, 49)
        Me.btnREliminar.TabIndex = 16
        Me.btnREliminar.Text = "ELIMINAR"
        Me.btnREliminar.UseVisualStyleBackColor = False
        '
        'btnRSalir
        '
        Me.btnRSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnRSalir.FlatAppearance.BorderSize = 0
        Me.btnRSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnRSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRSalir.ForeColor = System.Drawing.Color.White
        Me.btnRSalir.Image = CType(resources.GetObject("btnRSalir.Image"), System.Drawing.Image)
        Me.btnRSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRSalir.Location = New System.Drawing.Point(931, 466)
        Me.btnRSalir.Name = "btnRSalir"
        Me.btnRSalir.Size = New System.Drawing.Size(155, 49)
        Me.btnRSalir.TabIndex = 17
        Me.btnRSalir.Text = "SALIR"
        Me.btnRSalir.UseVisualStyleBackColor = False
        '
        'frmTodoRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 620)
        Me.Controls.Add(Me.btnRSalir)
        Me.Controls.Add(Me.btnREliminar)
        Me.Controls.Add(Me.btnRModificar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnRNuevo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTodoRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTodoRegistro"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCerrar As PictureBox
    Public WithEvents Label1 As Label
    Public WithEvents btnRNuevo As Button
    Public WithEvents btnRModificar As Button
    Public WithEvents btnREliminar As Button
    Public WithEvents btnRSalir As Button
End Class
