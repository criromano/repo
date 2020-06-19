Public Class Ref_Marca
    Private idRef_Marca As Integer
    Private nombreMarca As String

    Public Sub New()
    End Sub

    Public Sub New(idRef_Marca As Integer, nombreMarca As String)
        Me.idRef_Marca = idRef_Marca
        Me.nombreMarca = nombreMarca
    End Sub

    Public Property IdRef_Marca1 As Integer
        Get
            Return idRef_Marca
        End Get
        Set(value As Integer)
            idRef_Marca = value
        End Set
    End Property

    Public Property NombreMarca1 As String
        Get
            Return nombreMarca
        End Get
        Set(value As String)
            nombreMarca = value
        End Set
    End Property
End Class
