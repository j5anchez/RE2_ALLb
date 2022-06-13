create proc Dashboard
@TotVentas float out,
@nprod int out,
@nmarc int out,
@ncateg int out,
@nclient int out,
@nprove int out,
@nemple int out

as

set @TotVentas=(select sum(TOTAL) as TotVentas from VENTAS)
set @nprod=(select count(ID) as CantProd from PRODUCTOS)
set @ncateg=(select count(ID) as CantCateg from CATEGORIAS)
set @nmarc=(select count(ID) as CantMarc from MARCAS)
set @nemple=(select count(ID) as CantEmple from EMPLEADOS)
set @nprove=(select count(ID) as CantProve from PROVEEDORES)
set @nclient=(select count(ID) as CantClient from CLIENTES)
go


-- 5 PRODUCTOS PREFERIDOS
CREATE PROC ProdPreferidos
as
select top 5 C.CATEGORIA+' '+M.MARCA+' '+P.DESCRIPCION AS PRODUCTO,COUNT(ID_PRODUCTO) as CantSalidas
from DETALLE_VENTA as DV
inner join PRODUCTOS as P on p.ID=DV.ID_PRODUCTO
inner join CATEGORIAS as C on c.ID=P.ID_CATEGORIA
inner join MARCAS AS M ON M.ID=P.ID_MARCA
group by DV.ID_PRODUCTO,C.CATEGORIA,M.MARCA,P.DESCRIPCION
order by count (2) desc
go
-- CANTIDAD DE PRODUCTOS POR CATEGORIA
CREATE PROC ProdPorCategoria
AS
select C.CATEGORIA,COUNT(ID_CATEGORIA) AS CANT
from PRODUCTOS as P
inner join CATEGORIAS AS C ON C.ID=P.ID_CATEGORIA
group by ID_CATEGORIA,C.CATEGORIA
order by count(2)
select * from PRODUCTOS
GO


-- MARGEN BENEFICIO PRODUCTOS PORCENTAJE
CREATE PROC MargenPorcentaje
AS
select M.MARCA,P.DESCRIPCION,P.MARGEN_PORCIENTO
from PRODUCTOS as P
inner join MARCAS AS M ON M.ID=P.ID_MARCA
group by P.DESCRIPCION,P.MARGEN_PORCIENTO,M.MARCA
order by P.MARGEN_PORCIENTO DESC
GO


-- MARGEN BENEFICIO PRODUCTOS EUROS
CREATE PROC MargenEuros
AS
select M.MARCA,P.DESCRIPCION,P.MARGEN_EUROS
from PRODUCTOS as P
inner join MARCAS AS M ON M.ID=P.ID_MARCA
group by P.DESCRIPCION,P.MARGEN_EUROS,M.MARCA
order by P.MARGEN_EUROS DESC
GO

-- MARGEN BENEFICIO PRODUCTOS STOCK
CREATE PROC MargenStock
AS
select M.MARCA,P.DESCRIPCION,P.MARGEN_STOCK
from PRODUCTOS as P
inner join MARCAS AS M ON M.ID=P.ID_MARCA
group by P.DESCRIPCION,P.MARGEN_STOCK,M.MARCA
order by P.MARGEN_STOCK DESC
GO


-- MEJORES CLIENTES
CREATE PROC MejoresClientes
AS
SELECT C.ID, C.NOMBRES,C.APELLIDOS, sum(V.TOTAL) AS TOTAL_COMPRAS
from VENTAS AS V
inner join CLIENTES AS C ON C.ID=V.ID_CLIENTE
group by V.ID_CLIENTE,C.NOMBRES,C.APELLIDOS,C.ID
ORDER BY TOTAL_COMPRAS DESC
GO


-- MEJORES EMPLEADOS
CREATE PROC MejoresEmpleados
AS
SELECT E.ID, E.NOMBRES,E.APELLIDOS, sum(V.TOTAL) AS TOTAL_VENTAS
from VENTAS AS V
inner join EMPLEADOS AS E ON E.ID=V.ID_EMPLEADO
group by V.ID_EMPLEADO,E.NOMBRES,E.APELLIDOS,E.ID
ORDER BY TOTAL_VENTAS DESC
GO


--- NUMERO TABLAS
--CREATE PROC NumeroTablas
--AS
--select count(0) from information_schema.tables
--GO

--- NOMBRES TABLAS
--CREATE PROC NombresTablas
--AS
--select table_name from information_schema.tables
--order by table_name asc
--GO

--- TABLA COLUMNA
--CREATE PROC TablaColumna
--AS
--select table_name, COLUMN_name from information_schema.COLUMNS
--order by table_name asc
--GO


--- NOMBRES COLUMNAS
---CREATE PROC NombresColumnas @TABLA VARCHAR(100)
---AS SELECT COLUMN_NAME
---FROM INFORMATION_SCHEMA.COLUMNS
---WHERE TABLE_NAME = N'@TABLA'
---GO

