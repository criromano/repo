<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNuevaCompra
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer

	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar usando el Diseñador de Windows Forms.  
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblIngresaCompra = New System.Windows.Forms.Label()
        Me.MenuTitulos = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_aviso_caja = New System.Windows.Forms.Label()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.lblCambiarPrecioDeVenta = New System.Windows.Forms.Label()
        Me.lblPrecioDeVenta = New System.Windows.Forms.Label()
        Me.txtTotalVenta = New System.Windows.Forms.TextBox()
        Me.cboCondicionDeCompra = New System.Windows.Forms.ComboBox()
        Me.lblTipodeCompra = New System.Windows.Forms.Label()
        Me.lblTotalDeCompra = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.dgvCompras = New System.Windows.Forms.DataGridView()
        Me.idProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.envase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.medida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codBarras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preciocosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioTot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaDeVenta = New System.Windows.Forms.DateTimePicker()
        Me.lblCodigoDeBarras = New System.Windows.Forms.Label()
        Me.txtCodigoDeBarras = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.cboProducto = New System.Windows.Forms.ComboBox()
        Me.txtPrecioDeVenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCargaManual = New System.Windows.Forms.Button()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.btnConfirmarCompra = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIngresaCompra
        '
        Me.lblIngresaCompra.AutoSize = True
        Me.lblIngresaCompra.BackColor = System.Drawing.SystemColors.Control
        Me.lblIngresaCompra.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Italic)
        Me.lblIngresaCompra.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblIngresaCompra.Location = New System.Drawing.Point(17, 3)
        Me.lblIngresaCompra.Name = "lblIngresaCompra"
        Me.lblIngresaCompra.Size = New System.Drawing.Size(176, 47)
        Me.lblIngresaCompra.TabIndex = 1
        Me.lblIngresaCompra.Text = "COMPRAS"
        '
        'MenuTitulos
        '
        Me.MenuTitulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuTitulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuTitulos.ForeColor = System.Drawing.Color.Transparent
        Me.MenuTitulos.Location = New System.Drawing.Point(0, 0)
        Me.MenuTitulos.Name = "MenuTitulos"
        Me.MenuTitulos.Size = New System.Drawing.Size(1100, 33)
        Me.MenuTitulos.TabIndex = 29
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 622)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 28)
        Me.Panel1.TabIndex = 30
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.lbl_aviso_caja)
        Me.Panel3.Controls.Add(Me.cboProveedor)
        Me.Panel3.Controls.Add(Me.lblProveedor)
        Me.Panel3.Controls.Add(Me.btnCargaManual)
        Me.Panel3.Controls.Add(Me.lblCambiarPrecioDeVenta)
        Me.Panel3.Controls.Add(Me.lblPrecioDeVenta)
        Me.Panel3.Controls.Add(Me.txtTotalVenta)
        Me.Panel3.Controls.Add(Me.btnBuscarProducto)
        Me.Panel3.Controls.Add(Me.cboCondicionDeCompra)
        Me.Panel3.Controls.Add(Me.lblTipodeCompra)
        Me.Panel3.Controls.Add(Me.lblTotalDeCompra)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.btnConfirmarCompra)
        Me.Panel3.Controls.Add(Me.btnAgregar)
        Me.Panel3.Controls.Add(Me.txtCantidad)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txtPrecio)
        Me.Panel3.Controls.Add(Me.lblPrecio)
        Me.Panel3.Controls.Add(Me.lblDescripcion)
        Me.Panel3.Controls.Add(Me.dgvCompras)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.dtpFechaDeVenta)
        Me.Panel3.Controls.Add(Me.lblCodigoDeBarras)
        Me.Panel3.Controls.Add(Me.txtCodigoDeBarras)
        Me.Panel3.Controls.Add(Me.lblIngresaCompra)
        Me.Panel3.Controls.Add(Me.txtDescripcion)
        Me.Panel3.Controls.Add(Me.cboProducto)
        Me.Panel3.Controls.Add(Me.txtPrecioDeVenta)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(93, 56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1004, 546)
        Me.Panel3.TabIndex = 31
        '
        'lbl_aviso_caja
        '
        Me.lbl_aviso_caja.AutoSize = True
        Me.lbl_aviso_caja.BackColor = System.Drawing.Color.Red
        Me.lbl_aviso_caja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_aviso_caja.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_aviso_caja.ForeColor = System.Drawing.Color.White
        Me.lbl_aviso_caja.Location = New System.Drawing.Point(302, 3)
        Me.lbl_aviso_caja.Name = "lbl_aviso_caja"
        Me.lbl_aviso_caja.Padding = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.lbl_aviso_caja.Size = New System.Drawing.Size(452, 37)
        Me.lbl_aviso_caja.TabIndex = 60
        Me.lbl_aviso_caja.Text = "  AVISO:    LA CAJA NO HA SIDO INICIADA EL DIA DE HOY   "
        Me.lbl_aviso_caja.Visible = False
        '
        'cboProveedor
        '
        Me.cboProveedor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Location = New System.Drawing.Point(123, 96)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(256, 29)
        Me.cboProveedor.TabIndex = 2
        Me.cboProveedor.Text = "Seleccionar"
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.Location = New System.Drawing.Point(23, 99)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(94, 21)
        Me.lblProveedor.TabIndex = 58
        Me.lblProveedor.Text = "Proveedor:"
        '
        'lblCambiarPrecioDeVenta
        '
        Me.lblCambiarPrecioDeVenta.AutoSize = True
        Me.lblCambiarPrecioDeVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCambiarPrecioDeVenta.Enabled = False
        Me.lblCambiarPrecioDeVenta.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCambiarPrecioDeVenta.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblCambiarPrecioDeVenta.Location = New System.Drawing.Point(594, 255)
        Me.lblCambiarPrecioDeVenta.Name = "lblCambiarPrecioDeVenta"
        Me.lblCambiarPrecioDeVenta.Size = New System.Drawing.Size(58, 15)
        Me.lblCambiarPrecioDeVenta.TabIndex = 54
        Me.lblCambiarPrecioDeVenta.Text = "Modificar"
        Me.lblCambiarPrecioDeVenta.Visible = False
        '
        'lblPrecioDeVenta
        '
        Me.lblPrecioDeVenta.AutoSize = True
        Me.lblPrecioDeVenta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrecioDeVenta.Location = New System.Drawing.Point(576, 199)
        Me.lblPrecioDeVenta.Name = "lblPrecioDeVenta"
        Me.lblPrecioDeVenta.Size = New System.Drawing.Size(90, 21)
        Me.lblPrecioDeVenta.TabIndex = 51
        Me.lblPrecioDeVenta.Text = "Precio vta:"
        Me.lblPrecioDeVenta.Visible = False
        '
        'txtTotalVenta
        '
        Me.txtTotalVenta.Enabled = False
        Me.txtTotalVenta.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTotalVenta.Location = New System.Drawing.Point(386, 483)
        Me.txtTotalVenta.Name = "txtTotalVenta"
        Me.txtTotalVenta.Size = New System.Drawing.Size(152, 43)
        Me.txtTotalVenta.TabIndex = 45
        Me.txtTotalVenta.Visible = False
        '
        'cboCondicionDeCompra
        '
        Me.cboCondicionDeCompra.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCondicionDeCompra.FormattingEnabled = True
        Me.cboCondicionDeCompra.Location = New System.Drawing.Point(206, 59)
        Me.cboCondicionDeCompra.Name = "cboCondicionDeCompra"
        Me.cboCondicionDeCompra.Size = New System.Drawing.Size(173, 29)
        Me.cboCondicionDeCompra.TabIndex = 1
        '
        'lblTipodeCompra
        '
        Me.lblTipodeCompra.AutoSize = True
        Me.lblTipodeCompra.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTipodeCompra.Location = New System.Drawing.Point(23, 62)
        Me.lblTipodeCompra.Name = "lblTipodeCompra"
        Me.lblTipodeCompra.Size = New System.Drawing.Size(177, 21)
        Me.lblTipodeCompra.TabIndex = 48
        Me.lblTipodeCompra.Text = "Condición de compra:"
        '
        'lblTotalDeCompra
        '
        Me.lblTotalDeCompra.AutoSize = True
        Me.lblTotalDeCompra.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDeCompra.Location = New System.Drawing.Point(20, 486)
        Me.lblTotalDeCompra.Name = "lblTotalDeCompra"
        Me.lblTotalDeCompra.Size = New System.Drawing.Size(347, 37)
        Me.lblTotalDeCompra.TabIndex = 46
        Me.lblTotalDeCompra.Text = "Importe total de Compra:"
        Me.lblTotalDeCompra.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(363, 486)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 37)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "$"
        Me.Label6.Visible = False
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(27, 159)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(119, 29)
        Me.txtCantidad.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(23, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 21)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Cantidad:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(452, 223)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(84, 29)
        Me.txtPrecio.TabIndex = 8
        Me.txtPrecio.Visible = False
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrecio.Location = New System.Drawing.Point(448, 198)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(62, 21)
        Me.lblPrecio.TabIndex = 38
        Me.lblPrecio.Text = "Precio:"
        Me.lblPrecio.Visible = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcion.Location = New System.Drawing.Point(21, 198)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(84, 21)
        Me.lblDescripcion.TabIndex = 36
        Me.lblDescripcion.Text = "Producto:"
        Me.lblDescripcion.Visible = False
        '
        'dgvCompras
        '
        Me.dgvCompras.AllowUserToAddRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.dgvCompras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvCompras.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCompras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProd, Me.cantidad, Me.envase, Me.producto, Me.medida, Me.unMedida, Me.marca, Me.codBarras, Me.preciocosto, Me.precioTot, Me.Check})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCompras.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCompras.EnableHeadersVisualStyles = False
        Me.dgvCompras.Location = New System.Drawing.Point(25, 273)
        Me.dgvCompras.MultiSelect = False
        Me.dgvCompras.Name = "dgvCompras"
        Me.dgvCompras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCompras.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCompras.RowHeadersVisible = False
        Me.dgvCompras.RowHeadersWidth = 30
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCompras.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCompras.Size = New System.Drawing.Size(968, 199)
        Me.dgvCompras.TabIndex = 35
        Me.dgvCompras.Visible = False
        '
        'idProd
        '
        Me.idProd.HeaderText = "ID prod."
        Me.idProd.Name = "idProd"
        Me.idProd.ReadOnly = True
        Me.idProd.Width = 52
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cant."
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 40
        '
        'envase
        '
        Me.envase.HeaderText = "Envase"
        Me.envase.Name = "envase"
        Me.envase.ReadOnly = True
        Me.envase.Width = 70
        '
        'producto
        '
        Me.producto.FillWeight = 408.3333!
        Me.producto.HeaderText = "Producto"
        Me.producto.Name = "producto"
        Me.producto.ReadOnly = True
        Me.producto.Width = 240
        '
        'medida
        '
        Me.medida.FillWeight = 48.61111!
        Me.medida.HeaderText = "Medida"
        Me.medida.Name = "medida"
        Me.medida.ReadOnly = True
        Me.medida.Width = 50
        '
        'unMedida
        '
        Me.unMedida.FillWeight = 48.61111!
        Me.unMedida.HeaderText = "Un. medida"
        Me.unMedida.Name = "unMedida"
        Me.unMedida.ReadOnly = True
        Me.unMedida.Width = 90
        '
        'marca
        '
        Me.marca.FillWeight = 48.61111!
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        Me.marca.Width = 120
        '
        'codBarras
        '
        Me.codBarras.FillWeight = 48.61111!
        Me.codBarras.HeaderText = "Cod. barras"
        Me.codBarras.Name = "codBarras"
        Me.codBarras.ReadOnly = True
        '
        'preciocosto
        '
        Me.preciocosto.FillWeight = 48.61111!
        Me.preciocosto.HeaderText = "Precio un."
        Me.preciocosto.Name = "preciocosto"
        Me.preciocosto.ReadOnly = True
        Me.preciocosto.Width = 80
        '
        'precioTot
        '
        Me.precioTot.FillWeight = 48.61111!
        Me.precioTot.HeaderText = "Precio tot."
        Me.precioTot.Name = "precioTot"
        Me.precioTot.ReadOnly = True
        Me.precioTot.Width = 80
        '
        'Check
        '
        Me.Check.HeaderText = "Elim."
        Me.Check.Name = "Check"
        Me.Check.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Check.Width = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(616, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 21)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Fecha:"
        '
        'dtpFechaDeVenta
        '
        Me.dtpFechaDeVenta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaDeVenta.Location = New System.Drawing.Point(680, 56)
        Me.dtpFechaDeVenta.Name = "dtpFechaDeVenta"
        Me.dtpFechaDeVenta.Size = New System.Drawing.Size(296, 29)
        Me.dtpFechaDeVenta.TabIndex = 33
        '
        'lblCodigoDeBarras
        '
        Me.lblCodigoDeBarras.AutoSize = True
        Me.lblCodigoDeBarras.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCodigoDeBarras.Location = New System.Drawing.Point(177, 135)
        Me.lblCodigoDeBarras.Name = "lblCodigoDeBarras"
        Me.lblCodigoDeBarras.Size = New System.Drawing.Size(143, 21)
        Me.lblCodigoDeBarras.TabIndex = 30
        Me.lblCodigoDeBarras.Text = "Codigo de Barras:"
        '
        'txtCodigoDeBarras
        '
        Me.txtCodigoDeBarras.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoDeBarras.Location = New System.Drawing.Point(181, 159)
        Me.txtCodigoDeBarras.Name = "txtCodigoDeBarras"
        Me.txtCodigoDeBarras.Size = New System.Drawing.Size(333, 29)
        Me.txtCodigoDeBarras.TabIndex = 4
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(25, 223)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(383, 29)
        Me.txtDescripcion.TabIndex = 7
        Me.txtDescripcion.Visible = False
        '
        'cboProducto
        '
        Me.cboProducto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProducto.FormattingEnabled = True
        Me.cboProducto.Location = New System.Drawing.Point(25, 223)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(383, 29)
        Me.cboProducto.TabIndex = 55
        Me.cboProducto.Text = "Seleccionar"
        Me.cboProducto.Visible = False
        '
        'txtPrecioDeVenta
        '
        Me.txtPrecioDeVenta.Enabled = False
        Me.txtPrecioDeVenta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioDeVenta.Location = New System.Drawing.Point(580, 223)
        Me.txtPrecioDeVenta.Name = "txtPrecioDeVenta"
        Me.txtPrecioDeVenta.Size = New System.Drawing.Size(84, 29)
        Me.txtPrecioDeVenta.TabIndex = 9
        Me.txtPrecioDeVenta.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(437, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 21)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "$"
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(565, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 21)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "$"
        Me.Label3.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Image = Global.lacabania.My.Resources.Resources.money_16px1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(386, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(214, 29)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Cargar pago a proveedor"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnCargaManual
        '
        Me.btnCargaManual.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnCargaManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargaManual.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargaManual.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCargaManual.Image = Global.lacabania.My.Resources.Resources.keyboard_32px
        Me.btnCargaManual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargaManual.Location = New System.Drawing.Point(579, 156)
        Me.btnCargaManual.Name = "btnCargaManual"
        Me.btnCargaManual.Size = New System.Drawing.Size(175, 32)
        Me.btnCargaManual.TabIndex = 6
        Me.btnCargaManual.Text = "CARGA MANUAL"
        Me.btnCargaManual.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCargaManual.UseVisualStyleBackColor = False
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.BackColor = System.Drawing.Color.Lime
        Me.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarProducto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarProducto.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBuscarProducto.Image = Global.lacabania.My.Resources.Resources.find_24px
        Me.btnBuscarProducto.Location = New System.Drawing.Point(520, 156)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(39, 32)
        Me.btnBuscarProducto.TabIndex = 5
        Me.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarProducto.UseVisualStyleBackColor = False
        '
        'btnConfirmarCompra
        '
        Me.btnConfirmarCompra.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnConfirmarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmarCompra.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.btnConfirmarCompra.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnConfirmarCompra.Image = Global.lacabania.My.Resources.Resources.save_32px
        Me.btnConfirmarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmarCompra.Location = New System.Drawing.Point(711, 478)
        Me.btnConfirmarCompra.Name = "btnConfirmarCompra"
        Me.btnConfirmarCompra.Size = New System.Drawing.Size(265, 60)
        Me.btnConfirmarCompra.TabIndex = 11
        Me.btnConfirmarCompra.Text = "CONFIRMAR COMPRA"
        Me.btnConfirmarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirmarCompra.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAgregar.Image = Global.lacabania.My.Resources.Resources.add_32px
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(697, 216)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(115, 40)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = False
        Me.btnAgregar.Visible = False
        '
        'frmNuevaCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1100, 650)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuTitulos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNuevaCompra"
        Me.Text = "Nueva Compra"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblIngresaCompra As Label
	Friend WithEvents MenuTitulos As Panel
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Panel3 As Panel
	Friend WithEvents lblCodigoDeBarras As Label
	Friend WithEvents txtCodigoDeBarras As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents dtpFechaDeVenta As DateTimePicker
	Friend WithEvents dgvCompras As DataGridView
	Friend WithEvents txtCantidad As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents txtPrecio As TextBox
	Friend WithEvents lblPrecio As Label
	Friend WithEvents lblDescripcion As Label
	Friend WithEvents Label4 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnConfirmarCompra As Button
    Friend WithEvents lblTotalDeCompra As Label
    Friend WithEvents txtTotalVenta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboCondicionDeCompra As ComboBox
    Friend WithEvents lblTipodeCompra As Label
    Friend WithEvents btnBuscarProducto As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrecioDeVenta As TextBox
    Friend WithEvents lblPrecioDeVenta As Label
    Friend WithEvents lblCambiarPrecioDeVenta As Label
    Friend WithEvents cboProducto As ComboBox
    Friend WithEvents btnCargaManual As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblProveedor As Label
    Friend WithEvents cboProveedor As ComboBox
    Friend WithEvents idProd As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents envase As DataGridViewTextBoxColumn
    Friend WithEvents producto As DataGridViewTextBoxColumn
    Friend WithEvents medida As DataGridViewTextBoxColumn
    Friend WithEvents unMedida As DataGridViewTextBoxColumn
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents codBarras As DataGridViewTextBoxColumn
    Friend WithEvents preciocosto As DataGridViewTextBoxColumn
    Friend WithEvents precioTot As DataGridViewTextBoxColumn
    Friend WithEvents Check As DataGridViewCheckBoxColumn
    Friend WithEvents lbl_aviso_caja As Label
    Friend WithEvents Button1 As Button
End Class
