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

int qtdNota100 = 0; int qtdNota50 = 0; int qtdNota20 = 0; int qtdNota10 = 0;int qtdNota5 = 0; int qtdNota2 = 0;

if(valor >= 100)
{
    do
    {
        qtdNota100 ++;
    } while ((valor - (qtdNota100 * 100)) <= 100);
}
int acumulativo = qtdNota100 * 100;
if (valor - acumulativo != 0)
{
    do
    {
        qtdNota50++;
    } while ((valor - (qtdNota50 * 50)) <= 50);
}
acumulativo += qtdNota50 * 50;
if (valor - acumulativo != 0)
{
    do
    {
        qtdNota20++;
    } while ((valor - (qtdNota20 * 20)) <= 20);
}
acumulativo += qtdNota20 * 20;
if (valor - acumulativo != 0)
{
    do
    {
        qtdNota10++;
    } while ((valor - (qtdNota10 * 10)) <= 10);
}
acumulativo += qtdNota10 * 10;
if (valor - acumulativo != 0)
{
    do
    {
        qtdNota5++;
    } while ((valor - (qtdNota5 * 5)) <= 5);
}
acumulativo += qtdNota5 * 5;
if (valor - acumulativo != 0)
{
    do
    {
        qtdNota2++;
    } while ((valor - (qtdNota2 * 2)) <= 2);
}

Console.WriteLine("Quantidade de notas de 100: "+qtdNota100
    +"\nQuantidade de notas de 50: "+qtdNota50
    +"\nQuantidade de notas de 20: "+qtdNota20
    +"\nQuantidade de notas de 10: "+qtdNota10
    +"\nQuantidade de notas de 5: "+qtdNota5
    +"\nQuantidade de notas de 2: "+qtdNota2);