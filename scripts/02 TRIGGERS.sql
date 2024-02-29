SELECT 'Creando Triggers' AS 'Estado' $$



-- 1) Realizar un trigger para que al dar de alta una fila en recarga, impacte automáticamente en el saldo del cliente.--


USE 5to_Fichines $$
DELIMITER $$
DROP TRIGGER IF EXISTS ActualizarSaldo $$
CREATE TRIGGER ActualizarSaldo AFTER INSERT ON Recarga
FOR EACH ROW
BEGIN
    UPDATE Tarjeta
    SET Saldo = Saldo + NEW.MontoRecargado
    WHERE idTarjeta = NEW.idTarjeta;
END $$


-- 2) Realizar un trigger para que al momento de hacer un gasto en el saldo del cliente, 
-- se verifique que tenga el saldo necesario para ese gasto; 
-- en caso contrario se debe mostrar la leyenda ‘Saldo insuficiente’ y no permitir la operación. --


DELIMITER $$
DROP TRIGGER IF EXISTS GastoSaldo $$
CREATE TRIGGER GastoSaldo BEFORE INSERT ON JuegaFichin
FOR EACH ROW
BEGIN
    IF (EXISTS (SELECT Saldo
                FROM Tarjeta
                WHERE Saldo < NEW.Gasto))THEN
    SIGNAL SQLSTATE '45000'
    SET MESSAGE_TEXT = 'Saldo insuficiente';
    END IF;
END $$
