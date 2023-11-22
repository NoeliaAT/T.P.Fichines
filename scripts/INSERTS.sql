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

START TRANSACTION;



CALL altaFichin(001, "Suggar", 2000, 30.50);
CALL altaRecarga(12345, 2023-11-21 16:32:04, 49.70);
CALL altaJuegaFichin(12345, 001, 2023-11-21 16:40:08, 30.50);
CALL registrarCliente(12345, "Noelia", "Almaraz", "Noe@gmail", 54321, 50.30);



CALL recaudaciónPara 

CALL Gastos 





-- hacer alta cliente y traer cliente//
