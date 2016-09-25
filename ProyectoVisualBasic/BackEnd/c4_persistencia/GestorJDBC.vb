Imports System.Data.SqlClient

Public MustInherit Class GestorJDBC
    Protected conexion As SqlConnection

    Public MustOverride Sub abrirConexion()

    Public Sub cerrarConexion()
        Try
            conexion.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub iniciarTransaccion()
        Try
            conexion.BeginTransaction().InitializeLifetimeService()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub terminarTransaccion()
        Try
            conexion.BeginTransaction.Commit()
            conexion.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub cancelarTransaccion()
        Try
            conexion.BeginTransaction.Rollback()
            conexion.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function prepararSentencia(ByVal sql As String) As SqlCommand
        Dim sentencia As SqlCommand
        sentencia = New SqlCommand(sql, conexion)
        Return sentencia
    End Function
    Public Function ejecutarConsulta(ByVal sql As String) As SqlDataReader
        Dim resultado As SqlDataReader
        Dim sentencia As SqlCommand
        sentencia = prepararSentencia(sql)
        resultado = sentencia.ExecuteReader()
        Return resultado
    End Function

End Class
