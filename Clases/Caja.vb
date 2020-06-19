Public Class Caja
    Private idCaja As Integer
    Private fecha As Date
    Private saldoInicial As Double
    Private saldoFinal As Double

    Public Sub New()
    End Sub

    Public Sub New(idCaja As Integer, fecha As Date, saldoInicial As Double, saldoFinal As Double)
        Me.IdCaja1 = idCaja
        Me.Fecha1 = fecha
        Me.SaldoInicial1 = saldoInicial
        Me.SaldoFinal1 = saldoFinal
    End Sub

    Public Property IdCaja1 As Integer
        Get
            Return idCaja
        End Get
        Set(value As Integer)
            idCaja = value
        End Set
    End Property

    Public Property Fecha1 As Date
        Get
            Return fecha
        End Get
        Set(value As Date)
            fecha = value
        End Set
    End Property

    Public Property SaldoInicial1 As Double
        Get
            Return saldoInicial
        End Get
        Set(value As Double)
            saldoInicial = value
        End Set
    End Property

    Public Property SaldoFinal1 As Double
        Get
            Return saldoFinal
        End Get
        Set(value As Double)
            saldoFinal = value
        End Set
    End Property
End Class
