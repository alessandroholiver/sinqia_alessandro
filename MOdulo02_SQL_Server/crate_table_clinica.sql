--Alessandro Oliveira
--Alessandro, seu CHECK está com operador incorreto. Vou corrigir pra voce


CREATE TABLE TBConvenio
(
Id  int IDENTITY (1,1)not null PRIMARY KEY,
Nome varchar (60) not null,
);
go

CREATE TABLE TBProcedimento
(
CID  varchar (11) not null PRIMARY KEY,
Nome varchar (60) not null,
Descricao varchar (100) not null,
Preco decimal not null,
Id int not null,
);
go


CREATE TABLE TBMatMed
(
 Id  int IDENTITY not null PRIMARY KEY,
 Nome varchar (60) not null,
 Preco decimal not null,
 Descricao varchar (100) not null

)

CREATE TABLE TBMedicamento
(
 Id  int IDENTITY not null PRIMARY KEY,
 Nome varchar (60) not null,
 Preco decimal not null,
 Descricao varchar (100) not null

)

CREATE TABLE TBPaciente
(
Cpf  varchar (11) not null PRIMARY KEY,
Nome varchar (60) not null,
DtNascimento datetime not null,
Telefone varchar (20) not null,
Endereco varchar (60) not null,
IdConvenio int not null,
Email varchar (60) not null,
FOREIGN KEY (IdConvenio) REFERENCES TBConvenio (Id)
);
go

CREATE TABLE TBMedico
(
CRM  varchar (11) not null PRIMARY KEY,
Nome varchar (60) not null,
Telefone varchar (20) not null,
Especialidade varchar (20) not null,
);
go



CREATE TABLE TBMatMed
(

Id int PRIMARY KEY IDENTITY not null,
Descricao varchar(50) not null ,
PrecoUnitario float not null,
Unidade varchar(5) not null,
Categoria INT not null CHECK (Categoria=1 OR Categoria=2) --aqui funciona como uma restrição do proprio sql
);
go

CREATE TABLE TBConsulta
( 
Cod  int IDENTITY (1,1)not null PRIMARY KEY,
IdPaciente varchar (11) not null,
IdConvenio int not null,
Data datetime not null,
IdProcedimento varchar (11) not null,
IdMedico varchar (11) not null,
Preco decimal not null

FOREIGN KEY (IdPaciente) REFERENCES TBPaciente (Cpf),
FOREIGN KEY (IdConvenio) REFERENCES TBConvenio (Id),
FOREIGN KEY (IdProcedimento) REFERENCES TBProcedimento (CID),
FOREIGN KEY (IdMedico) REFERENCES TBMedico (CRM),
--Muito obrigado, eu nao estava enxergando que era o sinal de atribuição no check

)

