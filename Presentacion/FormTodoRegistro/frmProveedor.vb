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

    Dim proveedor As New frmProveedorEdicion

    Private Sub btnRNuevo_Click(sender As Object, e As EventArgs) Handles btnRNuevo.Click
        frmProveedorEdicion.ShowDialog()
    End Sub

    Private Sub frmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvProveedor.DataSource = logica.listar_proveedores.Tables("Proveedores")
        dgvProveedor.Columns(0).Width = 143
        dgvProveedor.Columns(1).Width = 110
        dgvProveedor.Columns(2).Width = 90
        dgvProveedor.Columns(3).Width = 110
        dgvProveedor.Columns(4).Width = 70
        dgvProveedor.Columns(5).Width = 170
        dgvProveedor.Columns(6).Width = 80

        dgvProveedor.Columns(7).Visible = False
        dgvProveedor.Columns(8).Visible = False
    End Sub

    Private Sub btnREliminar_Click(sender As Object, e As EventArgs) Handles btnREliminar.Click
        fila = dgvProveedor.CurrentCell.RowIndex
        logica.PROV_NOM = dgvProveedor.Item(1, fila).Value
        If MessageBox.Show("Desea eliminar a " & logica.PROV_NOM & "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = 1 Then
            logica.PROV_RUC = dgvProveedor.Item(2, fila).Value
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
            fila = dgvProveedor.CurrentCell.RowIndex

            proveedor.txtId.Text = dgvProveedor.Item(2, fila).Value
            proveedor.txtEmpresa.Text = dgvProveedor.Item(1, fila).Value
            proveedor.txtPersonaC.Text = dgvProveedor.Item(3, fila).Value
            proveedor.txtDireccion.Text = dgvProveedor.Item(4, fila).Value
            proveedor.txtTelefono.Text = dgvProveedor.Item(6, fila).Value
            proveedor.txtReferencia.Text = dgvProveedor.Item(5, fila).Value
            proveedor.ShowDialog()
        End If
    End Sub
End Class
