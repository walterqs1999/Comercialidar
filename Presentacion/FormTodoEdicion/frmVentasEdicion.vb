Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports Logica
Imports datos

Public Class frmVentasEdicion

    Dim venLogi As New Logica.lVentas
    Dim comLogi As New Logica.lCompras
    Dim usuDato As New datos.dVenta
    Dim con As New datos.dConexion

    Dim detarticulos As String
    Dim rpta As Integer
    Dim r As Integer

    Private Sub frmVentasEdicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboTipo.SelectedIndex = 0
    End Sub

    Private Sub txtRUCDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRUCDNI.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                If venLogi.cliRegistrado(txtRUCDNI.Text) = True Then
                    txtNombres.Text = nomCli
                    txtDireccion.Text = dirCli
                Else
                    MsgBox("Cliente no existe")
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
                    txtPrecioVenta.Text = pvuProducto
                    txtStock.Text = stockProducto
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
        Dim id As Integer

        con = Val(txtTotal.Text)
        total = Val(txtPrecioVenta.Text * txtCantidad.Text)

        stockProducto = stockProducto - txtCantidad.Text

        If venLogi.iddocumento Then
            id = iddocc
        End If

        dgvDatos.Rows.Add(id, txtNumeroF.Text, cboTipo.Text, txtCodigo.Text, txtDescripcion.Text, txtPrecioVenta.Text, txtCantidad.Text, total, stockProducto)

        con = con + total
        subt = con / 1.18
        igv = con - subt

        If cboTipo.Text = "FACTURA" Then
            txtSubT.Text = subt.ToString("N2")
            txtIgv.Text = igv.ToString("N2")
        Else
            txtSubT.Text = 0
            txtIgv.Text = 0
        End If

        txtTotal.Text = con

        txtCodigo.Clear()
        txtDescripcion.Clear()
        txtCantidad.Clear()
        txtPrecioVenta.Clear()
        txtStock.Clear()
        txtCodigo.Focus()

        If dgvDatos.Rows.Count < 1 Then
            btnEliminar.Enabled = False
        Else
            btnEliminar.Enabled = True
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        dgvDatos.Rows.Remove(dgvDatos.CurrentRow)
        Dim Total As Single
        For Each row As DataGridViewRow In Me.dgvDatos.Rows
            Total += Val(row.Cells(7).Value)
        Next

        txtTotal.Text = Total.ToString

        If dgvDatos.Rows.Count < 1 Then
            btnEliminar.Enabled = False
        Else
            btnEliminar.Enabled = True
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        dgvDatos.Rows.Clear()
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        If venLogi.numerodocumento(cboTipo.Text) Then
            txtNumeroF.Text = numdocc
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If venLogi.numerodocumento(cboTipo.Text) Then
            txtNumeroF.Text = numdocc
        End If
        cboTipo.SelectedIndex = 0
        dgvDatos.Rows.Clear()

        If dgvDatos.Rows.Count < 1 Then
            btnEliminar.Enabled = False
        Else
            btnEliminar.Enabled = True
        End If
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click

        Dim conta As Integer = 0

        rpta = MessageBox.Show("Deseas guardar..?", "Registro Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If rpta = vbYes Then

            If txtRUCDNI.Text <> "" Then
                If dgvDatos.Rows.Count > 0 Then
                    venLogi.CABVE_NUMDOC = txtNumeroF.Text
                    venLogi.CABVE_TIPODOC = cboTipo.Text
                    venLogi.CLI_DNI = txtRUCDNI.Text
                    venLogi.USU_DNI = dniusuario
                    venLogi.CABVE_TOTAL = txtTotal.Text
                    venLogi.CABVE_SUBT = txtSubT.Text
                    venLogi.CABVE_IGV = txtIgv.Text
                    venLogi.CABVE_FECHA = dtpFecha.Value

                    If venLogi.registrar_cabeceraV Then
                        conta = 1
                    End If

                    txtDetalle.Text = "COMERCIAL IDAR - I.E.R.L" + vbNewLine
                    txtDetalle.Text += " " + vbNewLine
                    txtDetalle.Text += cboTipo.Text + " N° " + txtNumeroF.Text + "                   " + dtpFecha.Text + vbNewLine
                    txtDetalle.Text += "Usuario: " + txtNombres.Text + vbNewLine
                    txtDetalle.Text += "RUC/DNI: " + txtRUCDNI.Text + vbNewLine
                    txtDetalle.Text += "____________________________________" + vbNewLine
                    txtDetalle.Text += " " + vbNewLine

                    Dim Fila As DataGridViewRow = New DataGridViewRow
                    'Dim Fila1 = dgvDatos.RowCount
                    Try
                        For Each Fila In dgvDatos.Rows
                            'For r = 0 To Fila

                            'detarticulos = dgvDatos.Rows(Fila).Cells(0).Value.ToString()
                            'detarticulos = dgvDatos.Rows(Fila).Cells[0].Value.ToString()

                            venLogi.CABVE_ID = Convert.ToInt64(Fila.Cells("id").Value.ToString())
                            'comLogi.CABCO_ID = Convert.ToInt64(dgvDatos.Rows(Fila1).Cells(0).Value.ToString())
                            venLogi.DETVE_NUMDOC = Convert.ToInt64(Fila.Cells("numedoc").Value.ToString())
                            'comLogi.DETCO_NUMDOC = Convert.ToInt64(dgvDatos.Rows(Fila1).Cells(1).Value.ToString())
                            venLogi.DETVE_TIPODOC = Convert.ToString(Fila.Cells("tipo").Value.ToString())
                            'comLogi.DETCO_TIPODOC = Convert.ToString(dgvDatos.Rows(Fila1).Cells(2).Value.ToString())
                            venLogi.PRO_COD = Convert.ToInt64(Fila.Cells("codigo").Value.ToString())
                            'comLogi.PRO_COD = Convert.ToInt64(dgvDatos.Rows(Fila1).Cells(3).Value.ToString())
                            venLogi.DETVE_PVU = Convert.ToDecimal(Fila.Cells("pvu").Value.ToString())
                            'comLogi.DETCO_PCU = Convert.ToDecimal(dgvDatos.Rows(Fila1).Cells(5).Value.ToString())
                            venLogi.DETVE_CANTIDAD = Convert.ToInt64(Fila.Cells("cantidad").Value.ToString())
                            'comLogi.DETCO_CANTIDAD = Convert.ToInt64(dgvDatos.Rows(Fila1).Cells(6).Value.ToString())
                            venLogi.DETVE_TOTALPRO = Convert.ToDecimal(Fila.Cells("total").Value.ToString())
                            'comLogi.DETCO_TOTALPRO = Convert.ToDecimal(dgvDatos.Rows(Fila1).Cells(7).Value.ToString())

                            venLogi.registrar_detalleV()

                            comLogi.actualizarStock(Convert.ToInt64(Fila.Cells("newstock").Value.ToString()), Convert.ToInt64(Fila.Cells("codigo").Value.ToString()))

                            txtDetalle.Text += Convert.ToString(Fila.Cells("producto").Value.ToString()) + "   -   " + Convert.ToString(Fila.Cells("pvu").Value.ToString()) + "   -   " + Convert.ToString(Fila.Cells("cantidad").Value.ToString()) + "    -   " + Convert.ToString(Fila.Cells("total").Value.ToString()) + vbNewLine
                            ' Next
                        Next
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    If cboTipo.Text = "FACTURA" Then
                        txtDetalle.Text += "____________________________________" + vbNewLine
                        txtDetalle.Text += " " + vbNewLine
                        txtDetalle.Text += "Subtotal: S/. " + txtSubT.Text + vbNewLine
                        txtDetalle.Text += "IGV: S/. " + txtIgv.Text + vbNewLine
                        txtDetalle.Text += "Total: S/. " + txtTotal.Text + vbNewLine
                    Else
                        txtDetalle.Text += "____________________________________" + vbNewLine
                        txtDetalle.Text += " " + vbNewLine
                        txtDetalle.Text += "Total: S/. " + txtTotal.Text + vbNewLine
                    End If

                    If conta = 1 Then
                        MsgBox("Venta registrada")
                    End If
                Else
                    MsgBox("Debe agregar algunos productos")
                End If
            Else
                MsgBox("Debe llenar casilla de datos")
            End If
        End If
    End Sub

    Private Sub grbDatos_Enter(sender As Object, e As EventArgs) Handles grbDatos.Enter

    End Sub
End Class
