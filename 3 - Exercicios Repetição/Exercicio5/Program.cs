//5.Modifique o programa em VS anterior para aceitar votos nulos 
//(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
//Ao final, informe o nome do candidato vencedor, o número de votos nulos e o número de pessoas que votaram.

int votosJoao = 0, votosZeca = 0, votosBranco = 0, votosNulo = 0;
string voto;

do
{
    Console.WriteLine("Digite o voto: ");
    voto = Console.ReadLine();
    if (voto == "JOAO")
    {
        votosJoao++;
    }
    else if (voto == "ZECA")
    {
        votosZeca++;
    }
    else if (voto == "BRANCO")
    {
        votosBranco++;
    }
    else
    {
        votosNulo++;
    }
} while (voto != "FIM");
if (votosJoao > votosZeca)
{
    Console.WriteLine($"O candidato João venceu!\nQuantidade de votos: {votosJoao}\nQuantidade de nulos: {votosNulo}");
}
if (votosZeca > votosJoao)
{
    Console.WriteLine($"O candidato Zeca venceu!\nQuantidade de votos: {votosZeca}\nQuantidade de nulos: {votosNulo}");
}
