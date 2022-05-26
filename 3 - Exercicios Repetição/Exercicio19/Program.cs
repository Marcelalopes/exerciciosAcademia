// 19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, 
//coletando dados sobre o salário e número de filhos. A prefeitura deseja saber:  
//a) média do salário da população;
//b) média do número de filhos;
//c) maior salário;
//d) percentual de pessoas com salário até R$ 100,00.
//O final da leitura de dados se dará com a entrada de um salário negativo.
List<double> listSalario = new List<double>();
List<int> listFilhos = new List<int>();
double salario; int filhos;
double mediaSalario = 0, mediaFilhos = 0, maiorSalario = 0, percentual100;
do
{
    Console.WriteLine("Insira o salário do habitante: ");
    salario = double.Parse(Console.ReadLine());
    listSalario.Add(salario);

    Console.WriteLine("Insira o número de filhos: ");
    filhos = int.Parse(Console.ReadLine());
    listFilhos.Add(filhos);
} while (salario > 0);

for (int i = 0; i < listSalario.Count; i++)
{
    mediaSalario += listSalario[i];
}
mediaSalario /= listSalario.Count;
Console.WriteLine("Média do salário da população: "+mediaSalario);

for (int i = 0; i < listFilhos.Count; i++)
{
    mediaFilhos += listFilhos[i];
}
mediaFilhos /= listFilhos.Count;
Console.WriteLine("Média da quantidade de filhos da população: " + mediaFilhos);

for (int i = 0; i < listSalario.Count; i++)
{
    if (listSalario[i] > maiorSalario)
    {
        maiorSalario = listSalario[i];
    }    
}
Console.WriteLine("Maior Salário: "+maiorSalario);
int count=0;
for (int i = 0; i < listSalario.Count; i++)
{
    if (listSalario[i] <= 100)
    {
        count++;
    }
}
percentual100 = (count * 100)/listSalario.Count;
Console.WriteLine("Percentual de pessoas com salário até R$100,00: "+percentual100);