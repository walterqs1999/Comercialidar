﻿Imports Logica.mdlGeneralUsuario

Public Class frmWelcome
    'Dim conta As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
            ProgressBar1.Value += 5
            ProgressBar1.Text = ProgressBar1.Value.ToString()
            If ProgressBar1.Value = 100 Then
                Timer1.Stop()
                Timer2.Start()
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Dim frmAccesoAdministrador As New frmMenuAdministrador

        Me.Opacity -= 0.05

        If Me.Opacity = 0 Then
            Timer2.Stop()
            Me.Hide()
        End If
    End Sub

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbUsername01.Text = nombreusuario
        Me.Opacity = 0.0
        ProgressBar1.Value = 0
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        Timer1.Start()
    End Sub

End Class