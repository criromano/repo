Public Class ComprasACuenta
    Private idComprasACuenta As Integer
    Private idCompra As Integer
    Private importe As Double
    Private saldada As Boolean

    Public Sub New()
    End Sub

    Public Sub New(idComprasACuenta As Integer, idCompra As Integer, importe As Double, saldada As Boolean)
        Me.IdComprasACuenta1 = idComprasACuenta
        Me.IdCompra1 = idCompra
        Me.Importe1 = importe
        Me.Saldada1 = saldada
    End Sub

    Public Property IdComprasACuenta1 As Integer
        Get
            Return idComprasACuenta
        End Get
        Set(value As Integer)
            idComprasACuenta = value
        End Set
    End Property

    Public Property IdCompra1 As Integer
        Get
            Return idCompra
        End Get
        Set(value As Integer)
            idCompra = value
        End Set
    End Property

    Public Property Importe1 As Double
        Get
            Return importe
        End Get
        Set(value As Double)
            importe = value
        End Set
    End Property

    Public Property Saldada1 As Boolean
        Get
            Return saldada
        End Get
        Set(value As Boolean)
            saldada = value
        End Set
    End Property
End Class
