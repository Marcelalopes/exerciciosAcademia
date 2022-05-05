/* 
 * 3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
si os valores de duas variáveis A e B.
*/

int a, b, aux;

a = 3;
b = 4;

Console.WriteLine("Valores iniciais, a = "+ a + " b = "+b);

aux = a;
a = b;
b = aux;

Console.WriteLine("Valores finais, a = " + a + " b = " + b);