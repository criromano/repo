Public Class DetalleCompra
    Private idDetalleCompra As Integer
    Private idCompra As Integer
    Private cantidad As Integer
    Private importe As Double
    Private idProducto As Integer

    Public Sub New()
    End Sub

    Public Sub New(idDetalleCompra As Integer, idCompra As Integer, cantidad As Integer, importe As Double, idProducto As Integer)
        Me.IdDetalleCompra1 = idDetalleCompra
        Me.IdCompra1 = idCompra
        Me.Cantidad1 = cantidad
        Me.Importe1 = importe
        Me.IdProducto1 = idProducto
    End Sub

    Public Property IdDetalleCompra1 As Integer
        Get
            Return idDetalleCompra
        End Get
        Set(value As Integer)
            idDetalleCompra = value
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

    Public Property IdProducto1 As Integer
        Get
            Return idProducto
        End Get
        Set(value As Integer)
            idProducto = value
        End Set
    End Property
End Class
