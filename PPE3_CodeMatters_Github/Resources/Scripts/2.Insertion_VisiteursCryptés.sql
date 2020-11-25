-- les tuples des LABORATOIRE 
INSERT INTO Laboratoire VALUES ('Swiss');
INSERT INTO Laboratoire VALUES ('Bourdin');
INSERT INTO Laboratoire VALUES ('Autres laboratoires');

--Certains des tuples de VISITEUR
INSERT INTO VISITEUR (idVisiteur, idLabo, nom, prenom, rue, cp, ville, dateEmbauche, identifiant, password) VALUES
('a13', 1,'Villechalane','Louis', '8 rue des Charmes', '46000', 'Cahors', '2005-12-21', 'lvillachane','92eb980737f1854076b2e34933286d8e'),
('a17', 1,'Andre', 	'David' ,'1 rue Petit', '46200', 'Lalbenque', '1998-11-23', 'dandre', '37f2381c9a729782c38410b1ea5b8191'),
('a55', 1,'Bedos', 	'Christian','1 rue Peranud', '46250', 'Montcuq', '1995-01-12', 'cbedos', '26ec3c585ee973005c2744742d920dc3'),
('a93', 1,'Tusseau','Louis', '22 rue des Ternes', '46123', 'Gramat', '2000-05-01', 'ltusseau', 'f85f3127fc55f0ad7433b6879bc05f4e'),
('b13', 1,'Bentot', 'Pascal', '11 allée des Cerises', '46512', 'Bessines', '1992-07-09', 'pbentot', 'ae5d0d7637be4083a245f980a2189d97'),
('b16', 1,'Bioret',	'Luc', '1 Avenue gambetta', '75000', 'Paris', '1998-05-11', 'lbioret', '566ea5a9b3a6f186928cc20711f13fa8'),
('b19', 2,'Bunisset','Francis', '10 rue des Perles', '93100', 'Montreuil', '1987-10-21', 'fbunisset', '969c2fe5ac918a86a664b2041d5bc295'),
('b25', 2,'Bunisset','Denise', '23 rue Manin', '75019', 'Paris', '2010-12-05', 'dbunisset', '03b01d4e2f53d838a2228e6cd57b8578'),
('b28', 1,'Cacheux', 'Bernard', '114 rue Blanche','75017','Paris','2009-11-12','bcacheux', 'f6b78ee75c60c4becd5ed3daaca14127'),
('b34', 1,'Cadic', 	'Eric', '123 av de la République', '75011', 'Paris', '2008-09-23', 'ecadic', '36b98727aece53010ddde58639294427'),
('b46', 1,'Charoze', 'Catherine', '100 rue Petit', '75019', 'Paris', '2005-11-12', 'ccharoze', 'fce14894825737b9850d2bfccf0adf02'),
('b50', 2,'Clepkens','Christophe','12 allée des Anges','59000','Lille', '2003-08-11','cclepkens', '9ac1d70eef6e5f225b1db64eabaa4374'),
('b59', 3,'Cottin', 'Vincenne', '36 rue Des Roches', '93100', 'Monteuil', '2001-11-18', 'vcottin', 'e509e3ed6ac643ac405aba9c40ebc591'),
('c14', 3,'Daburon', 'François', '13 rue de Chanzy', '75000', 'Paris', '2002-02-11', 'fdaburon', '44fda4ffdcf80a5f0c07fd0c82dafa4b'),
('c39', 1,'De Monceau', 'Philippe', '13 rue Barthes', '94000', 'Créteil', '2010-12-14', 'pde', 'd5d01f0959b81d8e99e0ff5ecec858f7'),
('c54', 2,'Debelle', 'Michel', '181 av Barbusse', '93210', 'Rosny', '2006-11-23', 'mdebelle', '5583dc317a2427151176da897d02847c'),
('d13', 1,'Debelle', 'Jeanne', '134 al des Joncs', '44000', 'Nantes', '2000-05-11', 'jdebelle', 'b7d60232b71cf9cbbfffa53cac58c2b6'),
('d51', 2,'Debroise', 'Michel', '2 Bld Jourdain', '44000', 'Nantes', '2001-04-17', 'mdebroise', '7101579c34d26bb94798fa096c577a8b'),
('e22', 3,'Desmarquest','Nathalie', '14 Place d Arc', '45000', 'Orléans', '2005-11-12', 'ndesmarquest', '77f0798fb878eba2d41a92187db41370'),
('e24', 1,'Desnost', 'Pierre', '16 avenue des Cèdres', '23200', 'Guéret', '2001-02-05','pdesnost', 'f22a9af3e65d9b3942f242cb559374ae'),
('e39', 3,'Dudouit', 'Frédéric', '18 rue de l église', '23120', 'GrandBourg', '2000-08-01', 'fdudouit', '09723e8247fbdda4d2dda2d15d160dfd'),
('e49', 1,'Duncombe', 	'Claude', '19 rue de la tour', '23100', 'La Source', '1987-10-10', 'cduncombe', '3ea57afcbbdbe5190df1d1330621b1ef'),
('e58', 2,'Enault-Pascreau', 'Céline', '25 place de la gare', '23200', 'Gueret', '1995-09-01', 'cenault', '8c2cfac2fc5e3b1100842b3573720cc8'),
('e52', 2,'Eynde', 	'Valérie', '3 Grand Place', '13015', 'Marseille', '1999-11-01', 'veynde', 'ea33b05db1515b43c387050ef64e687b'),
('f21', 1,'Finck', 	'Jacques', '10 avenue du Prado', '13002', 'Marseille', '2001-11-10', 'jfinck', 'ec5014f6a2f2631952b6c677409a29fe'),
('f39', 3,'Frémont', 'Fernande', '4 route de la mer', '13012', 'Allauh', '1998-10-01', 'ffremont', '8774099cc05fd213276773425739ed85'),
('f48', 1,'Gest', 'Alain', '30 avenue de la mer', '67000', 'Strasbourg', '1985-11-01', 'agest', '8167f1d92b7c2666aaf0d6f77cbc761d'),
('z10', 1,'Maurice', 'Igor', '3 avenue du Vauclin', '972', 'Saint-Pierre', '1995-12-12', 'imaurice', '8167f1d92b7c2666aaf0d6f77cbc761d'),
('z11', 1,'Martin', 'Jean', '250 rue du Port', '97200', 'Saint-Pierre', '1992-30-06', 'jmartin', '8167f1d92b7c2666aaf0d6f77cbc761d'),
('z12', 1,'Noël', 'Annie', 'Rue de la Montagne noire', '97300', 'Cayenne', '1988-25-05', 'anoel', '8167f1d92b7c2666aaf0d6f77cbc761d');
--Certains des tuples des SECTEUR
INSERT INTO Secteur (idSecteur, libSecteur, idVisiteur) VALUES 
(1, 'Sud', 'e52'),
(2, 'Nord', 'b50'),
(3, 'Paris-Centre', 'c14'),
(4, 'Est', 'f48'),
(5, 'Ouest', 'd13'),
(9, 'DOM TOM', 'z10');

