<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEtiqueta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEtiqueta))
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuTitulos = New System.Windows.Forms.Panel()
        Me.txtIdVenta = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnLista = New System.Windows.Forms.Button()
        Me.btnUnoxUno = New System.Windows.Forms.Button()
        Me.txtCodigoBarras = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCodigoDeBarras = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tablaProductos = New System.Windows.Forms.DataGridView()
        Me.colNro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuTitulos.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.tablaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuTitulos
        '
        Me.MenuTitulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuTitulos.Controls.Add(Me.txtIdVenta)
        Me.MenuTitulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuTitulos.ForeColor = System.Drawing.Color.Transparent
        Me.MenuTitulos.Location = New System.Drawing.Point(0, 0)
        Me.MenuTitulos.Name = "MenuTitulos"
        Me.MenuTitulos.Size = New System.Drawing.Size(532, 25)
        Me.MenuTitulos.TabIndex = 27
        '
        'txtIdVenta
        '
        Me.txtIdVenta.Location = New System.Drawing.Point(436, 0)
        Me.txtIdVenta.Name = "txtIdVenta"
        Me.txtIdVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtIdVenta.TabIndex = 49
        Me.txtIdVenta.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.btnLista)
        Me.Panel3.Controls.Add(Me.btnUnoxUno)
        Me.Panel3.Controls.Add(Me.txtCodigoBarras)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.lblCodigoDeBarras)
        Me.Panel3.Controls.Add(Me.txtProducto)
        Me.Panel3.Controls.Add(Me.txtPrecio)
        Me.Panel3.Controls.Add(Me.lblPrecio)
        Me.Panel3.Controls.Add(Me.btnBuscarProducto)
        Me.Panel3.Controls.Add(Me.btnAgregar)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.tablaProductos)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(18, 31)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(514, 521)
        Me.Panel3.TabIndex = 28
        '
        'btnLista
        '
        Me.btnLista.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLista.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLista.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLista.Image = CType(resources.GetObject("btnLista.Image"), System.Drawing.Image)
        Me.btnLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLista.Location = New System.Drawing.Point(298, 478)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(196, 40)
        Me.btnLista.TabIndex = 5
        Me.btnLista.Text = "Imprimir Lista"
        Me.btnLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLista.UseVisualStyleBackColor = False
        '
        'btnUnoxUno
        '
        Me.btnUnoxUno.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnUnoxUno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnoxUno.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnoxUno.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUnoxUno.Image = CType(resources.GetObject("btnUnoxUno.Image"), System.Drawing.Image)
        Me.btnUnoxUno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUnoxUno.Location = New System.Drawing.Point(18, 478)
        Me.btnUnoxUno.Name = "btnUnoxUno"
        Me.btnUnoxUno.Size = New System.Drawing.Size(196, 40)
        Me.btnUnoxUno.TabIndex = 4
        Me.btnUnoxUno.Text = "Imprimir Uno X Uno"
        Me.btnUnoxUno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUnoxUno.UseVisualStyleBackColor = False
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoBarras.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoBarras.Location = New System.Drawing.Point(101, 20)
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Size = New System.Drawing.Size(272, 29)
        Me.txtCodigoBarras.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(-3, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(517, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "_________________________________________________________________________________" &
    "_____________________"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 21)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "$"
        '
        'lblCodigoDeBarras
        '
        Me.lblCodigoDeBarras.AutoSize = True
        Me.lblCodigoDeBarras.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCodigoDeBarras.Location = New System.Drawing.Point(14, 77)
        Me.lblCodigoDeBarras.Name = "lblCodigoDeBarras"
        Me.lblCodigoDeBarras.Size = New System.Drawing.Size(84, 21)
        Me.lblCodigoDeBarras.TabIndex = 56
        Me.lblCodigoDeBarras.Text = "Producto:"
        '
        'txtProducto
        '
        Me.txtProducto.Enabled = False
        Me.txtProducto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.Location = New System.Drawing.Point(101, 77)
        Me.txtProducto.MaxLength = 27
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(229, 29)
        Me.txtProducto.TabIndex = 1
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(101, 127)
        Me.txtPrecio.MaxLength = 10
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(229, 29)
        Me.txtPrecio.TabIndex = 2
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrecio.Location = New System.Drawing.Point(14, 127)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(62, 21)
        Me.lblPrecio.TabIndex = 54
        Me.lblPrecio.Text = "Precio:"
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.BackColor = System.Drawing.Color.Lime
        Me.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarProducto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarProducto.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBuscarProducto.Image = Global.lacabania.My.Resources.Resources.find_24px
        Me.btnBuscarProducto.Location = New System.Drawing.Point(379, 17)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(39, 32)
        Me.btnBuscarProducto.TabIndex = 52
        Me.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarProducto.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAgregar.Image = Global.lacabania.My.Resources.Resources.add_32px
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(379, 116)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(115, 40)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 21)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Búsqueda:"
        '
        'tablaProductos
        '
        Me.tablaProductos.AllowUserToAddRows = False
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tablaProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.tablaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tablaProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tablaProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.tablaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablaProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.tablaProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNro, Me.colProducto, Me.colPrecio, Me.colEliminar})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tablaProductos.DefaultCellStyle = DataGridViewCellStyle13
        Me.tablaProductos.EnableHeadersVisualStyles = False
        Me.tablaProductos.GridColor = System.Drawing.Color.SteelBlue
        Me.tablaProductos.Location = New System.Drawing.Point(14, 162)
        Me.tablaProductos.MultiSelect = False
        Me.tablaProductos.Name = "tablaProductos"
        Me.tablaProductos.ReadOnly = True
        Me.tablaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablaProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.tablaProductos.RowHeadersVisible = False
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        Me.tablaProductos.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.tablaProductos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tablaProductos.RowTemplate.Height = 35
        Me.tablaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablaProductos.Size = New System.Drawing.Size(480, 289)
        Me.tablaProductos.TabIndex = 48
        '
        'colNro
        '
        Me.colNro.FillWeight = 59.77061!
        Me.colNro.HeaderText = "#"
        Me.colNro.Name = "colNro"
        Me.colNro.ReadOnly = True
        '
        'colProducto
        '
        Me.colProducto.FillWeight = 166.1369!
        Me.colProducto.HeaderText = "Producto"
        Me.colProducto.Name = "colProducto"
        Me.colProducto.ReadOnly = True
        '
        'colPrecio
        '
        Me.colPrecio.FillWeight = 92.87422!
        Me.colPrecio.HeaderText = "Precio"
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.ReadOnly = True
        '
        'colEliminar
        '
        Me.colEliminar.FillWeight = 81.21828!
        Me.colEliminar.HeaderText = "Eliminar"
        Me.colEliminar.Name = "colEliminar"
        Me.colEliminar.ReadOnly = True
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
        'frmEtiqueta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 564)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.MenuTitulos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEtiqueta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir Tickets"
        Me.MenuTitulos.ResumeLayout(False)
        Me.MenuTitulos.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.tablaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuTitulos As Panel
    Friend WithEvents txtIdVenta As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents tablaProductos As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigoBarras As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnBuscarProducto As Button
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblCodigoDeBarras As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents btnLista As Button
    Friend WithEvents btnUnoxUno As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents colNro As DataGridViewTextBoxColumn
    Friend WithEvents colProducto As DataGridViewTextBoxColumn
    Friend WithEvents colPrecio As DataGridViewTextBoxColumn
    Friend WithEvents colEliminar As DataGridViewCheckBoxColumn
End Class
