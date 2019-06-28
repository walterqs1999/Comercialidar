Imports System.Data.SqlClient

Public Class dCliente
    Public _CLI_DNI As String
    Public _USU_DNI As String
    Public _CLI_NOM As String
    Public _CLI_DIR As String
    Private _CLI_TEL As String
    Private _CLI_ESTA As String

    Public Property CLI_DNI As String
        Get
            Return _CLI_DNI
        End Get
        Set(ByVal value As String)
            _CLI_DNI = value
        End Set
    End Property

    Public Property USU_DNI As String
        Get
            Return _USU_DNI
        End Get
        Set(ByVal value As String)
            _USU_DNI = value
        End Set
    End Property

    Public Property CLI_NOM As String
        Get
            Return _CLI_NOM
        End Get
        Set(ByVal value As String)
            _CLI_NOM = value
        End Set
    End Property

    Public Property CLI_DIR As String
        Get
            Return _CLI_DIR
        End Get
        Set(ByVal value As String)
            _CLI_DIR = value
        End Set
    End Property

    Public Property CLI_TEL As String
        Get
            Return _CLI_TEL
        End Get
        Set(value As String)
            _CLI_TEL = value
        End Set
    End Property

    Public Property CLI_ESTA As String
        Get
            Return _CLI_ESTA
        End Get
        Set(value As String)
            _CLI_ESTA = value
        End Set
    End Property
End Class