--Certains des tuples des REGION 
INSERT INTO Region (idRegion, libRegion, idVisiteur, idSecteur) VALUES 
(1, 'Guadeloupe', 'z11',9),
(2, 'Martinique','z11',9),
(3, 'Guyanne','z12',9),
(11, 'Ile De France','b25',3),
(21, 'Champagne-Ardenne','e22',4),
(22, 'Picardie','b46',2),
(23, 'Haute Normandie','b46',2),
(24, 'Centre','e22',5),
(31, 'Nord-Pas-de-Calais','b46',2),
(41, 'Alsace Lorraine','e22',4),
(52, 'Pays de la Loire','d51',5),
(53, 'Bretagne','d51',5),
(54, 'Poitou Charente','f21',3),
(72, 'Aquitaine','f21',1),
(82, 'Rhône-Alpes','f21',1),
(83, 'Auvergne','f21',3);

-- les tuples de travailler
INSERT INTO Travailler (idVisiteur, idRegion) VALUES
('z10', 1),
('z11', 1),
('z10', 2),
('z11', 2),
('z10', 3),
('z12', 3),
('a17', 11),
('b19', 11),
('b28', 11),
('b34', 11),
('c39', 11),
('b25', 11),
('e39', 21),
('e49', 21),
('e22', 21),
('a55', 24),
('e39', 24),
('e49', 24),
('e52', 24),
('e58', 24),
('b13', 52),
('b16', 52),
('a13', 52),
('d13', 52),
('d51', 52),
('a17', 53),
('a93', 53),
('d13', 53),
('d51', 53),
('d13', 54),
('a55', 72),
('e49', 72),
('f21', 72),
('e52', 72),
('e24', 82),
('e39', 82),
('e49', 82),
('f21', 82),
('f21', 83),
('e24', 83);


