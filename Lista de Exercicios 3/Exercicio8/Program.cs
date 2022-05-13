//8.Faça um programa em VS que solicite um numero inteiro. Se o numero não for inteiro, solicite-o até q
//ue seja. após, informe se ele é par ou impar. 
//Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.

int num;
char op;
do
{
    do
    {
        Console.WriteLine("Digite um número: ");
        num = int.Parse(Console.ReadLine());
    } while (num < 0);
    if (num%2==0)
    {
        Console.WriteLine("Número par!");
    }
    else
    {
        Console.WriteLine("Número impar!");
    }
    Console.WriteLine("Você que digitar outro número? (S/N)");
    op = char.Parse(Console.ReadLine());
} while (op != 'N');
