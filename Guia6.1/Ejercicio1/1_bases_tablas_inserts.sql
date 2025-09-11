USE master

GO

DROP DATABASE IF EXISTS Guia6_1Ejercicio1_db

GO

CREATE DATABASE Guia6_1Ejercicio1_db

GO

USE Guia6_1Ejercicio1_db

GO

CREATE TABLE Figuras
(
Id INT PRIMARY KEY IDENTITY(1,1),
Tipo INT NOT NULL,
Area DECIMAL (18,2),
Ancho DECIMAL(18,2), -- NUMERIC O DECIMAL
Largo DECIMAL (18,2),
Radio DECIMAL (18,2)
);

GO

INSERT INTO Figuras(Tipo, Ancho, Largo, Radio) 
VALUES
(1, 1,1,NULL),
(1, 1,2,NULL),
(2, NULL,NULL, 1),
(1, 2.2,1,NULL),
(2, NULL,NULL,2.1);



SELECT f.Id,
		Tipo = CASE WHEN f.Tipo = 1 THEN 'Rectangulo'
			 WHEN f.Tipo = 2 THEN 'Circulo'
			 ELSE 'No identificado'
			 END,
		f.Area,
		f.Ancho,
		f.Largo,
		f.Radio
FROM Figuras f;

GO

USE master
GO