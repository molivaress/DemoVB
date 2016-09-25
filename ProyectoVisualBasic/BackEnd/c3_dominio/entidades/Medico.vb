Public Class Medico
    Private codigo As String
    Private nombre As String
    Public Property nombreProp() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property
    Public Property CodigoProp() As String
        Get
            Return codigo
        End Get
        Set(ByVal value As String)
            codigo = value
        End Set
    End Property

End Class
