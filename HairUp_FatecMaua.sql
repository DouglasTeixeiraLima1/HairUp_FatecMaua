CREATE TABLE CLIENTE(
	id_cliente		int NOT NULL IDENTITY(1,1),
	nome			varchar(100) NOT NULL,
	cpf				char(11) NOT NULL,
	celular			char(12) NOT NULL,
	email			varchar(60),

	CONSTRAINT PK_CLIENTE PRIMARY KEY(id_cliente)
);

insert into CLIENTE VALUES
('Douglas','12345678901','123456789012','dg123@gmail.com'),
('Gabriela','34567876566','13984456789','gabrielatsant@outlook.com'),
('Carlos','98765432100','11987654321','carlos@email.com'),
('Fernanda','12312312399','11991234567','fernanda@email.com'),
('Marcos','32132132188','11999887766','marcos@email.com'),
('Juliana','45645645677','11988776655','juliana@email.com'),
('Ricardo','65465465466','11977665544','ricardo@email.com'),
('Amanda','78978978955','11966554433','amanda@email.com'),
('Felipe','98798798744','11955443322','felipe@email.com'),
('Patricia','14725836900','11944332211','patricia@email.com'),
('Rafael','25836914700','11933221100','rafael@email.com'),
('Tatiane','36914725800','11922110099','tatiane@email.com');

/*--------------------------------------------------------------------------------*/
CREATE TABLE PROFISSIONAL (
	id_profissional		int NOT NULL IDENTITY(1,1),
	nome				varchar(100) NOT NULL,

	CONSTRAINT PK_Profissional PRIMARY KEY(id_profissional)
);

Insert into PROFISSIONAL VALUES
('Vivi Siqueira'),
('Romeu Felipe'),
('Celso Kamura'),
('Marco Antônio de Biaggi'),
('Mara Roszak'),
('Aura Friedman'),
('Gue Oliveira'),
('Jen Atkin'),
('Gabriel Fernandes Tavares'),
('Marisa Alves Cesar'),
('Juliana Cabelano'),
('Lucas Silvano');
/*--------------------------------------------------------------------------------*/
CREATE TABLE SERVICO (
	 id_servico		int NOT NULL IDENTITY(1,1),
	 nome_servico	varchar(100),
	 descricao		varchar(300),
	 Preco			decimal(10,2)

	 CONSTRAINT PK_Servico PRIMARY KEY (id_servico)
);


INSERT INTO SERVICO VALUES
('Corte de cabelo feminino','Corte personalizado conforme o tipo de rosto, textura e estilo desejado. Inclui lavagem e finalização.', 80),
('Coloração / Tintura','Aplicação de tinta para mudar ou realçar a cor natural dos fios. Inclui tonalização e secagem.', 100),
('Mechas / Luzes / Balayage', 'Técnicas de clareamento parcial dos fios para criar contraste e luminosidade.', 150),
('Hidratação / Nutrição Capilar','Tratamento para repor água e nutrientes dos fios, deixando o cabelo mais macio e brilhoso.', 60),
('Escova e Prancha','Secagem modelada e alisamento temporário dos fios com escova e chapinha.', 50),
('Penteado para festas','Produção de penteado elaborado (coque, trança, semi preso etc.) para eventos especiais.', 120),
('Manicure e Pedicure','Limpeza, corte, lixamento e esmaltação das unhas das mãos e dos pés.', 59.99),
('Design de Sobrancelhas','Modelagem e correção do formato das sobrancelhas com pinça, cera ou linha.', 35),
('Depilação Corporal (cera)','Remoção de pelos com cera quente ou fria (pernas, axilas, virilha, etc.).', 130),
('Maquiagem Profissional','Produção de maquiagem social ou para eventos, com produtos de alta fixação.', 290),
('Combo CSMP (Cabelo + Sobrancelha + Manicure + Pedicure)','Combo CSMP – Cuide-se da cabeça aos pés! Inclui corte e escova, design de sobrancelhas, manicure e pedicure completos. Um pacote prático e econômico para renovar seu visual com beleza e bem-estar.', 350);

/*--------------------------------------------------------------------------------*/
CREATE TABLE AGENDA(
	id_agenda		int	NOT NULL IDENTITY(1,1),
	id_cliente		int NOT NULL,
	id_servico		int NOT NULL,
	id_profissional int NOT NULL,
	data_agenda		date,
	hora			time,

	CONSTRAINT FK_Cliente FOREIGN KEY(id_cliente)
		REFERENCES Cliente(id_cliente),

	CONSTRAINT FK_Servico FOREIGN KEY(id_servico)
		REFERENCES Servico(id_servico),

	CONSTRAINT FK_PROFISSIONAL FOREIGN KEY(id_profissional)
		REFERENCES PROFISSIONAL(id_profissional)
);

INSERT INTO AGENDA VALUES
(2,1,1,'2025-11-01','14:30'),
(3,2,2,'2025-12-06','15:00'),
(4,3,3,'2026-01-14','10:00'),
(5,4,4,'2026-02-12','08:00'),
(6,5,5,'2026-02-15','21:00'),
(7,6,6,'2025-12-14','16:00'),
(8,7,7,'2026-05-17','12:00'),
(9,8,8,'2025-12-05','13:00'),
(10,9,9,'2026-03-02','12:00'),
(11,10,10,'2026-01-10','19:00'),
(12,11,11,'2025-12-30','15:00');
/*--------------------------------------------------------------------------------*/


