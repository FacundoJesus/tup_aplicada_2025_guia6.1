USE master;

GO


USE Guia6_1Ejercicio1_db;

GO

--Sentencia DML update (save)
--a- Realice la consulta de la tabla Figuras.
DECLARE @Id_Figura INT = 3;



--b- Establezca variables T-SQL con valores iniciales. El Id a actualizar igual a 3.
SELECT * FROM Figuras WHERE Id=@Id_Figura;

DECLARE @Tipo INT;
DECLARE @Area DECIMAL(18,2);
DECLARE @Ancho DECIMAL(18,2);
DECLARE @Largo DECIMAL(18,2);
DECLARE @Radio DECIMAL(18,2);

--c- Calcular el área como prueba 
SELECT @Tipo=f.Tipo, @Ancho = f.Ancho, @Largo=f.Largo, @Radio = f.Radio
FROM Figuras f
WHERE f.Id=@Id_Figura

IF @Tipo = 1
BEGIN
	SET @Area = @Ancho * @Largo
END
ELSE IF @Tipo = 2
BEGIN
	SET @Area = PI() * POWER(@Radio,2);
END

--d- Actualice el registro
UPDATE Figuras 
SET Area=@Area, Ancho=@Ancho, Largo=@Largo, Radio=@Radio
WHERE Id=@Id_Figura

--d- Realice la consulta de la tabla Figuras.
SELECT * FROM Figuras WHERE Id=@Id_Figura;

GO

USE master;
