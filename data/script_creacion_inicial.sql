--Conexión a la base de datos.
USE [GD1C2019]
GO

--Creación de schema.
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'FGNN_19')
BEGIN
	EXEC ('CREATE SCHEMA FGNN_19 AUTHORIZATION gdCruceros2019')
END
GO

--Validación de tablas.
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Recorridos_X_Crucero'))
    DROP TABLE FGNN_19.Recorridos_X_Crucero
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Recorrido_X_Tramo'))
    DROP TABLE FGNN_19.Recorrido_X_Tramo
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Pasajes_Cancelados'))
    DROP TABLE FGNN_19.Pasajes_Cancelados
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Pasajes'))
    DROP TABLE FGNN_19.Pasajes
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Cabinas'))
    DROP TABLE FGNN_19.Cabinas
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Viajes'))
    DROP TABLE FGNN_19.Viajes
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Compras'))
    DROP TABLE FGNN_19.Compras
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Tramos'))
    DROP TABLE FGNN_19.Tramos
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Cruceros'))
    DROP TABLE FGNN_19.Cruceros
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Recorridos'))
    DROP TABLE FGNN_19.Recorridos
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Clientes'))
    DROP TABLE FGNN_19.Clientes
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Funcionalidades_Roles'))
    DROP TABLE FGNN_19.Funcionalidades_Roles
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Usuarios_Roles'))
    DROP TABLE FGNN_19.Usuarios_Roles		
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Usuarios'))
    DROP TABLE FGNN_19.Usuarios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Funcionalidades'))
    DROP TABLE FGNN_19.Funcionalidades
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Roles'))
    DROP TABLE FGNN_19.Roles
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Reservas'))
    DROP TABLE FGNN_19.Reservas
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Metodos_Pago'))
    DROP TABLE FGNN_19.Metodos_Pago
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Tipos_Cabinas'))
	DROP TABLE FGNN_19.Tipos_Cabinas
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Fabricantes'))
	DROP TABLE FGNN_19.Fabricantes
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Puertos'))
    DROP TABLE FGNN_19.Puertos
GO

IF EXISTS (SELECT * FROM sys.views WHERE name = 'vw_RolesYFuncionalidades' AND type = 'V') 
	DROP VIEW FGNN_19.vw_RolesYFuncionalidades
GO

IF EXISTS (SELECT * FROM sys.objects WHERE [name] = N'TR_Roles_InsteadOfDelete' AND [type] = 'TR')
    DROP TRIGGER FGNN_19.TR_Roles_InsteadOfDelete
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.P_ValidarLogin') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.P_ValidarLogin 
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.P_Viaje_valido') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.P_Viaje_valido
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.P_Actualizar_Recorridos') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.P_Actualizar_Recorridos
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Baja_difinitiva_crucero') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Baja_difinitiva_crucero
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Baja_temporal_crucero') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Baja_temporal_crucero
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Actualizacion_reinicio_cruceros') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Actualizacion_reinicio_cruceros
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Cancelar_pasajes_crucero') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Cancelar_pasajes_crucero
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Reemplazar_crucero') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Reemplazar_crucero
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Reeprogramar_viajes_crucero') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Reeprogramar_viajes_crucero
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.TOP5_recorridos_mas_comprados') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.TOP5_recorridos_mas_comprados
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.TOP5_recorridos_mas_cabinas_libres') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.TOP5_recorridos_mas_cabinas_libres
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.TOP5_cruceros_mas_dias_fuera_servicio') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.TOP5_cruceros_mas_dias_fuera_servicio
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.P_InsertarCrucero') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.P_InsertarCrucero
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.P_InsertarViaje') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.P_InsertarViaje
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.P_IngresarRecorrido') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.P_IngresarRecorrido
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.P_TramosDelRecorrido') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.P_TramosDelRecorrido
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.P_TramoRecorridoOriginal') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.P_TramoRecorridoOriginal
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.P_IngresarRecorrido_X_Tramo') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.P_IngresarRecorrido_X_Tramo
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.P_CabinasDelCrucero') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.P_CabinasDelCrucero
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.P_Verificar_Recorrido') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.P_Verificar_Recorrido
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Actualizar_Viajes') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Actualizar_Viajes
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Fecha_valida_corrimiento') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Fecha_valida_corrimiento
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.TOP5_recorridos_mas_comprados') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.TOP5_recorridos_mas_comprados
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.TOP5_recorridos_mas_cabinas_libres') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.TOP5_recorridos_mas_cabinas_libres
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.TOP5_cruceros_mas_dias_fuera_servicio') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.TOP5_cruceros_mas_dias_fuera_servicio
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Anios_TOP5_cruceros_mas_dias_fuera_servicio') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Anios_TOP5_cruceros_mas_dias_fuera_servicio
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Datos_cliente') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Datos_cliente
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Cancelar_pasajes_crucero_definitiva') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Cancelar_pasajes_crucero_definitiva
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Actualizar_Reservas') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Actualizar_Reservas
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Insertar_Compra') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Insertar_Compra
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.P_PuedeViajarCliente') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.P_PuedeViajarCliente
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Calcular_costo_pasaje') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Calcular_costo_pasaje
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Insertar_pasaje') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Insertar_pasaje
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Obtener_id_metodo_pago') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Obtener_id_metodo_pago
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Insertar_Reserva') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Insertar_Reserva
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Obtener_datos_mostrar_pasaje') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Obtener_datos_mostrar_pasaje
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.FN_Calcular_costo_pasaje') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
	DROP FUNCTION FGNN_19.FN_Calcular_costo_pasaje
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.FN_Calcular_costo_base') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
	DROP FUNCTION FGNN_19.FN_Calcular_costo_base
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.FN_Tiene_fecha_libre') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
	DROP FUNCTION FGNN_19.FN_Tiene_fecha_libre
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.FN_Puede_cumplir_sus_viajes') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
	DROP FUNCTION FGNN_19.FN_Puede_cumplir_sus_viajes
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.FN_Pasaje_no_cancelado') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
	DROP FUNCTION FGNN_19.FN_Pasaje_no_cancelado
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.FN_Crucero_reemplazante') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
	DROP FUNCTION FGNN_19.FN_Crucero_reemplazante
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.FN_Puede_cumplir_recorrido') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
	DROP FUNCTION FGNN_19.FN_Puede_cumplir_recorrido
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.FN_Cabina_reemplazante') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
	DROP FUNCTION FGNN_19.FN_Cabina_reemplazante
GO

--Creación de tablas.
CREATE TABLE [FGNN_19].[Usuarios] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[username] VARCHAR(255) UNIQUE NOT NULL,
	[password] NVARCHAR(64) NOT NULL,
	[intentos_fallidos] SMALLINT DEFAULT 0 NOT NULL,
	[habilitado] BIT DEFAULT 1 NOT NULL,
	PRIMARY KEY ([id])
);
GO

CREATE TABLE [FGNN_19].[Funcionalidades] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[descripcion] VARCHAR(255) NOT NULL,
	PRIMARY KEY ([id])
);
GO

CREATE TABLE [FGNN_19].[Roles] (
	[id] SMALLINT IDENTITY(1, 1),
	[descripcion] VARCHAR(255) UNIQUE NOT NULL,
	[habilitado] BIT DEFAULT 1 NOT NULL,
	PRIMARY KEY ([id])
);
GO

CREATE TABLE [FGNN_19].[Reservas] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[codigo] NUMERIC(18, 0),
	[habilitada] BIT DEFAULT 1 NOT NULL,
	[fecha] DATETIME2(3) NOT NULL,
	PRIMARY KEY ([id])
);
GO

CREATE TABLE [FGNN_19].[Metodos_Pago] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[descripcion] VARCHAR(255) NOT NULL,
	PRIMARY KEY ([id])
);
GO

CREATE TABLE [FGNN_19].[Tipos_Cabinas] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[descripcion] VARCHAR(255) NOT NULL,
	[porcentaje_adicional] FLOAT NOT NULL,
	PRIMARY KEY ([id])
);
GO

