--criando a tabela TB eventos, com chave primaria e auto incremento

CREATE TABLE TBEventos
(
Id int not null IDENTITY (1,1),
Descricao  varchar (100) not null,
Resposavel varchar (50) not null,
Data       datetime not null,
Preco      float not null,
PRIMARY KEY (Id)
);
go

CREATE TABLE TBConvidados
(
CPF      varchar (11)  not null,
IdEvento int not null , 
Nome     varchar (50) not null,
Telefone varchar (20) not null,
Email    varchar (60) not null,
PRIMARY KEY(CPF),
FOREIGN KEY (IdEvento) REFERENCES TBEventos (Id)
);
go
