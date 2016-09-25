Imports System.Data.SqlClient
Imports BackEnd
Public Class MedicoDAOSqlServer
    Implements IMedicoDAO

    Dim gestorJDBC As GestorJDBC

    Public Sub New(ByVal gestorJDBCp As GestorJDBC)
        gestorJDBC = gestorJDBCp
    End Sub

    Public Function ingresar(medico As Medico) As Integer Implements IMedicoDAO.ingresar
        Try
            Dim retorno As Integer
            Dim nombreProcedimiento As String = "_medico_ingresar"
            Dim sentencia As SqlCommand = gestorJDBC.prepararSentencia(nombreProcedimiento)
            sentencia.CommandText = nombreProcedimiento
            sentencia.CommandType = CommandType.StoredProcedure
            sentencia.Parameters.Add("@codigo", SqlDbType.Char, 4).Value = medico.CodigoProp
            sentencia.Parameters.Add("@nombre", SqlDbType.NVarChar, 20).Value = medico.nombreProp
            retorno = sentencia.ExecuteNonQuery()
            Return retorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
