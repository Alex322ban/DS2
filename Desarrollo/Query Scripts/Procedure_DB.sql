--REGISTRAR CLIENTE
--======================================================
CREATE PROCEDURE P0001  
@NOMB VARCHAR(30),
@APE VARCHAR(30),
@DNI VARCHAR(7)
AS
BEGIN
INSERT INTO CLIENTE VALUES(@NOMB,@APE,@DNI)
END

--ACTUALIZAR CLIENTE
--======================================================
CREATE PROCEDURE P0002
@IDC INT,
@NOMB VARCHAR(30),
@APE VARCHAR(30),
@DNI VARCHAR(7)
AS
BEGIN
UPDATE CLIENTE
SET Nomb=@NOMB, Ape=@APE, DNI=@DNI
WHERE IDC= @IDC
END

--ELIMINAR CLIENTE
--======================================================
CREATE PROCEDURE P0003
@DNI VARCHAR(7)
AS 
BEGIN
DELETE 
FROM CLIENTE 
WHERE DNI =@DNI
END

--REGISTRAR EN GARAJE
--======================================================
CREATE PROCEDURE P0004
@SLOT INT,
@PLACA VARCHAR(7),
@DNI VARCHAR(7)
AS
BEGIN
UPDATE GARAJE
SET PLACA=@PLACA, DNI=@DNI, DISPO=1
WHERE SLOT=@SLOT
END

--LIBERAR EN GARAJE
--======================================================
CREATE PROCEDURE P0005
@SLOT INT
AS
BEGIN
UPDATE GARAJE
SET PLACA='', DNI='', DISPO=0
WHERE SLOT=@SLOT
END

--ASIGNAR HABITACI�N
--======================================================
CREATE PROCEDURE P0006
@IDH INT,
@IDC INT
AS
BEGIN
UPDATE HABITACION
SET ESTADO=1, IDC=@IDC
WHERE IDH = @IDH
END
select * from HABITACION
select * from CLIENTE
P0006 '5001', 25 


SELECT *
FROM HABITACION
--DESASIGNAR HABITACI�N
--======================================================
ALTER PROCEDURE P0007
@IDH INT
AS 
BEGIN
	UPDATE HABITACION
		SET ESTADO=2, IDC=1
		WHERE IDH=@IDH
END
SELECT *
FROM HABITACION
--HABILITAR HABITACI�N
--======================================================
CREATE PROCEDURE P0008
@IDH INT
AS
BEGIN
UPDATE HABITACION
SET ESTADO=0
WHERE IDH = @IDH
END

--PAGO CLIENTE
--======================================================
CREATE PROCEDURE PC001
@DNI INT,
@FECHA VARCHAR(8),
@MONTO VARCHAR(7),
@IGV VARCHAR(7)
AS
BEGIN
INSERT INTO BOLETA VALUES(@DNI,@FECHA,@MONTO,@IGV)
END

--LISTAR CLIENTES
--======================================================
ALTER PROCEDURE P0009
AS
BEGIN
SELECT IDC , Nomb AS 'Nombre', Ape AS 'Apellido', DNI 
	FROM CLIENTE
	WHERE NOT DNI = 1
END
--LISTAR HABITACIONES
--======================================================
alter PROCEDURE P0010
AS
BEGIN 
	SELECT idh as 'Cod',DESCRIPCION AS 'Descripci�n', num AS 'Cuarto', Nomb AS 'Nombres', Ape AS 'Apellidos' 
		FROM HABITACION
		INNER JOIN CLIENTE ON (HABITACION.IDC=CLIENTE.IDC)
		INNER JOIN ESTADOH ON (HABITACION.ESTADO = ESTADOH.ESTADO)
		WHERE (DESCRIPCION='Limpieza') OR (DESCRIPCION='En uso')
END
--LISTAR HABITACIONES DISPONIBLES 
--======================================================
CREATE PROCEDURE P0013
AS
BEGIN
SELECT IDH, NUM AS 'N�mero',DESCRIPCION 
	FROM HABITACION
	INNER JOIN ESTADOH ON (HABITACION.ESTADO= ESTADOH.ESTADO)
	WHERE (DESCRIPCION='Disponible') AND (NOT IDH =1)
END
--LISTAR HABITACIONES NO DISPONIBLES 
--======================================================
CREATE PROCEDURE P0014
AS
BEGIN
SELECT IDH, NUM AS 'N�mero',DESCRIPCION 
	FROM HABITACION
	INNER JOIN ESTADOH ON (HABITACION.ESTADO= ESTADOH.ESTADO)
	WHERE (DESCRIPCION='En uso ') AND (NOT IDH =1)
END

--LISTAR GARAJE 
--======================================================
CREATE PROCEDURE P0011
AS 
BEGIN 
	SELECT SLOT AS 'N�mero', PLACA AS 'Placa', DNI, DESCRIPCION AS 'Descripci�n'
	FROM GARAJE
	INNER JOIN ESTADOG ON (GARAJE.DISPO = ESTADOG.DISPO)
END

--LISTAR INVENTARIO 
--======================================================
CREATE PROCEDURE P0012
AS
BEGIN
SELECT IDI AS 'ID', TIPO, NUM AS 'CUARTO', DESCRIPCION AS 'DESCRIPCI�N'
	FROM INVENTARIO
	INNER JOIN HABITACION ON (INVENTARIO.IDH = HABITACION.IDH)
	INNER JOIN ESTADOI ON (INVENTARIO.ESTADO = ESTADOI.ESTADO)
END

SELECT *
FROM USUARIO


ALTER PROCEDURE SESION
@USR varchar(30),
@PASS varchar(30)
AS 
BEGIN
SELECT *
FROM USUARIO
WHERE USR=@USR AND pass=@PASS
END

SESION 'fchoquecota','123456'