//4.Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
//Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
//Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
//Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
//escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
//de votos em branco.

int votosJoao = 0, votosZeca = 0, votosBranco = 0;
string voto;

do
{
    Console.WriteLine("Digite o voto: ");
    voto = Console.ReadLine();
    if(voto == "JOAO")
    {
        votosJoao++;
    }
    else if(voto == "ZECA")
    {
        votosZeca++;
    }
    else if (voto == "BRANCO")
    {
        votosBranco++;
    }

} while (voto != "FIM");
Console.WriteLine($"Votos João: {votosJoao}\nVotosZeca: {votosZeca}\nVotos Branco: {votosBranco}");