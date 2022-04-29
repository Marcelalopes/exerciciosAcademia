/*
 * 10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
notas de menor valor fossem distribuídas em número mínimo possível. 
Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, 
três notas de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
de acordo com o critério da “distribuição ótima”.
*/

Console.WriteLine("Valor a ser sacado");
int valor = int.Parse(Console.ReadLine());

int resto, qtdNota100, qtdNota50, qtdNota20, qtdNota10, qtdNota5,qtdNota2;

qtdNota100 = valor / 100;
resto = valor % 100;
qtdNota50 = resto / 50;
resto = resto % 50;
qtdNota20 = resto / 20;
resto %= 20;
qtdNota10 = resto / 10;
resto %= 10;
qtdNota5 = resto / 5;
resto %= 5;
qtdNota2 = resto / 2;
resto %= 2;

Console.WriteLine("Quantidade de notas de 100: "+qtdNota100
    +"\nQuantidade de notas de 50: "+qtdNota50
    +"\nQuantidade de notas de 20: "+qtdNota20
    +"\nQuantidade de notas de 10: "+qtdNota10
    +"\nQuantidade de notas de 5: "+qtdNota5
    +"\nQuantidade de notas de 2: "+qtdNota2);