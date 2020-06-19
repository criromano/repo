Imports System.Runtime.InteropServices
Imports lacabania.frmProductos

Public Class MenuPrincipal
    Dim abrirNuevoForm As New Funciones
    Dim ds As New DataSet
    Dim funcion As New Funciones

    'DLL IMPORTDAS
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    'DLL IMPORTDAS
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    'CONFIGURA TAMAÑOS DEL MENU VERTICAL
    Private Sub btnSlide_Click(sender As Object, e As EventArgs) Handles btnSlide.Click
        If MenuVertical.Width = 220 Then
            tmOcultarMenu.Enabled = True
        ElseIf MenuVertical.Width = 80 Then
            tmMostrarMenu.Enabled = True
        End If
    End Sub
    'CREAMOS PARA ABRIR EL MENU HIJO
    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then ' si el panel contiene 
            Me.PanelContenedor.Controls.RemoveAt(0) ' remueve lo que tiene
        End If
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        'fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None ' le saca el borde
        fh.Dock = DockStyle.Fill ' acoplamos a todo el panel contenedor
        Me.PanelContenedor.Controls.Add(fh) ' agregamos los paneles al form contenedor
        Me.PanelContenedor.Tag = fh 'el panel contenedor tendra los datos del formulario
        fh.Show() 'Mostramos el formulario
    End Sub

    'ABRE FORMULARIO PRODUCTOS NUEVOS
    Private Sub btnProductosNuevos_Click(sender As Object, e As EventArgs) Handles btnProductosNuevos.Click
        frmVentas.Close()
        frmProductos.Close()
        abrirNuevoForm.AbrirFormEnPanel(New frmPadronProductos)
        tmOcultarMenu.Enabled = True
    End Sub

    'PARTE DE LAIMPORTACION DE DLL
    Private Sub MenuTitulos_MouseMove(sender As Object, e As MouseEventArgs) Handles MenuTitulos.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    'TIMER QUE OCULTA EL MENU
    Private Sub tmOcultarMenu_Tick(sender As Object, e As EventArgs) Handles tmOcultarMenu.Tick
        If MenuVertical.Width <= 80 Then
            Me.tmOcultarMenu.Enabled = False
        Else
            MenuVertical.Width = MenuVertical.Width - 20
        End If
        btnProductosNuevos.Text = ""
        btnVentas.Text = ""
        btnCaja.Text = ""
        btnProveedor.Text = ""
        btnIngresarNuevaCompra.Text = ""
        btnCuentaCorriente.Text = ""
        btnAgregarDetalles.Text = ""
        btnInformes.Text = ""
    End Sub
    'TIMER QUE MUESTRA EL MENU
    Private Sub tmMostrarMenu_Tick(sender As Object, e As EventArgs) Handles tmMostrarMenu.Tick
        If MenuVertical.Width >= 220 Then
            Me.tmMostrarMenu.Enabled = False
        Else
            MenuVertical.Width = MenuVertical.Width + 20
        End If
        btnProductosNuevos.Text = "Productos"
        btnVentas.Text = "Ventas"
        btnCaja.Text = "Caja"
        btnProveedor.Text = "Proveedores" & vbCrLf & "y Clientes"
        btnIngresarNuevaCompra.Text = "Compras"
        btnCuentaCorriente.Text = "Cuenta" & vbCrLf & "corriente"
        btnAgregarDetalles.Text = "Agregar" & vbCrLf & "detalles"
        btnInformes.Text = "Informes"
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        frmProductos.Close()
        tmOcultarMenu.Enabled = True
        abrirNuevoForm.AbrirFormEnPanel(New frmVentas)
    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        tmOcultarMenu.Enabled = True
		abrirNuevoForm.AbrirFormEnPanel(New frmPadronClienteProveedor)
	End Sub


	Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

	Private Sub btnIngresarNuevaCompra_Click(sender As Object, e As EventArgs) Handles btnIngresarNuevaCompra.Click
        Me.tmOcultarMenu.Enabled = True
        abrirNuevoForm.AbrirFormEnPanel(New frmNuevaCompra) 'Abrimos formulario Compra
    End Sub

	Private Sub MenuTitulos_Paint(sender As Object, e As PaintEventArgs) Handles MenuTitulos.Paint
		lblFechaHora.Text = "VINERIA LA CABAÑA" & "       " & Format(Now, "dd/MM/yyyy") 'asiganamos nombre y fecha al menu de titulos
		lblFechaHora.TextAlign = HorizontalAlignment.Center ' centra el texto en el label
		lblFechaHora.Font = New Font("Open Sans", 16) ' establece tamaño y tipo de fuente

	End Sub

    Private Sub btnCaja_Click(sender As Object, e As EventArgs) Handles btnCaja.Click
        tmOcultarMenu.Enabled = True
        abrirNuevoForm.AbrirFormEnPanel(New frmCaja) 'Abrimos formulario caja
    End Sub

    'Private Sub btnNuevoProducto_Click(sender As Object, e As EventArgs)
    '	abrirNuevoForm.AbrirFormEnPanel(New frmProductos)
    '	tmOcultarMenu.Enabled = True
    'End Sub

    Private Sub btnAgregarDetalles_Click(sender As Object, e As EventArgs) Handles btnAgregarDetalles.Click
        tmOcultarMenu.Enabled = True
        abrirNuevoForm.AbrirFormEnPanel(New frmEspecificacionesDeProductos)
    End Sub

    Private Sub MenuVertical_Paint(sender As Object, e As PaintEventArgs) Handles MenuVertical.Paint

	End Sub

	Private Sub btnInformes_Click(sender As Object, e As EventArgs) Handles btnInformes.Click
		tmOcultarMenu.Enabled = True
		abrirNuevoForm.AbrirFormEnPanel(New frmInformes)
	End Sub

	Private Sub btnCuentaCorriente_Click(sender As Object, e As EventArgs) Handles btnCuentaCorriente.Click
		abrirNuevoForm.AbrirFormEnPanel(New frmCuentaCorriente)
		tmOcultarMenu.Enabled = True
	End Sub

    Private Sub PanelContenedor_Paint(sender As Object, e As PaintEventArgs) Handles PanelContenedor.Paint
        ds.Clear()
        funcion.VerificaMinimoDeStock().Fill(ds, "stock, producto, ref_tipoproducto, ref_marca, ref_tipoenvase, ref_unidaddemedida")
        If ds.Tables("stock, producto, ref_tipoproducto, ref_marca, ref_tipoenvase, ref_unidaddemedida").Rows.Count > 0 Then
            pbLogo.Visible = False
            lblAtencion.Visible = True
            dgvStockMinimo.Visible = True
            dgvStockMinimo.DataSource = ds.Tables("stock, producto, ref_tipoproducto, ref_marca, ref_tipoenvase, ref_unidaddemedida")
            TamanoColumna()
            dgvStockMinimo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        End If
    End Sub

    Private Sub TamanoColumna()
        Me.dgvStockMinimo.Columns("Stock").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvStockMinimo.Columns("Stock").FillWeight = 50
        Me.dgvStockMinimo.Columns("Stock").Width = 50
        Me.dgvStockMinimo.Columns("Stock").DisplayIndex = 0

        Me.dgvStockMinimo.Columns("Producto").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvStockMinimo.Columns("Producto").FillWeight = 200
        Me.dgvStockMinimo.Columns("Producto").Width = 200
        Me.dgvStockMinimo.Columns("Producto").DisplayIndex = 1

        Me.dgvStockMinimo.Columns("Tipo").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvStockMinimo.Columns("Tipo").FillWeight = 136
        Me.dgvStockMinimo.Columns("Tipo").Width = 136
        Me.dgvStockMinimo.Columns("Tipo").DisplayIndex = 2

        Me.dgvStockMinimo.Columns("Marca").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvStockMinimo.Columns("Marca").FillWeight = 200
        Me.dgvStockMinimo.Columns("Marca").Width = 200
        Me.dgvStockMinimo.Columns("Marca").DisplayIndex = 3

        Me.dgvStockMinimo.Columns("Envase").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvStockMinimo.Columns("Envase").FillWeight = 86
        Me.dgvStockMinimo.Columns("Envase").Width = 86
        Me.dgvStockMinimo.Columns("Envase").DisplayIndex = 4

        Me.dgvStockMinimo.Columns("Medida").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvStockMinimo.Columns("Medida").FillWeight = 70
        Me.dgvStockMinimo.Columns("Medida").Width = 70
        Me.dgvStockMinimo.Columns("Medida").DisplayIndex = 5

        Me.dgvStockMinimo.Columns("Un. Med.").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvStockMinimo.Columns("Un. Med.").FillWeight = 110
        Me.dgvStockMinimo.Columns("Un. Med.").Width = 110
        Me.dgvStockMinimo.Columns("Un. Med.").DisplayIndex = 6
    End Sub

    Private Sub dgvStockMinimo_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStockMinimo.CellMouseEnter
        If e.RowIndex > -1 Then
            dgvStockMinimo.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        'If Me.PanelContenedor.Controls.Count > 0 Then ' si el panel contiene 
        '    Me.Controls.RemoveAt(2) ' remueve lo que tiene
        '    Me.Show()
        'End If
    End Sub
End Class

