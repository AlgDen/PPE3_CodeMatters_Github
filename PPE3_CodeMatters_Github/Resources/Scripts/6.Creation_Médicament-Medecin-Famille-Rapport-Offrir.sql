CREATE TABLE FAMILLE (
idFamille 		char(3) 			NOT NULL,
libFamille 		varchar(80) 		NOT NULL,
PRIMARY KEY (idFamille)
);

CREATE TABLE SPECIALITE (
  idSpecialite 	char(3) 		NOT NULL,
  libSpecialite varchar(64) 	NOT NULL,
  PRIMARY KEY (idSpecialite)
);

CREATE TABLE MEDICAMENT (
idMedicament	char(12) 		NOT NULL,
nomCommercial 	varchar(64) 	NOT NULL,
idFamille  		char(3) 		NOT NULL,
composition 	varchar(256) 	NOT NULL,
effets 			varchar(256) 	NOT NULL,
contreIndications varchar(256) 	NOT NULL,
PRIMARY KEY (idMedicament)
);

CREATE TABLE MEDECIN (
  idMedecin		int 			identity (1, 1) ,
  nom 			varchar(30) 	NOT NULL,
  prenom 		varchar(30) 	NOT NULL,
  adresse 		varchar(80) 	NOT NULL,
  tel 			varchar(15) 	NULL,
  idSpecialite 	char(3) 		NULL,
  departement 	int 			NOT NULL,
  PRIMARY KEY (idMedecin)
);

CREATE TABLE MOTIF (
  idMotif		int   			identity (1, 1) ,
  libMotif		varchar(64)		NULL,
  PRIMARY KEY (idMotif)
) ;
CREATE TABLE RAPPORT (
  idRapport		int 			identity (1, 1) ,
  dateRapport	date 			NULL,
  idMotif 		int				NULL   , 
  bilan 		varchar(64)		NULL   ,
  idVisiteur 	char(3) 		NOT NULL,
  idMedecin 	int				NOT NULL,
  PRIMARY KEY (idRapport)
) ;
CREATE TABLE  OFFRIR(
idRapport 		int 			NOT NULL,
idMedicament 	char(12) 		NOT NULL,
quantite 		int				NULL,
PRIMARY KEY (idRapport,idMedicament)
);

ALTER TABLE MEDICAMENT
  ADD CONSTRAINT medicament_fk 	FOREIGN KEY (idFamille) 	REFERENCES  famille(idFamille);
ALTER TABLE RAPPORT
  ADD CONSTRAINT rapport_fk1 	FOREIGN KEY (idVisiteur) 	REFERENCES  visiteur(idVisiteur);
ALTER TABLE RAPPORT
  ADD CONSTRAINT rapport_fk2 	FOREIGN KEY (idMedecin) 	REFERENCES  medecin(idMedecin);
  ALTER TABLE RAPPORT
  ADD CONSTRAINT rapport_fk3 	FOREIGN KEY (idMotif) 		REFERENCES  Motif(idMotif);
ALTER TABLE OFFRIR
  ADD CONSTRAINT offrir_fk1 	FOREIGN KEY (idRapport) 	REFERENCES  rapport(idRapport);
ALTER TABLE OFFRIR
  ADD CONSTRAINT offrir_fk2 	FOREIGN KEY (idMedicament) 	REFERENCES  medicament(idMedicament);
ALTER TABLE MEDECIN
  ADD CONSTRAINT medecin_fk 	FOREIGN KEY (idSpecialite) 	REFERENCES  specialite(idSpecialite);
  

