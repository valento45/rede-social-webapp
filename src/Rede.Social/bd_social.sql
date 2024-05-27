CREATE DATABASE bd_social
    WITH
    OWNER = postgres
    ENCODING = 'UTF8'
    CONNECTION LIMIT = -1
    IS_TEMPLATE = False;
	
	
	create table pessoa_tb(
		IdPessoa serial not null primary key,
		Nome varchar(300) not null,
		RG varchar(50),
		DataNascimento timestamp not null,
		EstadoCivil varchar(100),
		CEP varchar(30),
		Logradouro varchar(300),
		Numero integer,
		Cidade varchar(100),
		UF varchar(5),
		Pais varchar(50)		
	);
	
	create table usuario_tb(
		IdUsuario serial not null primary key,
		IdPessoa integer not null,
		Email varchar(200) not null,
		Senha varchar not null,
		AutenticaDoisFatores boolean,
		Celular varchar(50),
		Verificado boolean,
		CONSTRAINT id_pessoa_fk foreign key(IdPessoa)
		references pessoa_tb(IdPessoa)
	
	);
	
	insert into pessoa_tb (Nome, DataNascimento) values ('teste', to_timestamp('10/10/2000', 'dd/MM/yyyy'))
	select * from pessoa_tb
	
	insert into usuario_tb (IdPessoa, Email, Senha) values (1, 'teste', 'teste')