Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class dConexion
    Public strConex As New SqlConnection("Data Source=DESKTOP-1TFGD1S\SQLEXPRESS;Initial Catalog=COMERCIAL_IDAR;User ID=sa;Password=sqlserver")

    Public Sub Conectar()
        Try
            'strConex.ConnectionString = "Data source = (local); Initial Catalog = BDCinema; User ID = sa; Password = 2019"
            'strConex.ConnectionString = "Data Source=(local);Initial Catalog=COMERCIAL_IDAR;Integrated Security=True"
            'strConex.ConnectionString = "Data Source=DESKTOP-1TFGD1S\SQLEXPRESS;Initial Catalog=COMERCIAL_IDAR;User ID=sa;Password=sqlserver"

            strConex.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
            strConex.Close()
        End Try
    End Sub

    Public Sub Desconectar()
        strConex.Close()
    End Sub

End Class