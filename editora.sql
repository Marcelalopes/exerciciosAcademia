use editora_db;

CREATE TABLE Autor (
	idAutor INT NOT NULL,
	nome VARCHAR(45) NOT NULL,
	
	PRIMARY KEY (idAutor)
);

CREATE TABLE Editora (
  idEditora INT NOT NULL,
  nome VARCHAR(45) NOT NULL,
  
  PRIMARY KEY (idEditora)
);

CREATE TABLE Genero (
  idGenero INT NOT NULL,
  descricao VARCHAR(45) NOT NULL,
  
  PRIMARY KEY (idGenero)
);

CREATE TABLE Livro (
  idLivro INT NOT NULL,
  titulo VARCHAR(45) NOT NULL,
  preco DECIMAL(3) NULL,
  idEditora INT NOT NULL,
  idGenero INT NOT NULL,

  PRIMARY KEY (idLivro),

  INDEX fk_Livro_Editora_idx (idEditora ASC),
  INDEX fk_Livro_Genero_idx (idGenero ASC),

  CONSTRAINT fk_Livro_Editora
    FOREIGN KEY (idEditora)
    REFERENCES Editora (idEditora)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,

  CONSTRAINT fk_Livro_Genero
    FOREIGN KEY (idGenero)
    REFERENCES Genero (idGenero)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);

CREATE TABLE Livro_Autor (
  idAutor INT NOT NULL,
  idLivro INT NOT NULL,
  
  PRIMARY KEY (idAutor, idLivro),
  INDEX fk_Autor_has_Livro_Livro_idx (idLivro ASC),
  INDEX fk_Autor_has_Livro_Autor_idx (idAutor ASC),
  
  CONSTRAINT fk_Autor_has_Livro_Autor
    FOREIGN KEY (idAutor)
    REFERENCES Autor (idAutor)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,

  CONSTRAINT fk_Autor_has_Livro_Livro
    FOREIGN KEY (idLivro)
    REFERENCES Livro (idLivro)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);

CREATE TABLE Ranking (
  idRanking INT NOT NULL,
  dataInicial DATE NOT NULL,
  dataFinal DATE NOT NULL,
  
  PRIMARY KEY (idRanking)
);

CREATE TABLE Ranking_Semanal (
  idRanking INT NOT NULL,
  idLivro INT NOT NULL,
  posicao DECIMAL(2) NULL,
  quantidadeSemanas DECIMAL(2) NULL,
  semanasConsecutivas DECIMAL(2) NULL,
  posicaoSemanaAnterior DECIMAL(2) NULL,
  
  PRIMARY KEY (idRanking, idLivro),
  INDEX fk_Ranking_has_Livro_Livro_idx (idLivro ASC),
  INDEX fk_Ranking_has_Livro_Ranking_idx (idRanking ASC),
  
  CONSTRAINT fk_Ranking_has_Livro_Ranking
    FOREIGN KEY (idRanking)
    REFERENCES Ranking (idRanking)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  
  CONSTRAINT fk_Ranking_has_Livro_Livro
    FOREIGN KEY (idLivro)
    REFERENCES Livro (idLivro)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);

insert into Genero values (1, 'Infantil');
insert into Genero values (2, 'Ficção');
insert into Genero values (3, 'Romance');
insert into Genero values (4, 'Auto-ajuda');
insert into Genero values (5, 'Negócios');
insert into Genero values (6, 'História');

select * from Genero;

insert into Editora values (1, 'Ática');
insert into Editora values (2, 'Makron Books');
insert into Editora values (3, 'Rocco');
insert into Editora values (4, 'Scipione');
insert into Editora values (5, 'Sagra Luzato');

select * from Editora;

insert into Autor values (1, 'Pedro');
insert into Autor values (2, 'Marcos');
insert into Autor values (3, 'Felipe');
insert into Autor values (4, 'Ana');
insert into Autor values (5, 'Maria');
insert into Autor values (6, 'Francisco');
insert into Autor values (7, 'Lucas');

select * from Autor;

