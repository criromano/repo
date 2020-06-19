Public Class Persona_has_Telefono
    Private idPersona As Integer
    Private idTelefono As Integer

    Public Sub New()
    End Sub

    Public Sub New(idPersona As Integer, idTelefono As Integer)
        Me.IdPersona1 = idPersona
        Me.IdTelefono1 = idTelefono
    End Sub

    Public Property IdPersona1 As Integer
        Get
            Return idPersona
        End Get
        Set(value As Integer)
            idPersona = value
        End Set
    End Property

    Public Property IdTelefono1 As Integer
        Get
            Return idTelefono
        End Get
        Set(value As Integer)
            idTelefono = value
        End Set
    End Property
End Class
