Imports datos
Imports Logica
Imports System.Data.SqlClient

Imports Presentacion.frmProveedorEdicion

Public Class frmProveedor

    Dim fila As Integer
    Dim logica As New Logica.lProveedor
    Private oconexion As SqlConnection
    Private odataAdapter As SqlDataAdapter
    Private odataset As DataSet

    Private Sub btnRNuevo_Click(sender As Object, e As EventArgs) Handles btnRNuevo.Click
        frmProveedorEdicion.ShowDialog()
    End Sub

    Private Sub frmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvProveedor.DataSource = logica.listar_proveedores.Tables("Proveedores")
        dgvProveedor.Columns(1).Width = 60
        dgvProveedor.Columns(5).Width = 73
        dgvProveedor.Columns(6).Width = 170
    End Sub

    Private Sub btnREliminar_Click(sender As Object, e As EventArgs) Handles btnREliminar.Click
        fila = dgvProveedor.CurrentCell.RowIndex
        logica.PROV_NOM = dgvProveedor.Item(2, fila).Value
        If MessageBox.Show("Desea eliminar a " & logica.PROV_NOM & "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = 1 Then
            logica.PROV_RUC = dgvProveedor.Item(0, fila).Value
            If logica.eliminar_proveedor Then
                MsgBox("proveedor eliminado")
            Else
                MsgBox("no se elimino proveedor")
            End If
        End If
    End Sub

    Private Sub btnRModificar_Click(sender As Object, e As EventArgs) Handles btnRModificar.Click
        If dgvProveedor.CurrentRow Is Nothing Then
            MsgBox("seleccione una fila")
        Else
            frmProveedorEdicion.txtId.Text = dgvProveedor.Item(0, fila).Value
            frmProveedorEdicion.txtEmpresa.Text = dgvProveedor.Item(2, fila).Value
            frmProveedorEdicion.txtPersonaC.Text = dgvProveedor.Item(3, fila).Value
            frmProveedorEdicion.txtDireccion.Text = dgvProveedor.Item(4, fila).Value
            frmProveedorEdicion.txtTelefono.Text = dgvProveedor.Item(5, fila).Value
            frmProveedorEdicion.txtReferencia.Text = dgvProveedor.Item(6, fila).Value
            frmProveedorEdicion.txtId.Enabled = False
            frmProveedorEdicion.ShowDialog()
        End If
    End Sub
End Class
