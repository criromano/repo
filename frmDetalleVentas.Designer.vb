<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDetalleVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleVentas))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_fecha_sel = New System.Windows.Forms.Label()
        Me.tbl_Detalle_Ventas = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDetalle = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTipodeVenta = New System.Windows.Forms.Label()
        Me.MenuTitulos = New System.Windows.Forms.Panel()
        Me.txtIdVenta = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        CType(Me.tbl_Detalle_Ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuTitulos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.lbl_fecha_sel)
        Me.Panel3.Controls.Add(Me.tbl_Detalle_Ventas)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.lblDetalle)
        Me.Panel3.Controls.Add(Me.txtTotal)
        Me.Panel3.Controls.Add(Me.lblTipodeVenta)
        Me.Panel3.Location = New System.Drawing.Point(18, 31)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(518, 520)
        Me.Panel3.TabIndex = 25
        '
        'lbl_fecha_sel
        '
        Me.lbl_fecha_sel.AutoSize = True
        Me.lbl_fecha_sel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha_sel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_fecha_sel.Location = New System.Drawing.Point(355, 25)
        Me.lbl_fecha_sel.Name = "lbl_fecha_sel"
        Me.lbl_fecha_sel.Size = New System.Drawing.Size(139, 32)
        Me.lbl_fecha_sel.TabIndex = 50
        Me.lbl_fecha_sel.Text = "2019-12-01"
        '
        'tbl_Detalle_Ventas
        '
        Me.tbl_Detalle_Ventas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl_Detalle_Ventas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.tbl_Detalle_Ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tbl_Detalle_Ventas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbl_Detalle_Ventas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.tbl_Detalle_Ventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tbl_Detalle_Ventas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.tbl_Detalle_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tbl_Detalle_Ventas.DefaultCellStyle = DataGridViewCellStyle3
        Me.tbl_Detalle_Ventas.EnableHeadersVisualStyles = False
        Me.tbl_Detalle_Ventas.GridColor = System.Drawing.Color.SteelBlue
        Me.tbl_Detalle_Ventas.Location = New System.Drawing.Point(14, 60)
        Me.tbl_Detalle_Ventas.MultiSelect = False
        Me.tbl_Detalle_Ventas.Name = "tbl_Detalle_Ventas"
        Me.tbl_Detalle_Ventas.ReadOnly = True
        Me.tbl_Detalle_Ventas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tbl_Detalle_Ventas.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.tbl_Detalle_Ventas.RowHeadersVisible = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.tbl_Detalle_Ventas.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.tbl_Detalle_Ventas.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl_Detalle_Ventas.RowTemplate.Height = 35
        Me.tbl_Detalle_Ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tbl_Detalle_Ventas.Size = New System.Drawing.Size(480, 391)
        Me.tbl_Detalle_Ventas.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(3, 461)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(502, 21)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "---------------------------------------------------------------------------------" &
    "-"
        '
        'lblDetalle
        '
        Me.lblDetalle.AutoSize = True
        Me.lblDetalle.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Italic)
        Me.lblDetalle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblDetalle.Location = New System.Drawing.Point(6, 10)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(291, 47)
        Me.lblDetalle.TabIndex = 44
        Me.lblDetalle.Text = "DETALLE VENTAS:"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(323, 485)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(171, 33)
        Me.txtTotal.TabIndex = 43
        '
        'lblTipodeVenta
        '
        Me.lblTipodeVenta.AutoSize = True
        Me.lblTipodeVenta.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTipodeVenta.Location = New System.Drawing.Point(157, 488)
        Me.lblTipodeVenta.Name = "lblTipodeVenta"
        Me.lblTipodeVenta.Size = New System.Drawing.Size(164, 25)
        Me.lblTipodeVenta.TabIndex = 39
        Me.lblTipodeVenta.Text = "Total Importe:   $"
        '
        'MenuTitulos
        '
        Me.MenuTitulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuTitulos.Controls.Add(Me.txtIdVenta)
        Me.MenuTitulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuTitulos.ForeColor = System.Drawing.Color.Transparent
        Me.MenuTitulos.Location = New System.Drawing.Point(0, 0)
        Me.MenuTitulos.Name = "MenuTitulos"
        Me.MenuTitulos.Size = New System.Drawing.Size(571, 25)
        Me.MenuTitulos.TabIndex = 26
        '
        'txtIdVenta
        '
        Me.txtIdVenta.Location = New System.Drawing.Point(436, 0)
        Me.txtIdVenta.Name = "txtIdVenta"
        Me.txtIdVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtIdVenta.TabIndex = 49
        Me.txtIdVenta.Visible = False
        '
        'frmDetalleVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(571, 591)
        Me.Controls.Add(Me.MenuTitulos)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDetalleVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle De Ventas"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.tbl_Detalle_Ventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuTitulos.ResumeLayout(False)
        Me.MenuTitulos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
	Friend WithEvents tbl_Detalle_Ventas As DataGridView
	Friend WithEvents Label4 As Label
	Friend WithEvents lblDetalle As Label
	Friend WithEvents txtTotal As TextBox
	Friend WithEvents lblTipodeVenta As Label
	Friend WithEvents MenuTitulos As Panel
	Friend WithEvents txtIdVenta As TextBox
	Friend WithEvents lbl_fecha_sel As Label
End Class
