/* 15 - Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados 
e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.
*/
double m2, preco_total, qtd_latas, litros;
Console.WriteLine("Area a ser pintada em metros quadrados: ");
m2 = double.Parse(Console.ReadLine());

litros = m2/3;
qtd_latas = litros/18;
preco_total = 80.00 * qtd_latas;
Console.WriteLine("Quantidade de latas a serem compradas: "+qtd_latas+"\nPreço total: "+preco_total);
