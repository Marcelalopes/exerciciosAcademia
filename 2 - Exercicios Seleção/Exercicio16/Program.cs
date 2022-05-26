/*16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de 
 * fora tenha ganho o jogo por mais de 2 gols de diferença, mostre na tela uma mensagem indicando que o 
 * time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os 
 * dois times irão se enfrentar novamente em um novo jogo.
ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.*/


string placar;
Console.WriteLine("Digite o placar do jogo(0 x 0): ");
placar = Console.ReadLine();

string[] splitar = placar.Split(" ");
int golsTimeCasa = int.Parse(splitar[0]);
int golsTimeFora = int.Parse(splitar[3]);

if (golsTimeFora - golsTimeCasa >= 2)
{
    Console.WriteLine("Time fora está classificado para a próxima fase!");
}
else
{
    Console.WriteLine("Os times irão se enfrentar novamente em um jogo!");
}