using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_ConexaoComBanco
{
    class Usuario
    {
        int idUsuario;
        string nomeCompleto;
        string email;

        public Usuario(int idUsuario, string nomeCompleto, string email)
        {
            this.IdUsuario = idUsuario;
            this.NomeCompleto = nomeCompleto;
            this.Email = email;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NomeCompleto { get => nomeCompleto; set => nomeCompleto = value; }
        public string Email { get => email; set => email = value; }

        public static string gerarEmail(string nome)
        {
            string[] vetorDados = nome.ToLower().Split(' ');
            if (vetorDados.Length < 2)
            {
                return vetorDados[0]+"@ufn.edu.br";
            }
            else
            {
                return vetorDados[0] + vetorDados[vetorDados.Length - 1] + "@ufn.edu.br";
            }
        }
    }
}
