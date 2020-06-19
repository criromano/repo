Public Class Domicilio
    Private idDomicilio As Integer
    Private idRef_Calle As Integer
    Private numero As Integer
    Private piso As String
    Private dpto As String
    Private idRef_Localidad As Integer

    Public Sub New()
    End Sub

    Public Sub New(idDomicilio As Integer, idRef_Calle As Integer, numero As Integer, piso As String, dpto As String, idRef_Localidad As Integer)
        Me.IdDomicilio1 = idDomicilio
        Me.IdRef_Calle1 = idRef_Calle
        Me.Numero1 = numero
        Me.Piso1 = piso
        Me.Dpto1 = dpto
        Me.IdRef_Localidad1 = idRef_Localidad
    End Sub

    Public Property IdDomicilio1 As Integer
        Get
            Return idDomicilio
        End Get
        Set(value As Integer)
            idDomicilio = value
        End Set
    End Property

    Public Property IdRef_Calle1 As Integer
        Get
            Return idRef_Calle
        End Get
        Set(value As Integer)
            idRef_Calle = value
        End Set
    End Property

    Public Property Numero1 As Integer
        Get
            Return numero
        End Get
        Set(value As Integer)
            numero = value
        End Set
    End Property

    Public Property Piso1 As String
        Get
            Return piso
        End Get
        Set(value As String)
            piso = value
        End Set
    End Property

    Public Property Dpto1 As String
        Get
            Return dpto
        End Get
        Set(value As String)
            dpto = value
        End Set
    End Property

    Public Property IdRef_Localidad1 As Integer
        Get
            Return idRef_Localidad
        End Get
        Set(value As Integer)
            idRef_Localidad = value
        End Set
    End Property
End Class
