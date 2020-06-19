Public Class Compras
    Private idCompra As Integer
    Private fechaCompra As Date
    Private importeTotalDeCompra As Double
    Private idRef_CondicionVentaCompra As Integer
    Private idProveedor As Integer

    Public Sub New()
    End Sub

    Public Sub New(idCompra As Integer, fechaCompra As Date, importeTotalDeCompra As Double, idRef_CondicionVentaCompra As Integer, idProveedor As Integer)
        Me.idCompra = idCompra
        Me.fechaCompra = fechaCompra
        Me.importeTotalDeCompra = importeTotalDeCompra
        Me.idRef_CondicionVentaCompra = idRef_CondicionVentaCompra
        Me.idProveedor = idProveedor
    End Sub

    Public Property IdCompra1 As Integer
        Get
            Return idCompra
        End Get
        Set(value As Integer)
            idCompra = value
        End Set
    End Property

    Public Property FechaCompra1 As Date
        Get
            Return fechaCompra
        End Get
        Set(value As Date)
            fechaCompra = value
        End Set
    End Property

    Public Property ImporteTotalDeCompra1 As Double
        Get
            Return importeTotalDeCompra
        End Get
        Set(value As Double)
            importeTotalDeCompra = value
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

    Public Property IdProveedor1 As Integer
        Get
            Return idProveedor
        End Get
        Set(value As Integer)
            idProveedor = value
        End Set
    End Property
End Class
