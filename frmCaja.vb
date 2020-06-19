Public Class frmCaja
    Dim funcion As New Funciones

    Private Sub btnDetalleVentas_Click(sender As Object, e As EventArgs) Handles btnDetalleVentas.Click

        If txtTotalVentas.Text <> "0" Then
            Dim diasel As String
            diasel = dtpFechaCaja.Value.ToString("yyyy-MM-dd")

            frmDetalleCaja.lbl_fecha_sel.Text = diasel
            frmDetalleCaja.lblFecha_busca.Text = dtpFechaCaja.Value.ToString("dd/MM/yyyy")
            frmDetalleCaja.txtTotal.Text = txtTotalVentas.Text
            frmDetalleCaja.lblDetalle.Text = "DETALLE VENTAS:"

            frmDetalleCaja.ShowDialog()
        End If
    End Sub

    Private Sub dtpFechaCaja_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaCaja.ValueChanged
        Dim diasel As String

        diasel = dtpFechaCaja.Value.ToString("yyyy-MM-dd") 'toma fecha del almanaque

    End Sub

    Private Sub btnDelleCompras_Click(sender As Object, e As EventArgs) Handles btnDelleCompras.Click
        If txtTotalCompras.Text <> "0" Then
            Dim diasel As String
            diasel = dtpFechaCaja.Value.ToString("yyyy-MM-dd")

            frmDetalleCaja.lbl_fecha_sel.Text = diasel
            frmDetalleCaja.lblFecha_busca.Text = dtpFechaCaja.Value.ToString("dd/MM/yyyy")
            frmDetalleCaja.txtTotal.Text = txtTotalCompras.Text
            frmDetalleCaja.lblDetalle.Text = "DETALLE COMPRAS:"

            frmDetalleCaja.ShowDialog()
        End If
    End Sub

    Private Sub frmCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFechaCaja.Value = Date.Now
    End Sub

    Private Sub dtpFechaCaja_TextChanged(sender As Object, e As EventArgs) Handles dtpFechaCaja.TextChanged
        Dim diasel As String

        diasel = dtpFechaCaja.Value.ToString("yyyy-MM-dd") 'toma fecha del almanaque

        Dim abrirForm As New Funciones
        Dim posi As Integer = 0

        '---------------------------------------------
        'LLAMA A FUNCION PARA BUSCAR LOS TOTALES
        'RECORRE EL ARRAY CON LOS RESULTADOS
        For Each i As Double In abrirForm.ResumenDia(diasel)
            If posi = 0 Then
                txtInicio.Text = i
            ElseIf posi = 1 Then
                If diasel = Date.Now.ToString("yyyy-MM-dd") Then
                    If i = 1 Then 'si ya esta cargada 
                        txtInicio.ReadOnly = True
                        btnGuardar.Visible = False
                    Else
                        txtInicio.ReadOnly = False
                        btnGuardar.Visible = True
                        txtInicio.Text = ""
                        txtInicio.Focus()
                    End If
                Else
                    txtInicio.ReadOnly = True
                    btnGuardar.Visible = False
                End If
            ElseIf posi = 2 Then
                txtTotalVentas.Text = i
            ElseIf posi = 3 Then
                txtTotalEfectivo.Text = i
            ElseIf posi = 4 Then
                txtTotalCuenta.Text = i
            ElseIf posi = 5 Then
                txtTotalCompras.Text = i
            ElseIf posi = 6 Then
                txtTotalEfectivoCompras.Text = i
            ElseIf posi = 7 Then
                txtTotalCuentaCompras.Text = i
            ElseIf posi = 8 Then
                txtTotalCobrosCC.Text = i
            ElseIf posi = 9 Then
                txtTotalPagoProveedor.Text = i
            Else
                txtSaldo.Text = i
                If i > 0 Then
                    lblSaldo.ForeColor = Color.LimeGreen
                    txtSaldo.ForeColor = Color.LimeGreen
                Else
                    lblSaldo.ForeColor = Color.Red
                    txtSaldo.ForeColor = Color.Red
                End If
            End If
            posi += 1
        Next
    End Sub

    Private Sub txtInicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInicio.KeyPress
        '------------------------------------------------
        'SOLO NUMEROS
        '------------------------------------------------
        Dim dig As Integer = Len(txtInicio.Text & e.KeyChar)
        Dim a, esDecimal, NumDecimales As Integer
        Dim esDec As Boolean
        Dim coma As Char

        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "," Or e.KeyChar = "." Then
            If e.KeyChar = "." Then
                e.KeyChar = ","
            End If
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True 'deshabilita la tecla
        End If

        If dig = 1 And (e.KeyChar = "," Or e.KeyChar = ".") Then 'si dig=1 y es un punto rechaza 
            If e.KeyChar = "." Then
                e.KeyChar = ","
            End If
            e.Handled = True
            'Return a
        End If
        If txtInicio.SelectedText = "" Then
            ' aqui se hace el for para controlar que el numero sea de dos digitos - contadose a partir del punto decimal.
            For a = 0 To dig - 1
                Dim car As String = CStr(txtInicio.Text & e.KeyChar)
                If car.Substring(a, 1) = "," Then
                    esDecimal = esDecimal + 1
                    esDec = True
                End If
                If esDec = True Then
                    NumDecimales = NumDecimales + 1
                End If
                ' aqui se controla los digitos a partir del punto numdecimales = 4 si es de dos decimales  
                If NumDecimales >= 4 Or esDecimal >= 2 Then
                    e.Handled = True
                End If
                If e.KeyChar.IsControl(e.KeyChar) Then
                    e.Handled = False
                End If
            Next
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Len(txtInicio.Text) > 0 Then
            If MsgBox("¿Esta Seguro?", vbYesNo + vbQuestion) = vbYes Then
                Dim registraCaja As New Funciones
                Dim Caja As New Caja
                Caja.Fecha1 = dtpFechaCaja.Value
                Caja.SaldoInicial1 = txtInicio.Text
                Caja.SaldoFinal1 = 0

                '--------------------------------------
                'FUNCION ALTA INICIO CAJA
                registraCaja.registrarInicioCaja(Caja)

                Dim unomas As Date = Date.Now.AddDays(1)

                dtpFechaCaja.Value = unomas.ToString("yyyy-MM-dd")

                dtpFechaCaja.Value = Date.Now.ToString("yyyy-MM-dd")

                txtInicio.ReadOnly = True
                btnGuardar.Visible = False
            End If
        Else
            txtInicio.Focus()
        End If
    End Sub

    Private Sub btnExportarAExcel_Click(sender As Object, e As EventArgs) Handles btnExportarAExcel.Click
        dgvDatosParaExportar.Rows.Clear()
        dgvDatosParaExportar.Rows.Add(dtpFechaCaja.Value, txtInicio.Text, txtTotalVentas.Text, txtTotalEfectivo.Text, txtTotalCuenta.Text, txtTotalCompras.Text, txtTotalEfectivoCompras.Text, txtTotalCuentaCompras.Text, txtTotalCobrosCC.Text, txtTotalPagoProveedor.Text, txtSaldo.Text)
        funcion.ExportaInformeAExcel(dgvDatosParaExportar)
    End Sub

    Private Sub btnEfectivoVentas_Click(sender As Object, e As EventArgs) Handles btnEfectivoVentas.Click
        If txtTotalEfectivo.Text <> "0" Then
            Dim diasel As String
            diasel = dtpFechaCaja.Value.ToString("yyyy-MM-dd")

            frmDetalleCaja.lbl_fecha_sel.Text = diasel
            frmDetalleCaja.lblFecha_busca.Text = dtpFechaCaja.Value.ToString("dd/MM/yyyy")
            frmDetalleCaja.txtTotal.Text = txtTotalEfectivo.Text
            frmDetalleCaja.lblDetalle.Text = "DETALLE VENTAS EFECTIVO:"

            frmDetalleCaja.ShowDialog()
        End If
    End Sub

    Private Sub btnCCVentas_Click(sender As Object, e As EventArgs) Handles btnCCVentas.Click
        If txtTotalCuenta.Text <> "0" Then
            Dim diasel As String
            diasel = dtpFechaCaja.Value.ToString("yyyy-MM-dd")

            frmDetalleCaja.lbl_fecha_sel.Text = diasel
            frmDetalleCaja.lblFecha_busca.Text = dtpFechaCaja.Value.ToString("dd/MM/yyyy")
            frmDetalleCaja.txtTotal.Text = txtTotalCuenta.Text
            frmDetalleCaja.lblDetalle.Text = "DETALLE VENTAS C.C:"

            frmDetalleCaja.ShowDialog()
        End If
    End Sub

    Private Sub btnEfectivoCompras_Click(sender As Object, e As EventArgs) Handles btnEfectivoCompras.Click
        If txtTotalCompras.Text <> "0" Then
            Dim diasel As String
            diasel = dtpFechaCaja.Value.ToString("yyyy-MM-dd")

            frmDetalleCaja.lbl_fecha_sel.Text = diasel
            frmDetalleCaja.lblFecha_busca.Text = dtpFechaCaja.Value.ToString("dd/MM/yyyy")
            frmDetalleCaja.txtTotal.Text = txtTotalEfectivoCompras.Text
            frmDetalleCaja.lblDetalle.Text = "DETALLE COMPRAS EFECTIVO:"

            frmDetalleCaja.ShowDialog()
        End If
    End Sub

    Private Sub btnCCCompras_Click(sender As Object, e As EventArgs) Handles btnCCCompras.Click
        If txtTotalCompras.Text <> "0" Then
            Dim diasel As String
            diasel = dtpFechaCaja.Value.ToString("yyyy-MM-dd")

            frmDetalleCaja.lbl_fecha_sel.Text = diasel
            frmDetalleCaja.lblFecha_busca.Text = dtpFechaCaja.Value.ToString("dd/MM/yyyy")
            frmDetalleCaja.txtTotal.Text = txtTotalCuentaCompras.Text
            frmDetalleCaja.lblDetalle.Text = "DETALLE COMPRAS C.C:"

            frmDetalleCaja.ShowDialog()
        End If
    End Sub

    Private Sub btnDetallesCobrosCC_Click(sender As Object, e As EventArgs) Handles btnDetallesCobrosCC.Click
        If txtTotalCobrosCC.Text <> "0" Then
            Dim diasel As String
            diasel = dtpFechaCaja.Value.ToString("yyyy-MM-dd")

            frmDetalleCaja.lbl_fecha_sel.Text = diasel
            frmDetalleCaja.lblFecha_busca.Text = dtpFechaCaja.Value.ToString("dd/MM/yyyy")
            frmDetalleCaja.txtTotal.Text = txtTotalCobrosCC.Text
            frmDetalleCaja.lblDetalle.Text = "DETALLE COBROS C.C:"

            frmDetalleCaja.ShowDialog()
        End If
    End Sub

    Private Sub btnDetalleProveedor_Click(sender As Object, e As EventArgs) Handles btnDetalleProveedor.Click
        If txtTotalPagoProveedor.Text <> "0" Then
            Dim diasel As String
            diasel = dtpFechaCaja.Value.ToString("yyyy-MM-dd")

            frmDetalleCaja.lbl_fecha_sel.Text = diasel
            frmDetalleCaja.lblFecha_busca.Text = dtpFechaCaja.Value.ToString("dd/MM/yyyy")
            frmDetalleCaja.txtTotal.Text = txtTotalPagoProveedor.Text
            frmDetalleCaja.lblDetalle.Text = "DETALLE PAGOS A PROVEEDORES:"

            frmDetalleCaja.ShowDialog()
        End If
    End Sub
End Class