Public Class frmMenuUsuario
    Private Sub frmMenuUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size

    End Sub
End Class