/*
 * 6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B,
 * isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem 
 * de IPI (única) a ser acrescentada.
 */

Console.WriteLine("Parafuso A");
Console.WriteLine("Digite o código: ");
int codA = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de peças a ser comprada: ");
int qtdA = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor unitário do parafuso A: ");
float val_uniA = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a porcentagem de IPI a ser acrescentada: ");
float porcentagemA = float.Parse(Console.ReadLine());

float IPIA = (val_uniA*qtdA) * (porcentagemA/100);
float totalA = (val_uniA * qtdA) + IPIA;

Console.WriteLine("Parafuso A\nCódigo: "+ codA+"\nQuantidade: "+qtdA+"\nValor Unitário: "+val_uniA+"\nIPA: "+IPIA+"\nTotal: "+totalA);

Console.WriteLine("Parafuso B");
Console.WriteLine("Digite o código: ");
int codB = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de peças a ser comprada: ");
int qtdB = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor unitário do parafuso B: ");
float val_uniB = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a porcentagem de IPI a ser acrescentada: ");
float porcentagemB = float.Parse(Console.ReadLine());

float IPIB = (val_uniB * qtdB) * (porcentagemB / 100);
float totalB = (val_uniB * qtdB) + IPIB;

Console.WriteLine("Parafuso B\nCódigo: " + codB + "\nQuantidade: " + qtdB + "\nValor Unitário: " + val_uniB + "\nIPA: " + IPIB + "\nTotal: " + totalB);


