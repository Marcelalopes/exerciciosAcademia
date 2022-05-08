/* 12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
 * número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
 * R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento armazenando-o na 
 * variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
 * No final do processamento, exibir o salário total e o salário excedente do operário.
 */

int codigo;
double numeroHoras, sal, extra;

Console.WriteLine("Digite o código do funcionário e o número de horas trabalhadas: ");
codigo = int.Parse(Console.ReadLine());
numeroHoras = int.Parse(Console.ReadLine());
if (numeroHoras > 50)
{
    extra = (numeroHoras - 50)* 20.00;
    sal = 50 * 10.00;
    Console.WriteLine("Salario total: " + sal + "\nSalario excedente: " + extra);
}
else
{
    sal = numeroHoras * 10.00;
    Console.WriteLine("Salario total: " + sal);
}


