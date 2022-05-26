// 5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” se a
// média das duas notas for maior ou igual a 7,0. Caso a média seja inferior a 7,0, o programa deve ler a
// nota do exame e calcular a média final. Se esta média for maior ou igual a 5,0, o programa deve escrever
// “Aprovado”, caso contrário deve escrever “Reprovado”.

Console.WriteLine("Digite duas notas: ");
float nota1 =float.Parse(Console.ReadLine());
float nota2 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2) / 2;

if (media >= 7)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Digite a nota do exame final: ");
    float exame = float.Parse(Console.ReadLine());
    float media_final = (exame + media)/2;
    if (media_final >= 5)
    {
        Console.WriteLine("Aprovado");
    }
    else
    {
        Console.WriteLine("Reprovado");
    }
}

