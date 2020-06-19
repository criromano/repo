Imports System.Drawing.Printing

Public Class frmEtiqueta
    Dim cantidadDeProductos, precio, importe As Double
    Dim idCondicionDeVenta As Integer = 1
    Dim productoNuevo As New Producto
    Dim traeProducto As New Funciones
    Dim precioTotalDeVenta As Double = 0
    Dim registraVenta As New Funciones
    Dim condicionesVenta As New Funciones
    Dim listaDetalleVenta As New List(Of DetalleVenta)
    Dim listaDetalleVentaSinCodigoBarras As New List(Of DetalleVentaSinCodigo)
    Dim listaProductosSinCodigo As New List(Of ProductoSinCodigo)
    Dim idProductoSinCodigo As Integer
    Dim clientes As New Funciones
    Dim idCliente As Integer
    Dim idPersona As Integer = 1

    Private Sub frmEtiqueta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigoBarras.Focus()
    End Sub

    Private Sub frmEtiqueta_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtCodigoBarras.Focus()
        tablaProductos.Rows.Clear()
    End Sub

    Private Sub txtCodigoBarras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoBarras.KeyPress
        '------------------------------------------------
        'BUSCA POR CODIGO DE BARRAS
        '------------------------------------------------
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            If (e.KeyChar = Chr(13)) Then ' Se Preciona enter
                If Len(txtCodigoBarras.Text) > 3 Then ' si es mayor que 7, cod puede ser con 13 o 11 o 8

                    productoNuevo = traeProducto.ObtenerProductoVenta(txtCodigoBarras.Text.ToString)
                    If productoNuevo.IdProducto1 > 0 Then

                        txtProducto.Text = productoNuevo.NombreProducto1
                        txtPrecio.Text = Math.Round(traeProducto.MostrarPrecioDeProducto(productoNuevo.IdPrecioDeVenta1), 2)

                        txtProducto.Enabled = True
                        txtPrecio.Enabled = True
                        btnAgregar.Enabled = True

                        txtProducto.Focus()
                    Else
                        MsgBox("El producto ingresado no existe", vbOKOnly + vbCritical)
                        txtCodigoBarras.Text = ""
                        txtCodigoBarras.Focus()
                    End If

                Else
                    txtCodigoBarras.Focus()
                End If
            End If
        Else
            e.Handled = True 'deshabilita la tecla
        End If
    End Sub

    Private Sub txtProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProducto.KeyPress
        '---------------------------------
        'PRODUCTO
        '---------------------------------
        If (e.KeyChar = Chr(13)) Then ' Se Preciona enter
            txtPrecio.Focus()
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        '---------------------------------
        'PRECIO
        '---------------------------------
        Dim dig As Integer = Len(txtPrecio.Text & e.KeyChar)
        Dim a, esDecimal, NumDecimales As Integer
        Dim esDec As Boolean
        Dim coma As Char
        ' se verifica si es un digito o un punto para el decimal 
        If e.KeyChar.IsDigit(e.KeyChar) Or e.KeyChar = "," Or e.KeyChar = "." Then
            If e.KeyChar = "." Then
                e.KeyChar = ","
            End If
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
            If (e.KeyChar = Chr(13)) Then ' Se Preciona enter
                btnAgregar.Focus()
            End If
            'Return a
        Else
            e.Handled = True
        End If
        If dig = 1 And (e.KeyChar = "," Or e.KeyChar = ".") Then 'si dig=1 y es un punto rechaza 
            If e.KeyChar = "." Then
                e.KeyChar = ","
            End If
            e.Handled = True
            'Return a
        End If
        If txtPrecio.SelectedText = "" Then
            ' aqui se hace el for para controlar que el numero sea de dos digitos - contadose a partir del punto decimal.
            For a = 0 To dig - 1
                Dim car As String = CStr(txtPrecio.Text & e.KeyChar)

                If car.Substring(a, 1) = "," Then
                    esDecimal = esDecimal + 1
                    esDec = True
                End If
                If esDec = True Then
                    NumDecimales = NumDecimales + 1
                End If
                ' aqui se controla los digitos a partir del punto numdecimales = 4 si es de dos decimales  
                If NumDecimales >= 4 Or esDecimal >= 2 Then
                    e.Handled = True
                End If
                If e.KeyChar.IsControl(e.KeyChar) Then
                    e.Handled = False
                End If
            Next
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        '------------------------------------------------
        'AGREGA A LA TABLA
        '------------------------------------------------
        If Len(txtProducto.Text) = 0 Then
            txtProducto.Focus()
            Exit Sub
        End If

        If Len(txtPrecio.Text) = 0 Then
            txtPrecio.Focus()
            Exit Sub
        Else

            Dim precioArr As Array = Split(txtPrecio.Text, ",")
            Dim parteUno As String = ""
            Dim parteDos As String = ""
            Dim p As Integer = 1

            For Each partes In precioArr
                If p = 1 Then
                    parteUno = partes
                Else
                    parteDos = partes
                End If
                p += 1
            Next
            If Len(parteDos) = 0 Then
                parteDos = ",00"
            ElseIf Len(parteDos) = 1 Then
                parteDos = "," & parteDos & "0"
            ElseIf Len(parteDos) = 2 Then
                parteDos = "," & parteDos
            End If
            txtPrecio.Text = parteUno & parteDos


        End If

        Dim nroFila As Integer
        nroFila = tablaProductos.Rows.Count + 1

        tablaProductos.Rows.Add(nroFila, UCase(txtProducto.Text), txtPrecio.Text)
        txtProducto.Text = ""
        txtPrecio.Text = ""
        txtCodigoBarras.Text = ""

        txtProducto.Enabled = False
        txtPrecio.Enabled = False
        btnAgregar.Enabled = False

        txtCodigoBarras.Focus()
    End Sub

    Private Sub tablaProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaProductos.CellContentClick
        If e.ColumnIndex = tablaProductos.Columns.Item("colEliminar").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = tablaProductos.Rows(e.RowIndex).Cells("colEliminar")
            chkCell.Value = Not chkCell.Value

            If (chkCell.Value <> 0) Then
                '
                If MsgBox("¿Desea Eliminar?", vbYesNo + vbQuestion) = vbYes Then
                    tablaProductos.Rows.Remove(tablaProductos.Rows(e.RowIndex))

                    'For i = 0 To tablaProductos.Rows.Count - 1
                    Dim i As Integer = 1
                    For Each fila In tablaProductos.Rows
                        fila.Cells(0).Value = i
                        i += 1
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub btnLista_Click(sender As Object, e As EventArgs) Handles btnLista.Click
        '----------------------------------------------
        'IMPRIME EN UNA HOJA TODOS
        '----------------------------------------------
        Dim todos As New PrintDocument()
        'pd.PrinterSettings.PrinterName = "Microsoft Print to PDF" 'COMENTAR ESTA LÍNEA PARA QUE IMPRIMA DESDE LA IMPRESORA PREDETERMINADA

        AddHandler todos.PrintPage, AddressOf imprimeHoja_PrintPage
        ' indicamos que queremos imprimir
        todos.Print()
        '----------------------------------------------

    End Sub

    Private Sub btnUnoxUno_Click(sender As Object, e As EventArgs) Handles btnUnoxUno.Click
        '----------------------------------------------
        'IMPRIME UNO POR UNO
        '----------------------------------------------
        Dim pd As New PrintDocument()
        'pd.PrinterSettings.PrinterName = "Microsoft Print to PDF" 'COMENTAR ESTA LÍNEA PARA QUE IMPRIMA DESDE LA IMPRESORA PREDETERMINADA

        AddHandler pd.PrintPage, AddressOf print_PrintPage
        ' indicamos que queremos imprimir
        pd.Print()
        '----------------------------------------------
    End Sub

    Private Sub print_PrintPage(ByVal sender As Object,
                            ByVal e As PrintPageEventArgs)
        ' Este evento se producirá cada vez que se imprima una nueva página
        ' imprimir HOLA MUNDO en Arial tamaño 24 y negrita

        ' imprimimos la cadena en el margen izquierdo
        Dim xPos As Single = e.MarginBounds.Left
        ' La fuente a usar
        Dim prFont As New Font("Arial", 11, FontStyle.Bold)
        ' la posición superior
        Dim yPos As Single = 150 ' prFont.GetHeight(e.Graphics)

        ' imprimimos la cade



        Dim xposi As Integer
        Dim nombrePro As String
        'prFont = New Font("Arial", 9, FontStyle.Regular)
        yPos = 40
        For Each fila In tablaProductos.Rows

            prFont = New Font("Arial", 8, FontStyle.Regular)
            e.Graphics.DrawString("----------------------------------------------------", prFont, Brushes.Black, 10, yPos)

            yPos += 10
            xposi = 70
            nombrePro = fila.Cells(1).Value
            'If Len(fila.Cells(1).Value) > 7 Then
            If Len(fila.Cells(1).Value) > 18 Then
                nombrePro = nombrePro.Substring(0, 19)
                xposi = 10
                prFont = New Font("Arial", 11, FontStyle.Regular)
            Else
                xposi = 70 - ((Len(fila.Cells(1).Value) - 7) * 6)
                If (xposi < 10) Then
                    xposi = 10
                End If
                prFont = New Font("Arial", 12, FontStyle.Regular)
            End If

            'End If
            e.Graphics.DrawString(nombrePro, prFont, Brushes.Black, xposi, yPos) 'PRODUCTO

            yPos += 25
            prFont = New Font("Arial", 17, FontStyle.Bold)
            e.Graphics.DrawString("$ " & fila.Cells(2).Value, prFont, Brushes.Black, 60, yPos) 'PRECIO

            yPos += 20
            prFont = New Font("Arial", 8, FontStyle.Regular)
            e.Graphics.DrawString("----------------------------------------------------", prFont, Brushes.Black, 10, yPos)

            yPos += 20
        Next

        'prFont = New Font("Arial", 10, FontStyle.Bold)
        'yPos += 10
        'e.Graphics.DrawString("---------------------------------------", prFont, Brushes.Black, 10, yPos)
        'yPos += 13
        ''e.Graphics.DrawString("TOTAL: $" & txtTotalVenta.Text, prFont, Brushes.Black, 80, yPos)
        'yPos += 10
        'e.Graphics.DrawString("---------------------------------------", prFont, Brushes.Black, 10, yPos)
        'yPos += 20
        'e.Graphics.DrawString("¡Gracias por su compra!", prFont, Brushes.Black, 10, yPos)

        ' indicamos que ya no hay nada más que imprimir
        ' (el valor predeterminado de esta propiedad es False)
        e.HasMorePages = False

    End Sub

    Private Sub imprimeHoja_PrintPage(ByVal sender As Object,
                            ByVal e As PrintPageEventArgs)
        '------------------------------------------------
        ' IMPRIME LA HOJA

        '------------------------------------------------
        ' imprimimos la cadena en el margen izquierdo
        Dim xPos As Single = e.MarginBounds.Left
        ' La fuente a usar
        Dim prFont As New Font("Arial", 11, FontStyle.Bold)
        ' la posición superior
        Dim yPos As Single
        Dim totalFila As Integer
        Dim totalHoja As Integer
        Dim posicionY As Single
        Dim posicionX As Single
        Dim posicionPrecio As Single
        Dim posicionLinea As Single
        Dim tamanoProducto As Single

        totalFila = 1
        totalHoja = 1

        Dim xposi As Integer
        Dim nombrePro As String
        'prFont = New Font("Arial", 9, FontStyle.Regular)

        posicionY = 40
        For Each fila In tablaProductos.Rows
            yPos = posicionY

            If totalFila = 1 Then
                posicionLinea = 20
                posicionX = 120
                posicionPrecio = 100
            ElseIf totalFila = 2 Then
                posicionLinea = 280
                posicionX = 360
                posicionPrecio = 350
            ElseIf totalFila = 3 Then
                posicionLinea = 540
                posicionX = 610
                posicionPrecio = 610
            End If

            prFont = New Font("Arial", 8, FontStyle.Regular)
            e.Graphics.DrawString("------------------------------------------------------------------", prFont, Brushes.Black, posicionLinea, yPos)

            yPos += 15
            xposi = posicionX
            nombrePro = fila.Cells(1).Value

            If Len(fila.Cells(1).Value) > 27 Then
                nombrePro = nombrePro.Substring(0, 27)
                xposi = posicionLinea
                prFont = New Font("Arial", 10, FontStyle.Regular)
            Else
                'xposi = posicionX - ((Len(fila.Cells(1).Value) - 5) * 6)
                tamanoProducto = (Len(fila.Cells(1).Value) * 8.57) / 2

                If totalFila = 1 Then
                    'If (xposi < 20) Then
                    'xposi = 30 'posicionX
                    'Else
                    xposi = 143 - tamanoProducto
                    'End If
                ElseIf totalFila = 2 Then
                    'If (xposi < 280) Then
                    'xposi = 295 'posicionX
                    'Else
                    xposi = 403 - tamanoProducto
                    'End If
                ElseIf totalFila = 3 Then
                    'If (xposi < 540) Then
                    'xposi = 555 'posicionX
                    'Else
                    xposi = 663 - tamanoProducto
                    'End If
                End If

                prFont = New Font("Arial", 10, FontStyle.Regular)
            End If
            e.Graphics.DrawString(nombrePro, prFont, Brushes.Black, xposi, yPos) 'PRODUCTO

            yPos += 25
            prFont = New Font("Arial", 20, FontStyle.Bold)
            e.Graphics.DrawString("$ " & fila.Cells(2).Value, prFont, Brushes.Black, posicionPrecio, yPos) 'PRECIO

            prFont = New Font("Arial", 10, FontStyle.Regular)
            e.Graphics.DrawString("|", prFont, Brushes.Black, posicionLinea, yPos)
            e.Graphics.DrawString("|", prFont, Brushes.Black, posicionLinea + 240, yPos)
            e.Graphics.DrawString("|", prFont, Brushes.Black, posicionLinea, yPos - 15)
            e.Graphics.DrawString("|", prFont, Brushes.Black, posicionLinea + 240, yPos - 15)

            yPos += 30
            prFont = New Font("Arial", 8, FontStyle.Regular)
            e.Graphics.DrawString("------------------------------------------------------------------", prFont, Brushes.Black, posicionLinea, yPos)

            totalFila += 1
            totalHoja += 1
            If totalFila > 3 Then
                totalFila = 1
                posicionY += 85
            End If

            If totalHoja > 9 Then
                totalHoja = 1
            End If
        Next


        ' indicamos que ya no hay nada más que imprimir
        ' (el valor predeterminado de esta propiedad es False)
        e.HasMorePages = False

    End Sub



End Class