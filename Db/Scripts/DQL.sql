USE SENAI_HROADS_MANHA

-- 06. Selecionar todos os personagens;
SELECT * FROM Personagens

-- 07. Selecionar todos as classes;
SELECT * FROM Classes

-- 08. Selecionar somente o nome das classes;
SELECT Nome FROM Classes;

-- 09. Selecionar todas as habilidades;
SELECT * FROM Habilidades

-- 10. Realizar a contagem de quantas habilidades estão cadastradas;
SELECT COUNT (IdHabilidade) FROM Habilidades

-- 11. Selecionar somente os id’s das habilidades classificando-os por ordem crescente;
SELECT IdHabilidade FROM Habilidades ORDER BY IdHabilidade

-- 12. Selecionar todos os tipos de habilidades;
SELECT * FROM TiposDeHabilidades

-- 13. Selecionar todas as habilidades e a quais tipos de habilidades elas fazem parte;
SELECT Habilidades.Nome AS 'Habilidade', TiposDeHabilidades.Nome AS 'Tipo Habilidade' FROM Habilidades
INNER JOIN TiposDeHabilidades
ON Habilidades.IdTipoDeHabilidade = TiposDeHabilidades.IdTipoHabilidade;

-- 14. Selecionar todos os personagens e suas respectivas classes;
SELECT Personagens.Nome AS 'Personagem', Classes.Nome AS 'Nome Classe' FROM Personagens
INNER JOIN Classes
ON Classes.IdClasse = Personagens.IdClasse;

-- 15. Selecionar todos os personagens e as classes (mesmo que elas não tenham correspondência em personagens);
SELECT Personagens.Nome AS 'Personagem', Classes.Nome AS 'Nome Classe' FROM Personagens
FULL OUTER JOIN Classes
ON Personagens.IdClasse = Classes.IdClasse;

-- 16. Selecionar todas as classes e suas respectivas habilidades;
SELECT Classes.Nome, Habilidades.Nome FROM ClassesHabilidades
LEFT JOIN Classes
ON ClassesHabilidades.IdClasse = Classes.IdClasse
LEFT JOIN Habilidades
ON ClassesHabilidades.IdHabilidade = Habilidades.IdHabilidade;

-- 17. Selecionar todas as habilidades e suas classes (somente as que possuem correspondência);
SELECT Habilidades.Nome as 'Nome da Habilidade', Classes.Nome as 'Nome da Classe' FROM ClassesHabilidades
RIGHT JOIN Classes
ON ClassesHabilidades.IdClasse = Classes.IdClasse
RIGHT JOIN Habilidades
ON ClassesHabilidades.IdHabilidade = Habilidades.IdHabilidade;

-- 18. Selecionar todas as habilidades e suas classes (mesmo que elas não tenham correspondência).
SELECT Habilidades.Nome as 'Nome da Habilidade', Classes.Nome as 'Nome da Classe' FROM ClassesHabilidades
FULL OUTER JOIN Classes
ON ClassesHabilidades.IdClasse = Classes.IdClasse
FULL OUTER JOIN Habilidades
ON ClassesHabilidades.IdHabilidade = Habilidades.IdHabilidade;