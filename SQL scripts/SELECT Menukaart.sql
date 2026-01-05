SELECT	c.Naam AS Categorie, 
		s.Naam AS Subcategorie, 
		m.Naam AS MenuItem, 
		m.Omschrijving AS Omschrijving
FROM Categorie C
LEFT JOIN Subcategorie s
	ON c.CategorieId = s.CategorieId
LEFT JOIN MenuItem m
	ON m.SubcategorieId = s.SubcategorieId
WHERE m.Omschrijving IS NOT NULL