CREATE TABLE [FGNN_19].[Fabricantes] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[descripcion] VARCHAR(255) NOT NULL,
	PRIMARY KEY ([id])
);
GO

CREATE TABLE [FGNN_19].[Puertos] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[descripcion] VARCHAR(255) NOT NULL,
	PRIMARY KEY ([id]),
);
GO

CREATE TABLE [FGNN_19].[Usuarios_Roles] (
	[usuario_id] NUMERIC(18, 0),
	[rol_id] SMALLINT NOT NULL,
	PRIMARY KEY ([usuario_id], [rol_id]),
	FOREIGN KEY (usuario_id) REFERENCES FGNN_19.Usuarios(id),
	FOREIGN KEY (rol_id) REFERENCES FGNN_19.Roles(id)
);
GO

CREATE TABLE [FGNN_19].[Funcionalidades_Roles] (
	[rol_id] SMALLINT,
	[funcionalidad_id] NUMERIC(18, 0),
	PRIMARY KEY ([rol_id], [funcionalidad_id]),
	FOREIGN KEY (rol_id) REFERENCES FGNN_19.Roles(id),
	FOREIGN KEY (funcionalidad_id) REFERENCES FGNN_19.Funcionalidades(id)
);
GO

CREATE TABLE [FGNN_19].[Clientes] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[nombre] VARCHAR(255) NOT NULL,
	[apellido] VARCHAR(255) NOT NULL,
	[dni] NUMERIC(18, 0) NOT NULL,
	[direccion] VARCHAR(255) NOT NULL,
	[telefono] NUMERIC(18, 0) NOT NULL,
	[fecha_nac] DATETIME2(3) NOT NULL,
	[mail] VARCHAR(255),
	PRIMARY KEY ([id])
);
GO

CREATE TABLE [FGNN_19].[Cruceros] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[nombre] VARCHAR(255) NOT NULL,
	[fecha_alta] DATETIME2(3),
	[modelo] VARCHAR(255) NOT NULL,
	[fabricante_id] NUMERIC(18, 0),
	[tipo_servicio] VARCHAR(255),
	[baja_servicio] BIT DEFAULT 0,
	[baja_vida_util] BIT DEFAULT 0,
	[fecha_fuera_servicio] DATETIME2(3),
	[fecha_reinicio_servicio] DATETIME2(3),
	[fecha_baja_definitiva] DATETIME2(3),
	[cant_cabinas] SMALLINT,
	[habilitado] BIT DEFAULT 1 NOT NULL,
	PRIMARY KEY ([id]),
	FOREIGN KEY (fabricante_id) REFERENCES FGNN_19.Fabricantes(id)
);
GO

CREATE TABLE [FGNN_19].[Tramos] (
	[id] NUMERIC(18,0) IDENTITY(1, 1),
	[puerto_desde_id] NUMERIC(18, 0) NOT NULL,
	[puerto_hasta_id] NUMERIC(18,0) NOT NULL,
	[precio_base] FLOAT NOT NULL,
	PRIMARY KEY ([id]),
	FOREIGN KEY (puerto_desde_id) REFERENCES FGNN_19.Puertos(id),
	FOREIGN KEY (puerto_hasta_id) REFERENCES FGNN_19.Puertos(id)
);
GO

CREATE TABLE [FGNN_19].[Recorridos] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[codigo] VARCHAR(255),
	[puerto_desde_id] NUMERIC(18, 0) NOT NULL,
	[puerto_hasta_id] NUMERIC(18, 0) NOT NULL,
	[habilitado] BIT DEFAULT 1 NOT NULL,
	PRIMARY KEY ([id]),
	FOREIGN KEY (puerto_desde_id) REFERENCES FGNN_19.Puertos(id),
	FOREIGN KEY (puerto_hasta_id) REFERENCES FGNN_19.Puertos(id)
);
GO

CREATE TABLE [FGNN_19].[Compras] (
	[codigo] NUMERIC(18, 0) IDENTITY(1, 1),
	[codigo_pasaje] NUMERIC(18,0),
	[metodo_pago] NUMERIC(18, 0),
	[fecha] DATETIME2(3) NOT NULL,
	[cuotas] INT,
	PRIMARY KEY ([codigo]),
	FOREIGN KEY (metodo_pago) REFERENCES FGNN_19.Metodos_Pago(id)
);
GO

CREATE TABLE [FGNN_19].[Viajes] (
	[codigo] NUMERIC(18, 0) IDENTITY(1, 1),
	[crucero_id] NUMERIC(18, 0),
	[recorrido_codigo] NUMERIC(18, 0),
	[fecha_inicio] DATETIME2(3),
	[fecha_fin] DATETIME2(3),
	[fecha_fin_estimada] DATETIME2(3),
	PRIMARY KEY([codigo]),
	FOREIGN KEY (crucero_id) REFERENCES FGNN_19.Cruceros(id),
	FOREIGN KEY (recorrido_codigo) REFERENCES FGNN_19.Recorridos(id)
);
GO

CREATE TABLE [FGNN_19].[Cabinas] (
	[codigo] NUMERIC(18, 0) IDENTITY(1, 1),
	[crucero_id] NUMERIC(18, 0),
	[numero] NUMERIC(18, 0),
	[piso] NUMERIC(18, 0) NOT NULL,
	[tipo_id] NUMERIC(18, 0),
	[estado] BIT DEFAULT 1,
	PRIMARY KEY ([codigo]),
	FOREIGN KEY (crucero_id) REFERENCES FGNN_19.Cruceros(id),
	FOREIGN KEY (tipo_id) REFERENCES FGNN_19.Tipos_Cabinas(id)
);
GO

CREATE TABLE [FGNN_19].[Pasajes] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[reserva_codigo] NUMERIC(18, 0),
	[cliente_id] NUMERIC(18, 0),
	[compra_codigo] NUMERIC(18, 0),
	[viaje_codigo] NUMERIC(18, 0),
	[cabina_id] NUMERIC(18,0),
	[precio] FLOAT,
	[codigo] NUMERIC(18,0),
	PRIMARY KEY ([id]),
	FOREIGN KEY (reserva_codigo) REFERENCES FGNN_19.Reservas(id),
	FOREIGN KEY (cliente_id) REFERENCES FGNN_19.Clientes(id),
	FOREIGN KEY (compra_codigo) REFERENCES FGNN_19.Compras(codigo),
	FOREIGN KEY (viaje_codigo) REFERENCES FGNN_19.Viajes(codigo),
	FOREIGN KEY (cabina_id) REFERENCES FGNN_19.Cabinas(codigo)
);
GO

CREATE TABLE [FGNN_19].[Recorrido_X_Tramo] (
	[recorrido_id] NUMERIC(18, 0),
	[tramo_id] NUMERIC(18, 0),
	[orden] NUMERIC(18,0),
	PRIMARY KEY ([recorrido_id], [tramo_id]),
	FOREIGN KEY (recorrido_id) REFERENCES FGNN_19.Recorridos(id),
	FOREIGN KEY (tramo_id) REFERENCES FGNN_19.Recorridos(id)
);
GO

CREATE TABLE [FGNN_19].[Recorridos_X_Crucero] (
	[recorrido_codigo] NUMERIC(18, 0),
	[recorrido_crucero] NUMERIC(18, 0),
	PRIMARY KEY ([recorrido_codigo], [recorrido_crucero]),
	FOREIGN KEY (recorrido_codigo) REFERENCES FGNN_19.Recorridos(id),
	FOREIGN KEY (recorrido_crucero) REFERENCES FGNN_19.Cruceros(id)
);
GO

CREATE TABLE [FGNN_19].[Pasajes_Cancelados] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[id_pasaje] NUMERIC(18,0),
	[fecha_cancelacion] datetime2(3),
	[motivo] VARCHAR(255)
	PRIMARY KEY([id]),
	FOREIGN KEY (id_pasaje) REFERENCES FGNN_19.Pasajes(id)
);
GO

