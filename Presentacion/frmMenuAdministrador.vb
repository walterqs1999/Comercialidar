﻿Imports System.Windows.Forms
Imports Logica
Imports System.Drawing.Drawing2D

Imports Logica.mdlGeneralUsuario

Public Class frmMenuAdministrador

    Dim usuLogi As New Logica.lUsuario

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If MenuVertical.Width = 250 Then
            MenuVertical.Width = 90
            btnCerrar.Left = 1239
            btnMinimizar.Left = 1211
            lblHora.Left = 1109
            lblFecha.Left = 1075
        Else
            MenuVertical.Width = 250
            btnCerrar.Left = 1079
            btnMinimizar.Left = 1051
            lblHora.Left = 949
            lblFecha.Left = 915
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim rpta As Integer
        rpta = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If rpta = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmMenuAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombre.Text = nombreusuario
        lblAdministrador.Text = tipousuario

        usuLogi.ObtenerImagen(perfil.Image)
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

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    lblHora.Text = DateTime.Now.ToString("hh:mm:ss")
    '    lblFecha.Text = DateTime.Now.ToLongDateString()
    'End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        AbrirFomEnPanel(New frmConfiguracionUsuario)
    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        AbrirFomEnPanel(New frmProductos)
    End Sub

    Private Sub btnUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
        AbrirFomEnPanel(New frmUsuario)
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        AbrirFomEnPanel(New frmCliente)
    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        AbrirFomEnPanel(New frmProveedor)
    End Sub

    Private Sub btnCategorias_Click(sender As Object, e As EventArgs) Handles btnCategorias.Click
        AbrirFomEnPanel(New frmCategorias)
    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        AbrirFomEnPanel(New frmComprasEdicion)
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        AbrirFomEnPanel(New frmVentasEdicion)
    End Sub
End Class