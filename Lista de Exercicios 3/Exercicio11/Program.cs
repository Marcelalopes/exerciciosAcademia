//11.Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa,
//a média aritmética da turma e a quantidade de alunos da turma. Usar como flag a nota 12.

double nota = 0, notaMaior = 0, notaMenor = 12, media, somNotas = 0;
int qtdAlunos;

Console.WriteLine("Quantidade de alunos na turma: ");
qtdAlunos = int.Parse(Console.ReadLine());

for (int i = 0; i < qtdAlunos; i++)
{
    Console.WriteLine("Digite a nota do aluno: ");
    nota = double.Parse(Console.ReadLine());
    somNotas += nota;
    if(nota > notaMaior)
    {
        notaMaior = nota;
    }
    if(nota < notaMenor)
    {
        notaMenor = nota;
    }
}
media = somNotas / qtdAlunos;

