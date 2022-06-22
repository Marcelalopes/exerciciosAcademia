/* 
    NetEmpresta possui ao redor de 200.000 filmes (filmes, documentários, animes, ..), cujo empréstimo deve ser controlado.

    Cada filme/documentario/anime possui um número. 
    Para cada filme, é necessário saber seu título e sua categoria (comédia, drama, aventura, ...).
    Cada filme recebe um identificador próprio. 

    Os clientes podem desejar encontrar os filmes estrelados pelo seu ator predileto. 
    Por isso, é necessário manter a informação dos atores que estrelam em cada filme. 
    Nem todo filme possui estrelas. Para cada ator os clientes às vezes desejam saber o nome real, 
    bem como a data de nascimento.

    A NetEmpresa possui muitos clientes cadastrados. 
    Somente clientes cadastrados podem alugar filmes. 
    Para cada cliente é necessário saber seu pré-nome e seu sobrenome, seu telefone e seu endereço. 
    Além disso, cada cliente recebe um número de associado.
    Finalmente, desejamos saber que filmes cada cliente tem alugados. 
    Um cliente pode ter vários empréstimos em um instante no tempo. 

    Nota: são mantidos registros históricos de aluguéis.

    A partir desse relato construa:
    - modelo lógico

    Indicando entidades, atributos, relacionamentos, cardinalidades


    Categoria(codCategoria, descricao, ativo). 
        codCategoria chave primaria

    Ator(codAtor, apelido, nome, dataNascimento, ativo).
        codAtor chave primária

    Filme(codFilme, titulo, codCategoria, codAtor ativo). 
        codFilme chave primária
        codAtor referencia Ator

    Cliente(codCliente, prenome, sobrenome, telefone, endereco, ativo).
        codCliente chave primaria

    Aluguel(codFilme, codCliente, data, hota).
        codFilme, codCliente, data e hora formam chave primária
        codFilme referencia Filme
        codCliente referencia Cliente 
*/

// Categoria 1..n ----- 0..n Filmes
// Filmes 1..n ----- 0..n Ator
// Aluguel 0..n ----- 1..1 Filme
// Aluguel 0..n ----- 1..1 Cliente

using System;
using System.Collections.Generic;

public class Categoria{
    int codCategoria; //primary key
    string descricao;
    bool ativo;
}
public class CategoriaFilme{   
    Categoria codCategoria;
    Filme codFilme;
}
public class Filme {
    int cod; //primary key
    string titulo;
    bool ativo;
}
public class FilmeAtor {
    Ator codAtor;
    Filme codFilme;
}

public class Ator {
    int codAtor; //primary key
    string apelido;
    string nome;
    DateTime dataNascimento;
    bool ativo;
}

public class Cliente{
    int codAssociado; //primary key
    string prenome;
    string sobrenome;
    string telefone;
    string endereco;
    bool ativo;
    
}
public class Aluguel{
    Filme codFilm;
    Cliente codCliente;
    DateTime dataHora;
}