DROP DATABASE DBMOANSO_PF 
CREATE DATABASE DBMOANSO_PF
USE DBMOANSO_PF


CREATE TABLE Area(
	idArea int identity(1,1) NOT NULL,
	nombre nvarchar(30) NOT NULL, 
	CONSTRAINT [PK_Area] PRIMARY KEY CLUSTERED 
	(
		[idArea] ASC 
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]


CREATE TABLE Cargos(
	idCargo int identity(1,1) NOT null, 
    nombre nvarchar(50) NOT NULL, 
    descripcion nvarchar(max) NULL, 
	fecRegCargo date NOT NULL,
	estCargo bit NOT NULL, 
	CONSTRAINT [PK_Cargo] PRIMARY KEY CLUSTERED
	(
		[idCargo] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]


CREATE TABLE TiposContratos (
    idTipoContrato int IDENTITY(1,1) NOT NULL,
    nombre nvarchar(30) NOT NULL, 
    descripcion nvarchar(max) NOT NULL, 
    salario decimal(10, 2) NOT NULL,
    CONSTRAINT [PK_TiposContratos] PRIMARY KEY CLUSTERED 
    (
		[idTipoContrato] ASC 
	) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]


CREATE TABLE TiposLicenciasEmpleados(
	idTipoLicencia int identity(1,1) NOT NULL, 
	nombre nvarchar(30) NOT NULL, 
	estPagada bit NOT NULL, 
	CONSTRAINT [PK_TiposLicenciasEmpleados] PRIMARY KEY CLUSTERED 
	(
		[idTipoLicencia] ASC 
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]



CREATE TABLE AsistenciasEmpleados (
    idAsistencia int identity(1,1) NOT NULL,
    fecRegAsistencia date NOT NULL,
    horaRegAsistencia nvarchar(20) NOT NULL,
    estAsistencia bit NOT NULL,
    tipoAsistencia nvarchar(10) NOT NULL, -- Columna para indicar el tipo de asistencia (ingreso o salida)
    CONSTRAINT [PK_Asistencia] PRIMARY KEY CLUSTERED (
        [idAsistencia] ASC
    ) WITH (
        PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
        ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON
    ) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE ContratosEmpleados(
	idContrato int identity (1,1) NOT NULL,
	fecInicioContrato date NOT NULL, 
	fecFinalContrato date NOT NULL, 
	horaReg nvarchar(20) NOT NULL, 
	estContrato bit NOT NULL, 
	CONSTRAINT [PK_ContratosEmpleados] PRIMARY KEY CLUSTERED
	(
		[idContrato] ASC 
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

CREATE TABLE LicenciasEmpleados(
	idLicencia int identity (1,1) NOT NULL, 
	fecInicioLicencia date NOT NULL, 
	fecFinalLicencia date NOT NULL, 
	horaReg nvarchar(20) NOT NULL, 
	estLicencia bit NOT NULL, 
	CONSTRAINT [PK_LicenciasEmpleados] PRIMARY KEY CLUSTERED 
	(
		[idLicencia] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]



CREATE TABLE Empleado(
	idEmpleado int identity(1,1) NOT null, 
	nombre nvarchar (50) NOT NULL, 
	sexo nvarchar (20) NOT NULL,
	correo nvarchar (40) NULL, 
	telefono nvarchar (30) NOT NULL, 
	estEmpleado bit NOT NULL, 
	CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED
	(
		[idEmpleado] ASC 
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]


ALTER TABLE Cargos
ADD idArea int NOT NULL,
CONSTRAINT [FK_Cargo_Area] FOREIGN KEY (idArea)
REFERENCES Area (idArea);


ALTER TABLE Empleado
ADD idCargo int NOT NULL,
CONSTRAINT [FK_Empleado_Cargos] FOREIGN KEY (idCargo)
REFERENCES Cargos (idCargo);


ALTER TABLE AsistenciasEmpleados
ADD idEmpleado int NOT NULL,
CONSTRAINT [FK_AsistenciasEmpleados_Empleado] FOREIGN KEY (idEmpleado)
REFERENCES Empleado (idEmpleado);


ALTER TABLE ContratosEmpleados
ADD idEmpleado int NOT NULL,
CONSTRAINT [FK_ContratosEmpleados_Empleado] FOREIGN KEY (idEmpleado)
REFERENCES Empleado (idEmpleado);


ALTER TABLE ContratosEmpleados
ADD idTipoContrato int NOT NULL,
CONSTRAINT [FK_ContratosEmpleados_TiposContratos] FOREIGN KEY (idTipoContrato)
REFERENCES TiposContratos (idTipoContrato);


ALTER TABLE LicenciasEmpleados
ADD idEmpleado int NOT NULL,
CONSTRAINT [FK_LicenciasEmpleados_Empleado] FOREIGN KEY (idEmpleado)
REFERENCES Empleado (idEmpleado);


ALTER TABLE LicenciasEmpleados
ADD idTipoLicencia int NOT NULL,
CONSTRAINT [FK_LicenciasEmpleados_TiposLicenciasEmpleados] FOREIGN KEY (idTipoLicencia)
REFERENCES TiposLicenciasEmpleados (idTipoLicencia);

--Procedimientos de almacenado de la tabbla área
CREATE PROCEDURE ListadoArea
	AS SELECT idArea, nombre
	FROM Area

--Procedimientos de almacenado de la tabla empleados
CREATE PROCEDURE InsertarEmpleado
(
    @nombre nvarchar(50),
    @sexo nvarchar(20),
    @correo nvarchar(40),
    @telefono nvarchar(30),
    @estEmpleado bit,
    @idCargo int
)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Empleado (nombre, sexo, correo, telefono, estEmpleado, idCargo)
    VALUES (@nombre, @sexo, @correo, @telefono, @estEmpleado, @idCargo);
END;



CREATE PROCEDURE EditarEmpleado
(
    @idEmpleado int,
    @nombre nvarchar(50),
    @sexo nvarchar(20),
    @correo nvarchar(40),
    @telefono nvarchar(30),
    @estEmpleado bit,
    @idCargo int
)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Empleado
    SET nombre = @nombre,
        sexo = @sexo,
        correo = @correo,
        telefono = @telefono,
        estEmpleado = @estEmpleado,
        idCargo = @idCargo
    WHERE idEmpleado = @idEmpleado;
END;

CREATE PROCEDURE ListadoEmpleado
	AS SELECT idEmpleado, nombre
	FROM Empleado

CREATE PROCEDURE DeshabilitaEmpleado
	(@idEmpleado int) 
	AS
	BEGIN
		UPDATE Empleado set
		estEmpleado = 0
		where idEmpleado = @idEmpleado
END

CREATE PROCEDURE ListadoEmpleados
	AS SELECT idEmpleado, nombre, sexo, correo, telefono, estEmpleado,idCargo
	FROM Empleado
	WHERE estEmpleado ='1' OR estEmpleado = '0'


--Procedimientos de almanceado de la tabla Cargos
CREATE PROCEDURE InsertarCargo
    @nombre nvarchar(50), 
    @descripcion nvarchar(max), 
    @fecRegCargo date,
    @estCargo bit,
	@idArea int
	
AS
BEGIN

    INSERT INTO Cargos (nombre, descripcion, fecRegCargo, estCargo,idArea)
    VALUES (@nombre, @descripcion, @fecRegCargo, @estCargo,@idArea);
END


CREATE PROCEDURE EditarCargo	
	@idCargo int,
    @nombre nvarchar(50),
    @descripcion nvarchar(max), 
	@fecRegCargo date, 
    @estCargo bit,
	@idArea int
AS
BEGIN
   
    UPDATE Cargos
    SET nombre = @nombre, descripcion = @descripcion, fecRegCargo = @fecRegCargo, estCargo = @estCargo, idArea = @idArea
	WHERE idCargo = @idCargo;
END


CREATE PROCEDURE DeshabilitaCargo
    (@idCargo int) 
	AS
	BEGIN
		UPDATE Cargos set
		estCargo = 0
		where idCargo = @idCargo
	END

CREATE PROCEDURE ListaCargo
	AS SELECT idCargo, nombre, descripcion, fecRegCargo, estCargo, idArea
	FROM Cargos
	WHERE estCargo ='1' OR estCargo = '0'

--Procedimientos de almacenado de la AsistenciasEmpleados

CREATE PROCEDURE InsertarAsistencia
    @idEmpleado INT,
    @fecRegAsistencia DATE,
    @horaRegAsistencia NVARCHAR(20),
    @estAsistencia BIT,
    @tipoAsistencia NVARCHAR(10)
AS
BEGIN
    INSERT INTO AsistenciasEmpleados (idEmpleado, fecRegAsistencia, horaRegAsistencia, estAsistencia, tipoAsistencia)
    VALUES (@idEmpleado, @fecRegAsistencia, @horaRegAsistencia, @estAsistencia, @tipoAsistencia)
END


CREATE PROCEDURE DeshabilitarAsistencia
    @idAsistencia int 
AS
BEGIN
    UPDATE AsistenciasEmpleados
    SET estAsistencia = 0 
    WHERE idAsistencia = @idAsistencia
END


--Procedimientos de almacenado de la tabla ContratosEmpleados
CREATE PROCEDURE InsertarContrato
	@fecInicioContrato date,
	@fecFinalContrato date,
	@horaReg nvarchar(20),
	@estContrato bit,
	@idEmpleado int,
	@idTipoContrato int
AS
BEGIN
	INSERT INTO ContratosEmpleados (fecInicioContrato, fecFinalContrato, horaReg, estContrato, idEmpleado, idTipoContrato)
	VALUES (@fecInicioContrato, @fecFinalContrato, @horaReg, @estContrato, @idEmpleado, @idTipoContrato);
END;	

CREATE PROCEDURE DeshabilitarContrato
    @idContrato int 
AS
BEGIN
    UPDATE ContratosEmpleados
    SET estContrato = 0 
    WHERE idContrato = @idContrato
END

--Procedimiento de almacenado de la tabla Licencias

CREATE PROCEDURE InsertarLicencia
    @fecInicioLicencia DATE,
    @fecFinalLicencia DATE,
    @horaReg NVARCHAR(20),
    @estLicencia BIT,
    @idEmpleado INT,
    @idTipoLicencia INT
AS
BEGIN
    INSERT INTO LicenciasEmpleados (fecInicioLicencia, fecFinalLicencia, horaReg, estLicencia, idEmpleado, idTipoLicencia)
    VALUES (@fecInicioLicencia, @fecFinalLicencia, @horaReg, @estLicencia, @idEmpleado, @idTipoLicencia);
END

CREATE PROCEDURE DeshabilitarLicencia
    @idLicencia int 
AS
BEGIN
    UPDATE LicenciasEmpleados
    SET estLicencia = 0 
    WHERE idLicencia = @idLicencia
END


--Procedimiento de almacenado de la tabla TipoLicencia
CREATE PROCEDURE InsertarTipoLicencia
    @nombre nvarchar(30), 
    @estPagada bit
AS
BEGIN
    INSERT INTO TiposLicenciasEmpleados (nombre, estPagada)
    VALUES (@nombre, @estPagada)
END


CREATE PROCEDURE EditarTipoLicencia
    @idTipoLicencia int,
    @nombre nvarchar(30),
    @estPagada bit 
AS
BEGIN
    UPDATE TiposLicenciasEmpleados
    SET nombre = @nombre, estPagada = @estPagada
    WHERE idTipoLicencia = @idTipoLicencia
END

CREATE PROCEDURE EliminarTipoLicencia
    @idTipoLicencia int 
AS
BEGIN
    DELETE FROM TiposLicenciasEmpleados
    WHERE idTipoLicencia = @idTipoLicencia
END

--Procedimiento de almacenado de la tabla TipoContrato
CREATE PROCEDURE InsertarTipoContrato
    @nombre nvarchar(30), 
    @descripcion nvarchar(max), 
    @salario decimal(10, 2) 
AS
BEGIN
    INSERT INTO TiposContratos (nombre, descripcion, salario)
    VALUES (@nombre, @descripcion, @salario)
END


CREATE PROCEDURE EditarTipoContrato
    @idTipoContrato int, 
    @nombre nvarchar(30), 
    @descripcion nvarchar(max), 
    @salario decimal(10, 2) 
AS
BEGIN
    UPDATE TiposContratos
    SET nombre = @nombre, descripcion = @descripcion, salario = @salario
    WHERE idTipoContrato = @idTipoContrato
END


CREATE PROCEDURE EliminarTipoContrato
    @idTipoContrato int 
AS
BEGIN
    DELETE FROM TiposContratos
    WHERE idTipoContrato = @idTipoContrato
END

CREATE PROCEDURE ListarTipoContratos
AS
BEGIN
    SELECT idTipoContrato, nombre, descripcion, salario
    FROM TiposContratos
END

--TipoLicencia

CREATE PROCEDURE ListarTipoLicencias
AS
BEGIN
    SELECT idTipoLicencia, nombre, estPagada
    FROM TiposLicenciasEmpleados;
END

CREATE PROCEDURE InsertarTipoLicencia
    @nombre VARCHAR(50),
    @estPagada BIT
AS
BEGIN
    INSERT INTO TiposLicenciasEmpleados (nombre, estPagada)
    VALUES (@nombre, @estPagada);
    SELECT SCOPE_IDENTITY();
END

CREATE PROCEDURE EditarTipoLicencia
    @idTipoLicencia INT,
    @nombre VARCHAR(50),
    @estPagada BIT
AS
BEGIN
    UPDATE TiposLicenciasEmpleados
    SET nombre = @nombre, estPagada = @estPagada
    WHERE idTipoLicencia = @idTipoLicencia;
END

CREATE PROCEDURE EliminarTipoLicencia
    @idTipoLicencia INT 
AS
BEGIN
    DELETE FROM TiposLicenciasEmpleados
    WHERE idTipoLicencia = @idTipoLicencia;
END

--Inserciones
INSERT INTO Area (nombre)
VALUES ('Área 1'),
       ('Área 2'),
       ('Área 3'),
       ('Área 4'),
       ('Área 5'),
       ('Área 6'),
       ('Área 7'),
       ('Área 8'),
       ('Área 9'),
       ('Área 10');
select * from Area

INSERT INTO Cargos (nombre, descripcion, fecRegCargo, estCargo, idArea)
VALUES ('Cargo 1', 'Descripción del Cargo 1', GETDATE(), 1, 1);
INSERT INTO Cargos (nombre, descripcion, fecRegCargo, estCargo, idArea)
VALUES ('Cargo 2', 'Descripción del Cargo 2', GETDATE(), 1, 2);
INSERT INTO Cargos (nombre, descripcion, fecRegCargo, estCargo, idArea)
VALUES ('Cargo 3', 'Descripción del Cargo 3', GETDATE(), 1, 3);
INSERT INTO Cargos (nombre, descripcion, fecRegCargo, estCargo, idArea)
VALUES ('Cargo 4', 'Descripción del Cargo 4', GETDATE(), 1, 4);
INSERT INTO Cargos (nombre, descripcion, fecRegCargo, estCargo, idArea)
VALUES ('Cargo 5', 'Descripción del Cargo 5', GETDATE(), 1, 5);
INSERT INTO Cargos (nombre, descripcion, fecRegCargo, estCargo, idArea)
VALUES ('Cargo 6', 'Descripción del Cargo 6', GETDATE(), 1, 6);
INSERT INTO Cargos (nombre, descripcion, fecRegCargo, estCargo, idArea)
VALUES ('Cargo 7', 'Descripción del Cargo 7', GETDATE(), 1, 7);
INSERT INTO Cargos (nombre, descripcion, fecRegCargo, estCargo, idArea)
VALUES ('Cargo 8', 'Descripción del Cargo 8', GETDATE(), 1, 8);
INSERT INTO Cargos (nombre, descripcion, fecRegCargo, estCargo, idArea)
VALUES ('Cargo 9', 'Descripción del Cargo 9', GETDATE(), 1, 9);
INSERT INTO Cargos (nombre, descripcion, fecRegCargo, estCargo, idArea)
VALUES ('Cargo 10', 'Descripción del Cargo 10', GETDATE(), 1, 10);
select * from Cargos

INSERT INTO Empleado (nombre, sexo, correo, telefono, estEmpleado, idCargo)
VALUES ('Juan Perez', 'Masculino', 'juan@example.com', '123456789', 1, 1);
INSERT INTO Empleado (nombre, sexo, correo, telefono, estEmpleado, idCargo)
VALUES ('María González', 'Femenino', 'maria@example.com', '987654321', 1, 2);
INSERT INTO Empleado (nombre, sexo, correo, telefono, estEmpleado, idCargo)
VALUES ('Carlos Ramirez', 'Masculino', 'carlos@example.com', '555555555', 1, 3);
INSERT INTO Empleado (nombre, sexo, correo, telefono, estEmpleado, idCargo)
VALUES ('Ana Torres', 'Femenino', 'ana@example.com', '111111111', 1, 4);
INSERT INTO Empleado (nombre, sexo, correo, telefono, estEmpleado, idCargo)
VALUES ('Luisa Mendez', 'Femenino', 'luisa@example.com', '999999999', 1, 5);
INSERT INTO Empleado (nombre, sexo, correo, telefono, estEmpleado, idCargo)
VALUES ('Pedro Sanchez', 'Masculino', 'pedro@example.com', '777777777', 1, 6);
INSERT INTO Empleado (nombre, sexo, correo, telefono, estEmpleado, idCargo)
VALUES ('Laura Vargas', 'Femenino', 'laura@example.com', '222222222', 1, 7);
INSERT INTO Empleado (nombre, sexo, correo, telefono, estEmpleado, idCargo)
VALUES ('Javier Cruz', 'Masculino', 'javier@example.com', '888888888', 1, 8);
INSERT INTO Empleado (nombre, sexo, correo, telefono, estEmpleado, idCargo)
VALUES ('Sofia Fernández', 'Femenino', 'sofia@example.com', '333333333', 1, 9);
INSERT INTO Empleado (nombre, sexo, correo, telefono, estEmpleado, idCargo)
VALUES ('Eduardo Gómez', 'Masculino', 'eduardo@example.com', '666666666', 1, 10);
select * from Empleado


INSERT INTO AsistenciasEmpleados (idEmpleado, fecRegAsistencia, horaRegAsistencia, estAsistencia, tipoAsistencia)
VALUES (1, '2023-06-30', '09:00 AM', 1, 'Ingreso'),
       (1, '2023-06-30', '06:00 PM', 1, 'Salida'),
       (2, '2023-06-30', '08:30 AM', 1, 'Ingreso'),
       (2, '2023-06-30', '05:30 PM', 1, 'Salida'),
       (3, '2023-06-30', '09:15 AM', 1, 'Ingreso'),
       (3, '2023-06-30', '05:45 PM', 1, 'Salida'),
       (4, '2023-06-30', '08:45 AM', 1, 'Ingreso'),
       (4, '2023-06-30', '06:15 PM', 1, 'Salida'),
       (5, '2023-06-30', '09:30 AM', 1, 'Ingreso'),
       (5, '2023-06-30', '06:30 PM', 1, 'Salida')
select * from AsistenciasEmpleados

--Falta
INSERT INTO TiposContratos (nombre, descripcion, salario)
VALUES ('Tipo Contrato 1', 'Descripción Tipo Contrato 1', 1000),
       ('Tipo Contrato 2', 'Descripción Tipo Contrato 2', 2000),
       ('Tipo Contrato 3', 'Descripción Tipo Contrato 3', 3000),
       ('Tipo Contrato 4', 'Descripción Tipo Contrato 4', 4000),
       ('Tipo Contrato 5', 'Descripción Tipo Contrato 5', 5000),
       ('Tipo Contrato 6', 'Descripción Tipo Contrato 6', 6000),
       ('Tipo Contrato 7', 'Descripción Tipo Contrato 7', 7000),
       ('Tipo Contrato 8', 'Descripción Tipo Contrato 8', 8000),
       ('Tipo Contrato 9', 'Descripción Tipo Contrato 9', 9000),
       ('Tipo Contrato 10', 'Descripción Tipo Contrato 10', 10000);
select * from TiposContratos


INSERT INTO TiposLicenciasEmpleados (nombre, estPagada)
VALUES ('Licencia 1', 1),
       ('Licencia 2', 0),
       ('Licencia 3', 1),
       ('Licencia 4', 0),
       ('Licencia 5', 1),
       ('Licencia 6', 0),
       ('Licencia 7', 1),
       ('Licencia 8', 0),
       ('Licencia 9', 1),
       ('Licencia 10', 0);
select * from TiposLicenciasEmpleados


INSERT INTO ContratosEmpleados (fecInicioContrato, fecFinalContrato, horaReg, estContrato, idEmpleado, idTipoContrato)
VALUES (GETDATE(), '2023-12-31', '09:00 AM', 1, 1, 1);
INSERT INTO ContratosEmpleados (fecInicioContrato, fecFinalContrato, horaReg, estContrato, idEmpleado, idTipoContrato)
VALUES (GETDATE(), '2023-12-31', '10:00 AM', 1, 2, 2);
INSERT INTO ContratosEmpleados (fecInicioContrato, fecFinalContrato, horaReg, estContrato, idEmpleado, idTipoContrato)
VALUES (GETDATE(), '2023-12-31', '11:00 AM', 1, 3, 3);
INSERT INTO ContratosEmpleados (fecInicioContrato, fecFinalContrato, horaReg, estContrato, idEmpleado, idTipoContrato)
VALUES (GETDATE(), '2023-12-31', '01:00 PM', 1, 4, 4);
INSERT INTO ContratosEmpleados (fecInicioContrato, fecFinalContrato, horaReg, estContrato, idEmpleado, idTipoContrato)
VALUES (GETDATE(), '2023-12-31', '02:00 PM', 1, 5, 5);
INSERT INTO ContratosEmpleados (fecInicioContrato, fecFinalContrato, horaReg, estContrato, idEmpleado, idTipoContrato)
VALUES (GETDATE(), '2023-12-31', '03:00 PM', 1, 6, 6);
INSERT INTO ContratosEmpleados (fecInicioContrato, fecFinalContrato, horaReg, estContrato, idEmpleado, idTipoContrato)
VALUES (GETDATE(), '2023-12-31', '04:00 PM', 1, 7, 7);
INSERT INTO ContratosEmpleados (fecInicioContrato, fecFinalContrato, horaReg, estContrato, idEmpleado, idTipoContrato)
VALUES (GETDATE(), '2023-12-31', '05:00 PM', 1, 8, 8);
INSERT INTO ContratosEmpleados (fecInicioContrato, fecFinalContrato, horaReg, estContrato, idEmpleado, idTipoContrato)
VALUES (GETDATE(), '2023-12-31', '06:00 PM', 1, 9, 9);
INSERT INTO ContratosEmpleados (fecInicioContrato, fecFinalContrato, horaReg, estContrato, idEmpleado, idTipoContrato)
VALUES (GETDATE(), '2023-12-31', '07:00 PM', 1, 10, 10);
select * from ContratosEmpleados


INSERT INTO LicenciasEmpleados (fecInicioLicencia, fecFinalLicencia, horaReg, estLicencia, idEmpleado,idTipoLicencia)
VALUES (GETDATE(), GETDATE(), '09:00', 1, 1, 3),
       (GETDATE(), GETDATE(), '14:00', 1, 2, 4),
       (GETDATE(), GETDATE(), '18:00', 1, 3, 5),
       (GETDATE(), GETDATE(), '09:00', 1, 4, 6),
       (GETDATE(), GETDATE(), '14:00', 1, 5, 7)
select * from LicenciasEmpleados


	
