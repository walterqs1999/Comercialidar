'Imports System
'Imports System.Data
Imports System.Data.SqlClient

Imports datos

Public Class lProveedor

    Public conexx As SqlConnection
    Public enunc As SqlCommand
    Public resp As SqlDataReader
    Public odap As SqlDataAdapter

    Dim con As New datos.dConexion

    Public PROV_RUC As String
    Public USU_DNI As String
    Public PROV_NOM As String
    Public PROV_PERCARGO As String
    Public PROV_DIREC As String
    Public PROV_TEL As String
    Public PROV_REFE As String
    Public PROV_ESTA As String

    Public Function listar_proveedores() As DataSet
        Dim objDat As New DataSet
        con.Conectar()
        Dim comando As New SqlDataAdapter("SELECT PROV_RUC AS 'RUC PROVEEDOR', USU_DNI AS 'DNI USUARIO', PROV_NOM AS 'NOMBRE EMPRESA', PROV_PERCARGO AS 'PERSONA ACARGO', PROV_DIREC AS DIRECCION, PROV_TEL AS TELEFONO, PROV_REFE AS REFERENCIA FROM PROVEEDORES", con.strConex)
        'Dim comando As New SqlDataAdapter("select * from Usuarios", Con.strConex)
        comando.Fill(objDat, "Proveedores")
        con.Desconectar()
        Return objDat
    End Function

    Public Function eliminar_proveedor() As Boolean
        con.Conectar()
        Dim comando As New SqlCommand("proc_EliminarProveedor")
        comando.CommandType = CommandType.StoredProcedure
        comando.Connection = con.strConex
        comando.Parameters.AddWithValue("@codigo", PROV_RUC)
        Try
            comando.ExecuteNonQuery()
            Return True
            con.Desconectar()
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function registrar_proveedor() As Boolean
        Try
            con.Conectar()
            Dim comando = New SqlCommand("proc_InsertarProveedor")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = con.strConex
            comando.Parameters.AddWithValue("@codigo", PROV_RUC)
            comando.Parameters.AddWithValue("@codUsu", USU_DNI)
            comando.Parameters.AddWithValue("@nombre", PROV_NOM)
            comando.Parameters.AddWithValue("@perCargo", PROV_PERCARGO)
            comando.Parameters.AddWithValue("@direccion", PROV_DIREC)
            comando.Parameters.AddWithValue("@telefono", PROV_TEL)
            comando.Parameters.AddWithValue("@referencia", PROV_REFE)
            comando.Parameters.AddWithValue("@estado", PROV_ESTA)


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

    Public Function modificar_proveedor() As Boolean
        Try
            con.Conectar()
            Dim comando = New SqlCommand("proc_ModificarProveedor")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = con.strConex
            comando.Parameters.AddWithValue("@codigo", PROV_RUC)
            comando.Parameters.AddWithValue("@codUsu", USU_DNI)
            comando.Parameters.AddWithValue("@nombre", PROV_NOM)
            comando.Parameters.AddWithValue("@perCargo", PROV_PERCARGO)
            comando.Parameters.AddWithValue("@direccion", PROV_DIREC)
            comando.Parameters.AddWithValue("@telefono", PROV_TEL)
            comando.Parameters.AddWithValue("@referencia", PROV_REFE)
            comando.Parameters.AddWithValue("@estado", PROV_ESTA)


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
