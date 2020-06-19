Public Class frmNuevaCompra
	Dim cantidadDeProductos, precio, importe As Double
	Dim productoNuevo As New Producto
	Dim traeProducto As New Funciones
    Dim precioTotalDeCompra As Double = 0
    Dim registraCompra As New Funciones
    Dim listaDetalleCompra As New List(Of DetalleCompra)
    Dim listaDetalleCompraSinCodigoBarras As New List(Of DetalleCompraSinCodigo)
    Dim listaPreciosDeVentaNuevos As New List(Of Producto)
    Dim precioDeVenta As Double
    Dim idProductoSinCodigo As Integer
    Dim proveedores As New Funciones
    Dim idProveedor As Integer = 0
    Dim condiciones As New Funciones
    Dim idCondicionDeCompra As Integer = 1

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New(lista As List(Of DetalleCompra), listaSinCodigo As List(Of DetalleCompraSinCodigo), idCondicionDeCompra As Integer, idProveedor As Integer)

        Me.listaDetalleCompra = lista
        Me.listaDetalleCompraSinCodigoBarras = listaSinCodigo
        Me.idCondicionDeCompra = idCondicionDeCompra
        Me.idProveedor = idProveedor
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New(lista As List(Of DetalleCompra), listaSinCodigo As List(Of DetalleCompraSinCodigo), productoNuevo As Producto, idCondicionDeCompra As Integer, idProveedor As Integer)

        Me.listaDetalleCompra = lista
        Me.listaDetalleCompraSinCodigoBarras = listaSinCodigo
        Me.productoNuevo = productoNuevo
        Me.idCondicionDeCompra = idCondicionDeCompra
        Me.idProveedor = idProveedor
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmNuevaCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If listaDetalleCompra.Count > 0 Or listaDetalleCompraSinCodigoBarras.Count > 0 Then
            dgvCompras.Visible = True
            lblTotalDeCompra.Visible = True
            txtTotalVenta.Visible = True
            'Dim importe As Double = 0
            For Each detalle In listaDetalleCompra
                Dim prod As New Producto
                Dim precioUnitario As Double
                prod = traeProducto.TraeObjetoProductoPorId(detalle.IdProducto1)
                precioUnitario = detalle.Importe1 / detalle.Cantidad1
                precioTotalDeCompra += detalle.Importe1
                dgvCompras.Rows.Add(detalle.IdProducto1, detalle.Cantidad1, traeProducto.MostrarTiposDeEnvasesPorId(prod.IdRef_TipoEnvase1), prod.NombreProducto1, prod.Medida1, traeProducto.MostrarUnidadDeMedidaPorId(prod.IdRef_UnidadDeMedida1), traeProducto.MostrarMarcaPorId(prod.IdRef_Marca1), prod.CodigoBarras1, precioUnitario, detalle.Importe1)
            Next
            For Each detalleSinCodigo In listaDetalleCompraSinCodigoBarras
                Dim prodSinCodigo As New ProductoSinCodigo
                prodSinCodigo = traeProducto.TraeObjetoProductoSinCodigoPorId(detalleSinCodigo.IdProductoSinCodigo1)
                precioTotalDeCompra += detalleSinCodigo.Importe1
                dgvCompras.Rows.Add(detalleSinCodigo.IdProductoSinCodigo1, detalleSinCodigo.Cantidad1, "", prodSinCodigo.Nombre1, "", "", "", 0, "", detalleSinCodigo.Importe1)
            Next
            txtTotalVenta.Text = precioTotalDeCompra
            listaDetalleCompra.Clear()
            listaDetalleCompraSinCodigoBarras.Clear()
        End If

        Dim condicionesVenta As New Funciones
        For Each condicion In condicionesVenta.MostrarCondicionesDeVentaCompra()
            cboCondicionDeCompra.Items.Add(condicion.NombreCondicion1)
        Next
        For Each condicion In condicionesVenta.MostrarCondicionesDeVentaCompra()
            If idCondicionDeCompra = condicion.IdRef_CondicionVentaCompra1 Then
                cboCondicionDeCompra.SelectedItem = condicion.NombreCondicion1
            End If
        Next
        For Each prov In proveedores.TraeProveedores
            cboProveedor.Items.Add(prov.RazonSocial1)
        Next
        For Each prov In proveedores.TraeProveedores
            If idProveedor = prov.IdProveedor1 Then
                cboProveedor.SelectedItem = prov.RazonSocial1
            End If
        Next
        txtCodigoDeBarras.Focus()
        txtCantidad.Text = 1
        btnAgregar.Enabled = False
        btnConfirmarCompra.Enabled = False

        If productoNuevo.IdProducto1 <> 0 Then
            txtCantidad.Enabled = True
            txtCantidad.Text = 1
            txtCodigoDeBarras.Text = productoNuevo.CodigoBarras1
            txtPrecioDeVenta.Text = Math.Round(traeProducto.MostrarPrecioDeProducto(productoNuevo.IdPrecioDeVenta1), 2)
            precio = txtPrecioDeVenta.Text
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

    Private Sub btnConfirmarCompra_Click(sender As Object, e As EventArgs) Handles btnConfirmarCompra.Click
        If idProveedor = 0 Then
            MessageBox.Show("Debe ingresar un proveedor")
            cboProveedor.Select()
        Else
            If MsgBox("¿ESTA SEGURO?", vbYesNo + vbQuestion) = vbYes Then
                Dim stock As New Funciones
                Dim Compra As New Compras
                Compra.FechaCompra1 = dtpFechaDeVenta.Value
                Compra.ImporteTotalDeCompra1 = Math.Round(Convert.ToDouble(txtTotalVenta.Text), 2)
                Compra.IdRef_CondicionVentaCompra1 = idCondicionDeCompra
                Compra.IdProveedor1 = idProveedor
                registraCompra.registrarNuevaCompra(Compra)

                stock.ActualizarPrecioDeVentaDeProducto(listaPreciosDeVentaNuevos)

                For Each fila In dgvCompras.Rows
                    If fila.CellS(7).Value = 0 Then
                        Dim detalleSinCodigo As New DetalleCompraSinCodigo
                        detalleSinCodigo.IdCompra1 = registraCompra.RecuperaUltimoIdCompra()
                        detalleSinCodigo.Cantidad1 = Convert.ToInt32(fila.Cells(1).Value)
                        detalleSinCodigo.Importe1 = Convert.ToDouble(fila.Cells(9).Value)
                        detalleSinCodigo.IdProductoSinCodigo1 = Convert.ToInt32(fila.Cells(0).Value)
                        listaDetalleCompraSinCodigoBarras.Add(detalleSinCodigo)
                    Else
                        Dim detalle As New DetalleCompra
                        detalle.IdCompra1 = registraCompra.RecuperaUltimoIdCompra()
                        detalle.Cantidad1 = Convert.ToInt32(fila.Cells(1).Value)
                        detalle.Importe1 = Convert.ToDouble(fila.Cells(9).Value)
                        detalle.IdProducto1 = Convert.ToInt32(fila.Cells(0).Value)
                        stock.AgregaStockPorCompra(detalle.IdProducto1, detalle.Cantidad1)
                        listaDetalleCompra.Add(detalle)
                    End If
                Next
                If listaDetalleCompra.Count > 0 Then
                    registraCompra.registrarDetalleDeCompra(listaDetalleCompra)
                    listaDetalleCompra.Clear()
                End If
                If listaDetalleCompraSinCodigoBarras.Count > 0 Then
                    registraCompra.registrarDetalleDeCompraSinCodigoDeBarras(listaDetalleCompraSinCodigoBarras)
                    listaDetalleCompraSinCodigoBarras.Clear()
                End If
                dgvCompras.Rows.Clear()
                txtTotalVenta.Text = ""
                btnConfirmarCompra.Enabled = False
                dgvCompras.Visible = False
                lblTotalDeCompra.Visible = False
                Label6.Visible = False
                txtTotalVenta.Visible = False
                precioTotalDeCompra = 0
                cboCondicionDeCompra.SelectedIndex = 0
                txtPrecioDeVenta.Enabled = False
                cboCondicionDeCompra.SelectedItem = "CONTADO"
                idCondicionDeCompra = 1
                cboProveedor.Text = "SELECCIONAR"
                idProveedor = 0
                txtCodigoDeBarras.Focus()
            End If
        End If
    End Sub

    Private Sub lblCambiarPrecioDeVenta_Click(sender As Object, e As EventArgs) Handles lblCambiarPrecioDeVenta.Click
        txtPrecioDeVenta.Enabled = True
        txtPrecioDeVenta.Focus()
    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        For Each fila In dgvCompras.Rows
            If fila.Cells(7).Value = 0 Then
                Dim detalleSinCodigo As New DetalleCompraSinCodigo
                detalleSinCodigo.Cantidad1 = Convert.ToInt32(fila.Cells(1).Value)
                detalleSinCodigo.Importe1 = Convert.ToDouble(fila.Cells(9).Value)
                detalleSinCodigo.IdProductoSinCodigo1 = Convert.ToInt32(fila.Cells(0).Value)
                listaDetalleCompraSinCodigoBarras.Add(detalleSinCodigo)
            Else
                Dim detalle As New DetalleCompra
                detalle.IdCompra1 = registraCompra.RecuperaUltimoIdCompra()
                detalle.Cantidad1 = Convert.ToInt32(fila.Cells(1).Value)
                detalle.Importe1 = Convert.ToDouble(fila.Cells(9).Value)
                detalle.IdProducto1 = Convert.ToInt32(fila.Cells(0).Value)
                listaDetalleCompra.Add(detalle)
            End If
        Next

        Dim abrirForm As New Funciones
        abrirForm.AbrirFormEnPanel(New frmPadronProductosParaCompras(listaDetalleCompra, listaDetalleCompraSinCodigoBarras, idCondicionDeCompra, idProveedor))
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
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

        If (e.KeyChar = Chr(13)) Then ' Se Preciona enter
            If txtCantidad.Text <> "" Then
                btnAgregar.Focus()
            Else
                Me.Focus()
            End If
        End If

        If Len(txtPrecio.Text) > 0 Then
            If txtPrecio.Text <> 0 Then
                If cboProducto.Visible = False Then
                    lblCambiarPrecioDeVenta.Enabled = True
                    btnAgregar.Enabled = True
                Else
                    btnAgregar.Enabled = True
                End If
            Else
                btnAgregar.Enabled = False
                lblCambiarPrecioDeVenta.Enabled = False
            End If
        Else
            btnAgregar.Enabled = False
            lblCambiarPrecioDeVenta.Enabled = False
        End If
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
        lblPrecioDeVenta.Visible = True
        Label3.Visible = True
        txtPrecioDeVenta.Visible = True
        lblCambiarPrecioDeVenta.Visible = True
        cboProducto.Focus()
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

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        If Len(txtPrecio.Text) > 0 Then
            If txtPrecio.Text = "," Then
                txtPrecio.Text = ""
            Else
                If txtPrecio.Text <> 0 Then
                    If cboProducto.Visible = False Then
                        lblCambiarPrecioDeVenta.Enabled = True
                        btnAgregar.Enabled = True
                    Else
                        btnAgregar.Enabled = True
                    End If
                Else
                    btnAgregar.Enabled = False
                    lblCambiarPrecioDeVenta.Enabled = False
                End If
            End If
        Else
            btnAgregar.Enabled = False
            lblCambiarPrecioDeVenta.Enabled = False
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
                If Len(txtCodigoDeBarras.Text) > 7 Then ' si es mayor que 7, cod puede ser con 13 o 11 o 8
                    If Len(txtCantidad.Text) > 0 Then
                        If txtCantidad.Text = 0 Then
                            txtCantidad.Focus()
                        Else
                            productoNuevo = traeProducto.ObtenerProductoVenta(txtCodigoDeBarras.Text)
                            If productoNuevo.IdProducto1 > 0 Then
                                lblDescripcion.Visible = True
                                txtDescripcion.Visible = True
                                lblPrecio.Visible = True
                                txtPrecio.Visible = True
                                lblPrecioDeVenta.Visible = True
                                txtPrecioDeVenta.Visible = True
                                lblCambiarPrecioDeVenta.Visible = True
                                btnAgregar.Visible = True
                                txtDescripcion.Text = productoNuevo.NombreProducto1 & " - " & traeProducto.MostrarMarcaPorId(productoNuevo.IdRef_Marca1) & " - " & traeProducto.MostrarTiposDeEnvasesPorId(productoNuevo.IdRef_TipoEnvase1) & " - " & productoNuevo.Medida1 & " " & traeProducto.MostrarUnidadDeMedidaPorId(productoNuevo.IdRef_UnidadDeMedida1) & "/S"
                                txtPrecio.Enabled = True
                                txtPrecio.Focus()
                                txtPrecioDeVenta.Text = Math.Round(traeProducto.MostrarPrecioDeProducto(productoNuevo.IdPrecioDeVenta1), 2)

                            Else
                                If MsgBox("El producto ingresado no existe, ¿Desea cargarlo ahora?", vbYesNo + vbQuestion) = vbYes Then
                                    For Each fila In dgvCompras.Rows
                                        If fila.Cells(7).Value = 0 Then
                                            Dim detalleSinCodigo As New DetalleCompraSinCodigo
                                            detalleSinCodigo.Cantidad1 = Convert.ToInt32(fila.Cells(1).Value)
                                            detalleSinCodigo.Importe1 = Convert.ToDouble(fila.Cells(9).Value)
                                            detalleSinCodigo.IdProductoSinCodigo1 = Convert.ToInt32(fila.Cells(0).Value)
                                            listaDetalleCompraSinCodigoBarras.Add(detalleSinCodigo)
                                        Else
                                            Dim detalle As New DetalleCompra
                                            detalle.IdCompra1 = registraCompra.RecuperaUltimoIdCompra()
                                            detalle.Cantidad1 = Convert.ToInt32(fila.Cells(1).Value)
                                            detalle.Importe1 = Convert.ToDouble(fila.Cells(9).Value)
                                            detalle.IdProducto1 = Convert.ToInt32(fila.Cells(0).Value)
                                            listaDetalleCompra.Add(detalle)
                                        End If
                                    Next
                                    Dim codigoCargado As String = txtCodigoDeBarras.Text

                                    Dim abrirForm As New Funciones
                                    abrirForm.AbrirFormEnPanel(New frmAltaProductoDesdeCompra(listaDetalleCompra, listaDetalleCompraSinCodigoBarras, codigoCargado, idCondicionDeCompra, idProveedor))
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
        txtPrecioDeVenta.Enabled = False
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

    Private Sub txtPrecioDeVenta_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioDeVenta.TextChanged

        If Len(txtPrecioDeVenta.Text) > 0 Then
            If txtPrecioDeVenta.Text = "," Then
                txtPrecioDeVenta.Text = ""
            Else
                If txtPrecioDeVenta.Text <> 0 And Len(txtPrecio.Text) > 0 Then
                    btnAgregar.Enabled = True
                Else
                    btnAgregar.Enabled = False
                End If
            End If
        Else
            btnAgregar.Enabled = False
        End If

    End Sub

    Private Sub txtCodigoDeBarras_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoDeBarras.TextChanged
        'precioDeVenta = 0
        'txtCantidad.Enabled = True
        'btnAgregar.Enabled = True
        'If txtCodigoDeBarras.Text = "" Then
        '    txtCodigoDeBarras.Text = ""
        '    lblCambiarPrecioDeVenta.Enabled = False
        '    txtCantidad.Text = ""
        '    txtPrecio.Enabled = False
        '    txtPrecioDeVenta.Text = ""
        '    txtCantidad.Enabled = False
        'Else
        '    productoNuevo = traeProducto.ObtenerProductoVenta(txtCodigoDeBarras.Text.ToString)
        '    txtCantidad.Text = 1
        '    'txtPrecio.Text = traeProducto.MostrarPrecioDeProducto(productoNuevo.IdPrecioDeVenta1)
        '    txtPrecioDeVenta.Text = Math.Round(traeProducto.MostrarPrecioDeProducto(productoNuevo.IdPrecioDeVenta1), 2)
        '    precioDeVenta = Convert.ToDouble(txtPrecioDeVenta.Text)
        '    cantidadDeProductos = txtCantidad.Text
        '    If txtPrecio.Text <> "" Then
        '        precio = txtPrecio.Text
        '    End If
        '    importe = cantidadDeProductos * precio
        '    txtPrecio.Enabled = True
        '    lblCambiarPrecioDeVenta.Enabled = True
        'End If
    End Sub

    Private Sub cboProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProveedor.SelectedIndexChanged
        For Each prov In proveedores.TraeProveedores
            If prov.RazonSocial1 = cboProveedor.SelectedItem Then
                idProveedor = prov.IdProveedor1
            End If
        Next
    End Sub

    Private Sub cboCondicionDeCompra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCondicionDeCompra.SelectedIndexChanged
        For Each cond In condiciones.MostrarCondicionesDeVentaCompra
            If cond.NombreCondicion1 = cboCondicionDeCompra.SelectedItem Then
                idCondicionDeCompra = cond.IdRef_CondicionVentaCompra1
            End If
        Next
    End Sub

    Private Sub dgvCompras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCompras.CellContentClick
        If e.ColumnIndex = dgvCompras.Columns.Item("Check").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = dgvCompras.Rows(e.RowIndex).Cells("Check")
            chkCell.Value = Not chkCell.Value

            If (chkCell.Value <> 0) Then
                '
                If MsgBox("¿Desea Eliminar?", vbYesNo + vbQuestion) = vbYes Then
                    Dim precioT As Double = Convert.ToDouble(dgvCompras.Rows(e.RowIndex).Cells(9).Value)

                    precioTotalDeCompra -= precioT

                    dgvCompras.Rows.Remove(dgvCompras.Rows(e.RowIndex))

                    If dgvCompras.Rows.Count = 0 Then
                        precioTotalDeCompra = 0
                        btnConfirmarCompra.Enabled = False
                    End If
                    txtTotalVenta.Text = Math.Round(precioTotalDeCompra, 2)
                End If
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If idProveedor = 0 Then
            MessageBox.Show("Debe seleccionar un proveedor")
            cboProveedor.Select()
        Else
            Dim valorACuenta As String = InputBox("Ingrese el monto a pagar", "Pago a proveedor", 0)
            If valorACuenta <> "" Then
                Dim pago As Double = Double.Parse(valorACuenta)

                condiciones.registraPagosACuentaProveedor(pago, idProveedor)
            End If
        End If

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtPrecio.Text = "" Then
            MessageBox.Show("Debe completar el precio de compra")
        Else
            Dim precio As New Funciones
            Dim productoConPrecioNuevo As New Producto
            If txtPrecioDeVenta.Text <> "" Then
                If txtPrecioDeVenta.Text <> Math.Round(traeProducto.MostrarPrecioDeProducto(productoNuevo.IdPrecioDeVenta1), 2) Then
                    Dim nuevoPrecio As New PrecioDeVenta
                    nuevoPrecio.Precio1 = txtPrecioDeVenta.Text
                    nuevoPrecio.FechaDesde1 = dtpFechaDeVenta.Value
                    precio.GuardaPrecioDeProducto(nuevoPrecio)
                    productoConPrecioNuevo.IdProducto1 = productoNuevo.IdProducto1
                    productoConPrecioNuevo.IdPrecioDeVenta1 = precio.TraeUltimoIdPrecioDeVenta
                    listaPreciosDeVentaNuevos.Add(productoConPrecioNuevo)
                End If
            End If
            ' ACA EMPEZABA EL EVENTO KEY PRESS DE CODIGO DE BARRAS
            If Len(txtCodigoDeBarras.Text) > 7 Then ' si es mayor que 7, cod puede ser con 13 o 11 o 8
                'productoNuevo = traeProducto.ObtenerProductoVenta(txtCodigoDeBarras.Text.ToString)
                If productoNuevo.IdProducto1 > 0 Then
                    dgvCompras.Visible = True
                    'txtPrecio.Text = Math.Round(traeProducto.MostrarPrecioDeProducto(productoNuevo.IdPrecioDeVenta1), 2)
                    Dim precioTotal As Double
                    precioTotal = txtPrecio.Text * txtCantidad.Text
                    dgvCompras.Rows.Add(productoNuevo.IdProducto1, txtCantidad.Text, traeProducto.MostrarTiposDeEnvasesPorId(productoNuevo.IdRef_TipoEnvase1), productoNuevo.NombreProducto1, productoNuevo.Medida1, traeProducto.MostrarUnidadDeMedidaPorId(productoNuevo.IdRef_UnidadDeMedida1), traeProducto.MostrarMarcaPorId(productoNuevo.IdRef_Marca1), txtCodigoDeBarras.Text, txtPrecio.Text, precioTotal)
                    txtCodigoDeBarras.Text = ""
                    txtPrecio.Text = 0
                    txtTotalVenta.Text = ""
                    precioTotalDeCompra += precioTotal
                    txtTotalVenta.Text = Math.Round(precioTotalDeCompra, 2)
                    btnAgregar.Enabled = False
                    btnAgregar.Visible = False
                    txtCodigoDeBarras.Focus()
                    lblTotalDeCompra.Visible = True
                    Label6.Visible = True
                    txtTotalVenta.Visible = True
                    txtCantidad.Text = 1
                    btnConfirmarCompra.Enabled = True
                    lblDescripcion.Visible = False
                    txtDescripcion.Text = ""
                    txtDescripcion.Visible = False
                    lblPrecio.Visible = False
                    txtPrecio.Visible = False
                    lblCambiarPrecioDeVenta.Enabled = False
                    lblCambiarPrecioDeVenta.Visible = False
                    txtPrecioDeVenta.Text = ""
                    txtPrecioDeVenta.Enabled = False
                    txtPrecioDeVenta.Visible = False
                    lblPrecioDeVenta.Visible = False
                Else
                    MessageBox.Show("El producto ingresado no existe, debe cargarlo")
                End If
            ElseIf Len(txtCodigoDeBarras.Text) < 8 And cboProducto.Visible = False Then ' si es menor que 8, cod puede ser con 13 o 11 o 8
                MessageBox.Show("Debe ingresar un código de barras válido")
                txtCodigoDeBarras.Focus()
            Else
                dgvCompras.Visible = True
                Dim subtotalDeCompra As Double = 0
                subtotalDeCompra = txtCantidad.Text * txtPrecio.Text
                Dim productoSincodigo As New ProductoSinCodigo
                productoSincodigo = traeProducto.TraeObjetoProductoSinCodigoPorId(idProductoSinCodigo)
                dgvCompras.Rows.Add(productoSincodigo.IdProductoSinCodigo1, txtCantidad.Text, "", productoSincodigo.Nombre1, "", "", "", 0, txtPrecio.Text, subtotalDeCompra)
                txtCodigoDeBarras.Text = ""
                txtCantidad.Text = 1
                txtPrecio.Text = 0
                txtTotalVenta.Text = ""
                precioTotalDeCompra += subtotalDeCompra
                txtTotalVenta.Text = precioTotalDeCompra
                btnAgregar.Enabled = False
                txtCodigoDeBarras.Focus()
                lblTotalDeCompra.Visible = True
                Label4.Visible = True
                Label6.Visible = True
                txtTotalVenta.Visible = True
                lblDescripcion.Visible = False
                lblPrecio.Visible = False
                Label4.Visible = False
                txtPrecio.Enabled = False
                cboProducto.Visible = False
                txtPrecio.Visible = False
                txtPrecioDeVenta.Text = ""
                txtPrecioDeVenta.Enabled = False
                btnAgregar.Visible = False
                btnConfirmarCompra.Enabled = True
                txtPrecioDeVenta.Visible = False
                Label3.Visible = False
                lblCambiarPrecioDeVenta.Visible = False
                lblPrecioDeVenta.Visible = False
                Me.Select() 'el foco sigue en el textbox
            End If
        End If
    End Sub

    Private Sub txtPrecioDeVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioDeVenta.KeyPress
        Dim dig As Integer = Len(txtPrecioDeVenta.Text & e.KeyChar)
        Dim a, esDecimal, NumDecimales As Integer
        Dim esDec As Boolean
        Dim coma As Char
        ' se verifica si es un digito o un punto para el decimal 
        If e.KeyChar.IsDigit(e.KeyChar) Or e.KeyChar = "," Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
            'Return a
        Else
            e.Handled = True
        End If
        If dig = 1 And e.KeyChar = "," Then 'si dig=1 y es un punto rechaza 
            e.Handled = True
            'Return a
        End If
        If txtPrecioDeVenta.SelectedText = "" Then
            ' aqui se hace el for para controlar que el numero sea de dos digitos - contadose a partir del punto decimal.
            For a = 0 To dig - 1
                Dim car As String = CStr(txtPrecioDeVenta.Text & e.KeyChar)
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

        If Len(txtPrecioDeVenta.Text) > 0 Then
            If txtPrecioDeVenta.Text <> 0 Then
                btnAgregar.Enabled = True
            Else
                btnAgregar.Enabled = False
            End If
        Else
            btnAgregar.Enabled = False
        End If
    End Sub

End Class