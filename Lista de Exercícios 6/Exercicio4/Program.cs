//#4 Imagine um jogo com asteroides e uma nave de ataque, que deve destruir os asteróides que voam em todas as direções.

//Dessa forma, crie um programa em C# que represente uma lista de asteroides que deveriam ser 'inseridos' no jogo.

//Para isso, faça uma classe que contenha os atributos (privados) posição x, posição y (do asteroide em
//um plano cartesiano), tamanho do asteroide(1 a 10), velocidade do asteroide(1 a 5) e energia(1 a 5).

//Para esses atributos privados, gerar os métodos de acesso (propriedades getter e setter).

//Além disso, implementar 3 construtores (sobrecarga): um vazio, outro passando todos os parâmetros de um objeto tipo
//Asteroide, e um terceiro que constrói um asteroide com posição x e posição y.

//O programa principal (main) deve conter a lista de Asteroides, preenchida pelo usuário. Nesse programa principal,
//construir um método de classe que exiba todos os asteróides da lista.

using Exercicio4;

List<Asteroide> listA = new List<Asteroide>();
int px = 0, py = 0, tam = 0, velo = 0, ener = 0;
for (int i = 0; i < 3; i++)
{
    Console.Clear();
    Console.WriteLine("Digite a posição X: ");
    px = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a posição Y: ");
    py = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o tamanho do asteroide (1 a 10): ");
    tam = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a velocidade (1 a 5): ");
    velo = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a energia (1 a 5): ");
    ener = int.Parse(Console.ReadLine());
    listA.Add(new Asteroide(px,py,tam,velo,ener));
}
for (int i = 0; i < listA.Count; i++)
{
    Console.WriteLine(listA[i].ExibirAsteroides());
}