/*
 * 4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.
*/

int ano, mes, dia;

Console.WriteLine("Digite o dia: ");
dia = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o mês: ");
mes = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o ano: ");
ano = int.Parse(Console.ReadLine());

DateTime date = new DateTime(ano, mes, dia);

Console.WriteLine(date.ToString("yyyy-mm-dd"));
Console.WriteLine(date.ToString("yy-mm-dd"));
