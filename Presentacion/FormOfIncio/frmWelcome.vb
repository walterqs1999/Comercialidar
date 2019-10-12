Imports Logica.mdlGeneralUsuario
Imports Logica

Public Class frmWelcome

    Dim usuLogi As New lUsuario

    'Dim conta As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
            CircularProgressBar1.Value += 5
            CircularProgressBar1.Text = CircularProgressBar1.Value.ToString() + "%"
            If CircularProgressBar1.Value = 100 Then
                Timer1.Stop()
                Timer2.Start()
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Dim Administrador As New frmMenuAdministrador

        Me.Opacity -= 0.05

        If Me.Opacity = 0 Then
            Timer2.Stop()
            Me.Hide()
            If tipo = 1 Then
                Administrador.Show()
            End If
        End If
    End Sub

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbUsername01.Text = nombreusuario

        usuLogi.ObtenerImagen(perfil.Image)
        Me.Opacity = 0.0
        CircularProgressBar1.Value = 0
        CircularProgressBar1.Minimum = 0
        CircularProgressBar1.Maximum = 100
        Timer1.Start()
    End Sub
End Class