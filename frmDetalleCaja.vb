Public Class frmDetalleCaja
    Dim ds As New DataSet
    Dim funcion As New Funciones
    Private Sub frmDetalleCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '--------------------------------------------
        '--------------------------------------------
        'CONSULTA TABLA PERSONAS
        'TRAE LOS ULTIMOS 25
        '---------------------------------------------

        Dim consulta As String
        'Dim fila As Integer



        ds.Clear()
        If tbl_resumen.Rows.Count > 0 Then
            '   tbl_resumen.Rows.Clear()
        End If

        If lblDetalle.Text = "DETALLE VENTAS:" Then
            funcion.TraeResumenVC(lbl_fecha_sel.Text, "VENTAS").Fill(ds, "resumen")
        ElseIf lblDetalle.Text = "DETALLE VENTAS EFECTIVO:" Then
            funcion.TraeResumenVC(lbl_fecha_sel.Text, "VENTAS_EFECTIVO").Fill(ds, "resumen")
        ElseIf lblDetalle.Text = "DETALLE VENTAS C.C:" Then
            funcion.TraeResumenVC(lbl_fecha_sel.Text, "VENTAS_CC").Fill(ds, "resumen")
        ElseIf lblDetalle.Text = "DETALLE COMPRAS EFECTIVO:" Then
            funcion.TraeResumenVC(lbl_fecha_sel.Text, "COMPRAS_EFECTIVO").Fill(ds, "resumen")
        ElseIf lblDetalle.Text = "DETALLE COMPRAS C.C:" Then
            funcion.TraeResumenVC(lbl_fecha_sel.Text, "COMPRAS_CC").Fill(ds, "resumen")
        ElseIf lblDetalle.Text = "DETALLE COBROS C.C:" Then
            funcion.TraeResumenVC(lbl_fecha_sel.Text, "COBROS_CC").Fill(ds, "resumen")
        ElseIf lblDetalle.Text = "DETALLE PAGOS A PROVEEDORES:" Then
            funcion.TraeResumenVC(lbl_fecha_sel.Text, "PAGOS_PROVEEDOR").Fill(ds, "resumen")
        Else
            funcion.TraeResumenVC(lbl_fecha_sel.Text, "COMPRAS").Fill(ds, "resumen")
        End If

        If ds.Tables("resumen").Rows.Count > 0 Then
            tbl_resumen.DataSource = ds.Tables("resumen")


            Me.tbl_resumen.Columns("ClienteProveedor").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            Me.tbl_resumen.Columns("ClienteProveedor").FillWeight = 270
            Me.tbl_resumen.Columns("ClienteProveedor").Width = 270
            Me.tbl_resumen.Columns("ClienteProveedor").DisplayIndex = 0

            Me.tbl_resumen.Columns("ImporteTotal").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            Me.tbl_resumen.Columns("ImporteTotal").FillWeight = 205
            Me.tbl_resumen.Columns("ImporteTotal").Width = 205
            Me.tbl_resumen.Columns("ImporteTotal").DisplayIndex = 1


            Me.tbl_resumen.Columns("ImporteTotalCC").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            Me.tbl_resumen.Columns("ImporteTotalCC").FillWeight = 1
            Me.tbl_resumen.Columns("ImporteTotalCC").Width = 1
            Me.tbl_resumen.Columns("ImporteTotalCC").DisplayIndex = 2

            If lblDetalle.Text = "DETALLE VENTAS EFECTIVO:" Then

                'Dim cm As CurrencyManager
                'cm = Me.BindingContext(ds, "titulo")
                'cm.Position = -1


                Dim totalVenta As Double = 0
                Dim totalCC As Double = 0
                Dim totalEfectivo As Double = 0
                Dim nfila As Integer = 0

                For Each fila In tbl_resumen.Rows
                    If Not IsDBNull(fila.Cells(2).Value) Then
                        If (fila.Cells(2).Value <> 0) Then
                            'IMPORTE VENTA TOTAL - IMPORTE C.C

                            totalEfectivo = CDbl(fila.Cells(1).Value) - CDbl(fila.Cells(2).Value)
                            If (totalEfectivo > 0) Then
                                fila.Cells(1).Value = FormatNumber(totalEfectivo, 2)
                            Else

                                'tbl_resumen.CurrentCell = Nothing
                                'tbl_resumen.Rows(nfila).Visible = False

                                tbl_resumen.Rows(nfila).Cells(0).Value = ""
                                tbl_resumen.Rows(nfila).Cells(1).Value = 0
                                tbl_resumen.Rows(nfila).Cells(2).Value = 0
                            End If
                        End If
                    End If
                    nfila += 1
                Next


                For nfila = tbl_resumen.Rows.Count - 2 To 0 Step -1
                    If (tbl_resumen.Rows(nfila).Cells(1).Value = 0) Then

                        'If tbl_resumen.Rows(nfila).Selected = True Then
                        '    tbl_resumen.Rows(nfila).Selected = False
                        'End If
                        'Me.tbl_resumen.CurrentCell = Nothing
                        'tbl_resumen.Rows(nfila).Visible = False
                        tbl_resumen.Rows.Remove(tbl_resumen.Rows(nfila))

                        'tbl_resumen.Rows(nfila).Cells(0).ReadOnly = True
                        'tbl_resumen.Rows(nfila).Cells(1).ReadOnly = False
                        'tbl_resumen.Rows(nfila).Cells(2).ReadOnly = False

                        'tbl_resumen.Rows(nfila).Cells(0).Value = ""
                        'tbl_resumen.Rows(nfila).Cells(1).Value = ""
                        'tbl_resumen.Rows(nfila).Cells(2).Value = ""
                    End If
                Next
            End If

            'TamanoColumna()
            'dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        End If


        ''AGREGA LAS FILAS A LA TABLA
        'While fila < ds.Tables("resumen").Rows.Count

        'tbl_resumen.Rows.Add(ds.Tables("resumen").Rows(fila).Item("apellidoYNombre"), "$ " & ds.Tables("resumen").Rows(fila).Item("importeTotalDeVenta"))
        'fila += 1
        ' End While

    End Sub
End Class