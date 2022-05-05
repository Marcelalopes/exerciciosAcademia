// 3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela
// os que são superiores à média.

int num1, num2, num3, num4;
double media;

Console.WriteLine("Digite 4 números inteiros: ");
num1 = int.Parse(Console.ReadLine());
num2 = int.Parse(Console.ReadLine());
num3 = int.Parse(Console.ReadLine());
num4 = int.Parse(Console.ReadLine());

media = (num1 + num2 + num3 + num4)/4;
Console.WriteLine("Média = "+media);

if (num1 > media)
{
    Console.WriteLine("Número 1 é maior que a média");
}
if (num2 > media)
{
    Console.WriteLine("Número 2 é maior que a média");
}
if (num3 > media)
{
    Console.WriteLine("Número 3 é maior que a média");
}
if (num4 > media)
{
    Console.WriteLine("Número 4 é maior que a média");
}