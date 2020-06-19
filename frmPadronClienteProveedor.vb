Public Class frmPadronClienteProveedor
    Dim funcion As New Funciones
    Dim ds As New DataSet
    Private Sub rbClientes_CheckedChanged(sender As Object, e As EventArgs) Handles rbClientes.CheckedChanged
        dgvPadron.DataSource = Nothing
        ds.Clear()
        lblBusqueda.Visible = True
        txtFiltro.Visible = True
        txtFiltro.Select()
        funcion.TraePadronClientes("").Fill(ds, "cliente, persona, domicilio, ref_calle")
        If ds.Tables("cliente, persona, domicilio, ref_calle").Rows.Count > 0 Then
            dgvPadron.DataSource = ds.Tables("cliente, persona, domicilio, ref_calle")
            columnasClientes()
            dgvPadron.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        End If
    End Sub

    Private Sub rbProveedores_CheckedChanged(sender As Object, e As EventArgs) Handles rbProveedores.CheckedChanged
        dgvPadron.DataSource = Nothing
        ds.Clear()
        lblBusqueda.Visible = True
        txtFiltro.Visible = True
        txtFiltro.Select()
        funcion.TraePadronProveedores("").Fill(ds, "proveedor, domicilio, ref_calle")
        If ds.Tables("proveedor, domicilio, ref_calle").Rows.Count > 0 Then
            dgvPadron.DataSource = ds.Tables("proveedor, domicilio, ref_calle")
            columnasProveedores()
            dgvPadron.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        End If
    End Sub

    Private Sub dgvPadron_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPadron.CellMouseEnter
        If e.RowIndex > -1 Then
            dgvPadron.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub btnAltaPersona_Click(sender As Object, e As EventArgs) Handles btnAltaPersona.Click
        Dim mostrarPanel As New Funciones
        mostrarPanel.AbrirFormEnPanel(New frmProveedorYCliente())
    End Sub

    Private Sub columnasClientes()
        Me.dgvPadron.Columns("ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvPadron.Columns("ID").FillWeight = 40
        Me.dgvPadron.Columns("ID").Width = 40
        Me.dgvPadron.Columns("ID").DisplayIndex = 0

        Me.dgvPadron.Columns("CUIL").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvPadron.Columns("CUIL").FillWeight = 100
        Me.dgvPadron.Columns("CUIL").Width = 100
        Me.dgvPadron.Columns("CUIL").DisplayIndex = 1

        Me.dgvPadron.Columns("Apellido y nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvPadron.Columns("Apellido y nombre").FillWeight = 250
        Me.dgvPadron.Columns("Apellido y nombre").Width = 250
        Me.dgvPadron.Columns("Apellido y nombre").DisplayIndex = 2

        Me.dgvPadron.Columns("Calle").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvPadron.Columns("Calle").FillWeight = 150
        Me.dgvPadron.Columns("Calle").Width = 150
        Me.dgvPadron.Columns("Calle").DisplayIndex = 3

        Me.dgvPadron.Columns("Nro.").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvPadron.Columns("Nro.").FillWeight = 60
        Me.dgvPadron.Columns("Nro.").Width = 60
        Me.dgvPadron.Columns("Nro.").DisplayIndex = 4

        Me.dgvPadron.Columns("Piso").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvPadron.Columns("Piso").FillWeight = 60
        Me.dgvPadron.Columns("Piso").Width = 60
        Me.dgvPadron.Columns("Piso").DisplayIndex = 5

        Me.dgvPadron.Columns("Dpto.").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvPadron.Columns("Dpto.").FillWeight = 60
        Me.dgvPadron.Columns("Dpto.").Width = 60
        Me.dgvPadron.Columns("Dpto.").DisplayIndex = 6

        Me.dgvPadron.Columns("E-mail").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvPadron.Columns("E-mail").FillWeight = 267
        Me.dgvPadron.Columns("E-mail").Width = 267
        Me.dgvPadron.Columns("E-mail").DisplayIndex = 7
    End Sub

    Private Sub columnasProveedores()
        Me.dgvPadron.Columns("ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvPadron.Columns("ID").FillWeight = 40
        Me.dgvPadron.Columns("ID").Width = 40
        Me.dgvPadron.Columns("ID").DisplayIndex = 0

        Me.dgvPadron.Columns("CUIT").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            Me.dgvPadron.Columns("CUIT").FillWeight = 100
            Me.dgvPadron.Columns("CUIT").Width = 100
            Me.dgvPadron.Columns("CUIT").DisplayIndex = 1

            Me.dgvPadron.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            Me.dgvPadron.Columns("Nombre").FillWeight = 250
            Me.dgvPadron.Columns("Nombre").Width = 250
        Me.dgvPadron.Columns("Nombre").DisplayIndex = 2

        Me.dgvPadron.Columns("Calle").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvPadron.Columns("Calle").FillWeight = 150
        Me.dgvPadron.Columns("Calle").Width = 150
        Me.dgvPadron.Columns("Calle").DisplayIndex = 3

        Me.dgvPadron.Columns("Nro.").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvPadron.Columns("Nro.").FillWeight = 60
        Me.dgvPadron.Columns("Nro.").Width = 60
        Me.dgvPadron.Columns("Nro.").DisplayIndex = 4

        Me.dgvPadron.Columns("Piso").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvPadron.Columns("Piso").FillWeight = 60
        Me.dgvPadron.Columns("Piso").Width = 60
        Me.dgvPadron.Columns("Piso").DisplayIndex = 5

        Me.dgvPadron.Columns("Dpto.").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvPadron.Columns("Dpto.").FillWeight = 60
        Me.dgvPadron.Columns("Dpto.").Width = 60
        Me.dgvPadron.Columns("Dpto.").DisplayIndex = 6

        Me.dgvPadron.Columns("E-mail").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.dgvPadron.Columns("E-mail").FillWeight = 267
        Me.dgvPadron.Columns("E-mail").Width = 267
        Me.dgvPadron.Columns("E-mail").DisplayIndex = 7
    End Sub

    'Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
    '    If Len(txtFiltro.Text) >= 0 Then
    '        If Not IsNumeric(txtFiltro.Text) Then 'Si no es numerico
    '            dgvPadron.DataSource = Nothing
    '            ds.Clear()
    '            funcion.TraePadronClientes(txtFiltro.Text).Fill(ds, "cliente, persona, domicilio, ref_calle")
    '            If ds.Tables("cliente, persona, domicilio, ref_calle").Rows.Count > 0 Then
    '                dgvPadron.DataSource = ds.Tables("cliente, persona, domicilio, ref_calle")
    '                columnas()
    '                dgvPadron.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub txtFiltro_KeyUp(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
    '    If Len(txtFiltro.Text) >= 0 Then
    '        If Not IsNumeric(txtFiltro.Text) Then 'Si no es numerico
    '            dgvPadron.DataSource = Nothing
    '            ds.Clear()
    '            funcion.TraePadronClientes(txtFiltro.Text).Fill(ds, "cliente, persona, domicilio, ref_calle")
    '            If ds.Tables("cliente, persona, domicilio, ref_calle").Rows.Count > 0 Then
    '                dgvPadron.DataSource = ds.Tables("cliente, persona, domicilio, ref_calle")
    '                columnas()
    '                dgvPadron.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If rbClientes.Checked Then
            If Len(txtFiltro.Text) >= 0 Then
                If Not IsNumeric(txtFiltro.Text) Then 'Si no es numerico
                    dgvPadron.DataSource = Nothing
                    ds.Clear()
                    funcion.TraePadronClientes(txtFiltro.Text).Fill(ds, "cliente, persona, domicilio, ref_calle")
                    If ds.Tables("cliente, persona, domicilio, ref_calle").Rows.Count > 0 Then
                        dgvPadron.DataSource = ds.Tables("cliente, persona, domicilio, ref_calle")
                        columnasClientes()
                        dgvPadron.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    End If
                End If
            End If
        End If

        If rbProveedores.Checked Then
            If Len(txtFiltro.Text) >= 0 Then
                If Not IsNumeric(txtFiltro.Text) Then 'Si no es numerico
                    dgvPadron.DataSource = Nothing
                    ds.Clear()
                    funcion.TraePadronProveedores(txtFiltro.Text).Fill(ds, "proveedor, domicilio, ref_calle")
                    If ds.Tables("proveedor, domicilio, ref_calle").Rows.Count > 0 Then
                        dgvPadron.DataSource = ds.Tables("proveedor, domicilio, ref_calle")
                        columnasProveedores()
                        dgvPadron.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub dgvPadron_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPadron.CellDoubleClick
        If rbClientes.Checked Then
            Dim tipo As String = "Cliente"
            Dim idCliente As Integer = dgvPadron.Rows(e.RowIndex).Cells(0).Value
            funcion.AbrirFormEnPanel(New frmProveedorYCliente(idCliente, tipo))
        End If

        If rbProveedores.Checked Then
            Dim tipo As String = "Proveedor"
            Dim idProveedor As Integer = dgvPadron.Rows(e.RowIndex).Cells(0).Value
            funcion.AbrirFormEnPanel(New frmProveedorYCliente(idProveedor, tipo))
        End If

    End Sub
End Class