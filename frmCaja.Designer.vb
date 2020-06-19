<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCaja
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
        Me.MenuTitulos = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDetalleProveedor = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotalPagoProveedor = New System.Windows.Forms.TextBox()
        Me.btnDetallesCobrosCC = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalCobrosCC = New System.Windows.Forms.TextBox()
        Me.btnCCCompras = New System.Windows.Forms.Button()
        Me.txtTotalCuentaCompras = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnEfectivoCompras = New System.Windows.Forms.Button()
        Me.txtTotalEfectivoCompras = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCCVentas = New System.Windows.Forms.Button()
        Me.txtTotalCuenta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnEfectivoVentas = New System.Windows.Forms.Button()
        Me.txtTotalEfectivo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtInicio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDelleCompras = New System.Windows.Forms.Button()
        Me.btnDetalleVentas = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalVentas = New System.Windows.Forms.TextBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaCaja = New System.Windows.Forms.DateTimePicker()
        Me.lblTipodeVenta = New System.Windows.Forms.Label()
        Me.txtTotalCompras = New System.Windows.Forms.TextBox()
        Me.btnExportarAExcel = New System.Windows.Forms.Button()
        Me.dgvDatosParaExportar = New System.Windows.Forms.DataGridView()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sdoInicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalVentas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalVentasEfectivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalVentasCC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalCompras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalComprasEfectivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalComprasCC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalCobrosCC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbl_totalpagosprov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldoDia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvDatosParaExportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuTitulos
        '
        Me.MenuTitulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuTitulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuTitulos.ForeColor = System.Drawing.Color.Transparent
        Me.MenuTitulos.Location = New System.Drawing.Point(0, 0)
        Me.MenuTitulos.Name = "MenuTitulos"
        Me.MenuTitulos.Size = New System.Drawing.Size(1100, 50)
        Me.MenuTitulos.TabIndex = 22
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.btnDetalleProveedor)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.txtTotalPagoProveedor)
        Me.Panel3.Controls.Add(Me.btnDetallesCobrosCC)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtTotalCobrosCC)
        Me.Panel3.Controls.Add(Me.btnCCCompras)
        Me.Panel3.Controls.Add(Me.txtTotalCuentaCompras)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.btnEfectivoCompras)
        Me.Panel3.Controls.Add(Me.txtTotalEfectivoCompras)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.btnCCVentas)
        Me.Panel3.Controls.Add(Me.txtTotalCuenta)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.btnEfectivoVentas)
        Me.Panel3.Controls.Add(Me.txtTotalEfectivo)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.btnGuardar)
        Me.Panel3.Controls.Add(Me.txtInicio)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.btnDelleCompras)
        Me.Panel3.Controls.Add(Me.btnDetalleVentas)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.lblSaldo)
        Me.Panel3.Controls.Add(Me.txtSaldo)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txtTotalVentas)
        Me.Panel3.Controls.Add(Me.lblCliente)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.dtpFechaCaja)
        Me.Panel3.Controls.Add(Me.lblTipodeVenta)
        Me.Panel3.Controls.Add(Me.txtTotalCompras)
        Me.Panel3.Location = New System.Drawing.Point(225, 56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(657, 508)
        Me.Panel3.TabIndex = 21
        '
        'btnDetalleProveedor
        '
        Me.btnDetalleProveedor.BackColor = System.Drawing.SystemColors.Info
        Me.btnDetalleProveedor.Image = Global.lacabania.My.Resources.Resources.find_24px
        Me.btnDetalleProveedor.Location = New System.Drawing.Point(576, 407)
        Me.btnDetalleProveedor.Name = "btnDetalleProveedor"
        Me.btnDetalleProveedor.Size = New System.Drawing.Size(34, 35)
        Me.btnDetalleProveedor.TabIndex = 70
        Me.btnDetalleProveedor.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(167, 414)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(207, 21)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Total Pago a Proveedores:"
        '
        'txtTotalPagoProveedor
        '
        Me.txtTotalPagoProveedor.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotalPagoProveedor.Enabled = False
        Me.txtTotalPagoProveedor.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPagoProveedor.Location = New System.Drawing.Point(381, 408)
        Me.txtTotalPagoProveedor.Name = "txtTotalPagoProveedor"
        Me.txtTotalPagoProveedor.ReadOnly = True
        Me.txtTotalPagoProveedor.Size = New System.Drawing.Size(195, 33)
        Me.txtTotalPagoProveedor.TabIndex = 68
        Me.txtTotalPagoProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDetallesCobrosCC
        '
        Me.btnDetallesCobrosCC.BackColor = System.Drawing.SystemColors.Info
        Me.btnDetallesCobrosCC.Image = Global.lacabania.My.Resources.Resources.find_24px
        Me.btnDetallesCobrosCC.Location = New System.Drawing.Point(576, 359)
        Me.btnDetallesCobrosCC.Name = "btnDetallesCobrosCC"
        Me.btnDetallesCobrosCC.Size = New System.Drawing.Size(34, 35)
        Me.btnDetallesCobrosCC.TabIndex = 67
        Me.btnDetallesCobrosCC.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(167, 366)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(175, 21)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Total Cobros Cta. Cte.:"
        '
        'txtTotalCobrosCC
        '
        Me.txtTotalCobrosCC.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotalCobrosCC.Enabled = False
        Me.txtTotalCobrosCC.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCobrosCC.Location = New System.Drawing.Point(381, 360)
        Me.txtTotalCobrosCC.Name = "txtTotalCobrosCC"
        Me.txtTotalCobrosCC.ReadOnly = True
        Me.txtTotalCobrosCC.Size = New System.Drawing.Size(195, 33)
        Me.txtTotalCobrosCC.TabIndex = 65
        Me.txtTotalCobrosCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCCCompras
        '
        Me.btnCCCompras.BackColor = System.Drawing.SystemColors.Info
        Me.btnCCCompras.Image = Global.lacabania.My.Resources.Resources.find_24px
        Me.btnCCCompras.Location = New System.Drawing.Point(577, 314)
        Me.btnCCCompras.Name = "btnCCCompras"
        Me.btnCCCompras.Size = New System.Drawing.Size(34, 30)
        Me.btnCCCompras.TabIndex = 64
        Me.btnCCCompras.UseVisualStyleBackColor = False
        '
        'txtTotalCuentaCompras
        '
        Me.txtTotalCuentaCompras.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotalCuentaCompras.Enabled = False
        Me.txtTotalCuentaCompras.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCuentaCompras.Location = New System.Drawing.Point(418, 314)
        Me.txtTotalCuentaCompras.Name = "txtTotalCuentaCompras"
        Me.txtTotalCuentaCompras.ReadOnly = True
        Me.txtTotalCuentaCompras.Size = New System.Drawing.Size(159, 29)
        Me.txtTotalCuentaCompras.TabIndex = 63
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(168, 320)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 17)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Total Compras Cta. Cte.:"
        '
        'btnEfectivoCompras
        '
        Me.btnEfectivoCompras.BackColor = System.Drawing.SystemColors.Info
        Me.btnEfectivoCompras.Image = Global.lacabania.My.Resources.Resources.find_24px
        Me.btnEfectivoCompras.Location = New System.Drawing.Point(577, 279)
        Me.btnEfectivoCompras.Name = "btnEfectivoCompras"
        Me.btnEfectivoCompras.Size = New System.Drawing.Size(34, 30)
        Me.btnEfectivoCompras.TabIndex = 61
        Me.btnEfectivoCompras.UseVisualStyleBackColor = False
        '
        'txtTotalEfectivoCompras
        '
        Me.txtTotalEfectivoCompras.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotalEfectivoCompras.Enabled = False
        Me.txtTotalEfectivoCompras.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalEfectivoCompras.Location = New System.Drawing.Point(418, 279)
        Me.txtTotalEfectivoCompras.Name = "txtTotalEfectivoCompras"
        Me.txtTotalEfectivoCompras.ReadOnly = True
        Me.txtTotalEfectivoCompras.Size = New System.Drawing.Size(159, 29)
        Me.txtTotalEfectivoCompras.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(168, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 17)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Total Compras Efectivo:"
        '
        'btnCCVentas
        '
        Me.btnCCVentas.BackColor = System.Drawing.SystemColors.Info
        Me.btnCCVentas.Image = Global.lacabania.My.Resources.Resources.find_24px
        Me.btnCCVentas.Location = New System.Drawing.Point(576, 197)
        Me.btnCCVentas.Name = "btnCCVentas"
        Me.btnCCVentas.Size = New System.Drawing.Size(34, 30)
        Me.btnCCVentas.TabIndex = 58
        Me.btnCCVentas.UseVisualStyleBackColor = False
        '
        'txtTotalCuenta
        '
        Me.txtTotalCuenta.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotalCuenta.Enabled = False
        Me.txtTotalCuenta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCuenta.Location = New System.Drawing.Point(418, 197)
        Me.txtTotalCuenta.Name = "txtTotalCuenta"
        Me.txtTotalCuenta.ReadOnly = True
        Me.txtTotalCuenta.Size = New System.Drawing.Size(158, 29)
        Me.txtTotalCuenta.TabIndex = 57
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(168, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 17)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Total Ventas Cta. Cte.:"
        '
        'btnEfectivoVentas
        '
        Me.btnEfectivoVentas.BackColor = System.Drawing.SystemColors.Info
        Me.btnEfectivoVentas.Image = Global.lacabania.My.Resources.Resources.find_24px
        Me.btnEfectivoVentas.Location = New System.Drawing.Point(576, 161)
        Me.btnEfectivoVentas.Name = "btnEfectivoVentas"
        Me.btnEfectivoVentas.Size = New System.Drawing.Size(34, 30)
        Me.btnEfectivoVentas.TabIndex = 55
        Me.btnEfectivoVentas.UseVisualStyleBackColor = False
        '
        'txtTotalEfectivo
        '
        Me.txtTotalEfectivo.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotalEfectivo.Enabled = False
        Me.txtTotalEfectivo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalEfectivo.Location = New System.Drawing.Point(418, 162)
        Me.txtTotalEfectivo.Name = "txtTotalEfectivo"
        Me.txtTotalEfectivo.ReadOnly = True
        Me.txtTotalEfectivo.Size = New System.Drawing.Size(158, 29)
        Me.txtTotalEfectivo.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(168, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 17)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Total Ventas Efectivo:"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Info
        Me.btnGuardar.Image = Global.lacabania.My.Resources.Resources.save_32px
        Me.btnGuardar.Location = New System.Drawing.Point(576, 70)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(34, 35)
        Me.btnGuardar.TabIndex = 52
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtInicio
        '
        Me.txtInicio.BackColor = System.Drawing.SystemColors.Info
        Me.txtInicio.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInicio.Location = New System.Drawing.Point(381, 70)
        Me.txtInicio.Name = "txtInicio"
        Me.txtInicio.ReadOnly = True
        Me.txtInicio.Size = New System.Drawing.Size(195, 33)
        Me.txtInicio.TabIndex = 51
        Me.txtInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(167, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 21)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Saldo inicial:"
        '
        'btnDelleCompras
        '
        Me.btnDelleCompras.BackColor = System.Drawing.SystemColors.Info
        Me.btnDelleCompras.Image = Global.lacabania.My.Resources.Resources.find_24px
        Me.btnDelleCompras.Location = New System.Drawing.Point(576, 240)
        Me.btnDelleCompras.Name = "btnDelleCompras"
        Me.btnDelleCompras.Size = New System.Drawing.Size(34, 35)
        Me.btnDelleCompras.TabIndex = 49
        Me.btnDelleCompras.UseVisualStyleBackColor = False
        '
        'btnDetalleVentas
        '
        Me.btnDetalleVentas.BackColor = System.Drawing.SystemColors.Info
        Me.btnDetalleVentas.Image = Global.lacabania.My.Resources.Resources.find_24px
        Me.btnDetalleVentas.Location = New System.Drawing.Point(576, 122)
        Me.btnDetalleVentas.Name = "btnDetalleVentas"
        Me.btnDetalleVentas.Size = New System.Drawing.Size(34, 35)
        Me.btnDetalleVentas.TabIndex = 48
        Me.btnDetalleVentas.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(142, 444)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(502, 21)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "---------------------------------------------------------------------------------" &
    "-"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.ForeColor = System.Drawing.Color.Red
        Me.lblSaldo.Location = New System.Drawing.Point(226, 470)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(148, 30)
        Me.lblSaldo.TabIndex = 46
        Me.lblSaldo.Text = "Saldo del Día:"
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.White
        Me.txtSaldo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(380, 465)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(195, 39)
        Me.txtSaldo.TabIndex = 45
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Italic)
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(32, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 47)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "CAJA"
        '
        'txtTotalVentas
        '
        Me.txtTotalVentas.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotalVentas.Enabled = False
        Me.txtTotalVentas.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalVentas.Location = New System.Drawing.Point(381, 123)
        Me.txtTotalVentas.Name = "txtTotalVentas"
        Me.txtTotalVentas.ReadOnly = True
        Me.txtTotalVentas.Size = New System.Drawing.Size(195, 33)
        Me.txtTotalVentas.TabIndex = 43
        Me.txtTotalVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(167, 245)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(123, 21)
        Me.lblCliente.TabIndex = 42
        Me.lblCliente.Text = "Total Compras:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(167, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 21)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Fecha:"
        '
        'dtpFechaCaja
        '
        Me.dtpFechaCaja.CustomFormat = ""
        Me.dtpFechaCaja.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaCaja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCaja.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpFechaCaja.Location = New System.Drawing.Point(381, 24)
        Me.dtpFechaCaja.Name = "dtpFechaCaja"
        Me.dtpFechaCaja.Size = New System.Drawing.Size(195, 29)
        Me.dtpFechaCaja.TabIndex = 40
        Me.dtpFechaCaja.Value = New Date(2019, 12, 28, 0, 0, 0, 0)
        '
        'lblTipodeVenta
        '
        Me.lblTipodeVenta.AutoSize = True
        Me.lblTipodeVenta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipodeVenta.Location = New System.Drawing.Point(167, 129)
        Me.lblTipodeVenta.Name = "lblTipodeVenta"
        Me.lblTipodeVenta.Size = New System.Drawing.Size(107, 21)
        Me.lblTipodeVenta.TabIndex = 39
        Me.lblTipodeVenta.Text = "Total Ventas:"
        '
        'txtTotalCompras
        '
        Me.txtTotalCompras.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotalCompras.Enabled = False
        Me.txtTotalCompras.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCompras.Location = New System.Drawing.Point(381, 241)
        Me.txtTotalCompras.Name = "txtTotalCompras"
        Me.txtTotalCompras.ReadOnly = True
        Me.txtTotalCompras.Size = New System.Drawing.Size(195, 33)
        Me.txtTotalCompras.TabIndex = 38
        Me.txtTotalCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnExportarAExcel
        '
        Me.btnExportarAExcel.BackColor = System.Drawing.Color.Green
        Me.btnExportarAExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportarAExcel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportarAExcel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExportarAExcel.Image = Global.lacabania.My.Resources.Resources.excel_32px
        Me.btnExportarAExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarAExcel.Location = New System.Drawing.Point(868, 549)
        Me.btnExportarAExcel.Name = "btnExportarAExcel"
        Me.btnExportarAExcel.Size = New System.Drawing.Size(220, 53)
        Me.btnExportarAExcel.TabIndex = 48
        Me.btnExportarAExcel.Text = "EXPORTAR A EXCEL"
        Me.btnExportarAExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportarAExcel.UseVisualStyleBackColor = False
        '
        'dgvDatosParaExportar
        '
        Me.dgvDatosParaExportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatosParaExportar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha, Me.sdoInicial, Me.totalVentas, Me.totalVentasEfectivo, Me.totalVentasCC, Me.totalCompras, Me.totalComprasEfectivo, Me.totalComprasCC, Me.totalCobrosCC, Me.tbl_totalpagosprov, Me.saldoDia})
        Me.dgvDatosParaExportar.Location = New System.Drawing.Point(265, 570)
        Me.dgvDatosParaExportar.Name = "dgvDatosParaExportar"
        Me.dgvDatosParaExportar.Size = New System.Drawing.Size(545, 90)
        Me.dgvDatosParaExportar.TabIndex = 49
        Me.dgvDatosParaExportar.Visible = False
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        '
        'sdoInicial
        '
        Me.sdoInicial.HeaderText = "Saldo Inicial"
        Me.sdoInicial.Name = "sdoInicial"
        '
        'totalVentas
        '
        Me.totalVentas.HeaderText = "Total ventas"
        Me.totalVentas.Name = "totalVentas"
        '
        'totalVentasEfectivo
        '
        Me.totalVentasEfectivo.HeaderText = "Total ventas efectivo"
        Me.totalVentasEfectivo.Name = "totalVentasEfectivo"
        '
        'totalVentasCC
        '
        Me.totalVentasCC.HeaderText = "Total Ventas CC"
        Me.totalVentasCC.Name = "totalVentasCC"
        '
        'totalCompras
        '
        Me.totalCompras.HeaderText = "Total compras"
        Me.totalCompras.Name = "totalCompras"
        '
        'totalComprasEfectivo
        '
        Me.totalComprasEfectivo.HeaderText = "Total compras efectivo"
        Me.totalComprasEfectivo.Name = "totalComprasEfectivo"
        '
        'totalComprasCC
        '
        Me.totalComprasCC.HeaderText = "Total compras CC"
        Me.totalComprasCC.Name = "totalComprasCC"
        '
        'totalCobrosCC
        '
        Me.totalCobrosCC.HeaderText = "Total Cobros CC"
        Me.totalCobrosCC.Name = "totalCobrosCC"
        '
        'tbl_totalpagosprov
        '
        Me.tbl_totalpagosprov.HeaderText = "Total Pagos Proveedores"
        Me.tbl_totalpagosprov.Name = "tbl_totalpagosprov"
        '
        'saldoDia
        '
        Me.saldoDia.HeaderText = "Saldo del día"
        Me.saldoDia.Name = "saldoDia"
        '
        'frmCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1100, 650)
        Me.Controls.Add(Me.dgvDatosParaExportar)
        Me.Controls.Add(Me.btnExportarAExcel)
        Me.Controls.Add(Me.MenuTitulos)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCaja"
        Me.Text = "frmCaja"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvDatosParaExportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuTitulos As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblCliente As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFechaCaja As DateTimePicker
    Friend WithEvents lblTipodeVenta As Label
    Friend WithEvents txtTotalCompras As TextBox
    Friend WithEvents txtTotalVentas As TextBox
    Friend WithEvents lblSaldo As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDetalleVentas As Button
    Friend WithEvents btnDelleCompras As Button
    Friend WithEvents btnExportarAExcel As Button
    Friend WithEvents txtInicio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents dgvDatosParaExportar As DataGridView
    Friend WithEvents btnCCVentas As Button
    Friend WithEvents txtTotalCuenta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnEfectivoVentas As Button
    Friend WithEvents txtTotalEfectivo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCCCompras As Button
    Friend WithEvents txtTotalCuentaCompras As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnEfectivoCompras As Button
    Friend WithEvents txtTotalEfectivoCompras As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnDetallesCobrosCC As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTotalCobrosCC As TextBox
    Friend WithEvents btnDetalleProveedor As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTotalPagoProveedor As TextBox
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents sdoInicial As DataGridViewTextBoxColumn
    Friend WithEvents totalVentas As DataGridViewTextBoxColumn
    Friend WithEvents totalVentasEfectivo As DataGridViewTextBoxColumn
    Friend WithEvents totalVentasCC As DataGridViewTextBoxColumn
    Friend WithEvents totalCompras As DataGridViewTextBoxColumn
    Friend WithEvents totalComprasEfectivo As DataGridViewTextBoxColumn
    Friend WithEvents totalComprasCC As DataGridViewTextBoxColumn
    Friend WithEvents totalCobrosCC As DataGridViewTextBoxColumn
    Friend WithEvents tbl_totalpagosprov As DataGridViewTextBoxColumn
    Friend WithEvents saldoDia As DataGridViewTextBoxColumn
End Class
