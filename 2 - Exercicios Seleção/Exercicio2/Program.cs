// 2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar.

int num;
Console.WriteLine("Digite um número inteiro qualquer: ");
num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("O número é par");
}
else if (num % 2 == 1)
{
    Console.WriteLine("O número é impar");
}