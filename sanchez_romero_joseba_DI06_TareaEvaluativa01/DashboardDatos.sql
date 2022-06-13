CREATE DATABASE DASHBOARD
GO
USE DASHBOARD
go
--------------------------------------------------
--                 TABLAS  
----------------------------------------------------------------
-------------------//PRODUCTO//---------------------------------
CREATE TABLE CATEGORIAS
(
ID INT IDENTITY (1,1) PRIMARY KEY,
CATEGORIA  NVARCHAR (150)
)
go
CREATE TABLE MARCAS
(
ID INT IDENTITY (1,1) PRIMARY KEY,
MARCA  NVARCHAR (150)
)
go
CREATE TABLE PRODUCTOS
(
ID INT IDENTITY (1,1) PRIMARY KEY, 
ID_CATEGORIA INT,
ID_MARCA INT,
DESCRIPCION NVARCHAR (200),
PRECIO_COMPRA FLOAT,
PRECIO_VENTA FLOAT,
STOCK INT,
MARGEN_PORCIENTO AS ROUND((1-(PRECIO_COMPRA/PRECIO_VENTA))*100,2),
MARGEN_EUROS AS ROUND(PRECIO_VENTA-PRECIO_COMPRA,2),
MARGEN_STOCK AS ROUND((PRECIO_VENTA-PRECIO_COMPRA)*STOCK,2),
ESTADO NVARCHAR (15),
CONSTRAINT FK_CATEGORIA FOREIGN KEY (ID_CATEGORIA) REFERENCES CATEGORIAS(ID),
CONSTRAINT FK_MARCA FOREIGN KEY (ID_MARCA) REFERENCES MARCAS(ID),
)  
go
-------------------//PERSONAS//------------------------------------------------------------------------------
go
CREATE TABLE EMPLEADOS 
(
ID INT IDENTITY (1,1) PRIMARY KEY, 
DNI NVARCHAR (10),
CONTRASEÑA NVARCHAR (100),
NOMBRES NVARCHAR (150),
APELLIDOS NVARCHAR (150),
TELEFONO NVARCHAR (15),
DIRECCION NVARCHAR (150),
)
go
CREATE TABLE CLIENTES 
(
ID INT IDENTITY (1,1) PRIMARY KEY, 
NOMBRES NVARCHAR (150),
APELLIDOS NVARCHAR (150),
RUC NVARCHAR (30),
TELEFONO NVARCHAR (15),
DIRECCION NVARCHAR (150),
)
go
CREATE TABLE PROVEEDORES 
(
ID INT IDENTITY (1,1) PRIMARY KEY, 
RAZON_SOCIAL NVARCHAR (150),
RUC NVARCHAR (30),
TELEFONO NVARCHAR (15),
DIRECCION NVARCHAR (150),
)
go
-------------------//VENTA//------------------------------------------------------------------------------
CREATE TABLE VENTAS 
(
ID INT IDENTITY (1,1) PRIMARY KEY, 
TIPO_COMPROBANTE NVARCHAR (50),
SERIE_COMPROBANTE NVARCHAR (30),
FECHA DATE,
ID_CLIENTE INT,
ID_EMPLEADO INT,
TOTAL FLOAT,
CONSTRAINT FK_CLIENTE FOREIGN KEY (ID_CLIENTE) REFERENCES CLIENTES(ID),
CONSTRAINT FK_EMPLEADO FOREIGN KEY (ID_EMPLEADO) REFERENCES EMPLEADOS(ID)
)
go

CREATE TABLE DETALLE_VENTA
(
ID INT IDENTITY (1,1) PRIMARY KEY, 
ID_VENTA INT,
ID_PRODUCTO INT,
PRECIO_VENTA FLOAT,
CANTIDAD INT,
SUBTOTAL FLOAT,
CONSTRAINT FK_VENTA FOREIGN KEY (ID_VENTA) REFERENCES VENTAS(ID),
CONSTRAINT FK_PRODUCTO_V FOREIGN KEY (ID_PRODUCTO) REFERENCES PRODUCTOS(ID)
)
go
--INSERCION DE DATOS
INSERT INTO CATEGORIAS VALUES
(' S/C'),/*SIN CATEGORIA*/
('Preescolar'),
('Peluche'),
('Muñeca Fasion'),
('Mascota'),
('Auto'),
('Figura Animada'),
('Lanzadora'),
('Juego de rol'),
('Juego de mesa'),
('Rompecabeza'),
('Pelota'),
('Scooter'),
('Skates'),
('Accesorio')
 go

