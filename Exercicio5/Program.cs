/*
 * 5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel
 * (medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
 * consumido para percorrê-la (medido em l).
*/

float combustivel, distancia, consumo;

Console.WriteLine("Digite a distância total percorrida pelo automóvel em Km: ");
distancia = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade em litro do combustível no ponto inicial: ");
combustivel = float.Parse(Console.ReadLine());

consumo = distancia / combustivel;
Console.WriteLine("O consumo médio do automóvel é: "+consumo);