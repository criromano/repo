Public Class Ref_RubroProducto
    Private idRef_RubroProducto As Integer
    Private nombreRubroProducto As String

    Public Sub New()
    End Sub

    Public Sub New(idRef_RubroProducto As Integer, nombreRubroProducto As String)
        Me.idRef_RubroProducto = idRef_RubroProducto
        Me.nombreRubroProducto = nombreRubroProducto
    End Sub

    Public Property IdRef_RubroProducto1 As Integer
        Get
            Return idRef_RubroProducto
        End Get
        Set(value As Integer)
            idRef_RubroProducto = value
        End Set
    End Property

    Public Property NombreRubroProducto1 As String
        Get
            Return nombreRubroProducto
        End Get
        Set(value As String)
            nombreRubroProducto = value
        End Set
    End Property
End Class
