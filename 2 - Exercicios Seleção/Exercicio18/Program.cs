// 18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

int a, b, c;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());

if (a > b && a > c)
{
    Console.WriteLine(a);
}
else if (b > c && b > a)
{
    Console.WriteLine(b);
}
else
{
    Console.WriteLine(c);
}
