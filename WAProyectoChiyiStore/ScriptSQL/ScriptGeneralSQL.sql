

--CREAR BASE DE DATOS
CREATE DATABASE [Chiyi]


--CREAR TABLAS
USE [Chiyi]
CREATE TABLE [dbo].[Clientes](
	[Cedula] varchar(15) primary key NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Telefono] int NULL,
	[Direccion] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
	[FechaIngreso] [datetime] DEFAULT  getdate())

CREATE TABLE CategoriasProductos
(	IdCategoria int IDENTITY(1,1) PRIMARY KEY ,
	Categoria varchar(100), 
	Temporada varchar(50) ) 
	
CREATE TABLE Productos
(	IdProducto int IDENTITY(1,1) primary key,
	Producto varchar(100),
	Descripcion varchar(100),
	IdCategoria int foreign key (IdCategoria) references CategoriasProductos (IdCategoria),
	Precio money,
	FechaIngreso datetime default getdate())

CREATE TABLE Factura
(	IdFactura int IDENTITY(0,1) primary key,
	FechaFactura datetime DEFAULT GETDATE(),
	Cedula varchar(15) foreign key (Cedula) references Clientes (Cedula),
	Saldo money,
	TipoPago varchar(15))

CREATE TABLE Compra
(	IdFactura int foreign key (IdFactura) references Factura (IdFactura),
	IdProducto int foreign key (IdProducto) references Productos (IdProducto),
	Cantidad int,
	Precio money)
	
--Tabla de Usuarios
CREATE TABLE Usuarios (
		Usuario VARCHAR(25) primary key,
		Clave INT,
		Nombre VARCHAR(150),
		Rol VARCHAR(25),
		FechaCreacion DATETIME DEFAULT GETDATE()
)


--VISTA
SELECT A.FechaFactura, A.Cedula, B.Nombre, B.Apellido ,A.Saldo, A.TipoPago, SUM(Cantidad) AS CantidadArticulos 
FROM Factura AS A
LEFT JOIN Clientes AS B ON A.Cedula = B.Cedula
LEFT JOIN Compra AS C ON A.IdFactura = C.IdFactura
WHERE Cantidad IS NOT NULL
GROUP BY A.FechaFactura, A.Cedula, B.Nombre, B.Apellido ,A.Saldo, A.TipoPago



--CARGAR DATOS INICIALES DE CATEGORIAS DE PRODUCTOS
INSERT INTO CategoriasProductos (Categoria, Temporada)
SELECT 'Otros', 'General' UNION
SELECT 'Alimento', 'General' UNION
SELECT 'Accesorios', 'General' UNION
SELECT 'Jaulas', 'General' 



--CREAR SP
CREATE PROCEDURE spIngresarCliente
					@Cedula varchar(15),
					@Nombre varchar(50),
					@Apellido  varchar(50),
					@Telefono  int,
					@Direccion  varchar(100),
					@Email  varchar(100) 
AS 
BEGIN

	INSERT INTO Clientes (Cedula, Nombre, Apellido, Telefono, Direccion, Email)
	VALUES (@Cedula, @Nombre, @Apellido, @Telefono, @Direccion, @Email)

END

CREATE PROCEDURE spModificarCliente
					@Cedula int,
					@Nombre varchar(50),
					@Apellido  varchar(50),
					@Telefono  varchar(8),
					@Direccion  varchar(100),
					@Email  varchar(100) 
AS 
BEGIN
	UPDATE Clientes SET		Nombre = @Nombre, 
							Apellido = @Apellido, 
							Telefono = @Telefono, 
							Direccion = @Direccion, 
							Email = @Email
	WHERE Cedula = @Cedula
END

CREATE PROCEDURE spIngresarFactura
					@IdFactura int,
					@FechaFactura datetime,
					@Cedula  varchar(15),
					@Saldo money,
					@TipoPago varchar(15)
AS 
BEGIN

	INSERT INTO Factura (FechaFactura, Cedula, Saldo, TipoPago)
	VALUES (@FechaFactura, @Cedula, @Saldo, @TipoPago)

END

ALTER PROCEDURE spIngresarCompra
					@IdFactura int,
					@IdProducto varchar(150),
					@Cantidad int,
					@Precio money
AS 
BEGIN
	INSERT INTO Compra (IdFactura, IdProducto, Cantidad, Precio)
	SELECT @IdFactura, A.IdProducto, @Cantidad, A.Precio
	FROM Productos AS A
	WHERE Producto = @IdProducto
	
END

CREATE PROCEDURE spIngresarProductos
					@Producto varchar(100),
					@Descripcion varchar(100),
					@Categoria  varchar(100),
					@Precio  money
AS 
BEGIN
	INSERT INTO Productos (Producto, Descripcion, IdCategoria, Precio)
	SELECT @Producto, @Descripcion, A.IdCategoria, @Precio
	FROM CategoriasProductos AS A
	WHERE Categoria = @Categoria
	
END

CREATE PROCEDURE dbo.spModificarProductos
					@Producto varchar(100),
					@Descripcion varchar(100),
					@Categoria  varchar(100),
					@Precio  money
AS 
BEGIN
	UPDATE Productos SET	Descripcion = @Descripcion, 
							Precio = @Precio, 
							IdCategoria = B.IdCategoria				
	FROM Productos AS A 
	LEFT JOIN CategoriasProductos AS B ON B.Categoria = @Categoria
	WHERE Producto = @Producto
END





--Informacion de Tabla
SELECT * FROM dbo.Clientes
SELECT * FROM dbo.CategoriasProductos	order by categoria
SELECT * FROM dbo.Productos	
SELECT * FROM dbo.Usuarios

--Datos Finales
select * from Clientes
select *from Factura
select *from Compra
select *from Productos
select *from v_Compra




/***************************************/
/***************************************/
/***************************************/

insert into Clientes (Cedula, Nombre, Apellido, Telefono, Direccion, Email)
select '0-0000-0000', '','','','',''
	
insert into Usuarios (Usuario, Clave, Rol, Nombre)
select 'Administrador', 12345, 'Administrador', 'Administrador Sistema'

insert into Usuarios (Usuario, Clave, Rol, Nombre)
select 'eredondom', 6531, 'Vendedor', 'Erick Redondo'

insert into Usuarios (Usuario, Clave, Rol, Nombre)
select 'ana', 1234 , 'Vendedor', 'Ana DeArendel'

select * from Usuarios where Usuario = '' AND Clave = 'Cafeteria'
select * from Usuarios where Usuario = ' Usuario1 ' and Clave = 'cafeteria'"
