Public Class Ref_TipoTelefono
    Private idRef_TipoTelefono As Integer
    Private nombre As String

    Public Sub New()
    End Sub

    Public Sub New(idRef_TipoTelefono As Integer, nombre As String)
        Me.IdRef_TipoTelefono1 = idRef_TipoTelefono
        Me.Nombre1 = nombre
    End Sub

    Public Property IdRef_TipoTelefono1 As Integer
        Get
            Return idRef_TipoTelefono
        End Get
        Set(value As Integer)
            idRef_TipoTelefono = value
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
