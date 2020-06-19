Imports System.IO
Imports OfficeOpenXml

Public Class frmInformes
    Private Sub btnCrearInforme_Click(sender As Object, e As EventArgs) Handles btnCrearInforme.Click
        dgvInformes.DataSource = Nothing
        Dim fechaDesde, fechaHasta As String
        fechaDesde = Format(CDate(dtpFechaDesde.Value), "yyyy-MM-dd")
        fechaHasta = Format(CDate(dtpFechaHasta.Value), "yyyy-MM-dd")
        If rbCompras.Checked Then
            If rbTotales.Checked Then
                dgvInformes.Visible = True
                Dim datos As New Funciones()
                Dim ds = New DataSet()
                datos.GeneraInforme(fechaDesde, fechaHasta, "Compras", "Totales").Fill(ds, "Compras, ref_condicionVentaCompra")
                If ds.Tables("Compras, ref_condicionVentaCompra").Rows.Count > 0 Then
                    dgvInformes.DataSource = ds.Tables("Compras, ref_condicionVentaCompra")
                End If
            End If

            If rbDetallado.Checked Then
                dgvInformes.Visible = True
                Dim datos As New Funciones()
                Dim ds = New DataSet()
                datos.GeneraInforme(fechaDesde, fechaHasta, "Compras", "detalle").Fill(ds, "detalleCompra, compras")
                If ds.Tables("detalleCompra, compras").Rows.Count > 0 Then
                    dgvInformes.DataSource = ds.Tables("detalleCompra, compras")
                End If
            End If
        End If

        If rbVentas.Checked Then
            If rbTotales.Checked Then
                dgvInformes.Visible = True
                Dim datos As New Funciones()
                Dim ds = New DataSet()
                datos.GeneraInforme(fechaDesde, fechaHasta, "Ventas", "Totales").Fill(ds, "Ventas, ref_condicionVentaCompra")
                If ds.Tables("Ventas, ref_condicionVentaCompra").Rows.Count > 0 Then
                    dgvInformes.DataSource = ds.Tables("Ventas, ref_condicionVentaCompra")
                End If
            End If

            If rbDetallado.Checked Then
                dgvInformes.Visible = True
                Dim datos As New Funciones()
                Dim ds = New DataSet()
                datos.GeneraInforme(fechaDesde, fechaHasta, "Ventas", "detalle").Fill(ds, "detalleVenta, ventas")
                If ds.Tables("detalleVenta, ventas").Rows.Count > 0 Then
                    dgvInformes.DataSource = ds.Tables("detalleVenta, ventas")
                End If
            End If
        End If
    End Sub

    Private Sub rbCompras_CheckedChanged(sender As Object, e As EventArgs) Handles rbCompras.CheckedChanged
        gbAgrupados.Enabled = True
    End Sub

    Private Sub rbVentas_CheckedChanged(sender As Object, e As EventArgs) Handles rbVentas.CheckedChanged
        gbAgrupados.Enabled = True
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gbAgrupados.Enter

    End Sub

    Private Sub rbTotales_CheckedChanged(sender As Object, e As EventArgs) Handles rbTotales.CheckedChanged
        gbFechas.Enabled = True
        btnCrearInforme.Enabled = True
    End Sub

    Private Sub rbDetallado_CheckedChanged(sender As Object, e As EventArgs) Handles rbDetallado.CheckedChanged
        gbFechas.Enabled = True
        btnCrearInforme.Enabled = True
    End Sub

    Private Sub btnExportarAExcel_Click(sender As Object, e As EventArgs) Handles btnExportarAExcel.Click
        Dim exportar As New Funciones
        exportar.ExportaInformeAExcel(dgvInformes)
    End Sub
End Class