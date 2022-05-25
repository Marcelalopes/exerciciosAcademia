// 4 . Faça um algoritmo que leia uma lista de números inteiros positivos terminada pelo número 0 (zero). 
//Ao final, o algoritmo deve mostrar a média aritmética de todos os números lidos (excluindo o zero).

List<int> numeros = new List<int>();
int num;
double media=0;

do
{
    Console.WriteLine("Digite um número positivo: ");
    num = int.Parse(Console.ReadLine());
    numeros.Add(num);
} while (num != 0);

for (int i = 0; i < numeros.Count; i++)
{
    media += numeros[i];
}
media /= numeros.Count;
Console.WriteLine(media);
