/*8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
*Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
*Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
*E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
*total de vendas. 
*/

int cod;
string nome;
double sal_base, total_vendas, sal_total;

Console.WriteLine("Digite o código do funcionário: ");
cod = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o nome do funcionário: ");
nome = Console.ReadLine();
Console.WriteLine("Digite o salário base do funcionário: ");
sal_base = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o total de vendas do funcionário: ");
total_vendas = double.Parse(Console.ReadLine());

if(total_vendas > 500.0 && total_vendas < 1000.00)
{
    sal_total = sal_base + (total_vendas * 0.05);
    Console.WriteLine("Código: "+cod+"\nNome: "+nome+"\nSalário Total: "+sal_total);
}
else if (total_vendas > 1000.00 && total_vendas < 5000.00)
{
    sal_total = sal_base + (total_vendas * 0.07);
    Console.WriteLine("Código: " + cod + "\nNome: " + nome + "\nSalário Total: " + sal_total);
}
else if (total_vendas > 5000.0)
{
    sal_total = sal_base + (total_vendas * 0.1);
    Console.WriteLine("Código: " + cod + "\nNome: " + nome + "\nSalário Total: " + sal_total);
}