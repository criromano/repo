Public Class frmProveedorYCliente
    Dim funcion As New Funciones()
    Dim cliente As New Cliente
    Dim persona As New Persona
    Dim domicilio As New Domicilio
    Dim telefono As New Telefono
    Dim proveedor As New Proveedor

    Dim idTipoTelefono As Integer = 0
    Dim idCalle As Integer
    Dim idLocalidad As Integer = 1
    Dim id As Integer = 0
    Dim tipoPersona As String
    Dim idDomicilio As Integer
    Dim idTelefono As Integer
    Dim yaExiste As Integer = 0

    Public Sub New(ByVal id As Integer, ByVal tipo As String)
        Me.id = id
        Me.tipoPersona = tipo

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmProveedorYCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CARGA DE LAS CALLES EN EL COMBO
        For Each calle In funcion.MostrarCalles()
            cboCalle.Items.Add(calle.Nombre1)
        Next

        'CARGA DE LOS TIPOS DE TELEFONO EN EL COMBO
        For Each tipo In funcion.MostrarTiposDeTelefono()
            cboTipoTelefono.Items.Add(tipo.Nombre1)
        Next

        'CARGA LAS LOCALIDADES EN EL COMBO
        For Each localidad In funcion.MostrarLocalidades()
            cboLocalidad.Items.Add(localidad.Nombre1)
        Next
        If id > 0 And tipoPersona = "Cliente" Then
            rbCliente.Enabled = False
            rbProveedor.Enabled = False
            cliente = funcion.TraeClientePorId(id)
            rbCliente.Checked = True
            If cliente.Cuil1 <> "--" And cliente.Cuil1 <> "0" Then
                If Len(cliente.Cuil1) < 11 Then
                    txtCuit2.Text = cliente.Cuil1.Substring(1, 8)
                Else
                    txtCuit1.Text = cliente.Cuil1.Substring(0, 2)
                    txtCuit2.Text = cliente.Cuil1.Substring(3, 8)
                    txtCuit3.Text = cliente.Cuil1.Substring(12, 1)
                End If

            End If

            persona = funcion.TraePersonaPorId(cliente.IdPersona1)
            txtApellidoYNombre.Text = persona.ApellidoYNombre1
            txtMail.Text = persona.Email1

            domicilio = funcion.TraeDomicilioPorId(persona.IdDomicilio1)
            cboCalle.SelectedItem = funcion.TraeCallePorId(domicilio.IdRef_Calle1)
            txtNumero.Text = domicilio.Numero1
            txtPiso.Text = domicilio.Piso1
            txtDpto.Text = domicilio.Dpto1

            cboLocalidad.SelectedItem = funcion.TraeLocalidadPorId(domicilio.IdRef_Localidad1)

            telefono = funcion.TraeTelefonoPorId(persona.IdPersona1)
            cboTipoTelefono.SelectedItem = funcion.TraeTipoDeTelefonoPorId(telefono.IdRef_TipoTelefono1)
            txtCodigoDeArea.Text = telefono.CodArea1
            txtNumeroDeTelefono.Text = telefono.Numero1
            txtObservaciones.Text = cliente.Observaciones1
        End If
        If id > 0 And tipoPersona = "Proveedor" Then
            rbCliente.Enabled = False
            rbProveedor.Enabled = False
            proveedor = funcion.TraeProveedorPorId(id)
            rbProveedor.Checked = True
            txtCuit1.Text = proveedor.Cuit1.Substring(0, 2)
            txtCuit2.Text = proveedor.Cuit1.Substring(3, 8)
            txtCuit3.Text = proveedor.Cuit1.Substring(12, 1)
            txtApellidoYNombre.Text = proveedor.RazonSocial1
            txtMail.Text = proveedor.Email1

            domicilio = funcion.TraeDomicilioPorId(proveedor.IdDomicilio1)
            cboCalle.SelectedItem = funcion.TraeCallePorId(domicilio.IdRef_Calle1)
            txtNumero.Text = domicilio.Numero1
            txtPiso.Text = domicilio.Piso1
            txtDpto.Text = domicilio.Dpto1

            cboLocalidad.SelectedItem = funcion.TraeLocalidadPorId(domicilio.IdRef_Localidad1)

            telefono = funcion.TraeTelefonoPorIdDeProveedor(proveedor.IdProveedor1)
            cboTipoTelefono.SelectedItem = funcion.TraeTipoDeTelefonoPorId(telefono.IdRef_TipoTelefono1)
            txtCodigoDeArea.Text = telefono.CodArea1
            txtNumeroDeTelefono.Text = telefono.Numero1
            txtObservaciones.Text = proveedor.Observaciones1
        End If
    End Sub

    Private Sub rbCliente_CheckedChanged(sender As Object, e As EventArgs) Handles rbCliente.CheckedChanged
        lblApellidoYNombre.Text = "Apellido y nombre:"
        lblApellidoYNombre.Visible = True
        txtApellidoYNombre.Visible = True
        lblCuit.Text = "CUIL:"
        lblCuit.Visible = True
        txtCuit1.Visible = True
        Label2.Visible = True
        txtCuit2.Visible = True
        Label3.Visible = True
        txtCuit3.Visible = True
        lblDomicilio.Visible = True
        lblCalle.Visible = True
        cboCalle.Visible = True
        lblNumero.Visible = True
        txtNumero.Visible = True
        lblPiso.Visible = True
        txtPiso.Visible = True
        lblDpto.Visible = True
        txtDpto.Visible = True
        lblLocalidad.Visible = True
        cboLocalidad.Visible = True
        lblMail.Visible = True
        txtMail.Visible = True
        lblTelefono.Visible = True
        lblTipoTelefono.Visible = True
        cboTipoTelefono.Visible = True
        lblNumeroTelefono.Visible = True
        txtCodigoDeArea.Visible = True
        txtNumeroDeTelefono.Visible = True
        lblObservaciones.Visible = True
        txtObservaciones.Visible = True
        txtApellidoYNombre.Select()
        yaExiste = 0
    End Sub

    Private Sub rbProveedor_CheckedChanged(sender As Object, e As EventArgs) Handles rbProveedor.CheckedChanged
        lblApellidoYNombre.Text = "Razón Social:"
        lblApellidoYNombre.Visible = True
        txtApellidoYNombre.Visible = True
        lblCuit.Text = "CUIT:"
        lblCuit.Visible = True
        txtCuit1.Visible = True
        Label2.Visible = True
        txtCuit2.Visible = True
        Label3.Visible = True
        txtCuit3.Visible = True
        lblDomicilio.Visible = True
        lblCalle.Visible = True
        cboCalle.Visible = True
        lblNumero.Visible = True
        txtNumero.Visible = True
        lblPiso.Visible = True
        txtPiso.Visible = True
        lblDpto.Visible = True
        txtDpto.Visible = True
        lblLocalidad.Visible = True
        cboLocalidad.Visible = True
        lblMail.Visible = True
        txtMail.Visible = True
        lblTelefono.Visible = True
        lblTipoTelefono.Visible = True
        cboTipoTelefono.Visible = True
        lblNumeroTelefono.Visible = True
        txtCodigoDeArea.Visible = True
        txtNumeroDeTelefono.Visible = True
        lblObservaciones.Visible = True
        txtObservaciones.Visible = True
        txtApellidoYNombre.Select()
        yaExiste = 0
    End Sub

    Private Sub cboTipoTelefono_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoTelefono.SelectedIndexChanged
        For Each tipo In funcion.MostrarTiposDeTelefono
            If tipo.Nombre1 = cboTipoTelefono.SelectedItem Then
                idTipoTelefono = tipo.IdRef_TipoTelefono1
            End If
        Next
        lblNumeroTelefono.Enabled = True
        txtCodigoDeArea.Enabled = True
        txtNumeroDeTelefono.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim documento As String = txtCuit2.Text
        Dim idClienteProveedorExistente As Integer
        Dim cuil As String = txtCuit1.Text & "-" & txtCuit2.Text & "-" & txtCuit3.Text

        If rbCliente.Checked Then
            For Each clientes In funcion.ListaDeClientes()
                If clientes.Cuil1 <> "--" And clientes.Cuil1 <> "0" Then
                    If Len(clientes.Cuil1) < 11 Then
                        If clientes.Cuil1.Substring(1, 8) = documento Then
                            yaExiste = 1
                            idClienteProveedorExistente = clientes.IdCliente1
                        End If
                    Else
                        If clientes.Cuil1.Substring(3, 8) = documento Then
                            yaExiste = 1
                            idClienteProveedorExistente = clientes.IdCliente1
                        End If
                    End If
                End If
            Next
        End If

        If rbProveedor.Checked Then
            For Each proveedor In funcion.ListaDeProveedores()
                If proveedor.Cuit1 = cuil And cuil <> "--" Then
                    yaExiste = 1
                    idClienteProveedorExistente = proveedor.IdProveedor1
                End If
            Next
        End If

        If id = 0 Then 'GUARDA CLIENTE O PROVEEDOR NUEVO
            If yaExiste = 1 Then
                If rbCliente.Checked Then
                    MessageBox.Show("El cliente ingresado ya existe")
                End If
                If rbProveedor.Checked Then
                    MessageBox.Show("El proveedor ingresado ya existe")
                End If
                txtApellidoYNombre.Select()
            Else
                If MsgBox("¿ESTA SEGURO?", vbYesNo + vbQuestion) = vbYes Then
                    'GUARDA DOMICILIO
                    If idCalle <> 0 Then
                        Dim nuevoDomicilio As New Domicilio
                        nuevoDomicilio.IdRef_Calle1 = idCalle
                        nuevoDomicilio.Numero1 = txtNumero.Text
                        nuevoDomicilio.Piso1 = txtPiso.Text
                        nuevoDomicilio.Dpto1 = txtDpto.Text
                        nuevoDomicilio.IdRef_Localidad1 = idLocalidad
                        funcion.GuardaDomicilio(nuevoDomicilio)

                        idDomicilio = funcion.RecuperaUltimoIdDomicilio()
                    Else
                        idDomicilio = 1
                    End If


                    'GUARDA TIPO Y NÚMERO DE TÉLEFONO
                    If idTipoTelefono <> 0 And Len(txtCodigoDeArea.Text) > 0 And Len(txtNumeroDeTelefono.Text) > 0 Then
                        Dim nuevoTelefono As New Telefono
                        nuevoTelefono.CodArea1 = txtCodigoDeArea.Text
                        nuevoTelefono.Numero1 = txtNumeroDeTelefono.Text
                        nuevoTelefono.IdRef_TipoTelefono1 = idTipoTelefono
                        funcion.GuardaNumeroDeTelefono(nuevoTelefono)
                        idTelefono = funcion.RecuperaUltimoIdTelefono
                    End If

                    'CARGA DE CLIENTE
                    If rbCliente.Checked Then
                        If Validar() Then
                            Dim nuevaPersona As New Persona
                            nuevaPersona.ApellidoYNombre1 = txtApellidoYNombre.Text
                            nuevaPersona.Dni1 = txtCuit2.Text
                            nuevaPersona.IdDomicilio1 = idDomicilio
                            nuevaPersona.Email1 = txtMail.Text
                            funcion.GuardaPersonaNueva(nuevaPersona)
                            Dim idPersona As Integer = funcion.RecuperaUltimoIdPersona()

                            Dim nuevoCliente As New Cliente
                            nuevoCliente.IdPersona1 = idPersona
                            nuevoCliente.Cuil1 = txtCuit1.Text & "-" & nuevaPersona.Dni1 & "-" & txtCuit3.Text
                            nuevoCliente.Observaciones1 = txtObservaciones.Text
                            funcion.GuardaClienteNuevo(nuevoCliente)

                            If (idTelefono) Then
                                Dim telefonoDePersona As New Persona_has_Telefono
                                telefonoDePersona.IdPersona1 = idPersona
                                telefonoDePersona.IdTelefono1 = idTelefono
                                funcion.GuardaTelefonoEnPersona(telefonoDePersona)

                            End If
                            funcion.AbrirFormEnPanel(New frmPadronClienteProveedor)
                        End If
                    End If

                    'CARGA DE PROVEEDOR
                    If rbProveedor.Checked Then
                        If Validar() Then
                            Dim nuevoProveedor As New Proveedor
                            nuevoProveedor.RazonSocial1 = txtApellidoYNombre.Text
                            nuevoProveedor.Cuit1 = txtCuit1.Text & "-" & txtCuit2.Text & "-" & txtCuit3.Text
                            nuevoProveedor.IdDomicilio1 = idDomicilio
                            nuevoProveedor.Email1 = txtMail.Text
                            nuevoProveedor.Observaciones1 = txtObservaciones.Text
                            funcion.GuardaProveedorNuevo(nuevoProveedor)
                            Dim idProveedor As Integer = funcion.RecuperaUltimoIdProveedor

                            If (idTelefono) Then
                                Dim telefonoDeProveedor As New Proveedor_has_Telefono
                                telefonoDeProveedor.IdProveedor1 = idProveedor
                                telefonoDeProveedor.IdTelefono1 = idTelefono
                                funcion.GuardaTelefonoEnProveedor(telefonoDeProveedor)
                            End If
                            funcion.AbrirFormEnPanel(New frmPadronClienteProveedor)
                        End If
                    End If
                End If
            End If
        Else 'ACTUALIZA DATOS DE CLIENTE O PROVEEDOR EXISTENTE
            If yaExiste = 1 And id <> idClienteProveedorExistente Then
                If rbCliente.Checked Then
                    MessageBox.Show("El cliente ingresado ya existe")
                End If
                If rbProveedor.Checked Then
                    MessageBox.Show("El proveedor ingresado ya existe")
                End If
                txtApellidoYNombre.Select()
            Else
                If Len(txtCuit1.Text) > 0 And Len(txtCuit3.Text) < 1 Then
                    MessageBox.Show("Debe completar todo el CUIL/CUIT")
                Else
                    If Len(txtCuit3.Text) > 0 And Len(txtCuit1.Text) < 2 Then
                        MessageBox.Show("Debe completar todo el CUIL/CUIT")
                    Else
                        If MsgBox("¿ESTA SEGURO?", vbYesNo + vbQuestion) = vbYes Then
                            If idCalle <> domicilio.IdRef_Calle1 Or txtNumero.Text <> domicilio.Numero1 Or txtPiso.Text <> domicilio.Piso1 Or txtDpto.Text <> domicilio.Dpto1 Or idLocalidad <> domicilio.IdRef_Localidad1 Then
                                'actualiza domicilio si hubo algún cambio
                                domicilio.IdRef_Calle1 = idCalle
                                domicilio.Numero1 = txtNumero.Text
                                domicilio.Piso1 = txtPiso.Text
                                domicilio.Dpto1 = txtDpto.Text
                                domicilio.IdRef_Localidad1 = idLocalidad
                                If domicilio.IdDomicilio1 = 1 Then
                                    funcion.GuardaDomicilio(domicilio)
                                    idDomicilio = funcion.RecuperaUltimoIdDomicilio()
                                Else
                                    funcion.ActualizarDomicilio(domicilio)
                                    idDomicilio = domicilio.IdDomicilio1
                                End If
                            Else
                                idDomicilio = domicilio.IdDomicilio1
                            End If

                            If idTipoTelefono <> telefono.IdRef_TipoTelefono1 Or txtCodigoDeArea.Text <> telefono.CodArea1 Or txtNumeroDeTelefono.Text <> telefono.Numero1 Then
                                'actualiza telefono si hubo algún cambio
                                telefono.CodArea1 = txtCodigoDeArea.Text
                                telefono.Numero1 = txtNumeroDeTelefono.Text
                                telefono.IdRef_TipoTelefono1 = idTipoTelefono
                                If telefono.IdTelefono1 = 0 Then
                                    funcion.GuardaNumeroDeTelefono(telefono)
                                    idTelefono = funcion.RecuperaUltimoIdTelefono()
                                    If rbCliente.Checked Then
                                        Dim telefonoDePersona As New Persona_has_Telefono
                                        telefonoDePersona.IdPersona1 = id
                                        telefonoDePersona.IdTelefono1 = idTelefono
                                        funcion.GuardaTelefonoEnPersona(telefonoDePersona)
                                    End If
                                    If rbProveedor.Checked Then
                                        Dim telefonoDeProveedor As New Proveedor_has_Telefono
                                        telefonoDeProveedor.IdProveedor1 = id
                                        telefonoDeProveedor.IdTelefono1 = idTelefono
                                        funcion.GuardaTelefonoEnProveedor(telefonoDeProveedor)
                                    End If
                                Else
                                    funcion.ActualizarTeléfono(telefono)
                                End If
                            End If

                            If rbCliente.Checked Then
                                'actualizar persona
                                If Validar() Then
                                    If cliente.Cuil1 <> "--" Then
                                        If Len(cliente.Cuil1) < 11 Then
                                            If txtApellidoYNombre.Text <> persona.ApellidoYNombre1 Or txtCuit2.Text <> persona.Dni1 Or txtCuit3.Text <> cliente.Cuil1.Substring(9, 1) Or txtMail.Text <> persona.Email1 Or idDomicilio <> persona.IdDomicilio1 Or txtObservaciones.Text <> cliente.Observaciones1 Then
                                                persona.IdPersona1 = id
                                                persona.ApellidoYNombre1 = txtApellidoYNombre.Text
                                                persona.Dni1 = txtCuit2.Text
                                                persona.IdDomicilio1 = idDomicilio
                                                persona.Email1 = txtMail.Text
                                                cliente.IdCliente1 = id
                                                cliente.Cuil1 = txtCuit1.Text & "-" & txtCuit2.Text & "-" & txtCuit3.Text
                                                cliente.Observaciones1 = txtObservaciones.Text
                                                funcion.ActualizarPersona(persona)
                                                funcion.ActualizarCliente(cliente)
                                            End If
                                        Else
                                            If txtApellidoYNombre.Text <> persona.ApellidoYNombre1 Or txtCuit2.Text <> persona.Dni1 Or txtCuit3.Text <> cliente.Cuil1.Substring(12, 1) Or txtMail.Text <> persona.Email1 Or idDomicilio <> persona.IdDomicilio1 Or txtObservaciones.Text <> cliente.Observaciones1 Then
                                                persona.IdPersona1 = id
                                                persona.ApellidoYNombre1 = txtApellidoYNombre.Text
                                                persona.Dni1 = txtCuit2.Text
                                                persona.IdDomicilio1 = idDomicilio
                                                persona.Email1 = txtMail.Text
                                                cliente.IdCliente1 = id
                                                cliente.Cuil1 = txtCuit1.Text & "-" & txtCuit2.Text & "-" & txtCuit3.Text
                                                cliente.Observaciones1 = txtObservaciones.Text
                                                funcion.ActualizarPersona(persona)
                                                funcion.ActualizarCliente(cliente)
                                            End If
                                        End If
                                    Else
                                        If txtApellidoYNombre.Text <> persona.ApellidoYNombre1 Or txtCuit2.Text <> persona.Dni1 Or txtMail.Text <> persona.Email1 Or idDomicilio <> persona.IdDomicilio1 Or txtObservaciones.Text <> cliente.Observaciones1 Then
                                            persona.IdPersona1 = id
                                            persona.ApellidoYNombre1 = txtApellidoYNombre.Text
                                            persona.Dni1 = txtCuit2.Text
                                            persona.IdDomicilio1 = idDomicilio
                                            persona.Email1 = txtMail.Text
                                            cliente.Cuil1 = txtCuit1.Text & "-" & txtCuit2.Text & "-" & txtCuit3.Text
                                            cliente.Observaciones1 = txtObservaciones.Text
                                            funcion.ActualizarPersona(persona)
                                            funcion.ActualizarCliente(cliente)
                                        End If
                                    End If
                                    funcion.AbrirFormEnPanel(New frmPadronClienteProveedor)
                                End If
                            End If

                            If rbProveedor.Checked Then
                                'actualizar proveedor
                                If Validar() Then
                                    Dim cuit As String = txtCuit1.Text & "-" & txtCuit2.Text & "-" & txtCuit3.Text
                                    If txtApellidoYNombre.Text <> proveedor.RazonSocial1 Or cuit <> proveedor.Cuit1 Or txtMail.Text <> proveedor.Email1 Or idDomicilio <> proveedor.IdDomicilio1 Or txtObservaciones.Text <> proveedor.Observaciones1 Then
                                        proveedor.IdProveedor1 = id
                                        proveedor.RazonSocial1 = txtApellidoYNombre.Text
                                        proveedor.Cuit1 = cuit
                                        proveedor.IdDomicilio1 = idDomicilio
                                        proveedor.Email1 = txtMail.Text
                                        proveedor.Observaciones1 = txtObservaciones.Text
                                        funcion.ActualizarProveedor(proveedor)
                                    End If
                                    funcion.AbrirFormEnPanel(New frmPadronClienteProveedor)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        yaExiste = 0
        idClienteProveedorExistente = 0
    End Sub

    Private Function Validar() As Boolean
        If rbCliente.Checked Then
            If Len(txtApellidoYNombre.Text) = 0 Then
                MessageBox.Show("Debe completar el NOMBRE Y APELLIDO")
                txtApellidoYNombre.Select()
                Return False
            End If

            If Len(txtCuit2.Text) > 0 And Len(txtCuit2.Text) < 8 Then
                MessageBox.Show("El DNI debe contener 8 digitos")
                txtCuit2.Select()
                Return False
            End If
        End If

        If rbProveedor.Checked Then
            If Len(txtApellidoYNombre.Text) = 0 Then
                MessageBox.Show("Debe completar la RAZÓN SOCIAL")
                txtApellidoYNombre.Select()
                Return False
            End If

            If Len(txtCuit1.Text) = 0 Then
                MessageBox.Show("Debe completar el CUIT")
                txtCuit1.Select()
                Return False
            End If

            If Len(txtCuit2.Text) = 0 Then
                MessageBox.Show("Debe completar el CUIT")
                txtCuit2.Select()
                Return False
            End If

            If Len(txtCuit2.Text) > 0 And Len(txtCuit2.Text) < 8 Then
                MessageBox.Show("El CUIT debe estar completo")
                txtCuit2.Select()
                Return False
            End If

            If Len(txtCuit3.Text) = 0 Then
                MessageBox.Show("Debe completar el CUIT")
                txtCuit3.Select()
                Return False
            End If
        End If

        If idTipoTelefono <> 0 Then
            If Len(txtCodigoDeArea.Text) = 0 Then
                MessageBox.Show("Debe ingresar un CÓDIGO DE AREA")
                txtCodigoDeArea.Select()
                Return False
            End If

            If Len(txtNumeroDeTelefono.Text) = 0 Then
                MessageBox.Show("Debe ingresar un NÚMERO DE TELÉFONO")
                txtNumeroDeTelefono.Select()
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub cboCalle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCalle.SelectedIndexChanged
        For Each calle In funcion.MostrarCalles
            If calle.Nombre1 = cboCalle.SelectedItem Then
                idCalle = calle.IdRef_Calle1
            End If
        Next
        lblNumero.Enabled = True
        txtNumero.Enabled = True
        lblPiso.Enabled = True
        txtPiso.Enabled = True
        lblDpto.Enabled = True
        txtDpto.Enabled = True
        lblLocalidad.Enabled = True
        cboLocalidad.Enabled = True
    End Sub

    Private Sub txtCuit1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuit1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True 'deshabilita la tecla
        End If
    End Sub

    Private Sub txtCuit2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuit2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True 'deshabilita la tecla
        End If
    End Sub

    Private Sub txtCuit3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuit3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True 'deshabilita la tecla
        End If
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True 'deshabilita la tecla
        End If
    End Sub

    Private Sub cboLocalidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLocalidad.SelectedIndexChanged
        For Each localidad In funcion.MostrarLocalidades()
            If localidad.Nombre1 = cboLocalidad.SelectedItem() Then
                idLocalidad = localidad.IdRef_Localidad1
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        funcion.AbrirFormEnPanel(New frmPadronClienteProveedor)
    End Sub
End Class