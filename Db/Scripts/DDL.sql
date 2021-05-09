CREATE DATABASE SENAI_HROADS_MANHA
GO
USE SENAI_HROADS_MANHA
GO

CREATE TABLE Classes(
	IdClasse INT PRIMARY KEY IDENTITY,
	Nome TEXT NOT NULL,
);

CREATE TABLE Personagens(
	IdPersonagem	INT PRIMARY KEY IDENTITY,
	IdClasse		INT FOREIGN KEY REFERENCES Classes (IdClasse),
	Nome			VARCHAR(200) NOT NULL,
	MaxVida			TINYINT NOT NULL,
	MaxMana			TINYINT NOT NULL,
	DataAtualizacao DATE NOT NULL, 
	DataCriacao		DATE NOT NULL
);

CREATE TABLE TiposDeHabilidades(
	IdTipoHabilidade INT PRIMARY KEY  IDENTITY,
	Nome			 TEXT NOT NULL,
);

CREATE TABLE Habilidades(
	IdHabilidade	   INT PRIMARY KEY IDENTITY,
	IdTipoDeHabilidade INT FOREIGN KEY REFERENCES TiposDeHabilidades (IdTipoHabilidade),
	Nome			   TEXT NOT NULL,
);

CREATE TABLE ClassesHabilidades(
	IdHabilidade INT FOREIGN KEY REFERENCES Habilidades (IdHabilidade),
	IdClasse INT FOREIGN KEY REFERENCES Classes (IdClasse),
);

CREATE TABLE TipoUsuario(
	IdTipoUsuario INT PRIMARY KEY IDENTITY,
	TipoUsuario VARCHAR(200)
);
GO

CREATE TABLE Usuario(
	IdUsuario INT PRIMARY KEY IDENTITY,
	Email VARCHAR(200),
	Senha VARCHAR(200),
	IdTipoUsuario INT FOREIGN KEY REFERENCES TipoUsuario(IdTipoUsuario)
);

