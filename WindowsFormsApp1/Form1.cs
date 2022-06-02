using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Cliquei no botão OK");
            MessageBox.Show("O nome digitado pelo usuário é: "+tbNome.Text+"\ne-mail digitado foi: "+tbEmail.Text+"\nendereço digitado: "+tbEndereco.Text+"\ntelefone digitado: "+tbTelefone.Text+"\nbairro digitado: "+tbBairro.Text+"\ncidade digitada: "+tbCidade.Text+"\nsexo digitado: "+tbSexo.Text);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Cliquei no botão Cancelar");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void tbSexo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
