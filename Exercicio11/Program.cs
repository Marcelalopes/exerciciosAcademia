/*
 * 11) Escreva um algoritmo para ler o número de eleitores de um município, o número de votos brancos, nulos 
 * e válidos. Calcule e escreva o percentual que cada um representa em relação ao total de eleitores.
*/

Console.WriteLine("Digite o número de eleitores do município");
int qtdEleitores = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de votos branco");
int qtdVotosBrancos = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de votos nulos");
int qtdVotosNulos = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de votos válidos");
int qtdVotosValidos = int.Parse(Console.ReadLine());

double percent_branco = (qtdVotosBrancos * 100) / qtdEleitores;
double percent_nulo = (qtdVotosNulos * 100) / qtdEleitores;
double percent_valido = (qtdVotosValidos * 100) / qtdEleitores;

Console.WriteLine("Total de Eleitores: "+qtdEleitores
    +"\nPercentual de votos nulos: "+percent_nulo + "%"
    + "\nPercentual de votos brancos: "+percent_branco + "%"
    + "\nPercentual de votos válidos: "+percent_valido+"%");