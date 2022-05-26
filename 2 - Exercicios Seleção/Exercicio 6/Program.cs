/* 6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura 
 * (metros) e o peso (kg) de uma pessoa. O programa deve calcular o Indice de Massa Corpórea (IMC), 
 * exibi-lo ao usuário e informar sua situação conforme a tabela.O cálculo do imc = peso / (altura * altura)
 *
 * IMC 
*menor que 18                -> baixo peso
*maior que 18 e menor que 25 -> peso normal
*maior que 25 e menor que 30 -> sobrepeso
*maior que 30 e menor que 35 -> obesidade
*maior que 35                -> obesidade grau sério
*/

string name;
double altura, peso, imc;

Console.WriteLine("Digite seu nome: ");
name = Console.ReadLine();
name = name.ToUpper();

Console.WriteLine("Digite seu peso e sua altura: ");
peso = Double.Parse(Console.ReadLine());
altura = Double.Parse(Console.ReadLine());
imc = peso / (altura * altura);

if (imc < 18)
{
    Console.WriteLine(name + " você está abaixo do peso, IMC = " + imc);
}
else if (imc > 18 && imc < 25)
{
    Console.WriteLine(name + " você está no peso normal, IMC = " + imc);
}   
else if (imc > 25 && imc < 30)
{
    Console.WriteLine(name + " você está sobrepeso, IMC = " + imc);
}
else if (imc > 30 && imc < 35)
{
    Console.WriteLine(name + " você está obeso, IMC = " + imc);
}
else
{
    Console.WriteLine(name+" você está obeso grau II, IMC = "+ imc);
}

