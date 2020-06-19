<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductos
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
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblRubro = New System.Windows.Forms.Label()
        Me.lblNombreProducto = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblUnidadMedida = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.cboRubro = New System.Windows.Forms.ComboBox()
        Me.cboMarca = New System.Windows.Forms.ComboBox()
        Me.cboUnidadMedida = New System.Windows.Forms.ComboBox()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblMuestraUnidMedida = New System.Windows.Forms.Label()
        Me.btnGuardarProductos = New System.Windows.Forms.Button()
        Me.txtNuevoPrecioVenta = New System.Windows.Forms.TextBox()
        Me.lblNuevoPreciodeVenta = New System.Windows.Forms.Label()
        Me.txtCodigoBarras = New System.Windows.Forms.TextBox()
        Me.lblCodigoBarras = New System.Windows.Forms.Label()
        Me.cboTipoEnvase = New System.Windows.Forms.ComboBox()
        Me.lblTipoEnvase = New System.Windows.Forms.Label()
        Me.txtStockMinimo = New System.Windows.Forms.TextBox()
        Me.lblStockMinimo = New System.Windows.Forms.Label()
        Me.txtMedida = New System.Windows.Forms.TextBox()
        Me.lblMedida = New System.Windows.Forms.Label()
        Me.lblNuevoProducto = New System.Windows.Forms.Label()
        Me.MenuTitulos = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblId
        '
        Me.lblId.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblId.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(877, 63)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(37, 21)
        Me.lblId.TabIndex = 1
        Me.lblId.Text = "Id:"
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblId.Visible = False
        '
        'lblRubro
        '
        Me.lblRubro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRubro.AutoSize = True
        Me.lblRubro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRubro.Location = New System.Drawing.Point(4, 243)
        Me.lblRubro.Name = "lblRubro"
        Me.lblRubro.Size = New System.Drawing.Size(60, 21)
        Me.lblRubro.TabIndex = 2
        Me.lblRubro.Text = "Rubro:"
        Me.lblRubro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombreProducto.AutoSize = True
        Me.lblNombreProducto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreProducto.Location = New System.Drawing.Point(273, 63)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(77, 21)
        Me.lblNombreProducto.TabIndex = 3
        Me.lblNombreProducto.Text = "Nombre:"
        Me.lblNombreProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMarca
        '
        Me.lblMarca.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.Location = New System.Drawing.Point(4, 303)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(61, 21)
        Me.lblMarca.TabIndex = 4
        Me.lblMarca.Text = "Marca:"
        Me.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUnidadMedida
        '
        Me.lblUnidadMedida.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUnidadMedida.AutoSize = True
        Me.lblUnidadMedida.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidadMedida.Location = New System.Drawing.Point(4, 183)
        Me.lblUnidadMedida.Name = "lblUnidadMedida"
        Me.lblUnidadMedida.Size = New System.Drawing.Size(155, 21)
        Me.lblUnidadMedida.TabIndex = 5
        Me.lblUnidadMedida.Text = "Unidad de medida:"
        Me.lblUnidadMedida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtId
        '
        Me.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(920, 60)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(45, 29)
        Me.txtId.TabIndex = 6
        Me.txtId.Visible = False
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreProducto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreProducto.Location = New System.Drawing.Point(356, 60)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(414, 29)
        Me.txtNombreProducto.TabIndex = 1
        '
        'cboRubro
        '
        Me.cboRubro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboRubro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboRubro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRubro.FormattingEnabled = True
        Me.cboRubro.Location = New System.Drawing.Point(70, 240)
        Me.cboRubro.Name = "cboRubro"
        Me.cboRubro.Size = New System.Drawing.Size(247, 29)
        Me.cboRubro.TabIndex = 6
        Me.cboRubro.Text = "Seleccionar"
        '
        'cboMarca
        '
        Me.cboMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMarca.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(70, 300)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(247, 29)
        Me.cboMarca.TabIndex = 8
        Me.cboMarca.Text = "Seleccionar"
        '
        'cboUnidadMedida
        '
        Me.cboUnidadMedida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboUnidadMedida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboUnidadMedida.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnidadMedida.FormattingEnabled = True
        Me.cboUnidadMedida.Location = New System.Drawing.Point(165, 180)
        Me.cboUnidadMedida.Name = "cboUnidadMedida"
        Me.cboUnidadMedida.Size = New System.Drawing.Size(247, 29)
        Me.cboUnidadMedida.TabIndex = 3
        Me.cboUnidadMedida.Text = "Seleccionar"
        '
        'cboTipo
        '
        Me.cboTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(532, 240)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(195, 29)
        Me.cboTipo.TabIndex = 7
        Me.cboTipo.Text = "Seleccionar"
        '
        'lblTipo
        '
        Me.lblTipo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(381, 243)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(145, 21)
        Me.lblTipo.TabIndex = 11
        Me.lblTipo.Text = "Tipo de producto:"
        Me.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.Controls.Add(Me.dtpFecha)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 608)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 42)
        Me.Panel1.TabIndex = 16
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(1009, 19)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha.TabIndex = 29
        Me.dtpFecha.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.txtStock)
        Me.Panel2.Controls.Add(Me.lblStock)
        Me.Panel2.Controls.Add(Me.btnCancelar)
        Me.Panel2.Controls.Add(Me.lblMuestraUnidMedida)
        Me.Panel2.Controls.Add(Me.btnGuardarProductos)
        Me.Panel2.Controls.Add(Me.txtNuevoPrecioVenta)
        Me.Panel2.Controls.Add(Me.lblNuevoPreciodeVenta)
        Me.Panel2.Controls.Add(Me.txtCodigoBarras)
        Me.Panel2.Controls.Add(Me.lblCodigoBarras)
        Me.Panel2.Controls.Add(Me.cboTipoEnvase)
        Me.Panel2.Controls.Add(Me.lblTipoEnvase)
        Me.Panel2.Controls.Add(Me.txtStockMinimo)
        Me.Panel2.Controls.Add(Me.lblStockMinimo)
        Me.Panel2.Controls.Add(Me.txtMedida)
        Me.Panel2.Controls.Add(Me.lblMedida)
        Me.Panel2.Controls.Add(Me.lblNuevoProducto)
        Me.Panel2.Controls.Add(Me.cboTipo)
        Me.Panel2.Controls.Add(Me.lblTipo)
        Me.Panel2.Controls.Add(Me.cboUnidadMedida)
        Me.Panel2.Controls.Add(Me.cboMarca)
        Me.Panel2.Controls.Add(Me.cboRubro)
        Me.Panel2.Controls.Add(Me.txtNombreProducto)
        Me.Panel2.Controls.Add(Me.txtId)
        Me.Panel2.Controls.Add(Me.lblUnidadMedida)
        Me.Panel2.Controls.Add(Me.lblMarca)
        Me.Panel2.Controls.Add(Me.lblNombreProducto)
        Me.Panel2.Controls.Add(Me.lblId)
        Me.Panel2.Controls.Add(Me.lblRubro)
        Me.Panel2.Location = New System.Drawing.Point(93, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1004, 546)
        Me.Panel2.TabIndex = 17
        '
        'txtStock
        '
        Me.txtStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(532, 363)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(69, 29)
        Me.txtStock.TabIndex = 11
        Me.txtStock.Text = "0"
        '
        'lblStock
        '
        Me.lblStock.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStock.AutoSize = True
        Me.lblStock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.Location = New System.Drawing.Point(454, 366)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(57, 21)
        Me.lblStock.TabIndex = 31
        Me.lblStock.Text = "Stock:"
        Me.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Red
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancelar.Image = Global.lacabania.My.Resources.Resources.Cancelar_32px
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(574, 490)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(144, 53)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'lblMuestraUnidMedida
        '
        Me.lblMuestraUnidMedida.AutoSize = True
        Me.lblMuestraUnidMedida.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMuestraUnidMedida.Location = New System.Drawing.Point(626, 183)
        Me.lblMuestraUnidMedida.Name = "lblMuestraUnidMedida"
        Me.lblMuestraUnidMedida.Size = New System.Drawing.Size(0, 21)
        Me.lblMuestraUnidMedida.TabIndex = 29
        '
        'btnGuardarProductos
        '
        Me.btnGuardarProductos.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarProductos.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarProductos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardarProductos.Image = Global.lacabania.My.Resources.Resources.save_32px
        Me.btnGuardarProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarProductos.Location = New System.Drawing.Point(857, 490)
        Me.btnGuardarProductos.Name = "btnGuardarProductos"
        Me.btnGuardarProductos.Size = New System.Drawing.Size(144, 53)
        Me.btnGuardarProductos.TabIndex = 12
        Me.btnGuardarProductos.Text = "GUARDAR"
        Me.btnGuardarProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardarProductos.UseVisualStyleBackColor = False
        '
        'txtNuevoPrecioVenta
        '
        Me.txtNuevoPrecioVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNuevoPrecioVenta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevoPrecioVenta.Location = New System.Drawing.Point(155, 360)
        Me.txtNuevoPrecioVenta.Name = "txtNuevoPrecioVenta"
        Me.txtNuevoPrecioVenta.Size = New System.Drawing.Size(162, 29)
        Me.txtNuevoPrecioVenta.TabIndex = 10
        '
        'lblNuevoPreciodeVenta
        '
        Me.lblNuevoPreciodeVenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNuevoPreciodeVenta.AutoSize = True
        Me.lblNuevoPreciodeVenta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevoPreciodeVenta.Location = New System.Drawing.Point(4, 363)
        Me.lblNuevoPreciodeVenta.Name = "lblNuevoPreciodeVenta"
        Me.lblNuevoPreciodeVenta.Size = New System.Drawing.Size(146, 21)
        Me.lblNuevoPreciodeVenta.TabIndex = 27
        Me.lblNuevoPreciodeVenta.Text = "Precio de Venta: $"
        Me.lblNuevoPreciodeVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoBarras.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoBarras.Location = New System.Drawing.Point(356, 120)
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Size = New System.Drawing.Size(414, 29)
        Me.txtCodigoBarras.TabIndex = 2
        '
        'lblCodigoBarras
        '
        Me.lblCodigoBarras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCodigoBarras.AutoSize = True
        Me.lblCodigoBarras.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoBarras.Location = New System.Drawing.Point(207, 123)
        Me.lblCodigoBarras.Name = "lblCodigoBarras"
        Me.lblCodigoBarras.Size = New System.Drawing.Size(143, 21)
        Me.lblCodigoBarras.TabIndex = 19
        Me.lblCodigoBarras.Text = "Código de barras:"
        Me.lblCodigoBarras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboTipoEnvase
        '
        Me.cboTipoEnvase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTipoEnvase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoEnvase.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoEnvase.FormattingEnabled = True
        Me.cboTipoEnvase.Location = New System.Drawing.Point(532, 300)
        Me.cboTipoEnvase.Name = "cboTipoEnvase"
        Me.cboTipoEnvase.Size = New System.Drawing.Size(195, 29)
        Me.cboTipoEnvase.TabIndex = 9
        Me.cboTipoEnvase.Text = "Seleccionar"
        '
        'lblTipoEnvase
        '
        Me.lblTipoEnvase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipoEnvase.AutoSize = True
        Me.lblTipoEnvase.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoEnvase.Location = New System.Drawing.Point(398, 303)
        Me.lblTipoEnvase.Name = "lblTipoEnvase"
        Me.lblTipoEnvase.Size = New System.Drawing.Size(128, 21)
        Me.lblTipoEnvase.TabIndex = 17
        Me.lblTipoEnvase.Text = "Tipo de envase:"
        Me.lblTipoEnvase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStockMinimo
        '
        Me.txtStockMinimo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStockMinimo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockMinimo.Location = New System.Drawing.Point(909, 180)
        Me.txtStockMinimo.Name = "txtStockMinimo"
        Me.txtStockMinimo.Size = New System.Drawing.Size(56, 29)
        Me.txtStockMinimo.TabIndex = 5
        '
        'lblStockMinimo
        '
        Me.lblStockMinimo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStockMinimo.AutoSize = True
        Me.lblStockMinimo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockMinimo.Location = New System.Drawing.Point(783, 183)
        Me.lblStockMinimo.Name = "lblStockMinimo"
        Me.lblStockMinimo.Size = New System.Drawing.Size(120, 21)
        Me.lblStockMinimo.TabIndex = 15
        Me.lblStockMinimo.Text = "Stock mínimo:"
        Me.lblStockMinimo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMedida
        '
        Me.txtMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMedida.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedida.Location = New System.Drawing.Point(551, 180)
        Me.txtMedida.Name = "txtMedida"
        Me.txtMedida.Size = New System.Drawing.Size(69, 29)
        Me.txtMedida.TabIndex = 4
        '
        'lblMedida
        '
        Me.lblMedida.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMedida.AutoSize = True
        Me.lblMedida.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedida.Location = New System.Drawing.Point(473, 183)
        Me.lblMedida.Name = "lblMedida"
        Me.lblMedida.Size = New System.Drawing.Size(72, 21)
        Me.lblMedida.TabIndex = 13
        Me.lblMedida.Text = "Medida:"
        Me.lblMedida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNuevoProducto
        '
        Me.lblNuevoProducto.AutoSize = True
        Me.lblNuevoProducto.BackColor = System.Drawing.Color.Transparent
        Me.lblNuevoProducto.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevoProducto.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblNuevoProducto.Location = New System.Drawing.Point(0, 0)
        Me.lblNuevoProducto.Name = "lblNuevoProducto"
        Me.lblNuevoProducto.Size = New System.Drawing.Size(263, 47)
        Me.lblNuevoProducto.TabIndex = 0
        Me.lblNuevoProducto.Text = "Nuevo producto"
        '
        'MenuTitulos
        '
        Me.MenuTitulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuTitulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuTitulos.ForeColor = System.Drawing.Color.Transparent
        Me.MenuTitulos.Location = New System.Drawing.Point(0, 0)
        Me.MenuTitulos.Name = "MenuTitulos"
        Me.MenuTitulos.Size = New System.Drawing.Size(1100, 50)
        Me.MenuTitulos.TabIndex = 18
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1100, 650)
        Me.Controls.Add(Me.MenuTitulos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProductos"
        Me.Text = "Productos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblId As Label
    Friend WithEvents lblRubro As Label
    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents lblMarca As Label
    Friend WithEvents lblUnidadMedida As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents cboRubro As ComboBox
    Friend WithEvents cboMarca As ComboBox
    Friend WithEvents cboUnidadMedida As ComboBox
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents btnGuardarProductos As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblNuevoProducto As Label
    Friend WithEvents txtStockMinimo As TextBox
    Friend WithEvents lblStockMinimo As Label
    Friend WithEvents txtMedida As TextBox
    Friend WithEvents lblMedida As Label
    Friend WithEvents txtCodigoBarras As TextBox
    Friend WithEvents lblCodigoBarras As Label
    Friend WithEvents cboTipoEnvase As ComboBox
    Friend WithEvents lblTipoEnvase As Label
    Friend WithEvents MenuTitulos As Panel
    Friend WithEvents txtNuevoPrecioVenta As TextBox
    Friend WithEvents lblNuevoPreciodeVenta As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lblMuestraUnidMedida As Label
	Friend WithEvents txtStock As TextBox
	Friend WithEvents lblStock As Label
End Class
