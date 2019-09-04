--listando todos os cursos de todas as escolas

SELECT E.Descricao As Curso, A.Descricao AS Faculdade,E.Preco
FROM TB_ESCOLAS A, TB_CURSOS E 
WHERE E.IdEscola = A.Id ORDER BY Preco

SELECT 
 E.Descricao AS Escola,
 E.Telefone AS Telefone,
 Count(C.Descricao) AS Cursos,
 Sum(C.Preco)
FROM
  TB_Escolas E, TB_Cursos C
WHERE
   E.Id = C.IdEscola 
GROUP BY
   E.Descricao, E.Telefone