
create database ID

use ID

create table ID
(ID int IDENTITY(1,1) primary key,
Nombre varchar(30));

--------Procdimiento Jalar Factura------------
create procedure Numero_ID
as select max (ID)+1 as Numero
from ID

-------Procedimiento Almacenar--------------
create procedure Insertar_ID
@Nombre varchar(30)
as INSERT INTO ID(Nombre)
VALUES(@Nombre)

execute Insertar_ID
@Nombre='Diego'
select *from ID

-------Procedimiento Borrar Factura-----------
drop proc Numero_ID

------Select de la Factura--------------------
select max (ID)+1 as Numero from ID