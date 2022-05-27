namespace Desafio_Carros.src.Entities
{
    public class Util
    {
        public static void exibirLista(List<Veiculo> listaV)
        {
            Console.WriteLine("Listando Veiculos...");
            foreach (Veiculo i in listaV)
            {
                Console.WriteLine(i.Placa+" - "+i.DataHoraEntrada);   
            }
        }

        public static void carregarLista(List<Veiculo> listV)
        {
            StreamReader leitor;
            string nomeArquivo = "garagem.dat";
            string [] vetorDados;
            try
            {
                leitor = new StreamReader(nomeArquivo);
                do
                {
                    vetorDados = leitor.ReadLine().Split(";");
                } while (!leitor.EndOfStream);
            }
            catch (Exception e)
            {
                Console.WriteLine("Arquivo de veiculos com problemas ou inexistente\n"+e.Message);
            }
        }

        private static void gravarArquivo(Veiculo v)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("garagem.dat", true);

                escritor.WriteLine(v.Placa +";"+v.DataHoraEntrada);
                escritor.Flush();
                escritor.Close();
            }
            catch (Exception e)
            {                
                Console.WriteLine("Arquivo de veículos com problemas\n"+e.Message);
            }
        }

        public static void cadastrarVeiculo (List<Veiculo> lista)
        {
            string placa;
            DateTime data;
            Console.WriteLine("Digite a placa do veiculo: ");
            placa = Console.ReadLine();
            Console.WriteLine("Digite a data de entrada do veiculo: ");
            data = DateTime.Parse(Console.ReadLine());

            Veiculo v = new Veiculo(placa, data);
            lista.Add(v);
            Util.gravarArquivo(v);
        }
    }
}