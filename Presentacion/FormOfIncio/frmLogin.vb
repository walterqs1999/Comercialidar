Imports System.Runtime.InteropServices
Imports System
Imports System.Text
Imports System.Security.Cryptography

Imports datos
Imports Logica

Public Class frmLogin

    Dim cont As Integer = 0
    Dim usu As New Logica.lUsuario
    Dim co1 As New datos.dConexion

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

    Private Sub txtUsuario_Enter(sender As Object, e As EventArgs) Handles txtUsuario.Enter
        If txtUsuario.Text = "USUARIO" Then
            txtUsuario.Text = ""
            txtUsuario.ForeColor = Color.LightGray
            lblUsuario.Visible = True
        End If
    End Sub

    Private Sub txtUsuario_Leave(sender As Object, e As EventArgs) Handles txtUsuario.Leave
        If txtUsuario.Text = "" Then
            txtUsuario.Text = "USUARIO"
            txtUsuario.ForeColor = Color.DimGray
            lblUsuario.Visible = False
        End If
    End Sub

    Private Sub txtContraseña_Enter(sender As Object, e As EventArgs) Handles txtContraseña.Enter
        If txtContraseña.Text = "CONTRASEÑA" Then
            txtContraseña.Text = ""
            txtContraseña.ForeColor = Color.LightGray
            txtContraseña.UseSystemPasswordChar = True
            lblContraseña.Visible = True
        End If
    End Sub

    Private Sub txtContraseña_Leave(sender As Object, e As EventArgs) Handles txtContraseña.Leave
        If txtContraseña.Text = "" Then
            txtContraseña.Text = "CONTRASEÑA"
            txtContraseña.ForeColor = Color.DimGray
            txtContraseña.UseSystemPasswordChar = False
            lblContraseña.Visible = False
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        If lblContraseña.Visible = True Then
            btnMostrar.Visible = False
            txtContraseña.UseSystemPasswordChar = False
            btnOcultar.Visible = True
        End If
    End Sub

    Private Sub btnOcultar_Click(sender As Object, e As EventArgs) Handles btnOcultar.Click
        btnMostrar.Visible = True
        txtContraseña.UseSystemPasswordChar = True
        btnOcultar.Visible = False
    End Sub

    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click

        Dim clave As String

        If txtUsuario.Text = "USUARIO" Then
            Advertencia1.Visible = True

        End If
        If txtContraseña.Text = "CONTRASEÑA" Then
            Advertencia2.Visible = True
        End If

        Try
            clave = generarClave(txtContraseña.Text)

            If usu.usuRegistrado(txtUsuario.Text) = True Then
                Dim passs As String = usu.pass(txtUsuario.Text)
                If passs.Equals(clave) = True Then
                    Me.Visible = False
                    Dim frmmenuadministrador As New frmMenuAdministrador
                    Dim frmmenuusario As New frmMenuUsuario
                    If usu.consultarTusu(txtUsuario.Text) = "Administrador" Then
                        frmWelcome.ShowDialog()
                        frmmenuadministrador.ShowDialog()
                    Else
                        frmWelcome.ShowDialog()
                        frmmenuusario.ShowDialog()
                    End If
                Else
                    MsgBox("Clave Incorrecta")
                    cont = cont + 1
                    Advertencia2.Visible = True
                    txtContraseña.Focus()
                    txtContraseña.SelectAll()
                End If
            Else
                MsgBox("El Usuario:" + txtUsuario.Text + " no se encuentra registrado")
                Advertencia1.Visible = True
                txtUsuario.Focus()
                txtUsuario.SelectAll()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        If cont >= 3 Then
            MsgBox("Muchos intentos, Acceso Denegado al Sistema")
            End
        End If
    End Sub
End Class