insert into Livro values (1, 'A', 25.30, 1, 1);
insert into Livro values (2, 'B', 32.45, 1, 4);
insert into Livro values (3, 'C', 122.00, 4, 2);
insert into Livro values (4, 'D', 100.99, 4, 3);
insert into Livro values (5, 'E', 16.16, 1, 5);
insert into Livro values (6, 'F', 4.56, 3, 1);
insert into Livro values (7, 'G', 85.20, 2, 5);
insert into Livro values (8, 'H', 89.90, 5, 5);
insert into Livro values (9, 'I', 63.36, 2, 2);
insert into Livro values (10, 'J', 41.40, 3, 3);
insert into Livro values (11, 'K', 200.30, 4, 6);
insert into Livro values (12, 'L', 99.99, 2, 4);

select * from Livro;

insert into Livro_Autor values (1, 1);
insert into Livro_Autor values (6, 1);
insert into Livro_Autor values (6, 2);
insert into Livro_Autor values (5, 3);
insert into Livro_Autor values (1, 3);
insert into Livro_Autor values (4, 3);
insert into Livro_Autor values (4, 4);
insert into Livro_Autor values (1, 5);
insert into Livro_Autor values (5, 6);
insert into Livro_Autor values (3, 6);
insert into Livro_Autor values (3, 7);
insert into Livro_Autor values (2, 8);
insert into Livro_Autor values (6, 9);
insert into Livro_Autor values (6, 10);
insert into Livro_Autor values (1, 10);
insert into Livro_Autor values (2, 11);
insert into Livro_Autor values (2, 12);

select * from Livro_Autor;

insert into Ranking values (1, '20030817', '20030823');
insert into Ranking values (2, '20030824', '20030830');
insert into Ranking values (3, '20030831', '20030906');
insert into Ranking values (4, '20030907', '20030913');

select * from Ranking;

insert into Ranking_Semanal values (1,1,4,6,3,3);
insert into Ranking_Semanal values (2,1,5,7,3,4);
insert into Ranking_Semanal values (3,2,1,1,1,null);
insert into Ranking_Semanal values (4,2,1,2,2,1);
insert into Ranking_Semanal values (1,3,2,2,2,null);
insert into Ranking_Semanal values (2,3,2,3,3,2);
insert into Ranking_Semanal values (3,3,8,4,4,2);
insert into Ranking_Semanal values (4,3,10,5,5,8);
insert into Ranking_Semanal values (1,4,1,50,43,1);
insert into Ranking_Semanal values (2,5,1,1,1,null);
insert into Ranking_Semanal values (3,5,2,2,2,1);
insert into Ranking_Semanal values (4,5,9,3,3,2);
insert into Ranking_Semanal values (4,6,8,1,1,null);
insert into Ranking_Semanal values (3,7,5,1,1,null);
insert into Ranking_Semanal values (4,7,5,2,2,5);
insert into Ranking_Semanal values (1,8, 3,13,12,6);
insert into Ranking_Semanal values (2,8, 3, 14,13,3);
insert into Ranking_Semanal values (3,8,3,15,14,3);
insert into Ranking_Semanal values (4,8,4,16,15,3);
insert into Ranking_Semanal values (2,9,7,1,1,null);
insert into Ranking_Semanal values (3,9,7,2,2,7);
insert into Ranking_Semanal values (1,10,8,4,4,10);
insert into Ranking_Semanal values (2,10,9,5,5,8);
insert into Ranking_Semanal values (3,11,9,1,1,null);
insert into Ranking_Semanal values (1,12,6,3,2,6);

select * from Ranking_Semanal;

-- i. Mostre todos os autores cadastrados
select * from Autor;

-- ii.Mostre apenas os nomes dos autores
select nome from Autor;

-- iii.Mostre o nome e a identificação do autor, nesta ordem
select nome, idAutor from Autor;

-- iv.Mostre o nome dos autores que aparecem na tabela Livro_Autor
select a.nome from Autor as a, Livro_Autor as la where la.idAutor = a.idAutor;

