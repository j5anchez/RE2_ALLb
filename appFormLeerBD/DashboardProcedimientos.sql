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
