'Imports System
'Imports System.Data
Imports System.Data.SqlClient

Imports datos

Public Class lVentas

    Public conexx As SqlConnection
    Public enunc As SqlCommand
    Public resp As SqlDataReader
    Public odap As SqlDataAdapter
    Public oDataSet As DataSet

    Public StrSql As String
    Dim con As New datos.dConexion

    Dim rpta As Integer

    'CABECERA
    Public CABVE_NUMDOC As Integer
    Public CABVE_TIPODOC As String
    Public CLI_DNI As String
    Public USU_DNI As String
    Public CABVE_TOTAL As Decimal
    Public CABVE_SUBT As Decimal
    Public CABVE_IGV As Decimal
    Public CABVE_FECHA As Date

    'DETALLE
    Public CABVE_ID As Integer
    Public DETVE_NUMDOC As Integer
    Public DETVE_TIPODOC As String
    Public PRO_COD As Integer
    Public DETVE_PVU As Decimal
    Public DETVE_CANTIDAD As Integer
    Public DETVE_TOTALPRO As Decimal

    Public Function numerodocumento(ByVal tipo As String) As Boolean
        con.Conectar()
        Dim resul As Boolean = False
        Try
            enunc = New SqlCommand("SELECT COUNT(CABVE_NUMDOC) AS NUMERO FROM CABECERA_VENTA WHERE CABVE_TIPODOC = '" & tipo & "'", con.strConex)
            resp = enunc.ExecuteReader
            If resp.Read Then
                numdocc = resp.Item("NUMERO")
                If numdocc < 1 Then
                    numdocc = 1
                Else
                    numdocc = numdocc + 1
                End If
                resul = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Desconectar()
        End Try
        Return resul
    End Function

    Public Function iddocumento() As Boolean
        con.Conectar()
        Dim resul As Boolean = False
        Try
            enunc = New SqlCommand("SELECT MAX(CABVE_ID) AS ID FROM CABECERA_VENTA", con.strConex)
            resp = enunc.ExecuteReader
            If resp.Read Then
                If IsDBNull(resp.Item("ID")) Then
                    iddocc = 1
                Else
                    iddocc = resp.Item("ID")
                    iddocc = iddocc + 1
                End If
                resul = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Desconectar()
        End Try
        Return resul
    End Function

    Public Function registrar_cabeceraV() As Boolean
        Try
            con.Conectar()

            Dim comando = New SqlCommand("proc_InsertarCabeceraVenta")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = con.strConex
            comando.Parameters.AddWithValue("@numdoc", CABVE_NUMDOC)
            comando.Parameters.AddWithValue("@tipodoc", CABVE_TIPODOC)
            comando.Parameters.AddWithValue("@clidni", CLI_DNI)
            comando.Parameters.AddWithValue("@usudni", USU_DNI)
            comando.Parameters.AddWithValue("@total", CABVE_TOTAL)
            comando.Parameters.AddWithValue("@subtotal", CABVE_SUBT)
            comando.Parameters.AddWithValue("@igv", CABVE_IGV)
            comando.Parameters.AddWithValue("@fecha", CABVE_FECHA)

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

    Public Function registrar_detalleV() As Boolean
        Try
            con.Conectar()

            Dim comando = New SqlCommand("proc_InsertarDetalleVenta")

            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = con.strConex

            comando.Parameters.Clear()

            comando.Parameters.AddWithValue("@idcabecera", CABVE_ID)
            comando.Parameters.AddWithValue("@numedoc", DETVE_NUMDOC)
            comando.Parameters.AddWithValue("@tipodoc", DETVE_TIPODOC)
            comando.Parameters.AddWithValue("@codprod", PRO_COD)
            comando.Parameters.AddWithValue("@pvu", DETVE_PVU)
            comando.Parameters.AddWithValue("@cantidad", DETVE_CANTIDAD)
            comando.Parameters.AddWithValue("@total", DETVE_TOTALPRO)

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

    Public Function cliRegistrado(ByVal codCliente As String) As Boolean
        con.Conectar()
        Dim resul As Boolean = False
        Try
            enunc = New SqlCommand("SELECT CLI_NOM, CLI_DIR FROM CLIENTE WHERE CLI_DNI='" & codCliente & "'", con.strConex)
            resp = enunc.ExecuteReader

            If resp.Read Then
                resul = True

                nomCli = resp.Item("CLI_NOM")
                dirCli = resp.Item("CLI_DIR")
            End If
            resp.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Desconectar()
        End Try
        Return resul
    End Function
End Class
