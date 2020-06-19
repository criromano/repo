<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformes
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuTitulos = New System.Windows.Forms.Panel()
        Me.lblInformes = New System.Windows.Forms.Label()
        Me.rbCompras = New System.Windows.Forms.RadioButton()
        Me.rbVentas = New System.Windows.Forms.RadioButton()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaDesde = New System.Windows.Forms.Label()
        Me.lblFechaHasta = New System.Windows.Forms.Label()
        Me.gbTipoDeInforme = New System.Windows.Forms.GroupBox()
        Me.gbFechas = New System.Windows.Forms.GroupBox()
        Me.dgvInformes = New System.Windows.Forms.DataGridView()
        Me.gbAgrupados = New System.Windows.Forms.GroupBox()
        Me.rbDetallado = New System.Windows.Forms.RadioButton()
        Me.rbTotales = New System.Windows.Forms.RadioButton()
        Me.btnExportarAExcel = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnCrearInforme = New System.Windows.Forms.Button()
        Me.gbTipoDeInforme.SuspendLayout()
        Me.gbFechas.SuspendLayout()
        CType(Me.dgvInformes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAgrupados.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 622)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 28)
        Me.Panel1.TabIndex = 33
        '
        'MenuTitulos
        '
        Me.MenuTitulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuTitulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuTitulos.ForeColor = System.Drawing.Color.Transparent
        Me.MenuTitulos.Location = New System.Drawing.Point(0, 0)
        Me.MenuTitulos.Name = "MenuTitulos"
        Me.MenuTitulos.Size = New System.Drawing.Size(1100, 33)
        Me.MenuTitulos.TabIndex = 32
        '
        'lblInformes
        '
        Me.lblInformes.AutoSize = True
        Me.lblInformes.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformes.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblInformes.Location = New System.Drawing.Point(530, 53)
        Me.lblInformes.Name = "lblInformes"
        Me.lblInformes.Size = New System.Drawing.Size(187, 47)
        Me.lblInformes.TabIndex = 34
        Me.lblInformes.Text = "INFORMES"
        '
        'rbCompras
        '
        Me.rbCompras.AutoSize = True
        Me.rbCompras.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCompras.Location = New System.Drawing.Point(21, 28)
        Me.rbCompras.Name = "rbCompras"
        Me.rbCompras.Size = New System.Drawing.Size(91, 25)
        Me.rbCompras.TabIndex = 35
        Me.rbCompras.TabStop = True
        Me.rbCompras.Text = "Compras"
        Me.rbCompras.UseVisualStyleBackColor = True
        '
        'rbVentas
        '
        Me.rbVentas.AutoSize = True
        Me.rbVentas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVentas.Location = New System.Drawing.Point(21, 59)
        Me.rbVentas.Name = "rbVentas"
        Me.rbVentas.Size = New System.Drawing.Size(74, 25)
        Me.rbVentas.TabIndex = 36
        Me.rbVentas.TabStop = True
        Me.rbVentas.Text = "Ventas"
        Me.rbVentas.UseVisualStyleBackColor = True
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesde.Location = New System.Drawing.Point(68, 24)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(123, 29)
        Me.dtpFechaDesde.TabIndex = 37
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHasta.Location = New System.Drawing.Point(68, 55)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(123, 29)
        Me.dtpFechaHasta.TabIndex = 38
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.AutoSize = True
        Me.lblFechaDesde.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaDesde.Location = New System.Drawing.Point(6, 30)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(56, 21)
        Me.lblFechaDesde.TabIndex = 39
        Me.lblFechaDesde.Text = "Desde:"
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.AutoSize = True
        Me.lblFechaHasta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaHasta.Location = New System.Drawing.Point(10, 61)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(52, 21)
        Me.lblFechaHasta.TabIndex = 40
        Me.lblFechaHasta.Text = "Hasta:"
        '
        'gbTipoDeInforme
        '
        Me.gbTipoDeInforme.Controls.Add(Me.rbCompras)
        Me.gbTipoDeInforme.Controls.Add(Me.rbVentas)
        Me.gbTipoDeInforme.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTipoDeInforme.Location = New System.Drawing.Point(236, 114)
        Me.gbTipoDeInforme.Name = "gbTipoDeInforme"
        Me.gbTipoDeInforme.Size = New System.Drawing.Size(155, 100)
        Me.gbTipoDeInforme.TabIndex = 41
        Me.gbTipoDeInforme.TabStop = False
        Me.gbTipoDeInforme.Text = "Tipo de informe"
        '
        'gbFechas
        '
        Me.gbFechas.Controls.Add(Me.lblFechaDesde)
        Me.gbFechas.Controls.Add(Me.dtpFechaDesde)
        Me.gbFechas.Controls.Add(Me.dtpFechaHasta)
        Me.gbFechas.Controls.Add(Me.lblFechaHasta)
        Me.gbFechas.Enabled = False
        Me.gbFechas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFechas.Location = New System.Drawing.Point(573, 114)
        Me.gbFechas.Name = "gbFechas"
        Me.gbFechas.Size = New System.Drawing.Size(217, 100)
        Me.gbFechas.TabIndex = 42
        Me.gbFechas.TabStop = False
        Me.gbFechas.Text = "Fechas"
        '
        'dgvInformes
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.dgvInformes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvInformes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvInformes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvInformes.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvInformes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvInformes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvInformes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInformes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvInformes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInformes.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvInformes.EnableHeadersVisualStyles = False
        Me.dgvInformes.Location = New System.Drawing.Point(236, 245)
        Me.dgvInformes.MultiSelect = False
        Me.dgvInformes.Name = "dgvInformes"
        Me.dgvInformes.ReadOnly = True
        Me.dgvInformes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInformes.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvInformes.RowHeadersVisible = False
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.dgvInformes.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvInformes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInformes.Size = New System.Drawing.Size(852, 295)
        Me.dgvInformes.TabIndex = 45
        Me.dgvInformes.Visible = False
        '
        'gbAgrupados
        '
        Me.gbAgrupados.Controls.Add(Me.rbDetallado)
        Me.gbAgrupados.Controls.Add(Me.rbTotales)
        Me.gbAgrupados.Enabled = False
        Me.gbAgrupados.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.gbAgrupados.Location = New System.Drawing.Point(397, 114)
        Me.gbAgrupados.Name = "gbAgrupados"
        Me.gbAgrupados.Size = New System.Drawing.Size(170, 100)
        Me.gbAgrupados.TabIndex = 46
        Me.gbAgrupados.TabStop = False
        Me.gbAgrupados.Text = "Agrupados por"
        '
        'rbDetallado
        '
        Me.rbDetallado.AutoSize = True
        Me.rbDetallado.Location = New System.Drawing.Point(6, 59)
        Me.rbDetallado.Name = "rbDetallado"
        Me.rbDetallado.Size = New System.Drawing.Size(94, 25)
        Me.rbDetallado.TabIndex = 1
        Me.rbDetallado.TabStop = True
        Me.rbDetallado.Text = "Detallado"
        Me.rbDetallado.UseVisualStyleBackColor = True
        '
        'rbTotales
        '
        Me.rbTotales.AutoSize = True
        Me.rbTotales.Location = New System.Drawing.Point(6, 28)
        Me.rbTotales.Name = "rbTotales"
        Me.rbTotales.Size = New System.Drawing.Size(75, 25)
        Me.rbTotales.TabIndex = 0
        Me.rbTotales.TabStop = True
        Me.rbTotales.Text = "Totales"
        Me.rbTotales.UseVisualStyleBackColor = True
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
        Me.btnExportarAExcel.TabIndex = 47
        Me.btnExportarAExcel.Text = "EXPORTAR A EXCEL"
        Me.btnExportarAExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportarAExcel.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Red
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancelar.Image = Global.lacabania.My.Resources.Resources.Cancelar_32px
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(944, 145)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(144, 53)
        Me.btnCancelar.TabIndex = 44
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnCrearInforme
        '
        Me.btnCrearInforme.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnCrearInforme.Enabled = False
        Me.btnCrearInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearInforme.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearInforme.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCrearInforme.Image = Global.lacabania.My.Resources.Resources.OK_32PX
        Me.btnCrearInforme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCrearInforme.Location = New System.Drawing.Point(794, 145)
        Me.btnCrearInforme.Name = "btnCrearInforme"
        Me.btnCrearInforme.Size = New System.Drawing.Size(144, 53)
        Me.btnCrearInforme.TabIndex = 43
        Me.btnCrearInforme.Text = "CREAR"
        Me.btnCrearInforme.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCrearInforme.UseVisualStyleBackColor = False
        '
        'frmInformes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1100, 650)
        Me.Controls.Add(Me.btnExportarAExcel)
        Me.Controls.Add(Me.gbAgrupados)
        Me.Controls.Add(Me.dgvInformes)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCrearInforme)
        Me.Controls.Add(Me.gbFechas)
        Me.Controls.Add(Me.gbTipoDeInforme)
        Me.Controls.Add(Me.lblInformes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuTitulos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInformes"
        Me.Text = "Informes"
        Me.gbTipoDeInforme.ResumeLayout(False)
        Me.gbTipoDeInforme.PerformLayout()
        Me.gbFechas.ResumeLayout(False)
        Me.gbFechas.PerformLayout()
        CType(Me.dgvInformes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAgrupados.ResumeLayout(False)
        Me.gbAgrupados.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuTitulos As Panel
    Friend WithEvents lblInformes As Label
    Friend WithEvents rbCompras As RadioButton
    Friend WithEvents rbVentas As RadioButton
    Friend WithEvents dtpFechaDesde As DateTimePicker
    Friend WithEvents dtpFechaHasta As DateTimePicker
    Friend WithEvents lblFechaDesde As Label
    Friend WithEvents lblFechaHasta As Label
    Friend WithEvents gbTipoDeInforme As GroupBox
    Friend WithEvents gbFechas As GroupBox
    Friend WithEvents btnCrearInforme As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents dgvInformes As DataGridView
    Friend WithEvents gbAgrupados As GroupBox
    Friend WithEvents rbDetallado As RadioButton
    Friend WithEvents rbTotales As RadioButton
    Friend WithEvents btnExportarAExcel As Button
End Class
