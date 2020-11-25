--
-- Structure de la table FraisForfait
CREATE TABLE 	 FraisForfait (
  id 		char(3) 		NOT NULL,
  libelle char(20) 		DEFAULT NULL,
  montant decimal(5,2) 	DEFAULT NULL,
  PRIMARY KEY (id)
) ;
--
-- Structure de la table Etat
CREATE TABLE Etat (
  id 		char(2) 	NOT NULL,
  libelle varchar(30) DEFAULT NULL,
  PRIMARY KEY (id)
) ;
--
-- Structure de la table FicheFrais
CREATE TABLE  fichefrais (
  idVisiteur 		char(3) 		NOT NULL,
  mois 			char(6) 		NOT NULL,
  nbJustificatifs int 		DEFAULT NULL,
  montantValide 	decimal(10,2) 	DEFAULT NULL,
  dateModif 		date 			DEFAULT NULL,
  idEtat 			char(2) 		DEFAULT 'CR',
  PRIMARY KEY (idVisiteur,mois),
  FOREIGN KEY (idEtat) REFERENCES Etat(id),
  FOREIGN KEY (idVisiteur) REFERENCES Visiteur(idVisiteur)
);
--
-- Structure de la table LigneFraisForfait

CREATE TABLE  LigneFraisForfait (
  idVisiteur 		char(3) NOT NULL,
  mois 			char(6) NOT NULL,
  idFraisForfait 	char(3) NOT NULL,
  quantite 		int DEFAULT NULL,
  PRIMARY KEY (idVisiteur,mois,idFraisForfait),
  FOREIGN KEY (idVisiteur, mois) REFERENCES FicheFrais(idVisiteur, mois),
  FOREIGN KEY (idFraisForfait) REFERENCES FraisForfait(id)
) ;
-- Structure de la table LigneFraisHorsForfait
--
CREATE TABLE  LigneFraisHorsForfait (
  id 			integer identity (1, 1)   	not null,
  idVisiteur 	char(3) 		NOT NULL,
  mois 		char(6) 		NOT NULL,
  libelle 	varchar(100) 	DEFAULT NULL,
  date 		date 			DEFAULT NULL,
  montant 	decimal(10,2) 	DEFAULT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (idVisiteur, mois) REFERENCES FicheFrais(idVisiteur, mois)
) ;
