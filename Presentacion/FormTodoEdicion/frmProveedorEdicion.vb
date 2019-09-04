Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports Logica
Imports datos

Public Class frmProveedorEdicion

    Dim proLogi As New Logica.lProveedor
    Dim usuDato As New datos.dProveedor
    Dim con As New datos.dConexion

    Dim Rpta As Integer

    Private Sub btnGrabarb_Click(sender As Object, e As EventArgs) Handles btnGrabarb.Click
        proLogi.PROV_RUC = txtId.Text
        proLogi.USU_DNI = dniusuario
        proLogi.PROV_NOM = txtEmpresa.Text
        proLogi.PROV_PERCARGO = txtEmpresa.Text
        proLogi.PROV_DIREC = txtDireccion.Text
        proLogi.PROV_TEL = txtTelefono.Text
        proLogi.PROV_REFE = txtReferencia.Text
        proLogi.PROV_ESTA = "A"
        Dim can As Integer
        Dim xcod As String
        xcod = txtId.Text

        'con.Conectar()

        StrSql = "SELECT * FROM PROVEEDORES WHERE PROV_RUC ='" & xcod & "'"
        oCommand = New SqlCommand(StrSql, con.strConex)
        oDataAdapter = New SqlDataAdapter(oCommand)
        oDataSet = New DataSet
        oDataAdapter.Fill(oDataSet)
        can = oDataSet.Tables(0).Rows.Count

        If can > 0 Then
            xcod = (oDataSet.Tables(0).Rows(0)("PROV_RUC").ToString())
            If xcod = txtId.Text = True Then
                MessageBox.Show("Ya hay un PROVEDOR con este Código, Registre Nuevamente", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                LimpiarTextoGrupo()
                txtId.Focus()
            Else
            End If
        End If

        If proLogi.registrar_proveedor Then
            MsgBox("Proveedor Registrado")
            EstadoTextos(False)
            con.Desconectar()
        Else
            MsgBox("No se Registró Proveedor")
        End If
    End Sub

    Private Sub btnModificarb_Click(sender As Object, e As EventArgs) Handles btnModificarb.Click
        proLogi.PROV_RUC = txtId.Text
        proLogi.USU_DNI = dniusuario
        proLogi.PROV_NOM = txtEmpresa.Text
        proLogi.PROV_PERCARGO = txtEmpresa.Text
        proLogi.PROV_DIREC = txtDireccion.Text
        proLogi.PROV_TEL = txtTelefono.Text
        proLogi.PROV_REFE = txtReferencia.Text
        proLogi.PROV_ESTA = "A"

        If proLogi.modificar_proveedor Then
            MsgBox("Proveedor Modificado")
        Else
            MsgBox("No se Modifico el Proveedor")
        End If
    End Sub

End Class
