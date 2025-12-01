

create table employe(
IdEmploye varchar(30) Primary key,
NomEmploye varchar(30) NOT NULL,
PrenomEmploye varchar(30) NOT NULL,
TelEmploye varchar(30) NOT NULL,
Sexe varchar(15) NOT NULL,
Poste varchar(30) NOT NULL,
DateInsertion date,
DateModification date,
Salaire int
);



alter table employe
add DateSuppression date NULL;

create table departement
(
NumDepartement varchar(30) primary key,
NomDepartement varchar(30) NOT NULL,
ChefDepartement varchar(30) foreign key references employe(IdEmploye)
);


select * from employe