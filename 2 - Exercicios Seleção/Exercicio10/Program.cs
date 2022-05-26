/* 10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
*O programa deve mostrar os dados do atleta mais novo e mais alto.
*/

string nome1, nome2;
int idade1, idade2;
float altura1, altura2;

Console.WriteLine("Atleta 1");
Console.WriteLine("Nome: ");
nome1 = Console.ReadLine();
Console.WriteLine("Idade: ");
idade1 = int.Parse(Console.ReadLine());
Console.WriteLine("Altura: ");
altura1 = float.Parse(Console.ReadLine());

Console.WriteLine("Atleta 2");
Console.WriteLine("Nome: ");
nome2 = Console.ReadLine();
Console.WriteLine("Idade: ");
idade2 = int.Parse(Console.ReadLine());
Console.WriteLine("Altura: ");
altura2 = float.Parse(Console.ReadLine());

if (altura1 > altura2 && idade1 < idade2)
{
    Console.WriteLine("Nome: "+nome1+"\nIdade: "+idade1+"\nAltura: "+altura1);
}
else if (altura2 > altura1 && idade2 < idade1)
{
    Console.WriteLine("Nome: " + nome2 + "\nIdade: " + idade2 + "\nAltura: " + altura2);
}
else
{
    Console.WriteLine("Nenhum dos atletas é o mais alto e ao mesmo tempo o mais novo");
}