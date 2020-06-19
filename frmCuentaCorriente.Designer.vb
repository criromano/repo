<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCuentaCorriente
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
		Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtFiltro = New System.Windows.Forms.TextBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.MenuTitulos = New System.Windows.Forms.Panel()
		Me.lblPadronProductos = New System.Windows.Forms.Label()
		Me.dgvCtaCte = New System.Windows.Forms.DataGridView()
		Me.dgvDetalleDeVentas = New System.Windows.Forms.DataGridView()
		Me.IdVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.fechaDeVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Pagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.btnConfirmar = New System.Windows.Forms.DataGridViewButtonColumn()
		Me.btnPagos = New System.Windows.Forms.DataGridViewButtonColumn()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txt_cont_key = New System.Windows.Forms.TextBox()
		CType(Me.dgvCtaCte, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvDetalleDeVentas, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(96, 133)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(81, 21)
		Me.Label1.TabIndex = 35
		Me.Label1.Text = "Búsqueda:"
		'
		'txtFiltro
		'
		Me.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.txtFiltro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFiltro.Location = New System.Drawing.Point(183, 130)
		Me.txtFiltro.Name = "txtFiltro"
		Me.txtFiltro.Size = New System.Drawing.Size(428, 29)
		Me.txtFiltro.TabIndex = 34
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.Khaki
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Panel1.Location = New System.Drawing.Point(0, 608)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(1100, 42)
		Me.Panel1.TabIndex = 37
		'
		'MenuTitulos
		'
		Me.MenuTitulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.MenuTitulos.Dock = System.Windows.Forms.DockStyle.Top
		Me.MenuTitulos.ForeColor = System.Drawing.Color.Transparent
		Me.MenuTitulos.Location = New System.Drawing.Point(0, 0)
		Me.MenuTitulos.Name = "MenuTitulos"
		Me.MenuTitulos.Size = New System.Drawing.Size(1100, 50)
		Me.MenuTitulos.TabIndex = 36
		'
		'lblPadronProductos
		'
		Me.lblPadronProductos.AutoSize = True
		Me.lblPadronProductos.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPadronProductos.ForeColor = System.Drawing.SystemColors.HotTrack
		Me.lblPadronProductos.Location = New System.Drawing.Point(442, 53)
		Me.lblPadronProductos.Name = "lblPadronProductos"
		Me.lblPadronProductos.Size = New System.Drawing.Size(533, 47)
		Me.lblPadronProductos.TabIndex = 38
		Me.lblPadronProductos.Text = "Padrón de CUENTAS CORRIENTES"
		'
		'dgvCtaCte
		'
		Me.dgvCtaCte.AllowUserToAddRows = False
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
		Me.dgvCtaCte.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvCtaCte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.dgvCtaCte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
		Me.dgvCtaCte.BackgroundColor = System.Drawing.SystemColors.Control
		Me.dgvCtaCte.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvCtaCte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
		Me.dgvCtaCte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
		DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvCtaCte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
		Me.dgvCtaCte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvCtaCte.DefaultCellStyle = DataGridViewCellStyle3
		Me.dgvCtaCte.EnableHeadersVisualStyles = False
		Me.dgvCtaCte.Location = New System.Drawing.Point(100, 188)
		Me.dgvCtaCte.Margin = New System.Windows.Forms.Padding(0)
		Me.dgvCtaCte.MultiSelect = False
		Me.dgvCtaCte.Name = "dgvCtaCte"
		Me.dgvCtaCte.ReadOnly = True
		Me.dgvCtaCte.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray
		DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvCtaCte.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
		Me.dgvCtaCte.RowHeadersVisible = False
		DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
		DataGridViewCellStyle5.ForeColor = System.Drawing.Color.MediumSeaGreen
		DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
		DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
		DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
		Me.dgvCtaCte.RowsDefaultCellStyle = DataGridViewCellStyle5
		Me.dgvCtaCte.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
		Me.dgvCtaCte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvCtaCte.Size = New System.Drawing.Size(399, 397)
		Me.dgvCtaCte.TabIndex = 39
		'
		'dgvDetalleDeVentas
		'
		Me.dgvDetalleDeVentas.AccessibleRole = System.Windows.Forms.AccessibleRole.None
		Me.dgvDetalleDeVentas.AllowUserToAddRows = False
		DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
		Me.dgvDetalleDeVentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
		Me.dgvDetalleDeVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
		Me.dgvDetalleDeVentas.BackgroundColor = System.Drawing.SystemColors.Control
		Me.dgvDetalleDeVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvDetalleDeVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
		Me.dgvDetalleDeVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSlateGray
		DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
		DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
		DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvDetalleDeVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
		Me.dgvDetalleDeVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvDetalleDeVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdVenta, Me.fechaDeVenta, Me.Importe, Me.Saldo, Me.Pagar, Me.btnConfirmar, Me.btnPagos})
		DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvDetalleDeVentas.DefaultCellStyle = DataGridViewCellStyle10
		Me.dgvDetalleDeVentas.EnableHeadersVisualStyles = False
		Me.dgvDetalleDeVentas.Location = New System.Drawing.Point(512, 188)
		Me.dgvDetalleDeVentas.Margin = New System.Windows.Forms.Padding(0)
		Me.dgvDetalleDeVentas.MultiSelect = False
		Me.dgvDetalleDeVentas.Name = "dgvDetalleDeVentas"
		Me.dgvDetalleDeVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle11.BackColor = System.Drawing.Color.DarkSlateGray
		DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvDetalleDeVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
		Me.dgvDetalleDeVentas.RowHeadersVisible = False
		DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
		DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
		DataGridViewCellStyle12.ForeColor = System.Drawing.Color.MediumSeaGreen
		DataGridViewCellStyle12.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
		DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Teal
		DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
		Me.dgvDetalleDeVentas.RowsDefaultCellStyle = DataGridViewCellStyle12
		Me.dgvDetalleDeVentas.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
		Me.dgvDetalleDeVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvDetalleDeVentas.Size = New System.Drawing.Size(579, 397)
		Me.dgvDetalleDeVentas.TabIndex = 40
		Me.dgvDetalleDeVentas.Visible = False
		'
		'IdVenta
		'
		Me.IdVenta.HeaderText = "ID"
		Me.IdVenta.Name = "IdVenta"
		Me.IdVenta.Width = 50
		'
		'fechaDeVenta
		'
		Me.fechaDeVenta.HeaderText = "Fecha"
		Me.fechaDeVenta.Name = "fechaDeVenta"
		Me.fechaDeVenta.Width = 79
		'
		'Importe
		'
		Me.Importe.HeaderText = "Importe"
		Me.Importe.Name = "Importe"
		Me.Importe.Width = 97
		'
		'Saldo
		'
		Me.Saldo.HeaderText = "Saldo"
		Me.Saldo.Name = "Saldo"
		Me.Saldo.Width = 76
		'
		'Pagar
		'
		Me.Pagar.HeaderText = "Pagar"
		Me.Pagar.Name = "Pagar"
		Me.Pagar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.Pagar.Width = 77
		'
		'btnConfirmar
		'
		DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle8.BackColor = System.Drawing.Color.Blue
		DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnConfirmar.DefaultCellStyle = DataGridViewCellStyle8
		Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnConfirmar.HeaderText = "Confirmar"
		Me.btnConfirmar.Name = "btnConfirmar"
		Me.btnConfirmar.Text = "OK"
		Me.btnConfirmar.UseColumnTextForButtonValue = True
		Me.btnConfirmar.Width = 93
		'
		'btnPagos
		'
		DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle9.BackColor = System.Drawing.Color.Blue
		DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnPagos.DefaultCellStyle = DataGridViewCellStyle9
		Me.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnPagos.HeaderText = "Pagos"
		Me.btnPagos.Name = "btnPagos"
		Me.btnPagos.Text = "DETALLE"
		Me.btnPagos.UseColumnTextForButtonValue = True
		Me.btnPagos.Width = 93
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
		Me.Label2.Location = New System.Drawing.Point(97, 162)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(161, 20)
		Me.Label2.TabIndex = 42
		Me.Label2.Text = "Resumen de Cuentas:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
		Me.Label3.Location = New System.Drawing.Point(769, 162)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(132, 20)
		Me.Label3.TabIndex = 43
		Me.Label3.Text = "Detalle de Venta:"
		Me.Label3.Visible = False
		'
		'txt_cont_key
		'
		Me.txt_cont_key.Location = New System.Drawing.Point(907, 130)
		Me.txt_cont_key.Name = "txt_cont_key"
		Me.txt_cont_key.Size = New System.Drawing.Size(100, 20)
		Me.txt_cont_key.TabIndex = 45
		Me.txt_cont_key.Visible = False
		'
		'frmCuentaCorriente
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1100, 650)
		Me.Controls.Add(Me.txt_cont_key)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.dgvDetalleDeVentas)
		Me.Controls.Add(Me.dgvCtaCte)
		Me.Controls.Add(Me.lblPadronProductos)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.MenuTitulos)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtFiltro)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "frmCuentaCorriente"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "frmCuentaCorriente"
		CType(Me.dgvCtaCte, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvDetalleDeVentas, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuTitulos As Panel
    Friend WithEvents lblPadronProductos As Label
    Friend WithEvents dgvCtaCte As DataGridView
    Friend WithEvents dgvDetalleDeVentas As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents IdVenta As DataGridViewTextBoxColumn
    Friend WithEvents fechaDeVenta As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents Pagar As DataGridViewTextBoxColumn
    Friend WithEvents btnConfirmar As DataGridViewButtonColumn
    Friend WithEvents btnPagos As DataGridViewButtonColumn
    Friend WithEvents txt_cont_key As TextBox
End Class