--Fin creación de tablas.

--Migración

INSERT INTO FGNN_19.Tipos_Cabinas (descripcion, porcentaje_adicional)
SELECT CABINA_TIPO, CABINA_TIPO_PORC_RECARGO FROM gd_esquema.Maestra
GROUP BY CABINA_TIPO, CABINA_TIPO_PORC_RECARGO

INSERT INTO FGNN_19.Puertos (descripcion)
SELECT C.PUERTO_DESDE FROM gd_esquema.Maestra C
UNION
SELECT D.PUERTO_HASTA FROM gd_esquema.Maestra D

INSERT INTO FGNN_19.Recorridos (codigo, puerto_desde_id, puerto_hasta_id)
SELECT CONVERT(VARCHAR,M.RECORRIDO_CODIGO), PD.id, PH.id
FROM gd_esquema.Maestra M, FGNN_19.Puertos PD, FGNN_19.Puertos PH
WHERE PD.descripcion = M.PUERTO_DESDE
AND PH.descripcion = M.PUERTO_HASTA
GROUP BY CONVERT(VARCHAR,M.RECORRIDO_CODIGO), PD.id, PH.id

INSERT INTO FGNN_19.Tramos(puerto_desde_id, puerto_hasta_id, precio_base)
SELECT PD.id, PH.id, M.RECORRIDO_PRECIO_BASE
FROM gd_esquema.Maestra M, FGNN_19.Puertos PD, FGNN_19.Puertos PH
WHERE PD.descripcion = M.PUERTO_DESDE
AND PH.descripcion = M.PUERTO_HASTA
GROUP BY CONVERT(VARCHAR,M.RECORRIDO_CODIGO), PD.id, PH.id, M.RECORRIDO_PRECIO_BASE

INSERT INTO FGNN_19.Reservas (codigo, fecha)
SELECT RESERVA_CODIGO, RESERVA_FECHA
FROM gd_esquema.Maestra
WHERE RESERVA_CODIGO IS NOT NULL
AND RESERVA_FECHA IS NOT NULL
GROUP BY RESERVA_CODIGO, RESERVA_FECHA
ORDER BY RESERVA_CODIGO ASC

INSERT INTO FGNN_19.Fabricantes(descripcion)
SELECT CRU_FABRICANTE
FROM gd_esquema.Maestra
GROUP BY CRU_FABRICANTE
ORDER BY CRU_FABRICANTE ASC

INSERT INTO FGNN_19.Cruceros(nombre, modelo, fabricante_id)
SELECT m.CRUCERO_IDENTIFICADOR, m.CRUCERO_MODELO, f.id
FROM gd_esquema.Maestra m, FGNN_19.Fabricantes f
WHERE f.descripcion = m.CRU_FABRICANTE
GROUP BY m.CRUCERO_IDENTIFICADOR, m.CRUCERO_MODELO, f.id
ORDER BY m.CRUCERO_MODELO ASC, f.id ASC

INSERT INTO FGNN_19.Clientes(nombre, apellido, dni, direccion, telefono, fecha_nac, mail)
SELECT CLI_NOMBRE, CLI_APELLIDO, CLI_DNI, CLI_DIRECCION, CLI_TELEFONO, CLI_FECHA_NAC, CLI_MAIL
FROM gd_esquema.Maestra
GROUP BY CLI_NOMBRE, CLI_APELLIDO, CLI_DNI, CLI_DIRECCION, CLI_TELEFONO, CLI_FECHA_NAC, CLI_MAIL

INSERT INTO FGNN_19.Viajes(crucero_id, recorrido_codigo, fecha_inicio, fecha_fin, fecha_fin_estimada)
SELECT c.id, r.id, m.FECHA_SALIDA, m.FECHA_LLEGADA, m.FECHA_LLEGADA_ESTIMADA
FROM gd_esquema.Maestra m, FGNN_19.Cruceros c, FGNN_19.Fabricantes f, FGNN_19.Recorridos r
WHERE c.nombre = m.CRUCERO_IDENTIFICADOR 
AND c.modelo = m.CRUCERO_MODELO 
AND f.descripcion = m.CRU_FABRICANTE 
AND c.fabricante_id = f.id
AND r.codigo = CONVERT(VARCHAR,M.RECORRIDO_CODIGO)
GROUP BY c.id, r.id, m.FECHA_SALIDA, m.FECHA_LLEGADA, m.FECHA_LLEGADA_ESTIMADA

INSERT INTO FGNN_19.Compras(codigo_pasaje, fecha)
SELECT m.PASAJE_CODIGO, m.PASAJE_FECHA_COMPRA
FROM gd_esquema.Maestra m
WHERE m.PASAJE_CODIGO IS NOT NULL
GROUP BY m.PASAJE_CODIGO, m.PASAJE_FECHA_COMPRA

INSERT INTO FGNN_19.Cabinas(crucero_id, numero, piso, tipo_id)
SELECT 
(SELECT cru.id
FROM FGNN_19.Cruceros cru 
	JOIN FGNN_19.Fabricantes f ON cru.fabricante_id = f.id
WHERE m.CRUCERO_IDENTIFICADOR = cru.nombre AND m.CRUCERO_MODELO = cru.modelo AND m.CRU_FABRICANTE = f.descripcion) AS crucero_id,
 m.CABINA_NRO, m.CABINA_PISO, 
 (SELECT tc.id
 FROM FGNN_19.Tipos_Cabinas tc
 WHERE tc.descripcion = m.CABINA_TIPO AND tc.porcentaje_adicional = m.CABINA_TIPO_PORC_RECARGO) AS tipo_cabina_id
FROM gd_esquema.Maestra m
GROUP BY m.CRUCERO_IDENTIFICADOR, m.CRUCERO_MODELO, m.CRU_FABRICANTE, m.CABINA_NRO, m.CABINA_PISO, m.CABINA_TIPO, m.CABINA_TIPO_PORC_RECARGO

INSERT INTO FGNN_19.Pasajes(reserva_codigo, cliente_id, compra_codigo, viaje_codigo, cabina_id, precio, codigo)
SELECT (SELECT r.id 
	FROM FGNN_19.Reservas r 
	WHERE r.codigo = m.RESERVA_CODIGO AND r.fecha = m.RESERVA_FECHA), 
	(SELECT c.id
	FROM FGNN_19.Clientes c
	WHERE m.CLI_APELLIDO = c.apellido
		AND m.CLI_DIRECCION = c.direccion
		AND m.CLI_DNI = c.dni
		AND m.CLI_FECHA_NAC = c.fecha_nac
		AND m.CLI_MAIL = c.mail
		AND m.CLI_NOMBRE = c.nombre
		AND m.CLI_TELEFONO = c.telefono
	GROUP BY c.id) cliente_id,
(SELECT co.codigo
	FROM FGNN_19.Compras co
	WHERE co.codigo_pasaje = m.PASAJE_CODIGO
	GROUP BY co.codigo) compra_codigo,
(SELECT v.codigo
	FROM FGNN_19.Viajes v, FGNN_19.Recorridos r, FGNN_19.Puertos pd, FGNN_19.Puertos ph
	WHERE v.crucero_id = cru.id
		AND r.codigo = CONVERT(varchar,m.RECORRIDO_CODIGO)
		AND pd.descripcion = m.PUERTO_DESDE
		AND ph.descripcion = m.PUERTO_HASTA
		AND r.puerto_desde_id = pd.id
		AND r.puerto_hasta_id = ph.id
		AND v.recorrido_codigo = r.id
		AND v.fecha_inicio = m.FECHA_SALIDA
		AND v.fecha_fin = m.FECHA_LLEGADA
		AND v.fecha_fin_estimada = m.FECHA_LLEGADA_ESTIMADA
	GROUP BY v.codigo) viaje_codigo,
	(SELECT c.codigo
	FROM FGNN_19.Cabinas c, FGNN_19.Tipos_Cabinas tc
	WHERE  c.crucero_id = cru.id AND c.numero = m.CABINA_NRO AND c.piso = m.CABINA_PISO
	AND tc.descripcion = m.CABINA_TIPO AND tc.porcentaje_adicional = m.CABINA_TIPO_PORC_RECARGO AND tc.id = c.tipo_id),
  m.PASAJE_PRECIO, m.PASAJE_CODIGO
