/*1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da 
 * altura lidos pelo teclado: Área do triangulo = (base * altura) / 2; Teste se a base ou a altura digitada
 * não foi igual a zero. */

double b, altura, area;
Console.WriteLine("Digite a base do triângulo e em seguida digite a altura: ");
b = double.Parse(Console.ReadLine());
altura = double.Parse(Console.ReadLine());

if (b != 0 && altura != 0)
{
    area = (b * altura) / 2;
    Console.WriteLine("A área do triângulo é: " + area);
}
else
{
    Console.WriteLine("Os números digitados devem ser diferente de zero!");
}
