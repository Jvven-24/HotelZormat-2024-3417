CREATE DATABASE HotelZormatDB;
GO
USE HotelZormatDB;
GO

CREATE TABLE Usuarios (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NombreUsuario VARCHAR(50) NOT NULL UNIQUE,
    Contrasena VARCHAR(64) NOT NULL,        
    NombreCompleto NVARCHAR(100) NOT NULL,
    Rol VARCHAR(20) NOT NULL,                 -- 'Administrador' | 'Recepcionista'
    Activo BIT NOT NULL DEFAULT 1
);


CREATE TABLE Habitaciones (
    Numero INT PRIMARY KEY,
    Tipo VARCHAR(20) NOT NULL,                -- 'Sencilla' | 'Doble' | 'Suite'
    Piso INT NOT NULL,
    Estado VARCHAR(20) NOT NULL,              -- 'Disponible' | 'Ocupada' | 'Reservada' | 'Limpieza'
    Capacidad INT NOT NULL,
    TarifaBase DECIMAL(10,2) NOT NULL
);

CREATE TABLE Huespedes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    TipoDocumento VARCHAR(10) NOT NULL,       -- 'Cedula' | 'Pasaporte'
    NumeroDocumento VARCHAR(20) NOT NULL,     -- cédula: exactamente 11 dígitos (valida Negocio)
    Nacionalidad NVARCHAR(50) NOT NULL,
    Telefono VARCHAR(15) NULL,
    Email VARCHAR(100) NULL,
    FechaRegistro DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE Reservas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    HuespedId INT NOT NULL FOREIGN KEY REFERENCES Huespedes(Id),
    HabitacionNumero INT NOT NULL FOREIGN KEY REFERENCES Habitaciones(Numero),
    FechaCheckIn DATETIME NOT NULL,
    FechaCheckOut DATETIME NOT NULL,
    Temporada VARCHAR(10) NOT NULL,           -- 'Alta' | 'Media' | 'Baja'
    Estado VARCHAR(20) NOT NULL,              -- 'Pendiente' | 'Confirmada' | 'Cancelada'
    TotalNoches INT NOT NULL,
    MontoEstimado DECIMAL(10,2) NOT NULL,
    FechaCreacion DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE Estadias (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ReservaId INT NOT NULL FOREIGN KEY REFERENCES Reservas(Id),
    FechaCheckInReal DATETIME NOT NULL,
    FechaCheckOutReal DATETIME NULL,          -- NULL mientras la estadía está activa
    Estado VARCHAR(10) NOT NULL               -- 'Activa' | 'Cerrada'
);

CREATE TABLE Facturas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NCF VARCHAR(11) NOT NULL UNIQUE,          -- 'B02' + 8 dígitos secuenciales (Consumo Final)
    EstadiaId INT NOT NULL FOREIGN KEY REFERENCES Estadias(Id),
    Subtotal DECIMAL(10,2) NOT NULL,
    Itbis DECIMAL(10,2) NOT NULL,             -- 18%
    Propina DECIMAL(10,2) NOT NULL,           -- 10%
    Total DECIMAL(10,2) NOT NULL,
    FechaEmision DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE SecuenciaNCF (
    Tipo VARCHAR(3) PRIMARY KEY,              -- 'B02'
    UltimoNumero INT NOT NULL
);

CREATE TABLE Bitacora (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UsuarioId INT NOT NULL FOREIGN KEY REFERENCES Usuarios(Id),
    Accion VARCHAR(50) NOT NULL,              -- 'Login' | 'CheckIn' | 'CheckOut' | 'Facturacion' ...
    Detalle NVARCHAR(200) NULL,
    FechaHora DATETIME NOT NULL DEFAULT GETDATE()
);

-- Usuarios (contraseña en texto plano — suficiente para el nivel del curso)
INSERT INTO Usuarios (NombreUsuario, Contrasena, NombreCompleto, Rol) VALUES
 ('admin',     'Admin123', N'Administrador General',    'Administrador'),
 ('recepcion', 'Recep123', N'Recepcionista Principal',  'Recepcionista');

-- Las 9 habitaciones del Día 09 + TarifaBase
INSERT INTO Habitaciones (Numero, Tipo, Piso, Estado, Capacidad, TarifaBase) VALUES
 (101, 'Sencilla', 1, 'Disponible', 1, 2000.00),
 (102, 'Sencilla', 1, 'Ocupada',    1, 2000.00),
 (201, 'Doble',    2, 'Disponible', 2, 3200.00),
 (202, 'Doble',    2, 'Reservada',  2, 3200.00),
 (301, 'Sencilla', 3, 'Disponible', 1, 2000.00),
 (302, 'Doble',    3, 'Limpieza',   2, 3200.00),
 (305, 'Suite',    3, 'Ocupada',    4, 4500.00),
 (306, 'Suite',    3, 'Disponible', 4, 4500.00),
 (401, 'Suite',    4, 'Reservada',  4, 4500.00);

-- Huéspedes de prueba (1 dominicano con cédula de 11, 1 turista con pasaporte)
INSERT INTO Huespedes (Nombre, Apellido, TipoDocumento, NumeroDocumento, Nacionalidad, Telefono, Email) VALUES
 (N'Pedro', N'Martínez', 'Cedula',    '00112345678', N'Dominicana',      '809-555-0101', 'pedro@mail.com'),
 (N'John',  N'Smith',    'Pasaporte', 'P1234567',    N'Estadounidense',  NULL,           'john@mail.com');

-- Arranque de la secuencia NCF
INSERT INTO SecuenciaNCF (Tipo, UltimoNumero) VALUES ('B02', 0);

select * from Bitacora

