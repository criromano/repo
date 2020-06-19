Public Class frmPadronProductosParaCompras
    Dim detalle As New List(Of DetalleCompra)
    Dim detalleSinCodigo As New List(Of DetalleCompraSinCodigo)
    Dim ds = New DataSet
    Dim productos As New Funciones
    Dim idCondicionDeCompra As Integer
    Dim idProveedor As Integer

    Public Sub New(ByVal lista As List(Of DetalleCompra), ByVal listaSinCodigo As List(Of DetalleCompraSinCodigo), idCondicionDeCompra As Integer, idProveedor As Integer)

        Me.detalle = lista
        Me.detalleSinCodigo = listaSinCodigo
        Me.idCondicionDeCompra = idCondicionDeCompra
        Me.idProveedor = idProveedor
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmPadronProductosParaCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        productos.TraeProductos("", 2).Fill(ds, "producto,ref_unidaddemedida,ref_rubroproducto,ref_tipoproducto,ref_tipoenvase,ref_marca")
        If ds.Tables("producto,ref_unidaddemedida,ref_rubroproducto,ref_tipoproducto,ref_tipoenvase,ref_marca").Rows.Count > 0 Then
            dgvProductos.DataSource = ds.Tables("producto,ref_unidaddemedida,ref_rubroproducto,ref_tipoproducto,ref_tipoenvase,ref_marca")

            OrderColumna()
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        End If
    End Sub

    Private Sub OrderColumna()

        Me.dgvProductos.Columns("Id").Visible = False
        Me.dgvProductos.Columns("C. Barras").Visible = False
        Me.dgvProductos.Columns("Rubro").Visible = False
        Me.dgvProductos.Columns("Vigente").Visible = False


        Me.dgvProductos.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvProductos.Columns("Nombre").FillWeight = 170
        Me.dgvProductos.Columns("Nombre").Width = 170
        Me.dgvProductos.Columns("Nombre").DisplayIndex = 0

        Me.dgvProductos.Columns("Tipo").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvProductos.Columns("Tipo").FillWeight = 110
        Me.dgvProductos.Columns("Tipo").Width = 110
        Me.dgvProductos.Columns("Tipo").DisplayIndex = 1

        Me.dgvProductos.Columns("Marca").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvProductos.Columns("Marca").FillWeight = 150
        Me.dgvProductos.Columns("Marca").Width = 150
        Me.dgvProductos.Columns("Marca").DisplayIndex = 2

        Me.dgvProductos.Columns("Precio").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvProductos.Columns("Precio").FillWeight = 80
        Me.dgvProductos.Columns("Precio").Width = 80
        Me.dgvProductos.Columns("Precio").DisplayIndex = 3

        Me.dgvProductos.Columns("Envase").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvProductos.Columns("Envase").FillWeight = 130
        Me.dgvProductos.Columns("Envase").Width = 130
        Me.dgvProductos.Columns("Envase").DisplayIndex = 4

        Me.dgvProductos.Columns("Medida").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvProductos.Columns("Medida").FillWeight = 130
        Me.dgvProductos.Columns("Medida").Width = 130
        Me.dgvProductos.Columns("Medida").DisplayIndex = 5

        Me.dgvProductos.Columns("U.medida").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvProductos.Columns("U.medida").FillWeight = 100
        Me.dgvProductos.Columns("U.medida").Width = 100
        Me.dgvProductos.Columns("U.medida").DisplayIndex = 6


        Me.dgvProductos.Columns("Stock").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvProductos.Columns("Stock").FillWeight = 115
        Me.dgvProductos.Columns("Stock").Width = 115
        Me.dgvProductos.Columns("Stock").DisplayIndex = 7

        Me.dgvProductos.Columns("Id").DisplayIndex = 8 'Orden en el la tabla
        Me.dgvProductos.Columns("C. Barras").DisplayIndex = 9
        Me.dgvProductos.Columns("Rubro").DisplayIndex = 10
        Me.dgvProductos.Columns("Vigente").DisplayIndex = 11
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        '--------------------------------
        'COD.BARRAS
        '----------------------------------
        If (e.KeyChar = Chr(13)) Then 'Cuando se termina de leer el cod. simula un enter ..
            If IsNumeric(txtFiltro.Text) Then 'Si es numerico
                If Len(txtFiltro.Text) > 7 Then ' si es mayor que 7, cod puede ser con 13 o 11 o 8
                    BuscarProductos(1) 'Busca Codigo
                End If
            End If
        End If
    End Sub

    Private Sub txtFiltro_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyUp

        If Len(txtFiltro.Text) >= 0 Then
            If Not IsNumeric(txtFiltro.Text) Then 'Si no es numerico
                BuscarProductos(2) 'Busca por Nombre
            End If
        End If
    End Sub

    Private Sub BuscarProductos(tipo As Integer)
        dgvProductos.DataSource = Nothing
        ds.Clear()

        If tipo = 1 Then
            'BUSCA POR COD.BARRAS
            productos.TraeProductos(txtFiltro.Text, 2).Fill(ds, "producto,ref_unidaddemedida,ref_rubroproducto,ref_tipoproducto,ref_tipoenvase,ref_marca")
        Else
            'BUSCA POR NOMBRE PRODUCTO
            productos.TraeProductos(txtFiltro.Text, 1).Fill(ds, "producto,ref_unidaddemedida,ref_rubroproducto,ref_tipoproducto,ref_tipoenvase,ref_marca")
        End If

        If ds.Tables("producto,ref_unidaddemedida,ref_rubroproducto,ref_tipoproducto,ref_tipoenvase,ref_marca").Rows.Count > 0 Then
            dgvProductos.DataSource = ds.Tables("producto,ref_unidaddemedida,ref_rubroproducto,ref_tipoproducto,ref_tipoenvase,ref_marca")

            OrderColumna()
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        End If
    End Sub

    Private Sub dgvProductos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellContentDoubleClick

    End Sub

    Private Sub txtFiltro_LostFocus(sender As Object, e As EventArgs) Handles txtFiltro.LostFocus
        If Len(txtFiltro.Text) = 0 Then
            txtFiltro.ForeColor = Color.DimGray
            txtFiltro.Text = "BUSCAR PRODUCTO : POR COD.BARRAS O EL NOMBRE"
        End If
    End Sub

    Private Sub txtFiltro_GotFocus(sender As Object, e As EventArgs) Handles txtFiltro.GotFocus
        txtFiltro.ForeColor = Color.Black
        txtFiltro.Text = ""
    End Sub

    Private Sub btnAltaProducto_Click(sender As Object, e As EventArgs) Handles btnAltaProducto.Click
        Dim mostrarPanel As New Funciones
        mostrarPanel.AbrirFormEnPanel(New frmAltaProductoDesdeCompra(detalle, detalleSinCodigo, "", idCondicionDeCompra, idProveedor))
    End Sub

    Private Sub dgvProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick

    End Sub

    Private Sub dgvProductos_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellMouseEnter
        If e.RowIndex > -1 Then
            dgvProductos.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub dgvProductos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellDoubleClick
        Dim producto As New Producto
        Dim idProducto As Integer = dgvProductos.Rows(e.RowIndex).Cells(0).Value
        For Each prod In productos.TraeProductoPorId(idProducto)
            producto.IdProducto1 = prod.IdProducto1
            producto.NombreProducto1 = prod.NombreProducto1
            producto.IdRef_UnidadDeMedida1 = prod.IdRef_UnidadDeMedida1
            producto.Medida1 = prod.Medida1
            producto.CodigoBarras1 = prod.CodigoBarras1
            prod.StockMinimo1 = prod.StockMinimo1
            producto.IdRef_TipoEnvase1 = prod.IdRef_TipoEnvase1
            producto.IdRef_Marca1 = prod.IdRef_Marca1
            producto.IdPrecioDeVenta1 = prod.IdPrecioDeVenta1
        Next
        'detalle.Add(producto)
        Dim abreForm As New Funciones()
        abreForm.AbrirFormEnPanel(New frmNuevaCompra(detalle, detalleSinCodigo, producto, idCondicionDeCompra, idProveedor))
    End Sub

End Class