Public Class PagosACuentaProveedores
    Private idPagosACuentaProveedores As Integer
    Private fecha As Date
    Private importe As Double

    Public Sub New()
    End Sub

    Public Sub New(idPagosACuentaProveedores As Integer, fecha As Date, importe As Double)
        Me.IdPagosACuentaProveedores1 = idPagosACuentaProveedores
        Me.Fecha1 = fecha
        Me.Importe1 = importe
    End Sub

    Public Property IdPagosACuentaProveedores1 As Integer
        Get
            Return idPagosACuentaProveedores
        End Get
        Set(value As Integer)
            idPagosACuentaProveedores = value
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
