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
CREATE TABLE Reservering
(
	ReserveringId		INT				IDENTITY(1,1),
	Tafel				INT				NOT NULL,
	Datum				DATE			NOT NULL,
	KlantId				INT				NOT NULL,
	MedewerkerId		INT				NOT NULL
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

CREATE TABLE Klant
(
	KlantId				INT				IDENTITY(1,1),
	Voornaam			VARCHAR(50)		NOT NULL,
	Tussenvoegsel		VARCHAR(20),
	Achternaam			VARCHAR(50)		NOT NULL,
	Telefoonnummer		VARCHAR(20)		NOT NULL,
	Email				VARCHAR(40)		NOT NULL,
);

CREATE TABLE Medewerker
(
	MedewerkerId		INT				IDENTITY(1,1),
	Voornaam			VARCHAR(50)		NOT NULL,
	Tussenvoegsel		VARCHAR(20),
	Achternaam			VARCHAR(50)		NOT NULL,
	Gebruikersnaam		VARCHAR(50)		NOT NULL,
	Wachtwoord			VARCHAR(100)	NOT NULL,
	Rol					TINYINT			NOT NULL
)

-- Primary keys
ALTER TABLE Reservering
ADD CONSTRAINT PK_Reservering PRIMARY KEY(ReserveringId);

ALTER TABLE Categorie
ADD CONSTRAINT PK_CategorieID PRIMARY KEY(CategorieId);

ALTER TABLE Subcategorie
ADD CONSTRAINT PK_Subcategorie PRIMARY KEY(SubcategorieId);

ALTER TABLE MenuItem
ADD CONSTRAINT PK_MenuItem PRIMARY KEY(MenuItemId);

ALTER TABLE Klant
ADD CONSTRAINT PK_KlantID PRIMARY KEY(KlantId);

ALTER TABLE Medewerker
ADD CONSTRAINT PK_MedewerkerId PRIMARY KEY(MedewerkerId)

-- Foreign keys
ALTER TABLE Subcategorie
ADD CONSTRAINT FK_Subcategorie_Categorie FOREIGN KEY(CategorieId)
REFERENCES Categorie(CategorieId);

ALTER TABLE MenuItem
ADD CONSTRAINT FK_MenuItem_Subcategorie FOREIGN KEY (SubcategorieId)
REFERENCES Subcategorie(SubcategorieId);

ALTER TABLE Reservering
ADD CONSTRAINT FK_Reservering_Klant FOREIGN KEY (KlantId)
REFERENCES Klant(KlantId);

ALTER TABLE Reservering
ADD CONSTRAINT FK_Reservering_Medewerker FOREIGN KEY (MedewerkerId)
REFERENCES Medewerker(MedewerkerId);

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

INSERT INTO Klant(Voornaam, Tussenvoegsel, Achternaam, Email, Telefoonnummer)
VALUES	('Stan', '', 'Verbeek', 'stan@email.com', '0612345678'),
		('Enrico', 'van', 'Toorn', 'enrico@email.com', '0612876513'),
		('Ricardo', 'van', 'Toorn', 'ricardo@email.com', '0648162599')

INSERT INTO Medewerker(Voornaam, Tussenvoegsel, Achternaam, Gebruikersnaam, Wachtwoord, Rol)
VALUES ('Rob', '', 'Wessels', 'rob', 'P@ssword', 10),
	   ('Martijn', 'van de', 'Wetering', 'martijn', 'P@ssword', 10),
	   ('jeroen', '', 'Groen', 'jeroen', 'P@ssword', 10)

INSERT INTO Reservering (Tafel, AantalPersonen, Datum, KlantId, MedewerkerId)
VALUES	(4, 12, '2025-12-03 10:10:54', 2, 1),
		(8, 4, '2025-12-03 10:10:54', 1, 3),
		(5, 7, '2025-12-03 10:10:54', 3, 2)