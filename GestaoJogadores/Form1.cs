using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoJogadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StreamReader leitor = new StreamReader("jogadores.dat");
            String linhas;
            String[] vetorDados;
            do
            {
                linhas = leitor.ReadLine();
                vetorDados = linhas.Split(';');
                listaJogadores.Add(new Jogador(vetorDados[0], vetorDados[1]));
                textBox_lista.AppendText(vetorDados[0]+" - "+vetorDados[1]+Environment.NewLine);
            } while (!leitor.EndOfStream);
            leitor.Close();
        }

        private void gravar_click(object sender, MouseEventArgs e)
        {
            if (textBox_nome.Text.Equals(""))
            {
                MessageBox.Show("é preciso digitar o nome completo!","Alerta");
            }

            textBox_nome.Text = textBox_nome.Text.ToUpper();
            String email;
            if(Jogador.jaCadastrado(textBox_nome.Text, listaJogadores))
            {
                MessageBox.Show("Jogador já cadastrado", "Alerta");
            }else
            {
                String[] vetorNomes = textBox_nome.Text.ToLower().Split(' ');
                if (vetorNomes.Length > 1)
                {
                    email = vetorNomes[vetorNomes.Length - 1] + "." + vetorNomes[0] + "@ufn.edu.br";
                }else
                {
                    email = vetorNomes[0] + "@ufn.edu.br";
                }
                listaJogadores.Add(new Jogador(textBox_nome.Text, email));
                textBox_lista.AppendText(textBox_nome.Text + " - " + email+Environment.NewLine);

                StreamWriter escritor = new StreamWriter("jogadores.dat", true);

                escritor.WriteLine(textBox_nome.Text+";"+email);

                escritor.Close();
            }
            textBox_nome.Text = "";
        }

        private void limpar_click(object sender, MouseEventArgs e)
        {
            textBox_nome.Text = "";
            textBox_lista.Text = "";
            listaJogadores.Clear();
        }
        List<Jogador> listaJogadores = new List<Jogador>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
