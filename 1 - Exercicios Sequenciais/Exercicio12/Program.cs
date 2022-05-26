/*
 * 12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do 
 * combustível é de R$6,90, escreva um algoritmo para ler a marcação do odômetro (marcador de quilometragem) 
 * no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) 
 * recebido dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.
*/

double preco_combustivel = 6.90;

Console.WriteLine("Digite a marcação inicial do odômetro: ");
double odometro_inicial = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a marcação final do odômetro: ");
double odometro_final = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o total de combustível gasto: ");
double combustivel_gasto = double.Parse(Console.ReadLine());

Console.WriteLine("Montante em dinheiro recebido do dia: ");
double valor_total = double.Parse(Console.ReadLine());

double km = odometro_final - odometro_inicial;
double consumo = km / combustivel_gasto;
double lucro_liquido = valor_total - (combustivel_gasto * preco_combustivel);

Console.WriteLine("O consumo médio é de "+consumo+"Km/L"
    +"\nO lucro líquido é de "+lucro_liquido+" reais");