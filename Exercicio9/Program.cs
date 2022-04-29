/*
 * 9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
do que ou igual às duas prestações, que devem ser iguais, inteiras e as maiores possíveis. 
Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00; 
se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
da entrada e das duas prestações, de acordo com as regras acima. 
Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
conseqüente pagamento dos boletos das duas prestações.
*/

Console.WriteLine("Digite o valor da compra");
float valor = float.Parse(Console.ReadLine());

float entrada;
int prestacao1, prestacao2;

if (valor%3 == 0)
{
    entrada = valor/3;
    prestacao1 = (int)entrada;
    prestacao2 = (int)entrada;
}
else
{
    entrada = valor / 3 + (valor % 3);
    float resto = valor - entrada;
    prestacao1 = (int)resto / 2;
    prestacao2 = prestacao1;
}

Console.WriteLine("Entrada: " + entrada + "\nPrestação 1: " + prestacao1 + "\nPrestação 2: " + prestacao2);




