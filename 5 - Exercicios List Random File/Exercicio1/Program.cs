/* 1) Fazer um programa em VS que gere uma lista com n valores randômicos e inteiros para glicemia (entre 45 a 500). 
O programa deve calcular média, valor mínimo, valor máximo e mediana.
Sugere-se criar um menu como:

MENU
1 - Gerar lista
2 - Exibir lista
3 - Mostrar medidas centrais (média, valores min e max e mediana)
4 - Sair
Opção: ____

Observação, toda vez que a opção 1 for acionada, o usuário deve definir quantos números serão gerados na lista */
List<int> valGlicemia = new List<int>();
int op;

do
{
    Console.WriteLine("MENU");
    Console.WriteLine(
        "1 - Gerar lista\n"+
        "2 - Exibir lista\n"+
        "3 - Mostrar medidas centrais (média, valores min e max e mediana)\n"+
        "4 - Sair"
    );

    Console.WriteLine("Opção: ");
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            Console.WriteLine("Gerando Lista...");
            try
            {
                String nomeArquivo = @"E:\Academia .Net\exerciciosAcademia\5 - Exercicios List Random File\Exercicio1\bin\Debug\net6.0\glicemia.txt";
                StreamReader leitor = new StreamReader(nomeArquivo);

                do
                {
                    Console.WriteLine("Quantos valores você quer gerar na lista?");
                    int qtd = int.Parse(Console.ReadLine());

                    Random gerardorValores = new Random();
                    for (int i = 0; i < qtd; i++)
                    {
                        valGlicemia.Add( gerardorValores.Next(45,500));
                    }
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ao ler o arquivo: "+e.Message+"\n"+e.Source);
            }
            Console.ReadKey();
            break;
        case 2:
            Console.WriteLine("Exibindo Lista...");
            if (valGlicemia.Count == 0)
            {
                Console.WriteLine("Lista Vazia!");
            }else{
                for (int i = 0; i < valGlicemia.Count; i++)
                {
                    Console.WriteLine(valGlicemia[i]);
                }
            }
            Console.ReadKey();
            break;
        case 3:
            Console.WriteLine("Médias Centrais");
            if (valGlicemia.Count == 0) {
                Console.WriteLine("Lista Vazia!");
            } else {
                float media;
                int min;
                int max;
                float mediana;

                List<int> listaTmp = new List<int>();
                listaTmp.AddRange(valGlicemia);
                listaTmp.Sort();
                min = listaTmp[0];
                max = listaTmp[ listaTmp.Count - 1 ];
                int soma = 0;
                foreach (int i in listaTmp){
                    soma += i;
                }
                media = soma / listaTmp.Count;

                int meio = (int)listaTmp.Count / 2;
                if (listaTmp.Count % 2 != 0) { 
                    mediana = listaTmp[meio];
                } else { 
                    mediana  = listaTmp[meio] + listaTmp[meio - 1] / 2;
                }
                
                Console.WriteLine("A mediana de valores da lista é: " + mediana);
                Console.WriteLine("A média de valores da lista é: " + media);
                Console.WriteLine("O valor min da lista é: " + min);
                Console.WriteLine("O valor max da lista é: " + max);
            }
            Console.ReadKey();
            break;
        case 4:
            break;     
        default:
            Console.WriteLine("Opção Inválida!");
            Console.ReadKey();
            break;
    }

} while (op != 4);

