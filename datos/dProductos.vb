Public Class dProductos
    Public _USU_DNI As String
    Public _CAT_COD As Integer
    Public _PRO_NOM As String
    Public _PRO_PCU As Decimal
    Public _PRO_PVU As Decimal
    Public _PRO_STOCK As Integer
    Public _PRO_ESTA As String

    Public Property USU_DNI As String
        Get
            Return _USU_DNI
        End Get
        Set(value As String)
            _USU_DNI = value
        End Set
    End Property

    Public Property CAT_COD As Integer
        Get
            Return _CAT_COD
        End Get
        Set(value As Integer)
            _CAT_COD = value
        End Set
    End Property

    Public Property PRO_NOM As String
        Get
            Return _PRO_NOM
        End Get
        Set(value As String)
            _PRO_NOM = value
        End Set
    End Property

    Public Property PRO_PCU As Decimal
        Get
            Return _PRO_PCU
        End Get
        Set(value As Decimal)
            _PRO_PCU = value
        End Set
    End Property

    Public Property PRO_PVU As Decimal
        Get
            Return _PRO_PVU
        End Get
        Set(value As Decimal)
            _PRO_PVU = value
        End Set
    End Property

    Public Property PRO_STOCK As Integer
        Get
            Return _PRO_STOCK
        End Get
        Set(value As Integer)
            _PRO_STOCK = value
        End Set
    End Property

    Public Property PRO_ESTA As String
        Get
            Return _PRO_ESTA
        End Get
        Set(value As String)
            _PRO_ESTA = value
        End Set
    End Property
End Class
