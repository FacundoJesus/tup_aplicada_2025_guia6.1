USE master;

GO

USE Guia6_1Ejercicio1_db;

GO

-- listar todas las figuras

SELECT f.Id,
	   f.Tipo,
	   f.Area,
	   f.Ancho,
	   f.Largo,
	   f.Radio
FROM Figuras f
ORDER BY f.Id

GO

USE master
GO