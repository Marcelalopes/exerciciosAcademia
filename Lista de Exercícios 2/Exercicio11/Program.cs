/*11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para 
 * minutos).O programa deve exibir se a hora digitada está ou não válida. Lembre que usaremos o padrão 
 * de hora com 24h, de 0 a 23.
*/

int hora, min;
Console.WriteLine("Digite o valor da hora: ");
hora = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor dos minutos: ");
min = int.Parse(Console.ReadLine());
if (hora >= 0 && hora < 24 && min >= 0 && min < 60)
{
    Console.WriteLine("A hora é válida");
}
else
{
    Console.WriteLine("A hora é inválida");
}
