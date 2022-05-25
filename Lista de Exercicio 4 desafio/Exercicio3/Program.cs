// 3.	Dado um limite inferior e superior, calcule a soma de todos os números pares contidos nesse intervalo.

int lm_i, lm_s, soma=0;

Console.WriteLine("Digite o limite inferior e superior: ");
lm_i = int.Parse(Console.ReadLine());
lm_s = int.Parse(Console.ReadLine());

for (int i = lm_i; i < lm_s; i++)
{
    if( i%2 == 0)
    {
        soma += i;
    }
}
Console.WriteLine(soma);