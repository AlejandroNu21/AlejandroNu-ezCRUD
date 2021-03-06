create database sistema_ventas;
use sistema_ventas;

create table tb_usuario(
iDUsuario int primary key identity(1,1),
email varchar (50),
contrasena varchar(100)
);

Create table tb_venta(
iDVenta int primary Key identity(1,1),
iDDocumento int,
iDCliente int,
iDUsuario int,
iDProducto int,
totalVenta decimal,
fecha Date

);


create table tb_documento(
iDDocumento int primary key identity (1,1),
nombreDocumento varchar (50)
);

create table tb_cliente (
iDCliente int primary key identity(1,1),
nombreCliente varchar (50),
direccionCliente varchar(50),
duiCliente varchar(50)
);


create table tb_detalleVenta(
iDDetalleVenta int primary key identity(1,1),
idVenta int,
idProducto int,
cantidad int,
precio Decimal(12,5),
total Decimal
);

create table tb_producto(
idProducto int primary key identity (1,1),
nombreProducto varchar(50),
precioProducto varchar (50),
estadoProducto varchar (50)
);

use sistema_ventas;
alter table tb_detalleventa alter column precio decimal(18,5)
alter table tb_detalleventa alter column total decimal(18,5)

alter table tb_venta alter column totalventa decimal(18,5)

--CRUD

--Create

Insert into tb_cliente  (nombreCliente,direccionCliente,duiCliente) values ('Carlos','Ciudad Totolco','45679038')
Insert into tb_cliente  (nombreCliente,direccionCliente,duiCliente) values ('Khaterin','Ciudad Totolco','367292020')
Insert into tb_cliente  (nombreCliente,direccionCliente,duiCliente) values ('Jessica','Chalate','43628228838')

--READ

Select * from tb_cliente

--Update
update tb_cliente set duiCliente = 4569020460 Where iDCliente = 1002


--Create

Insert into tb_usuario(email,contrasena) values ('Alejandro21@unab.edu','1234')
Insert into tb_usuario(email,contrasena) values ('Carlos21@unab.edu','1234')

--READ

Select * from tb_usuario

--Update
update tb_usuario set contrasena = 2021 Where iDUsuario = 1002


--Create

Insert into tb_documento(nombreDocumento) values ('Documento1')
Insert into tb_documento  (nombreDocumento) values ('Documento2')

--READ
Select * from tb_documento

--Update
update tb_documento set nombreDocumento = 'Documento Nuevo' Where iDDocumento = 2



---Create
Insert into tb_producto  (nombreProducto,precioProducto,estadoProducto) values ('Laptop','500','Nuevo')
Insert into tb_producto  (nombreProducto,precioProducto,estadoProducto) values ('Mouse','10','Nuevo')

--READ
Select * from tb_producto

--Update
update tb_producto set precioProducto = 850 Where idProducto = 1003
