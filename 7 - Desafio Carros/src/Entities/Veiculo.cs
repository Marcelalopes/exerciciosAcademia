namespace Desafio_Carros.src.Entities
{
    public class Veiculo
    {
        string placa;
        DateTime dataHoraEntrada;

        public Veiculo(){}
        public Veiculo(string placa, DateTime data)
        {
            this.Placa = placa;
            this.DataHoraEntrada = data;
        }

        public string Placa { get => placa; set => placa = value; }
        public DateTime DataHoraEntrada { get => dataHoraEntrada; set => dataHoraEntrada = value; }
    }
}