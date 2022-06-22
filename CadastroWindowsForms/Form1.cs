using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            bool status = true;
            if (cbStatus.Text == "Ativo")
                status = true;
            else if (cbStatus.Text == "Inativo")
                status = false;

            Usuario usuario = new Usuario(tbName.Text, tbTelefone.Text, tbCpf.Text, tbLogin.Text, tbSenha.Text, status, cbTipo.Text);
            usuario.MostrarDados();
        }
    }
}
