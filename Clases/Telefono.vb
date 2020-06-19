Public Class Telefono
    Private idTelefono As Integer
    Private codArea As String
    Private numero As String
    Private idRef_TipoTelefono As Integer

    Public Sub New()
    End Sub

    Public Sub New(idTelefono As Integer, codArea As String, numero As String, idRef_TipoTelefono As Integer)
        Me.IdTelefono1 = idTelefono
        Me.CodArea1 = codArea
        Me.Numero1 = numero
        Me.IdRef_TipoTelefono1 = idRef_TipoTelefono
    End Sub

    Public Property IdTelefono1 As Integer
        Get
            Return idTelefono
        End Get
        Set(value As Integer)
            idTelefono = value
        End Set
    End Property

    Public Property CodArea1 As String
        Get
            Return codArea
        End Get
        Set(value As String)
            codArea = value
        End Set
    End Property

    Public Property Numero1 As String
        Get
            Return numero
        End Get
        Set(value As String)
            numero = value
        End Set
    End Property

    Public Property IdRef_TipoTelefono1 As Integer
        Get
            Return idRef_TipoTelefono
        End Get
        Set(value As Integer)
            idRef_TipoTelefono = value
        End Set
    End Property
End Class
