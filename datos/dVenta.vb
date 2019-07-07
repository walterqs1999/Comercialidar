Public Class dVenta
    'CABECERA
    Public _CABVE_NUMDOC As Integer
    Public _CABVE_TIPODOC As String
    Public _CLI_DNI As String
    Public _USU_DNI As String
    Public _CABVE_TOTAL As Decimal
    Public _CABVE_SUBT As Decimal
    Public _CABVE_IGV As Decimal
    Public _CABVE_FECHA As Date

    'DETALLE
    Public _CABVE_ID As Integer
    Public _DETVE_NUMDOC As Integer
    Public _DETVE_TIPODOC As String
    Public _PRO_COD As Integer
    Public _DETVE_PVU As Decimal
    Public _DETVE_CANTIDAD As Integer
    Public _DETVE_TOTALPRO As Decimal

    'CABECERA
    Public Property CABVE_NUMDOC As Integer
        Get
            Return _CABVE_NUMDOC
        End Get
        Set(value As Integer)
            _CABVE_NUMDOC = value
        End Set
    End Property

    Public Property CABVE_TIPODOC As String
        Get
            Return _CABVE_TIPODOC
        End Get
        Set(value As String)
            _CABVE_TIPODOC = value
        End Set
    End Property

    Public Property CLI_DNI As String
        Get
            Return _CLI_DNI
        End Get
        Set(value As String)
            _CLI_DNI = value
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

    Public Property CABVE_TOTAL As Decimal
        Get
            Return _CABVE_TOTAL
        End Get
        Set(value As Decimal)
            _CABVE_TOTAL = value
        End Set
    End Property

    Public Property CABVE_SUBT As Decimal
        Get
            Return _CABVE_SUBT
        End Get
        Set(value As Decimal)
            _CABVE_SUBT = value
        End Set
    End Property

    Public Property CABVE_IGV As Decimal
        Get
            Return _CABVE_IGV
        End Get
        Set(value As Decimal)
            _CABVE_IGV = value
        End Set
    End Property

    Public Property CABVE_FECHA As Date
        Get
            Return _CABVE_FECHA
        End Get
        Set(value As Date)
            _CABVE_FECHA = value
        End Set
    End Property

    'DETALLE
    Public Property CABVE_ID As Integer
        Get
            Return _CABVE_ID
        End Get
        Set(value As Integer)
            _CABVE_ID = value
        End Set
    End Property

    Public Property DETVE_NUMDOC As Integer
        Get
            Return _DETVE_NUMDOC
        End Get
        Set(value As Integer)
            _DETVE_NUMDOC = value
        End Set
    End Property

    Public Property DETVE_TIPODOC As String
        Get
            Return _DETVE_TIPODOC
        End Get
        Set(value As String)
            _DETVE_TIPODOC = value
        End Set
    End Property

    Public Property PRO_COD As Integer
        Get
            Return _PRO_COD
        End Get
        Set(value As Integer)
            _PRO_COD = value
        End Set
    End Property

    Public Property DETVE_PVU As Decimal
        Get
            Return _DETVE_PVU
        End Get
        Set(value As Decimal)
            _DETVE_PVU = value
        End Set
    End Property

    Public Property DETVE_CANTIDAD As Integer
        Get
            Return _DETVE_CANTIDAD
        End Get
        Set(value As Integer)
            _DETVE_CANTIDAD = value
        End Set
    End Property

    Public Property DETVE_TOTALPRO As Decimal
        Get
            Return _DETVE_TOTALPRO
        End Get
        Set(value As Decimal)
            _DETVE_TOTALPRO = value
        End Set
    End Property
End Class
