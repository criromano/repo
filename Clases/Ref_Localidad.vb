Public Class Ref_Localidad
    Private idRef_Localidad As Integer
    Private nombre As String

    Public Sub New()
    End Sub

    Public Sub New(idRef_Localidad As Integer, nombre As String)
        Me.IdRef_Localidad1 = idRef_Localidad
        Me.Nombre1 = nombre
    End Sub

    Public Property IdRef_Localidad1 As Integer
        Get
            Return idRef_Localidad
        End Get
        Set(value As Integer)
            idRef_Localidad = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
End Class
