Public Class frmAcceso
    Private Sub frmAcceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cbxMostrarCon_CheckedChanged(sender As Object, e As EventArgs) Handles cbxMostrarCon.CheckedChanged
        If cbxMostrarCon.Checked Then
            txtClave.PasswordChar = ""
        Else
            txtClave.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

    End Sub

    Private Sub frmAcceso_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        btnAceptar.Size = New Size(height:=48, width:=105)
    End Sub

    Private Sub btnAceptar_MouseHover(sender As Object, e As EventArgs) Handles btnAceptar.MouseHover
        btnAceptar.Size = New Size(height:=52, width:=109)
    End Sub
End Class