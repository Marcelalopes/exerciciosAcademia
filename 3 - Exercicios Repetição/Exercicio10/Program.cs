//10.Ler nome, sexo e idade de 50 pessoas e após imprimir:
//Número de pessoas do sexo masculino.
//Número de pessoas do sexo feminino.
//Número de pessoas com idade inferior a 30 anos.
//Número de pessoas com idade superior a 60 anos.
//Média de idade das mulheres.

string nome;
char sexo;
int idade, qtdFem=0, qtdMas=0, qtdMenos30=0, qtdMais60=0, idadeMulheres=0;
double media;
for (int i = 0; i < 50; i++)
{
    Console.WriteLine("Diga seu nome, sexo e idade: ");
    nome = Console.ReadLine();
    sexo = char.Parse(Console.ReadLine());
    idade = int.Parse(Console.ReadLine());
    if (sexo == 'M')
    {
        qtdMas++;
    }
    else
    {
        qtdFem++;
        idadeMulheres += idadeMulheres;
    }
    if (idade < 30)
    {
        qtdMenos30++;
    }
    else if (idade > 60)
    {
         qtdMais60++;
    }
}
media = idadeMulheres / qtdFem;
Console.WriteLine($"Quantidade de homens: {qtdMas}\nQuantidade de mulheres: {qtdFem}\nQuantidade de pessoas com idade inferior a 30 anos: {qtdMenos30}\nQuantidade de pessoas com idade superior a 60 anos: {qtdMais60}\nIdade média das mulheres: {media}");