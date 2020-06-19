Public Class Producto
    Private idProducto As Integer
    Private nombreProducto As String
    Private idRef_UnidadDeMedida As Integer
    Private medida As Double
    Private codigoBarras As String
    Private stockMinimo As Integer
    Private idRef_RubroProducto As Integer
    Private idRef_TipoProduto As Integer
    Private idRef_TipoEnvase As Integer
    Private idRef_Marca As Integer
    Private idPrecioDeVenta As Integer
    Private vigente As Boolean

    Public Sub New()
    End Sub

    Public Sub New(idProducto As Integer, nombreProducto As String, idRef_UnidadDeMedida As Integer, medida As Double, codigoBarras As String, stockMinimo As Integer, idRef_RubroProducto As Integer, idRef_TipoProduto As Integer, idRef_TipoEnvase As Integer, idRef_Marca As Integer, vigente As Boolean)
        Me.idProducto = idProducto
        Me.nombreProducto = nombreProducto
        Me.idRef_UnidadDeMedida = idRef_UnidadDeMedida
        Me.medida = medida
        Me.codigoBarras = codigoBarras
        Me.stockMinimo = stockMinimo
        Me.idRef_RubroProducto = idRef_RubroProducto
        Me.idRef_TipoProduto = idRef_TipoProduto
        Me.idRef_TipoEnvase = idRef_TipoEnvase
        Me.idRef_Marca = idRef_Marca
        Me.vigente = vigente
    End Sub

    Public Property IdProducto1 As Integer
        Get
            Return idProducto
        End Get
        Set(value As Integer)
            idProducto = value
        End Set
    End Property

    Public Property NombreProducto1 As String
        Get
            Return nombreProducto
        End Get
        Set(value As String)
            nombreProducto = value
        End Set
    End Property

    Public Property IdRef_UnidadDeMedida1 As Integer
        Get
            Return idRef_UnidadDeMedida
        End Get
        Set(value As Integer)
            idRef_UnidadDeMedida = value
        End Set
    End Property

    Public Property Medida1 As Double
        Get
            Return medida
        End Get
        Set(value As Double)
            medida = value
        End Set
    End Property

    Public Property CodigoBarras1 As String
        Get
            Return codigoBarras
        End Get
        Set(value As String)
            codigoBarras = value
        End Set
    End Property

    Public Property StockMinimo1 As Integer
        Get
            Return stockMinimo
        End Get
        Set(value As Integer)
            stockMinimo = value
        End Set
    End Property

    Public Property IdRef_RubroProducto1 As Integer
        Get
            Return idRef_RubroProducto
        End Get
        Set(value As Integer)
            idRef_RubroProducto = value
        End Set
    End Property

    Public Property IdRef_TipoProduto1 As Integer
        Get
            Return idRef_TipoProduto
        End Get
        Set(value As Integer)
            idRef_TipoProduto = value
        End Set
    End Property

    Public Property IdRef_TipoEnvase1 As Integer
        Get
            Return idRef_TipoEnvase
        End Get
        Set(value As Integer)
            idRef_TipoEnvase = value
        End Set
    End Property

    Public Property IdRef_Marca1 As Integer
        Get
            Return idRef_Marca
        End Get
        Set(value As Integer)
            idRef_Marca = value
        End Set
    End Property

    Public Property IdPrecioDeVenta1 As Integer
        Get
            Return idPrecioDeVenta
        End Get
        Set(value As Integer)
            idPrecioDeVenta = value
        End Set
    End Property

    Public Property Vigente1 As Boolean
        Get
            Return vigente
        End Get
        Set(value As Boolean)
            vigente = value
        End Set
    End Property
End Class
