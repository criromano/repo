<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEspecificacionesDeProductos
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
        Me.MenuTitulos = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelEspecideProductos = New System.Windows.Forms.Panel()
        Me.rbTipoTelefono = New System.Windows.Forms.RadioButton()
        Me.rbAgregarLocalildad = New System.Windows.Forms.RadioButton()
        Me.rbAgregarCalle = New System.Windows.Forms.RadioButton()
        Me.rbCondicionCompraVenta = New System.Windows.Forms.RadioButton()
        Me.lblActuales = New System.Windows.Forms.Label()
        Me.dgvEspecificaciones = New System.Windows.Forms.DataGridView()
        Me.rdbProductoSinCodigo = New System.Windows.Forms.RadioButton()
        Me.btnGuardarEspecificaciones = New System.Windows.Forms.Button()
        Me.rdbUnidadDeMedida = New System.Windows.Forms.RadioButton()
        Me.txtEspecificacion = New System.Windows.Forms.TextBox()
        Me.lblNuevoValor = New System.Windows.Forms.Label()
        Me.rdbRubroProducto = New System.Windows.Forms.RadioButton()
        Me.rdbTipoProducto = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdbAgregarTipoEnvase = New System.Windows.Forms.RadioButton()
        Me.rdbAgregaMarca = New System.Windows.Forms.RadioButton()
        Me.PanelEspecideProductos.SuspendLayout()
        CType(Me.dgvEspecificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MenuTitulos.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 608)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 42)
        Me.Panel1.TabIndex = 20
        '
        'PanelEspecideProductos
        '
        Me.PanelEspecideProductos.Controls.Add(Me.rbTipoTelefono)
        Me.PanelEspecideProductos.Controls.Add(Me.rbAgregarLocalildad)
        Me.PanelEspecideProductos.Controls.Add(Me.rbAgregarCalle)
        Me.PanelEspecideProductos.Controls.Add(Me.rbCondicionCompraVenta)
        Me.PanelEspecideProductos.Controls.Add(Me.lblActuales)
        Me.PanelEspecideProductos.Controls.Add(Me.dgvEspecificaciones)
        Me.PanelEspecideProductos.Controls.Add(Me.rdbProductoSinCodigo)
        Me.PanelEspecideProductos.Controls.Add(Me.btnGuardarEspecificaciones)
        Me.PanelEspecideProductos.Controls.Add(Me.rdbUnidadDeMedida)
        Me.PanelEspecideProductos.Controls.Add(Me.txtEspecificacion)
        Me.PanelEspecideProductos.Controls.Add(Me.lblNuevoValor)
        Me.PanelEspecideProductos.Controls.Add(Me.rdbRubroProducto)
        Me.PanelEspecideProductos.Controls.Add(Me.rdbTipoProducto)
        Me.PanelEspecideProductos.Controls.Add(Me.Label1)
        Me.PanelEspecideProductos.Controls.Add(Me.rdbAgregarTipoEnvase)
        Me.PanelEspecideProductos.Controls.Add(Me.rdbAgregaMarca)
        Me.PanelEspecideProductos.Location = New System.Drawing.Point(93, 56)
        Me.PanelEspecideProductos.Name = "PanelEspecideProductos"
        Me.PanelEspecideProductos.Size = New System.Drawing.Size(1004, 546)
        Me.PanelEspecideProductos.TabIndex = 0
        '
        'rbTipoTelefono
        '
        Me.rbTipoTelefono.AutoSize = True
        Me.rbTipoTelefono.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTipoTelefono.Location = New System.Drawing.Point(24, 460)
        Me.rbTipoTelefono.Name = "rbTipoTelefono"
        Me.rbTipoTelefono.Size = New System.Drawing.Size(221, 25)
        Me.rbTipoTelefono.TabIndex = 28
        Me.rbTipoTelefono.TabStop = True
        Me.rbTipoTelefono.Text = "Agregar Tipo de Teléfono"
        Me.rbTipoTelefono.UseVisualStyleBackColor = True
        '
        'rbAgregarLocalildad
        '
        Me.rbAgregarLocalildad.AutoSize = True
        Me.rbAgregarLocalildad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAgregarLocalildad.Location = New System.Drawing.Point(24, 420)
        Me.rbAgregarLocalildad.Name = "rbAgregarLocalildad"
        Me.rbAgregarLocalildad.Size = New System.Drawing.Size(167, 25)
        Me.rbAgregarLocalildad.TabIndex = 27
        Me.rbAgregarLocalildad.TabStop = True
        Me.rbAgregarLocalildad.Text = "Agregar Localidad"
        Me.rbAgregarLocalildad.UseVisualStyleBackColor = True
        '
        'rbAgregarCalle
        '
        Me.rbAgregarCalle.AutoSize = True
        Me.rbAgregarCalle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAgregarCalle.Location = New System.Drawing.Point(24, 380)
        Me.rbAgregarCalle.Name = "rbAgregarCalle"
        Me.rbAgregarCalle.Size = New System.Drawing.Size(131, 25)
        Me.rbAgregarCalle.TabIndex = 26
        Me.rbAgregarCalle.TabStop = True
        Me.rbAgregarCalle.Text = "Agregar Calle"
        Me.rbAgregarCalle.UseVisualStyleBackColor = True
        '
        'rbCondicionCompraVenta
        '
        Me.rbCondicionCompraVenta.AutoSize = True
        Me.rbCondicionCompraVenta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCondicionCompraVenta.Location = New System.Drawing.Point(24, 340)
        Me.rbCondicionCompraVenta.Name = "rbCondicionCompraVenta"
        Me.rbCondicionCompraVenta.Size = New System.Drawing.Size(309, 25)
        Me.rbCondicionCompraVenta.TabIndex = 25
        Me.rbCondicionCompraVenta.TabStop = True
        Me.rbCondicionCompraVenta.Text = "Agregar Condición de Compra/Venta"
        Me.rbCondicionCompraVenta.UseVisualStyleBackColor = True
        '
        'lblActuales
        '
        Me.lblActuales.AutoSize = True
        Me.lblActuales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActuales.Location = New System.Drawing.Point(561, 102)
        Me.lblActuales.Name = "lblActuales"
        Me.lblActuales.Size = New System.Drawing.Size(71, 21)
        Me.lblActuales.TabIndex = 24
        Me.lblActuales.Text = "Actuales:"
        Me.lblActuales.Visible = False
        '
        'dgvEspecificaciones
        '
        Me.dgvEspecificaciones.AllowUserToAddRows = False
        Me.dgvEspecificaciones.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvEspecificaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEspecificaciones.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvEspecificaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEspecificaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEspecificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEspecificaciones.ColumnHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEspecificaciones.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEspecificaciones.GridColor = System.Drawing.SystemColors.Control
        Me.dgvEspecificaciones.Location = New System.Drawing.Point(565, 126)
        Me.dgvEspecificaciones.Name = "dgvEspecificaciones"
        Me.dgvEspecificaciones.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvEspecificaciones.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvEspecificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEspecificaciones.Size = New System.Drawing.Size(280, 299)
        Me.dgvEspecificaciones.TabIndex = 23
        '
        'rdbProductoSinCodigo
        '
        Me.rdbProductoSinCodigo.AutoSize = True
        Me.rdbProductoSinCodigo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbProductoSinCodigo.Location = New System.Drawing.Point(24, 300)
        Me.rdbProductoSinCodigo.Name = "rdbProductoSinCodigo"
        Me.rdbProductoSinCodigo.Size = New System.Drawing.Size(324, 25)
        Me.rdbProductoSinCodigo.TabIndex = 22
        Me.rdbProductoSinCodigo.TabStop = True
        Me.rdbProductoSinCodigo.Text = "Agregar Producto Sin Código de Barras"
        Me.rdbProductoSinCodigo.UseVisualStyleBackColor = True
        '
        'btnGuardarEspecificaciones
        '
        Me.btnGuardarEspecificaciones.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarEspecificaciones.Enabled = False
        Me.btnGuardarEspecificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarEspecificaciones.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarEspecificaciones.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardarEspecificaciones.Image = Global.lacabania.My.Resources.Resources.save_32px
        Me.btnGuardarEspecificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarEspecificaciones.Location = New System.Drawing.Point(851, 490)
        Me.btnGuardarEspecificaciones.Name = "btnGuardarEspecificaciones"
        Me.btnGuardarEspecificaciones.Size = New System.Drawing.Size(144, 53)
        Me.btnGuardarEspecificaciones.TabIndex = 21
        Me.btnGuardarEspecificaciones.Text = "GUARDAR"
        Me.btnGuardarEspecificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardarEspecificaciones.UseVisualStyleBackColor = False
        '
        'rdbUnidadDeMedida
        '
        Me.rdbUnidadDeMedida.AutoSize = True
        Me.rdbUnidadDeMedida.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbUnidadDeMedida.Location = New System.Drawing.Point(24, 260)
        Me.rdbUnidadDeMedida.Name = "rdbUnidadDeMedida"
        Me.rdbUnidadDeMedida.Size = New System.Drawing.Size(234, 25)
        Me.rdbUnidadDeMedida.TabIndex = 6
        Me.rdbUnidadDeMedida.TabStop = True
        Me.rdbUnidadDeMedida.Text = "Agregar Unidad de Medida"
        Me.rdbUnidadDeMedida.UseVisualStyleBackColor = True
        '
        'txtEspecificacion
        '
        Me.txtEspecificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEspecificacion.Enabled = False
        Me.txtEspecificacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEspecificacion.Location = New System.Drawing.Point(565, 514)
        Me.txtEspecificacion.Name = "txtEspecificacion"
        Me.txtEspecificacion.Size = New System.Drawing.Size(280, 29)
        Me.txtEspecificacion.TabIndex = 5
        Me.txtEspecificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNuevoValor
        '
        Me.lblNuevoValor.AutoSize = True
        Me.lblNuevoValor.Enabled = False
        Me.lblNuevoValor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevoValor.Location = New System.Drawing.Point(561, 490)
        Me.lblNuevoValor.Name = "lblNuevoValor"
        Me.lblNuevoValor.Size = New System.Drawing.Size(170, 21)
        Me.lblNuevoValor.TabIndex = 0
        Me.lblNuevoValor.Text = "Ingrese Nuevo Valor:"
        Me.lblNuevoValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rdbRubroProducto
        '
        Me.rdbRubroProducto.AutoSize = True
        Me.rdbRubroProducto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbRubroProducto.Location = New System.Drawing.Point(24, 220)
        Me.rdbRubroProducto.Name = "rdbRubroProducto"
        Me.rdbRubroProducto.Size = New System.Drawing.Size(236, 25)
        Me.rdbRubroProducto.TabIndex = 4
        Me.rdbRubroProducto.TabStop = True
        Me.rdbRubroProducto.Text = "Agregar Rubro de Producto"
        Me.rdbRubroProducto.UseVisualStyleBackColor = True
        '
        'rdbTipoProducto
        '
        Me.rdbTipoProducto.AutoSize = True
        Me.rdbTipoProducto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbTipoProducto.Location = New System.Drawing.Point(24, 180)
        Me.rdbTipoProducto.Name = "rdbTipoProducto"
        Me.rdbTipoProducto.Size = New System.Drawing.Size(224, 25)
        Me.rdbTipoProducto.TabIndex = 3
        Me.rdbTipoProducto.TabStop = True
        Me.rdbTipoProducto.Text = "Agregar Tipo de Producto"
        Me.rdbTipoProducto.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(590, 47)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Alta de Especificaciones de Productos "
        '
        'rdbAgregarTipoEnvase
        '
        Me.rdbAgregarTipoEnvase.AutoSize = True
        Me.rdbAgregarTipoEnvase.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAgregarTipoEnvase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdbAgregarTipoEnvase.Location = New System.Drawing.Point(24, 140)
        Me.rdbAgregarTipoEnvase.Name = "rdbAgregarTipoEnvase"
        Me.rdbAgregarTipoEnvase.Size = New System.Drawing.Size(207, 25)
        Me.rdbAgregarTipoEnvase.TabIndex = 2
        Me.rdbAgregarTipoEnvase.TabStop = True
        Me.rdbAgregarTipoEnvase.Text = "Agregar Tipo de Envase"
        Me.rdbAgregarTipoEnvase.UseVisualStyleBackColor = True
        '
        'rdbAgregaMarca
        '
        Me.rdbAgregaMarca.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdbAgregaMarca.AutoSize = True
        Me.rdbAgregaMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rdbAgregaMarca.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAgregaMarca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdbAgregaMarca.Location = New System.Drawing.Point(24, 100)
        Me.rdbAgregaMarca.Name = "rdbAgregaMarca"
        Me.rdbAgregaMarca.Size = New System.Drawing.Size(140, 25)
        Me.rdbAgregaMarca.TabIndex = 1
        Me.rdbAgregaMarca.Text = "Agregar Marca"
        Me.rdbAgregaMarca.UseVisualStyleBackColor = True
        '
        'frmEspecificacionesDeProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1100, 650)
        Me.Controls.Add(Me.PanelEspecideProductos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuTitulos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEspecificacionesDeProductos"
        Me.Text = "Especificaciones De Productos"
        Me.PanelEspecideProductos.ResumeLayout(False)
        Me.PanelEspecideProductos.PerformLayout()
        CType(Me.dgvEspecificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuTitulos As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelEspecideProductos As Panel
    Friend WithEvents rdbAgregarTipoEnvase As RadioButton
    Friend WithEvents rdbAgregaMarca As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents rdbTipoProducto As RadioButton
    Friend WithEvents rdbRubroProducto As RadioButton
    Friend WithEvents txtEspecificacion As TextBox
    Friend WithEvents lblNuevoValor As Label
    Friend WithEvents btnGuardarEspecificaciones As Button
    Friend WithEvents rdbUnidadDeMedida As RadioButton
    Friend WithEvents rdbProductoSinCodigo As RadioButton
    Friend WithEvents dgvEspecificaciones As DataGridView
    Friend WithEvents lblActuales As Label
    Friend WithEvents rbTipoTelefono As RadioButton
    Friend WithEvents rbAgregarLocalildad As RadioButton
    Friend WithEvents rbAgregarCalle As RadioButton
    Friend WithEvents rbCondicionCompraVenta As RadioButton
End Class
