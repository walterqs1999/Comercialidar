Imports datos
Imports Logica
Imports System.Data.SqlClient

Public Class frmUsuario

    Dim logica As New Logica.lUsuario

    Private oconexion As SqlConnection
    Private odataAdapter As SqlDataAdapter
    Private odataset As DataSet

    Public Sub cargar_datagrid()
        dgvUsuarios.DataSource = logica.listar_Usuario.Tables("Usuario")
    End Sub
    Private Sub btnRNuevo_Click(sender As Object, e As EventArgs) Handles btnRNuevo.Click
        frmBaseEdicion.ShowDialog()
    End Sub

    Private Sub btnRGrabar_Click(sender As Object, e As EventArgs) Handles btnRGrabar.Click
        frmBaseEdicion.ShowDialog()
    End Sub

    Private Sub btnRModificar_Click(sender As Object, e As EventArgs) Handles btnRModificar.Click
        frmBaseEdicion.ShowDialog()
    End Sub

    Private Sub btnREliminar_Click(sender As Object, e As EventArgs) Handles btnREliminar.Click
        frmBaseEdicion.ShowDialog()
    End Sub

    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_datagrid()
    End Sub
End Class
