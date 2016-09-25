Imports BackEnd

Public Class GestionarMedicoServicio
    Dim gestorJDBC As GestorJDBC
    Dim medicoDAO As IMedicoDAO

    Public Sub New()
        gestorJDBC = New ConexionSQLServer()
        medicoDAO = New MedicoDAOSqlServer(gestorJDBC)
    End Sub

    Public Function ingresar(medico As Medico) As Integer
        Try
            gestorJDBC.abrirConexion()
            Dim retorno As Integer = medicoDAO.ingresar(medico)
            gestorJDBC.cerrarConexion()
            Return retorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
