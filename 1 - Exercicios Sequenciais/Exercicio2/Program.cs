/* 2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética
 * entre quatro números quaisquer. */

float media, n1, n2, n3, n4;

Console.WriteLine("Digite n1: ");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite n2: ");
n2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite n3: ");
n3 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite n4: ");
n4 = float.Parse(Console.ReadLine());

media = (n1 + n2 + n3 + n4)/4;

Console.WriteLine(media);