FROM gd_esquema.Maestra m, FGNN_19.Cruceros cru, FGNN_19.Fabricantes f
WHERE cru.nombre = m.CRUCERO_IDENTIFICADOR AND cru.modelo = m.CRUCERO_MODELO AND f.descripcion = m.CRU_FABRICANTE
	AND cru.fabricante_id = f.id
GROUP BY m.CABINA_NRO, m.CABINA_PISO, m.CABINA_TIPO, m.CABINA_TIPO_PORC_RECARGO, m.CLI_APELLIDO, m.CLI_DIRECCION, m.CLI_DNI, m.CLI_FECHA_NAC, m.CLI_MAIL, 
	m.CLI_NOMBRE, m.CLI_TELEFONO, cru.id, m.FECHA_LLEGADA, m.FECHA_LLEGADA_ESTIMADA, m.FECHA_SALIDA, m.PASAJE_CODIGO, m.PASAJE_FECHA_COMPRA, m.PASAJE_PRECIO,
	 m.PUERTO_DESDE, m.PUERTO_HASTA, m.RECORRIDO_CODIGO, m.RECORRIDO_PRECIO_BASE, m.RESERVA_CODIGO, m.RESERVA_FECHA

INSERT INTO FGNN_19.Recorridos_X_Crucero 
SELECT r.id, c.id
FROM gd_esquema.Maestra m, FGNN_19.Cruceros c, FGNN_19.Fabricantes f, FGNN_19.Recorridos r
WHERE c.nombre = m.CRUCERO_IDENTIFICADOR
AND c.modelo = m.CRUCERO_MODELO
AND c.fabricante_id = f.id
AND f.descripcion = m.CRU_FABRICANTE
AND r.codigo = CONVERT(VARCHAR,M.RECORRIDO_CODIGO)
GROUP BY r.id, c.id

INSERT INTO FGNN_19.Recorrido_X_Tramo (recorrido_id, tramo_id, orden)
SELECT r.id, t.id, 1
FROM FGNN_19.Recorridos r, FGNN_19.Tramos t
WHERE r.puerto_desde_id = t.puerto_desde_id AND r.puerto_hasta_id = t.puerto_hasta_id
GROUP BY r.id, t.id
 

-- Fin Migracion

-- Inserto metodos de pago

INSERT INTO FGNN_19.Metodos_Pago(descripcion)
VALUES('Tarjeta de débito')

INSERT INTO FGNN_19.Metodos_Pago(descripcion)
VALUES('Tarjeta de crédito')

INSERT INTO FGNN_19.Metodos_Pago(descripcion)
VALUES('Efectivo')

-- Fin insercion metodos de pago

-- Roles --
INSERT INTO [FGNN_19].[Roles](descripcion)
VALUES ('Administrador')

INSERT INTO [FGNN_19].[Roles](descripcion)
VALUES ('Administrador General')


-- Funcionalidades --
INSERT INTO [FGNN_19].[Funcionalidades](descripcion)
VALUES ('ABM Roles'),
	('ABM Recorridos'),
	('ABM Cruceros'),
	('Generar Viajes'),
	('Comprar Viajes'),
	('Pagar Reservas'),
	('Listado Estadistico')

-- Funcionalidades_Roles --
INSERT INTO [FGNN_19].[Funcionalidades_Roles]
	SELECT r.id, f.id 
	FROM [FGNN_19].[Funcionalidades] f, [FGNN_19].[Roles] r
	WHERE r.descripcion = 'Administrador';

INSERT INTO [FGNN_19].[Funcionalidades_Roles]
	SELECT r.id, f.id 
	FROM [FGNN_19].[Funcionalidades] f, [FGNN_19].[Roles] r
	WHERE r.descripcion = 'Administrador General';
GO

INSERT INTO FGNN_19.Usuarios (username, password, intentos_fallidos, habilitado)
VALUES
('juanpedro', CONVERT(NVARCHAR(64),HASHBYTES('SHA2_256', CONVERT(VARCHAR(64), 'w23e')),2),0,1),
('pablo18', CONVERT(NVARCHAR(64),HASHBYTES('SHA2_256', CONVERT(VARCHAR(64), 'w23e')),2), 0, 1),
('javiperez67', CONVERT(NVARCHAR(64),HASHBYTES('SHA2_256', CONVERT(VARCHAR(64), 'w23e')),2), 0, 1),
('admin', CONVERT(NVARCHAR(64),HASHBYTES('SHA2_256', CONVERT(VARCHAR(64), 'w23e')),2), 0, 1);
GO

INSERT INTO FGNN_19.Usuarios_Roles
SELECT u.id, r.id
FROM FGNN_19.Usuarios u, FGNN_19.Roles r
WHERE r.descripcion = 'Administrador'
AND u.username != 'admin';
GO

INSERT INTO FGNN_19.Usuarios_Roles
SELECT u.id, r.id
FROM FGNN_19.Usuarios u, FGNN_19.Roles r
WHERE r.descripcion = 'Administrador General'
AND u.username = 'admin';
GO

-- Vistas

CREATE VIEW FGNN_19.vw_RolesYFuncionalidades
AS 
SELECT r.descripcion AS ROL, f.descripcion AS FUNCIONALIDAD 
FROM FGNN_19.Roles r, FGNN_19.Funcionalidades f, FGNN_19.Funcionalidades_Roles fr
WHERE fr.funcionalidad_id = f.id
AND fr.rol_id = r.id;
GO

-- Funciones

CREATE FUNCTION FGNN_19.FN_Calcular_costo_base(@idRecorrido NUMERIC(18,0))
RETURNS FLOAT
AS

BEGIN

	DECLARE @PrecioBaseTotal FLOAT

	SET @PrecioBaseTotal = (SELECT SUM(t.precio_base)
	FROM FGNN_19.Recorridos r, FGNN_19.Recorrido_X_Tramo rt, FGNN_19.Tramos t
	WHERE r.id = @idRecorrido
	AND r.id = rt.recorrido_id AND t.id = rt.tramo_id
	GROUP BY r.id)

	RETURN @PrecioBaseTotal

END;
GO

CREATE FUNCTION FGNN_19.FN_Pasaje_no_cancelado(@idPasaje NUMERIC(18,0))
RETURNS BIT
AS
BEGIN

	IF NOT EXISTS (SELECT 1
		FROM Pasajes_Cancelados 
		WHERE id_pasaje = @idPasaje)
		RETURN 1

	RETURN 0

END
GO

CREATE FUNCTION FGNN_19.FN_Tiene_fecha_libre(@idCrucero NUMERIC(18,0), @fecha_inicio DATETIME2(3), @fecha_fin DATETIME2(3))
RETURNS INT
AS
BEGIN
	

	IF NOT EXISTS (SELECT 1
		FROM Viajes v
			JOIN Pasajes p ON p.viaje_codigo = v.codigo
		WHERE v.crucero_id = @idCrucero AND v.fecha_inicio < @fecha_fin AND v.fecha_fin > @fecha_inicio AND FGNN_19.FN_Pasaje_no_cancelado(p.id) = 1)
		RETURN 1

	RETURN 0

END
GO

CREATE FUNCTION FGNN_19.FN_Puede_cumplir_recorrido(@idCrucero NUMERIC(18,0), @idRecorrido NUMERIC(18,0))
RETURNS INT
AS
BEGIN

	IF EXISTS (SELECT 1
		FROM FGNN_19.Recorridos_X_Crucero
		WHERE recorrido_codigo = @idRecorrido AND recorrido_crucero = @idCrucero)
		RETURN 1

	RETURN 0

