--Exercicio 1
SELECT Descricao, Preco 
FROM TBEventos WHERE Preco BETWEEN 500 and 1000 

--Exercicio 2 (Correto)
SELECT C.Nome, C.Email, E.Descricao 
FROM TBConvidados C, TBEventos E
WHERE E.Preco = 0 AND  E.Id = C.IdEvento

--Exercicio 3
SELECT E.Descricao AS EVENTOS,
COUNT (C.Nome) AS Convidados 
FROM TBConvidados C, TBEventos E
WHERE E.Id =C.IdEvento
GROUP BY E.Descricao
 
 
--Exercicio 4
SELECT E.Descricao AS EVENTOS,
SUM (E.Preco) AS  Total
FROM TBConvidados C, TBEventos E
WHERE E.Id =C.IdEvento
GROUP BY E.Descricao




SELECT * From TBEventos
SELECT * FROM TBConvidados