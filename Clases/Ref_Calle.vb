Public Class Ref_Calle
    Private idRef_Calle As Integer
    Private nombre As String

    Public Sub New()
    End Sub

    Public Sub New(idRef_Calle As Integer, nombre As String)
        Me.IdRef_Calle1 = idRef_Calle
        Me.Nombre1 = nombre
    End Sub

    Public Property IdRef_Calle1 As Integer
        Get
            Return idRef_Calle
        End Get
        Set(value As Integer)
            idRef_Calle = value
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
