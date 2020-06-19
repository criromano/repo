Public Class Ref_CondicionVentaCompra
    Private idRef_CondicionVentaCompra As Integer
    Private nombreCondicion As String

    Public Sub New()
    End Sub

    Public Sub New(idRef_CondicionVentaCompra As Integer, nombreCondicion As String)
        Me.idRef_CondicionVentaCompra = idRef_CondicionVentaCompra
        Me.nombreCondicion = nombreCondicion
    End Sub

    Public Property IdRef_CondicionVentaCompra1 As Integer
        Get
            Return idRef_CondicionVentaCompra
        End Get
        Set(value As Integer)
            idRef_CondicionVentaCompra = value
        End Set
    End Property

    Public Property NombreCondicion1 As String
        Get
            Return nombreCondicion
        End Get
        Set(value As String)
            nombreCondicion = value
        End Set
    End Property
End Class
