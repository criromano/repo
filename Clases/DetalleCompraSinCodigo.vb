Public Class DetalleCompraSinCodigo
    Private idDetalleCompraSinCodigo As Integer
    Private idCompra As Integer
    Private cantidad As Integer
    Private importe As Double
    Private idProductoSinCodigo As Integer

    Public Sub New()
    End Sub

    Public Sub New(idDetalleCompraSinCodigo As Integer, idCompra As Integer, cantidad As Integer, importe As Double, idProductoSinCodigo As Integer)
        Me.IdDetalleCompraSinCodigo1 = idDetalleCompraSinCodigo
        Me.IdCompra1 = idCompra
        Me.Cantidad1 = cantidad
        Me.Importe1 = importe
        Me.IdProductoSinCodigo1 = idProductoSinCodigo
    End Sub

    Public Property IdDetalleCompraSinCodigo1 As Integer
        Get
            Return idDetalleCompraSinCodigo
        End Get
        Set(value As Integer)
            idDetalleCompraSinCodigo = value
        End Set
    End Property

    Public Property IdCompra1 As Integer
        Get
            Return idCompra
        End Get
        Set(value As Integer)
            idCompra = value
        End Set
    End Property

    Public Property Cantidad1 As Integer
        Get
            Return cantidad
        End Get
        Set(value As Integer)
            cantidad = value
        End Set
    End Property

    Public Property Importe1 As Double
        Get
            Return importe
        End Get
        Set(value As Double)
            importe = value
        End Set
    End Property

    Public Property IdProductoSinCodigo1 As Integer
        Get
            Return idProductoSinCodigo
        End Get
        Set(value As Integer)
            idProductoSinCodigo = value
        End Set
    End Property
End Class
