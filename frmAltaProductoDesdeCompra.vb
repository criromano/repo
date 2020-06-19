Public Class frmAltaProductoDesdeCompra
    Dim detalle As New List(Of DetalleCompra)
    Dim detalleSinCodigo As New List(Of DetalleCompraSinCodigo)
    Dim funcion As New Funciones
    Dim unidades As New Funciones
    Dim rubros As New Funciones
    Dim tiposProductos As New Funciones
    Dim tiposEnvases As New Funciones
    Dim marcas As New Funciones
    Dim idUnidadDeMedida As Integer
    Dim idRubroProducto As Integer
    Dim idTipoProducto As Integer
    Dim idTipoEnvase As Integer
    Dim idMarcaProducto As Integer
    Dim codigoNuevo As String
    Dim idCondicionDeCompra As Integer
    Dim idProveedor As Integer

    Public Sub New(lista As List(Of DetalleCompra), listaSinCodigo As List(Of DetalleCompraSinCodigo), codigoNuevo As String, idCondicionDeCompra As Integer, idProveedor As Integer)

        Me.detalle = lista
        Me.detalleSinCodigo = listaSinCodigo
        Me.codigoNuevo = codigoNuevo
        Me.idCondicionDeCompra = idCondicionDeCompra
        Me.idProveedor = idProveedor
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmAltaProductoDesdeCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If codigoNuevo <> "" Then
            txtCodigoBarras.Text = codigoNuevo
        End If
        txtNombreProducto.Focus()
        'CARGA LAS UNIDADES DE MEDIDA EN EL COMBO USANDO LA FUNCION MOSTRARUNIDADESDEMEDIDA
        For Each unidad In unidades.MostrarUnidadesDeMedida
            cboUnidadMedida.Items.Add(unidad.NombreUnidadDeMedida1)
        Next

        'CARGA LOS RUBROS DE LOS PRODUCTOS EN EL COMBO USANDO LA FUNCION MOSTRARRUBROSDEPRODUCTOS
        For Each rubro In rubros.MostrarRubrosDeProductos
            cboRubro.Items.Add(rubro.NombreRubroProducto1)
        Next

        'CARGA LOS TIPOS DE PRODUCTOS EN EL COMBO USANDO LA FUNCION MOSTRARTIPOSDEPRODUCTOS
        For Each tipoProducto In tiposProductos.MostrarTiposDeProductos
            cboTipo.Items.Add(tipoProducto.NombreTipoProducto1)
        Next

        'CARGA LOS TIPOS DE ENVASES EN EL COMBO USANDO LA FUNCION MOSTRARTIPOSDEENVASES
        For Each tipoEnvase In tiposEnvases.MostrarTiposDeEnvases
            cboTipoEnvase.Items.Add(tipoEnvase.NombreTipoEnvase1)
        Next

        'CARGA LAS MARCAS EN EL COMBO USANDO LA FUNCION MOSTRARMARCAS
        For Each marca In marcas.MostrarMarcas
            cboMarca.Items.Add(marca.NombreMarca1)
        Next
        For Each producto In detalle
            txtId.Text = producto.IdProducto1
        Next
        txtId.Text = funcion.ObtenerUltimoIDProducto() + 1
    End Sub

    Private Function Validar() As Boolean
        '------------------------------------------
        'COMPRUEBA CAMPOS ANTES DE GUARDAR
        '------------------------------------------
        If Len(txtNombreProducto.Text) = 0 Then
            MessageBox.Show("Debe completar el NOMBRE del producto")
            txtNombreProducto.Select()
            Return False
        End If

        If Len(txtCodigoBarras.Text) < 4 Then ' si es menor que 8, cod puede ser con 13 o 11 o 8
            MessageBox.Show("Debe completar el CODIGO DE BARRAS del producto")
            txtCodigoBarras.Select()
            Return False
        End If

        If (cboUnidadMedida.SelectedItem = "") Then
            MessageBox.Show("Debe completar la UNIDAD DE MEDIDA del producto")
            cboUnidadMedida.Select()
            Return False
        End If

        If Len(txtMedida.Text) = 0 Then
            MessageBox.Show("Debe completar la MEDIDA del producto")
            txtMedida.Select()
            Return False
        End If

        If Len(txtStockMinimo.Text) = 0 Then
            MessageBox.Show("Debe completar el STOCK MINIMO del producto")
            txtStockMinimo.Select()
            Return False
        End If

        If (cboRubro.SelectedItem = "") Then
            MessageBox.Show("Debe completar el RUBRO del producto")
            cboRubro.Select()
            Return False
        End If

        If (cboTipo.SelectedItem = "") Then
            MessageBox.Show("Debe completar el TIPO del producto")
            cboTipo.Select()
            Return False
        End If

        If (cboMarca.SelectedItem = "") Then
            MessageBox.Show("Debe completar la MARCA del producto")
            cboMarca.Select()
            Return False
        End If

        If (cboTipoEnvase.SelectedItem = "") Then
            MessageBox.Show("Debe completar el TIPO DE ENVASE del producto")
            cboTipoEnvase.Select()
            Return False
        End If

        If Len(txtNuevoPrecioVenta.Text) = 0 Then
            MessageBox.Show("Debe completar el PRECIO DE VENTA del producto")
            txtNuevoPrecioVenta.Select()
            Return False
        End If

        Return True

		'------------------------------------------
	End Function
	Private Sub btnGuardarProductos_Click(sender As Object, e As EventArgs) Handles btnGuardarProductos.Click
        If Validar() Then
            If MsgBox("¿ESTA SEGURO?", vbYesNo + vbQuestion) = vbYes Then
                Dim yaExisteProducto As Integer = 0
                Dim yaExisteCodigo As Integer = 0
                Dim producto As New Producto

                producto.IdProducto1 = txtId.Text
                producto.NombreProducto1 = txtNombreProducto.Text
                producto.IdRef_UnidadDeMedida1 = idUnidadDeMedida
                producto.Medida1 = txtMedida.Text
                producto.CodigoBarras1 = txtCodigoBarras.Text
                producto.StockMinimo1 = txtStockMinimo.Text
                producto.IdRef_RubroProducto1 = idRubroProducto
                producto.IdRef_TipoProduto1 = idTipoProducto
                producto.IdRef_TipoEnvase1 = idTipoEnvase
                producto.IdRef_Marca1 = idMarcaProducto
                Dim verificaSiExisteProducto As New Funciones
                For Each productoExistente In verificaSiExisteProducto.ListaDeProductos()
                    If producto.CodigoBarras1 = productoExistente.CodigoBarras1 Then
                        MessageBox.Show("El código de barras ingresado pertenece a otro producto")
                        yaExisteCodigo = 1
                        txtCodigoBarras.Focus()
                    Else
                        If productoExistente.NombreProducto1 = producto.NombreProducto1 And productoExistente.IdRef_UnidadDeMedida1 = producto.IdRef_UnidadDeMedida1 And productoExistente.Medida1 = producto.Medida1 And productoExistente.IdRef_RubroProducto1 = producto.IdRef_RubroProducto1 And productoExistente.IdRef_TipoProduto1 = producto.IdRef_TipoProduto1 And productoExistente.IdRef_TipoEnvase1 = producto.IdRef_TipoEnvase1 And productoExistente.IdRef_Marca1 = producto.IdRef_Marca1 Then
                            yaExisteProducto = 1
                        End If
                    End If
                Next
                If yaExisteProducto = 1 Or yaExisteCodigo = 1 Then
                    If yaExisteProducto = 1 Then
                        MessageBox.Show("El producto ingresado ya existe")
                    End If
                Else
                    Dim productoNuevo As New Funciones
                    Dim precioVenta As New PrecioDeVenta
                    txtNuevoPrecioVenta.Text = Replace(txtNuevoPrecioVenta.Text, ".", ",")
                    precioVenta.Precio1 = txtNuevoPrecioVenta.Text
                    precioVenta.FechaDesde1 = dtpFecha.Value
                    productoNuevo.GuardaPrecioDeProducto(precioVenta)
                    productoNuevo.AgregarProductoNuevo(producto)
                    Dim ultimoId As New Funciones
                    Dim id, cantidad As Integer
                    id = ultimoId.ObtenerUltimoIDProducto()
                    'ultimoId.AgregaStockPorCompra(id, cantidad)

                    funcion.AbrirFormEnPanel(New frmNuevaCompra(detalle, detalleSinCodigo, producto, idCondicionDeCompra, idProveedor))
                End If
            End If
            'Dim productonuevo As New Producto
            'productonuevo.NombreProducto1 = txtNombreProducto.Text
            'productonuevo.IdRef_UnidadDeMedida1 = idUnidadDeMedida
            'productonuevo.Medida1 = txtMedida.Text
            'productonuevo.CodigoBarras1 = txtCodigoBarras.Text
            'productonuevo.StockMinimo1 = txtStockMinimo.Text
            'productonuevo.IdRef_RubroProducto1 = idRubroProducto
            'productonuevo.IdRef_TipoProduto1 = idTipoProducto
            'productonuevo.IdRef_TipoEnvase1 = idTipoEnvase
            'productonuevo.IdRef_Marca1 = idMarcaProducto

            'Dim precioventa As New PrecioDeVenta
            'precioventa.FechaDesde1 = dtpFecha.Value
            'precioventa.Precio1 = txtNuevoPrecioVenta.Text

            'productonuevo.Vigente1 = 1

            'Dim guardar As New Funciones
            'guardar.GuardaPrecioDeProducto(precioventa)
            'guardar.AgregarProductoNuevo(productonuevo)

        End If
    End Sub

	Private Sub cboUnidadMedida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUnidadMedida.SelectedIndexChanged
        For Each unidad In unidades.MostrarUnidadesDeMedida
            If (unidad.NombreUnidadDeMedida1 = cboUnidadMedida.SelectedItem) Then
                idUnidadDeMedida = unidad.IdRef_UnidadDeMedida1
            End If
        Next
    End Sub

    Private Sub cboRubro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRubro.SelectedIndexChanged
        For Each rubro In rubros.MostrarRubrosDeProductos
            If (rubro.NombreRubroProducto1 = cboRubro.SelectedItem) Then
                idRubroProducto = rubro.IdRef_RubroProducto1
            End If
        Next
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        For Each tipo In tiposProductos.MostrarTiposDeProductos
            If (tipo.NombreTipoProducto1 = cboTipo.SelectedItem) Then
                idTipoProducto = tipo.IdRef_TipoProducto1
            End If
        Next
    End Sub

    Private Sub cboTipoEnvase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoEnvase.SelectedIndexChanged
        For Each tipoEnvase In tiposEnvases.MostrarTiposDeEnvases
            If (tipoEnvase.NombreTipoEnvase1 = cboTipoEnvase.SelectedItem) Then
                idTipoEnvase = tipoEnvase.IdRef_TipoEnvase1
            End If
        Next
    End Sub

    Private Sub cboMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMarca.SelectedIndexChanged
        For Each marca In marcas.MostrarMarcas
            If (marca.NombreMarca1 = cboMarca.SelectedItem) Then
                idMarcaProducto = marca.IdRef_Marca1
            End If
        Next
    End Sub

    Private Sub txtNuevoPrecioVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNuevoPrecioVenta.KeyPress
        Dim dig As Integer = Len(txtNuevoPrecioVenta.Text & e.KeyChar)
        Dim a, esDecimal, NumDecimales As Integer
        Dim esDec As Boolean
        Dim coma As Char
        ' se verifica si es un digito o un punto para el decimal 
        'If e.KeyChar.IsDigit(e.KeyChar) Or e.KeyChar = "," Then
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
        If txtNuevoPrecioVenta.SelectedText = "" Then
            ' aqui se hace el for para controlar que el numero sea de dos digitos - contadose a partir del punto decimal.
            For a = 0 To dig - 1
                Dim car As String = CStr(txtNuevoPrecioVenta.Text & e.KeyChar)
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

    Private Sub txtStockMinimo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStockMinimo.KeyPress
        '------------------------------------------------
        'SOLO NUMEROS
        '------------------------------------------------
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True 'deshabilita la tecla
        End If
    End Sub

    Private Sub txtMedida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMedida.KeyPress
        Dim dig As Integer = Len(txtMedida.Text & e.KeyChar)
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
        If txtMedida.SelectedText = "" Then
            ' aqui se hace el for para controlar que el numero sea de dos digitos - contadose a partir del punto decimal.
            For a = 0 To dig - 1
                Dim car As String = CStr(txtMedida.Text & e.KeyChar)
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

    Private Sub txtCodigoBarras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoBarras.KeyPress
        '------------------------------------------------
        'SOLO NUMEROS
        '------------------------------------------------
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            If (e.KeyChar = Chr(13)) Then ' Se Preciona enter
                If Len(txtCodigoBarras.Text) > 7 Then ' si es mayor que 7, cod puede ser con 13 o 11 o 8
                    cboUnidadMedida.Select()
                Else
                    Me.Select() 'el foco sigue en el textbox
                End If
            End If
        Else
            e.Handled = True 'deshabilita la tecla
        End If
    End Sub

    Private Sub txtMedida_TextChanged(sender As Object, e As EventArgs) Handles txtMedida.TextChanged
        If txtMedida.Text = "" Then
            lblMuestraUnidMedida.Text = ""
        Else
            lblMuestraUnidMedida.Text = cboUnidadMedida.Text & "/S"
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        funcion.AbrirFormEnPanel(New frmNuevaCompra(detalle, detalleSinCodigo, idCondicionDeCompra, idProveedor))
        'txtNombreProducto.Text = ""
        'txtId.Text = ""
        'txtCodigoBarras.Text = ""
        'cboUnidadMedida.Text = "Seleccionar"
        'txtMedida.Text = ""
        'txtStockMinimo.Text = ""
        'cboRubro.Text = "Seleccionar"
        'cboTipo.Text = "Seleccionar"
        'cboMarca.Text = "Seleccionar"
        'cboTipoEnvase.Text = "Seleccionar"
        'txtNuevoPrecioVenta.Text = ""
        'txtNombreProducto.Focus()
    End Sub

End Class