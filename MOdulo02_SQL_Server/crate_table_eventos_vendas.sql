--criando a tabela TB eventos, com chave primaria e auto incremento
--Alessandro Oliveira
CREATE TABLE TBClientes
(
Documento  varchar (14) not null PRIMARY KEY,
Nome varchar (60) not null,
Telefone varchar (20) not null,
Email varchar (60) not null
);
go

CREATE TABLE TBPedidos
(
Id int not null IDENTITY (1,1) PRIMARY KEY,
DocCliente varchar (14),
Data dateTime not null,
NumeroPedido  varchar (20) not null,
FOREIGN KEY (DocCliente) REFERENCES TBClientes(Documento)
);
go


CREATE TABLE TBItens
(
Id int not null IDENTITY (1,1) PRIMARY KEY,
IdPedido int not null,
IdProduto int not null,
Quantidade float not null,
FOREIGN KEY (IdPedido) REFERENCES TBPedidos(Id),
FOREIGN KEY (IdProduto) REFERENCES TBProdutos(Id)
);
go

CREATE TABLE TBProdutos
(
Id int not null IDENTITY (1,1) PRIMARY KEY,
IdCategoria int not null,
Descricao varchar (50) not null,
Unidade  varchar (10) not null,
Foto varbinary (MAX),
MimeType varchar (20)
FOREIGN KEY (IdCategoria) REFERENCES TBCategorias(Id)
);
go

CREATE TABLE TBCategorias
(
Id int not null IDENTITY (1,1) PRIMARY KEY,
Descricao varchar (20),
);
go

