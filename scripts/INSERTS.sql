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
	CALL altaTarjeta(321, 5.0);
	CALL altaRecarga(@idRecarga, @DniNoelia, 321, '2023-11-21 16:32:04', 31.00);
	CALL altaJuegaFichin(@idJuegaFichin, @DniNoelia, 321, 1, '2023-11-21 16:40:08', 30.50);
	CALL registrarCliente(@DniNoelia, "Noelia", "Almaraz", "Noe@gmail", 54321, 256);
COMMIT;
