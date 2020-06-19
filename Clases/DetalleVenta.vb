Public Class DetalleVenta
    Private idDetalleVenta As Integer
    Private idVenta As Integer
    Private cantidad As Integer
    Private importe As Double
    Private idProducto As Integer

    Public Sub New()
    End Sub

    Public Sub New(idDetalleVenta As Integer, idVenta As Integer, cantidad As Integer, importe As Double, idProducto As Integer)
        Me.idDetalleVenta = idDetalleVenta
        Me.idVenta = idVenta
        Me.cantidad = cantidad
        Me.importe = importe
        Me.IdProducto1 = idProducto
    End Sub

    Public Property IdDetalleVenta1 As Integer
        Get
            Return idDetalleVenta
        End Get
        Set(value As Integer)
            idDetalleVenta = value
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

    Public Property IdProducto1 As Integer
        Get
            Return idProducto
        End Get
        Set(value As Integer)
            idProducto = value
        End Set
    End Property
End Class
