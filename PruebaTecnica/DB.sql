CREATE TABLE Declaraciones (
    Id INT PRIMARY KEY IDENTITY(1,1),
    NumeroTransaccion BIGINT,
    FechaHoraTrn DATETIME,
    FechaAConsultar DATE,
    CuentaDeclaraciones INT,
    DatosComprimidos NVARCHAR(MAX)  -- Guardar datos en base64
);

CREATE TABLE Articulos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    DeclaracionId INT FOREIGN KEY REFERENCES Declaraciones(Id),
    ArticuloData NVARCHAR(MAX)  -- Aquí se pueden almacenar datos JSON
);

CREATE TABLE Liquidaciones (
    Id INT PRIMARY KEY IDENTITY(1,1),
    DeclaracionId INT FOREIGN KEY REFERENCES Declaraciones(Id),
    LiquidacionData NVARCHAR(MAX)  -- Aquí se pueden almacenar datos JSON
);
