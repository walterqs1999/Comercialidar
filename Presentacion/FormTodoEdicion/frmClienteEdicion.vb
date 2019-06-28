Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports Logica
Imports datos

Public Class frmClienteEdicion

    Dim cliLogi As New Logica.lCliente
    Dim usuDato As New datos.dUsuario
    Dim con As New datos.dConexion

    Dim Rpta As Integer

    Private Sub btnGrabarb_Click(sender As Object, e As EventArgs) Handles btnGrabarb.Click
        cliLogi.CLI_DNI = txtId.Text
        cliLogi.USU_DNI = dniusuario
        cliLogi.CLI_NOM = txtNombre.Text
        cliLogi.CLI_DIR = txtDireccion.Text
        cliLogi.CLI_TEL = txtTelefono.Text
        cliLogi.CLI_ESTA = "A"
        Dim can As Integer
        Dim xcod As String
        xcod = txtId.Text

        'con.Conectar()

        StrSql = "SELECT * FROM CLIENTE WHERE CLI_DNI ='" & xcod & "'"
        oCommand = New SqlCommand(StrSql, con.strConex)
        oDataAdapter = New SqlDataAdapter(oCommand)
        oDataSet = New DataSet
        oDataAdapter.Fill(oDataSet)
        can = oDataSet.Tables(0).Rows.Count

        If can > 0 Then
            xcod = (oDataSet.Tables(0).Rows(0)("CLI_DNI").ToString())
            If xcod = txtId.Text = True Then
                MessageBox.Show("Ya hay un Usuario con este Código, Registre Nuevamente", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                LimpiarTextoGrupo()
                txtId.Focus()
            Else
            End If
        End If

        If cliLogi.registrar_cliente Then
            MsgBox("Cliente Registrado")
            EstadoTextos(False)
            con.Desconectar()
        Else
            MsgBox("No se Registró Cliente")
        End If
    End Sub

    Private Sub btnModificarb_Click(sender As Object, e As EventArgs) Handles btnModificarb.Click
        cliLogi.CLI_DNI = txtId.Text
        cliLogi.USU_DNI = dniusuario
        cliLogi.CLI_NOM = txtNombre.Text
        cliLogi.CLI_DIR = txtDireccion.Text
        cliLogi.CLI_TEL = txtTelefono.Text
        cliLogi.CLI_ESTA = "A"

        If cliLogi.modificar_cliente Then
            MsgBox("Usuario Modificado")
        Else
            MsgBox("No se Modifico el Usuario")
        End If
    End Sub
End Class
