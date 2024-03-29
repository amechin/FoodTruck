USE [Foodtruck]
GO
SET IDENTITY_INSERT [dbo].[ACTUALITES] ON 

INSERT [dbo].[ACTUALITES] ([ID_ACTUALITE], [TITRE], [DESCRIPTION], [URL_IMAGE], [DATE_DEBUT], [DATE_FIN], [LINK], [ID_UTILISATEUR], [ACTIF]) VALUES (1, N'Manger vegan à Barcelone', N'Barcelone est une ville très connue pour sa gastronomie, notamment pour ses tapas. Et ces derniers existent en de nombreuses versions depuis plusieurs années.', N'https://www.vegactu.com/wp-content/uploads/2019/05/flaxkale.jpg', CAST(N'2019-01-01T00:00:00.000' AS DateTime), CAST(N'2029-12-31T00:00:00.000' AS DateTime), N'https://www.vegactu.com/actualite/style-de-vie/manger-vegan-a-barcelone-28405/', 1, 1)
INSERT [dbo].[ACTUALITES] ([ID_ACTUALITE], [TITRE], [DESCRIPTION], [URL_IMAGE], [DATE_DEBUT], [DATE_FIN], [LINK], [ID_UTILISATEUR], [ACTIF]) VALUES (2, N'Attention au sucre', N'Il faut faire attention ....', N'https://www.vegactu.com/wp-content/uploads/2019/05/flaxkale.jpg', CAST(N'2019-01-01T00:00:00.000' AS DateTime), CAST(N'2029-12-31T00:00:00.000' AS DateTime), N'https://www.vegactu.com/actualite/style-de-vie/manger-vegan-a-barcelone-28405/', 1, 1)
INSERT [dbo].[ACTUALITES] ([ID_ACTUALITE], [TITRE], [DESCRIPTION], [URL_IMAGE], [DATE_DEBUT], [DATE_FIN], [LINK], [ID_UTILISATEUR], [ACTIF]) VALUES (3, N'Mangez des 5 fruits et légumes par jour ', N'Il faut faire attention à votre alimentation....', N'https://www.vegactu.com/wp-content/uploads/2019/05/flaxkale.jpg', CAST(N'2019-01-01T00:00:00.000' AS DateTime), CAST(N'2029-12-31T00:00:00.000' AS DateTime), N'https://www.vegactu.com/actualite/style-de-vie/manger-vegan-a-barcelone-28405/', 1, 1)
INSERT [dbo].[ACTUALITES] ([ID_ACTUALITE], [TITRE], [DESCRIPTION], [URL_IMAGE], [DATE_DEBUT], [DATE_FIN], [LINK], [ID_UTILISATEUR], [ACTIF]) VALUES (4, N'Faite du sport au moins trois fois par semaine ', N'Le sport est important pour entretenir la santé ....', N'https://www.vegactu.com/wp-content/uploads/2019/05/flaxkale.jpg', CAST(N'2019-01-01T00:00:00.000' AS DateTime), CAST(N'2029-12-31T00:00:00.000' AS DateTime), N'https://www.vegactu.com/actualite/style-de-vie/manger-vegan-a-barcelone-28405/', 1, 1)
SET IDENTITY_INSERT [dbo].[ACTUALITES] OFF
SET IDENTITY_INSERT [dbo].[PRODUIT] ON 

INSERT [dbo].[PRODUIT] ([ID_PRODUIT], [ID_FAMILLE_REPAS], [LIBELLE_PRODUIT], [DESCRIPTION], [NOMBRE_DE_VENTE], [PRIX], [URL_IMAGE], [STOCK], [LMMJVSD], [MOYENNE_NOTE], [UNITE]) VALUES (1, 1, N'Chaussures', N'Chaussure en cuir', 4, CAST(15.00 AS Numeric(18, 2)), N'www.google.fr', 10, N'LMM', 5, N'euro')
SET IDENTITY_INSERT [dbo].[PRODUIT] OFF