END
GO

CREATE FUNCTION FGNN_19.FN_Puede_cumplir_sus_viajes(@idCruceroOriginal NUMERIC(18,0), @idCruceroReemplazo NUMERIC(18,0), @fechaHoy datetime2(3))
RETURNS BIT
AS
BEGIN

	DECLARE @cantidad_pasajes_cumple_fecha INT
	DECLARE @cantidad_pasajes_cumple_recorrido INT
	DECLARE @cantidad_pasajes_existentes INT

	SET @cantidad_pasajes_cumple_fecha = (SELECT ISNULL(SUM(FGNN_19.FN_Tiene_fecha_libre(@idCruceroReemplazo, fecha_inicio, fecha_fin)),0)
		FROM FGNN_19.Viajes v
		WHERE v.crucero_id = @idCruceroOriginal AND v.fecha_inicio >= @fechaHoy
		GROUP BY v.crucero_id)
		
	SET @cantidad_pasajes_cumple_recorrido = (SELECT ISNULL(SUM(FGNN_19.FN_Puede_cumplir_recorrido(@idCruceroReemplazo, recorrido_codigo)),0)
		FROM FGNN_19.Viajes v
		WHERE v.crucero_id = @idCruceroOriginal AND v.fecha_inicio >= @fechaHoy
		GROUP BY v.crucero_id)

	SET @cantidad_pasajes_existentes = (SELECT COUNT(DISTINCT v.codigo)
		FROM FGNN_19.Viajes v
			JOIN FGNN_19.Pasajes p ON p.viaje_codigo = v.codigo
		WHERE v.crucero_id = @idCruceroOriginal AND v.fecha_inicio >= @fechaHoy AND FGNN_19.FN_Pasaje_no_cancelado(p.id) = 1
		GROUP BY v.crucero_id)

	IF(@cantidad_pasajes_cumple_fecha = @cantidad_pasajes_existentes AND @cantidad_pasajes_cumple_recorrido = @cantidad_pasajes_existentes)
		RETURN 1

	RETURN 0

END
GO

CREATE FUNCTION FGNN_19.FN_Crucero_reemplazante(@idCruceroOriginal NUMERIC(18,0), @fechaHoy VARCHAR(255))
RETURNS NUMERIC(18,0)
AS
BEGIN

	DECLARE @idCruceroReemplazo NUMERIC(18,0)

	SET @idCruceroReemplazo = (SELECT TOP 1 cr.id
		FROM FGNN_19.Cruceros co
			JOIN FGNN_19.Cruceros cr ON co.id != cr.id
		WHERE co.id = @idCruceroOriginal AND cr.baja_servicio = 0 AND cr.baja_vida_util = 0 AND cr.modelo = co.modelo AND cr.tipo_servicio = co.tipo_servicio
			AND FGNN_19.FN_Puede_cumplir_sus_viajes(@idCruceroOriginal, cr.id, Convert(datetime2,@fechaHoy,103)) = 1
			)

	RETURN @idCruceroReemplazo
END
GO

CREATE FUNCTION FGNN_19.FN_Cabina_reemplazante(@idCrucero NUMERIC(18,0), @idCabinaVieja NUMERIC(18,0))
RETURNS NUMERIC(18,0)
AS
BEGIN

	DECLARE @numero NUMERIC(18,0) = (SELECT numero FROM Cabinas WHERE codigo = @idCabinaVieja)
	DECLARE @piso NUMERIC(18,0) = (SELECT piso FROM Cabinas WHERE codigo = @idCabinaVieja)
	DECLARE @tipo_id NUMERIC(18,0) = (SELECT tipo_id FROM Cabinas WHERE codigo = @idCabinaVieja)

	RETURN (SELECT codigo
		FROM Cabinas 
		WHERE crucero_id = @idCrucero AND numero = @numero AND piso = @piso AND tipo_id = @tipo_id)

END
GO

-- Procedures

CREATE PROCEDURE FGNN_19.P_PuedeViajarCliente
@codigoViaje NUMERIC(18,0),
@idCliente NUMERIC(18,0)
AS
BEGIN

	IF EXISTS(SELECT v1.codigo FROM FGNN_19.Clientes c, FGNN_19.Viajes v1, FGNN_19.Viajes v2, FGNN_19.Pasajes p2
			WHERE p2.cliente_id = c.id
			AND p2.viaje_codigo = v2.codigo
			AND v1.fecha_inicio < v2.fecha_fin
			AND v1.codigo = @codigoViaje
			AND c.id = @idCliente
			AND v1.codigo != v2.codigo)
	BEGIN
		SELECT 0
	END
	ELSE
	BEGIN
		SELECT 1
	END

END;
GO

CREATE PROCEDURE FGNN_19.P_TramoRecorridoOriginal
@idTramo NUMERIC(18,0),
@idRecorrido NUMERIC(18,0)
AS
BEGIN

SELECT t.id FROM FGNN_19.Tramos t, FGNN_19.Recorridos r, FGNN_19.Recorrido_X_Tramo rt
WHERE t.id = rt.tramo_id
AND r.id = rt.recorrido_id
AND t.id = @idTramo
AND r.id = @idRecorrido
	
END;
GO

CREATE PROCEDURE FGNN_19.P_TramosDelRecorrido
@idRecorrido NUMERIC(18,0)
AS
BEGIN

SELECT t.id, t.puerto_desde_id, t.puerto_hasta_id, pd.descripcion, ph.descripcion, t.precio_base
FROM FGNN_19.Tramos t, FGNN_19.Recorrido_X_Tramo rt, FGNN_19.Recorridos r, FGNN_19.Puertos pd, FGNN_19.Puertos ph
WHERE t.id = rt.tramo_id
AND r.id = rt.recorrido_id
AND r.id = @idRecorrido
AND pd.id = t.puerto_desde_id
AND ph.id = t.puerto_hasta_id
ORDER BY rt.orden ASC

END;
GO

CREATE PROCEDURE FGNN_19.P_IngresarRecorrido
@Codigo VARCHAR(255),
@idPuertoDesde NUMERIC(18,0),
@idPuertoHasta NUMERIC(18,0),
@idRecorridoIngresado NUMERIC(18,0) OUTPUT
AS
BEGIN

INSERT INTO FGNN_19.Recorridos (codigo, puerto_desde_id, puerto_hasta_id)
VALUES(@Codigo, @idPuertoDesde, @idPuertoHasta)

SET @idRecorridoIngresado = SCOPE_IDENTITY()

RETURN @idRecorridoIngresado

END;
GO

CREATE PROCEDURE FGNN_19.P_IngresarRecorrido_X_Tramo
@idRecorrido NUMERIC(18,0),
@idTramo NUMERIC(18,0),
@orden NUMERIC(18,0)
AS
BEGIN

INSERT INTO FGNN_19.Recorrido_X_Tramo (recorrido_id, tramo_id, orden)
VALUES(@idRecorrido, @idTramo, @orden)

END;
GO

CREATE PROCEDURE FGNN_19.P_ValidarLogin 
@User VARCHAR(255), 
@Pass VARCHAR(255), 
@Resultado INT OUTPUT
AS
BEGIN TRANSACTION
	IF EXISTS (
			SELECT 1
			FROM FGNN_19.Usuarios
			WHERE username = @User
			)
	BEGIN
		IF EXISTS (
				SELECT 1
				FROM FGNN_19.Usuarios
				WHERE username = @User
				AND password = CONVERT(BINARY (32), HASHBYTES('SHA2_256',@Pass))
				)
		BEGIN
			SET @Resultado = 0
		END
		ELSE
		BEGIN
			UPDATE FGNN_19.Usuarios
			SET intentos_fallidos = intentos_fallidos + 1
			WHERE username = @user

			SET @Resultado = 1
		END
	END
	ELSE
	BEGIN
		SET @Resultado = 1
	END

	RETURN @Resultado
