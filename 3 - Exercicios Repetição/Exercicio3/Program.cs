//3.Fazer um laço(repetição) que fique solicitando números ao usuário. 
//Se o usuário digitar 0 o programa em VS deve parar. 
//Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.
int num, div=0;
do
{
    Console.WriteLine("Digite um número: ");
    num = int.Parse(Console.ReadLine());
    if (num % 2 == 0)
    {
        Console.WriteLine("O número é par!");
    }
    else
    {
        Console.WriteLine("O número é impar!");
    }
    for (int i = 1; i < num; i++)
    {
        if (num%i == 0)
        {
            div++;
        }
    }
    if (div == 2)
    {
        Console.WriteLine("O número é primo!");
    }
    else
    {
        Console.WriteLine("O número não é primo!");
    }
} while (num != 0);