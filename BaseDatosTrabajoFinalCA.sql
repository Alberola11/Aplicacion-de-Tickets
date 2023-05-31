create database TrabajoFinalCA;
use TrabajoFinalCA;
create table tickets(
    id int auto_increment primary key,
    fecha datetime not null,
    identificador varchar(50) not null ,
    concepto varchar(50) not null ,
    nombre varchar(50) not null ,
    importeTotal float(10,2) not null ,
    direccion varchar(50) not null ,
    ente varchar(50) not null
);


