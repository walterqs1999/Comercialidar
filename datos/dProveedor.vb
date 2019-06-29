Imports System.Data.SqlClient

Public Class dProveedor

    Private _PROV_RUC As String
    Private _USU_DNI As String
    Private _PROV_NOM As String
    Private _PROV_PERCARGO As String
    Private _PROV_DIREC As String
    Private _PROV_TEL As String
    Private _PROV_REFE As String
    Private _PROV_ESTA As String

    Public Property PROV_RUC As String
        Get
            Return _PROV_RUC
        End Get
        Set(value As String)
            _PROV_RUC = value
        End Set
    End Property

    Public Property USU_DNI As String
        Get
            Return _USU_DNI
        End Get
        Set(value As String)
            _USU_DNI = value
        End Set
    End Property

    Public Property PROV_NOM As String
        Get
            Return _PROV_NOM
        End Get
        Set(value As String)
            _PROV_NOM = value
        End Set
    End Property

    Public Property PROV_PERCARGO As String
        Get
            Return _PROV_PERCARGO
        End Get
        Set(value As String)
            _PROV_PERCARGO = value
        End Set
    End Property

    Public Property PROV_DIREC As String
        Get
            Return _PROV_DIREC
        End Get
        Set(value As String)
            _PROV_DIREC = value
        End Set
    End Property

    Public Property PROV_TEL As String
        Get
            Return _PROV_TEL
        End Get
        Set(value As String)
            _PROV_TEL = value
        End Set
    End Property

    Public Property PROV_REFE As String
        Get
            Return _PROV_REFE
        End Get
        Set(value As String)
            _PROV_REFE = value
        End Set
    End Property

    Public Property PROV_ESTA As String
        Get
            Return _PROV_ESTA
        End Get
        Set(value As String)
            _PROV_ESTA = value
        End Set
    End Property
End Class
