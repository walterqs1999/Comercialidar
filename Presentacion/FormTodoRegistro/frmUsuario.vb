Imports Logica
Imports System.Data.SqlClient

Public Class frmUsuario

    Dim fila As Integer
    Dim logica As New lUsuario
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
            Dim usuario As New frmUsuarioEdicion
            fila = dgvUsuarios.CurrentCell.RowIndex
            usuario.txtId.Text = dgvUsuarios.Item(1, fila).Value
            usuario.txtNombre.Text = dgvUsuarios.Item(0, fila).Value
            usuario.txtDireccion.Text = dgvUsuarios.Item(2, fila).Value
            usuario.txtTelefono.Text = dgvUsuarios.Item(3, fila).Value
            usuario.txtEmail.Text = dgvUsuarios.Item(4, fila).Value
            usuario.cboTipo.Text = dgvUsuarios.Item(5, fila).Value
            usuario.txtUsuario.Text = usuariousuario
            usuario.txtClave.Text = claveusuario
            usuario.txtId.Enabled = False
            usuario.btnGenerar.Enabled = False
            usuario.txtClave.Visible = False
            dniusuario = dgvUsuarios.Item(1, fila).Value
            logica.ObtenerImagen(usuario.PictureBox1.Image)
            usuario.ShowDialog()
        End If
    End Sub

    Private Sub btnREliminar_Click(sender As Object, e As EventArgs) Handles btnREliminar.Click
        fila = dgvUsuarios.CurrentCell.RowIndex
        logica.USU_NOM = dgvUsuarios.Item(0, fila).Value
        If MessageBox.Show("Desea eliminar a " & logica.USU_NOM & "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = 1 Then
            logica.USU_DNI = dgvUsuarios.Item(1, fila).Value
            If logica.eliminar_usuario Then
                MsgBox("usuario eliminado")
            Else
                MsgBox("no se elimino usuario")
            End If
        End If
    End Sub

    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvUsuarios.DataSource = logica.listar_Usuario.Tables("Usuario")
        dgvUsuarios.Columns(0).Width = 160
        dgvUsuarios.Columns(1).Width = 60
        dgvUsuarios.Columns(4).Width = 170

        dgvUsuarios.Columns(6).Visible = False
        dgvUsuarios.Columns(7).Visible = False
        dgvUsuarios.Columns(8).Visible = False
    End Sub
End Class
