//3) Fazer um programa parecido com o número 1, porém, os dados devem vir de um arquivo texto (um valor abaixo do outro).

//Por exemplo,
//glicemia.txt 
//123
//200
//98
//45
//122
//100
//90
//98


//Também sugere-se usar um menu

//MENU
//1 - Abrir arquivo com dados de glicemia e popular lista
//2 - Exibir lista
//3 - Mostrar medidas centrais (média, valores min e max e mediana)
//4 - Sair
//Opção: ____
List<int> valGlicemia = new List<int>();
int op;

do
{
    Console.WriteLine("MENU");
    Console.WriteLine(
        "1 - Abrir arquivo com dados de glicemia e popular lista\n" +
        "2 - Exibir lista\n" +
        "3 - Mostrar medidas centrais (média, valores min e max e mediana)\n" +
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
                String nomeArquivo = "glicemia.txt";
                StreamReader leitor = new StreamReader(nomeArquivo);
                int valorGlicemico;

                do
                {
                    Console.WriteLine("Qual o valor glicemico deseja adicionar?");
                    valorGlicemico = int.Parse(Console.ReadLine());
                    valGlicemia.Add(valorGlicemico);
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ao ler o arquivo: " + e.Message + "\n" + e.Source);
            }
            Console.ReadKey();
            break;
        case 2:
            Console.WriteLine("Exibindo Lista...");
            if (valGlicemia.Count == 0)
            {
                Console.WriteLine("Lista Vazia!");
            }
            else
            {
                for (int i = 0; i < valGlicemia.Count; i++)
                {
                    Console.WriteLine(valGlicemia[i]);
                }
            }
            Console.ReadKey();
            break;
        case 3:
            Console.WriteLine("Médias Centrais");
            if (valGlicemia.Count == 0)
            {
                Console.WriteLine("Lista Vazia!");
            }
            else
            {
                float media;
                int min;
                int max;
                float mediana;

                List<int> listaTmp = new List<int>();
                listaTmp.AddRange(valGlicemia);
                listaTmp.Sort();
                min = listaTmp[0];
                max = listaTmp[listaTmp.Count - 1];
                int soma = 0;
                foreach (int i in listaTmp)
                {
                    soma += i;
                }
                media = soma / listaTmp.Count;

                int meio = (int)listaTmp.Count / 2;
                if (listaTmp.Count % 2 != 0)
                {
                    mediana = listaTmp[meio];
                }
                else
                {
                    mediana = listaTmp[meio] + listaTmp[meio - 1] / 2;
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