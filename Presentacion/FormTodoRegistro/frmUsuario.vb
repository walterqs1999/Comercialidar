Imports datos
Imports Logica
Imports System.Data.SqlClient

Imports Presentacion.frmUsuarioEdicion

Public Class frmUsuario

    Dim logica As New Logica.lUsuario

    Private oconexion As SqlConnection
    Private odataAdapter As SqlDataAdapter
    Private odataset As DataSet


    Private Sub btnRNuevo_Click(sender As Object, e As EventArgs) Handles btnRNuevo.Click
        frmUsuarioEdicion.ShowDialog()
    End Sub

    Private Sub btnRModificar_Click(sender As Object, e As EventArgs) Handles btnRModificar.Click

        If dgvUsuarios.CurrentRow Is Nothing Then
            MsgBox("seleccione una fila")
        Else
            frmUsuarioEdicion.grbConfidencial.Visible = False
            Dim fila As Integer
            fila = dgvUsuarios.CurrentCell.RowIndex
            frmUsuarioEdicion.txtId.Text = dgvUsuarios.Item(0, fila).Value
            frmUsuarioEdicion.txtNombre.Text = dgvUsuarios.Item(1, fila).Value
            frmUsuarioEdicion.txtDireccion.Text = dgvUsuarios.Item(2, fila).Value
            frmUsuarioEdicion.txtTelefono.Text = dgvUsuarios.Item(3, fila).Value
            frmUsuarioEdicion.txtEmail.Text = dgvUsuarios.Item(4, fila).Value
            frmUsuarioEdicion.cboTipo.Text = dgvUsuarios.Item(5, fila).Value
            frmUsuarioEdicion.txtUsuario.Text = usuariousuario
            frmUsuarioEdicion.txtClave.Text = claveusuario
            frmUsuarioEdicion.txtId.Enabled = False
            frmUsuarioEdicion.ShowDialog()
        End If
    End Sub

    Private Sub btnREliminar_Click(sender As Object, e As EventArgs) Handles btnREliminar.Click
        frmUsuarioEdicion.ShowDialog()
    End Sub

    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvUsuarios.DataSource = logica.listar_Usuario.Tables("Usuario")
    End Sub
End Class
