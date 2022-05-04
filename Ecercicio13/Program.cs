/*
 * 13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 
 * 2 salários mínimos mensais, mais uma comissão de 15% sobre o preço de custo de cada bicicleta vendida. 
 * Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o 
 * número de bicicletas vendidas pelo vendedor, calcule e mostre: o salário do empregado
*/

Console.WriteLine("Qual o valor do salário mínimo?");
double sal_min = Double.Parse(Console.ReadLine());

Console.WriteLine("Qual o preço de custo da bicicleta?");
double custo = Double.Parse(Console.ReadLine());

Console.WriteLine("Qual o número de bicicletas vendidas pelo vendedor?");
int qtdVendida = int.Parse(Console.ReadLine());

double comissao = custo * 0.15 * qtdVendida;
double salario = (2 * sal_min) + comissao;

Console.WriteLine("Salário do vendedor: "+salario);