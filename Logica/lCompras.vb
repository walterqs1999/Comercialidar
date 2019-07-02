﻿'Imports System
'Imports System.Data
Imports System.Data.SqlClient

Imports datos

Public Class lCompras
    Public conexx As SqlConnection
    Public enunc As SqlCommand
    Public resp As SqlDataReader
    Public odap As SqlDataAdapter
    Public oDataSet As DataSet

    Public StrSql As String
    Dim con As New datos.dConexion

    Dim rpta As Integer

    'CABECERA
    Public CABCO_NUMDOC As Integer
    Public CABCO_TIPODOC As String
    Public PROV_RUC As String
    Public USU_DNI As String
    Public CABCO_TOTAL As Decimal
    Public CABCO_SUBT As Decimal
    Public CABCO_IGV As Decimal
    Public CABCO_FECHA As Date

    'DETALLE
    Public CABCO_ID As Integer
    Public DETCO_TIPODOC As String
    Public PRO_COD As Integer
    Public DETCO_PCU As Decimal
    Public DETCO_PVU As Decimal
    Public DETCO_CANTIDAD As Integer
    Public DETCO_TOTALPRO As Decimal

    Public Sub Contar()

        con.Conectar()
        Dim can As Integer
        Dim comando = New SqlCommand("SELECT * FROM CABECERA_COMPRA")
        odap = New SqlDataAdapter(comando)
        oDataSet = New DataSet
        odap.Fill(oDataSet)
        can = oDataSet.Tables(0).Rows.Count
        If can < 1 Then
            docuid = 1
        Else
            docuid = can + 1
        End If
    End Sub

    Public Function registrar_cabeceraC() As Boolean
        Try
            con.Conectar()

            Dim comando = New SqlCommand("proc_InsertarCabeceraCompra")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = con.strConex
            comando.Parameters.AddWithValue("@numdoc", CABCO_NUMDOC)
            comando.Parameters.AddWithValue("@tipodoc", CABCO_TIPODOC)
            comando.Parameters.AddWithValue("@provruc", PROV_RUC)
            comando.Parameters.AddWithValue("@usudni", USU_DNI)
            comando.Parameters.AddWithValue("@total", CABCO_TOTAL)
            comando.Parameters.AddWithValue("@subtotal", CABCO_SUBT)
            comando.Parameters.AddWithValue("@igv", CABCO_IGV)
            comando.Parameters.AddWithValue("@fecha", CABCO_FECHA)

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

    Public Function registrar_detalleC() As Boolean
        Try
            con.Conectar()

            Dim comando = New SqlCommand("proc_InsertarDetalleCompra")

            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = con.strConex

            comando.Parameters.Clear()

            comando.Parameters.AddWithValue("@idcabecera", CABCO_ID)
            comando.Parameters.AddWithValue("@tipodoc", DETCO_TIPODOC)
            comando.Parameters.AddWithValue("@codprod", PRO_COD)
            comando.Parameters.AddWithValue("@pcu", DETCO_PCU)
            comando.Parameters.AddWithValue("@pvu", DETCO_PVU)
            comando.Parameters.AddWithValue("@cantidad", DETCO_CANTIDAD)
            comando.Parameters.AddWithValue("@total", DETCO_TOTALPRO)

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

    Public Function proRegistrado(ByVal codProveedor As String) As Boolean
        con.Conectar()
        Dim resul As Boolean = False
        Try
            enunc = New SqlCommand("SELECT PROV_NOM, PROV_DIREC FROM PROVEEDORES WHERE PROV_RUC='" & codProveedor & "'", con.strConex)
            resp = enunc.ExecuteReader

            If resp.Read Then
                resul = True

                nomProv = resp.Item("PROV_NOM")
                dirProv = resp.Item("PROV_DIREC")
            End If
            resp.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Desconectar()
        End Try
        Return resul
    End Function

    Public Function productoRegistrado(ByVal codProducto As String) As Boolean
        con.Conectar()
        Dim resul As Boolean = False
        Try
            enunc = New SqlCommand("SELECT PRO_NOM, PRO_PCU, PRO_PVU FROM PRODUCTO WHERE PRO_COD='" & codProducto & "'", con.strConex)
            resp = enunc.ExecuteReader

            If resp.Read Then
                resul = True

                nomProducto = resp.Item("PRO_NOM")
                pcuProducto = resp.Item("PRO_PCU")
                pvuProducto = resp.Item("PRO_PVU")
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