use DB_EVENTOS

INSERT INTO TBEVENTOS (Descricao,Resposavel, Data, Preco)
VALUES 
('Palestra Javascript', 'Prof. Joao', '2019-08-12', 500), 
('C# para Todos', 'Prof. Alessandro', '2019-08-12', 800),
('HMTL/CSS', 'Prof. Carlos', '2019-08-12', 1500),
('PYTHON', 'Prof. Matias', '2019-08-12', 2000)


INSERT INTO TBEVENTOS (Descricao,Resposavel, Data, Preco)
SELECT Descricao,Responsavel, Data, Preco 
FROM TBEventosOld

 
 SELECT * FROM TBEventos



INSERT INTO TBConvidados(CPF, IdEvento, Nome, Telefone, Email)
VALUES 
('01566698705', 1, 'Alessandro Oliveira', '31 64646646', 'ale@ale.com'), 
('01565687525', 2, 'Jose Joao', '31 64646646', 'jose@jose.com'), 
('12054578895', 3, 'Maria Aparecida', '31 65455555', 'mariaap@ma.com'), 
('06598756602', 4, 'Lucia Castro', '31 45221846', 'lucia@lu.com'), 
('08978455585', 2, 'Mauro Castro', '31 45846456', 'mauro@mau.com'), 
('08978455584', 3, 'Mauro Carvalho', '31 45846456', 'mauro@mau.com'),
('98955855465', 4, 'Rita de Cassia', '31 33333333', 'rita@rita.com'),
('54855485481', 3, 'Carlos Magalahes', '31 54855525', 'carlos@md.br'), 
('01566698708', 4, 'Oliveira Bravo', '31 64646646', 'ale@ale.com'), 
('12054578898', 1, 'Maria Costa', '31 65455555', 'mariaap@ma.com')  

