// 1.	Faça um programa que leia um número inteiro n, inteiro e positivo e mostre a seguinte soma: S = 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5....1 / n
int n;
double S = 1;
Console.WriteLine("Digite um número inteiro: ");
n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    S += 1 / i;
}
Console.WriteLine("S = "+S);

