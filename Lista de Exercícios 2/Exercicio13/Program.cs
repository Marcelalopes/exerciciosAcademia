/*13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
seu peso ideal, utilizando as seguintes fórmulas:
Para homens: (72.7 * h) - 58
Para mulheres: (62.1 * h) - 44.7
*/

char sexo;
double h,peso_ideal;
Console.WriteLine("Digite sua altura: ");
h = double.Parse(Console.ReadLine());
Console.WriteLine("Qual é o seu sexo(F/M): ");
sexo = char.Parse(Console.ReadLine());

if (sexo == 'M')
{
    peso_ideal = (72.7 * h) - 58;
    Console.WriteLine("Peso ideal: "+peso_ideal);
}
else if (sexo == 'F')
{
    peso_ideal = (62.1 * h) - 44.7;
    Console.WriteLine("Peso ideal: " + peso_ideal);
}
