/* 17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses 
 * lados podem ou não formar um triangulo. Para que os lados formem um triângulo, todos os lados devem ser 
 * menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é 
 * equilátero (todos os lados iguais), isoceles (somente 2 lados são iguais) ou escaleno 
 * (os 3 lados são diferentes).*/

double ladoA, ladoB, ladoC;

Console.WriteLine("Digite os 3 lados de um triângulo: ");
ladoA = double.Parse(Console.ReadLine());
ladoB = double.Parse(Console.ReadLine());
ladoC = double.Parse(Console.ReadLine());

if (ladoA <= ladoB + ladoC)
{
    if (ladoB <= ladoC + ladoA)
    {
        if (ladoC <= ladoB + ladoA)
        {
            Console.WriteLine("forma triângulo");
            if (ladoA == ladoB && ladoC == ladoB)
            {
                Console.WriteLine("Equilátero");
            }
            else if (ladoA == ladoB && ladoA != ladoC)
            {
                Console.WriteLine("Isóceles");
                if (ladoB == ladoC && ladoB != ladoA)
                {
                    Console.WriteLine("Isóceles");
                }
                else if (ladoA == ladoC && ladoA != ladoB)
                {
                    Console.WriteLine("Isóceles");
                }
            }
            else
            {
                Console.WriteLine("Escaleno");
            }
        }
        else
        {
            Console.WriteLine("Não forma triângulo");
        }
    }
    else
    {
        Console.WriteLine("Não forma triângulo");
    }
}
else
{
    Console.WriteLine("Não forma triângulo");
}

