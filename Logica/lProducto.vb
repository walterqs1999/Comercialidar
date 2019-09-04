Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class lProducto
    Public conexx As SqlConnection
    Public enunc As SqlCommand
    Public resp As SqlDataReader
    Public odap As SqlDataAdapter

    Dim con As New datos.dConexion

    Public USU_DNI As String
    Public CAT_COD As Integer
    Public PRO_NOM As String
    Public PRO_PCU As Decimal
    Public PRO_PVU As Decimal
    Public PRO_STOCK As Integer
    Public PRO_ESTA As String

    Public Sub cargar_combo(ByVal combo As ComboBox)
        Dim da As New SqlDataAdapter("SELECT * FROM CATEGORIAS", con.strConex)
        Dim dt As New DataTable
        da.Fill(dt)
        combo.DataSource = dt
        combo.DisplayMember = "CAT_NOM"
        combo.ValueMember = "CAT_COD"
    End Sub

    Public Function listar_productos() As DataSet
        Dim objDat As New DataSet
        con.Conectar()
        Dim comando As New SqlDataAdapter("SELECT * FROM vistaMostarProductos", con.strConex)
        'Dim comando As New SqlDataAdapter("select * from Usuarios", Con.strConex)
        comando.Fill(objDat, "productos")
        con.Desconectar()
        Return objDat
    End Function

    Public Function registrar_producto() As Boolean
        Try
            con.Conectar()
            Dim comando = New SqlCommand("proc_InsertarProducto")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = con.strConex
            comando.Parameters.AddWithValue("@codUsu", USU_DNI)
            comando.Parameters.AddWithValue("@codCat", CAT_COD)
            comando.Parameters.AddWithValue("@nombre", PRO_NOM)
            comando.Parameters.AddWithValue("@precioC", PRO_PCU)
            comando.Parameters.AddWithValue("@precioV", PRO_PVU)
            comando.Parameters.AddWithValue("@stock", PRO_STOCK)
            comando.Parameters.AddWithValue("@estado", PRO_ESTA)

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

    Public Function modificar_producto() As Boolean
        Try
            con.Conectar()
            Dim comando = New SqlCommand("proc_ModificarProducto")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = con.strConex
            comando.Parameters.AddWithValue("@codigo", codigoPro)
            comando.Parameters.AddWithValue("@codUsu", USU_DNI)
            comando.Parameters.AddWithValue("@codCat", CAT_COD)
            comando.Parameters.AddWithValue("@nombre", PRO_NOM)
            comando.Parameters.AddWithValue("@precioC", PRO_PCU)
            comando.Parameters.AddWithValue("@precioV", PRO_PVU)
            comando.Parameters.AddWithValue("@stock", PRO_STOCK)
            comando.Parameters.AddWithValue("@estado", PRO_ESTA)
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

    Public Function eliminar_producto() As Boolean
        con.Conectar()
        Dim comando As New SqlCommand("proc_EliminarProducto")
        comando.CommandType = CommandType.StoredProcedure
        comando.Connection = con.strConex
        comando.Parameters.AddWithValue("@codigo", codigoPro)
        Try
            comando.ExecuteNonQuery()
            Return True
            con.Desconectar()
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
