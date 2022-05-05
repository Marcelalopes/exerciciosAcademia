/*
 * 7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.
*/

Console.WriteLine("Número do vendedor:");
int num_vend = int.Parse(Console.ReadLine());

Console.WriteLine("Salário fixo do vendedor:");
float sal_fix = float.Parse(Console.ReadLine());

Console.WriteLine("Total de vendas feitas pelo vendedor:");
int total_vendas = int.Parse(Console.ReadLine());

Console.WriteLine("Percentual por total de venda:");
float per_venda = float.Parse(Console.ReadLine());

float acrescimo = (total_vendas * per_venda)/100;
float sal_total = sal_fix + acrescimo;

Console.WriteLine("Número do vendedor " + num_vend + " Salário total "+sal_total);