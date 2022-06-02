/* 2) Fazer um programa em VS que permita o usuário cadastrar emails de clientes (em uma lista). 
Uma vez cadastrados os emails, o programa deve separar o nome de usuário (antes do @) do domínio do email 
(depois do @). Ao final, o programa deve exibir os domínios utilizados no cadastro (não pode exibir os repetidos).
Observação: os domínio são, por exemplo, gmail.com; yahoo.com.br; ufn.edu.br; hotmail.com; entre outros.

Sugere-se usar um menu como:

MENU 
1 - Cadastrar emails
2 - Mostrar lista de emails
3 - Mostrar dominíos de emails
4 - Sair
Opção:____ */

List<string> listEmails = new List<string>();
List<string> listDominios = new List<string>();
int op;
do
{
    Console.WriteLine(
        "Menu\n"+
        "1 - Cadastrar emails\n"+
        "2 - Mostrar lista de emails\n"+
        "3 - Mostrar dominíos de emails\n"+
        "4 - Sair"
    );
    Console.Write("Opção: ");
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            Console.WriteLine("Gerando lista...");
            string email;
            Console.WriteLine("Cadastre um email: ");
            email = Console.ReadLine().ToLower();
            if (listEmails.Contains(email))
            {
                Console.WriteLine("Email já cadastrado");
            }
            else
            {
                listEmails.Add(email);

                string[] emailSplit;
                string dominio;
                emailSplit = email.Split("@");
                dominio = emailSplit[1];
                if (!listDominios.Contains(dominio))
                {
                    listDominios.Add(dominio);
                }
                listDominios.Sort();
                Console.WriteLine("Email cadastrado com sucesso");
            }
            Console.ReadKey();
            break;
        case 2:
            Console.WriteLine("Exibindo lista de emails");
            if (listEmails.Count == 0)
            {
                Console.WriteLine("Lista Vazia!");
            }
            else
            {
                for (int i = 0; i < listEmails.Count; i++)
                {
                    Console.WriteLine(listEmails[i]);
                }
            }
            Console.ReadKey();
            break;
        case 3:
            Console.WriteLine("Mostrando domínios...");
            if (listDominios.Count == 0)
            {
                Console.WriteLine("Lista Vazia!");
            }
            else
            {
                for (int i = 0; i < listDominios.Count; i++)
                {
                    Console.WriteLine(listDominios[i]);
                }
            }
            Console.ReadKey();
            break;
        case 4:
            Console.WriteLine("Tchau, até a próxima!");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("Opção Inválida!");
            Console.ReadKey();
            break;
    }
} while (op != 4);
