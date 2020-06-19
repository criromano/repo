Public Class PrecioDeVenta
    Private idPrecioDeVenta As Integer
    Private precio As Double
    Private fechaDesde As Date

    Public Sub New()
    End Sub

    Public Sub New(idPrecioDeVenta As Integer, idProducto As Integer, precio As Double, fechaDesde As Date)
        Me.idPrecioDeVenta = idPrecioDeVenta
        Me.precio = precio
        Me.fechaDesde = fechaDesde
    End Sub

    Public Property IdPrecioDeVenta1 As Integer
        Get
            Return idPrecioDeVenta
        End Get
        Set(value As Integer)
            idPrecioDeVenta = value
        End Set
    End Property

    Public Property Precio1 As Double
        Get
            Return precio
        End Get
        Set(value As Double)
            precio = value
        End Set
    End Property

    Public Property FechaDesde1 As Date
        Get
            Return fechaDesde
        End Get
        Set(value As Date)
            fechaDesde = value
        End Set
    End Property
End Class
