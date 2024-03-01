drop database if exists 5to_Fichines;
create database 5to_Fichines;
use 5to_Fichines;
SELECT 'Creando Tablas' AS 'Estado';
create table Fichin(
	idFichin INT not null auto_increment,
	nombre Varchar(45),
	lanzamiento INT,
	precio DECIMAL(7,2),
	CONSTRAINT PK_Fichin PRIMARY KEY (idFichin)
);
create table Cliente(
	Dni INT UNSIGNED,
	nombre Varchar(45),
	apellido Varchar(45),
	Mail Varchar(45),
	tarjeta INT,
	pass CHAR(64) NOT NULL,
	CONSTRAINT PK_Cliente PRIMARY KEY (DNI)
);
create table Tarjeta(
	idTarjeta INT not null auto_increment,
	Dni INT UNSIGNED,
	Saldo DECIMAL(7,2),
	CONSTRAINT PK_Tarjeta PRIMARY KEY (idTarjeta)
);
create table Recarga(
	idRecarga INT not null auto_increment,
	Dni INT UNSIGNED,
	idTarjeta INT NOT NULL,
	FechayHora DATETIME,
	MontoRecargado DECIMAL(7,2),
	CONSTRAINT PK_Recarga PRIMARY KEY(idRecarga),
	CONSTRAINT FK_Recarga_Cliente FOREIGN KEY(DNI)
	REFERENCES Cliente (DNI),
	CONSTRAINT FK_Recarga_Tarjeta FOREIGN KEY(idTarjeta)
	REFERENCES Tarjeta (idTarjeta)
);
create table JuegaFichin(
	idJuegaFichin INT not null auto_increment,
	DNI INT UNSIGNED,
	idTarjeta INT not null,
	idFichin INT not null,
	FechayHora DATETIME,
	Gasto DECIMAL(7,2),
	CONSTRAINT PK_JuegaFichin PRIMARY KEY (idJuegaFichin),
	CONSTRAINT FK_JuegaFichin_Cliente FOREIGN KEY (DNI)
	REFERENCES Cliente (DNI),
	CONSTRAINT FK_JuegaFichin_Tarjeta FOREIGN KEY (idTarjeta)
	REFERENCES Tarjeta (idTarjeta),
	CONSTRAINT FK_JuegaFichin_Fichin FOREIGN KEY (idFichin)
	REFERENCES Fichin (idFichin)
);

