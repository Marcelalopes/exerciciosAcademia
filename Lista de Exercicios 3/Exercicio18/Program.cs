// 18. Elaborar um programa que apresente o valor de uma potência de uma base qualquer 
// elevada a um expoente qualquer, ou seja, NM.

Random rnd = new Random();
int n = rnd.Next(1,10);
int m = rnd.Next(1,10);
double potencia = Math.Pow(n, m);
Console.WriteLine(potencia);



