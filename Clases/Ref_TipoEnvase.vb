Public Class Ref_TipoEnvase
    Private idRef_TipoEnvase As Integer
    Private nombreTipoEnvase As String

    Public Sub New()
    End Sub

    Public Sub New(idRef_TipoEnvase As Integer, nombreTipoEnvase As String)
        Me.idRef_TipoEnvase = idRef_TipoEnvase
        Me.nombreTipoEnvase = nombreTipoEnvase
    End Sub

    Public Property IdRef_TipoEnvase1 As Integer
        Get
            Return idRef_TipoEnvase
        End Get
        Set(value As Integer)
            idRef_TipoEnvase = value
        End Set
    End Property

    Public Property NombreTipoEnvase1 As String
        Get
            Return nombreTipoEnvase
        End Get
        Set(value As String)
            nombreTipoEnvase = value
        End Set
    End Property
End Class
