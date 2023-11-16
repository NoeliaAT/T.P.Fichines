DELIMITER ;
USE T.P.Fichines;
SELECT 'Preparando para Inserts' AS 'Estado';
SET FOREIGN_KEY_CHECKS=0;
	TRUNCATE TABLE Fichin;
	TRUNCATE TABLE Cliente;
	TRUNCATE TABLE Tarjeta;
	TRUNCATE TABLE Recarga;
	TRUNCATE TABLE JuegaFichin;
SET FOREIGN_KEY_CHECKS=1;

SELECT 'Rellenando T.P.Fichines' AS 'Estado';

 // hacer alta cliente y traer cliente//