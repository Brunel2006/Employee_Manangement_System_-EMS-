SELECT * FROM sanction;

ALTER TABLE sanction
ADD DateFin date;

UPDATE sanction
SET DateFin = '2025-03-12'
WHERE IdSanction = 'SAN52070';

UPDATE sanction
SET DateFin = '2025-03-12'
WHERE IdSanction = 'SAN71753';