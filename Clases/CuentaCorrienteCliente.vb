Public Class CuentaCorrienteCliente
    Private idCuentaCorrienteCliente As Integer
    Private idCliente As Integer
    Private saldo As Double

    Public Sub New()
    End Sub

    Public Sub New(idCuentaCorrienteCliente As Integer, idCliente As Integer, saldo As Double)
        Me.IdCuentaCorrienteCliente1 = idCuentaCorrienteCliente
        Me.IdCliente1 = idCliente
        Me.Saldo1 = saldo
    End Sub

    Public Property IdCuentaCorrienteCliente1 As Integer
        Get
            Return idCuentaCorrienteCliente
        End Get
        Set(value As Integer)
            idCuentaCorrienteCliente = value
        End Set
    End Property

    Public Property IdCliente1 As Integer
        Get
            Return idCliente
        End Get
        Set(value As Integer)
            idCliente = value
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
