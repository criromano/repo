Public Class CuentaCorrienteProveedor
    Private idCuentaCorrienteProveedor As Integer
    Private idProveedor As Integer
    Private saldo As Double

    Public Sub New()
    End Sub

    Public Sub New(idCuentaCorrienteProveedor As Integer, idProveedor As Integer, saldo As Double)
        Me.IdCuentaCorrienteProveedor1 = idCuentaCorrienteProveedor
        Me.IdProveedor1 = idProveedor
        Me.Saldo1 = saldo
    End Sub

    Public Property IdCuentaCorrienteProveedor1 As Integer
        Get
            Return idCuentaCorrienteProveedor
        End Get
        Set(value As Integer)
            idCuentaCorrienteProveedor = value
        End Set
    End Property

    Public Property IdProveedor1 As Integer
        Get
            Return idProveedor
        End Get
        Set(value As Integer)
            idProveedor = value
        End Set
    End Property

    Public Property Saldo1 As Double
        Get
            Return saldo
        End Get
        Set(value As Double)
            saldo = value
        End Set
    End Property
End Class
