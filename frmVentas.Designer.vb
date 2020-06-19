<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVentas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_aviso_caja = New System.Windows.Forms.Label()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.cboProducto = New System.Windows.Forms.ComboBox()
        Me.btnCargaManual = New System.Windows.Forms.Button()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.idProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.envase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.medida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codBarras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioUn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioTot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaDeVenta = New System.Windows.Forms.DateTimePicker()
        Me.cboCondicionDeVenta = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblTipodeVenta = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.btnConfirmarVenta = New System.Windows.Forms.Button()
        Me.lblCodigoDeBarras = New System.Windows.Forms.Label()
        Me.lblTotalDeVenta = New System.Windows.Forms.Label()
        Me.txtTotalVenta = New System.Windows.Forms.TextBox()
        Me.txtCodigoDeBarras = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuTitulos = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Italic)
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(17, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VENTAS"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_aviso_caja)
        Me.Panel1.Controls.Add(Me.cboCliente)
        Me.Panel1.Controls.Add(Me.lblCliente)
        Me.Panel1.Controls.Add(Me.cboProducto)
        Me.Panel1.Controls.Add(Me.btnCargaManual)
        Me.Panel1.Controls.Add(Me.dgvVentas)
        Me.Panel1.Controls.Add(Me.btnBuscarProducto)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtpFechaDeVenta)
        Me.Panel1.Controls.Add(Me.cboCondicionDeVenta)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.lblTipodeVenta)
        Me.Panel1.Controls.Add(Me.txtCantidad)
        Me.Panel1.Controls.Add(Me.lblCantidad)
        Me.Panel1.Controls.Add(Me.txtPrecio)
        Me.Panel1.Controls.Add(Me.lblPrecio)
        Me.Panel1.Controls.Add(Me.lblDescripcion)
        Me.Panel1.Controls.Add(Me.btnConfirmarVenta)
        Me.Panel1.Controls.Add(Me.lblCodigoDeBarras)
        Me.Panel1.Controls.Add(Me.lblTotalDeVenta)
        Me.Panel1.Controls.Add(Me.txtTotalVenta)
        Me.Panel1.Controls.Add(Me.txtCodigoDeBarras)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(93, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1004, 546)
        Me.Panel1.TabIndex = 3
        '
        'lbl_aviso_caja
        '
        Me.lbl_aviso_caja.AutoSize = True
        Me.lbl_aviso_caja.BackColor = System.Drawing.Color.Red
        Me.lbl_aviso_caja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_aviso_caja.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_aviso_caja.ForeColor = System.Drawing.Color.White
        Me.lbl_aviso_caja.Location = New System.Drawing.Point(318, 3)
        Me.lbl_aviso_caja.Name = "lbl_aviso_caja"
        Me.lbl_aviso_caja.Padding = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.lbl_aviso_caja.Size = New System.Drawing.Size(452, 37)
        Me.lbl_aviso_caja.TabIndex = 28
        Me.lbl_aviso_caja.Text = "  AVISO:    LA CAJA NO HA SIDO INICIADA EL DIA DE HOY   "
        Me.lbl_aviso_caja.Visible = False
        '
        'cboCliente
        '
        Me.cboCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(97, 96)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(267, 29)
        Me.cboCliente.TabIndex = 2
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCliente.Location = New System.Drawing.Point(23, 99)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(68, 21)
        Me.lblCliente.TabIndex = 37
        Me.lblCliente.Text = "Cliente:"
        '
        'cboProducto
        '
        Me.cboProducto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProducto.FormattingEnabled = True
        Me.cboProducto.Location = New System.Drawing.Point(27, 222)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(265, 29)
        Me.cboProducto.TabIndex = 7
        Me.cboProducto.Text = "Seleccionar"
        Me.cboProducto.Visible = False
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
        'dgvVentas
        '
        Me.dgvVentas.AllowUserToAddRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.dgvVentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvVentas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProd, Me.cantidad, Me.envase, Me.producto, Me.medida, Me.unMedida, Me.marca, Me.codBarras, Me.precioUn, Me.precioTot, Me.Check})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVentas.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvVentas.EnableHeadersVisualStyles = False
        Me.dgvVentas.Location = New System.Drawing.Point(25, 257)
        Me.dgvVentas.MultiSelect = False
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvVentas.RowHeadersVisible = False
        Me.dgvVentas.RowHeadersWidth = 30
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgvVentas.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentas.Size = New System.Drawing.Size(968, 211)
        Me.dgvVentas.TabIndex = 31
        Me.dgvVentas.Visible = False
        '
        'idProd
        '
        Me.idProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.idProd.HeaderText = "ID prod."
        Me.idProd.Name = "idProd"
        Me.idProd.ReadOnly = True
        Me.idProd.Width = 52
        '
        'cantidad
        '
        Me.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.cantidad.HeaderText = "Cant."
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 40
        '
        'envase
        '
        Me.envase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.envase.HeaderText = "Envase"
        Me.envase.Name = "envase"
        Me.envase.ReadOnly = True
        Me.envase.Width = 70
        '
        'producto
        '
        Me.producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.producto.FillWeight = 408.3333!
        Me.producto.HeaderText = "Producto"
        Me.producto.Name = "producto"
        Me.producto.ReadOnly = True
        Me.producto.Width = 240
        '
        'medida
        '
        Me.medida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.medida.FillWeight = 48.61111!
        Me.medida.HeaderText = "Medida"
        Me.medida.Name = "medida"
        Me.medida.ReadOnly = True
        Me.medida.Width = 50
        '
        'unMedida
        '
        Me.unMedida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.unMedida.FillWeight = 48.61111!
        Me.unMedida.HeaderText = "Un. medida"
        Me.unMedida.Name = "unMedida"
        Me.unMedida.ReadOnly = True
        Me.unMedida.Width = 90
        '
        'marca
        '
        Me.marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.marca.FillWeight = 48.61111!
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        Me.marca.Width = 120
        '
        'codBarras
        '
        Me.codBarras.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.codBarras.FillWeight = 48.61111!
        Me.codBarras.HeaderText = "Cod. barras"
        Me.codBarras.Name = "codBarras"
        Me.codBarras.ReadOnly = True
        '
        'precioUn
        '
        Me.precioUn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.precioUn.FillWeight = 48.61111!
        Me.precioUn.HeaderText = "Precio un."
        Me.precioUn.Name = "precioUn"
        Me.precioUn.ReadOnly = True
        Me.precioUn.Width = 80
        '
        'precioTot
        '
        Me.precioTot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
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
        Me.Check.Width = 30
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(617, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 21)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Fecha:"
        '
        'dtpFechaDeVenta
        '
        Me.dtpFechaDeVenta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaDeVenta.Location = New System.Drawing.Point(681, 59)
        Me.dtpFechaDeVenta.Name = "dtpFechaDeVenta"
        Me.dtpFechaDeVenta.Size = New System.Drawing.Size(296, 29)
        Me.dtpFechaDeVenta.TabIndex = 26
        '
        'cboCondicionDeVenta
        '
        Me.cboCondicionDeVenta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCondicionDeVenta.FormattingEnabled = True
        Me.cboCondicionDeVenta.Location = New System.Drawing.Point(191, 59)
        Me.cboCondicionDeVenta.Name = "cboCondicionDeVenta"
        Me.cboCondicionDeVenta.Size = New System.Drawing.Size(173, 29)
        Me.cboCondicionDeVenta.TabIndex = 1
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAgregar.Image = Global.lacabania.My.Resources.Resources.add_32px
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(579, 215)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(115, 40)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = False
        Me.btnAgregar.Visible = False
        '
        'lblTipodeVenta
        '
        Me.lblTipodeVenta.AutoSize = True
        Me.lblTipodeVenta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTipodeVenta.Location = New System.Drawing.Point(23, 62)
        Me.lblTipodeVenta.Name = "lblTipodeVenta"
        Me.lblTipodeVenta.Size = New System.Drawing.Size(162, 21)
        Me.lblTipodeVenta.TabIndex = 20
        Me.lblTipodeVenta.Text = "Condición de venta:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(27, 159)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(119, 29)
        Me.txtCantidad.TabIndex = 3
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.Location = New System.Drawing.Point(23, 135)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(83, 21)
        Me.lblCantidad.TabIndex = 16
        Me.lblCantidad.Text = "Cantidad:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(333, 222)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(200, 29)
        Me.txtPrecio.TabIndex = 8
        Me.txtPrecio.Visible = False
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrecio.Location = New System.Drawing.Point(329, 197)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(62, 21)
        Me.lblPrecio.TabIndex = 14
        Me.lblPrecio.Text = "Precio:"
        Me.lblPrecio.Visible = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcion.Location = New System.Drawing.Point(23, 197)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(84, 21)
        Me.lblDescripcion.TabIndex = 12
        Me.lblDescripcion.Text = "Producto:"
        Me.lblDescripcion.Visible = False
        '
        'btnConfirmarVenta
        '
        Me.btnConfirmarVenta.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnConfirmarVenta.Enabled = False
        Me.btnConfirmarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmarVenta.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.btnConfirmarVenta.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnConfirmarVenta.Image = Global.lacabania.My.Resources.Resources.save_32px
        Me.btnConfirmarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmarVenta.Location = New System.Drawing.Point(712, 478)
        Me.btnConfirmarVenta.Name = "btnConfirmarVenta"
        Me.btnConfirmarVenta.Size = New System.Drawing.Size(265, 60)
        Me.btnConfirmarVenta.TabIndex = 10
        Me.btnConfirmarVenta.Text = "CONFIRMAR VENTA"
        Me.btnConfirmarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirmarVenta.UseVisualStyleBackColor = False
        '
        'lblCodigoDeBarras
        '
        Me.lblCodigoDeBarras.AutoSize = True
        Me.lblCodigoDeBarras.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCodigoDeBarras.Location = New System.Drawing.Point(177, 135)
        Me.lblCodigoDeBarras.Name = "lblCodigoDeBarras"
        Me.lblCodigoDeBarras.Size = New System.Drawing.Size(143, 21)
        Me.lblCodigoDeBarras.TabIndex = 8
        Me.lblCodigoDeBarras.Text = "Codigo de Barras:"
        '
        'lblTotalDeVenta
        '
        Me.lblTotalDeVenta.AutoSize = True
        Me.lblTotalDeVenta.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDeVenta.Location = New System.Drawing.Point(20, 486)
        Me.lblTotalDeVenta.Name = "lblTotalDeVenta"
        Me.lblTotalDeVenta.Size = New System.Drawing.Size(318, 37)
        Me.lblTotalDeVenta.TabIndex = 6
        Me.lblTotalDeVenta.Text = "Importe total de Venta:"
        Me.lblTotalDeVenta.Visible = False
        '
        'txtTotalVenta
        '
        Me.txtTotalVenta.Enabled = False
        Me.txtTotalVenta.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTotalVenta.Location = New System.Drawing.Point(371, 483)
        Me.txtTotalVenta.Name = "txtTotalVenta"
        Me.txtTotalVenta.Size = New System.Drawing.Size(152, 43)
        Me.txtTotalVenta.TabIndex = 5
        Me.txtTotalVenta.Visible = False
        '
        'txtCodigoDeBarras
        '
        Me.txtCodigoDeBarras.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoDeBarras.Location = New System.Drawing.Point(181, 159)
        Me.txtCodigoDeBarras.Name = "txtCodigoDeBarras"
        Me.txtCodigoDeBarras.Size = New System.Drawing.Size(333, 29)
        Me.txtCodigoDeBarras.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(318, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 21)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "$"
        Me.Label4.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(345, 486)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 37)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "$"
        Me.Label6.Visible = False
        '
        'MenuTitulos
        '
        Me.MenuTitulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuTitulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuTitulos.ForeColor = System.Drawing.Color.Transparent
        Me.MenuTitulos.Location = New System.Drawing.Point(0, 0)
        Me.MenuTitulos.Name = "MenuTitulos"
        Me.MenuTitulos.Size = New System.Drawing.Size(1100, 50)
        Me.MenuTitulos.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Khaki
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 608)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1100, 42)
        Me.Panel2.TabIndex = 20
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1100, 650)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuTitulos)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVentas"
        Me.Text = "frmVentas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuTitulos As Panel
    Friend WithEvents txtCodigoDeBarras As TextBox
    Friend WithEvents lblTotalDeVenta As Label
    Friend WithEvents txtTotalVenta As TextBox
    Friend WithEvents lblCodigoDeBarras As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnConfirmarVenta As Button
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblTipodeVenta As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dtpFechaDeVenta As DateTimePicker
    Friend WithEvents cboCondicionDeVenta As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBuscarProducto As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCargaManual As Button
    Friend WithEvents cboProducto As ComboBox
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents cboCliente As ComboBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents idProd As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents envase As DataGridViewTextBoxColumn
    Friend WithEvents producto As DataGridViewTextBoxColumn
    Friend WithEvents medida As DataGridViewTextBoxColumn
    Friend WithEvents unMedida As DataGridViewTextBoxColumn
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents codBarras As DataGridViewTextBoxColumn
    Friend WithEvents precioUn As DataGridViewTextBoxColumn
    Friend WithEvents precioTot As DataGridViewTextBoxColumn
    Friend WithEvents Check As DataGridViewCheckBoxColumn
    Friend WithEvents lbl_aviso_caja As Label
End Class
