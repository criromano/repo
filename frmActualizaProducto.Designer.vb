<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmActualizaProducto
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
        Me.lblActualizarPrecios = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMuestraUnidMedida = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtCodigoBarras = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.cboTipoEnvase = New System.Windows.Forms.ComboBox()
        Me.lblTipoEnvase = New System.Windows.Forms.Label()
        Me.txtStockMinimo = New System.Windows.Forms.TextBox()
        Me.txtNuevoPrecioVenta = New System.Windows.Forms.TextBox()
        Me.lblStockMinimo = New System.Windows.Forms.Label()
        Me.lblNuevoPreciodeVenta = New System.Windows.Forms.Label()
        Me.txtMedida = New System.Windows.Forms.TextBox()
        Me.lblMedida = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.cboUnidadMedida = New System.Windows.Forms.ComboBox()
        Me.lblRubro = New System.Windows.Forms.Label()
        Me.cboMarca = New System.Windows.Forms.ComboBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.cboRubro = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblUnidadMedida = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.MenuTitulos = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblActualizarPrecios
        '
        Me.lblActualizarPrecios.AutoSize = True
        Me.lblActualizarPrecios.BackColor = System.Drawing.SystemColors.Control
        Me.lblActualizarPrecios.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualizarPrecios.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblActualizarPrecios.Location = New System.Drawing.Point(0, 0)
        Me.lblActualizarPrecios.Name = "lblActualizarPrecios"
        Me.lblActualizarPrecios.Size = New System.Drawing.Size(317, 47)
        Me.lblActualizarPrecios.TabIndex = 2
        Me.lblActualizarPrecios.Text = "Actualizar Producto"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblMuestraUnidMedida)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.txtCodigoBarras)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.cboTipoEnvase)
        Me.Panel1.Controls.Add(Me.lblTipoEnvase)
        Me.Panel1.Controls.Add(Me.txtStockMinimo)
        Me.Panel1.Controls.Add(Me.txtNuevoPrecioVenta)
        Me.Panel1.Controls.Add(Me.lblStockMinimo)
        Me.Panel1.Controls.Add(Me.lblNuevoPreciodeVenta)
        Me.Panel1.Controls.Add(Me.txtMedida)
        Me.Panel1.Controls.Add(Me.lblMedida)
        Me.Panel1.Controls.Add(Me.cboTipo)
        Me.Panel1.Controls.Add(Me.lblActualizarPrecios)
        Me.Panel1.Controls.Add(Me.lblTipo)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.cboUnidadMedida)
        Me.Panel1.Controls.Add(Me.lblRubro)
        Me.Panel1.Controls.Add(Me.cboMarca)
        Me.Panel1.Controls.Add(Me.lblId)
        Me.Panel1.Controls.Add(Me.cboRubro)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNombreProducto)
        Me.Panel1.Controls.Add(Me.lblMarca)
        Me.Panel1.Controls.Add(Me.lblUnidadMedida)
        Me.Panel1.Location = New System.Drawing.Point(93, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1004, 546)
        Me.Panel1.TabIndex = 27
        '
        'lblMuestraUnidMedida
        '
        Me.lblMuestraUnidMedida.AutoSize = True
        Me.lblMuestraUnidMedida.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMuestraUnidMedida.Location = New System.Drawing.Point(626, 183)
        Me.lblMuestraUnidMedida.Name = "lblMuestraUnidMedida"
        Me.lblMuestraUnidMedida.Size = New System.Drawing.Size(0, 21)
        Me.lblMuestraUnidMedida.TabIndex = 53
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
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = False
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
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(207, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 21)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Código de barras:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardar.Image = Global.lacabania.My.Resources.Resources.save_32px
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(857, 490)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(144, 53)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
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
        Me.lblTipoEnvase.TabIndex = 48
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
        'txtNuevoPrecioVenta
        '
        Me.txtNuevoPrecioVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNuevoPrecioVenta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevoPrecioVenta.Location = New System.Drawing.Point(155, 360)
        Me.txtNuevoPrecioVenta.Name = "txtNuevoPrecioVenta"
        Me.txtNuevoPrecioVenta.Size = New System.Drawing.Size(162, 29)
        Me.txtNuevoPrecioVenta.TabIndex = 10
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
        Me.lblStockMinimo.TabIndex = 46
        Me.lblStockMinimo.Text = "Stock mínimo:"
        Me.lblStockMinimo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.lblNuevoPreciodeVenta.TabIndex = 25
        Me.lblNuevoPreciodeVenta.Text = "Precio de Venta: $"
        Me.lblNuevoPreciodeVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.lblMedida.TabIndex = 44
        Me.lblMedida.Text = "Medida:"
        Me.lblMedida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.lblTipo.TabIndex = 42
        Me.lblTipo.Text = "Tipo de producto:"
        Me.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtId
        '
        Me.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(920, 60)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(45, 29)
        Me.txtId.TabIndex = 37
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
        Me.lblRubro.TabIndex = 33
        Me.lblRubro.Text = "Rubro:"
        Me.lblRubro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        '
        'lblId
        '
        Me.lblId.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblId.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(877, 63)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(37, 21)
        Me.lblId.TabIndex = 32
        Me.lblId.Text = "Id:"
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(273, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 21)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Nombre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'lblMarca
        '
        Me.lblMarca.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.Location = New System.Drawing.Point(4, 303)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(61, 21)
        Me.lblMarca.TabIndex = 35
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
        Me.lblUnidadMedida.TabIndex = 36
        Me.lblUnidadMedida.Text = "Unidad de medida:"
        Me.lblUnidadMedida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(993, 19)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(104, 20)
        Me.dtpFecha.TabIndex = 52
        Me.dtpFecha.Visible = False
        '
        'MenuTitulos
        '
        Me.MenuTitulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuTitulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuTitulos.ForeColor = System.Drawing.Color.Transparent
        Me.MenuTitulos.Location = New System.Drawing.Point(0, 0)
        Me.MenuTitulos.Name = "MenuTitulos"
        Me.MenuTitulos.Size = New System.Drawing.Size(1100, 50)
        Me.MenuTitulos.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Khaki
        Me.Panel2.Controls.Add(Me.dtpFecha)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 608)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1100, 42)
        Me.Panel2.TabIndex = 31
        '
        'frmActualizaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1100, 650)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuTitulos)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmActualizaProducto"
        Me.Text = "Actualizar Precios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblActualizarPrecios As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuTitulos As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtCodigoBarras As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboTipoEnvase As ComboBox
    Friend WithEvents lblTipoEnvase As Label
    Friend WithEvents txtStockMinimo As TextBox
    Friend WithEvents txtNuevoPrecioVenta As TextBox
    Friend WithEvents lblStockMinimo As Label
    Friend WithEvents lblNuevoPreciodeVenta As Label
    Friend WithEvents txtMedida As TextBox
    Friend WithEvents lblMedida As Label
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents cboUnidadMedida As ComboBox
    Friend WithEvents lblRubro As Label
    Friend WithEvents cboMarca As ComboBox
    Friend WithEvents lblId As Label
    Friend WithEvents cboRubro As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents lblMarca As Label
    Friend WithEvents lblUnidadMedida As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblMuestraUnidMedida As Label
End Class
