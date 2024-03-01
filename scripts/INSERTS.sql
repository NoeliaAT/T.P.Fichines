DELIMITER ;
USE 5to_Fichines;
SELECT 'Preparando para Insertss' AS 'Estado';
SET FOREIGN_KEY_CHECKS=0;
	TRUNCATE TABLE Fichin;
	TRUNCATE TABLE Cliente;
	TRUNCATE TABLE Tarjeta;
	TRUNCATE TABLE Recarga;
	TRUNCATE TABLE JuegaFichin;
SET FOREIGN_KEY_CHECKS=1;

SELECT 'Rellenando T.P.Fichines' AS 'Estado';

START TRANSACTION;

	CALL altaFichin(1, "Suggar", 2000, 30.50);
	CALL registrarCliente(54321, "Noelia", "Almaraz", "Noe@gmail", 54321, 256);
	CALL altaTarjeta(321, 54321, 50.0);
	CALL altaRecarga(11, 54321, 321, '2023-11-21 16:32:04', 31.00);
	CALL altaJuegaFichin(5, 54321, 321, 1, '2023-11-21 16:40:08', 30.50);
COMMIT;
