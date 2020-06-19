<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.MenuVertical = New System.Windows.Forms.Panel()
        Me.MenuTitulos = New System.Windows.Forms.Panel()
        Me.lblFechaHora = New System.Windows.Forms.Label()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.lblAtencion = New System.Windows.Forms.Label()
        Me.dgvStockMinimo = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnInformes = New System.Windows.Forms.Button()
        Me.btnAgregarDetalles = New System.Windows.Forms.Button()
        Me.btnCuentaCorriente = New System.Windows.Forms.Button()
        Me.btnIngresarNuevaCompra = New System.Windows.Forms.Button()
        Me.btnProveedor = New System.Windows.Forms.Button()
        Me.btnCaja = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnProductosNuevos = New System.Windows.Forms.Button()
        Me.btnSlide = New System.Windows.Forms.PictureBox()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.MenuVertical.SuspendLayout()
        Me.MenuTitulos.SuspendLayout()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.dgvStockMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuVertical
        '
        Me.MenuVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuVertical.Controls.Add(Me.btnInicio)
        Me.MenuVertical.Controls.Add(Me.btnInformes)
        Me.MenuVertical.Controls.Add(Me.btnAgregarDetalles)
        Me.MenuVertical.Controls.Add(Me.btnCuentaCorriente)
        Me.MenuVertical.Controls.Add(Me.btnIngresarNuevaCompra)
        Me.MenuVertical.Controls.Add(Me.btnProveedor)
        Me.MenuVertical.Controls.Add(Me.btnCaja)
        Me.MenuVertical.Controls.Add(Me.btnVentas)
        Me.MenuVertical.Controls.Add(Me.btnProductosNuevos)
        Me.MenuVertical.Controls.Add(Me.btnSlide)
        Me.MenuVertical.Location = New System.Drawing.Point(0, 47)
        Me.MenuVertical.Name = "MenuVertical"
        Me.MenuVertical.Size = New System.Drawing.Size(220, 661)
        Me.MenuVertical.TabIndex = 0
        '
        'MenuTitulos
        '
        Me.MenuTitulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuTitulos.Controls.Add(Me.PictureBox2)
        Me.MenuTitulos.Controls.Add(Me.lblFechaHora)
        Me.MenuTitulos.Controls.Add(Me.PictureBox1)
        Me.MenuTitulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuTitulos.ForeColor = System.Drawing.Color.Transparent
        Me.MenuTitulos.Location = New System.Drawing.Point(0, 0)
        Me.MenuTitulos.Name = "MenuTitulos"
        Me.MenuTitulos.Size = New System.Drawing.Size(1100, 50)
        Me.MenuTitulos.TabIndex = 1
        '
        'lblFechaHora
        '
        Me.lblFechaHora.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblFechaHora.AutoSize = True
        Me.lblFechaHora.Enabled = False
        Me.lblFechaHora.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaHora.Location = New System.Drawing.Point(397, 17)
        Me.lblFechaHora.Name = "lblFechaHora"
        Me.lblFechaHora.Size = New System.Drawing.Size(140, 23)
        Me.lblFechaHora.TabIndex = 1
        Me.lblFechaHora.Text = "HORA FECHA"
        Me.lblFechaHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.Control
        Me.PanelContenedor.Controls.Add(Me.lblAtencion)
        Me.PanelContenedor.Controls.Add(Me.dgvStockMinimo)
        Me.PanelContenedor.Controls.Add(Me.Panel1)
        Me.PanelContenedor.Controls.Add(Me.pbLogo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1100, 650)
        Me.PanelContenedor.TabIndex = 2
        '
        'lblAtencion
        '
        Me.lblAtencion.AutoSize = True
        Me.lblAtencion.BackColor = System.Drawing.Color.Transparent
        Me.lblAtencion.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtencion.ForeColor = System.Drawing.Color.Red
        Me.lblAtencion.Location = New System.Drawing.Point(225, 110)
        Me.lblAtencion.Name = "lblAtencion"
        Me.lblAtencion.Size = New System.Drawing.Size(863, 40)
        Me.lblAtencion.TabIndex = 19
        Me.lblAtencion.Text = "ATENCIÓN! Algunos productos están por debajo del stock mínimo"
        Me.lblAtencion.Visible = False
        '
        'dgvStockMinimo
        '
        Me.dgvStockMinimo.AllowUserToAddRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvStockMinimo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStockMinimo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvStockMinimo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvStockMinimo.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvStockMinimo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStockMinimo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvStockMinimo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockMinimo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStockMinimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStockMinimo.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStockMinimo.EnableHeadersVisualStyles = False
        Me.dgvStockMinimo.Location = New System.Drawing.Point(226, 158)
        Me.dgvStockMinimo.MultiSelect = False
        Me.dgvStockMinimo.Name = "dgvStockMinimo"
        Me.dgvStockMinimo.ReadOnly = True
        Me.dgvStockMinimo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockMinimo.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvStockMinimo.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgvStockMinimo.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvStockMinimo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStockMinimo.Size = New System.Drawing.Size(862, 387)
        Me.dgvStockMinimo.TabIndex = 18
        Me.dgvStockMinimo.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 608)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 42)
        Me.Panel1.TabIndex = 17
        '
        'tmOcultarMenu
        '
        Me.tmOcultarMenu.Interval = 30
        '
        'tmMostrarMenu
        '
        Me.tmMostrarMenu.Interval = 30
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.lacabania.My.Resources.Resources.logo_50px
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 50)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.lacabania.My.Resources.Resources._error
        Me.PictureBox1.Location = New System.Drawing.Point(1059, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 28)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnInicio
        '
        Me.btnInicio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnInicio.BackColor = System.Drawing.Color.Transparent
        Me.btnInicio.FlatAppearance.BorderSize = 0
        Me.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.ForeColor = System.Drawing.Color.White
        Me.btnInicio.Image = Global.lacabania.My.Resources.Resources.inicio_32px
        Me.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.Location = New System.Drawing.Point(0, 5)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(100, 40)
        Me.btnInicio.TabIndex = 9
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInicio.UseVisualStyleBackColor = False
        Me.btnInicio.Visible = False
        '
        'btnInformes
        '
        Me.btnInformes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnInformes.BackColor = System.Drawing.Color.Transparent
        Me.btnInformes.FlatAppearance.BorderSize = 0
        Me.btnInformes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnInformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInformes.Font = New System.Drawing.Font("Segoe UI", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformes.ForeColor = System.Drawing.Color.White
        Me.btnInformes.Image = Global.lacabania.My.Resources.Resources.informes_64px
        Me.btnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInformes.Location = New System.Drawing.Point(0, 400)
        Me.btnInformes.Name = "btnInformes"
        Me.btnInformes.Size = New System.Drawing.Size(220, 70)
        Me.btnInformes.TabIndex = 8
        Me.btnInformes.Text = "Informes"
        Me.btnInformes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInformes.UseVisualStyleBackColor = False
        '
        'btnAgregarDetalles
        '
        Me.btnAgregarDetalles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarDetalles.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarDetalles.FlatAppearance.BorderSize = 0
        Me.btnAgregarDetalles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnAgregarDetalles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnAgregarDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarDetalles.Font = New System.Drawing.Font("Segoe UI", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarDetalles.ForeColor = System.Drawing.Color.White
        Me.btnAgregarDetalles.Image = Global.lacabania.My.Resources.Resources.agregar_descripciones_64px
        Me.btnAgregarDetalles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarDetalles.Location = New System.Drawing.Point(0, 330)
        Me.btnAgregarDetalles.Name = "btnAgregarDetalles"
        Me.btnAgregarDetalles.Size = New System.Drawing.Size(220, 70)
        Me.btnAgregarDetalles.TabIndex = 7
        Me.btnAgregarDetalles.Text = "Agregar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "detalles"
        Me.btnAgregarDetalles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarDetalles.UseVisualStyleBackColor = False
        '
        'btnCuentaCorriente
        '
        Me.btnCuentaCorriente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCuentaCorriente.BackColor = System.Drawing.Color.Transparent
        Me.btnCuentaCorriente.FlatAppearance.BorderSize = 0
        Me.btnCuentaCorriente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnCuentaCorriente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnCuentaCorriente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuentaCorriente.Font = New System.Drawing.Font("Segoe UI", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuentaCorriente.ForeColor = System.Drawing.Color.White
        Me.btnCuentaCorriente.Image = Global.lacabania.My.Resources.Resources.cuenta_corriente_64px
        Me.btnCuentaCorriente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCuentaCorriente.Location = New System.Drawing.Point(0, 260)
        Me.btnCuentaCorriente.Name = "btnCuentaCorriente"
        Me.btnCuentaCorriente.Size = New System.Drawing.Size(220, 70)
        Me.btnCuentaCorriente.TabIndex = 6
        Me.btnCuentaCorriente.Text = "Cuenta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Corriente"
        Me.btnCuentaCorriente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCuentaCorriente.UseVisualStyleBackColor = False
        '
        'btnIngresarNuevaCompra
        '
        Me.btnIngresarNuevaCompra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnIngresarNuevaCompra.BackColor = System.Drawing.Color.Transparent
        Me.btnIngresarNuevaCompra.FlatAppearance.BorderSize = 0
        Me.btnIngresarNuevaCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnIngresarNuevaCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnIngresarNuevaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresarNuevaCompra.Font = New System.Drawing.Font("Segoe UI", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarNuevaCompra.ForeColor = System.Drawing.Color.White
        Me.btnIngresarNuevaCompra.Image = Global.lacabania.My.Resources.Resources.nueva_compra_64px
        Me.btnIngresarNuevaCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIngresarNuevaCompra.Location = New System.Drawing.Point(0, 190)
        Me.btnIngresarNuevaCompra.Name = "btnIngresarNuevaCompra"
        Me.btnIngresarNuevaCompra.Size = New System.Drawing.Size(220, 70)
        Me.btnIngresarNuevaCompra.TabIndex = 5
        Me.btnIngresarNuevaCompra.Text = "Compras"
        Me.btnIngresarNuevaCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIngresarNuevaCompra.UseVisualStyleBackColor = False
        '
        'btnProveedor
        '
        Me.btnProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnProveedor.BackColor = System.Drawing.Color.Transparent
        Me.btnProveedor.FlatAppearance.BorderSize = 0
        Me.btnProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedor.Font = New System.Drawing.Font("Segoe UI", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProveedor.ForeColor = System.Drawing.Color.White
        Me.btnProveedor.Image = Global.lacabania.My.Resources.Resources.proveedores_64px
        Me.btnProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProveedor.Location = New System.Drawing.Point(0, 470)
        Me.btnProveedor.Name = "btnProveedor"
        Me.btnProveedor.Size = New System.Drawing.Size(220, 70)
        Me.btnProveedor.TabIndex = 4
        Me.btnProveedor.Text = "Proveedores" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y Clientes"
        Me.btnProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProveedor.UseVisualStyleBackColor = False
        '
        'btnCaja
        '
        Me.btnCaja.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCaja.BackColor = System.Drawing.Color.Transparent
        Me.btnCaja.FlatAppearance.BorderSize = 0
        Me.btnCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCaja.Font = New System.Drawing.Font("Segoe UI", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaja.ForeColor = System.Drawing.Color.White
        Me.btnCaja.Image = Global.lacabania.My.Resources.Resources.caja_64px
        Me.btnCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCaja.Location = New System.Drawing.Point(0, 540)
        Me.btnCaja.Name = "btnCaja"
        Me.btnCaja.Size = New System.Drawing.Size(220, 70)
        Me.btnCaja.TabIndex = 3
        Me.btnCaja.Text = "Caja"
        Me.btnCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCaja.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVentas.BackColor = System.Drawing.Color.Transparent
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Segoe UI", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ForeColor = System.Drawing.Color.White
        Me.btnVentas.Image = Global.lacabania.My.Resources.Resources.ventas_64px
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.Location = New System.Drawing.Point(0, 120)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(220, 70)
        Me.btnVentas.TabIndex = 2
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'btnProductosNuevos
        '
        Me.btnProductosNuevos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnProductosNuevos.BackColor = System.Drawing.Color.Transparent
        Me.btnProductosNuevos.FlatAppearance.BorderSize = 0
        Me.btnProductosNuevos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnProductosNuevos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnProductosNuevos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductosNuevos.Font = New System.Drawing.Font("Segoe UI", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductosNuevos.ForeColor = System.Drawing.Color.White
        Me.btnProductosNuevos.Image = Global.lacabania.My.Resources.Resources.product_64px
        Me.btnProductosNuevos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductosNuevos.Location = New System.Drawing.Point(0, 50)
        Me.btnProductosNuevos.Name = "btnProductosNuevos"
        Me.btnProductosNuevos.Size = New System.Drawing.Size(220, 70)
        Me.btnProductosNuevos.TabIndex = 1
        Me.btnProductosNuevos.Text = "Productos"
        Me.btnProductosNuevos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProductosNuevos.UseVisualStyleBackColor = False
        '
        'btnSlide
        '
        Me.btnSlide.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSlide.ErrorImage = Global.lacabania.My.Resources.Resources.menu
        Me.btnSlide.Image = CType(resources.GetObject("btnSlide.Image"), System.Drawing.Image)
        Me.btnSlide.Location = New System.Drawing.Point(158, 6)
        Me.btnSlide.Name = "btnSlide"
        Me.btnSlide.Size = New System.Drawing.Size(59, 41)
        Me.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSlide.TabIndex = 0
        Me.btnSlide.TabStop = False
        '
        'pbLogo
        '
        Me.pbLogo.Image = Global.lacabania.My.Resources.Resources.logo_550px_50pc
        Me.pbLogo.Location = New System.Drawing.Point(383, 56)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(550, 550)
        Me.pbLogo.TabIndex = 20
        Me.pbLogo.TabStop = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 650)
        Me.Controls.Add(Me.MenuTitulos)
        Me.Controls.Add(Me.MenuVertical)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuVertical.ResumeLayout(False)
        Me.MenuTitulos.ResumeLayout(False)
        Me.MenuTitulos.PerformLayout()
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        CType(Me.dgvStockMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSlide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents MenuVertical As Panel
    Friend WithEvents MenuTitulos As Panel
    Friend WithEvents btnSlide As PictureBox
    Friend WithEvents btnProductosNuevos As Button
    Friend WithEvents btnCaja As Button
    Friend WithEvents btnVentas As Button
    Public WithEvents PanelContenedor As Panel
    Friend WithEvents btnProveedor As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tmOcultarMenu As Timer
    Friend WithEvents tmMostrarMenu As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnIngresarNuevaCompra As Button
    Private WithEvents lblFechaHora As Label
    Friend WithEvents btnCuentaCorriente As Button
    Friend WithEvents btnAgregarDetalles As Button
    Friend WithEvents btnInformes As Button
	Friend WithEvents dgvStockMinimo As DataGridView
    Friend WithEvents lblAtencion As Label
    Friend WithEvents btnInicio As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pbLogo As PictureBox
End Class