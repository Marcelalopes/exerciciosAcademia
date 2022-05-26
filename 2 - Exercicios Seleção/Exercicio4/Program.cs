// 4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por
// hora recebido por cada um deles. Mostrar na tela qual dos professores tem o maior salário total.

float qtd_hr1, val_hr1, qtd_hr2, val_hr2, sal1, sal2;

Console.WriteLine("Digite a quantidade de horas aula dadas pelo professor 1: ");
qtd_hr1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor por hora recebido pelo professor 1: ");
val_hr1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de horas aula dadas pelo professor 2: ");
qtd_hr2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor por hora recebido pelo professor 2: ");
val_hr2 = float.Parse(Console.ReadLine());

sal1 = qtd_hr1 * val_hr1;
sal2 = qtd_hr2 * val_hr2;

if (sal1 > sal2)
{
    Console.WriteLine("Professor 1 ganha mais que o professor 2");
}
else
{
    Console.WriteLine("Professor 2 ganha mais que o professor 1");
}
