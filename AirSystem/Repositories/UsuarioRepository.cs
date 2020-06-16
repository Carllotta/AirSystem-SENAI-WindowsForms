using AirSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Repositories
{
    class UsuarioRepository
    {
        private static List<Usuario> ListUsers;

        public UsuarioRepository()
        {
            if(ListUsers == null)
            {
                ListUsers = new List<Usuario>();

                ListUsers.Add(new Usuario
                {
                    
                    Nome = "Carla",
                    Sobrenome = "Dias",
                    Nascimento = Convert.ToDateTime("22/05/1997"),
                    Endereco = "Hermes da Fonseca",
                    Numero = "325",
                    NomeUsuario = "adm",
                    Senha = "adm123",
                    TipoUsuario = true // logo é adm
                });
                
                ListUsers.Add(new Usuario
                {
                    Nome = "Isabella",
                    Sobrenome = "Galbero",
                    Nascimento = Convert.ToDateTime("03/03/1987"),
                    Endereco = "Rua Lydia Damus",
                    Numero = "128",
                    NomeUsuario = "comum",
                    Senha = "comum123",
                    TipoUsuario = false // logo não é adm
                });
            }
        }

        public List<Usuario> ListarTodos()
        {
            return ListUsers;
        }

        public Usuario LoginUser(string nomeUser, string senha)
        {
            
           return ListUsers.Find(u => u.NomeUsuario == nomeUser && u.Senha == senha);
           
        }

        public void CadastrarUsuario(Usuario novoUser)
        {
            ListUsers.Add(novoUser);

        }


    }
}
