Public Class Persona
    Private idPersona As Integer
    Private apellidoYNombre As String
    Private dni As String
    Private idDomicilio As Integer
    Private email As String

    Public Sub New()
    End Sub

    Public Sub New(idPersona As Integer, apellidoYNombre As String, dni As String, idDomicilio As Integer, email As String)
        Me.IdPersona1 = idPersona
        Me.ApellidoYNombre1 = apellidoYNombre
        Me.Dni1 = dni
        Me.IdDomicilio1 = idDomicilio
        Me.Email1 = email
    End Sub

    Public Property IdPersona1 As Integer
        Get
            Return idPersona
        End Get
        Set(value As Integer)
            idPersona = value
        End Set
    End Property

    Public Property ApellidoYNombre1 As String
        Get
            Return apellidoYNombre
        End Get
        Set(value As String)
            apellidoYNombre = value
        End Set
    End Property

    Public Property Dni1 As String
        Get
            Return dni
        End Get
        Set(value As String)
            dni = value
        End Set
    End Property

    Public Property IdDomicilio1 As Integer
        Get
            Return idDomicilio
        End Get
        Set(value As Integer)
            idDomicilio = value
        End Set
    End Property

    Public Property Email1 As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property
End Class
