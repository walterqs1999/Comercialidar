Public Class dCategorias
    Public _CAT_NOM As String
    Public _USU_DNI As String
    Public _CAT_ESTA As String

    Public Property CAT_ESTA As String
        Get
            Return _CAT_ESTA
        End Get
        Set(value As String)
            _CAT_ESTA = value
        End Set
    End Property

    Public Property CAT_NOM As String
        Get
            Return _CAT_NOM
        End Get
        Set(value As String)
            _CAT_NOM = value
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
End Class
