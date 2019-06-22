<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuUsuario))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CleintesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AYUDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoToolStripMenuItem, Me.OperacionesToolStripMenuItem, Me.ConsultaToolStripMenuItem, Me.AYUDAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(798, 28)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CleintesToolStripMenuItem, Me.ToolStripMenuItem3, Me.SALIRToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Image = CType(resources.GetObject("MantenimientoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(112, 24)
        Me.MantenimientoToolStripMenuItem.Text = "REGISTROS"
        '
        'CleintesToolStripMenuItem
        '
        Me.CleintesToolStripMenuItem.Name = "CleintesToolStripMenuItem"
        Me.CleintesToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.CleintesToolStripMenuItem.Text = "Clientes"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(164, 6)
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem})
        Me.OperacionesToolStripMenuItem.Image = CType(resources.GetObject("OperacionesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.OperacionesToolStripMenuItem.Text = "OPERACIONES"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(121, 24)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem})
        Me.ConsultaToolStripMenuItem.Image = CType(resources.GetObject("ConsultaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(117, 24)
        Me.ConsultaToolStripMenuItem.Text = "CONSULTAS"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'AYUDAToolStripMenuItem
        '
        Me.AYUDAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AYUDAToolStripMenuItem.Image = CType(resources.GetObject("AYUDAToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AYUDAToolStripMenuItem.Name = "AYUDAToolStripMenuItem"
        Me.AYUDAToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.AYUDAToolStripMenuItem.Text = "AYUDA"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Image = CType(resources.GetObject("AcercaDeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(144, 24)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'frmMenuUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 544)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MinimizeBox = False
        Me.Name = "frmMenuUsuario"
        Me.Text = ".:. MENÚ USUARIO .:."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CleintesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AYUDAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
End Class
