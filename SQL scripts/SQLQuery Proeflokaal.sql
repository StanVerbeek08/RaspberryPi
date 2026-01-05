-- Auteurs:			Enrico van Toorn, Stan Verbeek
-- Datum:			25-11-2025
-- Omschrijving		Proeflokaal SQL create & insert script

-- Aanmaken ProeflokaalDB
USE master
DROP DATABASE IF EXISTS ProeflokaalDB
GO
CREATE DATABASE ProeflokaalDB
GO
USE ProeflokaalDB

-- Aanmaken tabellen
CREATE TABLE Reserveringen 
(
	ReserveringId		INT				IDENTITY(1,1)
);
CREATE TABLE Categorie 
(
	CategorieId			INT				IDENTITY(1,1),
	Naam				VARCHAR(50)		NOT NULL
);
CREATE TABLE Subcategorie
(
	SubcategorieId		INT				IDENTITY(1,1),
	CategorieId			INT				NOT NULL,
	Naam				VARCHAR(50)		NOT NULL
);

CREATE TABLE MenuItem
(
	MenuItemId			INT				IDENTITY(1,1),
	SubcategorieId		INT				NOT NULL,
	Naam				VARCHAR(50)		NOT NULL,
	Omschrijving		VARCHAR(100),
);

-- Primary keys
ALTER TABLE Reserveringen
ADD CONSTRAINT PK_Reserveringen PRIMARY KEY(ReserveringId);

ALTER TABLE Categorie
ADD CONSTRAINT PK_CategorieID PRIMARY KEY(CategorieId);

ALTER TABLE Subcategorie
ADD CONSTRAINT PK_Subcategorie PRIMARY KEY(SubcategorieId);

ALTER TABLE MenuItem
ADD CONSTRAINT PK_MenuItem PRIMARY KEY(MenuItemId);

-- Foreign keys
ALTER TABLE Subcategorie
ADD CONSTRAINT FK_Subcategorie_Categorie FOREIGN KEY(CategorieId)
REFERENCES Categorie(CategorieId);

ALTER TABLE MenuItem
ADD CONSTRAINT FK_MenuItem_Subcategorie FOREIGN KEY (SubcategorieId)
REFERENCES Subcategorie(SubcategorieId);

-- Alternate keys
ALTER TABLE Categorie
ADD CONSTRAINT Unq_CategorieNaam UNIQUE(Naam);
 
ALTER TABLE Subcategorie
ADD CONSTRAINT Unq_SubcategorieNaam UNIQUE(Naam);

ALTER TABLE MenuItem
ADD CONSTRAINT Unq_MenuItemNaam UNIQUE(Naam);

INSERT INTO Categorie (Naam)
VALUES	('Dranken'),
		('Eten');

INSERT INTO Subcategorie (CategorieId, Naam)
VALUES	(1, 'Wijn'),
		(2,	'Voorgerechten'),
		(2,	'Nagerecht');

INSERT INTO MenuItem (SubcategorieId, Naam, Omschrijving)
VALUES	(2, 'Soep', 'Dit is soep'),
		(1, 'Champagne', 'Dit is champagne'),
		(3, 'Ijsje', 'Dit is lekker ijs')
