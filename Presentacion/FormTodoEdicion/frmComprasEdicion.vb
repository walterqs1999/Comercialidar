Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports Logica
Imports datos

Public Class frmComprasEdicion
    Dim comLogi As New Logica.lCompras
    Dim usuDato As New datos.dCompra
    Dim con As New datos.dConexion
    Dim detarticulos As String
    Dim rpta As Integer
    Dim r As Integer

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click

        Dim conta As Integer = 0

        rpta = MessageBox.Show("Deseas guardar..?", "Registro Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If rpta = vbYes Then
            comLogi.CABCO_NUMDOC = txtNumeroF.Text
            comLogi.CABCO_TIPODOC = cboTipo.Text
            comLogi.PROV_RUC = txtRUCDNI.Text
            comLogi.USU_DNI = dniusuario
            comLogi.CABCO_TOTAL = txtTotal.Text
            comLogi.CABCO_SUBT = txtSubT.Text
            comLogi.CABCO_IGV = txtIgv.Text
            comLogi.CABCO_FECHA = dtpFecha.Value

            If comLogi.registrar_cabeceraC Then
                conta = 1
            End If

            Dim Fila As DataGridViewRow = New DataGridViewRow
            'Dim Fila1 = dgvDatos.RowCount
            Try
                For Each Fila In dgvDatos.Rows
                    'For r = 0 To Fila

                    'detarticulos = dgvDatos.Rows(Fila).Cells(0).Value.ToString()
                    'detarticulos = dgvDatos.Rows(Fila).Cells[0].Value.ToString()

                    comLogi.CABCO_ID = Convert.ToInt64(Fila.Cells("id").Value.ToString())
                    'comLogi.CABCO_ID = Convert.ToInt64(dgvDatos.Rows(Fila1).Cells(0).Value.ToString())
                    comLogi.DETCO_TIPODOC = Convert.ToString(Fila.Cells("tipo").Value.ToString())
                    'comLogi.DETCO_TIPODOC = Convert.ToString(dgvDatos.Rows(Fila1).Cells(1).Value.ToString())
                    comLogi.PRO_COD = Convert.ToInt64(Fila.Cells("codigo").Value.ToString())
                    'comLogi.PRO_COD = Convert.ToInt64(dgvDatos.Rows(Fila1).Cells(2).Value.ToString())
                    comLogi.DETCO_PCU = Convert.ToDecimal(Fila.Cells("pcu").Value.ToString())
                    'comLogi.DETCO_PCU = Convert.ToDecimal(dgvDatos.Rows(Fila1).Cells(3).Value.ToString())
                    comLogi.DETCO_PVU = Convert.ToDecimal(Fila.Cells("pvu").Value.ToString())
                    'comLogi.DETCO_PCU = Convert.ToDecimal(dgvDatos.Rows(Fila1).Cells(4).Value.ToString())
                    comLogi.DETCO_CANTIDAD = Convert.ToInt64(Fila.Cells("cantidad").Value.ToString())
                    'comLogi.DETCO_CANTIDAD = Convert.ToInt64(dgvDatos.Rows(Fila1).Cells(5).Value.ToString())
                    comLogi.DETCO_TOTALPRO = Convert.ToDecimal(Fila.Cells("total").Value.ToString())
                    'comLogi.DETCO_TOTALPRO = Convert.ToDecimal(dgvDatos.Rows(Fila1).Cells(6).Value.ToString())

                    If comLogi.registrar_detalleC Then
                        conta = conta + 1
                    End If
                    ' Next
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If conta = 4 Then
            MsgBox("compra registrada")
        End If
    End Sub
    Private Sub txtRUCDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRUCDNI.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                If comLogi.proRegistrado(txtRUCDNI.Text) = True Then
                    txtNombres.Text = nomProv
                    txtDireccion.Text = dirProv
                Else
                    MsgBox("Proveedor no existe")
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                If comLogi.productoRegistrado(txtCodigo.Text) = True Then
                    txtDescripcion.Text = nomProducto
                    txtUnitarioC.Text = pcuProducto
                    txtUnitarioV.Text = pvuProducto
                Else
                    MsgBox("Producto no existe")
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim total, igv, subt As Decimal
        Dim con As Double
        con = Val(txtTotal.Text)
        total = txtUnitarioC.Text * txtCantidad.Text
        'mdlStock = mdlStock + txtCantidad.Text

        dgvDatos.Rows.Add(17, cboTipo.Text, txtCodigo.Text, txtDescripcion.Text, txtUnitarioC.Text, txtUnitarioV.Text, txtCantidad.Text, total)

        con = con + total
        subt = con / 1.18
        igv = con - subt

        If cboTipo.Text = "FACTURA" Then
            txtSubT.Text = subt
            txtIgv.Text = igv
        Else
            txtSubT.Text = 0
            txtIgv.Text = 0
        End If

        txtTotal.Text = con


        txtCodigo.Clear()
        txtDescripcion.Clear()
        txtCantidad.Clear()
        txtUnitarioC.Clear()
        txtUnitarioV.Clear()
        txtCodigo.Focus()
    End Sub

    Private Sub frmComprasEdicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNumeroF.Text = docuid
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNumeroF.Text = docuid
    End Sub
End Class
