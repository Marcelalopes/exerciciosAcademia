//#2
//Crie um programa em C# no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. 
//O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e Peixes foram informados.

//Regras que deverão ser seguidas para a implementação do programa:

//Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
//Caso seja informado um tipo diferente o programa repetir até o usuário digitar um tipo válido.
//É obrigatório criar uma classe para representar o Animal.
//A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
//a classe deverá possuir métodos de acesso (propriedade getter e setter) para permitir que o usuário armazene/leia os dados dos dois dados privados (propriedades).

using Exercicio2;

string nome, tipo;
int qtdGato = 0, qtdCachorro = 0, qtdPeixe = 0;
List<Animal> listA = new List<Animal>();
for (int i = 0; i < 5; i++)
{
    while(true){
        Console.WriteLine("Qual o nome do seu animal?");
        nome = Console.ReadLine();
        Console.WriteLine("Qual o tipo do seu animal?(Cachorro/Gato/Peixe)");
        tipo = Console.ReadLine();
        if (tipo == "Gato" || tipo == "Cachorro" || tipo == "Peixe" || tipo == "gato" || tipo == "cachorro" || tipo == "peixe")
        {

            listA.Add(new Animal(nome, tipo));
            break;
        }
        else
        {
            Console.WriteLine("Valor inválido!");
        }
    }
    if (listA[i].Type == "Gato" || listA[i].Type == "gato")
    {
        qtdGato++;
    }
    else if (listA[i].Type == "Cachorro" || listA[i].Type == "cachorro")
    {
        qtdCachorro++;
    }
    else if (listA[i].Type == "Peixe" || listA[i].Type == "peixe")
    {
        qtdPeixe++;
    }
}
Console.WriteLine($"Quantidade de gatos: {qtdGato}\nQuantidade de cachorros: {qtdCachorro}\nQuantidade de peixes: {qtdPeixe}");