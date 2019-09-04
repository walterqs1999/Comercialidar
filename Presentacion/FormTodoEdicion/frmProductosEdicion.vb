Imports Logica
Imports datos
Imports Logica.mdlProductos

Public Class frmProductosEdicion

    Dim proLogi As New lProducto
    Dim usuDato As New dUsuario
    Dim con As New dConexion

    Dim Rpta As Integer

    Private Sub frmProductosEdicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If valorPro = 1 Then
            proLogi.cargar_combo(cboCategoria)
        End If
        If valorPro = 2 Then
            cboCategoria.SelectedIndex = index
        End If
    End Sub

    Private Sub btnGrabarb_Click(sender As Object, e As EventArgs) Handles btnGrabarb.Click
        proLogi.USU_DNI = dniusuario
        proLogi.CAT_COD = cboCategoria.SelectedValue
        proLogi.PRO_NOM = txtNombre.Text
        proLogi.PRO_PCU = txtPrecioC.Text
        proLogi.PRO_PVU = txtPrecioV.Text
        proLogi.PRO_STOCK = txtStock.Text
        proLogi.PRO_ESTA = "A"

        If proLogi.registrar_producto Then
            MsgBox("Producto registrado")
            EstadoTextos(False)
            con.Desconectar()
        Else
            MsgBox("No se Registró Producto")
        End If
    End Sub

    Private Sub btnModificarb_Click(sender As Object, e As EventArgs) Handles btnModificarb.Click
        codigoPro = txtId.Text
        proLogi.USU_DNI = dniusuario
        proLogi.CAT_COD = cboCategoria.SelectedValue
        proLogi.PRO_NOM = txtNombre.Text
        proLogi.PRO_PCU = txtPrecioC.Text
        proLogi.PRO_PVU = txtPrecioV.Text
        proLogi.PRO_STOCK = txtStock.Text
        proLogi.PRO_ESTA = "A"

        If proLogi.modificar_producto Then
            MsgBox("Producto Modificado")
        Else
            MsgBox("No se Modifico el Producto")
        End If
    End Sub
End Class
