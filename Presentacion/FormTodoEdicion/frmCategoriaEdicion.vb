Imports Logica.mdlCategorias
Imports Logica
Imports datos

Public Class frmCategoriaEdicion

    Dim catLogi As New lCategorias
    Dim usuDato As New dUsuario
    Dim con As New dConexion

    Private Sub frmCategoriaEdicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtId.Enabled = False
    End Sub

    Private Sub btnGrabarb_Click(sender As Object, e As EventArgs) Handles btnGrabarb.Click

        catLogi.CAT_NOM = txtNombre.Text
        catLogi.USU_DNI = dniusuario
        catLogi.CAT_ESTA = "A"

        If catLogi.registrar_categorias Then
            MsgBox("Categoria Registrada")
            EstadoTextos(False)
            con.Desconectar()
        Else
            MsgBox("No se Registró Categoria")
        End If

    End Sub

    Private Sub btnModificarb_Click(sender As Object, e As EventArgs) Handles btnModificarb.Click
        codigo = txtId.Text
        catLogi.CAT_NOM = txtNombre.Text
        catLogi.USU_DNI = dniusuario
        catLogi.CAT_ESTA = "A"

        If catLogi.modificar_categoria Then
            MsgBox("Categoria Modificada")
        Else
            MsgBox("No se Modifico el Categoria")
        End If
    End Sub
End Class
