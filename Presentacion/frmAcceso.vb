Imports System
Imports System.Text
Imports System.Security.Cryptography

Imports Datos
Imports Logica

Public Class frmAcceso

    Dim cont As Integer = 0
    Dim usu As New Logica.lUsuario
    Dim co1 As New Datos.dConexion

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim rpta As Integer

        rpta = MessageBox.Show("¿Desea Cancelar la Operación?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If rpta = vbYes Then
            End
        End If
    End Sub

    Private Sub cbxMostrarCon_CheckedChanged(sender As Object, e As EventArgs) Handles cbxMostrarCon.CheckedChanged
        If cbxMostrarCon.Checked Then
            txtClave.PasswordChar = ""
        Else
            txtClave.PasswordChar = "*"
        End If
    End Sub

    Private Sub frmAcceso_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        btnAceptar.Size = New Size(height:=48, width:=105)
    End Sub

    Private Sub btnAceptar_MouseHover(sender As Object, e As EventArgs) Handles btnAceptar.MouseHover
        btnAceptar.Size = New Size(height:=54, width:=111)
    End Sub

    Private Sub frmAcceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Clear()
        txtClave.Clear()
        txtUsuario.Focus()
    End Sub

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

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Dim clave As String

            clave = generarClave(txtClave.Text)

            If usu.usuRegistrado(txtUsuario.Text) = True Then
                Dim passs As String = usu.pass(txtUsuario.Text)
                If passs.Equals(clave) = True Then
                    Me.Visible = False
                    If usu.consultarTusu(txtUsuario.Text) = "Administrador" Then
                        frmMenuAdmin.ShowDialog()
                    Else
                        frmMenuUsuario.ShowDialog()
                        MsgBox("No es Administrador")
                    End If
                Else
                    MsgBox("Clave Incorrecta")
                    cont = cont + 1
                    txtClave.Clear()
                    txtClave.Focus()
                End If
            Else
                MsgBox("El Usuario:" + txtUsuario.Text * " no se encuentra registrado")
                txtClave.Clear()
                txtUsuario.Focus()
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