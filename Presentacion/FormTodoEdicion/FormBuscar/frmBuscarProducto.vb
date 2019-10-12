Imports Logica

Public Class frmbuscarProducto

    Dim proLogica As New lProducto

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim rpta As Integer
        rpta = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If rpta = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub frmbuscarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim ventas As New frmVentasEdicion
        Dim fila As Integer = dgvProductosB.CurrentCell.RowIndex

        ventas.txtCodigo.Text = dgvProductosB.Item(2, fila).Value
        ventas.txtDescripcion.Text = dgvProductosB.Item(1, fila).Value
        ventas.txtPrecioVenta.Text = dgvProductosB.Item(5, fila).Value
        ventas.txtStock.Text = dgvProductosB.Item(6, fila).Value
        ventas.txtCantidad.Focus()
        Me.Close()
    End Sub

    Private Sub btnImportacion_Click(sender As Object, e As EventArgs) Handles btnImportacion.Click
        Dim ventas As New frmVentasEdicion
        Dim fila As Integer
        fila = dgvProductosB.CurrentRow.Index

        ventas.txtCodigo.Text = dgvProductosB.Rows(fila).Cells(2).Value
        ventas.txtDescripcion.Text = Convert.ToString(dgvProductosB.Item(1, fila).Value)
        ventas.txtPrecioVenta.Text = Convert.ToString(dgvProductosB.Item(5, fila).Value)
        ventas.txtStock.Text = Convert.ToString(dgvProductosB.Item(6, fila).Value)
        ventas.txtCantidad.Focus()
        Me.Hide()
    End Sub
End Class