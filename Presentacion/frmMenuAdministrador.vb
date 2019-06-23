Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class frmMenuAdministrador
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If MenuVertical.Width = 250 Then
            MenuVertical.Width = 90
            btnCerrar.Left = 1250
            btnMinimizar.Left = 1224
        Else
            MenuVertical.Width = 250
            btnCerrar.Left = 1090
            btnMinimizar.Left = 1064
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmMenuAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AbrirFomEnPanel(ByVal Formhijo As Object)

        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()
    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        AbrirFomEnPanel(New frmBaseRegistro)
    End Sub
End Class