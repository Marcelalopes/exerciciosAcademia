using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace _9_ConexaoComBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string conexaoString = ConfigurationManager.ConnectionStrings["UsuariosDBString"].ConnectionString;

        private void carregarListView()
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                string sqlTexto = "SELECT idUsuario, nomeCompleto, email FROM usuario";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);

                lvUsuarios.Items.Clear();
                SqlDataReader leitor = comando.ExecuteReader();
                int i = 0;
                while(leitor.Read())
                {
                    lvUsuarios.Items.Add(leitor["idUsuario"].ToString());
                    lvUsuarios.Items[i].SubItems.Add(leitor["nomeCompleto"].ToString());
                    lvUsuarios.Items[i].SubItems.Add(leitor["email"].ToString());
                    i++;
                }
                conexao.Close();
                btConectar.Enabled = false;
                MessageBox.Show("Banco conectado com sucesso!", "Atenção");
            }
            catch (Exception e)
            {
                MessageBox.Show("Problemas de conexão com o Banco de Dados\n" + e.Message.ToString(), "Alerta");
            }
        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            carregarListView();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //capturar valores das variáveis
                int idUsuario = int.Parse(tbId.Text);
                string nomeCompleto = tbNome.Text;
                string email = Usuario.gerarEmail(tbNome.Text);

                //gerar sentenças SQL
                string sqlTexto = "INSERT INTO usuario (idUsuario, nomeCompleto, email) VALUES(@idUsuario, @nomeCompleto, @email)";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                comando.Parameters.AddWithValue("@nomeCompleto", nomeCompleto);
                comando.Parameters.AddWithValue("@email", email);

                //executar sentença SQL
                comando.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show("Problemas com o banco\n" + error.Message.ToString(), "Alerta");
            }

            conexao.Close();

            //recarregar ListView
            carregarListView();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                int idUsuario = int.Parse(lvUsuarios.SelectedItems[0].Text);

                //gerar sentenças SQL
                string sqlTexto = "DELETE FROM usuario WHERE idUsuario = @idUsuario";

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idUsuario", idUsuario);

                //executar sentença SQL
                if (comando.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Remoção realizada com sucesso!");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Problemas com o banco\n" + er.Message.ToString(), "Alerta");
            }

            conexao.Close();

            //recarregar ListView
            carregarListView();
        }
    }
}
