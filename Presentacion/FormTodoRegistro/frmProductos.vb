Imports System.Data.SqlClient
Imports Logica.mdlProductos

Public Class frmProductos

    Dim fila As Integer
    Dim logica As New Logica.lProducto
    Private oconexion As SqlConnection
    Private odataAdapter As SqlDataAdapter
    Private odataset As DataSet

    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvProductos.DataSource = logica.listar_productos.Tables("productos")

        dgvProductos.Columns(0).Width = 160
        dgvProductos.Columns(1).Width = 140
        dgvProductos.Columns(2).Width = 70
        dgvProductos.Columns(3).Width = 115
        dgvProductos.Columns(4).Width = 70
        dgvProductos.Columns(5).Width = 70
        dgvProductos.Columns(6).Width = 60

        dgvProductos.Columns(7).Visible = False
        dgvProductos.Columns(8).Visible = False
        dgvProductos.Columns(9).Visible = False

    End Sub

    Private Sub btnRNuevo_Click(sender As Object, e As EventArgs) Handles btnRNuevo.Click
        valorPro = 1
        frmProductosEdicion.ShowDialog()
    End Sub

    Private Sub btnRModificar_Click(sender As Object, e As EventArgs) Handles btnRModificar.Click
        valorPro = 2
        If dgvProductos.CurrentRow Is Nothing Then
            MsgBox("seleccione una fila")
        Else
            Dim producto As New frmProductosEdicion
            logica.cargar_combo(producto.cboCategoria)
            fila = dgvProductos.CurrentCell.RowIndex

            producto.txtId.Text = dgvProductos.Item(2, fila).Value
            Dim conta As Integer
            index = 0
            conta = producto.cboCategoria.Items.Count()
            For i = 0 To conta - 1
                producto.cboCategoria.SelectedIndex = i

                If producto.cboCategoria.Text = dgvProductos.Item(3, fila).Value Then
                    index = i
                    i = conta + 1
                End If
            Next
            'producto.cboCategoria.SelectedIndex = val
            'producto.cboCategoria.Text = dgvProductos.Item(3, fila).Value
            producto.txtNombre.Text = dgvProductos.Item(1, fila).Value
            producto.txtPrecioC.Text = dgvProductos.Item(4, fila).Value
            producto.txtPrecioV.Text = dgvProductos.Item(5, fila).Value
            producto.txtStock.Text = dgvProductos.Item(6, fila).Value

            producto.ShowDialog()
        End If
    End Sub

    Private Sub btnREliminar_Click(sender As Object, e As EventArgs) Handles btnREliminar.Click
        fila = dgvProductos.CurrentCell.RowIndex
        logica.PRO_NOM = dgvProductos.Item(1, fila).Value
        If MessageBox.Show("Desea eliminar a " & logica.PRO_NOM & "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = 1 Then
            codigoPro = dgvProductos.Item(2, fila).Value
            If logica.eliminar_producto Then
                MsgBox("categoria eliminada")
            Else
                MsgBox("no se elimino categoria")
            End If
        End If
    End Sub
End Class