INSERT INTO MARCAS VALUES
(' S/M'),/*SIN MARCA*/
('Baby Alive'),
('Barbie'),
('Chicas Superpoderosas'),
('Disney Princesa'),
('Disney'),
('Frozen'),
('Lady Bug'),
('Play Doh'),
('Star Wars'),
('Tortugas Ninja'),
('Cars'),
('Dinotrux'),
('Hot Wheels'),
('MatchBox'),
('Nerf'),
('Transformes'),
('Boomco'),
('Avengers'),
('Batman'),
('Dragon Ball'),
('Mattel'),
('Max Steel'),
('Pokemon'),
('Mattel')
go

INSERT INTO EMPLEADOS VALUES 
('78952456','venta','Felipa','Montes Nogales','9658457455','Av Argentina 2015'),
('95456585','venta','Andoni','Hervas Belmonte','5694555512','Av la Marina'),
('16584555','venta','Mark','Fuente Trujillo','9632547852','Av la paz 2015'),
('78952456','compra','Gines','Merchan Carmona','9658457455','Av Argentina 2015'),
('78952456','compra','Adolfa','Jimenez Rivera','9658457455','Av Argentina 2015'),
('78952456','compra','Karina','Reina Velazquez','9658457455','Av Argentina 2015')

go

INSERT INTO PRODUCTOS VALUES
(	7	,	16	,'	ultra flash x10	',	44	,	44	,	30	,'	Activo'),
(	5	,	14	,'	pack 3	',	34	,	42	,	74	,'	Activo'	),
(	3	,	6	,'	Ariel	',	58	,	62	,	12	,'	Activo'),
(	8	,	22	,'	Cartas Magicas'	,	25	,	40	,	12	,'	Activo'),
(	15	,	1	,'	super cars',	10	,	15	,	20	,'	Activo'	),
(	5	,	14	,'	Azul extremo'	,	12	,	13	,	12	,'	Activo'	),
(	5	,	14	,'	black edition'	,	23	,	43	,	54	,'	Activo'	),
(	5	,	14	,'	4x4 ultimate'	,	65	,	67	,	12	,'	Activo'	),
(	5	,	14	,'	Transformes'	,	34	,	36	,	65	,'	Activo'	),
(	5	,	14	,'	Fire Edition'	,	56	,	63	,	345	,'	Activo'	),
(	3	,	6	,'	Rapuncel'	,	56	,	66	,	434	,'	Activo'),
(	3	,	6	,'	Valiente'	,	54	,	63	,	23	,'	Activo	'),
(	3	,	6	,'	Sirenita'	,	5	,	7	,	45	,'	Activo'	),
(	3	,	6	,'	Anna Frozzen'	,	12	,	14	,	43	,'	Activo'	),
(	3	,	6	,'	Elsa frozen'	,	23	,	25	,	4	,'	Activo'	),
(	7	,	16	,'	Laser Nif'	,	23	,	30	,	54	,'	Activo	'),
(	7	,	16	,'	Batman Cannon'	,	34	,	37	,	3	,'	Activo'),
(	8	,	9	,'	Monopolio PAris'	,	23	,	30	,	32	,'	Activo'	),
(	8	,	9	,'	Ajedrez StarWars'	,	34	,	36	,	43	,'	Activo	'),
(	15	,	21	,'	Goku black'	,	23	,	24	,	23	,'	Activo'	),
(	5	,	12	,'	Franchesco	',	341	,	422	,	12	,'	Activo'	),
(	5	,	12	,'	Rayo Macuin'	,	122	,	140	,	12	,'	Activo	'),
(	4	,	24	,'	Picachu	',	12	,	14	,	12	,'	Activo'	),
(	4	,	24	,'	Estrella'	,	123	,	133	,	34	,'	Activo'	),
(	4	,	24	,'	Dragon'	,	123	,	143	,	34	,'	Activo	'),
(	4	,	24	,'	Chicorita'	,	123	,	128	,	34	,'	Activo	'),
(	4	,	24	,'	Bolbason'	,	123	,	129	,	34	,'	Activo	'),
(	4	,	24	,'	rayxchu'	,	123	,	148	,	34	,'	Activo	'),
(	4	,	24	,'	Viper'	,	123	,	137	,	34	,'	Activo	'),
(	4	,	24	,'	Bobofe'	,	123	,	133	,	34	,'	Activo	'),
(	4	,	24	,'	Chaizar'	,	123	,	142	,	34	,'	Activo'	),
(	4	,	24	,'	charmilion'	,	123	,	126	,	34	,'	Activo'	),
(	15	,	12	,'	rayo'	,	123	,	127	,	34	,'	Activo	'),
(	15	,	12	,'	grua	',	123	,	300	,	34	,'	Activo'	),
(	15	,	12	,'	grulla'	,	123	,	125	,	34	,'	Activo	'),
(	6	,	21	,'	goku'	,	123	,	200	,	34	,'	Activo'),
(	6	,	21	,'	gokublack	',	123	,	200	,	34	,'	Activo'	),
(	6	,	21	,'	frezzer	',	123	,	125	,	34	,'	Activo	'),
(	6	,	21	,'	majimnbo'	,	123	,	125	,	34	,'	Activo'	),
(	6	,	21	,'	Cell'	,	123	,	125	,	34	,'	Activo'	),
(	6	,	21	,'	pikoro'	,	123	,	125	,	34	,'	Activo'	),
(	6	,	21	,'	gohan'	,	123	,	125	,	34	,'	Activo	'),
(	6	,	21	,'	chichi'	,	123	,	125	,	34	,'	Activo'	),
(	6	,	21	,'	bulma'	,	123	,	125	,	34	,'	Activo	'),
(	6	,	21	,'	vegeta'	,	123	,	125	,	34	,'	Activo	'),
(	6	,	21	,'	Trunsk'	,	123	,	125	,	34	,'	Activo	'),
(	6	,	21	,'	goten'	,	123	,	125	,	34	,'	Activo	'),
(	6	,	21	,'	Videl'	,	123	,	125	,	34	,'	Activo	'),
(	6	,	21	,'	krilin'	,	123	,	125	,	34	,'	Activo	'),
(	6	,	21	,'	yancha'	,	123	,	125	,	34	,'	Activo	'),
(	6	,	21	,'	nro 18'	,	123	,	125	,	34	,'	Activo'	),
(	6	,	21	,'	roshi'	,	123	,	125	,	34	,'	Activo'	),
(	6	,	21	,'	urnaibaba	',	123	,	125	,	34	,'	Activo'	),
(	8	,	1	,'	damas rosa'	,	123	,	125	,	34	,'	Activo'),
(	8	,	1	,'	mono polis cityt'	,	123	,	125	,	34	,'	Activo'	),
(	11	,	1	,'	futbol	',	234	,	245	,	34	,'	Activo'	),
(	11	,	1	,'	basket'	,	234	,	245	,	34	,'	Activo'	),
(	11	,	1	,'	tennis'	,	234	,	245	,	34	,'	Activo'	),
(	11	,	1	,'	kiko'	,	234	,	245	,	134	,'	Activo'	),
(	13	,	1	,'	chico slim'	,	234	,	245	,	34	,'	Activo'	),
(	13	,	1	,'	caros lfd	',	234	,	245	,	12	,'	Activo'	),
(	12	,	1	,'	rosa 1m	',	234	,	245	,	34	,'	Activo	'),
(	12	,	1	,'	tall da'	,	234	,	245	,	44	,'	Activo'	),
(	1	,	9	,'	laptop'	,	234	,	245	,	34	,'	Activo	'),
(	1	,	9	,'	calcu boy'	,	234	,	245	,	34	,'	Activo'	),
(	1	,	9	,'	origami'	,	234	,	245	,	34	,'	Activo	')
GO


