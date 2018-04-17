CREATE DATABASE DB_HOTEL
USE DB_HOTEL
DROP TABLE USUARIO
CREATE TABLE USUARIO
(IDU INT PRIMARY KEY,
 USR VARCHAR(20),
 Nomb VARCHAR(30),
 Ape VARCHAR(30),
 pass VARCHAR(30),
 cate INT
)
CREATE TABLE CATEGORIA
(cate INT PRIMARY KEY,
 descripcion VARCHAR(20)
)
CREATE TABLE CLIENTE
(IDC INT PRIMARY KEY,
 Nomb VARCHAR(30),			
 Ape VARCHAR(30),
 DNI VARCHAR(7),
)
CREATE TABLE GARAJE
(SLOT INT PRIMARY KEY,
 PLACA VARCHAR(7),
 DNI VARCHAR(7),
 DISPO INT
)
CREATE TABLE ESTADOG
(DISPO INT,
 DESCRIPCION VARCHAR(15)
)
CREATE TABLE HABITACION
(IDH INT PRIMARY KEY,
 NUM VARCHAR(4),
 ESTADO VARCHAR(1),
 IDC INT FOREIGN KEY REFERENCES CLIENTE(IDC)
)
CREATE TABLE ESTADOH
(ESTADO VARCHAR(1),
 DESCRIPCION VARCHAR(10)
)
CREATE TABLE INVENTARIO
(IDI INT PRIMARY KEY,
 TIPO VARCHAR(20),
 IDH INT FOREIGN KEY REFERENCES HABITACION(IDH),
 ESTADO VARCHAR(1)
)
CREATE TABLE ESTADOI
(ESTADO VARCHAR(1),
 DESCRIPCION VARCHAR(10)
)
CREATE TABLE BOLETA
(ID INT PRIMARY KEY,
 IDC INT FOREIGN KEY REFERENCES CLIENTE(IDC),
 FECHA VARCHAR(8),
 MONTO VARCHAR(7),
 IGV VARCHAR(7),
)
