--create database examen_Jose_Antonio_Estrada_Reyes


create table t_clientes(

idCliente int identity(1,1) primary key,
Nombre varchar(50),
Domicilio varchar(100),
email varchar(50)

)


create table  t_facturas(

idFactura int identity(1,1) primary key,
NumeroFactura varchar(10),
FechaHora datetime,
idCliente int foreign key references t_clientes(idCliente)

)
create table t_productos(

idProducto int identity(1,1) primary key,
Nombre varchar(50),
Marca varchar(50),
Costo numeric(5,2),
PrecioVenta numeric(5,2)
)

create table t_detalleFactura(

idDetalle int identity(1,1) primary key,
idFactura int foreign key references t_facturas(idFactura),
idProducto int foreign key references  t_productos(idProducto),
Cantidad int

)


