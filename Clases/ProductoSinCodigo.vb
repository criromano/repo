Public Class ProductoSinCodigo
    Private idProductoSinCodigo As Integer
    Private nombre As String

    Public Sub New()
    End Sub

    Public Sub New(idProductoSinCodigo As Integer, nombre As String)
        Me.IdProductoSinCodigo1 = idProductoSinCodigo
        Me.Nombre1 = nombre
    End Sub

    Public Property IdProductoSinCodigo1 As Integer
        Get
            Return idProductoSinCodigo
        End Get
        Set(value As Integer)
            idProductoSinCodigo = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
End Class
