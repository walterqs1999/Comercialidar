Imports System.Data.SqlClient
Imports System.Drawing.Brush

Public Class frmTodoDocumentos

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

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim rpta As Integer
        rpta = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If rpta = vbYes Then
            Me.Close()
        End If
    End Sub

    Public Sub Tipo()
        If cboTipo.Text = "BOLETA" Then
            txtSubT.Visible = False
            txtIgv.Visible = False
            lblSubT.Visible = False
            lblIgv.Visible = False
            lbDNI.Visible = True
            lbRUC.Visible = False
        Else
            txtSubT.Visible = True
            txtIgv.Visible = True
            lblSubT.Visible = True
            lblIgv.Visible = True
            lbDNI.Visible = False
            lbRUC.Visible = True
        End If
    End Sub

    Public Sub LimpiarTexto()
        'recorremos todos los controles del formulario que enviamos
        For Each Control As Control In Me.Controls
            'filtramos solo aquellos de tipo texbox
            If TypeOf Control Is TextBox Then
                Control.Text = ""
            End If
        Next
    End Sub

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

        For Each Caja As Control In Me.grbDetalle.Controls
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
        btnComprar.Enabled = Not estado
        btnCancelar.Enabled = Not estado
        btnEliminar.Enabled = Not estado
        btnAgregar.Enabled = Not estado
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

        For Each caja As Control In Me.grbDetalle.Controls
            If TypeOf caja Is TextBox Then
                caja.Enabled = estado
            End If
            If TypeOf caja Is ComboBox Then
                caja.Enabled = estado
            End If
        Next
        For Each caja As Control In Me.Controls
            'filtramos solo aquellos de tipo texbox
            If TypeOf caja Is TextBox Then
                caja.Enabled = estado
            End If
        Next
    End Sub

    Private Sub frmTodoDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstadoBotones(True)
        EstadoTextos(False)
        LimpiarTextoGrupo()
        dtpFecha.Value = DateTime.Now
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarTextoGrupo()
        EstadoBotones(False)
        EstadoTextos(True)
        Tipo()
        txtNumeroF.Enabled = False
        txtDetalle.Enabled = False
        txtDetalle.Clear()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        rpta = MessageBox.Show("¿Desea Cancelar la Operación?", "Registro Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rpta = vbYes Then
            EstadoBotones(True)
            EstadoTextos(False)
            LimpiarTextoGrupo()
            txtDetalle.Clear()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        rpta = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rpta = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        Tipo()
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        EstadoTextos(False)
        EstadoBotones(True)
    End Sub

    Private Sub btnVistaPrevia_Click(sender As Object, e As EventArgs) Handles btnVistaPrevia.Click

    End Sub

    'Private Sub pdt_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdt.PrintPage
    '    Dim x, y As Integer

    '    x = e.MarginBounds.Left
    '    y = e.MarginBounds.Top
    '    Dim Brush As New SolidBrush(txtDetalle.ForeColor)

    '    e.Graphics.DrawString(txtDetalle.Font, Color.FromArgb(90, 0, 50, 255), Brush, x, y)
    'End Sub
End Class