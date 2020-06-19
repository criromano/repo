Public Class Ventas
    Private idVenta As Integer
    Private fechaVenta As Date
    Private importeTotalDeVenta As Double
    Private idRef_CondicionVentaCompra As Integer
    Private idCliente As Integer

    Public Sub New()
    End Sub

    Public Sub New(idVenta As Integer, fechaVenta As Date, importeTotalDeVenta As Double, idRef_CondicionVentaCompra As Integer, idCliente As Integer)
        Me.idVenta = idVenta
        Me.fechaVenta = fechaVenta
        Me.importeTotalDeVenta = importeTotalDeVenta
        Me.idRef_CondicionVentaCompra = idRef_CondicionVentaCompra
        Me.idCliente = idCliente
    End Sub

    Public Property IdVenta1 As Integer
        Get
            Return idVenta
        End Get
        Set(value As Integer)
            idVenta = value
        End Set
    End Property

    Public Property FechaVenta1 As Date
        Get
            Return fechaVenta
        End Get
        Set(value As Date)
            fechaVenta = value
        End Set
    End Property

    Public Property ImporteTotalDeVenta1 As Double
        Get
            Return importeTotalDeVenta
        End Get
        Set(value As Double)
            importeTotalDeVenta = value
        End Set
    End Property

    Public Property IdRef_CondicionVentaCompra1 As Integer
        Get
            Return idRef_CondicionVentaCompra
        End Get
        Set(value As Integer)
            idRef_CondicionVentaCompra = value
        End Set
    End Property

    Public Property IdCliente1 As Integer
        Get
            Return idCliente
        End Get
        Set(value As Integer)
            idCliente = value
        End Set
    End Property
End Class
