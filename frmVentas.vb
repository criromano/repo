Imports System.Drawing.Printing
Public Class frmVentas
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


    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New(lista As List(Of DetalleVenta), listaSinCodigo As List(Of DetalleVentaSinCodigo), idCondicionDeVenta As Integer, idCliente As Integer)

        Me.listaDetalleVenta = lista
        Me.listaDetalleVentaSinCodigoBarras = listaSinCodigo
        Me.idCondicionDeVenta = idCondicionDeVenta
        Me.idPersona = idCliente
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New(lista As List(Of DetalleVenta), listaSinCodigo As List(Of DetalleVentaSinCodigo), productoNuevo As Producto, idCondicionDeVenta As Integer, idCliente As Integer)

        Me.listaDetalleVenta = lista
        Me.listaDetalleVentaSinCodigoBarras = listaSinCodigo
        Me.productoNuevo = productoNuevo
        Me.idCondicionDeVenta = idCondicionDeVenta
        Me.idPersona = idCliente
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If listaDetalleVenta.Count > 0 Then
            dgvVentas.Visible = True
            lblTotalDeVenta.Visible = True
            txtTotalVenta.Visible = True
            For Each detalle In listaDetalleVenta
                Dim prod As New Producto
                Dim precioUnitario As Double
                prod = traeProducto.TraeObjetoProductoPorId(detalle.IdProducto1)
                precioTotalDeVenta += detalle.Importe1
                precioUnitario = detalle.Importe1 / detalle.Cantidad1
                dgvVentas.Rows.Add(detalle.IdProducto1, detalle.Cantidad1, traeProducto.MostrarTiposDeEnvasesPorId(prod.IdRef_TipoEnvase1), prod.NombreProducto1, prod.Medida1, traeProducto.MostrarUnidadDeMedidaPorId(prod.IdRef_UnidadDeMedida1), traeProducto.MostrarMarcaPorId(prod.IdRef_Marca1), prod.CodigoBarras1, precioUnitario, detalle.Importe1)
            Next
            listaDetalleVenta.Clear()
        End If

        If listaDetalleVentaSinCodigoBarras.Count > 0 Then
            dgvVentas.Visible = True
            lblTotalDeVenta.Visible = True
            txtTotalVenta.Visible = True
            For Each detalleSinCodigo In listaDetalleVentaSinCodigoBarras
                Dim prodSinCodigo As New ProductoSinCodigo
                prodSinCodigo = traeProducto.TraeObjetoProductoSinCodigoPorId(detalleSinCodigo.IdProductoSinCodigo1)
                precioTotalDeVenta += detalleSinCodigo.Importe1
                dgvVentas.Rows.Add(detalleSinCodigo.IdProductoSinCodigo1, detalleSinCodigo.Cantidad1, "", prodSinCodigo.Nombre1, "", "", "", 0, "", detalleSinCodigo.Importe1)
            Next
            listaDetalleVentaSinCodigoBarras.Clear()
        End If
        txtTotalVenta.Text = precioTotalDeVenta

        For Each condicion In condicionesVenta.MostrarCondicionesDeVentaCompra()
            cboCondicionDeVenta.Items.Add(condicion.NombreCondicion1)
        Next
        For Each condicion In condicionesVenta.MostrarCondicionesDeVentaCompra()
            If idCondicionDeVenta = condicion.IdRef_CondicionVentaCompra1 Then
                cboCondicionDeVenta.SelectedItem = condicion.NombreCondicion1
            End If
        Next
        For Each cliente In clientes.TraeClientes
            cboCliente.Items.Add(cliente.ApellidoYNombre1)
        Next
        For Each cliente In clientes.TraeClientes
            If idPersona = cliente.IdPersona1 Then
                cboCliente.SelectedItem = cliente.ApellidoYNombre1
            End If
        Next
        txtCodigoDeBarras.Focus()
        txtCantidad.Text = 1
        btnAgregar.Enabled = False
        'btnConfirmarVenta.Enabled = False

        If productoNuevo.IdProducto1 <> 0 Then
            txtCantidad.Enabled = True
            txtCantidad.Text = 1
            txtCodigoDeBarras.Text = productoNuevo.CodigoBarras1
            txtPrecio.Text = Math.Round(traeProducto.MostrarPrecioDeProducto(productoNuevo.IdPrecioDeVenta1), 2)
            precio = txtPrecio.Text
            txtCantidad.Focus()
        End If

        For Each productoSinCodigo In traeProducto.MostrarProductosSinCodigo()
            cboProducto.Items.Add(productoSinCodigo.Nombre1)
        Next

        '-----------------------------------
        'busca caja
        Dim traeCaja As New Funciones
        Dim cajasn As String = traeCaja.InicioCaja()
        If cajasn = "N" Then
            lbl_aviso_caja.Visible = True
        Else
            lbl_aviso_caja.Visible = False
        End If

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click



        dgvVentas.Visible = True

        Dim precioTotal As Double
        precioTotal = txtPrecio.Text * txtCantidad.Text
        Dim productoSincodigo As New ProductoSinCodigo
        productoSincodigo = traeProducto.TraeObjetoProductoSinCodigoPorId(idProductoSinCodigo)
        dgvVentas.Rows.Add(productoSincodigo.IdProductoSinCodigo1, txtCantidad.Text, "", productoSincodigo.Nombre1, "", "", "", 0, txtPrecio.Text, precioTotal)
        txtCodigoDeBarras.Text = ""
        txtCantidad.Text = 1
        txtPrecio.Text = 0
        txtTotalVenta.Text = ""
        precioTotalDeVenta += precioTotal
        txtTotalVenta.Text = Math.Round(precioTotalDeVenta, 2)
        btnAgregar.Enabled = False
        txtCodigoDeBarras.Focus()
        lblTotalDeVenta.Visible = True
        Label4.Visible = False
        Label6.Visible = True
        txtTotalVenta.Visible = True
        lblDescripcion.Visible = False
        lblPrecio.Visible = False
        Label4.Visible = False
        cboProducto.Visible = False
        txtPrecio.Visible = False
        btnAgregar.Visible = False
        cboProducto.Text = "Seleccionar"
    End Sub



    Private Sub btnConfirmarVenta_Click(sender As Object, e As EventArgs) Handles btnConfirmarVenta.Click
        If idCondicionDeVenta = 2 And idPersona = 1 Then
            MessageBox.Show("Debe ingresar un cliente")
            cboCliente.Select()
        Else
            If MsgBox("¿ESTA SEGURO?", vbYesNo + vbQuestion) = vbYes Then
                Dim stock As New Funciones
                Dim Venta As New Ventas
                Venta.FechaVenta1 = dtpFechaDeVenta.Value
                Venta.ImporteTotalDeVenta1 = txtTotalVenta.Text
                Venta.IdRef_CondicionVentaCompra1 = idCondicionDeVenta
                Venta.IdCliente1 = idCliente
                registraVenta.registrarNuevaVenta(Venta)

                '----------------------------------------------
                'LLAMA PARA IMPRIMIR
                '----------------------------------------------
                Dim pd As New PrintDocument()
                'pd.PrinterSettings.PrinterName = "Microsoft Print to PDF" 'COMENTAR ESTA LÍNEA PARA QUE IMPRIMA DESDE LA IMPRESORA PREDETERMINADA

                AddHandler pd.PrintPage, AddressOf print_PrintPage
                ' indicamos que queremos imprimir
                pd.Print()
                '----------------------------------------------


                For Each fila In dgvVentas.Rows
                    If fila.Cells(7).Value = 0 Then
                        Dim detalleSinCodigo As New DetalleVentaSinCodigo
                        detalleSinCodigo.IdVenta1 = registraVenta.RecuperaUltimoIdVenta()
                        detalleSinCodigo.Cantidad1 = Convert.ToInt32(fila.Cells(1).Value)
                        detalleSinCodigo.Importe1 = Convert.ToDouble(fila.Cells(9).Value)
                        detalleSinCodigo.IdProductoSinCodigo1 = Convert.ToInt32(fila.Cells(0).Value)
                        listaDetalleVentaSinCodigoBarras.Add(detalleSinCodigo)
                    Else
                        Dim detalle As New DetalleVenta
                        detalle.IdVenta1 = registraVenta.RecuperaUltimoIdVenta()
                        detalle.Cantidad1 = Convert.ToInt32(fila.Cells(1).Value)
                        detalle.Importe1 = Convert.ToDouble(fila.Cells(9).Value)
                        detalle.IdProducto1 = Convert.ToInt32(fila.Cells(0).Value)
                        stock.DescuentaStockPorVenta(detalle.IdProducto1, detalle.Cantidad1)
                        listaDetalleVenta.Add(detalle)
                    End If

                Next

                If listaDetalleVenta.Count > 0 Then
                    registraVenta.registrarDetalleDeVenta(listaDetalleVenta)
                    listaDetalleVenta.Clear()
                End If
                If listaDetalleVentaSinCodigoBarras.Count > 0 Then
                    registraVenta.registrarDetalleDeVentaSinCodigoDeBarras(listaDetalleVentaSinCodigoBarras)
                    listaDetalleVentaSinCodigoBarras.Clear()
                End If

                If idCondicionDeVenta = 2 Then
                    Dim valorACuenta As Double = InputBox("Ingrese el monto a cuenta", "Cuenta corriente", txtTotalVenta.Text)
                    Dim ventaACuenta As New VentasACuenta
                    ventaACuenta.IdVenta1 = registraVenta.RecuperaUltimoIdVenta()
                    ventaACuenta.Importe1 = valorACuenta
                    registraVenta.GuardarVentaACuenta(ventaACuenta)

                    Dim nuevaDeuda As New CuentaCorrienteCliente
                    nuevaDeuda.IdCliente1 = idCliente
                    nuevaDeuda.Saldo1 = valorACuenta
                    registraVenta.ActualizarSaldoCuentaCorrienteCliente(nuevaDeuda)
                End If
                dgvVentas.Rows.Clear()
                txtTotalVenta.Text = ""
                btnConfirmarVenta.Enabled = False
                dgvVentas.Visible = False
                lblTotalDeVenta.Visible = False
                Label6.Visible = False
                txtTotalVenta.Visible = False
                precioTotalDeVenta = 0
                cboCondicionDeVenta.SelectedItem = "CONTADO"
                idCondicionDeVenta = 1
                cboCliente.SelectedItem = "CONSUMIDOR FINAL"
                idPersona = 1
                txtCodigoDeBarras.Focus()
            End If
        End If
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


        ' imprimimos la cadena

        e.Graphics.DrawString("LA CABAÑA Beer Store", prFont, Brushes.Black, 10, 80)
        prFont = New Font("Arial", 12, FontStyle.Regular)
        e.Graphics.DrawString("Av. 22 de Octubre 386", prFont, Brushes.Black, 10, 110)
        e.Graphics.DrawString("----------------------------------", prFont, Brushes.Black, 10, 120)
        prFont = New Font("Arial", 11, FontStyle.Regular)
        e.Graphics.DrawString("PRESUPUESTO", prFont, Brushes.Black, 40, 135)

        'imprimimos la fecha y hora

        prFont = New Font("Arial", 9, FontStyle.Regular)
        e.Graphics.DrawString("Fecha: " & Date.Now.ToShortDateString.ToString & " " &
                                Date.Now.ToShortTimeString.ToString & " hs.", prFont, Brushes.Black, 10, 160)

        prFont = New Font("Arial", 8, FontStyle.Regular)
        e.Graphics.DrawString("---------------------------------------------------", prFont, Brushes.Black, 10, 170)

        e.Graphics.DrawString("CANT.", prFont, Brushes.Black, 10, 185)
        e.Graphics.DrawString("PROD.", prFont, Brushes.Black, 50, 185)
        e.Graphics.DrawString("IMPORTE", prFont, Brushes.Black, 130, 185)
        e.Graphics.DrawString("--------------------------------------------------", prFont, Brushes.Black, 10, 200)


        'prFont = New Font("Arial", 9, FontStyle.Regular)
        yPos = 220
        For Each fila In dgvVentas.Rows

            e.Graphics.DrawString(fila.Cells(1).Value, prFont, Brushes.Black, 10, yPos)
            e.Graphics.DrawString(fila.Cells(3).Value, prFont, Brushes.Black, 30, yPos)
            e.Graphics.DrawString("$ " & fila.Cells(9).Value, prFont, Brushes.Black, 150, yPos)
            yPos += 20
        Next

        prFont = New Font("Arial", 10, FontStyle.Bold)
        yPos += 10
        e.Graphics.DrawString("---------------------------------------", prFont, Brushes.Black, 10, yPos)
        yPos += 13
        e.Graphics.DrawString("TOTAL: $" & txtTotalVenta.Text, prFont, Brushes.Black, 80, yPos)
        yPos += 10
        e.Graphics.DrawString("---------------------------------------", prFont, Brushes.Black, 10, yPos)
        yPos += 20
        e.Graphics.DrawString("¡Gracias por su compra!", prFont, Brushes.Black, 10, yPos)

        ' indicamos que ya no hay nada más que imprimir
        ' (el valor predeterminado de esta propiedad es False)
        e.HasMorePages = False

    End Sub

    Private Sub txtNumeroDeProducto_TextChanged(sender As Object, e As EventArgs)
        txtCantidad.Enabled = True
        btnAgregar.Enabled = True
    End Sub

    Private Sub txtTotalVenta_TextChanged(sender As Object, e As EventArgs) Handles txtTotalVenta.TextChanged
        If Len(txtTotalVenta.Text) > 0 Then
            If txtTotalVenta.Text <> 0 Then
                btnConfirmarVenta.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        For Each fila In dgvVentas.Rows
            If fila.Cells(7).Value = 0 Then
                Dim detalleSinCodigo As New DetalleVentaSinCodigo
                detalleSinCodigo.Cantidad1 = Convert.ToInt32(fila.Cells(1).Value)
                detalleSinCodigo.Importe1 = Convert.ToDouble(fila.Cells(9).Value)
                detalleSinCodigo.IdProductoSinCodigo1 = Convert.ToInt32(fila.Cells(0).Value)
                listaDetalleVentaSinCodigoBarras.Add(detalleSinCodigo)
            Else
                Dim detalle As New DetalleVenta
                detalle.IdVenta1 = registraVenta.RecuperaUltimoIdVenta()
                detalle.Cantidad1 = Convert.ToInt32(fila.Cells(1).Value)
                detalle.Importe1 = Convert.ToDouble(fila.Cells(9).Value)
                detalle.IdProducto1 = Convert.ToInt32(fila.Cells(0).Value)
                listaDetalleVenta.Add(detalle)
            End If
        Next

        Dim abrirForm As New Funciones
        abrirForm.AbrirFormEnPanel(New frmPadronProductosSinCodigo(listaDetalleVenta, listaDetalleVentaSinCodigoBarras, idCondicionDeVenta, idPersona))
    End Sub

    Private Sub btnCargaManual_Click(sender As Object, e As EventArgs) Handles btnCargaManual.Click
        txtCodigoDeBarras.Text = ""
        txtPrecio.Visible = True
        cboProducto.Visible = True
        btnAgregar.Visible = True
        lblDescripcion.Visible = True
        lblPrecio.Visible = True
        Label4.Visible = True
        txtPrecio.Text = 0
        txtCantidad.Enabled = True
        txtCantidad.Text = 1
        txtPrecio.Enabled = True
        cboProducto.Focus()
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        If Len(txtPrecio.Text) > 0 Then
            If txtPrecio.Text = "," Then
                txtPrecio.Text = ""
            Else
                If txtPrecio.Text <> 0 Then
                    btnAgregar.Enabled = True
                Else
                    btnAgregar.Enabled = False
                End If
            End If

        Else
            btnAgregar.Enabled = False
        End If
    End Sub

    Private Sub txtCodigoDeBarras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoDeBarras.KeyPress
        '------------------------------------------------
        'SOLO NUMEROS
        '------------------------------------------------
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            If (e.KeyChar = Chr(13)) Then ' Se Preciona enter
				If Len(txtCodigoDeBarras.Text) > 3 Then ' si es mayor que 7, cod puede ser con 13 o 11 o 8
					If Len(txtCantidad.Text) > 0 Then
						If txtCantidad.Text = 0 Then
							txtCantidad.Focus()
						Else
							productoNuevo = traeProducto.ObtenerProductoVenta(txtCodigoDeBarras.Text.ToString)
							If productoNuevo.IdProducto1 > 0 Then
								dgvVentas.Visible = True
								txtPrecio.Text = Math.Round(traeProducto.MostrarPrecioDeProducto(productoNuevo.IdPrecioDeVenta1), 2)
								Dim precioTotal As Double
								precioTotal = txtPrecio.Text * txtCantidad.Text
								dgvVentas.Rows.Add(productoNuevo.IdProducto1, txtCantidad.Text, traeProducto.MostrarTiposDeEnvasesPorId(productoNuevo.IdRef_TipoEnvase1), productoNuevo.NombreProducto1, productoNuevo.Medida1, traeProducto.MostrarUnidadDeMedidaPorId(productoNuevo.IdRef_UnidadDeMedida1), traeProducto.MostrarMarcaPorId(productoNuevo.IdRef_Marca1), txtCodigoDeBarras.Text, txtPrecio.Text, precioTotal)
								txtCodigoDeBarras.Text = ""
								txtPrecio.Text = 0
								txtTotalVenta.Text = ""
								precioTotalDeVenta += precioTotal
								txtTotalVenta.Text = precioTotalDeVenta
								btnAgregar.Enabled = False
								txtCodigoDeBarras.Focus()
								lblTotalDeVenta.Visible = True
								Label6.Visible = True
								txtTotalVenta.Visible = True
								txtCantidad.Text = 1
							Else
								If MsgBox("El producto ingresado no existe, ¿Desea cargarlo ahora?", vbYesNo + vbQuestion) = vbYes Then
									For Each fila In dgvVentas.Rows
										If fila.Cells(7).Value = 0 Then
											Dim detalleSinCodigo As New DetalleVentaSinCodigo
											detalleSinCodigo.Cantidad1 = Convert.ToInt32(fila.Cells(1).Value)
											detalleSinCodigo.Importe1 = Convert.ToDouble(fila.Cells(9).Value)
											detalleSinCodigo.IdProductoSinCodigo1 = Convert.ToInt32(fila.Cells(0).Value)
											listaDetalleVentaSinCodigoBarras.Add(detalleSinCodigo)
										Else
											Dim detalle As New DetalleVenta
											detalle.IdVenta1 = registraVenta.RecuperaUltimoIdVenta()
											detalle.Cantidad1 = Convert.ToInt32(fila.Cells(1).Value)
											detalle.Importe1 = Convert.ToDouble(fila.Cells(9).Value)
											detalle.IdProducto1 = Convert.ToInt32(fila.Cells(0).Value)
											listaDetalleVenta.Add(detalle)
										End If
									Next
									Dim codigoNuevo As String = txtCodigoDeBarras.Text

									Dim abrirForm As New Funciones
									abrirForm.AbrirFormEnPanel(New frmAltaProductoDesdeVenta(listaDetalleVenta, listaDetalleVentaSinCodigoBarras, codigoNuevo, idCondicionDeVenta, idPersona))
								Else
									txtCodigoDeBarras.Text = ""
									txtCodigoDeBarras.Focus()
								End If
							End If
						End If
					Else
						txtCantidad.Focus()
					End If
				Else
					txtCodigoDeBarras.Focus()
                End If
            End If
        Else
            e.Handled = True 'deshabilita la tecla
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        '------------------------------------------------
        'SOLO NUMEROS
        '------------------------------------------------
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            If (e.KeyChar = Chr(13)) Then ' Se Preciona enter
                If Len(txtCantidad.Text) > 0 Then
                    If txtCantidad.Text = 0 Then
                        Me.Focus()
                    Else
                        txtCodigoDeBarras.Focus()
                    End If
                End If
            End If
        Else
            e.Handled = True 'deshabilita la tecla
        End If
    End Sub

    Private Sub cboProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProducto.SelectedIndexChanged
        For Each productoSinCodigo In traeProducto.MostrarProductosSinCodigo()
            If productoSinCodigo.Nombre1 = cboProducto.SelectedItem Then
                idProductoSinCodigo = productoSinCodigo.IdProductoSinCodigo1
            End If
        Next
        MessageBox.Show(idProductoSinCodigo)
        txtPrecio.Focus()
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        '------------------------------------------------
        'SOLO NUMEROS
        '------------------------------------------------
        'If Char.IsDigit(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        '    e.Handled = False
        '    If (e.KeyChar = Chr(13)) Then ' Se Preciona enter
        '        If txtCantidad.Text <> "" Then
        '            btnAgregar.Focus()
        '        Else
        '            Me.Focus()
        '        End If
        '    End If
        'Else
        '    e.Handled = True 'deshabilita la tecla
        'End If
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
                If txtCantidad.Text <> "" Then
                    btnAgregar.Focus()
                Else
                    Me.Focus()
                End If
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

    Private Sub txtCodigoDeBarras_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoDeBarras.TextChanged
        'txtCantidad.Enabled = True
        'btnAgregar.Enabled = True
        'If txtCodigoDeBarras.Text = "" Then
        '    txtCodigoDeBarras.Text = ""
        'Else
        '    productoNuevo = traeProducto.ObtenerProductoVenta(txtCodigoDeBarras.Text.ToString)
        '    'txtCantidad.Text = 1
        '    txtPrecio.Text = Math.Round(traeProducto.MostrarPrecioDeProducto(productoNuevo.IdPrecioDeVenta1), 2)


        '    cantidadDeProductos = txtCantidad.Text
        '    precio = txtPrecio.Text
        '    importe = cantidadDeProductos * precio
        'End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        If txtCantidad.Text = "" Then
            cantidadDeProductos = 0
        Else
            cantidadDeProductos = txtCantidad.Text
            importe = cantidadDeProductos * precio
        End If
    End Sub

    Private Sub cboCondicionDeVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCondicionDeVenta.SelectedIndexChanged
        For Each condicion In condicionesVenta.MostrarCondicionesDeVentaCompra
            If condicion.NombreCondicion1 = cboCondicionDeVenta.SelectedItem Then
                idCondicionDeVenta = condicion.IdRef_CondicionVentaCompra1
            End If
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCliente.SelectedIndexChanged
        For Each cliente In clientes.TraeClientes
            If cliente.ApellidoYNombre1 = cboCliente.SelectedItem Then
                cliente.ApellidoYNombre1 = cboCliente.SelectedItem
                idPersona = cliente.IdPersona1
            End If
        Next
        idCliente = clientes.TraeClientePorIdDePersona(idPersona)
    End Sub

    Private Sub dgvVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellContentClick
        If e.ColumnIndex = dgvVentas.Columns.Item("Check").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = dgvVentas.Rows(e.RowIndex).Cells("Check")
            chkCell.Value = Not chkCell.Value

            If (chkCell.Value <> 0) Then
                '
                If MsgBox("¿Desea Eliminar?", vbYesNo + vbQuestion) = vbYes Then
                    Dim precioT As Double = Convert.ToDouble(dgvVentas.Rows(e.RowIndex).Cells(9).Value)

                    precioTotalDeVenta -= precioT


                    dgvVentas.Rows.Remove(dgvVentas.Rows(e.RowIndex))

                    If dgvVentas.Rows.Count = 0 Then
                        precioTotalDeVenta = 0
                        btnConfirmarVenta.Enabled = False
                    End If
                    txtTotalVenta.Text = Math.Round(precioTotalDeVenta, 2)
                End If
            End If
        End If
    End Sub

    Private Sub dgvVentas_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellMouseEnter
        If e.RowIndex > -1 Then
            dgvVentas.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub lblCodigoDeBarras_Leave(sender As Object, e As EventArgs) Handles lblCodigoDeBarras.Leave

    End Sub
End Class