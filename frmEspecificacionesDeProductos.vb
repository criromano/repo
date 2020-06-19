Public Class frmEspecificacionesDeProductos
	Dim ds As New DataSet
	Dim funcion As New Funciones
	Private Sub btnGuardarEspecificaciones_Click(sender As Object, e As EventArgs) Handles btnGuardarEspecificaciones.Click
		If rdbAgregaMarca.Checked Then
			If Trim(txtEspecificacion.Text) = "" Then
				MessageBox.Show("Debe ingresar Marca")
				txtEspecificacion.Clear()
			Else
				Dim yaExisteMarca As Integer = 0
				Dim marca As New Ref_Marca
				marca.NombreMarca1 = txtEspecificacion.Text
				Dim marcas As New Funciones
				For Each marcaExistente In marcas.ListaDeMarcas()
					If marcaExistente.NombreMarca1 = marca.NombreMarca1 Then
						yaExisteMarca = 1
					End If
				Next
				If yaExisteMarca = 1 Then
					MessageBox.Show("La marca ingresada ya existe")
				Else
					Dim AgregarNuevaMarca As New Funciones
					AgregarNuevaMarca.AgregarNuevaMarca(marca)
					txtEspecificacion.Clear()
					ds.Clear()
					funcion.TraeEspecificaciones("Marca").Fill(ds, "ref_marca")
					If ds.Tables("ref_marca").Rows.Count > 0 Then
						dgvEspecificaciones.DataSource = ds.Tables("ref_marca")
						TamanoColumna()
						dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
					End If
				End If
			End If
		End If

		If rdbAgregarTipoEnvase.Checked Then
			If Trim(txtEspecificacion.Text) = "" Then
				MessageBox.Show("Debe ingresar Tipo de Envase")
				txtEspecificacion.Clear()
			Else
				Dim yaExisteTipoEnvase As Integer = 0
				Dim tipoEnvase As New Ref_TipoEnvase
				tipoEnvase.NombreTipoEnvase1 = txtEspecificacion.Text
				Dim tiposEnvases As New Funciones
				For Each envaseExistente In tiposEnvases.ListaDeTiposDeEnvases()
					If envaseExistente.NombreTipoEnvase1 = tipoEnvase.NombreTipoEnvase1 Then
						yaExisteTipoEnvase = 1
					End If
				Next
				If yaExisteTipoEnvase = 1 Then
					MessageBox.Show("El tipo de envase ingresado ya existe")
				Else
					Dim AgregarNuevoTipoDeEnvase As New Funciones
					AgregarNuevoTipoDeEnvase.AgregarNuevoTipoDeEnvase(tipoEnvase)
					txtEspecificacion.Clear()
					ds.Clear()
					funcion.TraeEspecificaciones("tipoenvase").Fill(ds, "ref_tipoenvase")
					If ds.Tables("ref_tipoenvase").Rows.Count > 0 Then
						dgvEspecificaciones.DataSource = ds.Tables("ref_tipoenvase")
						TamanoColumna()
						dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
					End If
				End If
			End If
		End If

		If rdbTipoProducto.Checked Then
			If Trim(txtEspecificacion.Text) = "" Then
				MessageBox.Show("Debe ingresar tipo de Producto")
				txtEspecificacion.Clear()
			Else
				Dim yaExisteTipoProducto As Integer = 0
				Dim tipo As New Ref_TipoProducto
				tipo.NombreTipoProducto1 = txtEspecificacion.Text
				Dim tiposProductos As New Funciones
				For Each tipoProductoExistente In tiposProductos.ListaDeTiposDeProductos()
					If tipoProductoExistente.NombreTipoProducto1 = tipo.NombreTipoProducto1 Then
						yaExisteTipoProducto = 1
					End If
				Next
				If yaExisteTipoProducto = 1 Then
					MessageBox.Show("El tipo de producto ingresado ya existe")
				Else
					Dim AgregarTipodeProductoNuevo As New Funciones
					AgregarTipodeProductoNuevo.AgregarTipodeProductoNuevo(tipo)
					txtEspecificacion.Clear()
					ds.Clear()
					funcion.TraeEspecificaciones("tipoproducto").Fill(ds, "ref_tipoproducto")
					If ds.Tables("ref_tipoproducto").Rows.Count > 0 Then
						dgvEspecificaciones.DataSource = ds.Tables("ref_tipoproducto")
						TamanoColumna()
						dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
					End If
				End If
			End If
		End If

		If rdbRubroProducto.Checked Then
			If Trim(txtEspecificacion.Text) = "" Then
				MessageBox.Show("Debe ingresar Rubro")
				txtEspecificacion.Clear()
			Else
				Dim yaExisteRubro As Integer = 0
				Dim rubro As New Ref_RubroProducto
				rubro.NombreRubroProducto1 = txtEspecificacion.Text
				Dim rubrosProductos As New Funciones
				For Each rubroProducto In rubrosProductos.ListaDeRubrosDeProductos()
					If rubroProducto.NombreRubroProducto1 = rubro.NombreRubroProducto1 Then
						yaExisteRubro = 1
					End If
				Next
				If yaExisteRubro = 1 Then
					MessageBox.Show("El rubro ingresado ya existe")
				Else
					Dim AgregarNuevoRubroDeProducto As New Funciones
					AgregarNuevoRubroDeProducto.AgregarNuevoRubroDeProducto(rubro)
					txtEspecificacion.Clear()
					ds.Clear()
					funcion.TraeEspecificaciones("rubroproducto").Fill(ds, "ref_rubroproducto")
					If ds.Tables("ref_rubroproducto").Rows.Count > 0 Then
						dgvEspecificaciones.DataSource = ds.Tables("ref_rubroproducto")
						TamanoColumna()
						dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
					End If
				End If
			End If
		End If

		If rdbUnidadDeMedida.Checked Then
			If Trim(txtEspecificacion.Text) = "" Then
				MessageBox.Show("Debe ingresar Unidad de Medida")
				txtEspecificacion.Clear()
			Else
				Dim yaExisteUnidad As Integer = 0
				Dim unidadmedida As New Ref_UnidadDeMedida
				unidadmedida.NombreUnidadDeMedida1 = txtEspecificacion.Text
				Dim unidadesDeMedida As New Funciones
				For Each unidad In unidadesDeMedida.ListaDeUnidadesDeMedida()
					If unidad.NombreUnidadDeMedida1 = unidadmedida.NombreUnidadDeMedida1 Then
						yaExisteUnidad = 1
					End If
				Next
				If yaExisteUnidad = 1 Then
					MessageBox.Show("La unidad de medida ingresada ya existe")
				Else
					Dim AgregarNuevaUnidadDeMedida As New Funciones
					AgregarNuevaUnidadDeMedida.AgregarNuevaUnidadDeMedida(unidadmedida)
					txtEspecificacion.Clear()
					ds.Clear()
					funcion.TraeEspecificaciones("unidaddemedida").Fill(ds, "ref_unidaddemedida")
					If ds.Tables("ref_unidaddemedida").Rows.Count > 0 Then
						dgvEspecificaciones.DataSource = ds.Tables("ref_unidaddemedida")
						TamanoColumna()
						dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
					End If
				End If
			End If
		End If

		If rdbProductoSinCodigo.Checked Then
			If Trim(txtEspecificacion.Text) = "" Then
				MessageBox.Show("Debe ingresar Producto Sin Codigo")
				txtEspecificacion.Clear()
			Else
				Dim yaExisteProducto As Integer = 0
				Dim producto As New ProductoSinCodigo
				producto.Nombre1 = txtEspecificacion.Text
				Dim productosSinCodigo As New Funciones
				For Each produ In productosSinCodigo.ListaDeProductosSinCodigo
					If produ.Nombre1 = producto.Nombre1 Then
						yaExisteProducto = 1
					End If
				Next
				If yaExisteProducto = 1 Then
					MessageBox.Show("El producto ingresado ya existe")
				Else
					Dim agregarNuevoProductoSinCodigo As New Funciones
					agregarNuevoProductoSinCodigo.AgregarNuevoProductoSinCodigo(producto)
					txtEspecificacion.Clear()
					ds.Clear()
					funcion.TraeEspecificaciones("productosincodigo").Fill(ds, "productosincodigo")
					If ds.Tables("productosincodigo").Rows.Count > 0 Then
						dgvEspecificaciones.DataSource = ds.Tables("productosincodigo")
						TamanoColumna()
						dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
					End If
				End If
			End If
		End If

		If rbCondicionCompraVenta.Checked Then
			If Trim(txtEspecificacion.Text) = "" Then
				MessageBox.Show("Debe ingresar una Condición")
				txtEspecificacion.Clear()
			Else
				Dim yaExisteCondicion As Integer = 0
				Dim condicion As New Ref_CondicionVentaCompra
				condicion.NombreCondicion1 = txtEspecificacion.Text
				For Each cond In funcion.MostrarCondicionesDeVentaCompra
					If cond.NombreCondicion1 = condicion.NombreCondicion1 Then
						yaExisteCondicion = 1
					End If
				Next
				If yaExisteCondicion = 1 Then
					MessageBox.Show("La condicion ingresada ya existe")
				Else
					funcion.AgregarCondicionDeCompraVenta(condicion)
					txtEspecificacion.Clear()
					ds.Clear()
					funcion.TraeCondicionesCompraVenta().Fill(ds, "ref_condicionventacompra")
					If ds.Tables("ref_condicionventacompra").Rows.Count > 0 Then
						dgvEspecificaciones.DataSource = ds.Tables("ref_condicionventacompra")
						TamanoColumna()
						dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
					End If
				End If
			End If
		End If

		If rbAgregarCalle.Checked Then
			If Trim(txtEspecificacion.Text) = "" Then
				MessageBox.Show("Debe ingresar una Calle")
				txtEspecificacion.Clear()
			Else
				Dim yaExisteCalle As Integer = 0
				Dim calle As New Ref_Calle
				calle.Nombre1 = txtEspecificacion.Text
				For Each cal In funcion.MostrarCalles
					If cal.Nombre1 = calle.Nombre1 Then
						yaExisteCalle = 1
					End If
				Next
				If yaExisteCalle = 1 Then
					MessageBox.Show("La calle ingresada ya existe")
				Else
					funcion.AgregarCalle(calle)
					txtEspecificacion.Clear()
					ds.Clear()
					funcion.TraeCalles().Fill(ds, "ref_calle")
					If ds.Tables("ref_calle").Rows.Count > 0 Then
						dgvEspecificaciones.DataSource = ds.Tables("ref_calle")
						TamanoColumna()
						dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
					End If
				End If
			End If
		End If

		If rbAgregarLocalildad.Checked Then
			If Trim(txtEspecificacion.Text) = "" Then
				MessageBox.Show("Debe ingresar una Localidad")
				txtEspecificacion.Clear()
			Else
				Dim yaExisteLocalidad As Integer = 0
				Dim localidad As New Ref_Localidad
				localidad.Nombre1 = txtEspecificacion.Text
				For Each local In funcion.MostrarLocalidades
					If local.Nombre1 = localidad.Nombre1 Then
						yaExisteLocalidad = 1
					End If
				Next
				If yaExisteLocalidad = 1 Then
					MessageBox.Show("La localidad ingresada ya existe")
				Else
					funcion.AgregarLocalidad(localidad)
					txtEspecificacion.Clear()
					ds.Clear()
					funcion.TraeLocalidades().Fill(ds, "ref_localidad")
					If ds.Tables("ref_localidad").Rows.Count > 0 Then
						dgvEspecificaciones.DataSource = ds.Tables("ref_localidad")
						TamanoColumna()
						dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
					End If
				End If
			End If
		End If

		If rbTipoTelefono.Checked Then
			If Trim(txtEspecificacion.Text) = "" Then
				MessageBox.Show("Debe ingresar un Tipo de Teléfono")
				txtEspecificacion.Clear()
			Else
				Dim yaExisteTipo As Integer = 0
				Dim tipoTelefono As New Ref_TipoTelefono
				tipoTelefono.Nombre1 = txtEspecificacion.Text
				For Each tipo In funcion.MostrarTiposDeTelefono
					If tipo.Nombre1 = tipoTelefono.Nombre1 Then
						yaExisteTipo = 1
					End If
				Next
				If yaExisteTipo = 1 Then
					MessageBox.Show("El Tipo de Teléfono ingresado ya existe")
				Else
					funcion.AgregarTipoTelefono(tipoTelefono)
					txtEspecificacion.Clear()
					ds.Clear()
					funcion.TraeTiposDeTelefonos().Fill(ds, "ref_tipotelefono")
					If ds.Tables("ref_tipotelefono").Rows.Count > 0 Then
						dgvEspecificaciones.DataSource = ds.Tables("ref_tipotelefono")
						TamanoColumna()
						dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
					End If
				End If
			End If
		End If

		btnGuardarEspecificaciones.Enabled = False
		txtEspecificacion.Focus()
	End Sub

	Private Sub rdbAgregaMarca_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAgregaMarca.CheckedChanged
		lblNuevoValor.Enabled = True
		txtEspecificacion.Enabled = True
		txtEspecificacion.Text = ""
		txtEspecificacion.Focus()
		btnGuardarEspecificaciones.Enabled = False
		lblNuevoValor.Text = "Ingrese Nueva MARCA:"
		ds.Clear()
		lblActuales.Visible = True
		funcion.TraeEspecificaciones("Marca").Fill(ds, "ref_marca")
		If ds.Tables("ref_marca").Rows.Count > 0 Then
			dgvEspecificaciones.DataSource = ds.Tables("ref_marca")
			TamanoColumna()
			dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
		End If
	End Sub

	Private Sub rdbAgregarTipoEnvase_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAgregarTipoEnvase.CheckedChanged
		lblNuevoValor.Enabled = True
		txtEspecificacion.Enabled = True
		txtEspecificacion.Text = ""
		txtEspecificacion.Focus()
		btnGuardarEspecificaciones.Enabled = False
		lblNuevoValor.Text = "Ingrese Nuevo ENVASE:"
		ds.Clear()
		lblActuales.Visible = True
		funcion.TraeEspecificaciones("tipoenvase").Fill(ds, "ref_tipoenvase")
		If ds.Tables("ref_tipoenvase").Rows.Count > 0 Then
			dgvEspecificaciones.DataSource = ds.Tables("ref_tipoenvase")
			TamanoColumna()
			dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
		End If
	End Sub

	Private Sub rdbTipoProducto_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTipoProducto.CheckedChanged
		lblNuevoValor.Enabled = True
		txtEspecificacion.Enabled = True
		txtEspecificacion.Text = ""
		txtEspecificacion.Focus()
		btnGuardarEspecificaciones.Enabled = False
		lblNuevoValor.Text = "Ingrese Nuevo TIPO:"
		ds.Clear()
        lblActuales.Visible = True

        funcion.TraeEspecificaciones("tipoproducto").Fill(ds, "ref_tipoproducto")
		If ds.Tables("ref_tipoproducto").Rows.Count > 0 Then
			dgvEspecificaciones.DataSource = ds.Tables("ref_tipoproducto")
			TamanoColumna()
			dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
		End If
	End Sub

	Private Sub rdbRubroProducto_CheckedChanged(sender As Object, e As EventArgs) Handles rdbRubroProducto.CheckedChanged
		lblNuevoValor.Enabled = True
		txtEspecificacion.Enabled = True
		txtEspecificacion.Text = ""
		txtEspecificacion.Focus()
		btnGuardarEspecificaciones.Enabled = False
		lblNuevoValor.Text = "Ingrese Nuevo RUBRO:"
		ds.Clear()
		lblActuales.Visible = True
		funcion.TraeEspecificaciones("rubroproducto").Fill(ds, "ref_rubroproducto")
		If ds.Tables("ref_rubroproducto").Rows.Count > 0 Then
			dgvEspecificaciones.DataSource = ds.Tables("ref_rubroproducto")
			TamanoColumna()
			dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
		End If
	End Sub

	Private Sub rdbUnidadDeMedida_CheckedChanged(sender As Object, e As EventArgs) Handles rdbUnidadDeMedida.CheckedChanged
		lblNuevoValor.Enabled = True
		txtEspecificacion.Enabled = True
		txtEspecificacion.Text = ""
		txtEspecificacion.Focus()
		btnGuardarEspecificaciones.Enabled = False
		lblNuevoValor.Text = "Ingrese Nueva UNIDAD DE MEDIDA:"
		ds.Clear()
		lblActuales.Visible = True
		funcion.TraeEspecificaciones("unidaddemedida").Fill(ds, "ref_unidaddemedida")
		If ds.Tables("ref_unidaddemedida").Rows.Count > 0 Then
			dgvEspecificaciones.DataSource = ds.Tables("ref_unidaddemedida")
			TamanoColumna()
			dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
		End If
	End Sub

	Private Sub txtEspecificacion_TextChanged(sender As Object, e As EventArgs) Handles txtEspecificacion.TextChanged
		If txtEspecificacion.Text <> "" Then
			btnGuardarEspecificaciones.Enabled = True
		End If
	End Sub

	Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdbProductoSinCodigo.CheckedChanged
		lblNuevoValor.Enabled = True
		txtEspecificacion.Enabled = True
		txtEspecificacion.Text = ""
		txtEspecificacion.Focus()
		btnGuardarEspecificaciones.Enabled = False
		lblNuevoValor.Text = "Ingrese Nuevo PRODUCTO:"
		ds.Clear()
		lblActuales.Visible = True
		funcion.TraeEspecificaciones("productosincodigo").Fill(ds, "productosincodigo")
		If ds.Tables("productosincodigo").Rows.Count > 0 Then
			dgvEspecificaciones.DataSource = ds.Tables("productosincodigo")
			TamanoColumna()
			dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
		End If
	End Sub

	Private Function TamanoColumna()
		Me.dgvEspecificaciones.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
		Me.dgvEspecificaciones.Columns("Nombre").FillWeight = 170
		Me.dgvEspecificaciones.Columns("Nombre").Width = 275
		Me.dgvEspecificaciones.Columns("Nombre").DisplayIndex = 0
	End Function

	Private Sub rbCondicionCompraVenta_CheckedChanged(sender As Object, e As EventArgs) Handles rbCondicionCompraVenta.CheckedChanged
		lblNuevoValor.Enabled = True
		txtEspecificacion.Enabled = True
		txtEspecificacion.Text = ""
		txtEspecificacion.Focus()
		btnGuardarEspecificaciones.Enabled = False
		lblNuevoValor.Text = "Ingrese Nueva CONDICIÓN:"
		ds.Clear()
		lblActuales.Visible = True
		funcion.TraeCondicionesCompraVenta().Fill(ds, "ref_condicionventacompra")
		If ds.Tables("ref_condicionventacompra").Rows.Count > 0 Then
			dgvEspecificaciones.DataSource = ds.Tables("ref_condicionventacompra")
			TamanoColumna()
			dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
		End If
	End Sub

	Private Sub rbAgregarCalle_CheckedChanged(sender As Object, e As EventArgs) Handles rbAgregarCalle.CheckedChanged
		lblNuevoValor.Enabled = True
		txtEspecificacion.Enabled = True
		txtEspecificacion.Text = ""
		txtEspecificacion.Focus()
		btnGuardarEspecificaciones.Enabled = False
		lblNuevoValor.Text = "Ingrese Nueva CALLE:"
		ds.Clear()
		lblActuales.Visible = True
		funcion.TraeCalles().Fill(ds, "ref_calle")
		If ds.Tables("ref_calle").Rows.Count > 0 Then
			dgvEspecificaciones.DataSource = ds.Tables("ref_calle")
			TamanoColumna()
			dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
		End If
	End Sub

	Private Sub rbAgregarLocalildad_CheckedChanged(sender As Object, e As EventArgs) Handles rbAgregarLocalildad.CheckedChanged
		lblNuevoValor.Enabled = True
		txtEspecificacion.Enabled = True
		txtEspecificacion.Text = ""
		txtEspecificacion.Focus()
		btnGuardarEspecificaciones.Enabled = False
		lblNuevoValor.Text = "Ingrese Nueva LOCALIDAD:"
		ds.Clear()
		lblActuales.Visible = True
		funcion.TraeLocalidades().Fill(ds, "ref_localidad")
		If ds.Tables("ref_localidad").Rows.Count > 0 Then
			dgvEspecificaciones.DataSource = ds.Tables("ref_localidad")
			TamanoColumna()
			dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
		End If
	End Sub

	Private Sub rbTipoTelefono_CheckedChanged(sender As Object, e As EventArgs) Handles rbTipoTelefono.CheckedChanged
		lblNuevoValor.Enabled = True
		txtEspecificacion.Enabled = True
		txtEspecificacion.Text = ""
		txtEspecificacion.Focus()
		btnGuardarEspecificaciones.Enabled = False
		lblNuevoValor.Text = "Ingrese Nuevo TIPO DE TELÉFONO:"
		ds.Clear()
		lblActuales.Visible = True
		funcion.TraeTiposDeTelefonos().Fill(ds, "ref_tipotelefono")
		If ds.Tables("ref_tipotelefono").Rows.Count > 0 Then
			dgvEspecificaciones.DataSource = ds.Tables("ref_tipotelefono")
			TamanoColumna()
			dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
		End If
	End Sub
End Class