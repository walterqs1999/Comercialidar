Imports Presentacion.frmBaseEdicion

Public Class frmTodoRegistro
    Public rpta As Integer
    Public valor As Integer

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        rpta = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If rpta = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnRSalir.Click
        rpta = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If rpta = vbYes Then
            Me.Close()
        End If
    End Sub

    Public Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnRNuevo.Click
        frmBaseEdicion.valorNuevo = 1
    End Sub

    Public Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnRGrabar.Click
        frmBaseEdicion.valorNuevo = 2
    End Sub

    Public Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnRModificar.Click
        frmBaseEdicion.valorNuevo = 3
    End Sub

    Public Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnREliminar.Click
        frmBaseEdicion.valorNuevo = 4
    End Sub

End Class