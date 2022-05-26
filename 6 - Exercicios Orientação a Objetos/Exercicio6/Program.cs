//#6 Crie uma classe para representar um objeto em um Plano Cartesiano. 
//Todo objeto no plano cartesiano tem como atributos 'x' e 'y'. Dessa forma, crie os getters e setter de 'x' e 'y', 
//o construtor básico e um método para exibir um objeto (x, y).
//Por fim, crie um programa em C# que cadastre 'n' objetos em uma lista (List), um método de que exiba
//os objetos da lista.

using Exercicio6;

List<PlanoCartesiano> listP = new List<PlanoCartesiano>();
int n,x=0,y=0;

Console.WriteLine("Quantos objetos você deseja cadastrar?");
n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.Clear();
    Console.WriteLine("Digite o ponto x: ");
    x = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o ponto y: ");
    y = int.Parse(Console.ReadLine());

    listP.Add(new PlanoCartesiano(x,y));
}
for (int i = 0; i < listP.Count; i++)
{
    listP[i].ExibirDados();
}