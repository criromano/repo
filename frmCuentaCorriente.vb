Imports System.Data
Imports System.Data.SqlClient

Public Class frmCuentaCorriente
	Dim ds = New DataSet
	Dim dsVentas As New DataSet
	Dim funcion As New Funciones()
	Dim idClienteSelecionado As Integer = 0
	Dim RestoCliente As Double = 0
	Dim filaCliente As Integer = 0
	Dim abrirNuevoForm As New Funciones
	Dim id As Integer = 0
	Public IdVentaSeleccionada As Integer = 0
	Dim cantComas As Integer = 0
	Dim fila As Integer
	Dim filaNueva As Integer = 0


	Private Sub frmCuentaCorriente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		txtFiltro.Select()
		'funcion.TraeCuentasCorrientes(txtFiltro.Text)
	End Sub

	Private Sub dgvCtaCte_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCtaCte.CellMouseEnter
		If e.RowIndex > -1 Then
			dgvCtaCte.Rows(e.RowIndex).Selected = True
		End If
	End Sub


	Private Sub ColumnasCuentasCorrientes()

		Me.dgvCtaCte.Columns("Cliente").Visible = True
		Me.dgvCtaCte.Columns("Apellido y Nombre").Visible = True
		Me.dgvCtaCte.Columns("Resto").Visible = True

		Me.dgvCtaCte.Columns("Cliente").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
		Me.dgvCtaCte.Columns("Cliente").FillWeight = 80 'alto
		Me.dgvCtaCte.Columns("Cliente").Width = 80 ' ancho
		Me.dgvCtaCte.Columns("Cliente").DisplayIndex = 0

		Me.dgvCtaCte.Columns("Apellido y Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
		Me.dgvCtaCte.Columns("Apellido y Nombre").FillWeight = 200
		Me.dgvCtaCte.Columns("Apellido y Nombre").Width = 200
		Me.dgvCtaCte.Columns("Apellido y Nombre").DisplayIndex = 1

		Me.dgvCtaCte.Columns("Resto").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
		Me.dgvCtaCte.Columns("Resto").FillWeight = 80
		Me.dgvCtaCte.Columns("Resto").Width = 80
		Me.dgvCtaCte.Columns("Resto").DisplayIndex = 2

		'Me.dgvCtaCte.Columns("Cliente").DisplayIndex = 0 'Orden en el la tabla
		'Me.dgvCtaCte.Columns("Apellido y Nombre").DisplayIndex = 1
		'Me.dgvCtaCte.Columns("Resto").DisplayIndex = 2
	End Sub

	Private Sub columnasDetalleDeVentas()

		Dim colCheck As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
		colCheck.Name = "Casilla"
		Me.dgvDetalleDeVentas.Columns.Add(colCheck)

		Me.dgvDetalleDeVentas.Columns("IdVenta").Visible = False
		Me.dgvDetalleDeVentas.Columns("Fecha de Venta").Visible = False
		'Me.dgvDetalleDeVentas.Columns("Saldada").Visible = True
		Me.dgvDetalleDeVentas.Columns("Importe").Visible = False
		Me.dgvDetalleDeVentas.Columns("idCliente").Visible = False
		Me.dgvDetalleDeVentas.Columns("Casilla").Visible = False
		Me.dgvDetalleDeVentas.Columns("saldar").Visible = True

		Me.dgvDetalleDeVentas.Columns("IdVenta").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
		Me.dgvDetalleDeVentas.Columns("IdVenta").FillWeight = 80 'alto
		Me.dgvDetalleDeVentas.Columns("IdVenta").Width = 30 ' ancho
		Me.dgvDetalleDeVentas.Columns("IdVenta").DisplayIndex = 0

		Me.dgvDetalleDeVentas.Columns("Fecha de Venta").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
		Me.dgvDetalleDeVentas.Columns("Fecha de Venta").FillWeight = 200
		Me.dgvDetalleDeVentas.Columns("Fecha de Venta").Width = 70
		Me.dgvDetalleDeVentas.Columns("Fecha de Venta").DisplayIndex = 1

		'Me.dgvDetalleDeVentas.Columns("Saldada").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
		'Me.dgvDetalleDeVentas.Columns("Saldada").FillWeight = 80
		'Me.dgvDetalleDeVentas.Columns("Saldada").Width = 80
		'Me.dgvDetalleDeVentas.Columns("Saldada").DisplayIndex = 2

		Me.dgvDetalleDeVentas.Columns("Importe").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
		Me.dgvDetalleDeVentas.Columns("Importe").FillWeight = 80
		Me.dgvDetalleDeVentas.Columns("Importe").Width = 80
		Me.dgvDetalleDeVentas.Columns("Importe").DisplayIndex = 3

		Me.dgvDetalleDeVentas.Columns("Casilla").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
		Me.dgvDetalleDeVentas.Columns("Casilla").FillWeight = 80 'alto
		Me.dgvDetalleDeVentas.Columns("Casilla").Width = 40 ' ancho
		Me.dgvDetalleDeVentas.Columns("Casilla").DisplayIndex = 4



	End Sub

	'AL CAMBIAR EL TEXTO FILTRA POR APELLIDO Y NOMBRE
	Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged

		If Len(txtFiltro.Text) >= 0 Then
			If Not IsNumeric(txtFiltro.Text) Then 'Si no es numerico
				dgvCtaCte.DataSource = Nothing
				ds.Clear()
				funcion.TraeCuentasCorrientes(txtFiltro.Text).Fill(ds, "cliente, Apellido y Nombre,Resto")
				If ds.Tables("cliente, Apellido y Nombre,Resto").Rows.Count > 0 Then
					dgvCtaCte.DataSource = ds.Tables("cliente, Apellido y Nombre,Resto")
					ColumnasCuentasCorrientes()
					dgvCtaCte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.DisplayedCells
				End If
			End If
		End If
	End Sub

	Private Sub frmCuentaCorriente_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
		ds.Clear()
		funcion.TraeCuentasCorrientes(txtFiltro.Text).Fill(ds, "cliente, Apellido y Nombre,Resto")
		If ds.Tables("cliente, Apellido y Nombre,Resto").Rows.Count > 0 Then
			dgvCtaCte.DataSource = ds.Tables("cliente, Apellido y Nombre,Resto")
			ColumnasCuentasCorrientes()
			dgvCtaCte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
		End If
	End Sub

	Private Sub dgvCtaCte_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCtaCte.CellDoubleClick
		dsVentas.Clear()
		dgvDetalleDeVentas.Rows.Clear()

		If e.RowIndex <> -1 And e.RowIndex < dgvCtaCte.Rows.Count Then
			idClienteSelecionado = dgvCtaCte.Rows(e.RowIndex).Cells(0).Value
			RestoCliente = dgvCtaCte.Rows(e.RowIndex).Cells(2).Value
			filaCliente = e.RowIndex
			funcion.TraeDetalleDeCuentasCorrientesPorCliente(dgvCtaCte.Rows(e.RowIndex).Cells(0).Value).fill(dsVentas, "ventasACuenta,ventas,ventasacuenta_has_pagosacuentacliente,pagosACuentaCliente")

			Dim importepago As Double = 0
			For Each ds As DataRow In dsVentas.Tables(0).Rows
				If IsDBNull(ds("importe")) Then
					importepago = 0
				Else
					importepago = ds("importe")
				End If

				Dim saldo As Double = ds("importeACuenta") - importepago 'IsDBNull(ds("importe")) = 0
				dgvDetalleDeVentas.Rows.Add(ds("idVentasACuenta"), Format(ds("fechaVenta"), "dd/MM/yyyy"), ds("importeACuenta"), Math.Round(saldo, 2))
			Next

			If dgvDetalleDeVentas.Rows.Count > 0 Then
				dgvDetalleDeVentas.Visible = True
				Label3.Visible = True
			Else
				dgvDetalleDeVentas.Visible = False
				Label3.Visible = False
			End If
		End If

	End Sub


	Private Sub dgvDetalleDeVentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleDeVentas.CellClick
		cantComas = 0
		If e.RowIndex <> -1 Then
			IdVentaSeleccionada = dgvDetalleDeVentas.Rows(e.RowIndex).Cells(0).Value
			frmDetalleDePagos.txtIdVenta.Text = IdVentaSeleccionada

			If dgvDetalleDeVentas.Columns(e.ColumnIndex).Name = "btnConfirmar" Then
				If dgvDetalleDeVentas.Rows(e.RowIndex).Cells(4).Value <> "" And dgvDetalleDeVentas.Rows(e.RowIndex).Cells(4).Value <> 0 Then
					Dim saldo As Double = dgvDetalleDeVentas.Rows(e.RowIndex).Cells(3).Value
					Dim pago As Double = dgvDetalleDeVentas.Rows(e.RowIndex).Cells(4).Value

					If pago <= saldo Then
						Dim diferencia As Double = saldo - pago
						funcion.registraPagosACuentaCliente(pago, idClienteSelecionado)
						Dim ultimoid As Integer = funcion.RecuperaUltimoIdPagoCliente()
						funcion.RegistrarIdUltimoPagoIdVenta(IdVentaSeleccionada, ultimoid)
						dgvDetalleDeVentas.Rows(e.RowIndex).Cells(3).Value = Math.Round(diferencia, 2)
						dgvDetalleDeVentas.Rows(e.RowIndex).Cells(4).Value = ""

						ds.Clear()
						funcion.TraeCuentasCorrientes(txtFiltro.Text).Fill(ds, "cliente, Apellido y Nombre,Resto")
						If ds.Tables("cliente, Apellido y Nombre,Resto").Rows.Count > 0 Then
							dgvCtaCte.DataSource = ds.Tables("cliente, Apellido y Nombre,Resto")
							ColumnasCuentasCorrientes()
							dgvCtaCte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
						End If

						'dgvCtaCte.Rows(filaCliente).Cells(2).Value = diferencia 'RestoCliente - pago

						If diferencia = 0 Then
							funcion.RegistrarPagoACuenta(IdVentaSeleccionada)
							If dgvCtaCte.Rows.Count > 0 Then
								dgvDetalleDeVentas.Rows.Clear()
								If filaCliente < dgvCtaCte.Rows.Count Then
									If idClienteSelecionado = dgvCtaCte.Rows(filaCliente).Cells(0).Value Then
										dgvCtaCte_CellDoubleClick(dgvCtaCte, New DataGridViewCellEventArgs(dgvCtaCte.CurrentCell.ColumnIndex, filaCliente))
									End If
								End If
							Else
								dgvDetalleDeVentas.Rows.Clear()
							End If
						End If
					Else
						MsgBox("EL MONTO INGRESADO NO PUEDE SER MAYOR AL SALDO DEUDOR", vbOKOnly, "Atencion!!")
						dgvDetalleDeVentas.Rows(e.RowIndex).Cells(4).Value = ""
						dgvDetalleDeVentas.CurrentCell = dgvDetalleDeVentas.Rows(e.RowIndex).Cells(4)
						dgvDetalleDeVentas.BeginEdit(True)
					End If
				Else
					MsgBox("POR FAVOR DEBE INGRESAR UN MONTO", vbOKOnly, "Atencion!!")
					dgvDetalleDeVentas.Rows(e.RowIndex).Cells(4).Value = ""
					dgvDetalleDeVentas.CurrentCell = dgvDetalleDeVentas.Rows(e.RowIndex).Cells(4)
					dgvDetalleDeVentas.BeginEdit(True)
				End If
			Else
				If dgvDetalleDeVentas.Columns(e.ColumnIndex).Name = "btnPagos" Then
					frmDetalleDePagos.ShowDialog()
				End If
			End If
		End If
		'fila = dgvDetalleDeVentas.CurrentRow.Index
	End Sub

	Private Sub dgvDetalleDeVentas_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDetalleDeVentas.CellMouseDoubleClick
		If e.RowIndex <> -1 Then
			cantComas = 0
			frmDetalleVentas.txtIdVenta.Text = funcion.TraeIdVentaPorIdVentaACuenta(IdVentaSeleccionada)
			frmDetalleVentas.ShowDialog()
		End If
	End Sub

	Private Sub dgvDetalleDeVentas_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvDetalleDeVentas.EditingControlShowing
		If dgvDetalleDeVentas.CurrentCell.ColumnIndex = 4 Then
			cantComas = 0

			txt_cont_key.Text = dgvDetalleDeVentas.CurrentCell.Value

			Dim txtFiltro = CType(e.Control, DataGridViewTextBoxEditingControl)

			RemoveHandler txtFiltro.KeyPress, AddressOf txtFiltro_KeyPress

			AddHandler txtFiltro.KeyPress, AddressOf txtFiltro_KeyPress

		End If
	End Sub

	Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
		If dgvDetalleDeVentas.Visible = True Then
			If dgvDetalleDeVentas.CurrentCell.ColumnIndex = 4 Then

				Dim dig As Integer
				Dim cadena As String

				If (e.KeyChar <> vbBack) Then
					dig = Len(txt_cont_key.Text & e.KeyChar)
					cadena = txt_cont_key.Text & e.KeyChar
				Else
					dig = Len(txt_cont_key.Text)
					cadena = txt_cont_key.Text
					If dig > 0 Then
						txt_cont_key.Text = cadena.Substring(0, dig - 1)
					End If
				End If

				If Char.IsDigit(e.KeyChar) Then
					e.Handled = False

				ElseIf Char.IsControl(e.KeyChar) Or e.KeyChar = "," Or e.KeyChar = "." Then
					If e.KeyChar = "." Then
						e.KeyChar = ","
					End If
					e.Handled = False
				Else
					e.Handled = True
				End If

				If dig = 1 And (e.KeyChar = "," Or e.KeyChar = ".") Then 'si dig=1 y es un punto rechaza 
					If e.KeyChar = "." Then
						e.KeyChar = ","
					End If
					e.Handled = True
				End If

				Dim a, esDecimal, NumDecimales As Integer
				Dim esDec As Boolean

				For a = 0 To dig - 1
					Dim car As String = CStr(txt_cont_key.Text & e.KeyChar)
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

				If (e.Handled = False) And ((e.KeyChar <> vbBack)) Then
					txt_cont_key.Text = txt_cont_key.Text & e.KeyChar
				End If
			End If
		End If
	End Sub

	Private Sub dgvCtaCte_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCtaCte.CellContentClick

	End Sub
End Class