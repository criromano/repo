Public Class Proveedor
    Private idProveedor As Integer
    Private razonSocial As String
    Private cuit As String
    Private idDomicilio As Integer
    Private email As String
    Private observaciones As String

    Public Sub New()
    End Sub

    Public Sub New(idProveedor As Integer, razonSocial As String, cuit As String, idDomicilio As Integer, email As String, observaciones As String)
        Me.idProveedor = idProveedor
        Me.razonSocial = razonSocial
        Me.cuit = cuit
        Me.idDomicilio = idDomicilio
        Me.email = email
        Me.observaciones = observaciones
    End Sub

    Public Property IdProveedor1 As Integer
        Get
            Return idProveedor
        End Get
        Set(value As Integer)
            idProveedor = value
        End Set
    End Property

    Public Property RazonSocial1 As String
        Get
            Return razonSocial
        End Get
        Set(value As String)
            razonSocial = value
        End Set
    End Property

    Public Property Cuit1 As String
        Get
            Return cuit
        End Get
        Set(value As String)
            cuit = value
        End Set
    End Property

    Public Property IdDomicilio1 As Integer
        Get
            Return idDomicilio
        End Get
        Set(value As Integer)
            idDomicilio = value
        End Set
    End Property

    Public Property Email1 As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property Observaciones1 As String
        Get
            Return observaciones
        End Get
        Set(value As String)
            observaciones = value
        End Set
    End Property
End Class
