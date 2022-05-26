//9.Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
//o zoológico num determinado dia, imprimindo:
//Quantas pessoas tem entre 1 e 3 filhos.
//Quantas pessoas tem entre 4 e 7 filhos.
//Quantas pessoas tem mais de 8 filhos.
//Quantas pessoas não tem filhos.
int qtdFilhos = 0, entre1e3 = 0, entre4e7 = 0, maisDe8 = 0, naoTem = 0;
for (int i = 0; i < 30; i++) {
    Console.WriteLine("Quantos filhos você tem?");
    qtdFilhos = int.Parse(Console.ReadLine());
    if (qtdFilhos > 0 && qtdFilhos < 4)
    {
        entre1e3++;
    }
    else if (qtdFilhos > 3 && qtdFilhos < 8)
    {
        entre4e7++;
    }
    else if (qtdFilhos > 7)
    {
        maisDe8++;
    }
    else
    {
        naoTem++;
    }
}
Console.WriteLine($"Quantidade de pessoas que tem entre 1 e 3 filhos: {entre1e3}\nQuantidade de pessoas que tem entre 4 e 7 filhos: {entre4e7}" +
    $"\nQuantidade de pessoas que tem mais de 8 filhos: {maisDe8}\nQuantidade de pessoas que não tem filhos: {naoTem}");
