<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPadronClienteProveedor
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuTitulos = New System.Windows.Forms.Panel()
        Me.gbSeleccion = New System.Windows.Forms.GroupBox()
        Me.rbProveedores = New System.Windows.Forms.RadioButton()
        Me.rbClientes = New System.Windows.Forms.RadioButton()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dgvPadron = New System.Windows.Forms.DataGridView()
        Me.btnAltaPersona = New System.Windows.Forms.Button()
        Me.lblBusqueda = New System.Windows.Forms.Label()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.gbSeleccion.SuspendLayout()
        CType(Me.dgvPadron, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 608)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 42)
        Me.Panel1.TabIndex = 33
        '
        'MenuTitulos
        '
        Me.MenuTitulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuTitulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuTitulos.ForeColor = System.Drawing.Color.Transparent
        Me.MenuTitulos.Location = New System.Drawing.Point(0, 0)
        Me.MenuTitulos.Name = "MenuTitulos"
        Me.MenuTitulos.Size = New System.Drawing.Size(1100, 50)
        Me.MenuTitulos.TabIndex = 32
        '
        'gbSeleccion
        '
        Me.gbSeleccion.Controls.Add(Me.rbProveedores)
        Me.gbSeleccion.Controls.Add(Me.rbClientes)
        Me.gbSeleccion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSeleccion.Location = New System.Drawing.Point(91, 103)
        Me.gbSeleccion.Name = "gbSeleccion"
        Me.gbSeleccion.Size = New System.Drawing.Size(997, 63)
        Me.gbSeleccion.TabIndex = 34
        Me.gbSeleccion.TabStop = False
        Me.gbSeleccion.Text = "Desea ver el padrón de:"
        '
        'rbProveedores
        '
        Me.rbProveedores.AutoSize = True
        Me.rbProveedores.Location = New System.Drawing.Point(738, 28)
        Me.rbProveedores.Name = "rbProveedores"
        Me.rbProveedores.Size = New System.Drawing.Size(115, 25)
        Me.rbProveedores.TabIndex = 1
        Me.rbProveedores.TabStop = True
        Me.rbProveedores.Text = "Proveedores"
        Me.rbProveedores.UseVisualStyleBackColor = True
        '
        'rbClientes
        '
        Me.rbClientes.AutoSize = True
        Me.rbClientes.Location = New System.Drawing.Point(211, 28)
        Me.rbClientes.Name = "rbClientes"
        Me.rbClientes.Size = New System.Drawing.Size(83, 25)
        Me.rbClientes.TabIndex = 0
        Me.rbClientes.TabStop = True
        Me.rbClientes.Text = "Clientes"
        Me.rbClientes.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblTitulo.Location = New System.Drawing.Point(294, 53)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(658, 47)
        Me.lblTitulo.TabIndex = 35
        Me.lblTitulo.Text = "PADRÓN DE CLIENTES Y PROVEEEDORES"
        '
        'dgvPadron
        '
        Me.dgvPadron.AllowUserToAddRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPadron.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPadron.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPadron.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPadron.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvPadron.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPadron.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPadron.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPadron.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPadron.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPadron.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPadron.EnableHeadersVisualStyles = False
        Me.dgvPadron.Location = New System.Drawing.Point(91, 222)
        Me.dgvPadron.MultiSelect = False
        Me.dgvPadron.Name = "dgvPadron"
        Me.dgvPadron.ReadOnly = True
        Me.dgvPadron.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPadron.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPadron.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPadron.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPadron.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPadron.Size = New System.Drawing.Size(997, 380)
        Me.dgvPadron.TabIndex = 36
        '
        'btnAltaPersona
        '
        Me.btnAltaPersona.BackColor = System.Drawing.Color.Lime
        Me.btnAltaPersona.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnAltaPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAltaPersona.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltaPersona.Image = Global.lacabania.My.Resources.Resources.alta_persona_32px
        Me.btnAltaPersona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAltaPersona.Location = New System.Drawing.Point(713, 172)
        Me.btnAltaPersona.Name = "btnAltaPersona"
        Me.btnAltaPersona.Size = New System.Drawing.Size(375, 44)
        Me.btnAltaPersona.TabIndex = 37
        Me.btnAltaPersona.Text = "AGREGAR"
        Me.btnAltaPersona.UseVisualStyleBackColor = False
        '
        'lblBusqueda
        '
        Me.lblBusqueda.AutoSize = True
        Me.lblBusqueda.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusqueda.Location = New System.Drawing.Point(87, 184)
        Me.lblBusqueda.Name = "lblBusqueda"
        Me.lblBusqueda.Size = New System.Drawing.Size(81, 21)
        Me.lblBusqueda.TabIndex = 39
        Me.lblBusqueda.Text = "Búsqueda:"
        Me.lblBusqueda.Visible = False
        '
        'txtFiltro
        '
        Me.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFiltro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(174, 181)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(428, 29)
        Me.txtFiltro.TabIndex = 38
        Me.txtFiltro.Visible = False
        '
        'frmPadronClienteProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 650)
        Me.Controls.Add(Me.lblBusqueda)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.btnAltaPersona)
        Me.Controls.Add(Me.dgvPadron)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.gbSeleccion)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuTitulos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPadronClienteProveedor"
        Me.Text = "frmPadronClienteProveedor"
        Me.gbSeleccion.ResumeLayout(False)
        Me.gbSeleccion.PerformLayout()
        CType(Me.dgvPadron, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuTitulos As Panel
    Friend WithEvents gbSeleccion As GroupBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents rbProveedores As RadioButton
    Friend WithEvents rbClientes As RadioButton
    Friend WithEvents dgvPadron As DataGridView
    Friend WithEvents btnAltaPersona As Button
    Friend WithEvents lblBusqueda As Label
    Friend WithEvents txtFiltro As TextBox
End Class
