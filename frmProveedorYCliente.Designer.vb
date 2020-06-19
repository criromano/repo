<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedorYCliente
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboLocalidad = New System.Windows.Forms.ComboBox()
        Me.cboCalle = New System.Windows.Forms.ComboBox()
        Me.lblNumeroTelefono = New System.Windows.Forms.Label()
        Me.cboTipoTelefono = New System.Windows.Forms.ComboBox()
        Me.lblTipoTelefono = New System.Windows.Forms.Label()
        Me.txtNumeroDeTelefono = New System.Windows.Forms.TextBox()
        Me.txtCodigoDeArea = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblDpto = New System.Windows.Forms.Label()
        Me.txtDpto = New System.Windows.Forms.TextBox()
        Me.lblPiso = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtPiso = New System.Windows.Forms.TextBox()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCuit3 = New System.Windows.Forms.TextBox()
        Me.txtCuit1 = New System.Windows.Forms.TextBox()
        Me.txtCuit2 = New System.Windows.Forms.TextBox()
        Me.txtApellidoYNombre = New System.Windows.Forms.TextBox()
        Me.gbCargar = New System.Windows.Forms.GroupBox()
        Me.rbProveedor = New System.Windows.Forms.RadioButton()
        Me.rbCliente = New System.Windows.Forms.RadioButton()
        Me.lblProveedoresYClientes = New System.Windows.Forms.Label()
        Me.lblCuit = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.lblApellidoYNombre = New System.Windows.Forms.Label()
        Me.lblDomicilio = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btlGuardar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.gbCargar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.txtObservaciones)
        Me.Panel2.Controls.Add(Me.lblObservaciones)
        Me.Panel2.Controls.Add(Me.cboLocalidad)
        Me.Panel2.Controls.Add(Me.cboCalle)
        Me.Panel2.Controls.Add(Me.lblNumeroTelefono)
        Me.Panel2.Controls.Add(Me.cboTipoTelefono)
        Me.Panel2.Controls.Add(Me.lblTipoTelefono)
        Me.Panel2.Controls.Add(Me.txtNumeroDeTelefono)
        Me.Panel2.Controls.Add(Me.txtCodigoDeArea)
        Me.Panel2.Controls.Add(Me.lblTelefono)
        Me.Panel2.Controls.Add(Me.txtMail)
        Me.Panel2.Controls.Add(Me.lblMail)
        Me.Panel2.Controls.Add(Me.lblDpto)
        Me.Panel2.Controls.Add(Me.txtDpto)
        Me.Panel2.Controls.Add(Me.lblPiso)
        Me.Panel2.Controls.Add(Me.txtNumero)
        Me.Panel2.Controls.Add(Me.txtPiso)
        Me.Panel2.Controls.Add(Me.lblCalle)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtCuit3)
        Me.Panel2.Controls.Add(Me.txtCuit1)
        Me.Panel2.Controls.Add(Me.txtCuit2)
        Me.Panel2.Controls.Add(Me.txtApellidoYNombre)
        Me.Panel2.Controls.Add(Me.gbCargar)
        Me.Panel2.Controls.Add(Me.lblProveedoresYClientes)
        Me.Panel2.Controls.Add(Me.lblCuit)
        Me.Panel2.Controls.Add(Me.lblNumero)
        Me.Panel2.Controls.Add(Me.lblLocalidad)
        Me.Panel2.Controls.Add(Me.lblApellidoYNombre)
        Me.Panel2.Controls.Add(Me.lblDomicilio)
        Me.Panel2.Location = New System.Drawing.Point(93, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1004, 546)
        Me.Panel2.TabIndex = 20
        '
        'cboLocalidad
        '
        Me.cboLocalidad.Enabled = False
        Me.cboLocalidad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLocalidad.FormattingEnabled = True
        Me.cboLocalidad.Location = New System.Drawing.Point(154, 263)
        Me.cboLocalidad.Name = "cboLocalidad"
        Me.cboLocalidad.Size = New System.Drawing.Size(232, 29)
        Me.cboLocalidad.TabIndex = 8
        Me.cboLocalidad.Text = "SELECCIONAR"
        Me.cboLocalidad.Visible = False
        '
        'cboCalle
        '
        Me.cboCalle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCalle.FormattingEnabled = True
        Me.cboCalle.Location = New System.Drawing.Point(213, 208)
        Me.cboCalle.Name = "cboCalle"
        Me.cboCalle.Size = New System.Drawing.Size(232, 29)
        Me.cboCalle.TabIndex = 4
        Me.cboCalle.Text = "SELECCIONAR"
        Me.cboCalle.Visible = False
        '
        'lblNumeroTelefono
        '
        Me.lblNumeroTelefono.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroTelefono.AutoSize = True
        Me.lblNumeroTelefono.Enabled = False
        Me.lblNumeroTelefono.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroTelefono.Location = New System.Drawing.Point(398, 323)
        Me.lblNumeroTelefono.Name = "lblNumeroTelefono"
        Me.lblNumeroTelefono.Size = New System.Drawing.Size(77, 21)
        Me.lblNumeroTelefono.TabIndex = 35
        Me.lblNumeroTelefono.Text = "Número:"
        Me.lblNumeroTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNumeroTelefono.Visible = False
        '
        'cboTipoTelefono
        '
        Me.cboTipoTelefono.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoTelefono.FormattingEnabled = True
        Me.cboTipoTelefono.Location = New System.Drawing.Point(201, 317)
        Me.cboTipoTelefono.Name = "cboTipoTelefono"
        Me.cboTipoTelefono.Size = New System.Drawing.Size(157, 29)
        Me.cboTipoTelefono.TabIndex = 10
        Me.cboTipoTelefono.Text = "SELECCIONAR"
        Me.cboTipoTelefono.Visible = False
        '
        'lblTipoTelefono
        '
        Me.lblTipoTelefono.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipoTelefono.AutoSize = True
        Me.lblTipoTelefono.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoTelefono.Location = New System.Drawing.Point(147, 320)
        Me.lblTipoTelefono.Name = "lblTipoTelefono"
        Me.lblTipoTelefono.Size = New System.Drawing.Size(48, 21)
        Me.lblTipoTelefono.TabIndex = 33
        Me.lblTipoTelefono.Text = "Tipo:"
        Me.lblTipoTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTipoTelefono.Visible = False
        '
        'txtNumeroDeTelefono
        '
        Me.txtNumeroDeTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDeTelefono.Enabled = False
        Me.txtNumeroDeTelefono.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDeTelefono.Location = New System.Drawing.Point(547, 317)
        Me.txtNumeroDeTelefono.Name = "txtNumeroDeTelefono"
        Me.txtNumeroDeTelefono.Size = New System.Drawing.Size(125, 29)
        Me.txtNumeroDeTelefono.TabIndex = 12
        Me.txtNumeroDeTelefono.Visible = False
        '
        'txtCodigoDeArea
        '
        Me.txtCodigoDeArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoDeArea.Enabled = False
        Me.txtCodigoDeArea.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoDeArea.Location = New System.Drawing.Point(481, 317)
        Me.txtCodigoDeArea.Name = "txtCodigoDeArea"
        Me.txtCodigoDeArea.Size = New System.Drawing.Size(60, 29)
        Me.txtCodigoDeArea.TabIndex = 11
        Me.txtCodigoDeArea.Visible = False
        '
        'lblTelefono
        '
        Me.lblTelefono.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(60, 320)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(81, 21)
        Me.lblTelefono.TabIndex = 30
        Me.lblTelefono.Text = "Teléfono:"
        Me.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTelefono.Visible = False
        '
        'txtMail
        '
        Me.txtMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.Location = New System.Drawing.Point(515, 263)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(395, 29)
        Me.txtMail.TabIndex = 9
        Me.txtMail.Visible = False
        '
        'lblMail
        '
        Me.lblMail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMail.AutoSize = True
        Me.lblMail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.Location = New System.Drawing.Point(446, 266)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(63, 21)
        Me.lblMail.TabIndex = 28
        Me.lblMail.Text = "e-mail:"
        Me.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMail.Visible = False
        '
        'lblDpto
        '
        Me.lblDpto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDpto.AutoSize = True
        Me.lblDpto.Enabled = False
        Me.lblDpto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDpto.Location = New System.Drawing.Point(792, 211)
        Me.lblDpto.Name = "lblDpto"
        Me.lblDpto.Size = New System.Drawing.Size(52, 21)
        Me.lblDpto.TabIndex = 26
        Me.lblDpto.Text = "Dpto:"
        Me.lblDpto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDpto.Visible = False
        '
        'txtDpto
        '
        Me.txtDpto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDpto.Enabled = False
        Me.txtDpto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDpto.Location = New System.Drawing.Point(850, 208)
        Me.txtDpto.Name = "txtDpto"
        Me.txtDpto.Size = New System.Drawing.Size(60, 29)
        Me.txtDpto.TabIndex = 7
        Me.txtDpto.Visible = False
        '
        'lblPiso
        '
        Me.lblPiso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPiso.AutoSize = True
        Me.lblPiso.Enabled = False
        Me.lblPiso.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPiso.Location = New System.Drawing.Point(657, 211)
        Me.lblPiso.Name = "lblPiso"
        Me.lblPiso.Size = New System.Drawing.Size(46, 21)
        Me.lblPiso.TabIndex = 24
        Me.lblPiso.Text = "Piso:"
        Me.lblPiso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPiso.Visible = False
        '
        'txtNumero
        '
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.Enabled = False
        Me.txtNumero.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(568, 208)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(60, 29)
        Me.txtNumero.TabIndex = 5
        Me.txtNumero.Visible = False
        '
        'txtPiso
        '
        Me.txtPiso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPiso.Enabled = False
        Me.txtPiso.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPiso.Location = New System.Drawing.Point(709, 208)
        Me.txtPiso.Name = "txtPiso"
        Me.txtPiso.Size = New System.Drawing.Size(60, 29)
        Me.txtPiso.TabIndex = 6
        Me.txtPiso.Visible = False
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalle.Location = New System.Drawing.Point(155, 211)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(52, 21)
        Me.lblCalle.TabIndex = 21
        Me.lblCalle.Text = "Calle:"
        Me.lblCalle.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(870, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 21)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "-"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(763, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 21)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "-"
        Me.Label2.Visible = False
        '
        'txtCuit3
        '
        Me.txtCuit3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuit3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuit3.Location = New System.Drawing.Point(892, 158)
        Me.txtCuit3.MaxLength = 1
        Me.txtCuit3.Name = "txtCuit3"
        Me.txtCuit3.Size = New System.Drawing.Size(18, 29)
        Me.txtCuit3.TabIndex = 3
        Me.txtCuit3.Visible = False
        '
        'txtCuit1
        '
        Me.txtCuit1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuit1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuit1.Location = New System.Drawing.Point(728, 158)
        Me.txtCuit1.MaxLength = 2
        Me.txtCuit1.Name = "txtCuit1"
        Me.txtCuit1.Size = New System.Drawing.Size(29, 29)
        Me.txtCuit1.TabIndex = 1
        Me.txtCuit1.Visible = False
        '
        'txtCuit2
        '
        Me.txtCuit2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuit2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuit2.Location = New System.Drawing.Point(785, 158)
        Me.txtCuit2.MaxLength = 8
        Me.txtCuit2.Name = "txtCuit2"
        Me.txtCuit2.Size = New System.Drawing.Size(79, 29)
        Me.txtCuit2.TabIndex = 2
        Me.txtCuit2.Visible = False
        '
        'txtApellidoYNombre
        '
        Me.txtApellidoYNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoYNombre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoYNombre.Location = New System.Drawing.Point(222, 158)
        Me.txtApellidoYNombre.Name = "txtApellidoYNombre"
        Me.txtApellidoYNombre.Size = New System.Drawing.Size(360, 29)
        Me.txtApellidoYNombre.TabIndex = 0
        Me.txtApellidoYNombre.Visible = False
        '
        'gbCargar
        '
        Me.gbCargar.Controls.Add(Me.rbProveedor)
        Me.gbCargar.Controls.Add(Me.rbCliente)
        Me.gbCargar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCargar.Location = New System.Drawing.Point(244, 67)
        Me.gbCargar.Name = "gbCargar"
        Me.gbCargar.Size = New System.Drawing.Size(488, 68)
        Me.gbCargar.TabIndex = 17
        Me.gbCargar.TabStop = False
        Me.gbCargar.Text = "Cargar"
        '
        'rbProveedor
        '
        Me.rbProveedor.AutoSize = True
        Me.rbProveedor.Location = New System.Drawing.Point(339, 28)
        Me.rbProveedor.Name = "rbProveedor"
        Me.rbProveedor.Size = New System.Drawing.Size(107, 25)
        Me.rbProveedor.TabIndex = 16
        Me.rbProveedor.TabStop = True
        Me.rbProveedor.Text = "Proveedor"
        Me.rbProveedor.UseVisualStyleBackColor = True
        '
        'rbCliente
        '
        Me.rbCliente.AutoSize = True
        Me.rbCliente.Location = New System.Drawing.Point(60, 28)
        Me.rbCliente.Name = "rbCliente"
        Me.rbCliente.Size = New System.Drawing.Size(82, 25)
        Me.rbCliente.TabIndex = 15
        Me.rbCliente.TabStop = True
        Me.rbCliente.Text = "Cliente"
        Me.rbCliente.UseVisualStyleBackColor = True
        '
        'lblProveedoresYClientes
        '
        Me.lblProveedoresYClientes.AutoSize = True
        Me.lblProveedoresYClientes.BackColor = System.Drawing.Color.Transparent
        Me.lblProveedoresYClientes.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedoresYClientes.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblProveedoresYClientes.Location = New System.Drawing.Point(205, 3)
        Me.lblProveedoresYClientes.Name = "lblProveedoresYClientes"
        Me.lblProveedoresYClientes.Size = New System.Drawing.Size(568, 47)
        Me.lblProveedoresYClientes.TabIndex = 0
        Me.lblProveedoresYClientes.Text = "ALTA DE PROVEEDORES Y CLIENTES"
        '
        'lblCuit
        '
        Me.lblCuit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCuit.AutoSize = True
        Me.lblCuit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuit.Location = New System.Drawing.Point(672, 161)
        Me.lblCuit.Name = "lblCuit"
        Me.lblCuit.Size = New System.Drawing.Size(50, 21)
        Me.lblCuit.TabIndex = 11
        Me.lblCuit.Text = "CUIT:"
        Me.lblCuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCuit.Visible = False
        '
        'lblNumero
        '
        Me.lblNumero.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Enabled = False
        Me.lblNumero.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(492, 211)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(77, 21)
        Me.lblNumero.TabIndex = 5
        Me.lblNumero.Text = "Número:"
        Me.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNumero.Visible = False
        '
        'lblLocalidad
        '
        Me.lblLocalidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Enabled = False
        Me.lblLocalidad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidad.Location = New System.Drawing.Point(60, 266)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(88, 21)
        Me.lblLocalidad.TabIndex = 4
        Me.lblLocalidad.Text = "Localidad:"
        Me.lblLocalidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLocalidad.Visible = False
        '
        'lblApellidoYNombre
        '
        Me.lblApellidoYNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblApellidoYNombre.AutoSize = True
        Me.lblApellidoYNombre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoYNombre.Location = New System.Drawing.Point(60, 161)
        Me.lblApellidoYNombre.Name = "lblApellidoYNombre"
        Me.lblApellidoYNombre.Size = New System.Drawing.Size(156, 21)
        Me.lblApellidoYNombre.TabIndex = 3
        Me.lblApellidoYNombre.Text = "Apellido y nombre:"
        Me.lblApellidoYNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblApellidoYNombre.Visible = False
        '
        'lblDomicilio
        '
        Me.lblDomicilio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomicilio.Location = New System.Drawing.Point(60, 211)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(89, 21)
        Me.lblDomicilio.TabIndex = 2
        Me.lblDomicilio.Text = "Domicilio:"
        Me.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDomicilio.Visible = False
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(372, 352)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(114, 53)
        Me.btnVolver.TabIndex = 19
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btlGuardar
        '
        Me.btlGuardar.Location = New System.Drawing.Point(492, 352)
        Me.btlGuardar.Name = "btlGuardar"
        Me.btlGuardar.Size = New System.Drawing.Size(114, 53)
        Me.btlGuardar.TabIndex = 18
        Me.btlGuardar.Text = "GUARDAR"
        Me.btlGuardar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.lacabania.My.Resources.Resources.Cancelar_32px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(574, 490)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 53)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "CANCELAR"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Image = Global.lacabania.My.Resources.Resources.save_32px
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(857, 490)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(144, 53)
        Me.btnGuardar.TabIndex = 13
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 608)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 42)
        Me.Panel1.TabIndex = 34
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(60, 371)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(126, 21)
        Me.lblObservaciones.TabIndex = 39
        Me.lblObservaciones.Text = "Observaciones:"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblObservaciones.Visible = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(192, 368)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(390, 29)
        Me.txtObservaciones.TabIndex = 40
        Me.txtObservaciones.Visible = False
        '
        'frmProveedorYCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1100, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btlGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProveedorYCliente"
        Me.Text = "frmProveedor"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.gbCargar.ResumeLayout(False)
        Me.gbCargar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
	Friend WithEvents lblProveedoresYClientes As Label
    Friend WithEvents lblCuit As Label
    Friend WithEvents lblNumero As Label
    Friend WithEvents lblLocalidad As Label
    Friend WithEvents lblApellidoYNombre As Label
    Friend WithEvents lblDomicilio As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents btlGuardar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtApellidoYNombre As TextBox
    Friend WithEvents gbCargar As GroupBox
    Friend WithEvents rbProveedor As RadioButton
    Friend WithEvents rbCliente As RadioButton
    Friend WithEvents txtCuit3 As TextBox
    Friend WithEvents txtCuit1 As TextBox
    Friend WithEvents txtCuit2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDpto As Label
    Friend WithEvents txtDpto As TextBox
    Friend WithEvents lblPiso As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtPiso As TextBox
    Friend WithEvents lblCalle As Label
    Friend WithEvents txtMail As TextBox
    Friend WithEvents lblMail As Label
    Friend WithEvents txtNumeroDeTelefono As TextBox
    Friend WithEvents txtCodigoDeArea As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblNumeroTelefono As Label
    Friend WithEvents cboTipoTelefono As ComboBox
    Friend WithEvents lblTipoTelefono As Label
    Friend WithEvents cboCalle As ComboBox
    Friend WithEvents cboLocalidad As ComboBox
	Friend WithEvents Panel1 As Panel
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents lblObservaciones As Label
End Class
