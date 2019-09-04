CREATE PROCEDURE pr_incluir_curso
(
@codigo int,
@idEscola int,
@descricao varchar (50),
@cargaHoraria int,
@preco float,
@status int output --0: Incluido --- 1: Alterado
) 
AS
BEGIN
  IF EXISTS (SELECT Codigo from TB_CURSOS 
WHERE Codigo = @codigo)
    BEGIN
	 UPDATE TB_CURSOS SET Codigo = @codigo, Descricao= @descricao, CargaHoraria =@cargaHoraria,
	 Preco = @preco WHERE Codigo = @codigo
	 SET @status = 1 
    END
ELSE
    BEGIN
	   INSERT INTO TB_Cursos (Codigo, IdEscola, Descricao, CargaHoraria, Preco)
	   VALUES (@codigo,@idEscola, @descricao, @cargaHoraria, @preco)
	   SET @status = 0 
    END

END

select * from TB_ESCOLAS
