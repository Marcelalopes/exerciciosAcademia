//#5 Crie uma classe para representar um item de cenário, com os atributos privados de:
//    *descrição(string), 
//    *data de criação(date - https://docs.microsoft.com/en-us/dotnet/api/system.datetime.date?view=net-6.0) e
//    *altura(float).

//Crie os métodos públicos necessários para sets e gets, o construtor básico e também um método para imprimir 
//todos dados de um item de cenário. 
//Por fim, crie um método para calcular a quanto tempo o item foi criado, além de um programa em C# para testar a classe criada.

using Exercicio5;

string des;
DateTime dataC;
float altura;

Console.WriteLine("Digite a descrição do item: ");
des = Console.ReadLine();
Console.WriteLine("Digite a data de criação: ");
dataC = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Digite a altura do item: ");
altura = float.Parse(Console.ReadLine());
Console.Clear();

ItemCenario item = new ItemCenario(des, dataC, altura);

Console.WriteLine(item.ExibirItem());
item.TempoCriacao();