using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class ItemCenario
    {
        private string Descricao;
        private DateTime DataCriacao;
        private float Altura;

        public string Descricao1 { get => Descricao; set => Descricao = value; }
        public DateTime DataCriacao1 { get => DataCriacao; set => DataCriacao = value; }
        public float Altura1 { get => Altura; set => Altura = value; }

        public ItemCenario(string desc, DateTime dataC, float alt)
        {
            this.Descricao1 = desc;
            this.DataCriacao1 = dataC;
            this.Altura1 = alt;
        }

        public string ExibirItem()
        {
            return "Descrição: " + this.Descricao1 + "\nData de criação: " + this.DataCriacao1 + "\nAltura: " + Altura1 + "\n----";
        }

        public void TempoCriacao()
        {
            Console.Write("Este item foi criado há ");
            Console.Write(DateTime.Now - this.DataCriacao1);
        }
    }
}
