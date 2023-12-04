-- 1) Realizar los SP para dar de alta todas las entidades menos la tabla Cliente.--

DELIMITER $$
USE 5to_Fichines $$
DROP PROCEDURE IF EXISTS altaFichin $$
CREATE PROCEDURE altaFichin (unidFichin INT,
							unNombre VARCHAR(45),
							unLanzamiento INT,
							unPrecio DECIMAL(7,2))
BEGIN
	INSERT INTO Fichin (idFichin, Nombre, lanzamiento, precio)
				VALUES (unIdFichin, unnombre, unlanzamiento, unPrecio);
END $$

DELIMITER $$
DROP PROCEDURE IF EXISTS altaRecarga $$
CREATE PROCEDURE altaRecarga	(unDNI INT,
								unaFechayHora DATETIME,
								unMontoRecargado INT)
BEGIN
	INSERT INTO Recarga (DNI, FechayHora, MontoRecargado)
				VALUES (unDNI, unaFechayHora, unMontoRecargado);
END $$

DELIMITER $$
DROP PROCEDURE IF EXISTS altaJuegaFichin $$
CREATE PROCEDURE altaJuegaFichin (unDNI INT,
								unidFichin INT,
								unFechayHora DATETIME,
								unGasto DECIMAL(7,2))
BEGIN
	INSERT INTO JuegaFichin (DNI, idFichin, FechayHora, Gasto)
					VALUES (unDNI, unidFichin, unFechayHora, unGasto);
END $$


-- 2) Se pide hacer el SP ‘registrarCliente’ que reciba los datos del cliente. Es importante guardar encriptada la contraseña del cliente usando SHA256.--

DELIMITER $$
DROP PROCEDURE IF EXISTS registraCliente $$
CREATE PROCEDURE registrarCliente (unDNI INT,
									unnombre VARCHAR(45),
									unapellido VARCHAR(45),
									unMail VARCHAR(45),
									unatarjeta INT,
									unsaldo DECIMAL(7,2))
BEGIN
	INSERT INTO Cliente(DNI, nombre, apellido, Mail, tarjeta, saldo)
				VALUES ( unDNI, unnombre, unapellido, unMail, untarjeta, unsaldo, unpassword);
	SELECT SHA2('password', 256);
END $$


-- 3) Se pide hacer el SP ‘clientePorDniPass’ que reciba un dni y contraseña (no encriptada), el SP tiene que devolver la fila correspondiente al cliente en caso de que concuerden dni y pass con los datos almacenados en la BD, caso contrario devuelve NULL.--

-- Ya no existe.

-- 4) Se pide hacer el SF ‘RecaudacionPara’ que reciba por parámetro un identificador de fichin, se debe devolver la ganancia que tuvo entre esas 2 fechas (inclusive).--

DELIMITER $$
DROP FUNCTION IF EXISTS recaudaciónPara $$
CREATE FUNCTION recaudaciónPara (unidFichin INT, fechaInicio DATE, fechaFin DATE)
	RETURNS INT READS SQL DATA
BEGIN
	DECLARE Recaudación INT ;
	SELECT SUM(Gasto) INTO Recaudación
	FROM JuegaFichin
	WHERE idFichin = idFichin
	AND FechayHora BETWEEN fechaInicio AND fechaFin;
    
    IF Recaudación IS NULL THEN
		SET Recaudación = 000;
	END IF;
    
	RETURN Recaudación;
END $$

-- necesito idfinchin
-- necesito la fecha de inicio y de fin
-- necesito el total de esos dias


-- 5) Se pide hacer el SP ‘Gastos’ que reciba por parámetro una identificación de cliente. El SP tiene que devolver fecha y hora, nombre del juego y consumo ($) que el cliente haya jugado, ordenado por fecha y hora descendentemente.--

DELIMITER $$
DROP PROCEDURE IF EXISTS Gastos $$
CREATE PROCEDURE Gastos (unDNI INT)
BEGIN
	SELECT JuegaFichin.FechayHora, Fichin.nombre, JuegaFichin.Gasto
    FROM JuegaFichin
    INNER JOIN Fichin ON JuegaFichin.idFichin = Fichin.idFichin
    WHERE JuegaFichin.DNI = DNI
    ORDER BY JuegaFichin.FechayHora DESC;
END $$

-- traer fecha y hora
-- traer nombre del juego
-- consumo ($) del cliente en el juego
-- ordenar fecha y hora descendentemente
