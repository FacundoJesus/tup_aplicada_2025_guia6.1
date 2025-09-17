USE master;

GO

USE Guia6_1Ejercicio1_db;

GO

--a- Realice la consulta de la tabla Figuras. b- Establezca el valor de la Id , por ejemplo: 3.
DECLARE @Id_Figura INT = 3;
SELECT * FROM Figuras WHERE Id=@Id_Figura;


--c- Realice el delete del registro
DELETE FROM Figuras
WHERE Id=@Id_Figura


--d- Realice la consulta de la tabla Figuras.
SELECT * FROM Figuras WHERE Id=@Id_Figura;

GO
USE master;



