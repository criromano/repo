Imports MySql.Data.MySqlClient
Imports lacabania.ConexionBDD
Imports System.Security.Cryptography

Public Class Funciones

    'TRAE DATOS DE PRODUCTO POR ID Y LO GUARDA EN UNA LISTA
    Public Function TraeProductoPorId(id As Integer) As List(Of Producto)
        'Dim comando As New MySqlCommand("SELECT prod.idproducto, prod.nombreproducto, prod.idRef_UnidadDeMedida, prod.medida, prod.codigobarras, prod.stockminimo, prod.idRef_RubroProducto, prod.idRef_TipoProducto, prod.idRef_TipoEnvase, prod.idRef_Marca, prec.precio, prod.vigente FROM producto as prod LEFT JOIN preciodeventa as prec on prod.idPrecioDeVenta=prec.idPrecioDeVenta where prod.idProducto =" & id)
        Dim comando As New MySqlCommand("SELECT prod.idproducto, prod.nombreproducto, prod.idRef_UnidadDeMedida, prod.medida, prod.codigobarras, prod.stockminimo, prod.idRef_RubroProducto, prod.idRef_TipoProducto, prod.idRef_TipoEnvase, prod.idRef_Marca, prod.idPrecioDeVenta, prod.vigente FROM producto as prod  where prod.idProducto =" & id)
        'MessageBox.Show(productoAModificar)
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim lista As New List(Of Producto)
        While reader.Read()
            Dim producto As New Producto
            Dim precio As New PrecioDeVenta
            producto.IdProducto1 = reader(0)
            producto.NombreProducto1 = reader(1)
            producto.IdRef_UnidadDeMedida1 = reader(2)
            producto.Medida1 = reader(3)
            producto.CodigoBarras1 = reader(4)
            producto.StockMinimo1 = reader(5)
            producto.IdRef_RubroProducto1 = reader(6)
            producto.IdRef_TipoProduto1 = reader(7)
            producto.IdRef_TipoEnvase1 = reader(8)
            producto.IdRef_Marca1 = reader(9)
            producto.IdPrecioDeVenta1 = reader(10)
            producto.Vigente1 = reader(11)
            lista.Add(producto)
        End While

        conectar.cerrarConexion()
        Return lista
    End Function

    'TRAE DATOS DE PRODUCTO POR ID
    Public Function TraeObjetoProductoPorId(id As Integer) As Producto
        Dim comando As New MySqlCommand("SELECT prod.idproducto, prod.nombreproducto, prod.idRef_UnidadDeMedida, prod.medida, prod.codigobarras, prod.stockminimo, prod.idRef_RubroProducto, prod.idRef_TipoProducto, prod.idRef_TipoEnvase, prod.idRef_Marca, prec.precio, prod.vigente FROM producto as prod LEFT JOIN preciodeventa as prec on prod.idPrecioDeVenta=prec.idPrecioDeVenta where prod.idProducto =" & id)
        'MessageBox.Show(productoAModificar)
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim producto As New Producto
        While reader.Read()
            Dim precio As New PrecioDeVenta
            producto.IdProducto1 = reader(0)
            producto.NombreProducto1 = reader(1)
            producto.IdRef_UnidadDeMedida1 = reader(2)
            producto.Medida1 = reader(3)
            producto.CodigoBarras1 = reader(4)
            producto.StockMinimo1 = reader(5)
            producto.IdRef_RubroProducto1 = reader(6)
            producto.IdRef_TipoProduto1 = reader(7)
            producto.IdRef_TipoEnvase1 = reader(8)
            producto.IdRef_Marca1 = reader(9)
            producto.IdPrecioDeVenta1 = reader(10)
            producto.Vigente1 = reader(11)
        End While

        conectar.cerrarConexion()
        Return producto
    End Function

    'TRAE DATOS DE PRODUCTO SIN CODIGO DE BARRAS POR ID
    Public Function TraeObjetoProductoSinCodigoPorId(id As Integer) As ProductoSinCodigo
        Dim comando As New MySqlCommand("SELECT idproductosincodigo, nombre FROM productosincodigo where idProductosincodigo =" & id)
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim producto As New ProductoSinCodigo
        While reader.Read()
            producto.IdProductoSinCodigo1 = reader(0)
            producto.Nombre1 = reader(1)
        End While

        'conectar.cerrarConexion()
        Return producto
    End Function

    'TRAE UNIDADES DE MEDIDA PARA MOSTRAR EN COMBO
    Public Function MostrarUnidadesDeMedida() As List(Of Ref_UnidadDeMedida)
        Dim comando As New MySqlCommand("SELECT * FROM ref_unidaddemedida order by nombreunidaddemedida")
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim listaUnidades = New List(Of Ref_UnidadDeMedida)
        While reader.Read()
            Dim unidades As New Ref_UnidadDeMedida
            unidades.IdRef_UnidadDeMedida1 = reader(0)
            unidades.NombreUnidadDeMedida1 = reader(1)
            listaUnidades.Add(unidades)
        End While

        conectar.cerrarConexion()
        Return listaUnidades
    End Function

    'TRAE UNIDAD DE MEDIDA POR ID
    Public Function MostrarUnidadDeMedidaPorId(id As Integer) As String
        Dim comando As New MySqlCommand("SELECT nombreunidaddemedida FROM ref_unidaddemedida where idref_unidaddemedida=" & id)
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim unidadDeMedida As String = ""
        While reader.Read()
            unidadDeMedida = reader(0)
        End While

        conectar.cerrarConexion()
        Return unidadDeMedida
    End Function

    'TRAE RUBROS DE PRODUCTOS POR ID
    Public Function MostrarRubrosPorId(id As Integer) As String
        Dim comando As New MySqlCommand("SELECT nombrerubroproducto FROM ref_rubroproducto where idref_rubroproducto=" & id)
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim rubro As String
        While reader.Read()
            rubro = reader(0)
        End While

        conectar.cerrarConexion()
        Return rubro
    End Function

    'TRAE RUBROS DE PRODUCTOS PARA MOSTRAR EN COMBO
    Public Function MostrarRubrosDeProductos() As List(Of Ref_RubroProducto)
        Dim comando As New MySqlCommand("SELECT * FROM ref_rubroproducto order by nombrerubroproducto")
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim listaRubros = New List(Of Ref_RubroProducto)
        While reader.Read()
            Dim rubros As New Ref_RubroProducto
            rubros.IdRef_RubroProducto1 = reader(0)
            rubros.NombreRubroProducto1 = reader(1)
            listaRubros.Add(rubros)
        End While

        conectar.cerrarConexion()
        Return listaRubros
    End Function

    'TRAE TIPOS DE PRODUCTOS PARA MOSTRAR EN COMBO
    Public Function MostrarTiposDeProductos() As List(Of Ref_TipoProducto)
        Dim comando As New MySqlCommand("SELECT * FROM ref_tipoproducto order by nombretipoproducto")
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim listaTiposProductos = New List(Of Ref_TipoProducto)
        While reader.Read()
            Dim tiposProductos As New Ref_TipoProducto
            tiposProductos.IdRef_TipoProducto1 = reader(0)
            tiposProductos.NombreTipoProducto1 = reader(1)
            listaTiposProductos.Add(tiposProductos)
        End While

        conectar.cerrarConexion()
        Return listaTiposProductos
    End Function

    'TRAE TIPOS DE ENVASES PARA MOSTRAR EN COMBO
    Public Function MostrarTiposDeEnvases() As List(Of Ref_TipoEnvase)
        Dim comando As New MySqlCommand("SELECT * FROM ref_tipoenvase order by nombretipoenvase")
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim listaTiposEnvases = New List(Of Ref_TipoEnvase)
        While reader.Read()
            Dim tiposEnvases As New Ref_TipoEnvase
            tiposEnvases.IdRef_TipoEnvase1 = reader(0)
            tiposEnvases.NombreTipoEnvase1 = reader(1)
            listaTiposEnvases.Add(tiposEnvases)
        End While

        conectar.cerrarConexion()
        Return listaTiposEnvases
    End Function

    'TRAE TIPOS DE ENVASES POR ID
    Public Function MostrarTiposDeEnvasesPorId(id As Integer) As String
        Dim comando As New MySqlCommand("SELECT nombretipoenvase FROM ref_tipoenvase where idref_tipoenvase=" & id)
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim tipoEnvase As String
        While reader.Read()
            tipoEnvase = reader(0)
        End While

        conectar.cerrarConexion()
        Return tipoEnvase
    End Function

    'TRAE TIPOS DE PRODUCTOS POR ID
    Public Function MostrarTiposDeProductoPorId(id As Integer) As String
        Dim comando As New MySqlCommand("SELECT nombretipoproducto FROM ref_tipoproducto where idref_tipoproducto=" & id)
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim tipoProducto As String
        While reader.Read()
            tipoProducto = reader(0)
        End While

        conectar.cerrarConexion()
        Return tipoProducto
    End Function

    'TRAE MARCAS PARA MOSTRAR EN COMBO
    Public Function MostrarMarcas() As List(Of Ref_Marca)
        Dim comando As New MySqlCommand("SELECT * FROM ref_marca order by nombremarca")
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim listaMarcas = New List(Of Ref_Marca)
        While reader.Read()
            Dim marcas As New Ref_Marca
            marcas.IdRef_Marca1 = reader(0)
            marcas.NombreMarca1 = reader(1)
            listaMarcas.Add(marcas)
        End While

        conectar.cerrarConexion()
        Return listaMarcas
    End Function

    'TRAE MARCA POR ID
    Public Function MostrarMarcaPorId(id As Integer) As String
        Dim comando As New MySqlCommand("SELECT nombremarca FROM ref_marca where idref_marca=" & id)
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim marca As String
        While reader.Read()
            marca = reader(0)
        End While

        conectar.cerrarConexion()
        Return marca
    End Function

    'TRAE PRODUCTOS SIN CODIGO DE BARRAS PARA MOSTRAR EN COMBO
    Public Function MostrarProductosSinCodigo() As List(Of ProductoSinCodigo)
        Dim comando As New MySqlCommand("SELECT * FROM productosincodigo order by nombre")
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim listaProductos = New List(Of ProductoSinCodigo)
        While reader.Read()
            Dim producto As New ProductoSinCodigo
            producto.IdProductoSinCodigo1 = reader(0)
            producto.Nombre1 = reader(1)
            listaProductos.Add(producto)
        End While

        conectar.cerrarConexion()
        Return listaProductos
    End Function

    'GUARDAMOS UN PRODUCTO NUEVO
    Public Function AgregarProductoNuevo(producto As Producto)
        Dim comandoTraePrecio As New MySqlCommand("SELECT max(idpreciodeventa) FROM preciodeventa")
        comandoTraePrecio.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comandoTraePrecio.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comandoTraePrecio.ExecuteReader()
        While reader.Read()
            producto.IdPrecioDeVenta1 = reader(0)
        End While

        Dim comando As New MySqlCommand("INSERT INTO producto (nombreProducto,idRef_UnidadDeMedida,medida,codigoBarras,stockMinimo,idRef_RubroProducto,idRef_TipoProducto,idRef_TipoEnvase,idRef_Marca,idpreciodeventa,vigente) VALUES (@nombreProducto,@idRef_UnidadDeMedida,@medida,@codigoBarras,@stockMinimo,@idRef_RubroProducto,@idRef_TipoProducto,@idRef_TipoEnvase,@idRef_Marca,@idpreciodeventa,@vigente)", conectar.ObtenerConexion())
        comando.Parameters.Add("@nombreProducto", MySqlDbType.VarChar).Value = producto.NombreProducto1 'producto.NombreProducto1
        comando.Parameters.Add("@idRef_UnidadDeMedida", MySqlDbType.Double).Value = producto.IdRef_UnidadDeMedida1 'productos.IdRef_RubroProducto1
        comando.Parameters.Add("@medida", MySqlDbType.Double).Value = producto.Medida1
        comando.Parameters.Add("@codigoBarras", MySqlDbType.VarChar).Value = producto.CodigoBarras1 'producto.CodigoBarras1
        comando.Parameters.Add("@stockMinimo", MySqlDbType.Double).Value = producto.StockMinimo1
        comando.Parameters.Add("@idRef_RubroProducto", MySqlDbType.VarChar).Value = producto.IdRef_RubroProducto1 'producto.IdRef_RubroProducto1
        comando.Parameters.Add("@idRef_TipoProducto", MySqlDbType.Double).Value = producto.IdRef_TipoProduto1 'producto.IdRef_TipoProduto1
        comando.Parameters.Add("@idRef_TipoEnvase", MySqlDbType.Double).Value = producto.IdRef_TipoEnvase1 'producto.IdRef_TipoEnvase1
        comando.Parameters.Add("@idRef_Marca", MySqlDbType.VarChar).Value = producto.IdRef_Marca1 'producto.IdRef_Marca1
        comando.Parameters.Add("@idpreciodeventa", MySqlDbType.Int32).Value = producto.IdPrecioDeVenta1
        comando.Parameters.Add("@vigente", MySqlDbType.Binary).Value = 1
        comando.ExecuteNonQuery()

        conectar.cerrarConexion()
    End Function

    'GUARDA PRECIO DE PRODUCTO NUEVO
    Public Function GuardaPrecioDeProducto(precio As PrecioDeVenta)
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("INSERT INTO preciodeventa (precio, fechadesde) VALUES (@precio, @fechadesde)", conectar.ObtenerConexion())
        'comando.Parameters.Add("@idproducto", MySqlDbType.Int16).Value = precio.IdProducto1
        comando.Parameters.Add("@precio", MySqlDbType.Double).Value = precio.Precio1
        comando.Parameters.Add("@fechadesde", MySqlDbType.Date).Value = precio.FechaDesde1
        comando.ExecuteNonQuery()

        conectar.cerrarConexion()
    End Function

    'TRAE PRECIO POR ID
    Public Function MostrarPrecioDeProducto(id As Integer) As Double
        Dim comando As New MySqlCommand("SELECT precio FROM preciodeventa where idpreciodeventa=" & id)
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim precio As Double
        While reader.Read()
            precio = reader(0)
        End While

        conectar.cerrarConexion()
        Return precio
    End Function

    'TRAE TODOS LOS PRODUCTOS
    Public Function TraeProductos(filtro As String, tipo As Integer)
        Dim comando As String
        If filtro = "" Then
            comando = "SELECT prod.idproducto as ID, prod.nombreproducto as Nombre, medida as Medida, unmed.nombreunidaddemedida as 'U.medida', prod.codigobarras as 'C. Barras', (SELECT stock FROM stock where idproducto=prod.idProducto) as 'Stock', rub.nombrerubroproducto as Rubro, tipop.nombretipoproducto as Tipo, tipoe.nombretipoenvase as Envase, mar.nombremarca as Marca, prec.precio as Precio, prod.vigente as Vigente FROM producto as prod LEFT JOIN ref_unidaddemedida as unmed on prod.idref_unidaddemedida=unmed.idref_unidaddemedida LEFT JOIN ref_rubroproducto as rub on prod.idref_rubroproducto=rub.idref_rubroproducto LEFT JOIN ref_tipoproducto as tipop on prod.idref_tipoproducto=tipop.idref_tipoproducto LEFT JOIN ref_tipoenvase as tipoe on prod.idref_tipoenvase=tipoe.idref_tipoenvase LEFT JOIN ref_marca as mar on prod.idref_marca=mar.idref_marca LEFT JOIN preciodeventa as prec on prod.idpreciodeventa=prec.idpreciodeventa limit 15"
        Else
            If tipo = 1 Then
                'BUSCA POR NOMBRE PRODUCTO
                comando = "SELECT prod.idproducto as ID, prod.nombreproducto as Nombre, medida as Medida, unmed.nombreunidaddemedida as 'U.medida', prod.codigobarras as 'C. Barras', (SELECT stock FROM stock where idproducto=prod.idProducto) as 'Stock', rub.nombrerubroproducto as Rubro, tipop.nombretipoproducto as Tipo, tipoe.nombretipoenvase as Envase, mar.nombremarca as Marca, prec.precio as Precio, prod.vigente as Vigente FROM producto as prod LEFT JOIN ref_unidaddemedida as unmed on prod.idref_unidaddemedida=unmed.idref_unidaddemedida LEFT JOIN ref_rubroproducto as rub on prod.idref_rubroproducto=rub.idref_rubroproducto LEFT JOIN ref_tipoproducto as tipop on prod.idref_tipoproducto=tipop.idref_tipoproducto LEFT JOIN ref_tipoenvase as tipoe on prod.idref_tipoenvase=tipoe.idref_tipoenvase LEFT JOIN ref_marca as mar on prod.idref_marca=mar.idref_marca LEFT JOIN preciodeventa as prec on prod.idpreciodeventa=prec.idpreciodeventa where prod.nombreproducto like '%" & filtro & "%' or rub.nombrerubroproducto like '%" & filtro & "%'"
            Else
                'BUSCA POR COD.BARRAS
                comando = "SELECT prod.idproducto as ID, prod.nombreproducto as Nombre, medida as Medida, unmed.nombreunidaddemedida as 'U.medida', prod.codigobarras as 'C. Barras', (SELECT stock FROM stock where idproducto=prod.idProducto) as 'Stock', rub.nombrerubroproducto as Rubro, tipop.nombretipoproducto as Tipo, tipoe.nombretipoenvase as Envase, mar.nombremarca as Marca, prec.precio as Precio, prod.vigente as Vigente FROM producto as prod LEFT JOIN ref_unidaddemedida as unmed on prod.idref_unidaddemedida=unmed.idref_unidaddemedida LEFT JOIN ref_rubroproducto as rub on prod.idref_rubroproducto=rub.idref_rubroproducto LEFT JOIN ref_tipoproducto as tipop on prod.idref_tipoproducto=tipop.idref_tipoproducto LEFT JOIN ref_tipoenvase as tipoe on prod.idref_tipoenvase=tipoe.idref_tipoenvase LEFT JOIN ref_marca as mar on prod.idref_marca=mar.idref_marca LEFT JOIN preciodeventa as prec on prod.idpreciodeventa=prec.idpreciodeventa where prod.codigobarras like '%" & filtro & "%'"
            End If
        End If

        Dim conectar = New ConexionBDD
        Dim mda = New MySqlDataAdapter(comando, conectar.ObtenerConexion())

        conectar.cerrarConexion()
        Return mda
    End Function

    'TRAE CUENTAS CORRIENTES
    Public Function TraeCuentasCorrientes(filtro As String)
        Dim comando As String
        If filtro = "" Then
            comando = "SELECT cli.idCliente as Cliente, Per.apellidoyNombre as 'Apellido y Nombre', round(sum(ctacte.saldo),2) as Resto FROM persona Per INNER join cliente cli INNER JOIN cuentacorrientecliente ctacte on ctacte.idCliente = cli.idCliente and per.idpersona = cli.idPersona where ctacte.saldo > 0 group by cli.idcliente limit 10"
        Else
            'BUSCA POR NOMBRE PRODUCTO
            comando = "SELECT cli.idCliente as Cliente, Per.apellidoyNombre as 'Apellido y Nombre', round(sum(ctacte.saldo),2) as Resto FROM persona Per INNER join cliente cli INNER JOIN cuentacorrientecliente ctacte on ctacte.idCliente = cli.idCliente and per.idpersona = cli.idPersona  WHERE per.apellidoynombre like '%" & filtro & "%' and ctacte.saldo > 0 group by cli.idcliente"
        End If

        Dim conectar = New ConexionBDD
        Dim mda = New MySqlDataAdapter(comando, conectar.ObtenerConexion())
        conectar.cerrarConexion()
        Return mda
    End Function

    'TRAE DETALLE DE CUENTAS CORRIENTES POR CLIENTE
    Public Function TraeDetalleDeCuentasCorrientesPorCliente(idcliente As Integer)
        Dim comando As String
        comando = "SELECT  vac.idVentasACuenta, round(vac.importe,2) as importeACuenta, ven.fechaVenta, round(ven.importetotaldeventa,2), round(sum(pagos.importe),2) as importe, ven.idCliente FROM ventasacuenta vac INNER JOIN ventas ven on vac.idVenta=ven.idventa LEFT JOIN ventasacuenta_has_pagosacuentacliente relacion on vac.idVentasACuenta=relacion.idVentasACuenta LEFT JOIN pagosacuentacliente pagos on relacion.idpagosacuentacliente=pagos.idPagosACuentaCliente where ven.idCliente  =   " & idcliente & " and vac.saldada = 0 GROUP by vac.idVentasACuenta"
        Dim conectar = New ConexionBDD
        Dim mda = New MySqlDataAdapter(comando, conectar.ObtenerConexion())
        conectar.cerrarConexion()
        Return mda
    End Function

    Public Function TraeIdVentaPorIdVentaACuenta(idVtaCta As Integer)
        Dim conectar = New ConexionBDD
        Dim comando As New MySqlCommand("select idventa from ventasacuenta where idventasacuenta=" & idVtaCta)
        comando.CommandType = CommandType.Text
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim idVenta As Integer
        While reader.Read()
            idVenta = reader(0)
        End While

        conectar.cerrarConexion()

        Return idVenta
    End Function

    'REGISTRA PAGOS A CUENTA CLIENTE
    Public Function registraPagosACuentaCliente(pago As Double, idCliente As Integer)
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("INSERT INTO pagosacuentacliente (importe,fecha) VALUES (@pago, @fecha)", conectar.ObtenerConexion())
        comando.Parameters.Add("@pago", MySqlDbType.Double).Value = pago
        comando.Parameters.Add("@fecha", MySqlDbType.Date).Value = Now()
        comando.ExecuteNonQuery()

        conectar.cerrarConexion()

        Dim comando2 As New MySqlCommand("UPDATE cuentacorrientecliente SET saldo=saldo - @pago where idcliente='" & idCliente & "'", conectar.ObtenerConexion())
        comando2.Parameters.Add("@pago", MySqlDbType.Double).Value = pago
        comando2.ExecuteNonQuery()

        conectar.cerrarConexion()
    End Function

    'REGISTRA PAGOS A CUENTA PROVEEDOR
    Public Function registraPagosACuentaProveedor(pago As Double, idCliente As Integer)
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("INSERT INTO pagosacuentaproveedores (importe,fecha) VALUES (@pago, @fecha)", conectar.ObtenerConexion())
        comando.Parameters.Add("@pago", MySqlDbType.Double).Value = pago
        comando.Parameters.Add("@fecha", MySqlDbType.Date).Value = Now()
        comando.ExecuteNonQuery()

        conectar.cerrarConexion()
    End Function

    'RECUPERA ULTIMO ID DE PAGO A CLIENTES
    Public Function RecuperaUltimoIdPagoCliente() As Integer
        Dim conectar = New ConexionBDD
        Dim comando As New MySqlCommand("SELECT if(max(idPagosACuentaCliente)>0,max(idPagosACuentaCliente),1) FROM pagosacuentacliente")
        comando.CommandType = CommandType.Text
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim idPagosACuentaCliente As Integer
        While reader.Read()
            idPagosACuentaCliente = reader(0)
        End While

        conectar.cerrarConexion()

        If idPagosACuentaCliente > 0 Then
            Return idPagosACuentaCliente
        Else
            idPagosACuentaCliente = 1
            Return idPagosACuentaCliente
        End If
    End Function


    'REGISTRA ULTIMO ID DE PAGO CON SU RESPECTIVO ID DE VENTA
    Public Function RegistrarIdUltimoPagoIdVenta(idventa As Integer, ultimoid As Integer)
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("INSERT INTO ventasacuenta_has_pagosacuentacliente (idVentasAcuenta,idpagosacuentacliente) VALUES (@idVentasAcuenta, @idpagosacuentacliente)", conectar.ObtenerConexion())
        comando.Parameters.Add("@idVentasAcuenta", MySqlDbType.Int32).Value = idventa
        comando.Parameters.Add("@idpagosacuentacliente", MySqlDbType.Int32).Value = ultimoid
        comando.ExecuteNonQuery()

        conectar.cerrarConexion()
    End Function

    'MODIFICA CUENTA SALDADA CUANDO SE CANCELA EN SU TOTALIDAD LA VENTA ACTUAL
    Public Function RegistrarPagoACuenta(idVenta As Integer)
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("UPDATE ventasACuenta SET saldada=1  where idVentasAcuenta='" & idVenta & "'", conectar.ObtenerConexion())
        comando.Parameters.Add("@saldada", MySqlDbType.Int32).Value = 1
        comando.ExecuteNonQuery()
        conectar.cerrarConexion()
    End Function


    'TRAE TODOS LOS PRODUCTOS Y LOS GUARDA EN UNA LISTA
    Public Function ListaDeProductos() As List(Of Producto)
        Dim comando As New MySqlCommand("SELECT * FROM producto")
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim lista = New List(Of Producto)
        While reader.Read()
            Dim productoExistente As New Producto
            productoExistente.NombreProducto1 = reader(1)
            productoExistente.IdRef_UnidadDeMedida1 = reader(2)
            productoExistente.Medida1 = reader(3)
            productoExistente.CodigoBarras1 = reader(4)
            productoExistente.IdRef_RubroProducto1 = reader(6)
            productoExistente.IdRef_TipoProduto1 = reader(7)
            productoExistente.IdRef_TipoEnvase1 = reader(8)
            productoExistente.IdRef_Marca1 = reader(9)
            lista.Add(productoExistente)
        End While

        conectar.cerrarConexion()
        Return lista
    End Function

    'TRAE TODAS LAS MARCAS Y LAS GUARDA EN UNA LISTA
    Public Function ListaDeMarcas() As List(Of Ref_Marca)
        Dim comando As New MySqlCommand("SELECT * FROM ref_marca")
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim lista = New List(Of Ref_Marca)
        While reader.Read()
            Dim marcaExistente As New Ref_Marca
            marcaExistente.NombreMarca1 = reader(1)
            lista.Add(marcaExistente)
        End While

        conectar.cerrarConexion()
        Return lista
    End Function

    'GUARDAMOS UNA NUEVA MARCA
    Public Function AgregarNuevaMarca(marca As Ref_Marca)
        Dim conectar = New ConexionBDD
        Dim comando As New MySqlCommand("INSERT INTO Ref_Marca (nombreMarca) VALUES (@nombreMarca)", conectar.ObtenerConexion())
        comando.Parameters.Add("@nombreMarca", MySqlDbType.VarChar).Value = marca.NombreMarca1 'nombre de la marca
        comando.ExecuteNonQuery()
        MsgBox("Nueva Marca Agregada Satisfactoriamente", vbOKOnly)

        conectar.cerrarConexion()
    End Function

    'TRAE TODOS LOS PRODUCTOS SIN CODIGO DE BARRAS Y LOS GUARDA EN UNA LISTA
    Public Function ListaDeProductosSinCodigo() As List(Of ProductoSinCodigo)
        Dim comando As New MySqlCommand("SELECT * FROM productosincodigo")
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim lista = New List(Of ProductoSinCodigo)
        While reader.Read()
            Dim productoExistente As New ProductoSinCodigo
            productoExistente.Nombre1 = reader(1)
            lista.Add(productoExistente)
        End While

        conectar.cerrarConexion()
        Return lista
    End Function

    'GUARDAMOS UN NUEVO PRODUCTO SIN CODIGO DE BARRAS
    Public Function AgregarNuevoProductoSinCodigo(producto As ProductoSinCodigo)
        Dim conectar = New ConexionBDD
        Dim comando As New MySqlCommand("INSERT INTO productosincodigo (nombre) VALUES (@nombre)", conectar.ObtenerConexion())
        comando.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = producto.Nombre1 'nombre de la marca
        comando.ExecuteNonQuery()
        MsgBox("Nuevo Producto agregado Satisfactoriamente", vbOKOnly)

        conectar.cerrarConexion()
    End Function

    'TRAE TODOS LOS TIPOS DE ENVASES Y LOS GUARDA EN UNA LISTA
    Public Function ListaDeTiposDeEnvases() As List(Of Ref_TipoEnvase)
        Dim comando As New MySqlCommand("SELECT * FROM ref_tipoenvase")
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim lista = New List(Of Ref_TipoEnvase)
        While reader.Read()
            Dim envaseExistente As New Ref_TipoEnvase
            envaseExistente.NombreTipoEnvase1 = reader(1)
            lista.Add(envaseExistente)
        End While

        conectar.cerrarConexion()
        Return lista
    End Function

    'GUARDAMOS UN NUEVO TIPO DE ENVASE
    Public Function AgregarNuevoTipoDeEnvase(tipoenvase As Ref_TipoEnvase)
        Dim conectar = New ConexionBDD
        Dim comando As New MySqlCommand("INSERT INTO Ref_TipoEnvase (nombreTipoEnvase) VALUES (@nombreTipoEnvase)", conectar.ObtenerConexion())
        comando.Parameters.Add("@nombreTipoEnvase", MySqlDbType.VarChar).Value = tipoenvase.NombreTipoEnvase1 'Nuevo tipo de envase
        comando.ExecuteNonQuery()
        MsgBox("Nuevo Tipo de Envase Agregado Satisfactoriamente", vbOKOnly)

        conectar.cerrarConexion()
    End Function

    'TRAE TODOS LOS TIPOS DE PRODUCTOS Y LOS GUARDA EN UNA LISTA
    Public Function ListaDeTiposDeProductos() As List(Of Ref_TipoProducto)
        Dim comando As New MySqlCommand("SELECT * FROM ref_tipoproducto")
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim lista = New List(Of Ref_TipoProducto)
        While reader.Read()
            Dim productoExistente As New Ref_TipoProducto
            productoExistente.NombreTipoProducto1 = reader(1)
            lista.Add(productoExistente)
        End While

        conectar.cerrarConexion()
        Return lista
    End Function

    'GUARDAMOS UN NUEVO TIPO DE PRODUCTO
    Public Function AgregarTipodeProductoNuevo(tipoproducto As Ref_TipoProducto)
        Dim conectar = New ConexionBDD
        Dim comando As New MySqlCommand("INSERT INTO ref_TipoProducto (nombreTipoProducto) VALUES (@nombreTipoProducto)", conectar.ObtenerConexion())
        comando.Parameters.Add("@nombreTipoProducto", MySqlDbType.VarChar).Value = tipoproducto.NombreTipoProducto1 'tipo de nombre producto
        comando.ExecuteNonQuery()
        MsgBox("Nuevo Tipo de Producto Agregado Satisfactoriamente", vbOKOnly)

        conectar.cerrarConexion()
    End Function

    'TRAE TODOS LOS RUBROS DE PRODUCTOS Y LOS GUARDA EN UNA LISTA
    Public Function ListaDeRubrosDeProductos() As List(Of Ref_RubroProducto)
        Dim comando As New MySqlCommand("SELECT * FROM ref_rubroproducto")
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim lista = New List(Of Ref_RubroProducto)
        While reader.Read()
            Dim rubroExistente As New Ref_RubroProducto
            rubroExistente.NombreRubroProducto1 = reader(1)
            lista.Add(rubroExistente)
        End While

        conectar.cerrarConexion()
        Return lista
    End Function

    'GUARDAMOS UN NUEVO RUBRO DE PRODUCTO
    Public Function AgregarNuevoRubroDeProducto(rubroproducto As Ref_RubroProducto)
        Dim conectar = New ConexionBDD
        Dim comando As New MySqlCommand("INSERT INTO Ref_RubroProducto (nombreRubroProducto) VALUES (@nombreRubroProducto)", conectar.ObtenerConexion())
        comando.Parameters.Add("@nombreRubroProducto", MySqlDbType.VarChar).Value = rubroproducto.NombreRubroProducto1 'tipo de rubro de producto
        comando.ExecuteNonQuery()
        MsgBox("Nuevo Rubro Agregado Satisfactoriamente", vbOKOnly)

        conectar.cerrarConexion()
    End Function

    'TRAE TODAS LAS UNIDADES DE MEDIDA Y LAS GUARDA EN UNA LISTA
    Public Function ListaDeUnidadesDeMedida() As List(Of Ref_UnidadDeMedida)
        Dim comando As New MySqlCommand("SELECT * FROM ref_unidaddemedida")
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim lista = New List(Of Ref_UnidadDeMedida)
        While reader.Read()
            Dim unidadExistente As New Ref_UnidadDeMedida
            unidadExistente.NombreUnidadDeMedida1 = reader(1)
            lista.Add(unidadExistente)
        End While

        conectar.cerrarConexion()
        Return lista
    End Function

    'GUARDAMOS UN TIPO DE UNIDAD DE MEDIDA
    Public Function AgregarNuevaUnidadDeMedida(unidaddemedida As Ref_UnidadDeMedida)
        Dim conectar = New ConexionBDD
        Dim comando As New MySqlCommand("INSERT INTO Ref_UnidadDeMedida (nombreUnidadDeMedida) VALUES (@nombreUnidadDeMedida)", conectar.ObtenerConexion())
        comando.Parameters.Add("@nombreUnidadDeMedida", MySqlDbType.VarChar).Value = unidaddemedida.NombreUnidadDeMedida1 'Nueva Unidad de Medida
        comando.ExecuteNonQuery()
        MsgBox("Nueva Unidad de Medida Agregada Satisfactoriamente", vbOKOnly)

        conectar.cerrarConexion()
    End Function

    'CREAMOS PARA ABRIR EL MENU HIJO
    Public Sub AbrirFormEnPanel(ByVal Formhijo As Object)
        If MenuPrincipal.PanelContenedor.Controls.Count > 0 Then ' si el panel contiene 
            MenuPrincipal.Controls.RemoveAt(2) ' remueve lo que tiene
        End If
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None ' le saca el borde
        fh.Dock = DockStyle.Fill ' acoplamos a todo el panel contenedor
        MenuPrincipal.Controls.Add(fh) ' agregamos los paneles al form contenedor
        MenuPrincipal.Tag = fh 'el panel contenedor tendra los datos del formulario
        fh.Show() 'Mostramos el formulario
    End Sub

    'TRAE EL ID DEL ÚLTIMO PRODUCTO CARGADO


    Public Function ObtenerUltimoIDProducto() As Integer
        Dim conectar = New ConexionBDD
        Dim comando As New MySqlCommand("SELECT if(max(idproducto)>0, max(idproducto),0) as idproducto FROM producto")
        comando.CommandType = CommandType.Text

        comando.Connection = conectar.ObtenerConexion()

        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim id As Integer
        While reader.Read()
            id = reader(0)
        End While

        conectar.cerrarConexion()
        'If id > 0 Then
        '	Return id
        'Else
        '	id = 1
        Return id
        'End If

    End Function

    'ACTUALIZA DATOS DE PRODUCTOS
    Public Function ActualizarDatosDeProductos(producto As Producto, precio As PrecioDeVenta, precioActual As Integer)
        Dim conectar = New ConexionBDD
        Dim id As Integer

        If (precioActual <> precio.Precio1) Then
            Dim comandoPrecio As New MySqlCommand("INSERT INTO preciodeventa (precio, fechadesde) VALUES (@precio, @fechadesde)", conectar.ObtenerConexion())
            comandoPrecio.Parameters.Add("@precio", MySqlDbType.Double).Value = precio.Precio1
            comandoPrecio.Parameters.Add("@fechadesde", MySqlDbType.Date).Value = precio.FechaDesde1
            comandoPrecio.ExecuteNonQuery()

            Dim comandoIdPrecio As New MySqlCommand("SELECT max(idpreciodeventa) FROM preciodeventa")
            comandoIdPrecio.CommandType = CommandType.Text
            comandoIdPrecio.Connection = conectar.ObtenerConexion()
            Dim reader As MySqlDataReader
            reader = comandoIdPrecio.ExecuteReader()
            While reader.Read()
                id = reader(0)
            End While

            Dim comandoConId As New MySqlCommand("UPDATE producto SET nombreproducto=@nombreproducto, idref_unidaddemedida=@idref_unidaddemedida, medida=@medida, codigobarras=@codigobarras, stockminimo=@stockminimo, idref_rubroproducto=@idref_rubroproducto, idref_tipoproducto=@idref_tipoproducto, idref_tipoenvase=@idref_tipoenvase, idref_marca=@idref_marca, idpreciodeventa=@idpreciodeventa where idproducto='" & producto.IdProducto1 & "'", conectar.ObtenerConexion())
            comandoConId.Parameters.Add("@nombreproducto", MySqlDbType.VarChar).Value = producto.NombreProducto1
            comandoConId.Parameters.Add("@idref_unidaddemedida", MySqlDbType.Int32).Value = producto.IdRef_UnidadDeMedida1
            comandoConId.Parameters.Add("@medida", MySqlDbType.Double).Value = producto.Medida1
            comandoConId.Parameters.Add("@codigobarras", MySqlDbType.VarChar).Value = producto.CodigoBarras1
            comandoConId.Parameters.Add("@stockminimo", MySqlDbType.Int32).Value = producto.StockMinimo1
            comandoConId.Parameters.Add("@idref_rubroproducto", MySqlDbType.Int32).Value = producto.IdRef_RubroProducto1
            comandoConId.Parameters.Add("@idref_tipoproducto", MySqlDbType.Int32).Value = producto.IdRef_TipoProduto1
            comandoConId.Parameters.Add("@idref_tipoenvase", MySqlDbType.Int32).Value = producto.IdRef_TipoEnvase1
            comandoConId.Parameters.Add("@idref_marca", MySqlDbType.Int32).Value = producto.IdRef_Marca1
            comandoConId.Parameters.Add("@idpreciodeventa", MySqlDbType.Int32).Value = id
            comandoConId.ExecuteNonQuery()
        Else
            Dim comando As New MySqlCommand("UPDATE producto SET nombreproducto=@nombreproducto, idref_unidaddemedida=@idref_unidaddemedida, medida=@medida, codigobarras=@codigobarras, stockminimo=@stockminimo, idref_rubroproducto=@idref_rubroproducto, idref_tipoproducto=@idref_tipoproducto, idref_tipoenvase=@idref_tipoenvase, idref_marca=@idref_marca where idproducto='" & producto.IdProducto1 & "'", conectar.ObtenerConexion())
            comando.Parameters.Add("@nombreproducto", MySqlDbType.VarChar).Value = producto.NombreProducto1
            comando.Parameters.Add("@idref_unidaddemedida", MySqlDbType.Int32).Value = producto.IdRef_UnidadDeMedida1
            comando.Parameters.Add("@medida", MySqlDbType.Double).Value = producto.Medida1
            comando.Parameters.Add("@codigobarras", MySqlDbType.VarChar).Value = producto.CodigoBarras1
            comando.Parameters.Add("@stockminimo", MySqlDbType.Int32).Value = producto.StockMinimo1
            comando.Parameters.Add("@idref_rubroproducto", MySqlDbType.Int32).Value = producto.IdRef_RubroProducto1
            comando.Parameters.Add("@idref_tipoproducto", MySqlDbType.Int32).Value = producto.IdRef_TipoProduto1
            comando.Parameters.Add("@idref_tipoenvase", MySqlDbType.Int32).Value = producto.IdRef_TipoEnvase1
            comando.Parameters.Add("@idref_marca", MySqlDbType.Int32).Value = producto.IdRef_Marca1
            comando.ExecuteNonQuery()
        End If

        MsgBox("Producto actualizado correctamente", vbOKOnly)

        conectar.cerrarConexion()
    End Function

    Public Function ActualizarPrecioDeVentaDeProducto(preciosNuevos As List(Of Producto))
        Dim conectar As New ConexionBDD
        For Each producto In preciosNuevos
            Dim comando As New MySqlCommand("UPDATE producto SET idpreciodeventa=@idpreciodeventa where idproducto='" & producto.IdProducto1 & "'", conectar.ObtenerConexion())
            comando.Parameters.Add("@idpreciodeventa", MySqlDbType.Int32).Value = producto.IdPrecioDeVenta1
            comando.ExecuteNonQuery()
        Next
    End Function

    'OBTENEMOS EL ULTIMO ID DE VENTA
    Public Function ObtenerUltimoiddeVenta() As Integer
        Dim conectar = New ConexionBDD
        Dim comando As New MySqlCommand("Select max(idVenta) From ventas", conectar.ObtenerConexion())
        comando.CommandType = CommandType.Text
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim idVenta As New Integer
        While reader.Read()
            If reader.Read Then 'VERIFICA QUE EL DATAREADER NO ESTÉ VACÍO (PUEDE PASAR PORQUE LA TABLA ESTÁ VACÍA)
                idVenta = reader(0)
            End If
        End While

        conectar.cerrarConexion()
        Return idVenta
    End Function

    'OBTENEMOS EL PRODUCTO FILTRADO POR CODIGO DE BARRAS
    Public Function ObtenerProductoVenta(codigoBarras As String) As Producto
        Dim conectar = New ConexionBDD
        Dim producto As New Producto
        Dim comando As New MySqlCommand("SELECT * from producto where codigobarras = " & codigoBarras & "", conectar.ObtenerConexion())
        comando.CommandType = CommandType.Text
        comando.Connection = conectar.ObtenerConexion()
        'MsgBox(comando.CommandText)
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        'Dim nombre As String
        While reader.Read()
            producto.IdProducto1 = reader(0)
            producto.NombreProducto1 = reader(1)
            producto.IdRef_UnidadDeMedida1 = reader(2)
            producto.Medida1 = reader(3)
            producto.CodigoBarras1 = reader(4)
            producto.StockMinimo1 = reader(5)
            producto.IdRef_RubroProducto1 = reader(6)
            producto.IdRef_TipoProduto1 = reader(7)
            producto.IdRef_TipoEnvase1 = reader(8)
            producto.IdRef_Marca1 = reader(9)
            producto.IdPrecioDeVenta1 = reader(10)
        End While

        conectar.cerrarConexion()
        Return producto
    End Function

    Public Function MostrarCondicionesDeVentaCompra() As List(Of Ref_CondicionVentaCompra)
        Dim comando As New MySqlCommand("SELECT * FROM ref_condicionventacompra order by nombrecondicion")
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim lista = New List(Of Ref_CondicionVentaCompra)
        While reader.Read()
            Dim condicion As New Ref_CondicionVentaCompra
            condicion.IdRef_CondicionVentaCompra1 = reader(0)
            condicion.NombreCondicion1 = reader(1)
            lista.Add(condicion)
        End While

        conectar.cerrarConexion()
        Return lista
    End Function

    'REGISTRAR NUEVA VENTA
    Public Function registrarNuevaVenta(Venta As Ventas)
        Dim conectar = New ConexionBDD
        Dim comandoPrecio As New MySqlCommand("INSERT INTO ventas (fechaVenta, importeTotalDeVenta, idRef_CondicionVentaCompra, idcliente) VALUES (@fecha, @importe, @idcondicion, @idcliente)", conectar.ObtenerConexion())
        comandoPrecio.Parameters.Add("@fecha", MySqlDbType.Date).Value = Venta.FechaVenta1
        comandoPrecio.Parameters.Add("@importe", MySqlDbType.Double).Value = Venta.ImporteTotalDeVenta1
        comandoPrecio.Parameters.Add("@idcondicion", MySqlDbType.Int32).Value = Venta.IdRef_CondicionVentaCompra1
        comandoPrecio.Parameters.Add("@idcliente", MySqlDbType.Int32).Value = Venta.IdCliente1
        comandoPrecio.ExecuteNonQuery()

        conectar.cerrarConexion()
    End Function

    'REGISTRAR NUEVA COMPRA
    Public Function registrarNuevaCompra(Compra As Compras)
        Dim conectar = New ConexionBDD
        Dim comandoPrecio As New MySqlCommand("INSERT INTO compras (fechacompra, importeTotalDecompra, idRef_CondicionVentaCompra, idproveedor) VALUES (@fecha, truncate(@importe,2), @idcondicion, @idproveedor)", conectar.ObtenerConexion())
        comandoPrecio.Parameters.Add("@fecha", MySqlDbType.Date).Value = Compra.FechaCompra1
        comandoPrecio.Parameters.Add("@importe", MySqlDbType.Double).Value = Math.Round(Compra.ImporteTotalDeCompra1, 2)
        comandoPrecio.Parameters.Add("@idcondicion", MySqlDbType.Int32).Value = Compra.IdRef_CondicionVentaCompra1
        comandoPrecio.Parameters.Add("@idproveedor", MySqlDbType.Int32).Value = Compra.IdProveedor1
        comandoPrecio.ExecuteNonQuery()

        conectar.cerrarConexion()
    End Function

    'INSERTA DETALLE DE VENTA DE PRODUCTOS CON CODIGO DE BARRAS
    Public Function registrarDetalleDeVenta(Detalle As List(Of DetalleVenta))
        Dim conectar = New ConexionBDD
        For Each producto In Detalle
            Dim comandoPrecio As New MySqlCommand("INSERT INTO detalleVenta (idVenta, Cantidad, Importe, idProducto) VALUES (@idVenta, @cantidad, @importe, @idProducto)", conectar.ObtenerConexion())
            comandoPrecio.Parameters.Add("@idVenta", MySqlDbType.Int32).Value = producto.IdVenta1
            comandoPrecio.Parameters.Add("@cantidad", MySqlDbType.Int32).Value = producto.Cantidad1
            comandoPrecio.Parameters.Add("@importe", MySqlDbType.Float).Value = producto.Importe1
            comandoPrecio.Parameters.Add("@idProducto", MySqlDbType.Int32).Value = producto.IdProducto1
            comandoPrecio.ExecuteNonQuery()
        Next

        'conectar.cerrarConexion()
    End Function

    'INSERTA DETALLE DE VENTA DE PRODUCTOS SIN CODIGO DE BARRAS
    Public Function registrarDetalleDeVentaSinCodigoDeBarras(Detalle As List(Of DetalleVentaSinCodigo))
        Dim conectar = New ConexionBDD
        For Each producto In Detalle
            Dim comandoPrecio As New MySqlCommand("INSERT INTO detalleVentasincodigo (idVenta, Cantidad, Importe, idProductosincodigo) VALUES (@idVenta, @cantidad, @importe, @idProductosincodigo)", conectar.ObtenerConexion())
            comandoPrecio.Parameters.Add("@idVenta", MySqlDbType.Int32).Value = producto.IdVenta1
            comandoPrecio.Parameters.Add("@cantidad", MySqlDbType.Int32).Value = producto.Cantidad1
            comandoPrecio.Parameters.Add("@importe", MySqlDbType.Float).Value = producto.Importe1
            comandoPrecio.Parameters.Add("@idProductosincodigo", MySqlDbType.Int32).Value = producto.IdProductoSinCodigo1
            comandoPrecio.ExecuteNonQuery()
        Next

        'conectar.cerrarConexion()
    End Function

    'INSERTA DETALLE DE COMPRA DE PRODUCTOS SIN CODIGO DE BARRAS
    Public Function registrarDetalleDeCompraSinCodigoDeBarras(Detalle As List(Of DetalleCompraSinCodigo))
        Dim conectar = New ConexionBDD
        For Each producto In Detalle
            Dim comandoPrecio As New MySqlCommand("INSERT INTO detallecomprasincodigo (idcompra, Cantidad, Importe, idProductosincodigo) VALUES (@idcompra, @cantidad, @importe, @idProductosincodigo)", conectar.ObtenerConexion())
            comandoPrecio.Parameters.Add("@idcompra", MySqlDbType.Int32).Value = producto.IdCompra1
            comandoPrecio.Parameters.Add("@cantidad", MySqlDbType.Int32).Value = producto.Cantidad1
            comandoPrecio.Parameters.Add("@importe", MySqlDbType.Float).Value = producto.Importe1
            comandoPrecio.Parameters.Add("@idProductosincodigo", MySqlDbType.Int32).Value = producto.IdProductoSinCodigo1
            comandoPrecio.ExecuteNonQuery()
        Next

        'conectar.cerrarConexion()
    End Function

    'INSERTA DETALLE DE COMPRA
    Public Function registrarDetalleDeCompra(Detalle As List(Of DetalleCompra))
        Dim conectar = New ConexionBDD
        For Each producto In Detalle
            Dim comandoPrecio As New MySqlCommand("INSERT INTO detallecompra (idCompra, Cantidad, Importe, idProducto) VALUES (@idcompra, @cantidad, @importe, @idProducto)", conectar.ObtenerConexion())
            comandoPrecio.Parameters.Add("@idcompra", MySqlDbType.Int32).Value = producto.IdCompra1
            comandoPrecio.Parameters.Add("@cantidad", MySqlDbType.Int32).Value = producto.Cantidad1
            comandoPrecio.Parameters.Add("@importe", MySqlDbType.Float).Value = producto.Importe1
            comandoPrecio.Parameters.Add("@idProducto", MySqlDbType.Int32).Value = producto.IdProducto1
            comandoPrecio.ExecuteNonQuery()
        Next

        conectar.cerrarConexion()
    End Function

    'TRAE ULTIMO ID DE VENTA
    Public Function RecuperaUltimoIdVenta() As Integer
        Dim conectar = New ConexionBDD
        Dim comando As New MySqlCommand("SELECT if(max(idVenta)>0,max(idventa),1) FROM Ventas")
        comando.CommandType = CommandType.Text
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim idVenta As Integer
        While reader.Read()
            idVenta = reader(0)
        End While

        conectar.cerrarConexion()

        If idVenta > 0 Then
            Return idVenta
        Else
            idVenta = 1
            Return idVenta
        End If
    End Function

    'TRAE ULTIMO ID DE COMPRA
    Public Function RecuperaUltimoIdCompra() As Integer
        Dim conectar = New ConexionBDD
        Dim comando As New MySqlCommand("SELECT if(max(idCompra)>0,max(idcompra),1) FROM Compras")
        comando.CommandType = CommandType.Text
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim idCompra As Integer
        While reader.Read()
            idCompra = reader(0)
        End While

        conectar.cerrarConexion()

        If idCompra > 0 Then
            Return idCompra
        Else
            idCompra = 1
            Return idCompra
        End If
    End Function

    Public Function DescuentaStockPorVenta(idProducto As Integer, cantidad As Integer)
        Dim conectar As New ConexionBDD
        Dim traeStock As New MySqlCommand("SELECT stock FROM stock where idproducto='" & idProducto & "'")
        traeStock.CommandType = CommandType.Text
        traeStock.Connection = conectar.ObtenerConexion()
        Dim stock As Integer
        Dim reader As MySqlDataReader
        reader = traeStock.ExecuteReader()
        While reader.Read()
            stock = reader(0)
        End While

        stock -= cantidad

        Dim comando As New MySqlCommand("UPDATE stock SET stock=@stock where idproducto='" & idProducto & "'", conectar.ObtenerConexion())
        comando.Parameters.Add("@stock", MySqlDbType.Int32).Value = stock
        comando.ExecuteNonQuery()

        conectar.cerrarConexion()
    End Function

    Public Function AgregaStockPorCompra(idProducto As Integer, cantidad As Integer)
        Dim conectar As New ConexionBDD
        Dim traeStock As New MySqlCommand("SELECT if(count(stock)>0,stock,'vacio') FROM stock where idproducto='" & idProducto & "'")
        traeStock.CommandType = CommandType.Text
        traeStock.Connection = conectar.ObtenerConexion()
        Dim stock As String
        Dim reader As MySqlDataReader
        reader = traeStock.ExecuteReader()
        While reader.Read()
            stock = reader(0)
        End While

        If stock = "vacio" Then
            Dim comandoPrecio As New MySqlCommand("INSERT INTO stock (idproducto, stock) VALUES (@idproducto, @stock)", conectar.ObtenerConexion())
            comandoPrecio.Parameters.Add("@idproducto", MySqlDbType.Int32).Value = idProducto
            comandoPrecio.Parameters.Add("@stock", MySqlDbType.Int32).Value = cantidad
            comandoPrecio.ExecuteNonQuery()
        Else
            Dim stockEnNumero As Integer = Integer.Parse(stock)
            stockEnNumero += cantidad

            Dim comando As New MySqlCommand("UPDATE stock SET stock=@stock where idproducto='" & idProducto & "'", conectar.ObtenerConexion())
            comando.Parameters.Add("@stock", MySqlDbType.Int32).Value = stockEnNumero
            comando.ExecuteNonQuery()
        End If

        conectar.cerrarConexion()
    End Function

    Public Function VerificaStock(idProducto As Integer, cantidad As Integer)
        Dim conectar As New ConexionBDD
        Dim traeStock As New MySqlCommand("SELECT stock FROM stock where idproducto='" & idProducto & "'")
        traeStock.CommandType = CommandType.Text
        traeStock.Connection = conectar.ObtenerConexion()
        Dim stock As Integer
        Dim reader As MySqlDataReader
        reader = traeStock.ExecuteReader()
        While reader.Read()
            stock = reader(0)
        End While

        stock -= cantidad

        Dim traeStockMinimo As New MySqlCommand("SELECT nombreproducto, stockMinimo FROM producto WHERE idproducto='" & idProducto & "'")
        traeStockMinimo.CommandType = CommandType.Text
        traeStockMinimo.Connection = conectar.ObtenerConexion()
        Dim stockMinimo As Integer
        Dim nombre As String
        reader = traeStockMinimo.ExecuteReader()
        While reader.Read()
            nombre = reader(0)
            stockMinimo = reader(1)
        End While

        'If stock < stockMinimo Then
        '    MessageBox.Show("El producto " & nombre & " tiene un stock de " & stock & ". Debería reponer")
        'End If

        conectar.cerrarConexion()
    End Function

    Public Function TraeUltimoIdPrecioDeVenta() As Integer
        Dim conectar As New ConexionBDD
        Dim traeUltimoIdDePrecioDeVenta As New MySqlCommand("SELECT max(idpreciodeventa) FROM preciodeventa")
        traeUltimoIdDePrecioDeVenta.CommandType = CommandType.Text
        traeUltimoIdDePrecioDeVenta.Connection = conectar.ObtenerConexion()
        Dim id As Integer
        Dim reader As MySqlDataReader
        reader = traeUltimoIdDePrecioDeVenta.ExecuteReader()
        While reader.Read()
            id = reader(0)
        End While

        conectar.cerrarConexion()
        Return id
    End Function

    'TRAE DATOS DE COMPRAS Y VENTAS DE PRODUCTOS
    Public Function GeneraInforme(FechaDesde As String, FechaHasta As String, tipo As String, agrupado As String) As MySqlDataAdapter
        If tipo = "Compras" And agrupado = "Totales" Then
            Dim comando As String = "SELECT com.idCompra as Id, com.FechaCOMPRA as Fecha, com.importeTotalDeCompra as Importe, cond.Nombrecondicion as Condicion from compras as com LEFT join ref_condicionventacompra as cond on cond.idRef_CondicionVentaCompra = com.idRef_CondicionVentaCompra WHERE com.fechaCompra >= '" & FechaDesde & "' and com.fechaCompra <= '" & FechaHasta & "'"
            Dim conectar = New ConexionBDD
            Dim mda = New MySqlDataAdapter(comando, conectar.ObtenerConexion())

            conectar.cerrarConexion()
            Return mda
        End If

        If tipo = "Compras" And agrupado = "detalle" Then
            Dim comando As String = "SELECT det.iddetallecompra as 'Id detalle', com.fechacompra as Fecha, det.idcompra as 'Id compra', det.cantidad as Cantidad, det.importe as Importe, prod.nombreproducto as Producto FROM detallecompra as det LEFT join producto as prod on det.idProducto = prod.idProducto LEFT JOIN compras as com on det.idcompra = com.idcompra  WHERE com.fechacompra >= '" & FechaDesde & "' and com.fechacompra <= '" & FechaHasta & "' UNION SELECT detsc.iddetallecomprasincodigo as 'Id detalle', com.fechacompra as Fecha, detsc.idcompra as 'Id compra', detsc.cantidad as Cantidad, detsc.importe as Importe, prodsc.nombre as Producto FROM detallecomprasincodigo as detsc LEFT join productosincodigo as prodsc on detsc.idProductoSinCodigo = prodsc.idProductoSinCodigo LEFT JOIN compras as com on detsc.idcompra = com.idcompra  WHERE com.fechacompra >= '" & FechaDesde & "' and com.fechacompra <= '" & FechaHasta & "' order by Fecha asc, `Id compra` asc"
            Dim conectar = New ConexionBDD
            Dim mda = New MySqlDataAdapter(comando, conectar.ObtenerConexion())

            conectar.cerrarConexion()
            Return mda
        End If

        If tipo = "Ventas" And agrupado = "Totales" Then
            Dim comando As String = "SELECT Ven.idVenta as Id, ven.FechaVenta as Fecha, ven.importeTotalDeVenta as Importe, cond.Nombrecondicion as Condicion from Ventas as ven LEFT join ref_condicionventacompra as cond on cond.idRef_CondicionVentaCompra = ven.idRef_CondicionVentaCompra WHERE ven.fechaVenta >= '" & FechaDesde & "' and ven.fechaVenta <= '" & FechaHasta & "'"
            Dim conectar = New ConexionBDD
            Dim mda = New MySqlDataAdapter(comando, conectar.ObtenerConexion())

            conectar.cerrarConexion()
            Return mda
        End If

        If tipo = "Ventas" And agrupado = "detalle" Then
            Dim comando As String = "SELECT det.iddetalleventa as 'Id detalle', ven.fechaventa as Fecha, det.idVenta as 'Id venta', det.cantidad as Cantidad, det.importe as Importe, prod.nombreproducto as Producto FROM detalleventa as det LEFT join producto as prod on det.idProducto = prod.idProducto LEFT JOIN ventas as ven on det.idVenta = ven.idVenta WHERE ven.fechaVenta >= '" & FechaDesde & "' and ven.fechaVenta <= '" & FechaHasta & "' UNION SELECT detsc.iddetalleventasincodigo as 'Id detalle', ven.fechaventa as Fecha, detsc.idVenta as 'Id venta', detsc.cantidad as Cantidad, detsc.importe as Importe, prodsc.nombre as Producto FROM detalleventasincodigo as detsc LEFT join productosincodigo as prodsc on detsc.idProductosincodigo = prodsc.idProductosincodigo LEFT JOIN ventas as ven on detsc.idVenta = ven.idVenta WHERE ven.fechaVenta >= '" & FechaDesde & "' and ven.fechaVenta <= '" & FechaHasta & "' order BY Fecha asc, `Id venta` asc"
            Dim conectar = New ConexionBDD
            Dim mda = New MySqlDataAdapter(comando, conectar.ObtenerConexion())

            conectar.cerrarConexion()
            Return mda
        End If
    End Function

    Public Function ExportaInformeAExcel(dgvInformes As DataGridView)
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = dgvInformes.ColumnCount
            Dim NRow As Integer = dgvInformes.RowCount

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = dgvInformes.Columns(i - 1).HeaderText.ToString
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = dgvInformes.Rows(Fila).Cells(Col).Value
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna seajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()


            'Aplicación visible
            exApp.Application.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

        End Try
    End Function

    'TRAE LOS TIPOS DE TELEFONOS
    Public Function MostrarTiposDeTelefono() As List(Of Ref_TipoTelefono)
        Dim comando As New MySqlCommand("SELECT * FROM ref_tipotelefono order by nombre")
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim listaTipos = New List(Of Ref_TipoTelefono)
        While reader.Read()
            Dim tipo As New Ref_TipoTelefono
            tipo.IdRef_TipoTelefono1 = reader(0)
            tipo.Nombre1 = reader(1)
            listaTipos.Add(tipo)
        End While

        conectar.cerrarConexion()
        Return listaTipos
    End Function

    'TRAE LAS CALLES    
    Public Function MostrarCalles() As List(Of Ref_Calle)
        Dim comando As New MySqlCommand("SELECT * FROM ref_Calle order by nombre")
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim listaCalles = New List(Of Ref_Calle)
        While reader.Read()
            Dim calle As New Ref_Calle
            calle.IdRef_Calle1 = reader(0)
            calle.Nombre1 = reader(1)
            listaCalles.Add(calle)
        End While

        conectar.cerrarConexion()
        Return listaCalles
    End Function

    'GUARDA NÚMERO DE TELÉFONO
    Public Function GuardaNumeroDeTelefono(telefono As Telefono)
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("INSERT INTO telefono (codarea, numero, idref_tipotelefono) VALUES (@codarea, @numero, @tipo)", conectar.ObtenerConexion())
        comando.Parameters.Add("@codarea", MySqlDbType.String).Value = telefono.CodArea1
        comando.Parameters.Add("@numero", MySqlDbType.String).Value = telefono.Numero1
        comando.Parameters.Add("@tipo", MySqlDbType.Int32).Value = telefono.IdRef_TipoTelefono1
        comando.ExecuteNonQuery()

        conectar.cerrarConexion()
    End Function

    'GUARDA NUEVO DOMICILIO
    Public Function GuardaDomicilio(domicilio As Domicilio)
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("INSERT INTO domicilio (idref_calle, numero, piso, dpto, idref_localidad) VALUES (@idcalle, @numero, @piso, @dpto, @localidad)", conectar.ObtenerConexion())
        comando.Parameters.Add("@idcalle", MySqlDbType.Int32).Value = domicilio.IdRef_Calle1
        comando.Parameters.Add("@numero", MySqlDbType.Int32).Value = domicilio.Numero1
        comando.Parameters.Add("@piso", MySqlDbType.String).Value = domicilio.Piso1
        comando.Parameters.Add("@dpto", MySqlDbType.String).Value = domicilio.Dpto1
        comando.Parameters.Add("@localidad", MySqlDbType.String).Value = domicilio.IdRef_Localidad1
        comando.ExecuteNonQuery()

        conectar.cerrarConexion()
    End Function

    'RECUPERA EL ULTIMO ID DE DOMICILIO
    Public Function RecuperaUltimoIdDomicilio() As Integer
        Dim conectar = New ConexionBDD
        Dim comando As New MySqlCommand("SELECT if(max(iddomicilio)>0,max(iddomicilio),1) FROM domicilio")
        comando.CommandType = CommandType.Text
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim idDomicilio As Integer
        While reader.Read()
            idDomicilio = reader(0)
        End While

        conectar.cerrarConexion()

        Return idDomicilio
    End Function

    'RECUPERA EL ULTIMO ID DE TELEFONO
    Public Function RecuperaUltimoIdTelefono() As Integer
        Dim conectar = New ConexionBDD
        Dim comando As New MySqlCommand("SELECT if(max(idtelefono)>0,max(idtelefono),1) FROM telefono")
        comando.CommandType = CommandType.Text
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim idTelefono As Integer
        While reader.Read()
            idTelefono = reader(0)
        End While

        conectar.cerrarConexion()

        Return idTelefono
    End Function

    'GUARDA PROVEEDOR NUEVO
    Public Function GuardaProveedorNuevo(proveedor As Proveedor)
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("INSERT INTO proveedor (razonsocial, cuit, iddomicilio, email, observaciones) VALUES (@razonsocial, @cuit, @iddomicilio, @email, @observacion)", conectar.ObtenerConexion())
        comando.Parameters.Add("@razonsocial", MySqlDbType.String).Value = proveedor.RazonSocial1
        comando.Parameters.Add("@cuit", MySqlDbType.String).Value = proveedor.Cuit1
        comando.Parameters.Add("@iddomicilio", MySqlDbType.Int32).Value = proveedor.IdDomicilio1
        comando.Parameters.Add("@email", MySqlDbType.String).Value = proveedor.Email1
        comando.Parameters.Add("@observacion", MySqlDbType.String).Value = proveedor.Observaciones1
        comando.ExecuteNonQuery()

        conectar.cerrarConexion()
    End Function

    'GUARDA PERSONA NUEVA
    Public Function GuardaPersonaNueva(persona As Persona)
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("INSERT INTO persona (apellidoynombre, dni, iddomicilio, email) VALUES (@apeynom, @dni, @iddomicilio, @email)", conectar.ObtenerConexion())
        comando.Parameters.Add("@apeynom", MySqlDbType.String).Value = persona.ApellidoYNombre1
        comando.Parameters.Add("@dni", MySqlDbType.String).Value = persona.Dni1
        comando.Parameters.Add("@iddomicilio", MySqlDbType.Int32).Value = persona.IdDomicilio1
        comando.Parameters.Add("@email", MySqlDbType.String).Value = persona.Email1
        comando.ExecuteNonQuery()

        conectar.cerrarConexion()
    End Function

    'GUARDA CLIENTE NUEVO
    Public Function GuardaClienteNuevo(cliente As Cliente)
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("INSERT INTO cliente (idpersona, cuil, observaciones) VALUES (@idpersona, @cuil, @observacion)", conectar.ObtenerConexion())
        comando.Parameters.Add("@idpersona", MySqlDbType.Int32).Value = cliente.IdPersona1
        comando.Parameters.Add("@cuil", MySqlDbType.String).Value = cliente.Cuil1
        comando.Parameters.Add("@observacion", MySqlDbType.String).Value = cliente.Observaciones1
        comando.ExecuteNonQuery()

        conectar.cerrarConexion()
    End Function

    'GUARDA RELACIÓN ENTRE TELÉFONO Y PROVEEDOR
    Public Function GuardaTelefonoEnProveedor(telefono As Proveedor_has_Telefono)
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("INSERT INTO proveedor_has_telefono (idproveedor, idtelefono) VALUES (@proveedor, @telefono)", conectar.ObtenerConexion())
        comando.Parameters.Add("@proveedor", MySqlDbType.Int32).Value = telefono.IdProveedor1
        comando.Parameters.Add("@telefono", MySqlDbType.Int32).Value = telefono.IdTelefono1
        comando.ExecuteNonQuery()

        conectar.cerrarConexion()
    End Function

    'GUARDA RELACIÓN ENTRE TELÉFONO Y PERSONA
    Public Function GuardaTelefonoEnPersona(telefono As Persona_has_Telefono)
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("INSERT INTO persona_has_telefono (idpersona, idtelefono) VALUES (@persona, @telefono)", conectar.ObtenerConexion())
        comando.Parameters.Add("@persona", MySqlDbType.Int32).Value = telefono.IdPersona1
        comando.Parameters.Add("@telefono", MySqlDbType.Int32).Value = telefono.IdTelefono1
        comando.ExecuteNonQuery()

        conectar.cerrarConexion()
    End Function

    'RECUPERA EL ULTIMO ID DE PROVEEDOR
    Public Function RecuperaUltimoIdProveedor() As Integer
        Dim conectar = New ConexionBDD
        Dim comando As New MySqlCommand("SELECT if(max(idproveedor)>0,max(idproveedor),1) FROM proveedor")
        comando.CommandType = CommandType.Text
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim idProveedor As Integer
        While reader.Read()
            idProveedor = reader(0)
        End While

        conectar.cerrarConexion()

        Return idProveedor
    End Function

    'RECUPERA EL ULTIMO ID DE PERSONA
    Public Function RecuperaUltimoIdPersona() As Integer
        Dim conectar = New ConexionBDD
        Dim comando As New MySqlCommand("SELECT if(max(idpersona)>0,max(idpersona),1) FROM persona")
        comando.CommandType = CommandType.Text
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim idPersona As Integer
        While reader.Read()
            idPersona = reader(0)
        End While

        conectar.cerrarConexion()

        Return idPersona
    End Function

    'TRAE ESPECIFICACIONES
    Public Function TraeEspecificaciones(especificacion As String)
        Dim comando As String
        If especificacion = "productosincodigo" Then
            comando = "SELECT nombre as Nombre FROM productosincodigo order by nombre"
        Else
            comando = "SELECT nombre" & especificacion & " as Nombre FROM ref_" & especificacion & " order by nombre" & especificacion
        End If
        Dim conectar = New ConexionBDD
        Dim mda = New MySqlDataAdapter(comando, conectar.ObtenerConexion())

        conectar.cerrarConexion()
        Return mda
    End Function

    'TRAE PROVEEDORES
    Public Function TraeProveedores() As List(Of Proveedor)
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("SELECT * FROM proveedor")
        comando.CommandType = CommandType.Text
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        Dim listaDeProveedores As New List(Of Proveedor)
        reader = comando.ExecuteReader()
        While reader.Read()
            Dim proveedores As New Proveedor
            proveedores.IdProveedor1 = reader(0)
            proveedores.RazonSocial1 = reader(1)
            proveedores.Cuit1 = reader(2)
            proveedores.IdDomicilio1 = reader(3)
            If Not IsDBNull(reader(4)) Then
                proveedores.Email1 = reader(4)
            End If
            listaDeProveedores.Add(proveedores)
        End While

        conectar.cerrarConexion()
        Return listaDeProveedores
    End Function

    'TRAE TODOS LOS CLIENTE CON LOS DATOS DE LA TABLA PERSONA
    Public Function TraeClientes() As List(Of Persona)
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("SELECT cli.idpersona, per.apellidoynombre FROM cliente as cli LEFT JOIN persona as per on cli.idPersona=per.idPersona")
        comando.CommandType = CommandType.Text
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        Dim listaDeClientes As New List(Of Persona)
        reader = comando.ExecuteReader()
        While reader.Read()
            Dim persona As New Persona
            persona.IdPersona1 = reader(0)
            persona.ApellidoYNombre1 = reader(1)
            listaDeClientes.Add(persona)
        End While

        conectar.cerrarConexion()
        Return listaDeClientes
    End Function

    'TRAE CLIENTE POR ID DE PERSONA
    Public Function TraeClientePorIdDePersona(id As Integer) As Integer
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("SELECT idcliente FROM cliente WHERE idpersona=" & id)
        comando.CommandType = CommandType.Text
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        Dim idCliente As Integer
        reader = comando.ExecuteReader()
        While reader.Read()
            idCliente = reader(0)
        End While

        conectar.cerrarConexion()
        Return idCliente
    End Function

    'TRAE CLIENTE POR ID
    Public Function TraeClientePorId(id As Integer) As Cliente
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("SELECT * FROM cliente WHERE idcliente=" & id)
        comando.CommandType = CommandType.Text
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        Dim cliente As New Cliente
        reader = comando.ExecuteReader()
        While reader.Read()
            cliente.IdCliente1 = reader(0)
            cliente.IdPersona1 = reader(1)
            cliente.Cuil1 = reader(2)
            cliente.Observaciones1 = reader(3)
        End While

        conectar.cerrarConexion()
        Return cliente
    End Function

    'TRAE PERSONA POR ID
    Public Function TraePersonaPorId(id As Integer) As Persona
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("SELECT * FROM persona WHERE idpersona=" & id)
        comando.CommandType = CommandType.Text
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        Dim persona As New Persona
        reader = comando.ExecuteReader()
        While reader.Read()
            persona.IdPersona1 = reader(0)
            persona.ApellidoYNombre1 = reader(1)
            persona.Dni1 = reader(2)
            persona.IdDomicilio1 = reader(3)
            persona.Email1 = reader(4)
        End While

        conectar.cerrarConexion()
        Return persona
    End Function

    'TRAE PROVEEDOR POR ID
    Public Function TraeProveedorPorId(id As Integer) As Proveedor
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("SELECT * FROM proveedor WHERE idproveedor=" & id)
        comando.CommandType = CommandType.Text
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        Dim proveedor As New Proveedor
        reader = comando.ExecuteReader()
        While reader.Read()
            proveedor.IdProveedor1 = reader(0)
            proveedor.RazonSocial1 = reader(1)
            proveedor.Cuit1 = reader(2)
            proveedor.IdDomicilio1 = reader(3)
            proveedor.Email1 = reader(4)
            proveedor.Observaciones1 = reader(5)
        End While

        conectar.cerrarConexion()
        Return proveedor
    End Function

    'TRAE DOMICILIO POR ID
    Public Function TraeDomicilioPorId(id As Integer) As Domicilio
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("SELECT * FROM domicilio WHERE iddomicilio=" & id)
        comando.CommandType = CommandType.Text
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        Dim domicilio As New Domicilio
        reader = comando.ExecuteReader()
        While reader.Read()
            domicilio.IdDomicilio1 = reader(0)
            domicilio.IdRef_Calle1 = reader(1)
            domicilio.Numero1 = reader(2)
            domicilio.Piso1 = reader(3)
            domicilio.Dpto1 = reader(4)
            domicilio.IdRef_Localidad1 = reader(5)
        End While

        conectar.cerrarConexion()
        Return domicilio
    End Function

    'TRAE CALLE POR ID
    Public Function TraeCallePorId(id As Integer) As String
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("SELECT nombre FROM ref_calle WHERE idref_calle=" & id)
        comando.CommandType = CommandType.Text
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        Dim calle As String
        reader = comando.ExecuteReader()
        While reader.Read()
            calle = reader(0)
        End While

        conectar.cerrarConexion()
        Return calle
    End Function

    'TRAE TELÉFONO POR ID DE PERSONA
    Public Function TraeTelefonoPorId(id As Integer) As Telefono
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("SELECT idtelefono FROM persona_has_telefono WHERE idpersona=" & id)
        comando.CommandType = CommandType.Text
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        Dim idtelefono As Integer
        reader = comando.ExecuteReader()
        While reader.Read()
            idtelefono = reader(0)
        End While

        Dim comando2 As New MySqlCommand("SELECT * FROM telefono where idtelefono=" & idtelefono)
        comando2.CommandType = CommandType.Text
        comando2.Connection = conectar.ObtenerConexion()
        Dim telefono As New Telefono
        reader = comando2.ExecuteReader()
        While reader.Read
            telefono.IdTelefono1 = reader(0)
            telefono.CodArea1 = reader(1)
            telefono.Numero1 = reader(2)
            telefono.IdRef_TipoTelefono1 = reader(3)
        End While

        conectar.cerrarConexion()
        Return telefono
    End Function

    'TRAE TELÉFONO POR ID DE PROVEEDOR
    Public Function TraeTelefonoPorIdDeProveedor(id As Integer) As Telefono
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("SELECT idtelefono FROM proveedor_has_telefono WHERE idproveedor=" & id)
        comando.CommandType = CommandType.Text
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        Dim idtelefono As Integer
        reader = comando.ExecuteReader()
        While reader.Read()
            idtelefono = reader(0)
        End While

        Dim comando2 As New MySqlCommand("SELECT * FROM telefono where idtelefono=" & idtelefono)
        comando2.CommandType = CommandType.Text
        comando2.Connection = conectar.ObtenerConexion()
        Dim telefono As New Telefono
        reader = comando2.ExecuteReader()
        While reader.Read
            telefono.IdTelefono1 = reader(0)
            telefono.CodArea1 = reader(1)
            telefono.Numero1 = reader(2)
            telefono.IdRef_TipoTelefono1 = reader(3)
        End While

        conectar.cerrarConexion()
        Return telefono
    End Function

    'TRAE TIPO DE TELEFONO POR ID
    Public Function TraeTipoDeTelefonoPorId(id As Integer) As String
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("SELECT nombre FROM ref_tipotelefono WHERE idref_tipotelefono=" & id)
        comando.CommandType = CommandType.Text
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        Dim tipoTelefono As String
        reader = comando.ExecuteReader()
        While reader.Read()
            tipoTelefono = reader(0)
        End While

        conectar.cerrarConexion()
        Return tipoTelefono
    End Function

    'TRAE LOCALIDAD POR ID
    Public Function TraeLocalidadPorId(id As Integer) As String
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("SELECT nombre FROM ref_localidad WHERE idref_localidad=" & id)
        comando.CommandType = CommandType.Text
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        Dim localidad As String
        reader = comando.ExecuteReader()
        While reader.Read()
            localidad = reader(0)
        End While

        conectar.cerrarConexion()
        Return localidad
    End Function

    'TRAE PADRÓN DE CLIENTES CON SUS DATOS
    Public Function TraePadronClientes(filtro As String)
        Dim comando As String
        If filtro = "" Then
            comando = "SELECT cli.idcliente as ID, cli.cuil as CUIL, per.apellidoynombre as `Apellido y nombre`, cal.nombre as Calle, dom.numero as `Nro.`, dom.piso as Piso, dom.dpto as `Dpto.`, per.email as `E-mail` FROM cliente as cli LEFT JOIN persona as per on cli.idpersona=per.idpersona LEFT JOIN domicilio as dom on per.idDomicilio=dom.idDomicilio LEFT JOIN ref_calle as cal on dom.idref_calle=cal.idref_calle where cli.idcliente<>1 limit 15"
        Else
            comando = "SELECT cli.idcliente as ID, cli.cuil as CUIL, per.apellidoynombre as `Apellido y nombre`, cal.nombre as Calle, dom.numero as `Nro.`, dom.piso as Piso, dom.dpto as `Dpto.`, per.email as `E-mail` FROM cliente as cli LEFT JOIN persona as per on cli.idpersona=per.idpersona LEFT JOIN domicilio as dom on per.idDomicilio=dom.idDomicilio LEFT JOIN ref_calle as cal on dom.idref_calle=cal.idref_calle where cli.idcliente<>1 and per.apellidoynombre like '%" & filtro & "%'"
        End If

        Dim conectar = New ConexionBDD
        Dim mda = New MySqlDataAdapter(comando, conectar.ObtenerConexion())

        conectar.cerrarConexion()
        Return mda
    End Function

    'TRAE PADRÓN DE PROVEEDORES CON SUS DATOS
    Public Function TraePadronProveedores(filtro As String)
        Dim comando As String
        If filtro = "" Then
            comando = "SELECT prov.idproveedor as ID, prov.cuit as CUIT, prov.razonsocial as Nombre, cal.nombre as Calle, dom.numero as `Nro.`, dom.piso as Piso, dom.dpto as `Dpto.`, prov.email as `E-mail` FROM proveedor as prov LEFT JOIN domicilio as dom on prov.iddomicilio=dom.idDomicilio LEFT JOIN ref_calle as cal on dom.idref_calle=cal.idRef_Calle limit 15"
        Else
            comando = "SELECT prov.idproveedor as ID, prov.cuit as CUIT, prov.razonsocial as Nombre, cal.nombre as Calle, dom.numero as `Nro.`, dom.piso as Piso, dom.dpto as `Dpto.`, prov.email as `E-mail` FROM proveedor as prov LEFT JOIN domicilio as dom on prov.iddomicilio=dom.idDomicilio LEFT JOIN ref_calle as cal on dom.idref_calle=cal.idRef_Calle where prov.razonsocial like '%" & filtro & "%'"
        End If
        Dim conectar As New ConexionBDD
        Dim mda As New MySqlDataAdapter(comando, conectar.ObtenerConexion())

        conectar.cerrarConexion()
        Return mda
    End Function

    'TRAE LOCALIDADES PARA MOSTRAR EN COMBO
    Public Function MostrarLocalidades() As List(Of Ref_Localidad)
        Dim comando As New MySqlCommand("SELECT * FROM ref_localidad order by nombre")
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim listaLocalidades = New List(Of Ref_Localidad)
        While reader.Read()
            Dim localidad As New Ref_Localidad
            localidad.IdRef_Localidad1 = reader(0)
            localidad.Nombre1 = reader(1)
            listaLocalidades.Add(localidad)
        End While

        conectar.cerrarConexion()
        Return listaLocalidades
    End Function

    'TRAE CONDICIONES DE COMPRA Y VENTA
    Public Function TraeCondicionesCompraVenta()
        Dim comando As String
        comando = "SELECT nombrecondicion as Nombre FROM ref_condicionventacompra order by nombrecondicion"
        Dim conectar = New ConexionBDD
        Dim mda = New MySqlDataAdapter(comando, conectar.ObtenerConexion())

        conectar.cerrarConexion()
        Return mda
    End Function

    'AGREGA CONDICIÓN DE COMPRA VENTA
    Public Function AgregarCondicionDeCompraVenta(condicion As Ref_CondicionVentaCompra)
        Dim conectar = New ConexionBDD
        Dim comando As New MySqlCommand("INSERT INTO ref_condicionventacompra (nombrecondicion) VALUES (@nombre)", conectar.ObtenerConexion())
        comando.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = condicion.NombreCondicion1
        comando.ExecuteNonQuery()
        MsgBox("Nueva condición agregada Satisfactoriamente", vbOKOnly)

        conectar.cerrarConexion()
    End Function

    'TRAE CALLES
    Public Function TraeCalles()
        Dim comando As String
        comando = "SELECT nombre as Nombre FROM ref_calle order by nombre"
        Dim conectar = New ConexionBDD
        Dim mda = New MySqlDataAdapter(comando, conectar.ObtenerConexion())

        conectar.cerrarConexion()
        Return mda
    End Function

    'AGREGA CALLE
    Public Function AgregarCalle(calle As Ref_Calle)
        Dim conectar = New ConexionBDD
        Dim comando As New MySqlCommand("INSERT INTO ref_calle (nombre) VALUES (@nombre)", conectar.ObtenerConexion())
        comando.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = calle.Nombre1
        comando.ExecuteNonQuery()
        MsgBox("Nueva calle agregada Satisfactoriamente", vbOKOnly)

        conectar.cerrarConexion()
    End Function

    'TRAE LOCALIDADES
    Public Function TraeLocalidades()
        Dim comando As String
        comando = "SELECT nombre as Nombre FROM ref_localidad order by nombre"
        Dim conectar = New ConexionBDD
        Dim mda = New MySqlDataAdapter(comando, conectar.ObtenerConexion())

        conectar.cerrarConexion()
        Return mda
    End Function

    'AGREGA LOCALIDAD
    Public Function AgregarLocalidad(localidad As Ref_Localidad)
        Dim conectar = New ConexionBDD
        Dim comando As New MySqlCommand("INSERT INTO ref_localidad (nombre) VALUES (@nombre)", conectar.ObtenerConexion())
        comando.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = localidad.Nombre1
        comando.ExecuteNonQuery()
        MsgBox("Nueva localidad agregada Satisfactoriamente", vbOKOnly)

        conectar.cerrarConexion()
    End Function

    'TRAE TIPOS DE TELEFONOS
    Public Function TraeTiposDeTelefonos()
        Dim comando As String
        comando = "SELECT nombre as Nombre FROM ref_tipotelefono order by nombre"
        Dim conectar = New ConexionBDD
        Dim mda = New MySqlDataAdapter(comando, conectar.ObtenerConexion())

        conectar.cerrarConexion()
        Return mda
    End Function

    'AGREGA TIPO DE TELEFONO
    Public Function AgregarTipoTelefono(tipoTelefono As Ref_TipoTelefono)
        Dim conectar = New ConexionBDD
        Dim comando As New MySqlCommand("INSERT INTO ref_tipotelefono (nombre) VALUES (@nombre)", conectar.ObtenerConexion())
        comando.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = tipoTelefono.Nombre1
        comando.ExecuteNonQuery()
        MsgBox("Nuevo Tipo de Teléfono agregado Satisfactoriamente", vbOKOnly)

        conectar.cerrarConexion()
    End Function

    'VERIFICA SI LOS PRODUCTOS TIENEN STOCK INFERIORES AL MÍNIMO
    Public Function VerificaMinimoDeStock()
        Dim comando As String
        comando = "SELECT sto.stock as Stock, prod.nombreProducto as Producto, tip.nombreTipoProducto as Tipo, mar.nombremarca as Marca, env.nombretipoenvase as Envase, prod.medida as Medida, unm.nombreunidaddemedida as `Un. Med.` FROM stock as sto LEFT JOIN producto as prod on prod.idProducto=sto.idproducto LEFT JOIN ref_tipoproducto as tip on prod.idRef_TipoProducto=tip.idref_tipoproducto LEFT JOIN ref_marca as mar on prod.idRef_Marca=mar.idRef_Marca LEFT JOIN ref_tipoenvase as env on prod.idRef_TipoEnvase=env.idRef_TipoEnvase LEFT JOIN ref_unidaddemedida as unm on prod.idRef_UnidadDeMedida=unm.idRef_UnidadDeMedida where sto.stock<=prod.stockMinimo"
        Dim conectar = New ConexionBDD
        Dim mda = New MySqlDataAdapter(comando, conectar.ObtenerConexion())

        conectar.cerrarConexion()
        Return mda
    End Function

    'ACTUALIZA DOMICILIO DE CLIENTE O PROVEEDOR
    Public Function ActualizarDomicilio(domicilio As Domicilio)
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("UPDATE domicilio SET idref_calle=@calle, numero=@numero, piso=@piso, dpto=@dpto, idref_localidad=@localidad where iddomicilio='" & domicilio.IdDomicilio1 & "'", conectar.ObtenerConexion())
        comando.Parameters.Add("@calle", MySqlDbType.Int32).Value = domicilio.IdRef_Calle1
        comando.Parameters.Add("@numero", MySqlDbType.Int32).Value = domicilio.Numero1
        comando.Parameters.Add("@piso", MySqlDbType.String).Value = domicilio.Piso1
        comando.Parameters.Add("@dpto", MySqlDbType.String).Value = domicilio.Dpto1
        comando.Parameters.Add("@localidad", MySqlDbType.Int32).Value = domicilio.IdRef_Localidad1
        comando.ExecuteNonQuery()
        conectar.cerrarConexion()
    End Function

    'ACTUALIZA TELÉFONO DE CLIENTE O PROVEEDOR
    Public Function ActualizarTeléfono(telefono As Telefono)
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("UPDATE telefono SET codarea=@codarea, numero=@numero, idref_tipotelefono=@tipo where idtelefono='" & telefono.IdTelefono1 & "'", conectar.ObtenerConexion())
        comando.Parameters.Add("@codarea", MySqlDbType.String).Value = telefono.CodArea1
        comando.Parameters.Add("@numero", MySqlDbType.String).Value = telefono.Numero1
        comando.Parameters.Add("@tipo", MySqlDbType.Int32).Value = telefono.IdRef_TipoTelefono1
        comando.ExecuteNonQuery()
        conectar.cerrarConexion()
    End Function

    'ACTUALIZA PERSONA
    Public Function ActualizarPersona(persona As Persona)
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("UPDATE persona SET apellidoynombre=@apeynom, dni=@dni, email=@email, iddomicilio=@domicilio where idpersona='" & persona.IdPersona1 & "'", conectar.ObtenerConexion())
        comando.Parameters.Add("@apeynom", MySqlDbType.String).Value = persona.ApellidoYNombre1
        comando.Parameters.Add("@dni", MySqlDbType.String).Value = persona.Dni1
        comando.Parameters.Add("@domicilio", MySqlDbType.String).Value = persona.IdDomicilio1
        comando.Parameters.Add("@email", MySqlDbType.String).Value = persona.Email1
        comando.ExecuteNonQuery()
        conectar.cerrarConexion()
    End Function

    'ACTUALIZA CLIENTE
    Public Function ActualizarCliente(cliente As Cliente)
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("UPDATE cliente SET cuil=@cuil, observaciones=@observacion where idcliente='" & cliente.IdCliente1 & "'", conectar.ObtenerConexion())
        comando.Parameters.Add("@cuil", MySqlDbType.String).Value = cliente.Cuil1
        comando.Parameters.Add("@observacion", MySqlDbType.String).Value = cliente.Observaciones1
        comando.ExecuteNonQuery()
        conectar.cerrarConexion()
    End Function

    'ACTUALIZA PROVEEDOR
    Public Function ActualizarProveedor(proveedor As Proveedor)
        Dim conectar As New ConexionBDD
        Dim comando As New MySqlCommand("UPDATE proveedor SET razonsocial=@nombre, cuit=@cuit, iddomicilio=@domicilio, email=@email, observaciones=@observacion where idproveedor='" & proveedor.IdProveedor1 & "'", conectar.ObtenerConexion())
        comando.Parameters.Add("@nombre", MySqlDbType.String).Value = proveedor.RazonSocial1
        comando.Parameters.Add("@cuit", MySqlDbType.String).Value = proveedor.Cuit1
        comando.Parameters.Add("@domicilio", MySqlDbType.String).Value = proveedor.IdDomicilio1
        comando.Parameters.Add("@email", MySqlDbType.String).Value = proveedor.Email1
        comando.Parameters.Add("@observacion", MySqlDbType.String).Value = proveedor.Observaciones1
        comando.ExecuteNonQuery()
        conectar.cerrarConexion()
    End Function

    'TRAE TODOS LOS CLIENTES Y LOS GUARDA EN UNA LISTA
    Public Function ListaDeClientes() As List(Of Cliente)
        Dim comando As New MySqlCommand("SELECT * FROM cliente")
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim lista = New List(Of Cliente)
        While reader.Read()
            Dim cliente As New Cliente
            cliente.IdCliente1 = reader(0)
            cliente.IdPersona1 = reader(1)
            cliente.Cuil1 = reader(2)
            lista.Add(cliente)
        End While

        conectar.cerrarConexion()
        Return lista
    End Function

    'TRAE TODOS LOS PROVEEDORES Y LOS GUARDA EN UNA LISTA
    Public Function ListaDeProveedores() As List(Of Proveedor)
        Dim comando As New MySqlCommand("SELECT * FROM proveedor")
        comando.CommandType = CommandType.Text
        Dim conectar = New ConexionBDD
        comando.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader()
        Dim lista = New List(Of Proveedor)
        While reader.Read()
            Dim proveedor As New Proveedor
            proveedor.IdProveedor1 = reader(0)
            proveedor.RazonSocial1 = reader(1)
            proveedor.Cuit1 = reader(2)
            proveedor.IdDomicilio1 = reader(3)
            proveedor.Email1 = reader(4)
            lista.Add(proveedor)
        End While

        conectar.cerrarConexion()
        Return lista
    End Function

    'Busca Inicio Caja
    Public Function InicioCaja()

        Dim sql_b As String
        Dim conectar = New ConexionBDD
        Dim fechaBuscar As String = Date.Now.ToString("yyyy-MM-dd")
        Dim tinicio As String = "N"
        Dim adaptador As MySqlDataAdapter
        Dim datos As DataSet

        '-------------------------------------------------------------------
        'BUSCA INICIO DIA
        sql_b = "SELECT saldoInicial from caja WHERE fecha='" & fechaBuscar & "'"

        adaptador = New MySqlDataAdapter(sql_b, conectar.ObtenerConexion())
        datos = New DataSet
        adaptador.Fill(datos, "rginicio")

        If (datos.Tables("rginicio").Rows.Count > 0) Then
            tinicio = "S"
        End If

        conectar.cerrarConexion()

        Return tinicio
    End Function

    'TRAE SUMA TOTAL VENTAS Y COMPRAS
    Public Function ResumenDia(fechaBuscar As String)

        Dim sql_b As String
        Dim conectar = New ConexionBDD
        Dim tinicio As Double = 0
        Dim cajasn As Integer = 0
        Dim tventas As Double = 0
        Dim tcompras As Double = 0
        Dim tsaldo As Double = 0
        Dim tefectivo As Double = 0
        Dim tcobrosCC As Double = 0
        Dim tmontoCC As Double = 0
        Dim tventaCC As Double = 0
        Dim tnoefectivo As Double = 0
        Dim tefectivoCompras As Double = 0
        Dim tnoefectivoCompras As Double = 0
        Dim tpagoProveedor As Double = 0
        Dim i As Integer

        Dim adaptador As MySqlDataAdapter
        Dim datos As DataSet

        '-------------------------------------------------------------------
        'BUSCA INICIO DIA
        sql_b = "SELECT saldoInicial from caja WHERE fecha='" & fechaBuscar & "'"

        adaptador = New MySqlDataAdapter(sql_b, conectar.ObtenerConexion())
        datos = New DataSet
        adaptador.Fill(datos, "rginicio")

        If (datos.Tables("rginicio").Rows.Count > 0) Then
            If Not IsDBNull(datos.Tables("rginicio").Rows(0).Item("saldoInicial")) Then
                tinicio = datos.Tables("rginicio").Rows(0).Item("saldoInicial")
                cajasn = 1
            End If
        End If

        '-------------------------------------------------------------------
        'BUSCA TOTAL VENTAS
        sql_b = "SELECT idRef_CondicionVentaCompra, SUM(importeTotalDeVenta) as tventas from ventas WHERE fechaVenta='" & fechaBuscar & "' GROUP by idRef_CondicionVentaCompra  "

        adaptador = New MySqlDataAdapter(sql_b, conectar.ObtenerConexion())
        datos = New DataSet
        adaptador.Fill(datos, "rgtotal")

        If (datos.Tables("rgtotal").Rows.Count > 0) Then
            For i = 0 To datos.Tables("rgtotal").Rows.Count - 1
                If Not IsDBNull(datos.Tables("rgtotal").Rows(i).Item("tventas")) Then
                    If (datos.Tables("rgtotal").Rows(i).Item("idRef_CondicionVentaCompra") = 1) Then
                        'EFECTIVO
                        '-------------------------------
                        tventas = datos.Tables("rgtotal").Rows(i).Item("tventas")
                        tefectivo = datos.Tables("rgtotal").Rows(i).Item("tventas")

                    ElseIf (datos.Tables("rgtotal").Rows(i).Item("idRef_CondicionVentaCompra") = 2) Then
                        'CUENTA CORRIENTE
                        '-------------------------------
                        tventas = tventas + datos.Tables("rgtotal").Rows(i).Item("tventas")
                        tventaCC = datos.Tables("rgtotal").Rows(i).Item("tventas")
                    Else
                        tnoefectivo = tnoefectivo + datos.Tables("rgtotal").Rows(i).Item("tventas")
                        tventas = tventas + datos.Tables("rgtotal").Rows(i).Item("tventas")
                    End If
                End If
            Next
        End If

        '-------------------------------------------------------------------
        'BUSCA TOTAL COMPRAS
        sql_b = "SELECT idRef_CondicionVentaCompra, SUM(importeTotalDeCompra) as tcompras from compras WHERE fechaCompra='" & fechaBuscar & "' GROUP BY idRef_CondicionVentaCompra"

        adaptador = New MySqlDataAdapter(sql_b, conectar.ObtenerConexion())
        datos = New DataSet
        adaptador.Fill(datos, "rgtotal")

        If (datos.Tables("rgtotal").Rows.Count > 0) Then
            For i = 0 To datos.Tables("rgtotal").Rows.Count - 1
                If Not IsDBNull(datos.Tables("rgtotal").Rows(i).Item("tcompras")) Then
                    If (datos.Tables("rgtotal").Rows(i).Item("idRef_CondicionVentaCompra") = 1) Then
                        'EFECTIVO
                        '-------------------------------
                        tcompras = datos.Tables("rgtotal").Rows(i).Item("tcompras")
                        tefectivoCompras = datos.Tables("rgtotal").Rows(i).Item("tcompras")
                    Else
                        tnoefectivoCompras = tnoefectivoCompras + datos.Tables("rgtotal").Rows(i).Item("tcompras")
                        tcompras = tcompras + datos.Tables("rgtotal").Rows(i).Item("tcompras")
                    End If
                End If
            Next
        End If


        '-------------------------------------------------------------------
        'BUSCA TOTAL MONTO C.C 
        sql_b = "SELECT SUM(vct.importe) as tmontoCC FROM ventas vt INNER JOIN ventasacuenta vct ON vt.idVenta = vct.idVenta  WHERE vt.fechaVenta= '" & fechaBuscar & "'"

        adaptador = New MySqlDataAdapter(sql_b, conectar.ObtenerConexion())
        datos = New DataSet
        adaptador.Fill(datos, "rgtotal")

        If (datos.Tables("rgtotal").Rows.Count > 0) Then
            If Not IsDBNull(datos.Tables("rgtotal").Rows(0).Item("tmontoCC")) Then
                tmontoCC = datos.Tables("rgtotal").Rows(0).Item("tmontoCC")
                tnoefectivo = tnoefectivo - tmontoCC
            End If
        End If

        tventaCC = tventaCC - tmontoCC

        'tefectivo = tefectivo + tnoefectivo
        tefectivo = tefectivo + tventaCC
        tnoefectivo = tmontoCC

        '-------------------------------------------------------------------
        'BUSCA TOTAL COBROS CC
        'sql_b = "SELECT idRef_CondicionVentaCompra, SUM(importeTotalDeCompra) as tcompras from compras WHERE fechaCompra='" & fechaBuscar & "' GROUP BY idRef_CondicionVentaCompra"
        sql_b = "SELECT SUM(pagos.Importe) as tcobros from pagosacuentacliente pagos inner JOIN ventasacuenta_has_pagosacuentacliente enlace on pagos.idPagosACuentaCliente = enlace.idPagosACuentaCliente INNER join ventasacuenta vtacta On enlace.idVentasACuenta = vtacta.idVentasACuenta INNER JOIN ventas vt ON vtacta.idVenta = vt.idVenta  WHERE (pagos.fecha='" & fechaBuscar & "')  " 'vtacta.idVentasACuenta = " & idVenta & "

        adaptador = New MySqlDataAdapter(sql_b, conectar.ObtenerConexion())
        datos = New DataSet
        adaptador.Fill(datos, "rgtotal")

        If (datos.Tables("rgtotal").Rows.Count > 0) Then

            If Not IsDBNull(datos.Tables("rgtotal").Rows(0).Item("tcobros")) Then
                tcobrosCC = datos.Tables("rgtotal").Rows(0).Item("tcobros")
            End If
        End If

        '-------------------------------------------------------------------
        'BUSCA TOTAL PAGO PROVEEDORES
        sql_b = "SELECT SUM(Importe) as tpagov from pagosacuentaproveedores WHERE (fecha='" & fechaBuscar & "')  " 'vtacta.idVentasACuenta = " & idVenta & "

        adaptador = New MySqlDataAdapter(sql_b, conectar.ObtenerConexion())
        datos = New DataSet
        adaptador.Fill(datos, "rgtotal")

        If (datos.Tables("rgtotal").Rows.Count > 0) Then

            If Not IsDBNull(datos.Tables("rgtotal").Rows(0).Item("tpagov")) Then
                tpagoProveedor = datos.Tables("rgtotal").Rows(0).Item("tpagov")
            End If
        End If

        tsaldo = tinicio + tefectivo + tcobrosCC - tefectivoCompras - tpagoProveedor

        conectar.cerrarConexion()

        Dim devolucion(10) As String
        devolucion(0) = tinicio
        devolucion(1) = cajasn
        devolucion(2) = tventas
        devolucion(3) = tefectivo
        devolucion(4) = (tnoefectivo)
        devolucion(5) = tcompras
        devolucion(6) = tefectivoCompras
        devolucion(7) = tnoefectivoCompras
        devolucion(8) = tcobrosCC
        devolucion(9) = tpagoProveedor
        devolucion(10) = tsaldo


        Return devolucion
    End Function

    'RESUMEN VENTAS/COMPRAS
    Public Function TraeResumenVC(fechaBuscar As String, tipo As String)
        Dim comando As String
        If tipo = "VENTAS" Then
            'TRAE LISTADO DE VENTAS DE LA FECHA SELECCIONADA
            comando = "SELECT PR.apellidoYNombre AS ClienteProveedor, vt.importeTotalDeVenta as ImporteTotal, vt.importeTotalDeVenta as ImporteTotalCC  FROM ventas vt INNER JOIN cliente cl ON vt.IdCliente = cl.IdCliente LEFT JOIN persona PR ON cl.idPersona = PR.idPersona WHERE (VT.fechaVenta='" & fechaBuscar & "')"

        ElseIf tipo = "VENTAS_EFECTIVO" Then
            'TRAE LISTADO DE VENTAS EN EFECTiVO DE LA FECHA SELECCIONADA
            'comando = "SELECT PR.apellidoYNombre AS ClienteProveedor, vt.importeTotalDeVenta as ImporteTotal  FROM ventas vt INNER JOIN cliente cl ON vt.IdCliente = cl.IdCliente LEFT JOIN persona PR ON cl.idPersona = PR.idPersona WHERE (VT.fechaVenta='" & fechaBuscar & "') and vt.idRef_CondicionVentaCompra=1"
            comando = "SELECT PR.apellidoYNombre AS ClienteProveedor, vt.importeTotalDeVenta as ImporteTotal, vct.importe as ImporteTotalCC  FROM ventas vt LEFT JOIN ventasacuenta vct ON vt.idVenta = vct.idVenta INNER JOIN cliente cl ON vt.IdCliente = cl.IdCliente LEFT JOIN persona PR ON cl.idPersona = PR.idPersona WHERE (VT.fechaVenta='" & fechaBuscar & "') and (vt.idRef_CondicionVentaCompra=1 or vt.idRef_CondicionVentaCompra=2)"

        ElseIf tipo = "VENTAS_CC" Then
            'TRAE LISTADO DE VENTAS EN CC DE LA FECHA SELECCIONADA
            comando = "SELECT PR.apellidoYNombre AS ClienteProveedor, vct.importe as ImporteTotal, vct.importe as ImporteTotalCC   FROM ventas vt INNER JOIN ventasacuenta vct ON vt.idVenta = vct.idVenta INNER JOIN cliente cl ON vt.IdCliente = cl.IdCliente LEFT JOIN persona PR ON cl.idPersona = PR.idPersona WHERE (VT.fechaVenta='" & fechaBuscar & "') and vt.idRef_CondicionVentaCompra=2"

        ElseIf tipo = "COMPRAS_EFECTIVO" Then
            'TRAE LISTADO DE COMPRAS EN EFECTIVO DE LA FECHA SELECCIONADA
            comando = "SELECT PV.razonSocial AS ClienteProveedor, CP.importeTotalDeCompra as ImporteTotal, CP.importeTotalDeCompra as ImporteTotalCC  FROM compras CP INNER JOIN proveedor PV ON CP.idProveedor = PV.idProveedor  WHERE (CP.fechaCompra='" & fechaBuscar & "') and CP.idRef_CondicionVentaCompra=1"

        ElseIf tipo = "COMPRAS_CC" Then
            'TRAE LISTADO DE COMRPAS EN CC DE LA FECHA SELECCIONADA
            comando = "SELECT PV.razonSocial AS ClienteProveedor, CP.importeTotalDeCompra as ImporteTotal, CP.importeTotalDeCompra as ImporteTotalCC  FROM compras CP INNER JOIN proveedor PV ON CP.idProveedor = PV.idProveedor WHERE (CP.fechaCompra='" & fechaBuscar & "') and CP.idRef_CondicionVentaCompra<>1"

        ElseIf tipo = "COBROS_CC" Then
            'TRAE LISTADO DE COBROS EN CC DE LA FECHA SELECCIONADA
            comando = "SELECT PR.apellidoYNombre AS ClienteProveedor, pagos.Importe as ImporteTotal, pagos.Importe as ImporteTotalCC from pagosacuentacliente pagos inner JOIN ventasacuenta_has_pagosacuentacliente enlace on pagos.idPagosACuentaCliente = enlace.idPagosACuentaCliente INNER join ventasacuenta vtacta On enlace.idVentasACuenta = vtacta.idVentasACuenta INNER JOIN ventas vt ON vtacta.idVenta = vt.idVenta INNER JOIN cliente cl ON vt.IdCliente = cl.IdCliente LEFT JOIN persona PR ON cl.idPersona = PR.idPersona WHERE (pagos.fecha='" & fechaBuscar & "')  order by pagos.fecha asc, pagos.importe  Desc" 'vtacta.idVentasACuenta = " & idVenta & "

        ElseIf tipo = "PAGOS_PROVEEDOR" Then
            'TRAE LISTADO DE PAGOS A PROVEEDORES EN  LA FECHA SELECCIONADA
            comando = "SELECT idPagosACuentaProveedores AS ClienteProveedor, importe as ImporteTotal, importe as ImporteTotalCC   FROM pagosacuentaproveedores  WHERE (fecha='" & fechaBuscar & "') order by fecha asc, importe  Desc"

        Else
            'TRAE LISTADO DE COMPRAS DE LA FECHA SELECCIONADA
            comando = "SELECT PV.razonSocial AS ClienteProveedor, CP.importeTotalDeCompra as ImporteTotal, CP.importeTotalDeCompra as ImporteTotalCC  FROM compras CP INNER JOIN proveedor PV ON CP.idProveedor = PV.idProveedor WHERE (CP.fechaCompra='" & fechaBuscar & "')"
        End If

        Dim conectar = New ConexionBDD
        Dim mda = New MySqlDataAdapter(comando, conectar.ObtenerConexion())

        conectar.cerrarConexion()
        Return mda
    End Function

    Public Function GuardarVentaACuenta(venta As VentasACuenta)
        Dim conectar = New ConexionBDD
        Dim comando As New MySqlCommand("INSERT INTO ventasacuenta (idventa, importe) VALUES (@idventa, @importe)", conectar.ObtenerConexion())
        comando.Parameters.Add("@idventa", MySqlDbType.Int32).Value = venta.IdVenta1
        comando.Parameters.Add("@importe", MySqlDbType.Double).Value = venta.Importe1
		comando.ExecuteNonQuery()
		conectar.cerrarConexion()
    End Function

    Public Function ActualizarSaldoCuentaCorrienteCliente(saldo As CuentaCorrienteCliente)
        Dim conectar As New ConexionBDD
        Dim existeCuenta = 0
        Dim comandoExisteCuenta As New MySqlCommand("SELECT saldo FROM cuentacorrientecliente where idcliente = " & saldo.IdCliente1)
        comandoExisteCuenta.CommandType = CommandType.Text
        comandoExisteCuenta.Connection = conectar.ObtenerConexion()
        Dim reader As MySqlDataReader
        reader = comandoExisteCuenta.ExecuteReader()
        While reader.Read()
            existeCuenta = 1
        End While
		If existeCuenta = 0 Then
			Dim comandoInsertar As New MySqlCommand("INSERT INTO cuentacorrientecliente (idcliente,saldo) VALUES (@idcliente, @saldo)", conectar.ObtenerConexion())
			comandoInsertar.Parameters.Add("@idcliente", MySqlDbType.Int32).Value = saldo.IdCliente1
			comandoInsertar.Parameters.Add("@saldo", MySqlDbType.Double).Value = saldo.Saldo1
			comandoInsertar.ExecuteNonQuery()
		Else
			Dim comando As New MySqlCommand("UPDATE cuentacorrientecliente SET saldo=saldo + @saldo where idcliente='" & saldo.IdCliente1 & "'", conectar.ObtenerConexion())
			comando.Parameters.Add("@saldo", MySqlDbType.Double).Value = saldo.Saldo1
			comando.ExecuteNonQuery()
		End If
		conectar.cerrarConexion()
    End Function
	'REGISTRAR INICIO CAJA
	Public Function registrarInicioCaja(Caja As Caja)
		Dim conectar = New ConexionBDD
		Dim comandoPrecio As New MySqlCommand("INSERT INTO caja (fecha, saldoInicial, saldoFinal) VALUES (@fecha, @saldoInicial, @saldoFinal)", conectar.ObtenerConexion())
		comandoPrecio.Parameters.Add("@fecha", MySqlDbType.Date).Value = Caja.Fecha1
		comandoPrecio.Parameters.Add("@saldoInicial", MySqlDbType.Double).Value = Caja.SaldoInicial1
		comandoPrecio.Parameters.Add("@saldoFinal", MySqlDbType.Int32).Value = Caja.SaldoFinal1
		comandoPrecio.ExecuteNonQuery()
		conectar.cerrarConexion()
	End Function

	'TRAER RESUMEN DE VENTAS POR ID
	Public Function TraeDetalledeVentasPorId(idVenta As Integer)
		Dim comando As String

		'TRAE LISTADO DE COMPRAS DE LA FECHA SELECCIONADA
		comando = "SELECT detventa.idVenta, detventa.Cantidad as Cant, detventa.importe, vta.fechaVenta, prod.nombreproducto as Nombre, prod.medida as Medida, env.nombretipoenvase as Envase FROM detalleVenta detventa inner JOIN ventas vta on vta.idVenta = detventa.idVenta inner join producto prod on detventa.idproducto = prod.idproducto inner join ref_tipoenvase env on prod.idref_tipoenvase = env.idref_tipoenvase WHERE detventa.idVenta  =" & idVenta
		Dim conectar = New ConexionBDD
		Dim mda = New MySqlDataAdapter(comando, conectar.ObtenerConexion())

		conectar.cerrarConexion()
		Return mda
	End Function

	'MUESTRA PAGOS REALIZADOS POR ID DE PAGOS
	Public Function TraeDetalledePagospoId(idVenta As Integer)
		Dim comando As String
		comando = "SELECT pagos.Fecha, pagos.Importe, pagos.idPagosACuentaCliente as idPago, vtacta.idVentasACuenta as idVenta from pagosacuentacliente pagos inner JOIN ventasacuenta_has_pagosacuentacliente enlace on pagos.idPagosACuentaCliente = enlace.idPagosACuentaCliente INNER join ventasacuenta vtacta On enlace.idVentasACuenta = vtacta.idVentasACuenta where vtacta.idVentasACuenta = " & idVenta & " order by pagos.fecha asc, pagos.importe  Desc"
		Dim conectar = New ConexionBDD
		Dim mda = New MySqlDataAdapter(comando, conectar.ObtenerConexion())
		conectar.cerrarConexion()
		Return mda
	End Function

End Class