-- v.Mostre o nome dos autores, sem repetição, presentes na tabela Livro_Autor
select distinct(Autor.nome) from Autor, Livro_Autor where Autor.idAutor = Livro_Autor.idAutor;

-- vi.Mostre os autores em ordem alfabética
select distinct(Autor.nome) from Autor, Livro_Autor where Autor.idAutor = Livro_Autor.idAutor order by Autor.nome;

-- vii.Mostre o título dos livros que são da editora Rocco ou da editora Scipione
select Livro.titulo from Livro, Editora where Editora.nome = 'Rocco' or Editora.nome = 'Scipione';

-- viii.Mostre, em ordem alfabética, os autores que começam com M
select nome from Autor where nome like 'M%' order by nome;

-- ix.Mostre, em ordem alfabética, os autores que começam com L
select nome from Autor where nome like 'L%' order by nome;

-- x.Mostre, em ordem alfabética, os autores que NÃO começam com L
select nome from Autor where nome not like 'L%' order by nome;

-- xi.Mostre, em qualquer ordem, os autores que não começam com M 
select nome from Autor where nome not like 'M%';

-- xii.Liste apenas os livros das editoras 1 OU 5
select * from Livro where idEditora = 1 or idEditora = 5;

-- xiii.Mostre os livros infantis das editoras 1 e 5
select * from Livro where (idEditora = 1 or idEditora = 5) and idGenero = 1;

-- xiv.Mostre os códigos e os títulos dos livros, com seus respectivos preços;
select idLivro, titulo, preco from Livro;

-- xv.Mostre os autores em ordem contrária à alfabética;
select * from Autor order by nome desc;

-- xvi.Liste os livros, na ordem de preços do mais caro ao mais barato;
select * from Livro order by preco;

-- xvii.Liste os livros, na ordem de preços do mais barato ao mais caro;
select * from Livro order by preco desc;

-- xviii.Mostre apenas os livros de auto-ajuda, na ordem crescente de preço; 
select * from Livro where idGenero = 4 order by preco;

-- xix.Mostre quantos autores estão cadastros;
select count(*) as quantidadeDeAutores from Autor;

-- xx.Mostre os preços dos livros mais baratos e mais caros da editora 1; 
select max(preco) as livroMaisCaro, min(preco) as livroMaisBarato from Livro where Livro.idEditora = 1;

-- xxi.Liste a média de preços dos livros da editora 2;
select avg(preco) as mediaPreco from Livro where idEditora = 2;

-- xxii.Mostre os livros com seus respectivos nomes de editoras e gêneros;
select Livro.titulo as Livro, Editora.nome as Editora, Genero.descricao as Genero from Livro, Editora, Genero where Livro.idEditora = Editora.idEditora and Livro.idGenero = Genero.idGenero;

-- xxiii.Liste os livros, mostrando o titulo de cada um bem como o nome do autor;
select Livro.titulo as Livro, Autor.nome as Autor from Livro, Autor, Livro_Autor where Livro.idLivro = Livro_Autor.idLivro and Autor.idAutor = Livro_Autor.idAutor;

-- xxiv.Mostre o título do livro que ficou o maior número de semanas consecutivas em 1o lugar;
SELECT Livro.titulo, Ranking_semanal.posicao, Ranking_semanal.semanasConsecutivas FROM Livro, Ranking_semanal WHERE semanasConsecutivas = (SELECT max(semanasConsecutivas) FROM Ranking_semanal WHERE posicao = 1) AND Livro.idLivro = Ranking_semanal.idLivro;

-- xxv.Mostre o nome dos autores dos livros que estavam no ranking da semana de 24/08/2003 a 30/08/2003;
select distinct Autor.nome as autor 
from Livro, Autor, Livro_Autor, Ranking, Ranking_Semanal 
where Livro_Autor.idAutor=Autor.idAutor and 
      Livro_Autor.idLivro=Livro.idLivro and 
      Ranking_Semanal.idRanking = Ranking.idRanking and 
      Ranking_Semanal.idLivro=Livro.idLivro and Ranking.idRanking=2;