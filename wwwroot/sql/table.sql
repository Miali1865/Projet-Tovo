CREATE TABLE departement(
    idDepartement SERIAL PRIMARY KEY,
    secteur VARCHAR(45)
);

CREATE TABLE poste(
    idPoste SERIAL PRIMARY KEY,
    idDepartement int REFERENCES depertement(idDepartement),
    nom VARCHAR(45)
);

CREATE TABLE filiere(
    idFiliere SERIAL PRIMARY KEY,
    nom VARCHAR(45)
);

CREATE TABLE diplome(
    idDiplome SERIAL PRIMARY KEY,
    nom VARCHAR(45)
);

CREATE TABLE typeContrat(
    idType SERIAL PRIMARY KEY,
    nom VARCHAR(45)
);

CREATE TABLE genre(
    idGenre SERIAL PRIMARY KEY,
    genre VARCHAR(45)
);

CREATE TABLE nationalite(
    idNationalite SERIAL PRIMARY KEY,
    nationalite varchar(45)
);

CREATE TABLE offre(
    idOffre SERIAL PRIMARY KEY,
    idPoste int REFERENCES poste(idPoste),
    nbre int(10),
    idType int references typeContrat(idType),
    idGenre int references genre(idGenre),
    idDiplome int references diplome(idDiplome),
    idFiliere int REFERENCES filiere(idFiliere),
    idNationalite int references nationalite(idNationalite),
    lieu varchar(50),
    experience TEXT,
    responsabilite TEXT NOT NULL
);

CREATE TABLE coefficient(
    idCoeff serial primary key,
    idOffre int references offre(idOffre),
    coeffGenre int(10),
    coeffDiplome int(10),
    coeffNationalite int(10),
    coeffExperience int(10),
    coeffAge int(10)
);


CREATE TABLE age(
    idAge seriel primary key,
    idOffre int REFERENCES offre(idOffre),
    min int(3),
    max int(3)
);