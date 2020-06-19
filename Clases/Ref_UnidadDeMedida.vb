Public Class Ref_UnidadDeMedida
    Private idRef_UnidadDeMedida As Integer
    Private nombreUnidadDeMedida As String

    Public Sub New()
    End Sub

    Public Sub New(idRef_UnidadDeMedida As Integer, nombreUnidadDeMedida As String)
        Me.idRef_UnidadDeMedida = idRef_UnidadDeMedida
        Me.nombreUnidadDeMedida = nombreUnidadDeMedida
    End Sub

    Public Property IdRef_UnidadDeMedida1 As Integer
        Get
            Return idRef_UnidadDeMedida
        End Get
        Set(value As Integer)
            idRef_UnidadDeMedida = value
        End Set
    End Property

    Public Property NombreUnidadDeMedida1 As String
        Get
            Return nombreUnidadDeMedida
        End Get
        Set(value As String)
            nombreUnidadDeMedida = value
        End Set
    End Property
End Class
