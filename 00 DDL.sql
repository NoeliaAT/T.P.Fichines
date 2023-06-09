drop database if exists 5to_Fichines;
create database 5to_Fichines;
use 5to_Fichines;
create table Fichin(
	idFichin INT not null auto_increment,
	nombre Varchar(45),
	lanzamiento INT,
	precio DECIMAL(7,2),
	primary key (idFichin)
);
create table Cliente(
	DNI INT not null,
	nombre Varchar(45),
	apellido Varchar(45),
	Mail Varchar(45),
	tarjeta INT,
	primary key (DNI)
);
create table Tarjeta(
	idTarjeta INT not null auto_increment,
	Saldo DECIMAL(7,2),
	primary key (idTarjeta)
);
create table Recarga(
	idRecarga INT not null auto_increment,
	DNI INT,
	idTarjeta INT NOT NULL,
	FechayHora DATETIME,
	MontoRecargado INT,
	primary key (idRecarga),
	foreign key (DNI) references Cliente (DNI),
	foreign key (idTarjeta) references Tarjeta (idTarjeta)
);
create table JuegaFichin(
	idJuegaFichin INT not null auto_increment,
	DNI INT not null,
	idTarjeta INT not null,
	idFichin INT not null,
	FechayHora DATETIME,
	Gasto DECIMAL(7,2),
	primary key (idJuegaFichin),
	foreign key (DNI) references Cliente(DNI),
	foreign key (idTarjeta) references Tarjeta (idTarjeta),
	foreign key (idFichin) references Fichin (idFichin)
);

