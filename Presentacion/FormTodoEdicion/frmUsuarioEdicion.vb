Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Security.Cryptography

Imports Logica
Imports datos
Public Class frmUsuarioEdicion

    Dim usuLogi As New Logica.lUsuario
    Dim usuDato As New datos.dUsuario
    Dim con As New datos.dConexion

    Dim Rpta As Integer

    'Public Sub cargar_datagrid()
    'dgvUsuarios.DataSource = logica.listar_Usuario.Tables("Usuario")
    'End Sub

    Function generarClave(ByVal cadena As String) As String
        Dim enc As New UTF8Encoding
        Dim data() As Byte = enc.GetBytes(cadena)
        Dim result() As Byte
        Dim sha As New SHA1CryptoServiceProvider

        result = sha.ComputeHash(data)

        Dim sb As New StringBuilder
        Dim max As Int32 = result.Length

        For i As Integer = 0 To max - 1
            'Convertimos los valores en hexadecimal
            'cuando tiene una cifra hay que rellenarlo con cero
            'para que siempre ocupen dos dígitos.
            If (result(i) < 16) Then
                sb.Append("0")
            End If

            sb.Append(result(i).ToString("x"))
        Next
        'Devolvemos la cadena con el hash :)
        generarClave = sb.ToString()

    End Function

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim usu, pass, nom, dni As String
        nom = txtNombre.Text
        dni = txtId.Text
        pass = "123456"

        nom = Mid(nom, 1, 4)
        dni = Mid(dni, 1, 4)
        usu = nom & dni
        txtUsuario.Text = LCase(usu)
        txtClave.Text = pass
        If txtNombre.Text = "" Or txtId.Text = "" Then
            MsgBox("Debe llenar los campos requeridos, Nombres y DNI")
            txtClave.Clear()
            txtUsuario.Clear()
            txtNombre.Focus()
        Else
        End If

        Try
            Dim can As Integer
            Dim xUsu As String
            usu = txtUsuario.Text

            con.Conectar()

            StrSql = "SELECT * FROM USUARIO WHERE USU_USU='" & usu & "'"
            oCommand = New SqlCommand(StrSql, con.strConex)
            oDataAdapter = New SqlDataAdapter(oCommand)
            oDataSet = New DataSet
            oDataAdapter.Fill(oDataSet)
            can = oDataSet.Tables(0).Rows.Count

            If can > 0 Then
                xUsu = (oDataSet.Tables(0).Rows(0)("USU_USU").ToString())
                If xUsu = txtUsuario.Text = True Then
                    MsgBox("Ya hay un usuario igual, se tomará el N° de DNI como alternativa")
                    txtUsuario.Text = txtId.Text
                    con.Desconectar()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnGrabarb_Click(sender As Object, e As EventArgs) Handles btnGrabarb.Click
        usuLogi.USU_DNI = txtId.Text
        usuLogi.USU_NOM = txtNombre.Text
        usuLogi.USU_DIR = txtDireccion.Text
        usuLogi.USU_TEL = txtTelefono.Text
        usuLogi.USU_CORREO = txtEmail.Text
        usuLogi.USU_USU = txtUsuario.Text
        usuLogi.USU_PAS = generarClave(txtClave.Text)
        usuLogi.USU_TIPO = cboTipo.Text
        usuLogi.USU_ESTA = "A"
        Dim can As Integer
        Dim xcod As String
        xcod = txtId.Text

        'con.Conectar()

        StrSql = "SELECT * FROM USUARIO WHERE USU_DNI ='" & xcod & "'"
        oCommand = New SqlCommand(StrSql, con.strConex)
        oDataAdapter = New SqlDataAdapter(oCommand)
        oDataSet = New DataSet
        oDataAdapter.Fill(oDataSet)
        can = oDataSet.Tables(0).Rows.Count

        If can > 0 Then
            xcod = (oDataSet.Tables(0).Rows(0)("USU_DNI").ToString())
            If xcod = txtId.Text = True Then
                MessageBox.Show("Ya hay un Usuario con este Código, Registre Nuevamente", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                LimpiarTextoGrupo()
                txtId.Focus()
            Else
            End If
        End If

        If txtId.Text = "" Then
            MsgBox("Escribe el DNI")
            txtId.Focus()
        Else

            If txtUsuario.Text = "" Or txtClave.Text = "" Then
                MsgBox("Debe Generar al Usuario antes de Registrar")
            ElseIf usuLogi.registrar_usuario Then
                MsgBox("Usuario Registrado")
                EstadoTextos(False)
                con.Desconectar()
            Else
                MsgBox("No se Registró Usuario")
            End If
        End If
        txtClave.Enabled = False
        txtUsuario.Enabled = False
        btnGenerar.Enabled = False
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtId.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnModificarb_Click(sender As Object, e As EventArgs) Handles btnModificarb.Click
        usuLogi.USU_DNI = txtId.Text
        usuLogi.USU_NOM = txtNombre.Text
        usuLogi.USU_DIR = txtDireccion.Text
        usuLogi.USU_TEL = txtTelefono.Text
        usuLogi.USU_CORREO = txtEmail.Text
        usuLogi.USU_USU = txtUsuario.Text
        usuLogi.USU_PAS = txtClave.Text
        usuLogi.USU_TIPO = cboTipo.Text
        usuLogi.USU_ESTA = "A"

        If usuLogi.modificar_usuario Then
            MsgBox("Usuario Modificado, No habra alteracion en el usuario y la clave, Seguiran siendo los mismos")
        Else
            MsgBox("No se Modifico el Usuario")
        End If
    End Sub
End Class
