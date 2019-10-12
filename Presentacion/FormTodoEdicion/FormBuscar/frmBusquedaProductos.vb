Imports Logica

Public Class frmBusquedaProductos
    Dim ventas As New frmVentasEdicion
    Dim proLogica As New lProducto

    Dim fila As Integer

    Private Sub frmBusquedaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvProductosB.DataSource = proLogica.listar_productos.Tables("productos")

        dgvProductosB.Columns(0).Visible = False
        dgvProductosB.Columns(1).Width = 220
        dgvProductosB.Columns(2).Width = 70
        dgvProductosB.Columns(3).Width = 180
        dgvProductosB.Columns(4).Visible = False
        dgvProductosB.Columns(5).Width = 70
        dgvProductosB.Columns(6).Width = 70
        dgvProductosB.Columns(7).Visible = False
        dgvProductosB.Columns(8).Visible = False
        dgvProductosB.Columns(9).Visible = False
    End Sub
    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click

        'fila = dgvProductosB.CurrentRow.Index

        'ventas.txtCodigo.Text = "Hola" 'dgvProductosB.Rows(fila).Cells(1).Value.ToString()
        'ventas.txtDescripcion.Text = "hola" 'Convert.ToString(dgvProductosB.Rows(fila).Cells(1).Value.ToString())
        'ventas.txtPrecioVenta.Text = "hola" 'dgvProductosB.Rows(fila).Cells(5).Value
        'ventas.txtStock.Text = "hola" 'dgvProductosB.Rows(fila).Cells(6).Value
        'ventas.txtCantidad.Focus()
        'ventas.Refresh()
        'Me.Close()

        Dim currentRow = dgvProductosB.CurrentRow

        Try
            ventas.txtCodigo.Text = currentRow.Cells(1).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvProductosB_DoubleClick(sender As Object, e As EventArgs) Handles dgvProductosB.DoubleClick
        Dim codigo, stock As Integer
        Dim descripcion As String
        Dim precioventa As Decimal

        fila = dgvProductosB.CurrentRow.Index

        codigo = dgvProductosB.Rows(fila).Cells(2).Value.ToString()
        descripcion = dgvProductosB.Rows(fila).Cells(1).Value.ToString()
        precioventa = dgvProductosB.Rows(fila).Cells(5).Value.ToString()
        stock = dgvProductosB.Rows(fila).Cells(6).Value.ToString()

        ventas.txtCodigo.Text = codigo
        ventas.txtDescripcion.Text = descripcion
        ventas.txtPrecioVenta.Text = precioventa
        ventas.txtStock.Text = stock

        Me.Close()
    End Sub
End Class
