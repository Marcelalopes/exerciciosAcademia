/*
 * 8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
A fórmula da conversão é F=(9*C+160)/5.
*/

Console.WriteLine("Digite a temperatura em Celsius");
float celsius = float.Parse(Console.ReadLine());

float fahrenheit = ((9 * celsius) + 160) / 5;

Console.WriteLine("Fahrenheit: "+fahrenheit);