COMMIT TRANSACTION;
GO

CREATE PROCEDURE [FGNN_19].[P_InsertarCrucero] 
@nombre VARCHAR(255),
@fecha_alta datetime2(3),
@modelo VARCHAR(255),
@fabricante_id NUMERIC(18,0),
@tipo_servicio VARCHAR(255),
@cant_cabinas SMALLINT
AS
BEGIN TRANSACTION

INSERT INTO FGNN_19.Cruceros (nombre, fecha_alta, modelo, fabricante_id, tipo_servicio, cant_cabinas)
VALUES(@nombre, @fecha_alta, @modelo, @fabricante_id, @tipo_servicio, @cant_cabinas)

COMMIT TRANSACTION;
GO

CREATE PROCEDURE [FGNN_19].[P_InsertarViaje] 
@idCrucero NUMERIC(18,0), 
@idRecorrido NUMERIC(18,0),
@fechaInicio DATETIME2(3),
@fechaFin DATETIME2(3)
AS
BEGIN TRANSACTION

INSERT INTO FGNN_19.Viajes(crucero_id, recorrido_codigo, fecha_inicio, fecha_fin)
VALUES(@idCrucero, @idRecorrido, @fechaInicio, @fechaFin)

IF NOT EXISTS(SELECT * FROM FGNN_19.Recorridos_X_Crucero rc
			  WHERE recorrido_codigo = @idRecorrido
			  AND recorrido_crucero = @idCrucero)
	BEGIN
		INSERT INTO FGNN_19.Recorridos_X_Crucero
		VALUES(@idRecorrido, @idCrucero)
	END

COMMIT TRANSACTION;
GO

CREATE PROCEDURE FGNN_19.P_Viaje_valido
@idCrucero NUMERIC(18,0), 
@idRecorrido NUMERIC(18,0),
@fechaInicio DATETIME2(3),
@fechaFin DATETIME2(3),
@Resultado INT OUTPUT
AS
BEGIN
	
	DECLARE @idPuertoDesde NUMERIC(18,0)
	DECLARE @idPuertoHasta NUMERIC(18,0)

	SELECT @idPuertoDesde = r.puerto_desde_id,
		   @idPuertoHasta = r.puerto_hasta_id
	FROM FGNN_19.Recorridos r
	WHERE r.id = @idRecorrido

	IF @fechaFin < @fechaInicio
	BEGIN
		SET @Resultado = 0
	END
	ELSE IF EXISTS(SELECT id
				  FROM Cruceros
				  WHERE id = @idCrucero
					AND FGNN_19.FN_Tiene_fecha_libre(id, @fechaInicio, @fechaFin) = 0)
	BEGIN
		SET @Resultado = 0
	END
	ELSE
	BEGIN
		SET @Resultado = 1
	END

RETURN @Resultado	

END;
GO

CREATE PROCEDURE FGNN_19.Baja_difinitiva_crucero (@idCrucero numeric(18,0), @fechaBaja datetime2(3))
AS
BEGIN TRANSACTION

	UPDATE FGNN_19.Cruceros
	SET baja_vida_util = 1, fecha_baja_definitiva = @fechaBaja
	WHERE id = @idCrucero

COMMIT TRANSACTION;
GO

CREATE PROCEDURE FGNN_19.Baja_temporal_crucero (@idCrucero numeric(18,0), @fechaBaja datetime2(3), @fechaReinicio datetime2(3))
AS
BEGIN TRANSACTION

	UPDATE FGNN_19.Cruceros
	SET baja_servicio = 1, fecha_fuera_servicio = @fechaBaja, fecha_reinicio_servicio = @fechaReinicio
	WHERE id = @idCrucero

COMMIT TRANSACTION;
GO

CREATE PROCEDURE FGNN_19.Actualizacion_reinicio_cruceros
@fechaHoy VARCHAR(255)
AS
BEGIN TRANSACTION

	UPDATE FGNN_19.Cruceros
	SET baja_servicio = 0, fecha_fuera_servicio = NULL, fecha_reinicio_servicio = NULL
	WHERE baja_servicio = 1 AND fecha_reinicio_servicio <= Convert(datetime2,@fechaHoy,103)

COMMIT TRANSACTION;
GO

CREATE PROCEDURE FGNN_19.Actualizar_Reservas
@fechaHoy VARCHAR(255)
AS
BEGIN TRANSACTION

	UPDATE FGNN_19.Reservas
	SET habilitada = 0
	WHERE habilitada = 1 AND ABS(DATEDIFF(day, fecha, Convert(datetime2,@fechaHoy,103))) >= 4 

	UPDATE c
	SET estado = 1
	FROM FGNN_19.Cabinas c, FGNN_19.Pasajes p, FGNN_19.Reservas r
	WHERE c.codigo = p.cabina_id
	AND p.reserva_codigo = r.id
	AND r.habilitada = 0

COMMIT TRANSACTION;
GO

CREATE PROCEDURE FGNN_19.Actualizar_Viajes
@fechaHoy VARCHAR(255)
AS
BEGIN

	UPDATE c
	SET estado = 1
	FROM FGNN_19.Cabinas c, FGNN_19.Pasajes p, FGNN_19.Viajes v
	WHERE c.codigo = p.cabina_id
	AND p.viaje_codigo = v.codigo
	AND v.fecha_fin < Convert(datetime2,@fechaHoy,103)

END;
GO

CREATE PROCEDURE FGNN_19.Cancelar_pasajes_crucero(@idCrucero NUMERIC(18,0), @motivo VARCHAR(255), @fechaHoy VARCHAR(255), @fechaReinicio datetime2(3))
AS
BEGIN TRANSACTION
	
	INSERT INTO FGNN_19.Pasajes_Cancelados(id_pasaje, fecha_cancelacion, motivo)
	SELECT p.id, Convert(datetime2,@fechaHoy,103), @motivo
	FROM Pasajes p
		JOIN Cabinas c ON c.codigo = p.cabina_id
	WHERE c.crucero_id = @idCrucero

	UPDATE Cruceros
	SET baja_servicio = 1, fecha_fuera_servicio = Convert(datetime2,@fechaHoy,103), fecha_reinicio_servicio = @fechaReinicio
	WHERE id = @idCrucero

	UPDATE FGNN_19.Cabinas
	SET estado = 1
	WHERE crucero_id = @idCrucero

COMMIT TRANSACTION;
GO

CREATE PROCEDURE FGNN_19.Cancelar_pasajes_crucero_definitiva(@idCrucero NUMERIC(18,0), @motivo VARCHAR(255), @fechaHoy VARCHAR(255))
AS
BEGIN TRANSACTION
	
	INSERT INTO FGNN_19.Pasajes_Cancelados(id_pasaje, fecha_cancelacion, motivo)
	SELECT p.id, Convert(datetime2,@fechaHoy,103), @motivo
	FROM Pasajes p
		JOIN Cabinas c ON c.codigo = p.cabina_id
	WHERE c.crucero_id = @idCrucero

	UPDATE Cruceros
	SET baja_vida_util = 1, fecha_baja_definitiva = Convert(datetime2,@fechaHoy,103)
	WHERE id = @idCrucero 

COMMIT TRANSACTION;
GO

