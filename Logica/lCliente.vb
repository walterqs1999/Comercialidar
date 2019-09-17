Imports System.Data.SqlClient

Public Class lCliente

    Public conexx As SqlConnection
    Public enunc As SqlCommand
    Public resp As SqlDataReader
    Public odap As SqlDataAdapter

    Dim con As New datos.dConexion

    Public CLI_DNI As String
    Public USU_DNI As String
    Public CLI_NOM As String
    Public CLI_DIR As String
    Public CLI_TEL As String
    Public CLI_ESTA As String

    Public Function listar_clientes() As DataSet
        Dim objDat As New DataSet
        con.Conectar()
        Dim comando As New SqlDataAdapter("SELECT * FROM vistaMostrarCliente WHERE CLI_ESTA = 'A'", con.strConex)
        'Dim comando As New SqlDataAdapter("select * from Usuarios", Con.strConex)
        comando.Fill(objDat, "Clientes")
        con.Desconectar()
        Return objDat
    End Function

    Public Function eliminar_cliente() As Boolean
        con.Conectar()
        Dim comando As New SqlCommand("proc_EliminarCliente")
        comando.CommandType = CommandType.StoredProcedure
        comando.Connection = con.strConex
        comando.Parameters.AddWithValue("@codigo", CLI_DNI)
        Try
            comando.ExecuteNonQuery()
            Return True
            con.Desconectar()
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function registrar_cliente() As Boolean
        Try
            con.Conectar()
            Dim comando = New SqlCommand("proc_InsertarCliente")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = con.strConex
            comando.Parameters.AddWithValue("@codigo", CLI_DNI)
            comando.Parameters.AddWithValue("@codUsu", USU_DNI)
            comando.Parameters.AddWithValue("@nombre", CLI_NOM)
            comando.Parameters.AddWithValue("@direccion", CLI_DIR)
            comando.Parameters.AddWithValue("@telefono", CLI_TEL)
            comando.Parameters.AddWithValue("@estado", CLI_ESTA)


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

    Public Function modificar_cliente() As Boolean
        Try
            con.Conectar()
            Dim comando = New SqlCommand("proc_ModificarCliente")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = con.strConex
            comando.Parameters.AddWithValue("@codigo", CLI_DNI)
            comando.Parameters.AddWithValue("@codUsu", USU_DNI)
            comando.Parameters.AddWithValue("@nombre", CLI_NOM)
            comando.Parameters.AddWithValue("@direccion", CLI_DIR)
            comando.Parameters.AddWithValue("@telefono", CLI_TEL)
            comando.Parameters.AddWithValue("@estado", CLI_ESTA)

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
End Class
