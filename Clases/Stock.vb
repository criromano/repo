Public Class Stock
    Private idStock As Integer
    Private idProducto As Integer
    Private stock As Integer

    Public Sub New()
    End Sub

    Public Sub New(idStock As Integer, idProducto As Integer, stock As Integer)
        Me.idStock = idStock
        Me.idProducto = idProducto
        Me.stock = stock
    End Sub

    Public Property IdStock1 As Integer
        Get
            Return idStock
        End Get
        Set(value As Integer)
            idStock = value
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

    Public Property Stock1 As Integer
        Get
            Return stock
        End Get
        Set(value As Integer)
            stock = value
        End Set
    End Property
End Class
