/* 9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
*diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
*Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
*Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.
*Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
*menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
*150, avisá-lo que será necessário adicionar 2 unidades de insulina.
*/

double val_glic1, val_glic2, val_glic3, media;

Console.WriteLine("Qual o primeiro valor da glicemia em jejum?");
val_glic1 = double.Parse(Console.ReadLine());

if (val_glic1 < 65.00)
{
    Console.WriteLine("Corre risco de hipoglicemia!");
}
else if (val_glic1 > 250.00)
{
    Console.WriteLine("Corre risco de hiperglicemia!");
}

Console.WriteLine("Qual o segundo valor da glicemia em jejum?");
val_glic2 = double.Parse(Console.ReadLine());

if (val_glic2 < 65.00)
{
    Console.WriteLine("Corre risco de hipoglicemia!");
}
else if (val_glic2 > 250.00)
{
    Console.WriteLine("Corre risco de hiperglicemia!");
}

Console.WriteLine("Qual o terceiro valor da glicemia em jejum?");
val_glic3 = double.Parse(Console.ReadLine());

if (val_glic3 < 65.00)
{
    Console.WriteLine("Corre risco de hipoglicemia!");
}
else if (val_glic3 > 250.00)
{
    Console.WriteLine("Corre risco de hiperglicemia!");
}

media = (val_glic1 + val_glic2 + val_glic3) / 3;
if (media < 80)
{
    Console.WriteLine("Você deve diminuir duas unidades de insulina");
}
else if (media > 150)
{
    Console.WriteLine("Você deve aumentar duas unidades de insulina");
}