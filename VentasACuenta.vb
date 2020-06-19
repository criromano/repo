Public Class VentasACuenta
    Private idVentasACuenta As Integer
    Private idVenta As Integer
    Private importe As Double
    Private saldada As Boolean

    Public Sub New()
    End Sub

    Public Sub New(idVentasACuenta As Integer, idVenta As Integer, importe As Double, saldada As Boolean)
        Me.IdVentasACuenta1 = idVentasACuenta
        Me.IdVenta1 = idVenta
        Me.Importe1 = importe
        Me.Saldada1 = saldada
    End Sub

    Public Property IdVentasACuenta1 As Integer
        Get
            Return idVentasACuenta
        End Get
        Set(value As Integer)
            idVentasACuenta = value
        End Set
    End Property

    Public Property IdVenta1 As Integer
        Get
            Return idVenta
        End Get
        Set(value As Integer)
            idVenta = value
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
