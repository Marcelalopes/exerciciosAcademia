/* 1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois 
 * números quaisquer. */

double n1;
double n2;
double media;

Console.WriteLine("Digite n1: ");
n1 = Double.Parse(Console.ReadLine());

Console.WriteLine("Digite n2: ");
n2 = Double.Parse(Console.ReadLine());

media = (n1 + n2) / 2;

Console.WriteLine(media);


