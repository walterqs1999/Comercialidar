<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuAdmin))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PruductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CleintesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRODEMOVIMIENTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOVIMIENTODECOMPRASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DETALLEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLIENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOVIMIENTODEVENTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DETALLEToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLIENTEToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AYUDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoToolStripMenuItem, Me.OperacionesToolStripMenuItem, Me.ConsultaToolStripMenuItem, Me.REGISTRODEMOVIMIENTOToolStripMenuItem, Me.AYUDAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(783, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoriasToolStripMenuItem1, Me.PruductosToolStripMenuItem, Me.CleintesToolStripMenuItem, Me.ToolStripMenuItem1, Me.ProveedoresToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.ToolStripMenuItem3, Me.SALIRToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Image = CType(resources.GetObject("MantenimientoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(112, 24)
        Me.MantenimientoToolStripMenuItem.Text = "REGISTROS"
        '
        'CategoriasToolStripMenuItem1
        '
        Me.CategoriasToolStripMenuItem1.Name = "CategoriasToolStripMenuItem1"
        Me.CategoriasToolStripMenuItem1.Size = New System.Drawing.Size(167, 24)
        Me.CategoriasToolStripMenuItem1.Text = "Categorias"
        '
        'PruductosToolStripMenuItem
        '
        Me.PruductosToolStripMenuItem.Name = "PruductosToolStripMenuItem"
        Me.PruductosToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.PruductosToolStripMenuItem.Text = "Productos"
        '
        'CleintesToolStripMenuItem
        '
        Me.CleintesToolStripMenuItem.Name = "CleintesToolStripMenuItem"
        Me.CleintesToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.CleintesToolStripMenuItem.Text = "Clientes"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(164, 6)
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
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
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem, Me.ComprasToolStripMenuItem})
        Me.OperacionesToolStripMenuItem.Image = CType(resources.GetObject("OperacionesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.OperacionesToolStripMenuItem.Text = "OPERACIONES"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.UsuariosToolStripMenuItem1, Me.ProveedoresToolStripMenuItem1, Me.ToolStripMenuItem4, Me.ProductosToolStripMenuItem, Me.CategoriasToolStripMenuItem})
        Me.ConsultaToolStripMenuItem.Image = CType(resources.GetObject("ConsultaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(117, 24)
        Me.ConsultaToolStripMenuItem.Text = "CONSULTAS"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'UsuariosToolStripMenuItem1
        '
        Me.UsuariosToolStripMenuItem1.Name = "UsuariosToolStripMenuItem1"
        Me.UsuariosToolStripMenuItem1.Size = New System.Drawing.Size(160, 24)
        Me.UsuariosToolStripMenuItem1.Text = "Usuarios"
        '
        'ProveedoresToolStripMenuItem1
        '
        Me.ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1"
        Me.ProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(160, 24)
        Me.ProveedoresToolStripMenuItem1.Text = "Proveedores"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(157, 6)
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.CategoriasToolStripMenuItem.Text = "Categorias"
        '
        'REGISTRODEMOVIMIENTOToolStripMenuItem
        '
        Me.REGISTRODEMOVIMIENTOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MOVIMIENTODECOMPRASToolStripMenuItem, Me.MOVIMIENTODEVENTASToolStripMenuItem})
        Me.REGISTRODEMOVIMIENTOToolStripMenuItem.Image = CType(resources.GetObject("REGISTRODEMOVIMIENTOToolStripMenuItem.Image"), System.Drawing.Image)
        Me.REGISTRODEMOVIMIENTOToolStripMenuItem.Name = "REGISTRODEMOVIMIENTOToolStripMenuItem"
        Me.REGISTRODEMOVIMIENTOToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.REGISTRODEMOVIMIENTOToolStripMenuItem.Text = "REGISTRO DE MOVIMIENTO"
        '
        'MOVIMIENTODECOMPRASToolStripMenuItem
        '
        Me.MOVIMIENTODECOMPRASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DETALLEToolStripMenuItem, Me.CLIENTEToolStripMenuItem})
        Me.MOVIMIENTODECOMPRASToolStripMenuItem.Name = "MOVIMIENTODECOMPRASToolStripMenuItem"
        Me.MOVIMIENTODECOMPRASToolStripMenuItem.Size = New System.Drawing.Size(264, 24)
        Me.MOVIMIENTODECOMPRASToolStripMenuItem.Text = "MOVIMIENTO DE COMPRAS"
        '
        'DETALLEToolStripMenuItem
        '
        Me.DETALLEToolStripMenuItem.Name = "DETALLEToolStripMenuItem"
        Me.DETALLEToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.DETALLEToolStripMenuItem.Text = "DETALLE"
        '
        'CLIENTEToolStripMenuItem
        '
        Me.CLIENTEToolStripMenuItem.Name = "CLIENTEToolStripMenuItem"
        Me.CLIENTEToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.CLIENTEToolStripMenuItem.Text = "PROVEEDOR"
        '
        'MOVIMIENTODEVENTASToolStripMenuItem
        '
        Me.MOVIMIENTODEVENTASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DETALLEToolStripMenuItem1, Me.CLIENTEToolStripMenuItem1})
        Me.MOVIMIENTODEVENTASToolStripMenuItem.Name = "MOVIMIENTODEVENTASToolStripMenuItem"
        Me.MOVIMIENTODEVENTASToolStripMenuItem.Size = New System.Drawing.Size(264, 24)
        Me.MOVIMIENTODEVENTASToolStripMenuItem.Text = "MOVIMIENTO DE VENTAS"
        '
        'DETALLEToolStripMenuItem1
        '
        Me.DETALLEToolStripMenuItem1.Name = "DETALLEToolStripMenuItem1"
        Me.DETALLEToolStripMenuItem1.Size = New System.Drawing.Size(136, 24)
        Me.DETALLEToolStripMenuItem1.Text = "DETALLE"
        '
        'CLIENTEToolStripMenuItem1
        '
        Me.CLIENTEToolStripMenuItem1.Name = "CLIENTEToolStripMenuItem1"
        Me.CLIENTEToolStripMenuItem1.Size = New System.Drawing.Size(136, 24)
        Me.CLIENTEToolStripMenuItem1.Text = "CLIENTE"
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
        'frmMenuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 454)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MinimizeBox = False
        Me.Name = "frmMenuAdmin"
        Me.Text = ".:. MENÚ ADMINISTRADOR .:."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PruductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CleintesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REGISTRODEMOVIMIENTOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOVIMIENTODECOMPRASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DETALLEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLIENTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOVIMIENTODEVENTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DETALLEToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CLIENTEToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AYUDAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
End Class
