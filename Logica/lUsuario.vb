Imports System
Imports System.IO
Imports System.Data.SqlClient
Imports System.Drawing

Imports datos


Public Class lUsuario

    Public conexx As SqlConnection
    Public enunc As SqlCommand
    Public resp As SqlDataReader
    Public odap As SqlDataAdapter

    Dim con As New datos.dConexion

    Public USU_DNI As String
    Public USU_NOM As String
    Public USU_DIR As String
    Public USU_TEL As String
    Public USU_CORREO As String
    Public USU_USU As String
    Public USU_PAS As String
    Public USU_TIPO As String
    Public USU_ESTA As String
    Public USU_IMAGEN As String

    Public Function ObtenerImagen(ByRef imagen As Image) As Boolean
        Dim resul As Boolean = False

        Try
            con.Conectar()
            enunc = New SqlCommand("SELECT USU_IMAGEN FROM USUARIO WHERE USU_DNI = '" & dniusuario & "' ", con.strConex)

            resp = enunc.ExecuteReader

            Dim newimagen As Image = Nothing

            If resp.Read Then

                Dim imgData As Byte() = resp.Item("USU_IMAGEN")
                Using ms As New MemoryStream(imgData, 0, imgData.Length)
                    ms.Write(imgData, 0, imgData.Length)
                    newimagen = Image.FromStream(ms, True)
                End Using

                imagen = newimagen
                newimagen = Nothing

                resul = True

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return resul
    End Function

    Public Function consultarTusu(ByVal nomUsu As String) As String
        Dim resul As String = ""
        Try
            con.Conectar()
            enunc = New SqlCommand("SELECT USU_EMAIL, USU_TEL, USU_DIR, USU_TIPO, USU_NOM, USU_USU, USU_CLAVE, USU_DNI FROM USUARIO WHERE USU_USU='" & nomUsu & "'", con.strConex)
            resp = enunc.ExecuteReader

            If resp.Read Then

                resul = resp.Item("USU_TIPO")

                nombreusuario = resp.Item("USU_NOM")
                tipousuario = resp.Item("USU_TIPO")
                usuariousuario = resp.Item("USU_USU")
                claveusuario = resp.Item("USU_CLAVE")
                dniusuario = resp.Item("USU_DNI")
                direcusuario = resp.Item("USU_DIR")
                teleusuario = resp.Item("USU_TEL")
                emailusuario = resp.Item("USU_EMAIL")
            End If
            resp.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Desconectar()
        End Try
        Return resul
    End Function

    Public Function usuRegistrado(ByVal nomUsu As String) As Boolean
        con.Conectar()
        Dim resul As Boolean = False
        Try
            enunc = New SqlCommand("SELECT * FROM USUARIO WHERE USU_USU='" & nomUsu & "'", con.strConex)
            resp = enunc.ExecuteReader

            If resp.Read Then
                resul = True
            End If
            resp.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Desconectar()
        End Try
        Return resul
    End Function

    Public Function pass(ByVal nomUsu As String) As String
        Dim resul As String = ""
        Try
            con.Conectar()
            enunc = New SqlCommand("SELECT USU_CLAVE FROM USUARIO WHERE USU_USU='" & nomUsu & "'", con.strConex)
            resp = enunc.ExecuteReader

            If resp.Read Then
                resul = resp.Item("USU_CLAVE")
            End If
            resp.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Desconectar()
        End Try
        Return resul
    End Function


    Public Function listar_Usuario() As DataSet
        Dim objDat As New DataSet
        con.Conectar()
        Dim comando As New SqlDataAdapter("SELECT USU_DNI AS DNI, USU_NOM AS NOMBRE, USU_DIR AS DIRECCION, USU_TEL AS TELEFONO, USU_EMAIL AS EMAIL, USU_TIPO AS TIPO FROM USUARIO ORDER BY NOMBRE", con.strConex)
        'Dim comando As New SqlDataAdapter("select * from Usuarios", Con.strConex)
        comando.Fill(objDat, "Usuario")
        con.Desconectar()
        Return objDat
    End Function

    Public Function registrar_usuario() As Boolean
        Try
            con.Conectar()
            Dim data As Byte() = System.IO.File.ReadAllBytes(USU_IMAGEN)

            Dim comando = New SqlCommand("proc_InsertarUsuario")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = con.strConex
            comando.Parameters.AddWithValue("@codigo", USU_DNI)
            comando.Parameters.AddWithValue("@nombre", USU_NOM)
            comando.Parameters.AddWithValue("@direccion", USU_DIR)
            comando.Parameters.AddWithValue("@telefono", USU_TEL)
            comando.Parameters.AddWithValue("@correo", USU_CORREO)
            comando.Parameters.AddWithValue("@usuario", USU_USU)
            comando.Parameters.AddWithValue("@clave", USU_PAS)
            comando.Parameters.AddWithValue("@tipo", USU_TIPO)
            comando.Parameters.AddWithValue("@estado", USU_ESTA)
            comando.Parameters.AddWithValue("@imagen", data)

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

    Public Function modificar_usuario() As Boolean
        Try
            con.Conectar()
            Dim data As Byte() = System.IO.File.ReadAllBytes(USU_IMAGEN)

            Dim comando = New SqlCommand("proc_ModificarUsuario")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = con.strConex
            comando.Parameters.AddWithValue("@codigo", USU_DNI)
            comando.Parameters.AddWithValue("@nombre", USU_NOM)
            comando.Parameters.AddWithValue("@direccion", USU_DIR)
            comando.Parameters.AddWithValue("@telefono", USU_TEL)
            comando.Parameters.AddWithValue("@correo", USU_CORREO)
            comando.Parameters.AddWithValue("@usuario", USU_USU)
            comando.Parameters.AddWithValue("@clave", USU_PAS)
            comando.Parameters.AddWithValue("@tipo", USU_TIPO)
            comando.Parameters.AddWithValue("@estado", USU_ESTA)
            comando.Parameters.AddWithValue("@imagen", data)


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

    Public Function eliminar_usuario() As Boolean
        con.Conectar()
        Dim comando As New SqlCommand("proc_EliminarUsuario")
        comando.CommandType = CommandType.StoredProcedure
        comando.Connection = con.strConex
        comando.Parameters.AddWithValue("@codigo", USU_DNI)
        Try
            comando.ExecuteNonQuery()
            Return True
            con.Desconectar()
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
