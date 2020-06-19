Public Class DetalleVentaSinCodigo
    Private idDetalleVentaSinCodigo As Integer
    Private idVenta As Integer
    Private cantidad As Integer
    Private importe As Double
    Private idProductoSinCodigo As Integer

    Public Sub New()
    End Sub

    Public Sub New(idDetalleVentaSinCodigo As Integer, idVenta As Integer, cantidad As Integer, importe As Double, idProductoSinCodigo As Integer)
        Me.IdDetalleVentaSinCodigo1 = idDetalleVentaSinCodigo
        Me.IdVenta1 = idVenta
        Me.Cantidad1 = cantidad
        Me.Importe1 = importe
        Me.IdProductoSinCodigo1 = idProductoSinCodigo
    End Sub

    Public Property IdDetalleVentaSinCodigo1 As Integer
        Get
            Return idDetalleVentaSinCodigo
        End Get
        Set(value As Integer)
            idDetalleVentaSinCodigo = value
        End Set
    End Property

    Public Property IdVenta1 As Integer
        Get
            Return idVenta
        End Get
        Set(value As Integer)
            idVenta = value
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
