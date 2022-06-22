using AulaSexta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbFabricante.Clear();
            tbModelo.Clear();
            cbPortas.ResetText();

            foreach (int checados in clbOpcionais.CheckedIndices)
            {
                clbOpcionais.SetItemChecked(checados, false);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            bool ac = false, dh = false, abs = false, ve = false, ab = false;
            int portas;
            foreach (string opc in clbOpcionais.CheckedItems)
            {
                if (opc == "Ar condicionado")
                {
                    ac = true;
                }
                if (opc == "Direção hidráulica")
                {
                    dh = true;
                }
                if (opc == "Freios ABS")
                {
                    abs = true;
                }
                if (opc == "Vidros elétricos")
                {
                    ve = true;
                }
                if (opc == "Air bag")
                {
                    ab = true;
                }
            }
            portas = 0;
            if (cbPortas.Text == "2 portas") portas = 2;
            else if (cbPortas.Text == "3 portas") portas = 3;
            else if (cbPortas.Text == "4 portas") portas = 4;
            else if (cbPortas.Text == "5 portas") portas = 5;
            Carro c = new Carro(tbModelo.Text, tbFabricante.Text, ac, dh, abs, ab, ve, portas);
            c.MostrarDadosCarro();
        }
    }
    }
}
