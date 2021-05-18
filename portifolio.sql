CREATE DATABASE PORTIFOLIO;
USE PORTIFOLIO;
CREATE TABLE USUARIO (
idusuario INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
nomeusuario VARCHAR(255),
login VARCHAR(255),
senha VARCHAR(255),
tipousuario varchar(255)
);

INSERT INTO USUARIO(nomeusuario, login, senha, tipousuario) VALUES ("admin", "admin", "admin", "Administrador" );
INSERT INTO USUARIO(nomeusuario, login, senha, tipousuario) VALUES ("aluno1", "aluno1", "aluno1", "Aluno" );
INSERT INTO USUARIO(nomeusuario, login, senha, tipousuario) VALUES ("aluno2", "aluno2", "aluno2", "Aluno" );
INSERT INTO USUARIO(nomeusuario, login, senha, tipousuario) VALUES ("aluno3", "aluno3", "aluno3", "Aluno" );

select * from USUARIO;

CREATE TABLE AULA(
idaula INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
Nome VARCHAR(255),
ImagemURL VARCHAR(400),
VideoUrl VARCHAR(400),
Duracao INT,
Preco double
);

INSERT INTO AULA(Nome, ImagemURL, VideoUrl, Duracao, Preco) VALUES ("Começando a programar", "https://img.youtube.com/vi/UqzQwR-L-OQ/0.jpg", "https://www.youtube.com/watch?v=UqzQwR-L-OQ", 7, 20 );
INSERT INTO AULA(Nome, ImagemURL, VideoUrl, Duracao, Preco) VALUES ("ASP.NET C# Iniciante - Aula 1 - Introdução", "https://img.youtube.com/vi/RDIR346RjoI/mqdefault.jpg", "https://www.youtube.com/watch?v=RDIR346RjoI", 30, 10 );
INSERT INTO AULA(Nome, ImagemURL, VideoUrl, Duracao, Preco) VALUES ("Curso de Introdução ao .NET Framework - Aula 1", "https://img.youtube.com/vi/x2q5RceTzD0/mqdefault.jpg", "https://www.youtube.com/watch?v=x2q5RceTzD0", 20, 2 );
INSERT INTO AULA(Nome, ImagemURL, VideoUrl, Duracao, Preco) VALUES (" Criando o Projeto e Instalando DOT NET 2.0", "https://img.youtube.com/vi/njlmcXxSHE4/mqdefault.jpg", "https://www.youtube.com/watch?v=NoYIohFBKnY", 60, 10 );


select * from AULA;
