Public Class frmDetalleDePagos
	Dim ds As New DataSet
	Dim funcion As New Funciones
	Private Sub frmDetalleDePagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'--------------------------------------------
		'--------------------------------------------
		'CONSULTA TABLA VENTAS
		'TRAE RESUMEN DE VENTAS POR ID DE VENTAS
		'---------------------------------------------

		Dim consulta As String
		Dim fila As Integer

		'Dim idventa As Integer = 1
		ds.Clear()
		If tbl_Detalle_Pagos.Rows.Count > 0 Then
			'   tbl_resumen.Rows.Clear()
		End If

		If lblDetalle.Text = "DETALLE DE PAGOS:" Then

			funcion.TraeDetalledePagospoId(Format(CInt(txtIdVenta.Text))).Fill(ds, "resumen")

			If ds.Tables("resumen").Rows.Count > 0 Then
				tbl_Detalle_Pagos.DataSource = ds.Tables("resumen")



				Me.tbl_Detalle_Pagos.Columns("Fecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
				Me.tbl_Detalle_Pagos.Columns("Fecha").FillWeight = 270
				Me.tbl_Detalle_Pagos.Columns("Fecha").Width = 235
				Me.tbl_Detalle_Pagos.Columns("Fecha").DisplayIndex = 0
				Me.tbl_Detalle_Pagos.Columns("Fecha").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft

				Me.tbl_Detalle_Pagos.Columns("Importe").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
				Me.tbl_Detalle_Pagos.Columns("Importe").FillWeight = 270
				Me.tbl_Detalle_Pagos.Columns("Importe").Width = 242
				Me.tbl_Detalle_Pagos.Columns("Importe").DisplayIndex = 1
				Me.tbl_Detalle_Pagos.Columns("Importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

				Me.tbl_Detalle_Pagos.Columns("idPago").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
				Me.tbl_Detalle_Pagos.Columns("idPago").FillWeight = 270
				Me.tbl_Detalle_Pagos.Columns("idPago").Width = 250
				Me.tbl_Detalle_Pagos.Columns("idPago").DisplayIndex = 2
				Me.tbl_Detalle_Pagos.Columns("idPago").Visible = False

				Me.tbl_Detalle_Pagos.Columns("idVenta").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
				Me.tbl_Detalle_Pagos.Columns("idVenta").FillWeight = 270
				Me.tbl_Detalle_Pagos.Columns("idVenta").Width = 100
				Me.tbl_Detalle_Pagos.Columns("idVenta").DisplayIndex = 3
				Me.tbl_Detalle_Pagos.Columns("idVenta").Visible = False
				'Me.tbl_Detalle_Ventas.Columns("fechaVenta").Visible = False

				'Me.lbl_fecha_sel.Text = tbl_Detalle_Ventas.Rows(0).Cells(4).Value

			End If
		End If

		'fila = 0
		Dim acumula As Double = 0
		For i = 0 To tbl_Detalle_Pagos.Rows.Count - 1
			acumula = acumula + CDbl(tbl_Detalle_Pagos.Rows(i).Cells("importe").Value)
		Next
		txtTotal.Text = acumula

	End Sub


End Class