<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTodoEdicion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTodoEdicion))
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModificarb = New System.Windows.Forms.Button()
        Me.btnGrabarb = New System.Windows.Forms.Button()
        Me.btnNuevob = New System.Windows.Forms.Button()
        Me.grbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.txtId)
        Me.grbDatos.Controls.Add(Me.Label1)
        Me.grbDatos.Location = New System.Drawing.Point(15, 12)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Size = New System.Drawing.Size(569, 186)
        Me.grbDatos.TabIndex = 54
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos :"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(449, 19)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(403, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Label1"
        '
        'btnModificarb
        '
        Me.btnModificarb.Image = CType(resources.GetObject("btnModificarb.Image"), System.Drawing.Image)
        Me.btnModificarb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarb.Location = New System.Drawing.Point(203, 242)
        Me.btnModificarb.Name = "btnModificarb"
        Me.btnModificarb.Size = New System.Drawing.Size(150, 36)
        Me.btnModificarb.TabIndex = 67
        Me.btnModificarb.Text = "&Modificar"
        Me.btnModificarb.UseVisualStyleBackColor = True
        '
        'btnGrabarb
        '
        Me.btnGrabarb.Image = CType(resources.GetObject("btnGrabarb.Image"), System.Drawing.Image)
        Me.btnGrabarb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrabarb.Location = New System.Drawing.Point(108, 242)
        Me.btnGrabarb.Name = "btnGrabarb"
        Me.btnGrabarb.Size = New System.Drawing.Size(150, 36)
        Me.btnGrabarb.TabIndex = 65
        Me.btnGrabarb.Text = "&Grabar"
        Me.btnGrabarb.UseVisualStyleBackColor = True
        '
        'btnNuevob
        '
        Me.btnNuevob.Image = CType(resources.GetObject("btnNuevob.Image"), System.Drawing.Image)
        Me.btnNuevob.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevob.Location = New System.Drawing.Point(307, 242)
        Me.btnNuevob.Name = "btnNuevob"
        Me.btnNuevob.Size = New System.Drawing.Size(150, 36)
        Me.btnNuevob.TabIndex = 64
        Me.btnNuevob.Text = "&Nuevo"
        Me.btnNuevob.UseVisualStyleBackColor = True
        '
        'frmTodoEdicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 335)
        Me.Controls.Add(Me.btnModificarb)
        Me.Controls.Add(Me.btnGrabarb)
        Me.Controls.Add(Me.btnNuevob)
        Me.Controls.Add(Me.grbDatos)
        Me.Name = "frmTodoEdicion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTodoEdicion"
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents grbDatos As GroupBox
    Public WithEvents txtId As TextBox
    Public WithEvents Label1 As Label
    Public WithEvents btnGrabarb As Button
    Public WithEvents btnModificarb As Button
    Public WithEvents btnNuevob As Button
End Class
