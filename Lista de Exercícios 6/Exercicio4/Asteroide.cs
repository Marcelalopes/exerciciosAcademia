using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Asteroide
    {
        private int Posix;
        private int Posiy;
        private int Tamanho;
        private int Velocidade;
        private int Energia;

        public int Posix1 { get => Posix; set => Posix = value; }
        public int Posiy1 { get => Posiy; set => Posiy = value; }
        public int Tamanho1 { get => Tamanho; set => Tamanho = value; }
        public int Velocidade1 { get => Velocidade; set => Velocidade = value; }
        public int Energia1 { get => Energia; set => Energia = value; }

        public Asteroide()
        {

        }
        public Asteroide(int posix, int posiy, int tamanho, int velocidade, int energia)
        {
            this.Posix1 = posix;
            this.Posiy1 = posiy;
            this.Tamanho1 = tamanho;
            this.Velocidade1 = velocidade;
            this.Energia1 = energia;
        }
        public Asteroide(int posix, int posiy)
        {
            this.Posix1 = posix;
            this.Posiy1 = posiy;
        }

        public string ExibirAsteroides()
        {
            return "Posição X: "+this.Posix1 + "\nPosição Y: " + this.Posiy1+"\nTamanho do asteroide: "+this.Tamanho1+"\nVelocidade: "+this.Velocidade1+"\nEnergia: "+this.Energia1+"\n--------";
        }
    }
}