CREATE PROCEDURE FGNN_19.Reemplazar_crucero(@idCrucero NUMERIC(18,0), @fechaHoy VARCHAR(255), @resultado INT OUTPUT)
AS
BEGIN TRANSACTION

	DECLARE @idCruceroReemplazo NUMERIC(18,0)

	SET @resultado = 0

	SET @idCruceroReemplazo = FGNN_19.FN_Crucero_reemplazante(@idCrucero, @fechaHoy)

	IF(@idCruceroReemplazo IS NULL)
		BEGIN
			SET @resultado = 1
			COMMIT TRANSACTION
			RETURN
		END

	UPDATE Pasajes 
	SET cabina_id = FGNN_19.FN_Cabina_reemplazante(@idCruceroReemplazo, cabina_id)
	WHERE EXISTS(SELECT 1 FROM Cabinas c WHERE c.codigo = cabina_id AND c.crucero_id = @idCrucero) 
		AND EXISTS(SELECT 1 FROM Viajes v WHERE v.codigo = viaje_codigo AND v.fecha_inicio >= Convert(datetime2,@fechaHoy,103))
		AND FGNN_19.FN_Pasaje_no_cancelado(id) = 1

	UPDATE Viajes
	SET crucero_id = @idCruceroReemplazo
	WHERE crucero_id = @idCrucero AND fecha_inicio >= Convert(datetime2,@fechaHoy,103) AND EXISTS(SELECT 1 FROM Pasajes WHERE viaje_codigo = codigo AND FGNN_19.FN_Pasaje_no_cancelado(id) = 1)

	UPDATE Cruceros
	SET baja_vida_util = 1, fecha_baja_definitiva = Convert(datetime2,@fechaHoy,103)
	WHERE id = @idCrucero 

COMMIT TRANSACTION;
GO

CREATE PROCEDURE FGNN_19.Reeprogramar_viajes_crucero(@idCrucero NUMERIC(18,0), @cantidadDias INT, @fechaHoy VARCHAR(255))
AS
BEGIN TRANSACTION

	UPDATE Viajes
	SET fecha_inicio = DATEADD(DAY, @cantidadDias, fecha_inicio), fecha_fin = DATEADD(DAY, @cantidadDias, fecha_fin)
	WHERE crucero_id = @idCrucero AND fecha_inicio >= Convert(datetime2,@fechaHoy,103) AND EXISTS(SELECT 1 FROM Pasajes WHERE viaje_codigo = codigo AND FGNN_19.FN_Pasaje_no_cancelado(id) = 1)

COMMIT TRANSACTION;
GO

CREATE PROCEDURE FGNN_19.Fecha_valida_corrimiento(@idCrucero NUMERIC(18,0), @cantidadDias INT, @fecha_reinicio_servicio DATETIME2(3), @fechaHoy VARCHAR(255), @Resultado INT OUTPUT)
AS
BEGIN

	DECLARE @fecha_pasaje_proximo DATETIME2(3) 
	
	SET @fecha_pasaje_proximo = (SELECT TOP 1 fecha_inicio
		FROM Viajes
		WHERE crucero_id = @idCrucero AND fecha_inicio > Convert(datetime2,@fechaHoy,103)
		ORDER BY fecha_inicio ASC)

	IF(CONVERT(DATETIME2(3), DATEADD(DAY, @cantidadDias, @fecha_pasaje_proximo)) < @fecha_reinicio_servicio)
		SET @Resultado = 0
	ELSE
		SET @Resultado = 1

	RETURN @Resultado
END
GO

CREATE PROCEDURE FGNN_19.P_CabinasDelCrucero
@idCrucero NUMERIC(18,0)
AS
BEGIN

SELECT codigo, numero, piso, tc.descripcion
FROM FGNN_19.Cabinas c, FGNN_19.Tipos_Cabinas tc
WHERE estado = 1
AND tc.id = c.tipo_id
AND crucero_id = @idCrucero

END
GO

CREATE PROCEDURE FGNN_19.TOP5_recorridos_mas_comprados(@anio INT, @semestre INT)
AS
BEGIN
DECLARE @QUERY_FINAL NVARCHAR(1500)
DECLARE @QUERY_1 VARCHAR(200) = 'SELECT TOP 5 ps.descripcion AS [Puerto de salida], pl.descripcion [Puerto de llegada], COUNT(*) AS [Cantidad de pasajes vendidos]'
DECLARE @QUERY_2 VARCHAR(200) = ' FROM FGNN_19.Pasajes p JOIN FGNN_19.Viajes v ON v.codigo = p.viaje_codigo JOIN FGNN_19.Recorridos r ON r.id = v.recorrido_codigo'
DECLARE @QUERY_3 VARCHAR(200) = ' JOIN FGNN_19.Compras c ON c.codigo = p.compra_codigo JOIN FGNN_19.Puertos ps ON ps.id = r.puerto_desde_id JOIN FGNN_19.Puertos pl ON pl.id = r.puerto_hasta_id '
DECLARE @QUERY_4 VARCHAR(200)
DECLARE @QUERY_5 VARCHAR(200) = ' GROUP BY r.id, ps.descripcion, pl.descripcion ORDER BY [Cantidad de pasajes vendidos] DESC'

		IF @semestre = 1
			SET @QUERY_4 = 'WHERE YEAR(c.fecha) = @anio AND MONTH(c.fecha) IN (1, 2, 3, 4, 5, 6)'
		ELSE
			SET @QUERY_4 = 'WHERE YEAR(c.fecha) = @anio AND MONTH(c.fecha) IN (7, 8, 9, 10, 11, 12)'
	SET @QUERY_FINAL = @QUERY_1 + @QUERY_2 + @QUERY_3 + @QUERY_4 + @QUERY_5
	EXEC sp_executesql @QUERY_FINAL, N'@anio INT, @semestre INT', @anio, @semestre

END
GO


CREATE PROCEDURE FGNN_19.TOP5_recorridos_mas_cabinas_libres(@anio INT, @semestre INT)
AS
BEGIN
DECLARE @QUERY_FINAL NVARCHAR(1500)
DECLARE @QUERY_1 VARCHAR(200) = 'SELECT TOP 5 ps.descripcion AS [Puerto de salida], pl.descripcion AS [Puerto de llegada], COUNT(*) AS [Cantidad de cabinas libres]'
DECLARE @QUERY_2 VARCHAR(200) = ' FROM FGNN_19.Cabinas c JOIN FGNN_19.Pasajes p ON p.cabina_id = c.codigo JOIN FGNN_19.Viajes v ON v.codigo = p.viaje_codigo'
DECLARE @QUERY_3 VARCHAR(200) = ' JOIN FGNN_19.Recorridos r ON r.id = v.recorrido_codigo JOIN FGNN_19.Puertos ps ON ps.id = r.puerto_desde_id JOIN FGNN_19.Puertos pl ON pl.id = r.puerto_hasta_id'
DECLARE @QUERY_4 VARCHAR(200) = ' WHERE c.estado = 0 AND '
DECLARE @QUERY_5 VARCHAR(200)
DECLARE @QUERY_6 VARCHAR(200) = ' GROUP BY r.id, ps.descripcion, pl.descripcion ORDER BY [Cantidad de cabinas libres] DESC'
	
	IF @semestre = 1
			SET @QUERY_5 = 'YEAR(v.fecha_fin) = @anio AND MONTH(v.fecha_fin) IN (1, 2, 3, 4, 5, 6)'
		ELSE
			SET @QUERY_5 = 'YEAR(v.fecha_fin) = @anio AND MONTH(v.fecha_fin) IN (7, 8, 9, 10, 11, 12)'
	SET @QUERY_FINAL = @QUERY_1 + @QUERY_2 + @QUERY_3 + @QUERY_4 + @QUERY_5 + @QUERY_6
	EXEC sp_executesql @QUERY_FINAL, N'@anio INT, @semestre INT', @anio, @semestre

END
GO


