Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Logica


Public Class frmTodoEdicion

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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        rpta = MessageBox.Show("¿Desea Cancelar la Operación?", "Registro Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rpta = vbYes Then
            EstadoTextos(False)
            LimpiarTextoGrupo()
        End If
    End Sub

    Private Sub frmBaseRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If valor = 1 Then
            btnNuevob.Visible = True
            btnGrabarb.Visible = True
            btnModificarb.Visible = False
            valor = 0
        End If
        If valor = 2 Then
            btnModificarb.Visible = True
            btnNuevob.Visible = False
            btnGrabarb.Visible = False
            valor = 0
        End If
    End Sub

    Private Sub btnNuevob_Click(sender As Object, e As EventArgs)
        operaciones = "N"
        LimpiarTextoGrupo()
        EstadoTextos(True)
        txtId.Focus()
    End Sub

    Private Sub btnModificarb_Click(sender As Object, e As EventArgs)
        operaciones = "M"
        EstadoTextos(True)
        txtId.Enabled = False
    End Sub

    Private Sub btnNuevob_Click_1(sender As Object, e As EventArgs) Handles btnNuevob.Click
        LimpiarTextoGrupo()
        EstadoTextos(True)
    End Sub
End Class