INSERT INTO CLIENTES VALUES 
('Juan','Algeria Torres','9658457455','9658457455','Av Argentina 2015'),
('Rodolfo','Fernandez Ajala','5694555512','9658457455','Av la Marina'),
('Mariela','Del lago','9632547852','9658457455','Av la paz 2015')
GO

INSERT INTO VENTAS VALUES
('factura','6656565','12-06-2012',1,1,344),
('factura','6656565','20-06-2012',2,2,948), 
('factura','6656565','19-07-2012',3,3,540), 
('factura','6656565','19-08-2012',1,2,532),
('factura','6656565','19-09-2012',2,1,299), 
('factura','6656565','19-12-2012',3,3,211), 
('factura','6656565','12-01-2013',1,3,234), 
('factura','6656565','11-02-2013',2,2,928), 
('factura','6656565','19-03-2013',3,1,293)
GO  

INSERT INTO DETALLE_VENTA VALUES
(3,3,56,5,894),
(3,3,56,5,894),
(3,3,56,5,894),
(3,3,56,5,894),
(3,3,56,5,894),
(3,3,56,5,894),
(3,3,56,5,894),
(3,3,56,5,894),
(4,1,56,5,894),
(4,5,56,5,894),
(4,6,56,5,894),
(4,7,56,5,894),
(4,8,56,5,894),
(4,8,56,5,894),
(4,8,56,5,894),
(4,8,56,5,894),
(4,8,56,5,894),
(2,1,56,5,894),
(2,2,56,5,894),
(2,3,56,5,894),
(2,4,56,5,894),
(2,5,56,5,894),
(2,6,56,5,894),
(3,6,56,5,894),
(3,2,56,5,894),
(3,3,56,5,894),
(3,3,56,5,894),
(3,3,56,5,894),
(3,3,56,5,894)
go

