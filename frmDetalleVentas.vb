Public Class frmDetalleVentas
	Dim ds As New DataSet
	Dim funcion As New Funciones
	Dim idVentaab As Integer

	Private Sub frmDetalleVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load




	End Sub

	Private Sub frmDetalleVentas_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
		'--------------------------------------------
		'--------------------------------------------
		'CONSULTA TABLA VENTAS
		'TRAE RESUMEN DE VENTAS POR ID DE VENTAS
		'---------------------------------------------

		Dim fila As Integer
		Me.lbl_fecha_sel.Text = ""

		ds.Clear()
		If tbl_Detalle_Ventas.Rows.Count > 0 Then
			'   tbl_resumen.Rows.Clear()
		End If

		If lblDetalle.Text = "DETALLE VENTAS:" Then
			funcion.TraeDetalledeVentasPorId(Format(CInt(txtIdVenta.Text))).Fill(ds, "resumen")

			If ds.Tables("resumen").Rows.Count > 0 Then
				tbl_Detalle_Ventas.DataSource = ds.Tables("resumen")



				Me.tbl_Detalle_Ventas.Columns("idVenta").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
				Me.tbl_Detalle_Ventas.Columns("idVenta").FillWeight = 270
				Me.tbl_Detalle_Ventas.Columns("idVenta").Width = 70
				Me.tbl_Detalle_Ventas.Columns("idVenta").DisplayIndex = 0
				Me.tbl_Detalle_Ventas.Columns("idVenta").Visible = False

				Me.tbl_Detalle_Ventas.Columns("Cant").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
				Me.tbl_Detalle_Ventas.Columns("Cant").FillWeight = 270
				Me.tbl_Detalle_Ventas.Columns("Cant").Width = 50
				Me.tbl_Detalle_Ventas.Columns("Cant").DisplayIndex = 1

				Me.tbl_Detalle_Ventas.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
				Me.tbl_Detalle_Ventas.Columns("Nombre").FillWeight = 270
				Me.tbl_Detalle_Ventas.Columns("Nombre").Width = 130
				Me.tbl_Detalle_Ventas.Columns("Nombre").DisplayIndex = 2

				Me.tbl_Detalle_Ventas.Columns("Envase").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
				Me.tbl_Detalle_Ventas.Columns("Envase").FillWeight = 270
				Me.tbl_Detalle_Ventas.Columns("Envase").Width = 130
				Me.tbl_Detalle_Ventas.Columns("Envase").DisplayIndex = 3

				Me.tbl_Detalle_Ventas.Columns("Medida").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
				Me.tbl_Detalle_Ventas.Columns("Medida").FillWeight = 270
				Me.tbl_Detalle_Ventas.Columns("Medida").Width = 80
				Me.tbl_Detalle_Ventas.Columns("Medida").DisplayIndex = 4

				Me.tbl_Detalle_Ventas.Columns("importe").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
				Me.tbl_Detalle_Ventas.Columns("importe").FillWeight = 270
				Me.tbl_Detalle_Ventas.Columns("importe").Width = 90
				Me.tbl_Detalle_Ventas.Columns("importe").DisplayIndex = 6

				Me.tbl_Detalle_Ventas.Columns("fechaVenta").DisplayIndex = 5
				Me.tbl_Detalle_Ventas.Columns("fechaVenta").Visible = False

				Me.lbl_fecha_sel.Text = tbl_Detalle_Ventas.Rows(0).Cells(3).Value



			End If
		End If

		fila = 0
		Dim acumula As Double = 0
		For i = 0 To tbl_Detalle_Ventas.Rows.Count - 1
			acumula = acumula + CDbl(tbl_Detalle_Ventas.Rows(i).Cells("importe").Value)
		Next
		txtTotal.Text = acumula
	End Sub
End Class