CREATE PROCEDURE FGNN_19.TOP5_cruceros_mas_dias_fuera_servicio(@anio INT, @semestre INT, @fechaHoy datetime2(3))
AS
BEGIN
DECLARE @QUERY_FINAL NVARCHAR(1500)
DECLARE @QUERY_1 VARCHAR(200) = 'SELECT TOP 5 nombre, modelo, DATEDIFF(DAY, fecha_fuera_servicio, @fechaHoy) AS [Dias fuera de servicio]'
DECLARE @QUERY_2 VARCHAR(200) = ' FROM FGNN_19.Cruceros WHERE fecha_reinicio_servicio < @fechaHoy AND ' 
DECLARE @QUERY_3 VARCHAR(200)
DECLARE @QUERY_4 VARCHAR(200) = ' GROUP BY id, nombre, modelo, fecha_fuera_servicio ORDER BY [Dias fuera de servicio] DESC'

	IF @semestre = 1
			SET @QUERY_3 = 'YEAR(fecha_fuera_servicio) = @anio AND MONTH(fecha_fuera_servicio) IN (1, 2, 3, 4, 5, 6)'
		ELSE
			SET @QUERY_3 = 'YEAR(fecha_fuera_servicio) = @anio AND MONTH(fecha_fuera_servicio) IN (7, 8, 9, 10, 11, 12)'
	SET @QUERY_FINAL = @QUERY_1 + @QUERY_2 + @QUERY_3 + @QUERY_4
	EXEC sp_executesql @QUERY_FINAL, N'@anio INT, @semestre INT', @anio, @semestre

END
GO


CREATE PROCEDURE FGNN_19.Datos_cliente(@dni NUMERIC(18,0), @id NUMERIC(18,0) OUTPUT, @nombre VARCHAR(255) OUTPUT, @apellido VARCHAR(255) OUTPUT, @direccion VARCHAR(255) OUTPUT, @telefono NUMERIC(18,0) OUTPUT,
	@fecha_nac DATETIME2(3) OUTPUT, @mail VARCHAR(255) OUTPUT)
AS
BEGIN

	SELECT @id = id, @nombre = nombre, @apellido = apellido, @direccion = direccion,
		@telefono = telefono, @fecha_nac = fecha_nac, @mail = mail
	FROM FGNN_19.Clientes
	WHERE dni = @dni

END;
GO

CREATE PROCEDURE FGNN_19.Insertar_Compra(@metodo_pago NUMERIC(18,0), @cuotas INT, @fechaHoy VARCHAR(255), @codigo NUMERIC(18,0) OUTPUT)
AS
BEGIN TRANSACTION

	INSERT INTO Compras(metodo_pago, cuotas, fecha)
	VALUES(@metodo_pago, @cuotas, Convert(datetime2,@fechaHoy,103))

	SET @codigo = SCOPE_IDENTITY()

COMMIT TRANSACTION;
GO

CREATE PROCEDURE FGNN_19.Calcular_costo_pasaje(@idViaje NUMERIC(18,0), @idCabina NUMERIC(18,0), @precio_final NUMERIC(18,0) OUTPUT)
AS
BEGIN
	
	DECLARE @idRecorrido NUMERIC(18,0)
	DECLARE @PorcAdicional FLOAT
	DECLARE @PrecioBaseTotal FLOAT

	SET @idRecorrido = (SELECT v.recorrido_codigo
		FROM FGNN_19.Viajes v
		WHERE v.codigo = @idViaje)

	SET @PorcAdicional = (SELECT tc.porcentaje_adicional
		FROM FGNN_19.Cabinas c
			JOIN FGNN_19.Tipos_Cabinas tc ON tc.id = c.tipo_id
			WHERE c.codigo = @idCabina)

	SET @PrecioBaseTotal = FGNN_19.FN_Calcular_costo_base(@idRecorrido)

	SET @precio_final = @PrecioBaseTotal * @PorcAdicional
END
GO

CREATE PROCEDURE FGNN_19.Insertar_pasaje(@reserva_codigo NUMERIC(18,0) = NULL, @cliente_id NUMERIC(18,0), 
	@compra_codigo NUMERIC(18,0) = NULL, @viaje_codigo NUMERIC(18,0), @cabina_codigo NUMERIC(18,0), @precio float)
AS
BEGIN TRANSACTION

	INSERT INTO Pasajes(reserva_codigo, cliente_id, compra_codigo, viaje_codigo, cabina_id, precio)
	VALUES(@reserva_codigo, @cliente_id, @compra_codigo, @viaje_codigo, @cabina_codigo, @precio)

	UPDATE FGNN_19.Cabinas
	SET estado = 0
	WHERE codigo = @cabina_codigo

COMMIT TRANSACTION;
GO

CREATE PROCEDURE FGNN_19.Obtener_id_metodo_pago(@descripcion VARCHAR(255), @id NUMERIC(18,0) OUTPUT)
AS
BEGIN
	
	SET @id = (SELECT id FROM FGNN_19.Metodos_Pago WHERE descripcion = @descripcion)

END;
GO

CREATE PROCEDURE FGNN_19.Insertar_Reserva(@fechaHoy VARCHAR(255), @id NUMERIC(18,0) OUTPUT)
AS
BEGIN TRANSACTION

	INSERT INTO Reservas(habilitada, fecha)
	VALUES(1, Convert(datetime2,@fechaHoy,103))

	SET @id = SCOPE_IDENTITY()

COMMIT TRANSACTION;
GO

CREATE PROCEDURE FGNN_19.Obtener_datos_mostrar_pasaje(@id_viaje DECIMAL(18,0), @id_cabina DECIMAL(18,0), @descripcionPS VARCHAR(255) OUTPUT,
	@descripcionPL VARCHAR(255) OUTPUT, @fecha_salida DATETIME2(3) OUTPUT, @fecha_llegada DATETIME2(3) OUTPUT, @crucero_nombre VARCHAR(255) OUTPUT,
	@cabina_numero INT OUTPUT)
AS
BEGIN

	(SELECT @descripcionPS = p.descripcion
		FROM FGNN_19.Viajes v
			JOIN FGNN_19.Recorridos r ON r.id = v.recorrido_codigo
			JOIN FGNN_19.Puertos p ON p.id = r.puerto_desde_id
		WHERE v.codigo = @id_viaje)

	(SELECT @descripcionPL = p.descripcion
		FROM FGNN_19.Viajes v
			JOIN FGNN_19.Recorridos r ON r.id = v.recorrido_codigo
			JOIN FGNN_19.Puertos p ON p.id = r.puerto_hasta_id
		WHERE v.codigo = @id_viaje)

	(SELECT @fecha_salida = fecha_inicio, @fecha_llegada = fecha_fin FROM FGNN_19.Viajes WHERE codigo = @id_viaje)

	(SELECT @crucero_nombre = cr.nombre, @cabina_numero = ca.numero
		FROM Cabinas ca
			JOIN Cruceros cr ON cr.id = ca.crucero_id
		WHERE ca.codigo = @id_cabina)
END;
GO

CREATE PROCEDURE FGNN_19.P_Actualizar_Recorridos 
@fechaHoy VARCHAR(255)
AS
BEGIN

UPDATE FGNN_19.Recorridos
SET habilitado = 1
WHERE id IN (SELECT r.id FROM FGNN_19.Recorridos r, FGNN_19.Viajes v
			 WHERE r.habilitado = 0
			 AND r.id = v.recorrido_codigo
			 AND v.fecha_inicio > Convert(datetime2,@fechaHoy,103)
			 GROUP BY r.id)

END;
GO

CREATE PROCEDURE FGNN_19.P_Verificar_Recorrido
@idRecorrido NUMERIC(18,0),
@fechaHoy VARCHAR(255)
AS
BEGIN

SELECT r.id FROM FGNN_19.Recorridos r, FGNN_19.Viajes v
WHERE r.habilitado = 1
AND r.id = v.recorrido_codigo
AND r.id = @idRecorrido
AND v.fecha_inicio > convert(datetime2,@fechaHoy,103)
GROUP BY r.id

END;
GO

-- Triggers

CREATE TRIGGER FGNN_19.TR_Roles_InsteadOfDelete ON FGNN_19.Roles
INSTEAD OF DELETE
AS

BEGIN TRANSACTION

UPDATE FGNN_19.Roles
SET habilitado = 0
WHERE id IN (SELECT id FROM DELETED)

DELETE FROM FGNN_19.Usuarios_Roles
WHERE rol_id IN (SELECT id FROM DELETED)

COMMIT;
GO