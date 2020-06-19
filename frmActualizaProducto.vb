Public Class frmActualizaProducto
    Private id As Integer
    Dim unidades As New Funciones
    Dim rubros As New Funciones
    Dim tiposProductos As New Funciones
    Dim tiposEnvases As New Funciones
    Dim marcas As New Funciones
    Dim nombreProducto As New Funciones
    Dim productoExiste As New Funciones
    Dim precioViejo As Double
    Dim idUnidadDeMedida As Integer = 0
    Dim idRubroProducto As Integer = 0
    Dim idTipoProducto As Integer = 0
    Dim idMarca As Integer = 0
    Dim idMarcaProducto As Integer = 0
    Dim idTipoEnvase As Integer = 0

    Public Sub New(ByVal idProducto As Integer)

        Me.id = idProducto
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmActualizaPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Dim producto As New Funciones
        Dim precioProducto As New Funciones
        For Each prod In producto.TraeProductoPorId(id)
            txtId.Text = prod.IdProducto1
            txtNombreProducto.Text = prod.NombreProducto1
            cboUnidadMedida.SelectedText = unidades.MostrarUnidadDeMedidaPorId(prod.IdRef_UnidadDeMedida1)
            idUnidadDeMedida = prod.IdRef_UnidadDeMedida1
            txtMedida.Text = prod.Medida1
            txtStockMinimo.Text = prod.StockMinimo1
            cboRubro.SelectedText = rubros.MostrarRubrosPorId(prod.IdRef_RubroProducto1)
            idRubroProducto = prod.IdRef_RubroProducto1
            cboTipo.SelectedText = tiposProductos.MostrarTiposDeProductoPorId(prod.IdRef_TipoProduto1)
            idTipoProducto = prod.IdRef_TipoProduto1
            cboTipoEnvase.SelectedText = tiposEnvases.MostrarTiposDeEnvasesPorId(prod.IdRef_TipoEnvase1)
            idTipoEnvase = prod.IdRef_TipoEnvase1
            cboMarca.SelectedText = marcas.MostrarMarcaPorId(prod.IdRef_Marca1)
            idMarcaProducto = prod.IdRef_Marca1
            precioViejo = precioProducto.MostrarPrecioDeProducto(prod.IdPrecioDeVenta1)
            txtNuevoPrecioVenta.Text = precioViejo
            txtCodigoBarras.Text = prod.CodigoBarras1
        Next

        txtNombreProducto.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Validar() Then
            If MsgBox("¿ESTA SEGURO?", vbYesNo + vbQuestion) = vbYes Then
                Dim producto As New Producto
                producto.IdProducto1 = id
                producto.NombreProducto1 = txtNombreProducto.Text
                producto.IdRef_UnidadDeMedida1 = idUnidadDeMedida
                producto.Medida1 = txtMedida.Text
                producto.CodigoBarras1 = txtCodigoBarras.Text
                producto.StockMinimo1 = txtStockMinimo.Text
                producto.IdRef_RubroProducto1 = idRubroProducto
                producto.IdRef_TipoProduto1 = idTipoProducto
                producto.IdRef_TipoEnvase1 = idTipoEnvase
                producto.IdRef_Marca1 = idMarcaProducto

                Dim precio As New PrecioDeVenta
                txtNuevoPrecioVenta.Text = Replace(txtNuevoPrecioVenta.Text, ".", ",")
                precio.Precio1 = txtNuevoPrecioVenta.Text
                precio.FechaDesde1 = dtpFecha.Value

                Dim actualizar As New Funciones
                actualizar.ActualizarDatosDeProductos(producto, precio, precioViejo)
                precioViejo = txtNuevoPrecioVenta.Text
                Dim abrirForm As New Funciones()
                abrirForm.AbrirFormEnPanel(New frmPadronProductos)
            End If
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtNombreProducto.Text = ""
        txtId.Text = ""
        txtCodigoBarras.Text = ""
        cboUnidadMedida.Text = "Seleccionar"
        txtMedida.Text = ""
        txtStockMinimo.Text = ""
        cboRubro.Text = "Seleccionar"
        cboTipo.Text = "Seleccionar"
        cboMarca.Text = "Seleccionar"
        cboTipoEnvase.Text = "Seleccionar"
        txtNuevoPrecioVenta.Text = ""
        Dim abrirForm As New Funciones()
        abrirForm.AbrirFormEnPanel(New frmPadronProductos)
    End Sub

    Private Sub txtMedida_TextChanged(sender As Object, e As EventArgs) Handles txtMedida.TextChanged
        If txtMedida.Text = "" Then
            lblMuestraUnidMedida.Text = ""
        Else
            lblMuestraUnidMedida.Text = cboUnidadMedida.Text & "/s"
        End If
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

        If Len(txtCodigoBarras.Text) < 4 Then
            MessageBox.Show("Debe completar el CODIGO DE BARRAS del producto")
            txtCodigoBarras.Select()
            Return False
        End If

        If (idUnidadDeMedida = 0) Then
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

        If (idRubroProducto = 0) Then
            MessageBox.Show("Debe completar el RUBRO del producto")
            cboRubro.Select()
            Return False
        End If

        If (idTipoProducto = 0) Then
            MessageBox.Show("Debe completar el TIPO del producto")
            cboTipo.Select()
            Return False
        End If

        If (idMarcaProducto = 0) Then
            MessageBox.Show("Debe completar la MARCA del producto")
            cboMarca.Select()
            Return False
        End If

        If (idTipoEnvase = 0) Then
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

    Private Sub cboUnidadMedida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUnidadMedida.SelectedIndexChanged
        For Each unidad In unidades.MostrarUnidadesDeMedida
            If (unidad.NombreUnidadDeMedida1 = cboUnidadMedida.SelectedItem) Then
                idUnidadDeMedida = unidad.IdRef_UnidadDeMedida1
            End If
        Next
        'MessageBox.Show(idUnidadDeMedida)
    End Sub

    Private Sub cboRubro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRubro.SelectedIndexChanged
        For Each rubro In rubros.MostrarRubrosDeProductos
            If (rubro.NombreRubroProducto1 = cboRubro.SelectedItem) Then
                idRubroProducto = rubro.IdRef_RubroProducto1
            End If
        Next
        ' MessageBox.Show(idRubroProducto)
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        For Each tipo In tiposProductos.MostrarTiposDeProductos
            If (tipo.NombreTipoProducto1 = cboTipo.SelectedItem) Then
                idTipoProducto = tipo.IdRef_TipoProducto1
            End If
        Next
        'MessageBox.Show(idTipoProducto)
    End Sub

    Private Sub cboMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMarca.SelectedIndexChanged
        For Each marca In marcas.MostrarMarcas
            If (marca.NombreMarca1 = cboMarca.SelectedItem) Then
                idMarcaProducto = marca.IdRef_Marca1
            End If
        Next
        'MessageBox.Show(idMarcaProducto)
    End Sub

    Private Sub cboTipoEnvase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoEnvase.SelectedIndexChanged
        For Each tipoEnvase In tiposEnvases.MostrarTiposDeEnvases
            If (tipoEnvase.NombreTipoEnvase1 = cboTipoEnvase.SelectedItem) Then
                idTipoEnvase = tipoEnvase.IdRef_TipoEnvase1
            End If
        Next
        'MessageBox.Show(idTipoEnvase)
    End Sub

    Private Sub txtNuevoPrecioVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNuevoPrecioVenta.KeyPress
        Dim dig As Integer = Len(txtNuevoPrecioVenta.Text & e.KeyChar)
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
End Class