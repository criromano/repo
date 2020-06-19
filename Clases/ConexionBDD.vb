Imports MySql.Data.MySqlClient

Public Class ConexionBDD
    Dim conexion As MySqlConnection
    Dim cadena As String

    Public Function ObtenerConexion() As MySqlConnection
        cadena = "server=localhost;userid=root;password=;database=lacabana;"
        conexion = New MySqlConnection(cadena)
        conexion.Open()

        If (conexion.State = 1) Then
            'MsgBox("Conectado")
        Else
            MsgBox("No conectado")
        End If

        Return conexion
    End Function

    Public Function cerrarConexion() As MySqlConnection
        conexion.Close()

        Return conexion
    End Function
End Class
