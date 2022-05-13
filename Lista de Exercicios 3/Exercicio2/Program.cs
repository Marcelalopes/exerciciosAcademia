//2.Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
//informar um outro número. Caso positivo, o programa em VS deve ser repetido.

int num;
char op;
do
{
    do
    {
        Console.WriteLine("Digite um número inteiro positivo: ");
        num = int.Parse(Console.ReadLine());
        if (num < 0)
        {
            Console.WriteLine("Valor incorreto!");
        }
    } while (num < 0);

    Console.WriteLine("Número digitado: " + num);
    Console.Write("Números inteiros pares entre 1 e " + num + ": ");
    for (int i = 1; i < num; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
    }
    Console.WriteLine("\nVocê deseja digitar o novo número? (S/N)");
    op = char.Parse(Console.ReadLine());
} while (op != 'N');