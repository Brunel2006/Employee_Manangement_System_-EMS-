select * from employe

delete from employe
where IdEmploye = '@IdEmploye'

ALTER TABLE employe
add dateModification Date null

insert into departement
values ('Dp01', 'Developpement Logiciel'), ('Dp02', 'Cybersecurite'), ('Dp03', 'Recherche Technologique')

update employe
set PrenomEmploye = 'LOUIS', TelEmploye = '658675676'
where IdEmploye = 'EM02'

select COUNT(*) from employe where StatutEmploye = 'EN SERVICE'