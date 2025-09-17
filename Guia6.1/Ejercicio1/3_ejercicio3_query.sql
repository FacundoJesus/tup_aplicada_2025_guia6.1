USE master;

GO

USE Guia6_1Ejercicio1_db;

GO


--Desarrollar la consulta por Id de la tablas Figuras. Utilizar la Id=3 como valor de prueba.
SELECT f.Id,
	   CASE WHEN f.Tipo=1 THEN 'Rectangulo'
			WHEN f.Tipo=2 THEN 'Circulo'
	   ELSE 'Desconocido' END AS Tipo,
	   f.Area,
	   f.Ancho,
	   f.Largo,
	   f.Radio
FROM Figuras f
WHERE f.Id=3

GO
USE master
GO