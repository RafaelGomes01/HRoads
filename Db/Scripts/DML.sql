USE SENAI_HROADS_MANHA
GO

-- Inserir todos os Registros no Banco de Dados
INSERT INTO Personagens (Nome, MaxVida, MaxMana, DataAtualizacao, DataCriacao)
VALUES ('DeuBug', 100, 80, '01/03/21', '18/01/19'), ('BitBug', 70, 100, '01/03/21', '17/03/16'), ('Fer8', 75, 60, '01/03/21', '18/03/18');

INSERT INTO Classes (Nome)
VALUES ('Barbaro'), ('Cruzado'), ('Caçadora de Demonios'), ('Monge'), ('Necromante'), ('Feiticeiro'), ('Arcanista');

INSERT INTO Habilidades (Nome)
VALUES ('Lança Mortal'), ('Escudo Supremo'), ('Recuperar Vida');

INSERT INTO TiposDeHabilidades (Nome)
VALUES ('Ataque'), ('Magia'), ('Cura'), ('Defesa');

INSERT INTO ClassesHabilidades(IdHabilidade)
VALUES (1), (2), (2), (1), (3), (2), (3);

--Atualizar o Nome do Personagem de "Fer8" para "Fer7"
UPDATE Personagens
SET Nome='Fer7'
WHERE IdPersonagem = 3;

--Atualizar o Nome da Classe de "Necromante" para "Necromancer"
UPDATE Classes
SET Nome='Necromancer'
WHERE IdClasse=5;

INSERT INTO TipoUsuario (TipoUsuario)
VALUES ('Adiministrador'), ('Jogador');
GO

INSERT INTO Usuario (Email, Senha, IdTipoUsuario)
VALUES ('admin@admim.com', 'Senai@132', 1), ('jogador@jogador.com', 'Senai@132', 2);