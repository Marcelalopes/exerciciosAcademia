//15.Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
//ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente. 
//Considerar nota 7,0 como mínima para aprovação.
List<double> notas = new List<double>();
double nota, media=0;
Console.WriteLine("Digite suas notas: ");
for (int i = 0; i < 4; i++)
{
    nota = double.Parse(Console.ReadLine());
    notas.Add(nota);
}
media = (notas[0] * 2)+(notas[1]*1)+(notas[2]*2)+(notas[3]*4)/(2+1+2+4);
if (media >= 7.0)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado");
}