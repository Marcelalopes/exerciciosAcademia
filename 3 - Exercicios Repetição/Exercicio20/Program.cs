/* 20.Foi realizada uma pesquisa de algumas características físicas da população de uma 
certa região, a qual coletou os seguintes dados referentes a cada habitante para 
serem analisados:
-sexo(masculino e feminino)
- cor dos olhos(azuis, verdes ou castanhos)
-cor dos cabelos(louros, castanhos, pretos)
-idade


Faça um algoritmo que determine e escreva: 
 
-a maior idade dos habitantes
- a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
e que tenham olhos verdes e cabelos louros.
O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade. */
List<char> listSexo = new List<char>();
List<string> listOlhos = new List<string>();
List<string> listCabelo = new List<string>();
List<int> listIdade = new List<int>(); int idade;
int maiorIdade = 0, qtdMulheres = 0;

do
{
    Console.WriteLine("Sexo: ");
    listSexo.Add(char.Parse(Console.ReadLine()));

    Console.WriteLine("Cor dos olhos: ");
    listOlhos.Add(Console.ReadLine());

    Console.WriteLine("Cor do cabelo: ");
    listCabelo.Add(Console.ReadLine());

    Console.WriteLine("Idade: ");
    idade = int.Parse(Console.ReadLine());
    listIdade.Add(idade);
} while (idade != -1);

for (int i = 0; i < listIdade.Count; i++)
{
    if (listIdade[i] > maiorIdade)
    {
        maiorIdade = listIdade[i];
    }
}
Console.WriteLine("Maior idade dos habitantes: "+maiorIdade);

for (int i = 0; i < listSexo.Count; i++)
{
    if (listSexo[i] == 'F' || listSexo[i] == 'f')
    {
        if (listIdade[i] >= 18 && listIdade[i] <= 35)
        {
            if (listOlhos[i] == "verdes" && listCabelo[i] == "louros")
            {
                qtdMulheres++;
            }
        }
    }
}
Console.WriteLine("quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive e que tenham olhos verdes e cabelos louros: "+qtdMulheres);