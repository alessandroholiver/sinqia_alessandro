ALTER PROCEDURE pr_incluir_convidado
(
@cpf varchar(11),
@idEvento int,
@nome varchar (50),
@telefone varchar (20),
@email varchar (50),
@status int output --0: Incluido --- 1: Alterado
) 
AS
BEGIN
  IF EXISTS (SELECT Cpf from TBConvidados 
WHERE Cpf = @Cpf)
    BEGIN
	 UPDATE TBConvidados SET IdEvento = @idEvento, Nome = @nome, Telefone =@telefone,
	 Email = @email WHERE Cpf = @cpf
	 SET @status = 1 
    END
ELSE
    BEGIN
	   INSERT INTO TBConvidados (Cpf, IdEvento, Nome, Email, Telefone)
	   VALUES (@cpf,@idEvento, @nome, @email, @telefone)
	   SET @status = 0 
    END

END


