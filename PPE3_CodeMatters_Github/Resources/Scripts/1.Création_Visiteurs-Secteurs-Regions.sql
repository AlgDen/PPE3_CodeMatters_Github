/* ============================================================ */
/*   Nom de la base   :  ???????????                            */
/*   Nom de SGBD      :  Microsoft SQL Server                   */
/*   Date de création :  09/09/2016                             */
/* ============================================================ */
/*   Table : Laboratoire                                        */
/* ============================================================ */
create table Laboratoire
(
    idLabo       integer identity (1, 1)   	not null,
    nomLabo      char(20)              		null    ,
    constraint 	PK_Laboratoire 				primary key (idLabo)
)
go

/* ============================================================ */
/*   Table : Visiteur                                           */
/* ============================================================ */
create table Visiteur
(
    idVisiteur    char(3)            	not null,
    idLabo        integer            	not null,    
	nom           varchar(32)           null    ,
    prenom        varchar(32)           null    ,
    rue           varchar(64)           null    ,
    cp            char(5)               null    ,    
	ville         varchar(64)           null    ,
    dateEmbauche  char(10)              null    ,
	identifiant	  varchar(16)			not null,
	password	  varchar(128)				not null,
	constraint 	  PK_VISITEUR 			primary key (idVisiteur)
)
go

create table Secteur
(
    idSecteur    integer           			not null,
    libSecteur   varchar(64)            	null    ,
	idVisiteur   char(3)					not null,
    constraint 	PK_SECTEUR 					primary key (idSecteur)
)
go
/* ============================================================ */
/*   Table : Region                                             */
/* ============================================================ */
create table Region
(
    idRegion    integer           			not null,
    libRegion   varchar(64)            		null    ,
	idVisiteur	char(3)						not null,
	idSecteur	integer						not null,
    constraint 	PK_REGION 					primary key (idRegion)
)
go
/* ============================================================ */
/*   Table : Travailler                                         */
/* ============================================================ */
create table Travailler
(
    idVisiteur	char(3)            		not null,
    idRegion	integer            		not null,
    constraint 	PK_TRAVAILLER 			primary key (idVisiteur, idRegion)
)
go
/* ============================================================ */
/*   Références de clés étrangères                              */
/* ============================================================ */
alter table Visiteur
    add constraint 	FK_Laboratoire 		foreign key  (idLabo)
       references 	Laboratoire (idLabo)
go
alter table Region
    add constraint 	FK_VISITEUR 		foreign key  (idVisiteur)
       references 	Visiteur (idVisiteur)
go
alter table Region
    add constraint 	FK_SECTEUR 	foreign key  (idSecteur)
       references 	SECTEUR (idSecteur)
go
alter table Secteur
    add constraint 	FK_VISITEURSECTEUR	foreign key  (idVisiteur)
       references 	Visiteur (idVisiteur)
go
alter table Travailler
    add constraint 	FK_VISITEURTRAVAIL 		foreign key  (idVisiteur)
       references 	Visiteur (idVisiteur)
go
alter table Travailler
    add constraint FK_TRAVAILLER		foreign key  (idRegion)
       references 	Region (idRegion)
go

