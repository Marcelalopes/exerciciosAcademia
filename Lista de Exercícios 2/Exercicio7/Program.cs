/*7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
*O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
*exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.
*/

string frase, palavra;
Console.WriteLine("Digite uma frase qualquer: ");
frase = Console.ReadLine();
Console.WriteLine("Digite a palavra que deseja pesquisar: ");
palavra = Console.ReadLine();

if (frase.Contains(palavra))
{
    Console.WriteLine("A palavra foi encontrada na frase");
}
else
{
    Console.WriteLine("A palavra não foi encontrada na frase");
}
