Public Class Ref_TipoProducto
    Private idRef_TipoProducto As Integer
    Private nombreTipoProducto As String

    Public Sub New()
    End Sub

    Public Sub New(idRef_TipoProducto As Integer, nombreTipoProducto As String)
        Me.idRef_TipoProducto = idRef_TipoProducto
        Me.nombreTipoProducto = nombreTipoProducto
    End Sub

    Public Property IdRef_TipoProducto1 As Integer
        Get
            Return idRef_TipoProducto
        End Get
        Set(value As Integer)
            idRef_TipoProducto = value
        End Set
    End Property

    Public Property NombreTipoProducto1 As String
        Get
            Return nombreTipoProducto
        End Get
        Set(value As String)
            nombreTipoProducto = value
        End Set
    End Property
End Class
