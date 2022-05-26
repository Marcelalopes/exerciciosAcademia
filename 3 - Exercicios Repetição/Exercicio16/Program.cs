//16.Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
//multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
//(N*3; N * 3 * 3; N * 3 * 3 * 3; etc).
int n;
double produto = 0;
Console.WriteLine("Digite um número entre 1 e 50: ");
n = int.Parse(Console.ReadLine());
do
{    
    if (n >0 && n <= 50)
    {
        produto += (n * 3);
    }
} while (produto < 250);
Console.WriteLine(produto);