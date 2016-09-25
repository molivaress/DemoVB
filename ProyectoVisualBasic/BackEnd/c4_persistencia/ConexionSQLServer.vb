Imports System.Data.SqlClient

Public Class ConexionSQLServer
    Inherits GestorJDBC

    Public Overrides Sub abrirConexion()
        Try
            Dim url As String = "Data Source=.;Initial Catalog=bdistemacitas;User ID=sa;Password=123456;MultipleActiveResultSets=true;"
            conexion = New SqlConnection(url)
            conexion.Open()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
