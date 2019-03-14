/*
Navicat SQL Server Data Transfer

Source Server         : SQL SERVER LOCAL
Source Server Version : 105000
Source Host           : DESKTOP-MBPE9RE:1433
Source Database       : Prueba
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 105000
File Encoding         : 65001

Date: 2019-03-13 20:35:20
*/


-- ----------------------------
-- Table structure for Estado
-- ----------------------------
DROP TABLE [dbo].[Estado]
GO
CREATE TABLE [dbo].[Estado] (
[id] int NOT NULL IDENTITY(1,1) ,
[nombre] varchar(255) NULL ,
[active] bit NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Estado]', RESEED, 32)
GO

-- ----------------------------
-- Records of Estado
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Estado] ON
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'1', N'Aguascalientes', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'2', N'Baja California', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'3', N'Baja California Sur', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'4', N'Campeche', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'5', N'Chiapas', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'6', N'Chihuahua', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'7', N'Ciudad de México', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'8', N'Coahuila de Zaragoza', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'9', N'Colima', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'10', N'Durango', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'11', N'Guanajuato', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'12', N'Guerrero', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'13', N'Hidalgo', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'14', N'Jalisco', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'15', N'México', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'16', N'Michoacán de Ocampo', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'17', N'Morelos', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'18', N'Nayarit', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'19', N'Nuevo León', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'20', N'Oaxaca', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'21', N'Puebla', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'22', N'Querétaro', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'23', N'Quintana Roo', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'24', N'San Luis Potosí', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'25', N'Sinaloa', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'26', N'Sonora', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'27', N'Tabasco', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'28', N'Tamaulipas', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'29', N'Tlaxcala', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'30', N'Veracruz de Ignacio de la Llave', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'31', N'Yucatán', N'1')
GO
GO
INSERT INTO [dbo].[Estado] ([id], [nombre], [active]) VALUES (N'32', N'Zacatecas', N'1')
GO
GO
SET IDENTITY_INSERT [dbo].[Estado] OFF
GO

-- ----------------------------
-- Table structure for Usuario
-- ----------------------------
DROP TABLE [dbo].[Usuario]
GO
CREATE TABLE [dbo].[Usuario] (
[Id] int NOT NULL IDENTITY(1,1) ,
[Nombres] varchar(255) NOT NULL ,
[PrimerApellido] varchar(255) NOT NULL ,
[SegundoApellido] varchar(255) NULL ,
[FechaNacimiento] datetime NOT NULL ,
[Sexo] bit NOT NULL ,
[EstadoNacimiento] int NOT NULL ,
[Telefono] bigint NOT NULL ,
[Estado] int NOT NULL ,
[Municipio] varchar(255) NOT NULL ,
[Colonia] varchar(255) NOT NULL ,
[CalleNumero] varchar(255) NULL ,
[activo] bit NULL DEFAULT ((1)) ,
[CURP] varchar(255) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Usuario]', RESEED, 4)
GO

-- ----------------------------
-- Records of Usuario
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Usuario] ON
GO
INSERT INTO [dbo].[Usuario] ([Id], [Nombres], [PrimerApellido], [SegundoApellido], [FechaNacimiento], [Sexo], [EstadoNacimiento], [Telefono], [Estado], [Municipio], [Colonia], [CalleNumero], [activo], [CURP]) VALUES (N'1', N'Pedro Maquir', N'Sarao', N'Cauich', N'1991-11-09 13:30:53.000', N'0', N'31', N'9999921063', N'7', N'Coyoacan', N'Santa Ursula', N'San Antonio, SN', N'1', N'SACP911109HYNRCD')
GO
GO
INSERT INTO [dbo].[Usuario] ([Id], [Nombres], [PrimerApellido], [SegundoApellido], [FechaNacimiento], [Sexo], [EstadoNacimiento], [Telefono], [Estado], [Municipio], [Colonia], [CalleNumero], [activo], [CURP]) VALUES (N'3', N'Mónica', N'Diaz', N'Rojas', N'1997-01-22 18:19:39.000', N'1', N'30', N'12233', N'30', N'Xalapa', N'Centro', N'alfaro 99', N'1', N'DIRM970122MVZZJN')
GO
GO
INSERT INTO [dbo].[Usuario] ([Id], [Nombres], [PrimerApellido], [SegundoApellido], [FechaNacimiento], [Sexo], [EstadoNacimiento], [Telefono], [Estado], [Municipio], [Colonia], [CalleNumero], [activo], [CURP]) VALUES (N'4', N'assa', N'sa', N'sasas', N'2019-03-13 18:28:13.973', N'1', N'3', N'222', N'4', N'Coyoacan', N'Santa Ursula', N'San antonio, SN', N'0', N'd')
GO
GO
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO

-- ----------------------------
-- Indexes structure for table Estado
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Estado
-- ----------------------------
ALTER TABLE [dbo].[Estado] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table Usuario
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Usuario
-- ----------------------------
ALTER TABLE [dbo].[Usuario] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[Usuario]
-- ----------------------------
ALTER TABLE [dbo].[Usuario] ADD FOREIGN KEY ([Estado]) REFERENCES [dbo].[Estado] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [dbo].[Usuario] ADD FOREIGN KEY ([EstadoNacimiento]) REFERENCES [dbo].[Estado] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
