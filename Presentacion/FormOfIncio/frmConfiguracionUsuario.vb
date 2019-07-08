Public Class frmConfiguracionUsuario
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim rpta As Integer
        rpta = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If rpta = vbYes Then
            Me.Close()
        End If
    End Sub
End Class