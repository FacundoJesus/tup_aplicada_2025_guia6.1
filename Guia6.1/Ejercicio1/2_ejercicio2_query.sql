USE master;

GO

USE Guia6_1Ejercicio1_db;

GO

-- listar todas las figuras
--Consulta de todos los registros (getAll)
SELECT f.Id,
		Tipo = CASE WHEN f.Tipo = 1 THEN 'Rectangulo'
			 WHEN f.Tipo = 2 THEN 'Circulo'
			 ELSE 'No identificado'
			 END,
	   f.Area,
	   f.Ancho,
	   f.Largo,
	   f.Radio
FROM Figuras f
ORDER BY f.Id

GO

USE master;
