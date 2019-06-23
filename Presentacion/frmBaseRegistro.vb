Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmBaseRegistro

    'Declaracion de variables para el manejo de Tablas
    Public oConexion As SqlConnection
    Public oDataAdapter As SqlDataAdapter
    Public oDataTable As DataTable
    Public oDataSet As DataSet
    Public oCommand As SqlCommand

    'Declarcion de variables alternas
    Public StrSql As String
    Dim rpta As Integer
    Dim contador As Integer = 0
    Public operaciones As String

    Public Sub LimpiarTextoGrupo()
        'recorremos todos los controles del formulario que enviamos
        For Each Caja As Control In Me.grbDatos.Controls
            'filtramos solo aquellos de tipo texbox
            If TypeOf Caja Is TextBox Then
                Caja.Text = ""
            End If

            If TypeOf Caja Is ComboBox Then
                Caja.Text = ""
            End If

        Next
    End Sub

    Public Sub EstadoBotones(ByVal estado As Boolean)
        btnNuevo.Enabled = estado
        btnGrabar.Enabled = Not estado
        btnCancelar.Enabled = Not estado
        btnModificar.Enabled = estado
        btnEliminar.Enabled = estado
        btnSalir.Enabled = estado
    End Sub

    Public Sub EstadoTextos(ByVal estado As Boolean)
        For Each caja As Control In Me.grbDatos.Controls
            If TypeOf caja Is TextBox Then
                caja.Enabled = estado
            End If
            If TypeOf caja Is ComboBox Then
                caja.Enabled = estado
            End If
        Next
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        operaciones = "N"
        LimpiarTextoGrupo()
        EstadoBotones(False)
        EstadoTextos(True)
        txtId.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        rpta = MessageBox.Show("¿Desea Cancelar la Operación?", "Registro Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rpta = vbYes Then
            EstadoBotones(True)
            EstadoTextos(False)
            LimpiarTextoGrupo()
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        operaciones = "M"
        EstadoBotones(False)
        EstadoTextos(True)
        txtId.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        rpta = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rpta = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub grbDatos_Enter(sender As Object, e As EventArgs) Handles grbDatos.Enter

    End Sub
End Class