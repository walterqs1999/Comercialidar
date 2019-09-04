Imports System.Data.SqlClient
Imports Logica.mdlCategorias

Public Class frmCategorias

    Dim fila As Integer
    Dim logica As New Logica.lCategorias
    Private oconexion As SqlConnection
    Private odataAdapter As SqlDataAdapter
    Private odataset As DataSet

    Private Sub frmCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCategorias.DataSource = logica.listar_categorias.Tables("Categorias")
        dgvCategorias.Columns(0).Width = 100
        dgvCategorias.Columns(1).Width = 400
        dgvCategorias.Columns(2).Width = 200
    End Sub

    Private Sub btnRNuevo_Click(sender As Object, e As EventArgs) Handles btnRNuevo.Click
        frmCategoriaEdicion.ShowDialog()
    End Sub

    Private Sub btnRModificar_Click(sender As Object, e As EventArgs) Handles btnRModificar.Click
        If dgvCategorias.CurrentRow Is Nothing Then
            MsgBox("seleccione una fila")
        Else
            fila = dgvCategorias.CurrentCell.RowIndex

            frmCategoriaEdicion.txtId.Text = dgvCategorias.Item(0, fila).Value
            frmCategoriaEdicion.txtNombre.Text = dgvCategorias.Item(1, fila).Value
            frmCategoriaEdicion.txtId.Enabled = False
            frmCategoriaEdicion.ShowDialog()
        End If
    End Sub

    Private Sub btnREliminar_Click(sender As Object, e As EventArgs) Handles btnREliminar.Click
        fila = dgvCategorias.CurrentCell.RowIndex
        logica.CAT_NOM = dgvCategorias.Item(1, fila).Value
        If MessageBox.Show("Desea eliminar a " & logica.CAT_NOM & "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = 1 Then
            codigo = dgvCategorias.Item(0, fila).Value
            If logica.eliminar_categoria Then
                MsgBox("Producto eliminado")
            Else
                MsgBox("no se elimino Producto")
            End If
        End If
    End Sub
End Class
