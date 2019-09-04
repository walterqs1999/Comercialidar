Imports System.Data.SqlClient

Public Class lCategorias
    Public conexx As SqlConnection
    Public enunc As SqlCommand
    Public resp As SqlDataReader
    Public odap As SqlDataAdapter

    Dim con As New datos.dConexion

    Public CAT_NOM As String
    Public USU_DNI As String
    Public CAT_ESTA As String

    Public Function listar_categorias() As DataSet
        Dim objDat As New DataSet
        con.Conectar()
        Dim comando As New SqlDataAdapter("SELECT CAT_COD AS 'CODIGO CATEGORIA', CAT_NOM AS 'NOMBRE CATEGORIA', USU_DNI AS 'DNI USUARIO' FROM CATEGORIAS", con.strConex)
        'Dim comando As New SqlDataAdapter("select * from Usuarios", Con.strConex)
        comando.Fill(objDat, "Categorias")
        con.Desconectar()
        Return objDat
    End Function

    Public Function registrar_categorias() As Boolean
        Try
            con.Conectar()
            Dim comando = New SqlCommand("proc_InsertarCategoria")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = con.strConex
            comando.Parameters.AddWithValue("@nombre", CAT_NOM)
            comando.Parameters.AddWithValue("@codUsu", USU_DNI)
            comando.Parameters.AddWithValue("@estado", CAT_ESTA)


            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Desconectar()
        End Try
    End Function

    Public Function modificar_categoria() As Boolean
        Try
            con.Conectar()
            Dim comando = New SqlCommand("proc_ModificarCategoria")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = con.strConex
            comando.Parameters.AddWithValue("@codigo", mdlCategorias.codigo)
            comando.Parameters.AddWithValue("@nombre", CAT_NOM)
            comando.Parameters.AddWithValue("@codUsu", USU_DNI)
            comando.Parameters.AddWithValue("@estado", CAT_ESTA)

            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Desconectar()
        End Try
    End Function

    Public Function eliminar_categoria() As Boolean
        con.Conectar()
        Dim comando As New SqlCommand("proc_EliminarCategoria")
        comando.CommandType = CommandType.StoredProcedure
        comando.Connection = con.strConex
        comando.Parameters.AddWithValue("@codigo", mdlCategorias.codigo)
        Try
            comando.ExecuteNonQuery()
            Return True
            con.Desconectar()
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
