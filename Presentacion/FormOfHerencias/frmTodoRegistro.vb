Imports Logica
Imports Presentacion.frmTodoEdicion

Public Class frmTodoRegistro
    Public rpta As Integer

    'Dim frmtodoedicion As New frmTodoEdicion

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
        valor = 1
    End Sub

    Public Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnRModificar.Click
        valor = 2
    End Sub
End Class