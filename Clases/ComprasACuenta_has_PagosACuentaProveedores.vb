Public Class ComprasACuenta_has_PagosACuentaProveedores
    Private idComprasACuenta As Integer
    Private idPagosACuentaProveedores As Integer

    Public Sub New()
    End Sub

    Public Sub New(idComprasACuenta As Integer, idPagosACuentaProveedores As Integer)
        Me.IdComprasACuenta1 = idComprasACuenta
        Me.IdPagosACuentaProveedores1 = idPagosACuentaProveedores
    End Sub

    Public Property IdComprasACuenta1 As Integer
        Get
            Return idComprasACuenta
        End Get
        Set(value As Integer)
            idComprasACuenta = value
        End Set
    End Property

    Public Property IdPagosACuentaProveedores1 As Integer
        Get
            Return idPagosACuentaProveedores
        End Get
        Set(value As Integer)
            idPagosACuentaProveedores = value
        End Set
    End Property
End Class
