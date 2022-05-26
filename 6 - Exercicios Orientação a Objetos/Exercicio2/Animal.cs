using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Animal
    {
        private string name;
        private string type;

        public Animal() { }
        public Animal(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Name}\nTipo: {Type}\n");
        }
    }
}
