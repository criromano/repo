Public Class Proveedor_has_Telefono
    Private idProveedor As Integer
    Private idTelefono As Integer

    Public Sub New()
    End Sub

    Public Sub New(idProveedor As Integer, idTelefono As Integer)
        Me.IdProveedor1 = idProveedor
        Me.IdTelefono1 = idTelefono
    End Sub

    Public Property IdProveedor1 As Integer
        Get
            Return idProveedor
        End Get
        Set(value As Integer)
            idProveedor = value
        End Set
    End Property

    Public Property IdTelefono1 As Integer
        Get
            Return idTelefono
        End Get
        Set(value As Integer)
            idTelefono = value
        End Set
    End Property
End Class
