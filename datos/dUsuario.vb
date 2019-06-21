Imports System.Data.SqlClient

Public Class dUsuario
    'Dim con As New Datos.Conexion

    Private _USU_DNI As String
    Private _USU_NOM As String
    Private _USU_DIR As String
    Private _USU_TEL As String
    Private _USU_EMAIL As String
    Private _USU_USU As String
    Private _USU_CLAVE As String
    Private _USU_TIPO As String
    Private _USU_ESTA As String

    Public Property USU_DNI As Integer
        Get
            Return _USU_DNI
        End Get
        Set(ByVal value As Integer)
            _USU_DNI = value
        End Set
    End Property

    Public Property USU_NOM As String
        Get
            Return _USU_NOM
        End Get
        Set(ByVal value As String)
            _USU_NOM = value
        End Set
    End Property

    Public Property USU_DIR As String
        Get
            Return _USU_DIR
        End Get
        Set(ByVal value As String)
            _USU_DIR = value
        End Set
    End Property

    Public Property USU_TEL As String
        Get
            Return _USU_TEL
        End Get
        Set(ByVal value As String)
            _USU_TEL = value
        End Set
    End Property

    Public Property USU_EMAIL As String
        Get
            Return _USU_EMAIL
        End Get
        Set(ByVal value As String)
            _USU_EMAIL = value
        End Set
    End Property

    Public Property USU_USU As String
        Get
            Return _USU_USU
        End Get
        Set(ByVal value As String)
            _USU_USU = value
        End Set
    End Property

    Public Property USU_CLAVE As String
        Get
            Return _USU_CLAVE
        End Get
        Set(ByVal value As String)
            _USU_CLAVE = value
        End Set
    End Property

    Public Property USU_TIPO As String
        Get
            Return _USU_TIPO
        End Get
        Set(ByVal value As String)
            _USU_TIPO = value
        End Set
    End Property

    Public Property USU_ESTA As String
        Get
            Return _USU_ESTA
        End Get
        Set(ByVal value As String)
            _USU_ESTA = value
        End Set
    End Property
End Class
