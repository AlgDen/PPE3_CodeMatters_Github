/* Liste des visiteurs, nom prénom, ville par nom de laboratoire en ordre alphabétique  */
SELECT  nomlabo, nom, prenom, ville
from visiteur join laboratoire on visiteur.idlabo = laboratoire.idlabo
order by nomlabo, nom;

/* Liste des visiteurs responsable de secteur, nom prénom, ville par nom de secteur ordre alphabétique  */
SELECT  libsecteur, nom, prenom, ville
from visiteur join secteur on visiteur.idvisiteur = secteur.idvisiteur
order by libsecteur, nom

/* Liste des visiteurs responsable de région, nom prénom, ville par nom de region ordre alphabétique  */
SELECT		libRegion, nom, prenom, ville
from		visiteur	join region		on visiteur.idvisiteur = region.idvisiteur
order by	libRegion, nom;

/* test secteur, région visiteur et travailler*/
SELECT		Secteur.idSecteur, libSecteur, secteur.idVisiteur, Region.idRegion, Region.idVisiteur, libRegion, cp, visiteur.idVisiteur, nom, prenom 
from		travailler  join	visiteur	ON  travailler.idvisiteur	= Visiteur.idVisiteur
						join	region		ON	travailler.idRegion		= Region.idRegion
						join    secteur		ON  region.idSecteur		= secteur.idSecteur
order by	1, libSecteur, libRegion, nom 

/* Requête de contrôle */
/*-------------------------*/

SELECT		libRegion, nom, prenom, dateEmbauche 
FROM		Travailler INNER JOIN	Visiteur
ON			Travailler.idVisiteur = Visiteur.idVisiteur
INNER JOIN	Region  ON			Travailler.idRegion = Region.idRegion
ORDER BY	libRegion, nom;

SELECT		Travailler.idRegion, libRegion, COUNT(Travailler.idVisiteur) AS NbVisiteurs 
FROM		Travailler JOIN		Region  
ON			Travailler.idRegion = Region.idRegion
GROUP BY 	Travailler.idRegion, libRegion
HAVING		Travailler.idRegion IN (52,53,54) 
ORDER BY	libRegion;

/* Regions dans lesquelles aucun visiteur ne travaille */
SELECT 		Region.idRegion, libRegion
FROM 		Region
WHERE		Region.idRegion 
NOT IN 		(select Travailler.idRegion From Travailler)