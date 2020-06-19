Public Class Cliente
    Private idCliente As Integer
    Private idPersona As Integer
    Private cuil As String
    Private observaciones As String
    Public Sub New()
    End Sub

    Public Sub New(idCliente As Integer, idPersona As Integer, cuil As String, observaciones As String)
        Me.idCliente = idCliente
        Me.idPersona = idPersona
        Me.cuil = cuil
        Me.observaciones = observaciones
    End Sub

    Public Property IdCliente1 As Integer
        Get
            Return idCliente
        End Get
        Set(value As Integer)
            idCliente = value
        End Set
    End Property

    Public Property IdPersona1 As Integer
        Get
            Return idPersona
        End Get
        Set(value As Integer)
            idPersona = value
        End Set
    End Property

    Public Property Cuil1 As String
        Get
            Return cuil
        End Get
        Set(value As String)
            cuil = value
        End Set
    End Property

    Public Property Observaciones1 As String
        Get
            Return observaciones
        End Get
        Set(value As String)
            observaciones = value
        End Set
    End Property
End Class
