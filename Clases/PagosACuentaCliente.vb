Public Class PagosACuentaCliente
    Private idPagosACuentaCliente As Integer
    Private fecha As Date
    Private importe As Double

    Public Sub New()
    End Sub

    Public Sub New(idPagosACuentaCliente As Integer, fecha As Date, importe As Double)
        Me.IdPagosACuentaCliente1 = idPagosACuentaCliente
        Me.Fecha1 = fecha
        Me.Importe1 = importe
    End Sub

    Public Property IdPagosACuentaCliente1 As Integer
        Get
            Return idPagosACuentaCliente
        End Get
        Set(value As Integer)
            idPagosACuentaCliente = value
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

    Public Property Importe1 As Double
        Get
            Return importe
        End Get
        Set(value As Double)
            importe = value
        End Set
    End Property
End Class
