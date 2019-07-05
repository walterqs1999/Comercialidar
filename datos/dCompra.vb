Public Class dCompra

    'CABECERA
    Public _CABCO_NUMDOC As Integer
    Public _CABCO_TIPODOC As String
    Public _PROV_RUC As String
    Public _USU_DNI As String
    Public _CABCO_TOTAL As Decimal
    Public _CABCO_SUBT As Decimal
    Public _CABCO_IGV As Decimal
    Public _CABCO_FECHA As Date

    'DETALLE
    Public _CABCO_ID As Integer
    Public _DETCO_NUMDOC As Integer
    Public _DETCO_TIPODOC As String
    Public _PRO_COD As Integer
    Public _DETCO_PCU As Decimal
    Public _DETCO_PVU As Decimal
    Public _DETCO_CANTIDAD As Integer
    Public _DETCO_TOTALPRO As Decimal


    'CABECERA
    Public Property CABCO_NUMDOC As Integer
        Get
            Return _CABCO_NUMDOC
        End Get
        Set(value As Integer)
            _CABCO_NUMDOC = value
        End Set
    End Property

    Public Property CABCO_TIPODOC As String
        Get
            Return _CABCO_TIPODOC
        End Get
        Set(value As String)
            _CABCO_TIPODOC = value
        End Set
    End Property

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

    Public Property CABCO_TOTAL As Decimal
        Get
            Return _CABCO_TOTAL
        End Get
        Set(value As Decimal)
            _CABCO_TOTAL = value
        End Set
    End Property

    Public Property CABCO_SUBT As Decimal
        Get
            Return _CABCO_SUBT
        End Get
        Set(value As Decimal)
            _CABCO_SUBT = value
        End Set
    End Property

    Public Property CABCO_IGV As Decimal
        Get
            Return _CABCO_IGV
        End Get
        Set(value As Decimal)
            _CABCO_IGV = value
        End Set
    End Property

    Public Property CABCO_FECHA As Date
        Get
            Return _CABCO_FECHA
        End Get
        Set(value As Date)
            _CABCO_FECHA = value
        End Set
    End Property


    'DETALLE
    Public Property CABCO_ID As Integer
        Get
            Return _CABCO_ID
        End Get
        Set(value As Integer)
            _CABCO_ID = value
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

    Public Property DETCO_PCU As Decimal
        Get
            Return _DETCO_PCU
        End Get
        Set(value As Decimal)
            _DETCO_PCU = value
        End Set
    End Property

    Public Property DETCO_PVU As Decimal
        Get
            Return _DETCO_PVU
        End Get
        Set(value As Decimal)
            _DETCO_PVU = value
        End Set
    End Property

    Public Property DETCO_CANTIDAD As Integer
        Get
            Return _DETCO_CANTIDAD
        End Get
        Set(value As Integer)
            _DETCO_CANTIDAD = value
        End Set
    End Property

    Public Property DETCO_TOTALPRO As Decimal
        Get
            Return _DETCO_TOTALPRO
        End Get
        Set(value As Decimal)
            _DETCO_TOTALPRO = value
        End Set
    End Property

    Public Property DETCO_TIPODOC As String
        Get
            Return _DETCO_TIPODOC
        End Get
        Set(value As String)
            _DETCO_TIPODOC = value
        End Set
    End Property

    Public Property DETCO_NUMDOC As Integer
        Get
            Return _DETCO_NUMDOC
        End Get
        Set(value As Integer)
            _DETCO_NUMDOC = value
        End Set
    End Property
End Class
