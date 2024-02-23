
DELIMITER $$
SELECT 'Creando Triggers' AS 'Estado' $$



-- 1) Realizar un trigger para que al dar de alta una fila en recarga, impacte automáticamente en el saldo del cliente.--


USE 5to_Fichines $$
DELIMITER $$
DROP TRIGGER IF EXISTS ActualizarSaldo $$
CREATE TRIGGER ActualizarSaldo AFTER INSERT ON Recarga
FOR EACH ROW
BEGIN
    UPDATE Cliente
    SET Saldo = SUM (Saldo + NEW.MontoRecargado)
    WHERE ;
END $$

-- UPDATE Cliente WHERE --
-- SET Saldo = SUM (OLD.Saldo + NEW.MontoRecargado) --
--creo que me olvidé de la condición--


-- 2) Realizar un trigger para que al momento de hacer un gasto en el saldo del cliente, se verifique que tenga el saldo necesario para ese gasto; en caso contrario se debe mostrar la leyenda ‘Saldo insuficiente’ y no permitir la operación. --


DELIMITER $$
DROP TRIGGER IF EXISTS GastoSaldo $$
CREATE TRIGGER GastoSaldo BEFORE UPDATE ON Tarjeta
FOR EACH ROW
BEGIN
    IF (OLD.Saldo < NEW.Gasto) THEN --no es "Gasto" a secas, NEW-OLD --
    SIGNAL SQLSTATE '45000'
    SET MESSAGE_TEXT = 'Saldo insuficiente';
    END IF;
END $$
-- before insert en juega fichin --