using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroWindowsForms
{
    class Usuario
    {
        public Usuario(string name, string phone, string cPF, string login, string senha, bool status, string type)
        {
            Name = name;
            Phone = phone;
            CPF = cPF;
            Login = login;
            Senha = senha;
            Status = status;
            Type = type;
        }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string CPF { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Status { get; set; }
        public string Type { get; set; }

        public void MostrarDados()
        {
            string status = "";
            if (this.Status == true)
                status = "Ativo";
            else if (this.Status == false)
                status = "Inativo";
            MessageBox.Show(
                $"Nome = {this.Name}\n"+
                $"Telefone = {this.Phone}\n"+
                $"CPF = {this.CPF}\n"+
                $"Login = {this.Login}\n"+
                $"Senha = {this.Senha}\n"+
                $"Status = {status}\n"+
                $"Tipo = {this.Type}"
            );
        }
    }
}
