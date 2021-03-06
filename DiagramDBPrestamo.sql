/*
   Wednesday, May 1, 20199:56:20 PM
   Usuario: 
   Servidor: .\SQLEXPRESS
   Base de datos: 
   Aplicación: 
*/

/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Rol
	(
	rol_codigo nchar(10) NOT NULL,
	rol_descripcion nchar(50) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Rol ADD CONSTRAINT
	PK_Rol PRIMARY KEY CLUSTERED 
	(
	rol_codigo
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Rol SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Rol', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Rol', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Rol', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Periodo
	(
	per_codigo int NOT NULL,
	per_descripcion nchar(50) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Periodo ADD CONSTRAINT
	PK_Periodo PRIMARY KEY CLUSTERED 
	(
	per_codigo
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Periodo SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Periodo', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Periodo', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Periodo', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Destino
	(
	des_codigo int NOT NULL,
	des_descripcion nchar(50) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Destino ADD CONSTRAINT
	PK_Destino PRIMARY KEY CLUSTERED 
	(
	des_codigo
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Destino SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Destino', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Destino', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Destino', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Usuario
	(
	usu_id int NOT NULL,
	usu_nombreUsuario nchar(30) NOT NULL,
	usu_contraseña nchar(15) NOT NULL,
	usu_apellidonombre nchar(30) NOT NULL,
	rol_codigo nchar(10) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Usuario ADD CONSTRAINT
	PK_Usuario PRIMARY KEY CLUSTERED 
	(
	usu_id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Usuario ADD CONSTRAINT
	FK_Usuario_Rol FOREIGN KEY
	(
	rol_codigo
	) REFERENCES dbo.Rol
	(
	rol_codigo
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Usuario SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Usuario', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Usuario', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Usuario', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Cliente
	(
	cli_dni nchar(8) NOT NULL,
	cli_nombre nchar(30) NOT NULL,
	cli_apellido nchar(20) NOT NULL,
	cli_sexo nchar(10) NOT NULL,
	cli_fechaNacimiento date NOT NULL,
	cli_ingresos decimal(10, 2) NOT NULL,
	cli_direccion nchar(25) NOT NULL,
	cli_telefono nchar(20) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Cliente ADD CONSTRAINT
	PK_Cliente PRIMARY KEY CLUSTERED 
	(
	cli_dni
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Cliente SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Cliente', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Cliente', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Cliente', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Prestamo
	(
	pre_numero int NOT NULL,
	cli_dni nchar(8) NOT NULL,
	des_codigo int NOT NULL,
	per_codigo int NOT NULL,
	pre_fecha date NOT NULL,
	pre_importe decimal(10, 2) NOT NULL,
	pre_tasaInteres decimal(5, 2) NOT NULL,
	pre_cantidadCuotas int NOT NULL,
	pre_estado varchar(10) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Prestamo ADD CONSTRAINT
	PK_Prestamo PRIMARY KEY CLUSTERED 
	(
	pre_numero
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Prestamo ADD CONSTRAINT
	FK_Prestamo_Cliente FOREIGN KEY
	(
	cli_dni
	) REFERENCES dbo.Cliente
	(
	cli_dni
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Prestamo ADD CONSTRAINT
	FK_Prestamo_Destino FOREIGN KEY
	(
	des_codigo
	) REFERENCES dbo.Destino
	(
	des_codigo
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Prestamo ADD CONSTRAINT
	FK_Prestamo_Periodo FOREIGN KEY
	(
	per_codigo
	) REFERENCES dbo.Periodo
	(
	per_codigo
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Prestamo SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Prestamo', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Prestamo', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Prestamo', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Cuota
	(
	cuo_codigo int NOT NULL,
	pre_numero int NOT NULL,
	cuo_numero int NOT NULL,
	cuo_vencimiento date NULL,
	cuo_importe decimal(10, 2) NOT NULL,
	cuo_estado nchar(10) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Cuota ADD CONSTRAINT
	PK_Cuota PRIMARY KEY CLUSTERED 
	(
	cuo_codigo
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Cuota ADD CONSTRAINT
	FK_Cuota_Prestamo FOREIGN KEY
	(
	pre_numero
	) REFERENCES dbo.Prestamo
	(
	pre_numero
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Cuota SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Cuota', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Cuota', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Cuota', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Pago
	(
	pag_codigo int NOT NULL,
	cuo_codigo int NOT NULL,
	pag_fecha date NOT NULL,
	pag_importe decimal(10, 2) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Pago ADD CONSTRAINT
	PK_Pago PRIMARY KEY CLUSTERED 
	(
	pag_codigo
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Pago ADD CONSTRAINT
	FK_Pago_Cuota FOREIGN KEY
	(
	cuo_codigo
	) REFERENCES dbo.Cuota
	(
	cuo_codigo
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Pago SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Pago', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Pago', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Pago', 'Object', 'CONTROL') as Contr_Per 