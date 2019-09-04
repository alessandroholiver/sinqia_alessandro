CREATE PROCEDURE pr_incluir_convidado
(
@cpf varchar(11),
@idEvento int,
@nome varchar (50),
@telefone varchar (20),
@email varchar (50)
) 
AS
BEGIN
  IF EXISTS (SELECT Cpf from TBConvidados 
WHERE Cpf = @Cpf)
    BEGIN
	 UPDATE TBConvidados SET IdEvento = @idEvento, Nome = @nome, Telefone =@telefone,
	 Email = @email WHERE Cpf = @cpf 
    END
ELSE
    BEGIN
	   INSERT INTO TBConvidados (Cpf, IdEvento, Nome, Email, Telefone)
	   VALUES (@cpf,@idEvento, @nome, @email, @telefone)
    END

END


exec pr_incluir_convidado '01565687525',4, 'Carlos Antonio', '314566548','teste@teste' 