Public Class VentasACuentas_has_PagosACuentaClientes
    Private idVentasACuentas As Integer
    Private idPagosACuentaCliente As Integer

    Public Sub New()
    End Sub

    Public Sub New(idVentasACuentas As Integer, idPagosACuentaCliente As Integer)
        Me.IdVentasACuentas1 = idVentasACuentas
        Me.IdPagosACuentaCliente1 = idPagosACuentaCliente
    End Sub

    Public Property IdVentasACuentas1 As Integer
        Get
            Return idVentasACuentas
        End Get
        Set(value As Integer)
            idVentasACuentas = value
        End Set
    End Property

    Public Property IdPagosACuentaCliente1 As Integer
        Get
            Return idPagosACuentaCliente
        End Get
        Set(value As Integer)
            idPagosACuentaCliente = value
        End Set
    End Property
End Class
