Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography

Imports Logica

Public Class frmConfiguracionUsuario

    Dim usuLogi As New Logica.lUsuario

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
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim rpta As Integer
        rpta = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If rpta = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub frmConfiguracionUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Text = nombreusuario
        txtDni.Text = dniusuario
        txtDireccion.Text = direcusuario
        txtTelefono.Text = teleusuario
        txtEmail.Text = emailusuario
        txtUsuario.Text = usuariousuario
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If generarClave(txtContraseña.Text) = claveusuario Then
            grbDatosAcceso.Height = 353
            Advertencia2.Visible = False
            exito.Visible = True
            btnConfirmar.Enabled = False
        Else
            Advertencia2.Visible = True
            txtContraseña.Focus()
            txtContraseña.SelectAll()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        txtDni.Enabled = True
        txtDni.Focus()
        txtDni.SelectAll()
        PictureBox2.Visible = False
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        txtNombre.Enabled = True
        txtNombre.Focus()
        txtNombre.SelectAll()
        PictureBox3.Visible = False
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        txtDireccion.Enabled = True
        txtDireccion.Focus()
        txtDireccion.SelectAll()
        PictureBox4.Visible = False
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        txtTelefono.Enabled = True
        txtTelefono.Focus()
        txtTelefono.SelectAll()
        PictureBox5.Visible = False
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        txtEmail.Enabled = True
        txtEmail.Focus()
        txtEmail.SelectAll()
        PictureBox6.Visible = False
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        txtUsuario.Enabled = True
        txtUsuario.Focus()
        txtUsuario.SelectAll()
        PictureBox7.Visible = False
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        txtContraseña.Enabled = True
        txtContraseña.Clear()
        txtContraseña.Focus()
        txtContraseña.UseSystemPasswordChar = True
        PictureBox8.Visible = False
    End Sub

    Private Sub txtConfirmar_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmar.TextChanged
        If txtNuevaContraseña.Text = txtConfirmar.Text Then
            exito1.Visible = True
            advertencia.Visible = False
        Else
            exito1.Visible = False
            advertencia.Visible = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        usuLogi.USU_DNI = txtDni.Text
        usuLogi.USU_NOM = txtNombre.Text
        usuLogi.USU_DIR = txtDireccion.Text
        usuLogi.USU_TEL = txtTelefono.Text
        usuLogi.USU_CORREO = txtEmail.Text
        usuLogi.USU_USU = txtUsuario.Text
        If txtNuevaContraseña.Enabled = True Then
            usuLogi.USU_PAS = generarClave(txtNuevaContraseña.Text)
        Else
            usuLogi.USU_PAS = generarClave(txtContraseña.Text)
        End If
        usuLogi.USU_TIPO = tipousuario
        usuLogi.USU_ESTA = "A"

        If usuLogi.modificar_usuario Then
            MsgBox("Usuario Modificado")
            txtNombre.Enabled = False
            txtDni.Enabled = False
            txtDireccion.Enabled = False
            txtTelefono.Enabled = False
            txtEmail.Enabled = False
            txtUsuario.Enabled = False
            txtContraseña.Enabled = False
            txtNuevaContraseña.Enabled = False
            txtConfirmar.Enabled = False
        Else
            MsgBox("No se Modifico el Usuario")
        End If
    End Sub
End Class