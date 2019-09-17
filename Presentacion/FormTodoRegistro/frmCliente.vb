Imports System.Data.SqlClient

Public Class frmCliente

    Dim fila As Integer
    Dim logica As New Logica.lCliente
    Private oconexion As SqlConnection
    Private odataAdapter As SqlDataAdapter
    Private odataset As DataSet

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvClientes.DataSource = logica.listar_clientes.Tables("Clientes")
        dgvClientes.Columns(0).Width = 200
        dgvClientes.Columns(1).Width = 180
        dgvClientes.Columns(2).Width = 100

        dgvClientes.Columns(5).Visible = False
        dgvClientes.Columns(6).Visible = False
    End Sub

    Private Sub btnREliminar_Click(sender As Object, e As EventArgs) Handles btnREliminar.Click
        fila = dgvClientes.CurrentCell.RowIndex
        logica.CLI_NOM = dgvClientes.Item(1, fila).Value
        If MessageBox.Show("Desea eliminar a " & logica.CLI_NOM & "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = 1 Then
            logica.CLI_DNI = dgvClientes.Item(2, fila).Value
            If logica.eliminar_cliente Then
                MsgBox("cliente eliminado")
            Else
                MsgBox("no se elimino cliente")
            End If
        End If
    End Sub

    Private Sub btnRNuevo_Click(sender As Object, e As EventArgs) Handles btnRNuevo.Click
        frmClienteEdicion.ShowDialog()
    End Sub

    Private Sub btnRModificar_Click(sender As Object, e As EventArgs) Handles btnRModificar.Click
        If dgvClientes.CurrentRow Is Nothing Then
            MsgBox("seleccione una fila")
        Else
            fila = dgvClientes.CurrentCell.RowIndex

            frmClienteEdicion.txtId.Text = dgvClientes.Item(2, fila).Value
            frmClienteEdicion.txtNombre.Text = dgvClientes.Item(1, fila).Value
            frmClienteEdicion.txtDireccion.Text = dgvClientes.Item(3, fila).Value
            frmClienteEdicion.txtTelefono.Text = dgvClientes.Item(4, fila).Value
            frmClienteEdicion.txtId.Enabled = False
            frmClienteEdicion.ShowDialog()
        End If
    End Sub
End Class
